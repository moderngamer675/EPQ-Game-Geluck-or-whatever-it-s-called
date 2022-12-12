
namespace Possible_EPQ
{
    partial class GameUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameUI));
            this.lbScore = new System.Windows.Forms.Label();
            this.tbScore = new System.Windows.Forms.TextBox();
            this.btn_doorOne = new System.Windows.Forms.Button();
            this.btn_doorTwo = new System.Windows.Forms.Button();
            this.btn_doorThree = new System.Windows.Forms.Button();
            this.timerTick = new System.Windows.Forms.Timer(this.components);
            this.tb_answer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Lucida Sans Unicode", 35F, System.Drawing.FontStyle.Bold);
            this.lbScore.Location = new System.Drawing.Point(166, 37);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(169, 57);
            this.lbScore.TabIndex = 3;
            this.lbScore.Text = "Score:";
            // 
            // tbScore
            // 
            this.tbScore.BackColor = System.Drawing.Color.Gainsboro;
            this.tbScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbScore.Cursor = System.Windows.Forms.Cursors.No;
            this.tbScore.Font = new System.Drawing.Font("Lucida Sans Unicode", 35F, System.Drawing.FontStyle.Bold);
            this.tbScore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbScore.Location = new System.Drawing.Point(328, 37);
            this.tbScore.Name = "tbScore";
            this.tbScore.ReadOnly = true;
            this.tbScore.Size = new System.Drawing.Size(116, 72);
            this.tbScore.TabIndex = 4;
            this.tbScore.TabStop = false;
            // 
            // btn_doorOne
            // 
            this.btn_doorOne.BackColor = System.Drawing.Color.Tan;
            this.btn_doorOne.Font = new System.Drawing.Font("Lucida Sans Unicode", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doorOne.ForeColor = System.Drawing.Color.Peru;
            this.btn_doorOne.Location = new System.Drawing.Point(12, 223);
            this.btn_doorOne.Name = "btn_doorOne";
            this.btn_doorOne.Size = new System.Drawing.Size(162, 379);
            this.btn_doorOne.TabIndex = 5;
            this.btn_doorOne.Text = "1";
            this.btn_doorOne.UseVisualStyleBackColor = false;
            this.btn_doorOne.Click += new System.EventHandler(this.btn_doorOne_Click);
            // 
            // btn_doorTwo
            // 
            this.btn_doorTwo.BackColor = System.Drawing.Color.Tan;
            this.btn_doorTwo.Font = new System.Drawing.Font("Lucida Sans Unicode", 48F, System.Drawing.FontStyle.Bold);
            this.btn_doorTwo.ForeColor = System.Drawing.Color.Peru;
            this.btn_doorTwo.Location = new System.Drawing.Point(204, 223);
            this.btn_doorTwo.Name = "btn_doorTwo";
            this.btn_doorTwo.Size = new System.Drawing.Size(168, 379);
            this.btn_doorTwo.TabIndex = 6;
            this.btn_doorTwo.Text = "2";
            this.btn_doorTwo.UseVisualStyleBackColor = false;
            this.btn_doorTwo.Click += new System.EventHandler(this.btn_doorTwo_Click);
            // 
            // btn_doorThree
            // 
            this.btn_doorThree.BackColor = System.Drawing.Color.Tan;
            this.btn_doorThree.Font = new System.Drawing.Font("Lucida Sans Unicode", 48F, System.Drawing.FontStyle.Bold);
            this.btn_doorThree.ForeColor = System.Drawing.Color.Peru;
            this.btn_doorThree.Location = new System.Drawing.Point(402, 223);
            this.btn_doorThree.Name = "btn_doorThree";
            this.btn_doorThree.Size = new System.Drawing.Size(170, 379);
            this.btn_doorThree.TabIndex = 7;
            this.btn_doorThree.Text = "3";
            this.btn_doorThree.UseVisualStyleBackColor = false;
            this.btn_doorThree.Click += new System.EventHandler(this.btn_doorThree_Click);
            // 
            // timerTick
            // 
            this.timerTick.Enabled = true;
            this.timerTick.Tick += new System.EventHandler(this.timerTick_Tick);
            // 
            // tb_answer
            // 
            this.tb_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_answer.Location = new System.Drawing.Point(201, 116);
            this.tb_answer.Name = "tb_answer";
            this.tb_answer.Size = new System.Drawing.Size(171, 80);
            this.tb_answer.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Sans Unicode", 25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(52, 645);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(462, 57);
            this.button1.TabIndex = 9;
            this.button1.Text = "Hold to Show Answer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_showAnswer);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_hideAnswer);
            // 
            // GameUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(584, 848);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_answer);
            this.Controls.Add(this.btn_doorThree);
            this.Controls.Add(this.btn_doorTwo);
            this.Controls.Add(this.btn_doorOne);
            this.Controls.Add(this.tbScore);
            this.Controls.Add(this.lbScore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geluck";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exit);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.TextBox tbScore;
        private System.Windows.Forms.Button btn_doorOne;
        private System.Windows.Forms.Button btn_doorThree;
        private System.Windows.Forms.Button btn_doorTwo;
        private System.Windows.Forms.Timer timerTick;
        private System.Windows.Forms.TextBox tb_answer;
        private System.Windows.Forms.Button button1;
    }
}