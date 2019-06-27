namespace FacebookWizzard.Form
{
    partial class frmTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTest));
            this.pnFill = new System.Windows.Forms.Panel();
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.btnLikeAll = new DevExpress.XtraEditors.SimpleButton();
            this.lblSubject = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnFill
            // 
            this.pnFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFill.Location = new System.Drawing.Point(0, 49);
            this.pnFill.Name = "pnFill";
            this.pnFill.Size = new System.Drawing.Size(1462, 649);
            this.pnFill.TabIndex = 3;
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.button1);
            this.pnTop.Controls.Add(this.btnReload);
            this.pnTop.Controls.Add(this.btnLikeAll);
            this.pnTop.Controls.Add(this.lblSubject);
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1462, 49);
            this.pnTop.TabIndex = 2;
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.Location = new System.Drawing.Point(1209, 14);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "Load lại trang";
            // 
            // btnLikeAll
            // 
            this.btnLikeAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLikeAll.Location = new System.Drawing.Point(1299, 14);
            this.btnLikeAll.Name = "btnLikeAll";
            this.btnLikeAll.Size = new System.Drawing.Size(151, 23);
            this.btnLikeAll.TabIndex = 2;
            this.btnLikeAll.Text = "Thích tất cả các comment";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(98, 14);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(52, 18);
            this.lblSubject.TabIndex = 1;
            this.lblSubject.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kết quả trả về: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 698);
            this.Controls.Add(this.pnFill);
            this.Controls.Add(this.pnTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chức năng";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnFill;
        private System.Windows.Forms.Panel pnTop;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.SimpleButton btnLikeAll;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}