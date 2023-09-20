namespace Tetris
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelBoard = new System.Windows.Forms.Panel();
            this.labelResoult = new System.Windows.Forms.Label();
            this.panelMini = new System.Windows.Forms.Panel();
            this.labelHelp = new System.Windows.Forms.Label();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelBoard
            // 
            this.panelBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBoard.Location = new System.Drawing.Point(0, 1);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(250, 500);
            this.panelBoard.TabIndex = 0;
            // 
            // labelResoult
            // 
            this.labelResoult.Location = new System.Drawing.Point(256, 9);
            this.labelResoult.Name = "labelResoult";
            this.labelResoult.Size = new System.Drawing.Size(145, 113);
            this.labelResoult.TabIndex = 1;
            // 
            // panelMini
            // 
            this.panelMini.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMini.Location = new System.Drawing.Point(256, 102);
            this.panelMini.Name = "panelMini";
            this.panelMini.Size = new System.Drawing.Size(150, 150);
            this.panelMini.TabIndex = 2;
            // 
            // labelHelp
            // 
            this.labelHelp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHelp.Location = new System.Drawing.Point(256, 395);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(145, 98);
            this.labelHelp.TabIndex = 3;
            this.labelHelp.Text = "Управление:\r\nДвижение стрелками\r\nВлево, Вправо, Вниз\r\n\r\nПеревернуть - Вверх\r\nПауз" +
    "а - Пробел\r\nВыход - Escape";
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(292, 311);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(75, 23);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.Text = "Вниз";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(259, 282);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(44, 23);
            this.buttonLeft.TabIndex = 5;
            this.buttonLeft.Text = "<---";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(344, 282);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(44, 23);
            this.buttonRight.TabIndex = 6;
            this.buttonRight.Text = "--->";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 502);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.labelHelp);
            this.Controls.Add(this.panelMini);
            this.Controls.Add(this.labelResoult);
            this.Controls.Add(this.panelBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тетрис";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBoard;
        private System.Windows.Forms.Label labelResoult;
        private System.Windows.Forms.Panel panelMini;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
    }
}

