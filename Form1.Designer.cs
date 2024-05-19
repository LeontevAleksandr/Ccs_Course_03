namespace Ccs_Course_03
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
            picDisplay = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            tbSpreading = new TrackBar();
            label1 = new Label();
            tbSpeed = new TrackBar();
            label2 = new Label();
            tbParticlesPerTick = new TrackBar();
            label3 = new Label();
            tbLife = new TrackBar();
            label4 = new Label();
            tbRadius = new TrackBar();
            label5 = new Label();
            lblCountParticle = new Label();
            cbSpeedVector = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)picDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSpreading).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbParticlesPerTick).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbLife).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbRadius).BeginInit();
            SuspendLayout();
            // 
            // picDisplay
            // 
            picDisplay.Location = new Point(12, 12);
            picDisplay.Name = "picDisplay";
            picDisplay.Size = new Size(889, 488);
            picDisplay.TabIndex = 0;
            picDisplay.TabStop = false;
            picDisplay.MouseMove += picDisplay_MouseMove;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 40;
            timer1.Tick += timer1_Tick;
            // 
            // tbSpreading
            // 
            tbSpreading.Location = new Point(907, 36);
            tbSpreading.Maximum = 100;
            tbSpreading.Name = "tbSpreading";
            tbSpreading.Size = new Size(174, 56);
            tbSpreading.TabIndex = 1;
            tbSpreading.Scroll += tbSpreading_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(938, 13);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 2;
            label1.Text = "Распределение";
            // 
            // tbSpeed
            // 
            tbSpeed.Location = new Point(907, 122);
            tbSpeed.Minimum = 1;
            tbSpeed.Name = "tbSpeed";
            tbSpeed.Size = new Size(174, 56);
            tbSpeed.TabIndex = 3;
            tbSpeed.Value = 1;
            tbSpeed.Scroll += tbSpeed_Scroll;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(959, 99);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 4;
            label2.Text = "Скорость";
            // 
            // tbParticlesPerTick
            // 
            tbParticlesPerTick.Location = new Point(907, 205);
            tbParticlesPerTick.Maximum = 5;
            tbParticlesPerTick.Minimum = 1;
            tbParticlesPerTick.Name = "tbParticlesPerTick";
            tbParticlesPerTick.Size = new Size(174, 56);
            tbParticlesPerTick.TabIndex = 5;
            tbParticlesPerTick.TabStop = false;
            tbParticlesPerTick.Value = 1;
            tbParticlesPerTick.Scroll += tbParticlesPerTick_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(926, 182);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 6;
            label3.Text = "Количество частиц";
            // 
            // tbLife
            // 
            tbLife.Location = new Point(907, 287);
            tbLife.Maximum = 200;
            tbLife.Name = "tbLife";
            tbLife.Size = new Size(174, 56);
            tbLife.TabIndex = 7;
            tbLife.Scroll += tbLife_Scroll;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(893, 264);
            label4.Name = "label4";
            label4.Size = new Size(201, 20);
            label4.TabIndex = 8;
            label4.Text = "Продолжительность жизни";
            // 
            // tbRadius
            // 
            tbRadius.Location = new Point(907, 361);
            tbRadius.Maximum = 5;
            tbRadius.Minimum = 1;
            tbRadius.Name = "tbRadius";
            tbRadius.Size = new Size(174, 56);
            tbRadius.TabIndex = 9;
            tbRadius.Value = 1;
            tbRadius.Scroll += tbRadius_Scroll;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(936, 338);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 10;
            label5.Text = "Радиус частицы";
            // 
            // lblCountParticle
            // 
            lblCountParticle.AutoSize = true;
            lblCountParticle.Location = new Point(917, 416);
            lblCountParticle.Name = "lblCountParticle";
            lblCountParticle.Size = new Size(156, 20);
            lblCountParticle.TabIndex = 11;
            lblCountParticle.Text = "Количество частиц: 0";
            // 
            // cbSpeedVector
            // 
            cbSpeedVector.AutoSize = true;
            cbSpeedVector.Location = new Point(953, 458);
            cbSpeedVector.Name = "cbSpeedVector";
            cbSpeedVector.Size = new Size(79, 24);
            cbSpeedVector.TabIndex = 12;
            cbSpeedVector.Text = "Вектор";
            cbSpeedVector.UseVisualStyleBackColor = true;
            cbSpeedVector.CheckedChanged += cbSpeedVector_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 512);
            Controls.Add(cbSpeedVector);
            Controls.Add(lblCountParticle);
            Controls.Add(label5);
            Controls.Add(tbRadius);
            Controls.Add(label4);
            Controls.Add(tbLife);
            Controls.Add(label3);
            Controls.Add(tbParticlesPerTick);
            Controls.Add(label2);
            Controls.Add(tbSpeed);
            Controls.Add(label1);
            Controls.Add(tbSpreading);
            Controls.Add(picDisplay);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSpreading).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbParticlesPerTick).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbLife).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbRadius).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private TrackBar tbSpreading;
        private Label label1;
        private TrackBar tbSpeed;
        private Label label2;
        private TrackBar tbParticlesPerTick;
        private Label label3;
        private TrackBar tbLife;
        private Label label4;
        private TrackBar tbRadius;
        private Label label5;
        private Label lblCountParticle;
        private CheckBox cbSpeedVector;
    }
}
