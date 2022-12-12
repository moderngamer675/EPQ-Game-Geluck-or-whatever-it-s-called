
namespace Possible_EPQ
{
    partial class frm_settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_settings));
            this.btn_returnHomeScreen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundColour_ComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fontColour_ComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.language_ComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_returnHomeScreen
            // 
            this.btn_returnHomeScreen.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_returnHomeScreen.FlatAppearance.BorderSize = 0;
            this.btn_returnHomeScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_returnHomeScreen.Font = new System.Drawing.Font("Lucida Sans Unicode", 30F, System.Drawing.FontStyle.Bold);
            this.btn_returnHomeScreen.Location = new System.Drawing.Point(47, 700);
            this.btn_returnHomeScreen.Name = "btn_returnHomeScreen";
            this.btn_returnHomeScreen.Size = new System.Drawing.Size(476, 115);
            this.btn_returnHomeScreen.TabIndex = 1;
            this.btn_returnHomeScreen.Text = "Press to Return to Home Screen";
            this.btn_returnHomeScreen.UseVisualStyleBackColor = false;
            this.btn_returnHomeScreen.Click += new System.EventHandler(this.btn_returnHomeScreen_Click);
            this.btn_returnHomeScreen.MouseLeave += new System.EventHandler(this.btn_returnHomeScreenLeave);
            this.btn_returnHomeScreen.MouseHover += new System.EventHandler(this.btn_returnHomeScreenHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 70F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(75, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 115);
            this.label1.TabIndex = 2;
            this.label1.Text = "Settings";
            // 
            // backgroundColour_ComboBox
            // 
            this.backgroundColour_ComboBox.BackColor = System.Drawing.Color.Gainsboro;
            this.backgroundColour_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backgroundColour_ComboBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F);
            this.backgroundColour_ComboBox.FormattingEnabled = true;
            this.backgroundColour_ComboBox.Location = new System.Drawing.Point(255, 230);
            this.backgroundColour_ComboBox.Name = "backgroundColour_ComboBox";
            this.backgroundColour_ComboBox.Size = new System.Drawing.Size(271, 26);
            this.backgroundColour_ComboBox.TabIndex = 4;
            this.backgroundColour_ComboBox.SelectedIndexChanged += new System.EventHandler(this.backgroundColour_ComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(31, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Background Colour:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(98, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Font Colour:";
            // 
            // fontColour_ComboBox
            // 
            this.fontColour_ComboBox.BackColor = System.Drawing.Color.Gainsboro;
            this.fontColour_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fontColour_ComboBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F);
            this.fontColour_ComboBox.FormattingEnabled = true;
            this.fontColour_ComboBox.Location = new System.Drawing.Point(255, 370);
            this.fontColour_ComboBox.Name = "fontColour_ComboBox";
            this.fontColour_ComboBox.Size = new System.Drawing.Size(271, 26);
            this.fontColour_ComboBox.TabIndex = 7;
            this.fontColour_ComboBox.SelectedIndexChanged += new System.EventHandler(this.fontColour_ComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(121, 539);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Language:";
            // 
            // language_ComboBox
            // 
            this.language_ComboBox.BackColor = System.Drawing.Color.Gainsboro;
            this.language_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.language_ComboBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F);
            this.language_ComboBox.FormattingEnabled = true;
            this.language_ComboBox.Location = new System.Drawing.Point(255, 540);
            this.language_ComboBox.Name = "language_ComboBox";
            this.language_ComboBox.Size = new System.Drawing.Size(271, 26);
            this.language_ComboBox.TabIndex = 9;
            this.language_ComboBox.SelectedIndexChanged += new System.EventHandler(this.language_ComboBox_SelectedIndexChanged);
            // 
            // frm_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(584, 848);
            this.Controls.Add(this.language_ComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fontColour_ComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backgroundColour_ComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_returnHomeScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_returnHomeScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox backgroundColour_ComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox fontColour_ComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox language_ComboBox;
    }
}