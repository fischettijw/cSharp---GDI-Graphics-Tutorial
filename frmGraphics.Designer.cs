namespace cSharp___GDI__Graphics_Tutorial
{
    partial class frmGraphics
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
            this.components = new System.ComponentModel.Container();
            this.timAppTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timAppTimer
            // 
            this.timAppTimer.Enabled = true;
            this.timAppTimer.Interval = 10;
            this.timAppTimer.Tick += new System.EventHandler(this.timAppTimer_Tick);
            // 
            // frmGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmGraphics";
            this.Text = "cSharp - GDI+ Tutorial";
            this.Load += new System.EventHandler(this.frmGraphics_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmGraphics_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timAppTimer;
    }
}

