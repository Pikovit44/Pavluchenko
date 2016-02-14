using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextRed
{
    public interface IMainForm
    {
        string FilePath { get;  }
        string Content { get; set; }
        void SetSymbolCount(int count);
        event EventHandler FileOpenClick;
        event EventHandler ContentChanged;
        event EventHandler FileSaveClick;
        
    }

    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            butOpenFile.Click += new EventHandler(butOpenFile_Click);
            butSaveFile.Click += butSave_Click;
            fldContent.TextChanged += fldContent_TextChanged;
            butSelectFile.Click += butSelectFile_Click;
            numFont.ValueChanged += numFont_ValueChanged;
        }

        #region Проброс событий
        private void butOpenFile_Click(object sender, EventArgs e)
        {
            if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (FileSaveClick != null) FileSaveClick(this, EventArgs.Empty);
        }

        private void fldContent_TextChanged(object sender, EventArgs e)
        {
            if (ContentChanged != null) ContentChanged(this, EventArgs.Empty);
        }
        #endregion

        #region IMainForm
        public string Content
        {
            get  { return fldFilePath.Text; }
            set  { fldContent.Text = value; }
        }

        public string FilePath
        {
            get {return fldFilePath.Text;}
        }

        public void SetSymbolCount(int count)
        {
            lbSymbolCount.Text = count.ToString();
        }

        public event EventHandler ContentChanged;
        public event EventHandler FileOpenClick;
        public event EventHandler FileSaveClick;
        #endregion

        private void butSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fldFilePath.Text = dlg.FileName;

                if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);
            }

        }
        private void numFont_ValueChanged(object sender, EventArgs e)
        {
            fldContent.Font = new Font("Calibri", (float)numFont.Value);
        }


    }

}
