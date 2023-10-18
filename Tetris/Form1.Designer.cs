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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelBoard = new System.Windows.Forms.Panel();
            this.labelPause = new System.Windows.Forms.Label();
            this.labelResoult = new System.Windows.Forms.Label();
            this.panelMini = new System.Windows.Forms.Panel();
            this.labelHelp = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
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
            // labelPause
            // 
            this.labelPause.AutoSize = true;
            this.labelPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPause.ForeColor = System.Drawing.Color.Red;
            this.labelPause.Location = new System.Drawing.Point(29, 166);
            this.labelPause.Name = "labelPause";
            this.labelPause.Size = new System.Drawing.Size(191, 42);
            this.labelPause.TabIndex = 0;
            this.labelPause.Text = "П А У З А";
            this.labelPause.Visible = false;
            // 
            // labelResoult
            // 
            this.labelResoult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResoult.Location = new System.Drawing.Point(256, 9);
            this.labelResoult.Name = "labelResoult";
            this.labelResoult.Size = new System.Drawing.Size(150, 82);
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
            this.labelHelp.Location = new System.Drawing.Point(256, 376);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(145, 98);
            this.labelHelp.TabIndex = 3;
            this.labelHelp.Text = "Управление:\r\nДвижение стрелками\r\nВлево, Вправо, Вниз\r\n\r\nПеревернуть - Вверх\r\nПауз" +
    "а - Пробел\r\nВыход - Escape";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 502);
            this.Controls.Add(this.labelPause);
            this.Controls.Add(this.labelHelp);
            this.Controls.Add(this.panelMini);
            this.Controls.Add(this.labelResoult);
            this.Controls.Add(this.panelBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тетрис";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBoard;
        private System.Windows.Forms.Label labelResoult;
        private System.Windows.Forms.Panel panelMini;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelPause;
    }
}

