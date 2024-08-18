namespace FinkiEscape
{
    partial class ConnectWires
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
            this.SuspendLayout();
            // 
            // ConnectWires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinkiEscape.Properties.Resources.wireConnect;
            this.ClientSize = new System.Drawing.Size(601, 351);
            this.MaximizeBox = false;
            this.Name = "ConnectWires";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Разводна табла";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ConnectWires_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConnectWires_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ConnectWires_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}