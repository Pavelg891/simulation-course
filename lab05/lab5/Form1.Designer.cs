namespace lab5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxYesNo = new System.Windows.Forms.TextBox();
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.labelYesNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMagic8Ball = new System.Windows.Forms.TextBox();
            this.buttonMagic8Ball = new System.Windows.Forms.Button();
            this.labelMagic8Ball = new System.Windows.Forms.Label();
            this.buttonStats = new System.Windows.Forms.Button();
            this.labelStats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxYesNo
            // 
            this.textBoxYesNo.Location = new System.Drawing.Point(63, 48);
            this.textBoxYesNo.Name = "textBoxYesNo";
            this.textBoxYesNo.Size = new System.Drawing.Size(165, 20);
            this.textBoxYesNo.TabIndex = 0;
            this.textBoxYesNo.Text = "Пойти сегодня в университет?";
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.Location = new System.Drawing.Point(63, 95);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(75, 23);
            this.buttonAnswer.TabIndex = 1;
            this.buttonAnswer.Text = "ответ";
            this.buttonAnswer.UseVisualStyleBackColor = true;
            this.buttonAnswer.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // labelYesNo
            // 
            this.labelYesNo.AutoSize = true;
            this.labelYesNo.Location = new System.Drawing.Point(60, 143);
            this.labelYesNo.Name = "labelYesNo";
            this.labelYesNo.Size = new System.Drawing.Size(0, 13);
            this.labelYesNo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Скажи \"да\" или \"нет\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Шар предсказаний";
            // 
            // textBoxMagic8Ball
            // 
            this.textBoxMagic8Ball.Location = new System.Drawing.Point(379, 48);
            this.textBoxMagic8Ball.Name = "textBoxMagic8Ball";
            this.textBoxMagic8Ball.Size = new System.Drawing.Size(165, 20);
            this.textBoxMagic8Ball.TabIndex = 5;
            this.textBoxMagic8Ball.Text = "Пойти сегодня в университет?";
            // 
            // buttonMagic8Ball
            // 
            this.buttonMagic8Ball.Location = new System.Drawing.Point(379, 95);
            this.buttonMagic8Ball.Name = "buttonMagic8Ball";
            this.buttonMagic8Ball.Size = new System.Drawing.Size(75, 23);
            this.buttonMagic8Ball.TabIndex = 6;
            this.buttonMagic8Ball.Text = "ответ";
            this.buttonMagic8Ball.UseVisualStyleBackColor = true;
            this.buttonMagic8Ball.Click += new System.EventHandler(this.buttonMagic8Ball_Click);
            // 
            // labelMagic8Ball
            // 
            this.labelMagic8Ball.AutoSize = true;
            this.labelMagic8Ball.Location = new System.Drawing.Point(376, 143);
            this.labelMagic8Ball.Name = "labelMagic8Ball";
            this.labelMagic8Ball.Size = new System.Drawing.Size(0, 13);
            this.labelMagic8Ball.TabIndex = 7;
            // 
            // buttonStats
            // 
            this.buttonStats.Location = new System.Drawing.Point(583, 95);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.Size = new System.Drawing.Size(75, 23);
            this.buttonStats.TabIndex = 8;
            this.buttonStats.Text = "статистика";
            this.buttonStats.UseVisualStyleBackColor = true;
            this.buttonStats.Click += new System.EventHandler(this.buttonStats_Click);
            // 
            // labelStats
            // 
            this.labelStats.AutoSize = true;
            this.labelStats.Location = new System.Drawing.Point(580, 143);
            this.labelStats.Name = "labelStats";
            this.labelStats.Size = new System.Drawing.Size(0, 13);
            this.labelStats.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelStats);
            this.Controls.Add(this.buttonStats);
            this.Controls.Add(this.labelMagic8Ball);
            this.Controls.Add(this.buttonMagic8Ball);
            this.Controls.Add(this.textBoxMagic8Ball);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelYesNo);
            this.Controls.Add(this.buttonAnswer);
            this.Controls.Add(this.textBoxYesNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxYesNo;
        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.Label labelYesNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMagic8Ball;
        private System.Windows.Forms.Button buttonMagic8Ball;
        private System.Windows.Forms.Label labelMagic8Ball;
        private System.Windows.Forms.Button buttonStats;
        private System.Windows.Forms.Label labelStats;
    }
}

