namespace carmanage
{
    partial class mainFrm
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
            this.testgrid = new System.Windows.Forms.DataGridView();
            this.carcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttodays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forcegrid = new System.Windows.Forms.DataGridView();
            this.carplate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comgrid = new System.Windows.Forms.DataGridView();
            this.carnun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.testgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forcegrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // testgrid
            // 
            this.testgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carcode,
            this.exdate,
            this.ttodays});
            this.testgrid.Location = new System.Drawing.Point(12, 12);
            this.testgrid.Name = "testgrid";
            this.testgrid.RowTemplate.Height = 23;
            this.testgrid.Size = new System.Drawing.Size(348, 404);
            this.testgrid.TabIndex = 0;
            this.testgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // carcode
            // 
            this.carcode.Frozen = true;
            this.carcode.HeaderText = "号牌";
            this.carcode.Name = "carcode";
            this.carcode.ReadOnly = true;
            // 
            // exdate
            // 
            this.exdate.HeaderText = "检验有效期";
            this.exdate.Name = "exdate";
            this.exdate.ReadOnly = true;
            // 
            // ttodays
            // 
            this.ttodays.HeaderText = "距今天数";
            this.ttodays.Name = "ttodays";
            this.ttodays.ReadOnly = true;
            // 
            // forcegrid
            // 
            this.forcegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.forcegrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carplate,
            this.enddate,
            this.todays});
            this.forcegrid.Location = new System.Drawing.Point(367, 13);
            this.forcegrid.Name = "forcegrid";
            this.forcegrid.RowTemplate.Height = 23;
            this.forcegrid.Size = new System.Drawing.Size(345, 403);
            this.forcegrid.TabIndex = 1;
            this.forcegrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // carplate
            // 
            this.carplate.HeaderText = "号牌";
            this.carplate.Name = "carplate";
            this.carplate.ReadOnly = true;
            // 
            // enddate
            // 
            this.enddate.HeaderText = "交强险有效期";
            this.enddate.Name = "enddate";
            this.enddate.ReadOnly = true;
            // 
            // todays
            // 
            this.todays.HeaderText = "距今天天数";
            this.todays.Name = "todays";
            this.todays.ReadOnly = true;
            // 
            // comgrid
            // 
            this.comgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carnun,
            this.comins,
            this.amount,
            this.tod});
            this.comgrid.Location = new System.Drawing.Point(718, 12);
            this.comgrid.Name = "comgrid";
            this.comgrid.RowTemplate.Height = 23;
            this.comgrid.Size = new System.Drawing.Size(451, 404);
            this.comgrid.TabIndex = 2;
            // 
            // carnun
            // 
            this.carnun.HeaderText = "号牌";
            this.carnun.Name = "carnun";
            this.carnun.ReadOnly = true;
            // 
            // comins
            // 
            this.comins.HeaderText = "商业险有效期";
            this.comins.Name = "comins";
            this.comins.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.HeaderText = "保额";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // tod
            // 
            this.tod.HeaderText = "距今天数";
            this.tod.Name = "tod";
            this.tod.ReadOnly = true;
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 603);
            this.Controls.Add(this.comgrid);
            this.Controls.Add(this.forcegrid);
            this.Controls.Add(this.testgrid);
            this.Name = "mainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "车保宝-";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainFrm_FormClosed);
            this.Load += new System.EventHandler(this.mainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forcegrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView testgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn carcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn exdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttodays;
        private System.Windows.Forms.DataGridView forcegrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn carplate;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddate;
        private System.Windows.Forms.DataGridViewTextBoxColumn todays;
        private System.Windows.Forms.DataGridView comgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnun;
        private System.Windows.Forms.DataGridViewTextBoxColumn comins;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tod;
    }
}