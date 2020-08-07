using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;

namespace Disney1
{
    static class Global
    {
        public static Account User;

        public static BindingList<Room> BookRooms = new BindingList<Room>();

        public static DateTime CheckIn;

        public static DateTime CheckOut;

        public static List<RoomOrderDetail> OrderDetails;

        public static List<bool> Breakfast;

        public static List<bool> Storage;

        public static List<Guest> Guests;

        public static Guest OrderGuest;

        public static int GetToatlPrice()
        {
            return 0;
        }

        public static bool TimeIsOverlapping(DateTime Start, DateTime End, DateTime x, DateTime y)
        {
            // 取得開始時間轉換成總天數 當作起點(只有 TimeSpan 能取得總天數)
            // 取得開始時間到結束時間中間的天數 當作寬度(DateTime - DateTime = TimeSpan)
            Rectangle rec1 = new Rectangle(Convert.ToInt32(TimeSpan.FromTicks(Start.Ticks).TotalDays), 0, Convert.ToInt32((End - Start).TotalDays), 0);
            Rectangle rec2 = new Rectangle(Convert.ToInt32(TimeSpan.FromTicks(x.Ticks).TotalDays), 0, Convert.ToInt32((y-x).TotalDays), 0);
            Rectangle result = Rectangle.Intersect(rec1, rec2);
            return result.Width != 0;
        }

        public static void ExportReport(DataGridView dgv, string filename)
        {
            var wordApp = new word.Application();
            wordApp.Visible = false;
            var wordDoc = wordApp.Documents.Add();
            dgv.SelectAll();
            Clipboard.SetDataObject(dgv.GetClipboardContent());
            wordDoc.Range().Paste();
            try
            {
                wordDoc.Tables[1].set_Style("Grid Table 4 - Accent 1");
            }
            catch (Exception)
            {

            }
            wordDoc.Tables[1].AutoFitBehavior(word.WdAutoFitBehavior.wdAutoFitWindow);
            wordDoc.SaveAs2(filename, word.WdSaveFormat.wdFormatPDF);
            wordDoc.Close(false);
            wordApp.Quit(false);

            System.Diagnostics.Process.Start(filename);
        }
    }
}
