namespace data_reader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.version = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.Label();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Sinking Ship", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.ForeColor = System.Drawing.Color.BurlyWood;
            this.version.Location = new System.Drawing.Point(798, 141);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(93, 20);
            this.version.TabIndex = 0;
            this.version.Text = "label1";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Sinking Ship", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.BurlyWood;
            this.date.Location = new System.Drawing.Point(798, 175);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(93, 20);
            this.date.TabIndex = 1;
            this.date.Text = "label1";
            // 
            // startTime
            // 
            this.startTime.AutoSize = true;
            this.startTime.Font = new System.Drawing.Font("Sinking Ship", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTime.ForeColor = System.Drawing.Color.BurlyWood;
            this.startTime.Location = new System.Drawing.Point(798, 73);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(93, 20);
            this.startTime.TabIndex = 2;
            this.startTime.Text = "label1";
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.Font = new System.Drawing.Font("Sinking Ship", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.length.ForeColor = System.Drawing.Color.BurlyWood;
            this.length.Location = new System.Drawing.Point(798, 107);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(93, 20);
            this.length.TabIndex = 3;
            this.length.Text = "label1";
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(12, 73);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(769, 545);
            this.dataView.TabIndex = 4;
            this.dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sinking Ship", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BurlyWood;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cycle Reader ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1352, 708);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.length);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.date);
            this.Controls.Add(this.version);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label startTime;
        private System.Windows.Forms.Label length;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Label label1;
    }
}

