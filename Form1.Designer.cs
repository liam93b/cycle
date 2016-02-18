namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.dataView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.Location = new System.Drawing.Point(36, 65);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(753, 488);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Sinking Ship", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.BurlyWood;
            this.label2.Location = new System.Drawing.Point(297, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cycle Ent";
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.Location = new System.Drawing.Point(179, 199);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(35, 13);
            this.length.TabIndex = 7;
            this.length.Text = "label1";
            // 
            // startTime
            // 
            this.startTime.AutoSize = true;
            this.startTime.Location = new System.Drawing.Point(179, 173);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(35, 13);
            this.startTime.TabIndex = 6;
            this.startTime.Text = "label1";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(60, 199);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(35, 13);
            this.date.TabIndex = 5;
            this.date.Text = "label1";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(60, 173);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(35, 13);
            this.version.TabIndex = 4;
            this.version.Text = "label1";
            // 
            // dataView
            // 
            this.dataView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(63, 234);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(649, 309);
            this.dataView.TabIndex = 8;
            this.dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.cycling_clipart;
            this.ClientSize = new System.Drawing.Size(849, 616);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.length);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.date);
            this.Controls.Add(this.version);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label length;
        private System.Windows.Forms.Label startTime;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.DataGridView dataView;
    }
}

