namespace FinkiEscapa
{
    partial class IQQuiz
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
            this.questionTxt = new System.Windows.Forms.Label();
            this.counter = new System.Windows.Forms.Label();
            this.answer1 = new System.Windows.Forms.Button();
            this.answer2 = new System.Windows.Forms.Button();
            this.answer3 = new System.Windows.Forms.Button();
            this.answer4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // questionTxt
            // 
            this.questionTxt.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.questionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.questionTxt.Location = new System.Drawing.Point(12, 67);
            this.questionTxt.Name = "questionTxt";
            this.questionTxt.Size = new System.Drawing.Size(776, 106);
            this.questionTxt.TabIndex = 0;
            this.questionTxt.Text = "question";
            this.questionTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // counter
            // 
            this.counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counter.Location = new System.Drawing.Point(560, 23);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(228, 25);
            this.counter.TabIndex = 1;
            this.counter.Text = "1/10";
            this.counter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // answer1
            // 
            this.answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer1.Location = new System.Drawing.Point(18, 210);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(371, 74);
            this.answer1.TabIndex = 2;
            this.answer1.Text = "answer1";
            this.answer1.UseVisualStyleBackColor = true;
            this.answer1.Click += new System.EventHandler(this.answer1_Click);
            // 
            // answer2
            // 
            this.answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer2.Location = new System.Drawing.Point(417, 210);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(371, 74);
            this.answer2.TabIndex = 2;
            this.answer2.Text = "answer2";
            this.answer2.UseVisualStyleBackColor = true;
            this.answer2.Click += new System.EventHandler(this.answer2_Click);
            // 
            // answer3
            // 
            this.answer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer3.Location = new System.Drawing.Point(18, 315);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(371, 74);
            this.answer3.TabIndex = 2;
            this.answer3.Text = "answer3";
            this.answer3.UseVisualStyleBackColor = true;
            this.answer3.Click += new System.EventHandler(this.answer3_Click);
            // 
            // answer4
            // 
            this.answer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer4.Location = new System.Drawing.Point(417, 315);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(371, 74);
            this.answer4.TabIndex = 2;
            this.answer4.Text = "answer4";
            this.answer4.UseVisualStyleBackColor = true;
            this.answer4.Click += new System.EventHandler(this.answer4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            // 
            // IQQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.Controls.Add(this.answer4);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.questionTxt);
            this.Name = "IQQuiz";
            this.Text = "IQQuiz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label questionTxt;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.Button answer1;
        private System.Windows.Forms.Button answer2;
        private System.Windows.Forms.Button answer3;
        private System.Windows.Forms.Button answer4;
        private System.Windows.Forms.Timer timer1;
    }
}