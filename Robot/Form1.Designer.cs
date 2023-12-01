namespace Robot
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            lblRobot = new Label();
            BtnGo1 = new Button();
            BtnN = new Button();
            btnE = new Button();
            btnS = new Button();
            label2 = new Label();
            BtnW = new Button();
            BtnGo10 = new Button();
            BtnExit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblRobot);
            panel1.Location = new Point(31, 31);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 220);
            panel1.TabIndex = 1;
            // 
            // lblRobot
            // 
            lblRobot.BackColor = SystemColors.ControlLight;
            lblRobot.Font = new Font("Wingdings", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblRobot.ForeColor = SystemColors.ActiveCaptionText;
            lblRobot.Location = new Point(100, 100);
            lblRobot.Margin = new Padding(2, 0, 2, 0);
            lblRobot.Name = "lblRobot";
            lblRobot.Size = new Size(20, 20);
            lblRobot.TabIndex = 0;
            lblRobot.Text = "a";
            lblRobot.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnGo1
            // 
            BtnGo1.Location = new Point(46, 280);
            BtnGo1.Margin = new Padding(2);
            BtnGo1.Name = "BtnGo1";
            BtnGo1.Size = new Size(45, 20);
            BtnGo1.TabIndex = 3;
            BtnGo1.Text = "Go 1";
            BtnGo1.UseVisualStyleBackColor = true;
            // 
            // BtnN
            // 
            BtnN.Location = new Point(127, 257);
            BtnN.Margin = new Padding(2);
            BtnN.Name = "BtnN";
            BtnN.Size = new Size(24, 20);
            BtnN.TabIndex = 4;
            BtnN.Text = "&N";
            BtnN.UseVisualStyleBackColor = true;
            // 
            // btnE
            // 
            btnE.Location = new Point(147, 281);
            btnE.Margin = new Padding(2);
            btnE.Name = "btnE";
            btnE.Size = new Size(24, 20);
            btnE.TabIndex = 5;
            btnE.Text = "E";
            btnE.UseVisualStyleBackColor = true;
            // 
            // btnS
            // 
            btnS.Location = new Point(127, 304);
            btnS.Margin = new Padding(2);
            btnS.Name = "btnS";
            btnS.Size = new Size(24, 20);
            btnS.TabIndex = 6;
            btnS.Text = "S";
            btnS.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 8);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 7;
            label2.Text = "{X=0,Y=0}";
            // 
            // BtnW
            // 
            BtnW.Location = new Point(108, 280);
            BtnW.Margin = new Padding(2);
            BtnW.Name = "BtnW";
            BtnW.Size = new Size(24, 20);
            BtnW.TabIndex = 8;
            BtnW.Text = "W";
            BtnW.UseVisualStyleBackColor = true;
            // 
            // BtnGo10
            // 
            BtnGo10.Location = new Point(189, 280);
            BtnGo10.Margin = new Padding(2);
            BtnGo10.Name = "BtnGo10";
            BtnGo10.Size = new Size(45, 20);
            BtnGo10.TabIndex = 9;
            BtnGo10.Text = "Go 10";
            BtnGo10.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(197, 341);
            BtnExit.Margin = new Padding(2);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(75, 23);
            BtnExit.TabIndex = 10;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnExit;
            ClientSize = new Size(284, 376);
            Controls.Add(BtnExit);
            Controls.Add(BtnGo10);
            Controls.Add(BtnW);
            Controls.Add(label2);
            Controls.Add(btnS);
            Controls.Add(btnE);
            Controls.Add(BtnN);
            Controls.Add(BtnGo1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Robot";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label lblRobot;
        private Button BtnGo1;
        private Button BtnN;
        private Button btnE;
        private Button btnS;
        private Label label2;
        private Button BtnW;
        private Button BtnGo10;
        private Button BtnExit;
    }
}