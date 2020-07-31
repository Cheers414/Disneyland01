using System;
using System.Collections.Generic;
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

        public static void ExportReport(DataGridView dgv , string filename)
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
