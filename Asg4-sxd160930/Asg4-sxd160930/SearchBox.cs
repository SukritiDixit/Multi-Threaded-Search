/*
 * Assignment -4 ;
 * Subject - CS6326 Human Computer Interaction;
 * Sem - Spring'17
 * Author - Sukriti Dixit (SXD160930)
 * Description - Multi-Threaded text search in a chosen text file.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Asg4_sxd160930
{
   
    public partial class SearchBox : Form
    {
        int bclick = 0;
        string line;
        int ctr;

        // Constructor
        public SearchBox()
        {
            InitializeComponent();
            statusbar.Text = "Welcome to Text Search. Please browse to the required file and enter the text to be searched for" ;
            statusStrip.Refresh();
        }

        // Event Handeler for Browse Button
        private void browse_bt_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileSelectPopUp = new OpenFileDialog();
            fileSelectPopUp.Title = "Select File To Upload";
            fileSelectPopUp.InitialDirectory = @"c:\";
            fileSelectPopUp.Filter = "All files (*.*)|*.*";
            fileSelectPopUp.FilterIndex = 2;
            fileSelectPopUp.RestoreDirectory = true;
            if (fileSelectPopUp.ShowDialog() == DialogResult.OK)
            {
                path_tb.Text = fileSelectPopUp.FileName;
            }
        }

        // Event Handeler for Search Button
        private void search_bt_Click(object sender, EventArgs e)
        {
            bclick++;
            statusbar.Text = "Search in Progress";
            statusStrip.Refresh();

            if (bclick % 2 != 0 && search_bt.Text == "Search")
            {
                search_bt.Text = "Cancel";
                progressBar.Show();
                backgroundWorker.RunWorkerAsync(); 
            }
            else if (bclick%2 == 0 && search_bt.Text == "Cancel")
            {
                statusbar.Text = "Search Cancelled";
                statusStrip.Refresh();
                search_bt.Text = "Search";
                progressBar.Hide();
                progressBar.Value = 0;
                backgroundWorker.CancelAsync();
            }
            
        }

        // File read and progress reporting done by Background Worker
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string query = search_text_tb.Text;
            string l;
            int c = 0;

            FileInfo fileInfo = new FileInfo(path_tb.Text);
            long length = fileInfo.Length;
            long strlen = 0;

            using (StreamReader read = new StreamReader(path_tb.Text))
            {
                while ((l = read.ReadLine()) != null)
                {
                    if (backgroundWorker.CancellationPending == true)
                    {
                        e.Cancel = true;
                        break;
                    }
                    if (l.Contains(query))
                    {
                        ctr = c;
                        line = String.Copy(l);
                        strlen += l.Length * sizeof(Char);
                        backgroundWorker.ReportProgress((int)(((decimal)strlen / (decimal)length) * (decimal)100));
                        Thread.Sleep(50);
                    }

                    c++;
                    if ((l = read.ReadLine()) == null)
                    {
                        backgroundWorker.ReportProgress(100);
                    }
                }
                read.Close();
            }
            }

        // Progress reflection in GUI
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ListViewItem row = new ListViewItem(ctr.ToString());
            row.SubItems.Add(line);
            result.Items.Add(row);
            progressBar.Value = e.ProgressPercentage;
        }

        // Steps to be executed on Cancellation and Process Completion
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                result.Items.Clear();
                backgroundWorker.CancelAsync();
            }
           
            else
            {
                statusbar.Text = "Search Complete";
                statusStrip.Refresh();
            }
        }

        private void result_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }// end of partial class

}// end of namespace
