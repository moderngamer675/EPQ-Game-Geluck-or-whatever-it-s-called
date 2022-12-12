
namespace Possible_EPQ
{
    partial class frm_homeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_homeScreen));
            this.btn_playButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_playButton
            // 
            this.btn_playButton.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_playButton.FlatAppearance.BorderSize = 0;
            this.btn_playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_playButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playButton.Location = new System.Drawing.Point(132, 299);
            this.btn_playButton.Name = "btn_playButton";
            this.btn_playButton.Size = new System.Drawing.Size(305, 139);
            this.btn_playButton.TabIndex = 0;
            this.btn_playButton.Text = "Play";
            this.btn_playButton.UseVisualStyleBackColor = false;
            this.btn_playButton.Click += new System.EventHandler(this.btn_playButton_Click);
            this.btn_playButton.MouseLeave += new System.EventHandler(this.btn_playButtonLeave);
            this.btn_playButton.MouseHover += new System.EventHandler(this.btn_playButtonHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 98F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 160);
            this.label1.TabIndex = 1;
            this.label1.Text = "Geluck";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(354, 1032);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Created by Husnain Shahzad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(128, 817);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Created By Husnain Shahzad";
            // 
            // btn_quitButton
            // 
            this.btn_quitButton.FlatAppearance.BorderSize = 0;
            this.btn_quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitButton.Location = new System.Drawing.Point(92, 466);
            this.btn_quitButton.Name = "btn_quitButton";
            this.btn_quitButton.Size = new System.Drawing.Size(368, 132);
            this.btn_quitButton.TabIndex = 5;
            this.btn_quitButton.Text = "Quit";
            this.btn_quitButton.UseVisualStyleBackColor = true;
            this.btn_quitButton.Click += new System.EventHandler(this.btn_quitButton_Click);
            this.btn_quitButton.MouseLeave += new System.EventHandler(this.btn_quitButtonLeave);
            this.btn_quitButton.MouseHover += new System.EventHandler(this.btn_quitButtonHover);
            // 
            // frm_homeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(584, 848);
            this.Controls.Add(this.btn_quitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_playButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_homeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geluck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_playButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_quitButton;
    }
}

