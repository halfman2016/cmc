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
            this.forcedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.testgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // testgrid
            // 
            this.testgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carcode,
            this.exdate,
            this.ttodays,
            this.forcedate,
            this.forto,
            this.comamount,
            this.comdate,
            this.comto});
            this.testgrid.Location = new System.Drawing.Point(12, 12);
            this.testgrid.Name = "testgrid";
            this.testgrid.RowTemplate.Height = 23;
            this.testgrid.Size = new System.Drawing.Size(996, 404);
            this.testgrid.TabIndex = 0;
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
            // forcedate
            // 
            this.forcedate.HeaderText = "交强险有效期";
            this.forcedate.Name = "forcedate";
            this.forcedate.ReadOnly = true;
            // 
            // forto
            // 
            this.forto.HeaderText = "距今";
            this.forto.Name = "forto";
            this.forto.ReadOnly = true;
            // 
            // comamount
            // 
            this.comamount.HeaderText = "商业险额度";
            this.comamount.Name = "comamount";
            this.comamount.ReadOnly = true;
            // 
            // comdate
            // 
            this.comdate.HeaderText = "商业险有效期";
            this.comdate.Name = "comdate";
            this.comdate.ReadOnly = true;
            // 
            // comto
            // 
            this.comto.HeaderText = "距今";
            this.comto.Name = "comto";
            this.comto.ReadOnly = true;
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 603);
            this.Controls.Add(this.testgrid);
            this.Name = "mainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "车保宝-";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainFrm_FormClosed);
            this.Load += new System.EventHandler(this.mainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView testgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn carcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn exdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttodays;
        private System.Windows.Forms.DataGridViewTextBoxColumn forcedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn forto;
        private System.Windows.Forms.DataGridViewTextBoxColumn comamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn comdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn comto;
    }
}