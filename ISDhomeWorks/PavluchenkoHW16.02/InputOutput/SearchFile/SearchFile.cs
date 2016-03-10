using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchFile
{
    public interface IMainForm
    {
        string FilePath { get; }
        string Content { set; }
        event EventHandler FileSearchClick;
        event EventHandler FileCompressClick;
    }

    public partial class SearchFile : Form
    {
        public SearchFile()
        {
            InitializeComponent();
            searchBtn.Click += new EventHandler (SearchBtn_Click);

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
           if (FileSearchClick != null) FileSearchClick(this, EventArgs.Empty);
        }


        string FilePath { get; }
        string Content
        {
            set { textFileFld.Text = value; }
        }

        event EventHandler FileSearchClick;
        event EventHandler FileCompressClick;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
