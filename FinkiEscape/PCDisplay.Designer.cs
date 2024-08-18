namespace FinkiEscape
{
    partial class PCDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCDisplay));
            this.backBtb = new System.Windows.Forms.Button();
            this.screen = new System.Windows.Forms.Panel();
            this.pcDialog = new System.Windows.Forms.Panel();
            this.dialogBtn = new System.Windows.Forms.Button();
            this.dialogMsg = new System.Windows.Forms.Label();
            this.game2Lbl = new System.Windows.Forms.Label();
            this.game3Lbl = new System.Windows.Forms.Label();
            this.game4Lbl = new System.Windows.Forms.Label();
            this.game5Lbl = new System.Windows.Forms.Label();
            this.game6Lbl = new System.Windows.Forms.Label();
            this.game1Lbl = new System.Windows.Forms.Label();
            this.game2Btn = new System.Windows.Forms.PictureBox();
            this.game5Btn = new System.Windows.Forms.PictureBox();
            this.game6Btn = new System.Windows.Forms.PictureBox();
            this.game3Btn = new System.Windows.Forms.PictureBox();
            this.game4Btn = new System.Windows.Forms.PictureBox();
            this.game1Btn = new System.Windows.Forms.PictureBox();
            this.screen.SuspendLayout();
            this.pcDialog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.game2Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game5Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game6Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game3Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game4Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game1Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtb
            // 
            this.backBtb.BackColor = System.Drawing.SystemColors.Desktop;
            this.backBtb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.backBtb.Location = new System.Drawing.Point(980, 577);
            this.backBtb.Name = "backBtb";
            this.backBtb.Size = new System.Drawing.Size(132, 53);
            this.backBtb.TabIndex = 1;
            this.backBtb.Text = "Назад";
            this.backBtb.UseVisualStyleBackColor = false;
            this.backBtb.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // screen
            // 
            this.screen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.screen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("screen.BackgroundImage")));
            this.screen.Controls.Add(this.pcDialog);
            this.screen.Controls.Add(this.game2Lbl);
            this.screen.Controls.Add(this.game3Lbl);
            this.screen.Controls.Add(this.game4Lbl);
            this.screen.Controls.Add(this.game5Lbl);
            this.screen.Controls.Add(this.game6Lbl);
            this.screen.Controls.Add(this.game1Lbl);
            this.screen.Controls.Add(this.game2Btn);
            this.screen.Controls.Add(this.game5Btn);
            this.screen.Controls.Add(this.game6Btn);
            this.screen.Controls.Add(this.game3Btn);
            this.screen.Controls.Add(this.game4Btn);
            this.screen.Controls.Add(this.game1Btn);
            this.screen.Location = new System.Drawing.Point(139, 53);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(875, 430);
            this.screen.TabIndex = 2;
            // 
            // pcDialog
            // 
            this.pcDialog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcDialog.BackgroundImage = global::FinkiEscape.Properties.Resources.pcDialog;
            this.pcDialog.Controls.Add(this.dialogBtn);
            this.pcDialog.Controls.Add(this.dialogMsg);
            this.pcDialog.Location = new System.Drawing.Point(285, 142);
            this.pcDialog.Name = "pcDialog";
            this.pcDialog.Size = new System.Drawing.Size(305, 145);
            this.pcDialog.TabIndex = 12;
            this.pcDialog.Visible = false;
            // 
            // dialogBtn
            // 
            this.dialogBtn.Location = new System.Drawing.Point(115, 114);
            this.dialogBtn.Name = "dialogBtn";
            this.dialogBtn.Size = new System.Drawing.Size(75, 23);
            this.dialogBtn.TabIndex = 1;
            this.dialogBtn.Text = "ОК";
            this.dialogBtn.UseVisualStyleBackColor = true;
            this.dialogBtn.Click += new System.EventHandler(this.dialogBtn_Click);
            // 
            // dialogMsg
            // 
            this.dialogMsg.BackColor = System.Drawing.Color.Transparent;
            this.dialogMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dialogMsg.Location = new System.Drawing.Point(0, 33);
            this.dialogMsg.Name = "dialogMsg";
            this.dialogMsg.Size = new System.Drawing.Size(305, 76);
            this.dialogMsg.TabIndex = 0;
            this.dialogMsg.Text = "label1";
            this.dialogMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // game2Lbl
            // 
            this.game2Lbl.BackColor = System.Drawing.Color.Transparent;
            this.game2Lbl.Location = new System.Drawing.Point(100, 83);
            this.game2Lbl.Margin = new System.Windows.Forms.Padding(0);
            this.game2Lbl.Name = "game2Lbl";
            this.game2Lbl.Size = new System.Drawing.Size(57, 38);
            this.game2Lbl.TabIndex = 7;
            this.game2Lbl.Text = "game2";
            this.game2Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // game3Lbl
            // 
            this.game3Lbl.BackColor = System.Drawing.Color.Transparent;
            this.game3Lbl.Location = new System.Drawing.Point(180, 83);
            this.game3Lbl.Margin = new System.Windows.Forms.Padding(0);
            this.game3Lbl.Name = "game3Lbl";
            this.game3Lbl.Size = new System.Drawing.Size(60, 38);
            this.game3Lbl.TabIndex = 8;
            this.game3Lbl.Text = "game3";
            this.game3Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // game4Lbl
            // 
            this.game4Lbl.BackColor = System.Drawing.Color.Transparent;
            this.game4Lbl.Location = new System.Drawing.Point(260, 83);
            this.game4Lbl.Margin = new System.Windows.Forms.Padding(0);
            this.game4Lbl.Name = "game4Lbl";
            this.game4Lbl.Size = new System.Drawing.Size(60, 38);
            this.game4Lbl.TabIndex = 9;
            this.game4Lbl.Text = "game4";
            this.game4Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // game5Lbl
            // 
            this.game5Lbl.BackColor = System.Drawing.Color.Transparent;
            this.game5Lbl.Location = new System.Drawing.Point(340, 83);
            this.game5Lbl.Margin = new System.Windows.Forms.Padding(0);
            this.game5Lbl.Name = "game5Lbl";
            this.game5Lbl.Size = new System.Drawing.Size(60, 38);
            this.game5Lbl.TabIndex = 10;
            this.game5Lbl.Text = "game5";
            this.game5Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // game6Lbl
            // 
            this.game6Lbl.BackColor = System.Drawing.Color.Transparent;
            this.game6Lbl.Location = new System.Drawing.Point(420, 83);
            this.game6Lbl.Margin = new System.Windows.Forms.Padding(0);
            this.game6Lbl.Name = "game6Lbl";
            this.game6Lbl.Size = new System.Drawing.Size(60, 38);
            this.game6Lbl.TabIndex = 11;
            this.game6Lbl.Text = "game6";
            this.game6Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // game1Lbl
            // 
            this.game1Lbl.BackColor = System.Drawing.Color.Transparent;
            this.game1Lbl.Location = new System.Drawing.Point(20, 83);
            this.game1Lbl.Margin = new System.Windows.Forms.Padding(0);
            this.game1Lbl.Name = "game1Lbl";
            this.game1Lbl.Size = new System.Drawing.Size(60, 38);
            this.game1Lbl.TabIndex = 6;
            this.game1Lbl.Text = "game1";
            this.game1Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // game2Btn
            // 
            this.game2Btn.BackColor = System.Drawing.Color.Transparent;
            this.game2Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.game2Btn.Image = global::FinkiEscape.Properties.Resources.icon_null;
            this.game2Btn.Location = new System.Drawing.Point(100, 20);
            this.game2Btn.Name = "game2Btn";
            this.game2Btn.Size = new System.Drawing.Size(60, 60);
            this.game2Btn.TabIndex = 5;
            this.game2Btn.TabStop = false;
            this.game2Btn.Click += new System.EventHandler(this.game2Btn_Click);
            // 
            // game5Btn
            // 
            this.game5Btn.BackColor = System.Drawing.Color.Transparent;
            this.game5Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.game5Btn.Image = global::FinkiEscape.Properties.Resources.icon_null;
            this.game5Btn.Location = new System.Drawing.Point(340, 20);
            this.game5Btn.Name = "game5Btn";
            this.game5Btn.Size = new System.Drawing.Size(60, 60);
            this.game5Btn.TabIndex = 4;
            this.game5Btn.TabStop = false;
            this.game5Btn.Click += new System.EventHandler(this.game5Btn_Click);
            // 
            // game6Btn
            // 
            this.game6Btn.BackColor = System.Drawing.Color.Transparent;
            this.game6Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.game6Btn.Image = global::FinkiEscape.Properties.Resources.icon_null;
            this.game6Btn.Location = new System.Drawing.Point(420, 20);
            this.game6Btn.Name = "game6Btn";
            this.game6Btn.Size = new System.Drawing.Size(60, 60);
            this.game6Btn.TabIndex = 1;
            this.game6Btn.TabStop = false;
            this.game6Btn.Click += new System.EventHandler(this.game6Btn_Click);
            // 
            // game3Btn
            // 
            this.game3Btn.BackColor = System.Drawing.Color.Transparent;
            this.game3Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.game3Btn.Image = global::FinkiEscape.Properties.Resources.icon_null;
            this.game3Btn.Location = new System.Drawing.Point(180, 20);
            this.game3Btn.Name = "game3Btn";
            this.game3Btn.Size = new System.Drawing.Size(60, 60);
            this.game3Btn.TabIndex = 2;
            this.game3Btn.TabStop = false;
            this.game3Btn.Click += new System.EventHandler(this.game3Btn_Click);
            // 
            // game4Btn
            // 
            this.game4Btn.BackColor = System.Drawing.Color.Transparent;
            this.game4Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.game4Btn.Image = global::FinkiEscape.Properties.Resources.icon_null;
            this.game4Btn.Location = new System.Drawing.Point(260, 20);
            this.game4Btn.Name = "game4Btn";
            this.game4Btn.Size = new System.Drawing.Size(60, 60);
            this.game4Btn.TabIndex = 3;
            this.game4Btn.TabStop = false;
            this.game4Btn.Click += new System.EventHandler(this.game4Btn_Click);
            // 
            // game1Btn
            // 
            this.game1Btn.BackColor = System.Drawing.Color.Transparent;
            this.game1Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.game1Btn.Image = global::FinkiEscape.Properties.Resources.icon_null;
            this.game1Btn.Location = new System.Drawing.Point(20, 20);
            this.game1Btn.Name = "game1Btn";
            this.game1Btn.Size = new System.Drawing.Size(60, 60);
            this.game1Btn.TabIndex = 0;
            this.game1Btn.TabStop = false;
            this.game1Btn.Click += new System.EventHandler(this.game1Btn_Click);
            // 
            // PCDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinkiEscape.Properties.Resources.pcMonitor;
            this.Controls.Add(this.screen);
            this.Controls.Add(this.backBtb);
            this.Name = "PCDisplay";
            this.Size = new System.Drawing.Size(1150, 660);
            this.VisibleChanged += new System.EventHandler(this.PCDisplay_VisibleChanged);
            this.screen.ResumeLayout(false);
            this.pcDialog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.game2Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game5Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game6Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game3Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game4Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game1Btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button backBtb;
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.Label game2Lbl;
        private System.Windows.Forms.Label game3Lbl;
        private System.Windows.Forms.Label game4Lbl;
        private System.Windows.Forms.Label game5Lbl;
        private System.Windows.Forms.Label game6Lbl;
        private System.Windows.Forms.Label game1Lbl;
        private System.Windows.Forms.PictureBox game2Btn;
        private System.Windows.Forms.PictureBox game5Btn;
        private System.Windows.Forms.PictureBox game6Btn;
        private System.Windows.Forms.PictureBox game3Btn;
        private System.Windows.Forms.PictureBox game4Btn;
        private System.Windows.Forms.PictureBox game1Btn;
        private System.Windows.Forms.Panel pcDialog;
        private System.Windows.Forms.Button dialogBtn;
        private System.Windows.Forms.Label dialogMsg;
    }
}
