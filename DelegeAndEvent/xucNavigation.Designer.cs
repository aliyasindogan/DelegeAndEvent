namespace DelegeAndEvent
{
    partial class xucNavigation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPageName = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // lblPageName
            // 
            this.lblPageName.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPageName.Appearance.Options.UseFont = true;
            this.lblPageName.Location = new System.Drawing.Point(37, 22);
            this.lblPageName.Name = "lblPageName";
            this.lblPageName.Size = new System.Drawing.Size(94, 23);
            this.lblPageName.TabIndex = 0;
            this.lblPageName.Text = "Ana Sayfa";
            // 
            // xucNavigation
            // 
            this.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPageName);
            this.Name = "xucNavigation";
            this.Size = new System.Drawing.Size(555, 64);
            this.Load += new System.EventHandler(this.xucNavigation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.LabelControl lblPageName;
    }
}
