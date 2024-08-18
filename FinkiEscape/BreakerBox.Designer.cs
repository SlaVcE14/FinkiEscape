namespace FinkiEscape
{
    partial class BreakerBox
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
            this.button1 = new System.Windows.Forms.Button();
            this.powerSwitch = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(34, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // powerSwitch
            // 
            this.powerSwitch.BackColor = System.Drawing.Color.Transparent;
            this.powerSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.powerSwitch.Location = new System.Drawing.Point(466, 245);
            this.powerSwitch.Name = "powerSwitch";
            this.powerSwitch.Size = new System.Drawing.Size(31, 36);
            this.powerSwitch.TabIndex = 3;
            this.powerSwitch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.powerSwitch_MouseClick);
            // 
            // BreakerBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinkiEscape.Properties.Resources.powerOff;
            this.Controls.Add(this.powerSwitch);
            this.Controls.Add(this.button1);
            this.Name = "BreakerBox";
            this.Size = new System.Drawing.Size(1150, 660);
            this.VisibleChanged += new System.EventHandler(this.BreakerBox_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel powerSwitch;
    }
}
