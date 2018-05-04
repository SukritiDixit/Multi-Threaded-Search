namespace Asg4_sxd160930
{
    partial class SearchBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.filepath_lb = new System.Windows.Forms.Label();
            this.search_lb = new System.Windows.Forms.Label();
            this.path_tb = new System.Windows.Forms.TextBox();
            this.search_text_tb = new System.Windows.Forms.TextBox();
            this.browse_bt = new System.Windows.Forms.Button();
            this.search_bt = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.result = new System.Windows.Forms.ListView();
            this.col_line = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_text = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusbar = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // filepath_lb
            // 
            this.filepath_lb.AutoSize = true;
            this.filepath_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filepath_lb.Location = new System.Drawing.Point(12, 9);
            this.filepath_lb.Name = "filepath_lb";
            this.filepath_lb.Size = new System.Drawing.Size(63, 17);
            this.filepath_lb.TabIndex = 0;
            this.filepath_lb.Text = "File Path";
            // 
            // search_lb
            // 
            this.search_lb.AutoSize = true;
            this.search_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_lb.Location = new System.Drawing.Point(12, 46);
            this.search_lb.Name = "search_lb";
            this.search_lb.Size = new System.Drawing.Size(78, 17);
            this.search_lb.TabIndex = 1;
            this.search_lb.Text = "Search For";
            // 
            // path_tb
            // 
            this.path_tb.Location = new System.Drawing.Point(96, 12);
            this.path_tb.Name = "path_tb";
            this.path_tb.Size = new System.Drawing.Size(525, 20);
            this.path_tb.TabIndex = 2;
            // 
            // search_text_tb
            // 
            this.search_text_tb.Location = new System.Drawing.Point(96, 47);
            this.search_text_tb.Name = "search_text_tb";
            this.search_text_tb.Size = new System.Drawing.Size(525, 20);
            this.search_text_tb.TabIndex = 3;
            // 
            // browse_bt
            // 
            this.browse_bt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.browse_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.browse_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse_bt.Location = new System.Drawing.Point(627, 2);
            this.browse_bt.Name = "browse_bt";
            this.browse_bt.Size = new System.Drawing.Size(70, 28);
            this.browse_bt.TabIndex = 5;
            this.browse_bt.Text = "Browse";
            this.browse_bt.UseVisualStyleBackColor = false;
            this.browse_bt.Click += new System.EventHandler(this.browse_bt_Click);
            // 
            // search_bt
            // 
            this.search_bt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.search_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_bt.Location = new System.Drawing.Point(627, 39);
            this.search_bt.Name = "search_bt";
            this.search_bt.Size = new System.Drawing.Size(70, 28);
            this.search_bt.TabIndex = 6;
            this.search_bt.Text = "Search";
            this.search_bt.UseVisualStyleBackColor = false;
            this.search_bt.Click += new System.EventHandler(this.search_bt_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 400);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(682, 18);
            this.progressBar.TabIndex = 8;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // result
            // 
            this.result.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_line,
            this.col_text});
            this.result.FullRowSelect = true;
            this.result.Location = new System.Drawing.Point(15, 73);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(682, 321);
            this.result.TabIndex = 9;
            this.result.UseCompatibleStateImageBehavior = false;
            this.result.View = System.Windows.Forms.View.Details;
            this.result.SelectedIndexChanged += new System.EventHandler(this.result_SelectedIndexChanged);
            // 
            // col_line
            // 
            this.col_line.Text = "Line#";
            this.col_line.Width = 80;
            // 
            // col_text
            // 
            this.col_text.Text = "Text";
            this.col_text.Width = 470;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusbar});
            this.statusStrip.Location = new System.Drawing.Point(0, 426);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(709, 22);
            this.statusStrip.TabIndex = 10;
            this.statusStrip.Text = "statusStrip1";
            this.statusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip_ItemClicked);
            // 
            // statusbar
            // 
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(55, 17);
            this.statusbar.Text = "statusbar";
            // 
            // SearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 448);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.result);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.search_bt);
            this.Controls.Add(this.browse_bt);
            this.Controls.Add(this.search_text_tb);
            this.Controls.Add(this.path_tb);
            this.Controls.Add(this.search_lb);
            this.Controls.Add(this.filepath_lb);
            this.Name = "SearchBox";
            this.Text = "Text Search";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filepath_lb;
        private System.Windows.Forms.Label search_lb;
        private System.Windows.Forms.TextBox path_tb;
        private System.Windows.Forms.TextBox search_text_tb;
        private System.Windows.Forms.Button browse_bt;
        private System.Windows.Forms.Button search_bt;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ListView result;
        private System.Windows.Forms.ColumnHeader col_line;
        private System.Windows.Forms.ColumnHeader col_text;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusbar;
    }
}

