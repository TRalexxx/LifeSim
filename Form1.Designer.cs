namespace LifeSim
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
            components = new System.ComponentModel.Container();
            fieldPanel = new Panel();
            gamePicBox = new PictureBox();
            startBtn = new Button();
            stopBtn = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            intervalNud = new NumericUpDown();
            label1 = new Label();
            generationLable = new Label();
            fieldPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gamePicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)intervalNud).BeginInit();
            SuspendLayout();
            // 
            // fieldPanel
            // 
            fieldPanel.Controls.Add(gamePicBox);
            fieldPanel.Location = new Point(12, 76);
            fieldPanel.Name = "fieldPanel";
            fieldPanel.Size = new Size(857, 494);
            fieldPanel.TabIndex = 4;
            // 
            // gamePicBox
            // 
            gamePicBox.Dock = DockStyle.Fill;
            gamePicBox.Location = new Point(0, 0);
            gamePicBox.Name = "gamePicBox";
            gamePicBox.Size = new Size(857, 494);
            gamePicBox.TabIndex = 0;
            gamePicBox.TabStop = false;
            gamePicBox.MouseMove += gamePicBox_MouseMove;
            // 
            // startBtn
            // 
            startBtn.Location = new Point(12, 12);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(75, 23);
            startBtn.TabIndex = 5;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // stopBtn
            // 
            stopBtn.Location = new Point(93, 12);
            stopBtn.Name = "stopBtn";
            stopBtn.Size = new Size(75, 23);
            stopBtn.TabIndex = 6;
            stopBtn.Text = "Stop";
            stopBtn.UseVisualStyleBackColor = true;
            stopBtn.Click += stopBtn_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // intervalNud
            // 
            intervalNud.Location = new Point(57, 47);
            intervalNud.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            intervalNud.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            intervalNud.Name = "intervalNud";
            intervalNud.Size = new Size(101, 23);
            intervalNud.TabIndex = 7;
            intervalNud.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 8;
            label1.Text = "Speed";
            // 
            // generationLable
            // 
            generationLable.AutoSize = true;
            generationLable.Location = new Point(239, 20);
            generationLable.Name = "generationLable";
            generationLable.Size = new Size(31, 15);
            generationLable.TabIndex = 9;
            generationLable.Text = "Gen:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 581);
            Controls.Add(generationLable);
            Controls.Add(label1);
            Controls.Add(intervalNud);
            Controls.Add(stopBtn);
            Controls.Add(startBtn);
            Controls.Add(fieldPanel);
            Name = "Form1";
            Text = "Form1";
            SizeChanged += Form1_SizeChanged;
            fieldPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gamePicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)intervalNud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel fieldPanel;
        private Button startBtn;
        private Button stopBtn;
        private System.Windows.Forms.Timer timer1;
        private PictureBox gamePicBox;
        private NumericUpDown intervalNud;
        private Label label1;
        private Label generationLable;
    }
}