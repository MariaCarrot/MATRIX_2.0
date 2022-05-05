namespace MATRIX_2._0
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
            this.SumMatrix = new System.Windows.Forms.Button();
            this.MinusMatrix = new System.Windows.Forms.Button();
            this.MultiplayMatrix = new System.Windows.Forms.Button();
            this.Row1 = new System.Windows.Forms.TextBox();
            this.Col1 = new System.Windows.Forms.TextBox();
            this.Row2 = new System.Windows.Forms.TextBox();
            this.Col2 = new System.Windows.Forms.TextBox();
            this.CreateMatrix = new System.Windows.Forms.Button();
            this.pan_mat1 = new System.Windows.Forms.Panel();
            this.pan_res = new System.Windows.Forms.Panel();
            this.pan_mat2 = new System.Windows.Forms.Panel();
            this.Random1 = new System.Windows.Forms.Button();
            this.Random2 = new System.Windows.Forms.Button();
            this.Random3 = new System.Windows.Forms.Button();
            this.Det2 = new System.Windows.Forms.Button();
            this.Det1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MultiplayNum1 = new System.Windows.Forms.Button();
            this.Transposition1 = new System.Windows.Forms.Button();
            this.Multiplay1 = new System.Windows.Forms.Button();
            this.pan_num1 = new System.Windows.Forms.Panel();
            this.MultiplayNum2 = new System.Windows.Forms.Button();
            this.Multiplay2 = new System.Windows.Forms.Button();
            this.pan_num2 = new System.Windows.Forms.Panel();
            this.Transposition2 = new System.Windows.Forms.Button();
            this.pan_det1 = new System.Windows.Forms.Panel();
            this.pan_det2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // SumMatrix
            // 
            this.SumMatrix.Location = new System.Drawing.Point(0, 38);
            this.SumMatrix.Name = "SumMatrix";
            this.SumMatrix.Size = new System.Drawing.Size(123, 41);
            this.SumMatrix.TabIndex = 1;
            this.SumMatrix.Text = "Сложение";
            this.SumMatrix.UseVisualStyleBackColor = true;
            this.SumMatrix.Click += new System.EventHandler(this.SumMatrix_Click);
            // 
            // MinusMatrix
            // 
            this.MinusMatrix.Location = new System.Drawing.Point(0, 85);
            this.MinusMatrix.Name = "MinusMatrix";
            this.MinusMatrix.Size = new System.Drawing.Size(123, 41);
            this.MinusMatrix.TabIndex = 2;
            this.MinusMatrix.Text = "Вычитание";
            this.MinusMatrix.UseVisualStyleBackColor = true;
            this.MinusMatrix.Click += new System.EventHandler(this.MinusMatrix_Click);
            // 
            // MultiplayMatrix
            // 
            this.MultiplayMatrix.Location = new System.Drawing.Point(0, 132);
            this.MultiplayMatrix.Name = "MultiplayMatrix";
            this.MultiplayMatrix.Size = new System.Drawing.Size(123, 41);
            this.MultiplayMatrix.TabIndex = 3;
            this.MultiplayMatrix.Text = "Перемножение";
            this.MultiplayMatrix.UseVisualStyleBackColor = true;
            this.MultiplayMatrix.Click += new System.EventHandler(this.MultiplayMatrix_Click);
            // 
            // Row1
            // 
            this.Row1.Location = new System.Drawing.Point(423, 9);
            this.Row1.Name = "Row1";
            this.Row1.Size = new System.Drawing.Size(32, 22);
            this.Row1.TabIndex = 4;
            this.Row1.Text = "1";
            this.Row1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Row1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Row1_KeyPress);
            // 
            // Col1
            // 
            this.Col1.Location = new System.Drawing.Point(487, 9);
            this.Col1.Name = "Col1";
            this.Col1.Size = new System.Drawing.Size(32, 22);
            this.Col1.TabIndex = 8;
            this.Col1.Text = "1";
            this.Col1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Col1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Col1_KeyPress);
            // 
            // Row2
            // 
            this.Row2.Location = new System.Drawing.Point(630, 9);
            this.Row2.Name = "Row2";
            this.Row2.Size = new System.Drawing.Size(32, 22);
            this.Row2.TabIndex = 9;
            this.Row2.Text = "1";
            this.Row2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Row2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Row2_KeyPress);
            // 
            // Col2
            // 
            this.Col2.Location = new System.Drawing.Point(692, 9);
            this.Col2.Name = "Col2";
            this.Col2.Size = new System.Drawing.Size(32, 22);
            this.Col2.TabIndex = 10;
            this.Col2.Text = "1";
            this.Col2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Col2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Col2_KeyPress);
            // 
            // CreateMatrix
            // 
            this.CreateMatrix.Location = new System.Drawing.Point(918, 12);
            this.CreateMatrix.Name = "CreateMatrix";
            this.CreateMatrix.Size = new System.Drawing.Size(145, 23);
            this.CreateMatrix.TabIndex = 11;
            this.CreateMatrix.Text = "Создать матрицы";
            this.CreateMatrix.UseVisualStyleBackColor = true;
            this.CreateMatrix.Click += new System.EventHandler(this.CreateMatrix_Click_1);
            // 
            // pan_mat1
            // 
            this.pan_mat1.Location = new System.Drawing.Point(142, 76);
            this.pan_mat1.Name = "pan_mat1";
            this.pan_mat1.Size = new System.Drawing.Size(354, 189);
            this.pan_mat1.TabIndex = 12;
            // 
            // pan_res
            // 
            this.pan_res.Location = new System.Drawing.Point(423, 412);
            this.pan_res.Name = "pan_res";
            this.pan_res.Size = new System.Drawing.Size(344, 185);
            this.pan_res.TabIndex = 13;
            // 
            // pan_mat2
            // 
            this.pan_mat2.Location = new System.Drawing.Point(546, 76);
            this.pan_mat2.Name = "pan_mat2";
            this.pan_mat2.Size = new System.Drawing.Size(352, 189);
            this.pan_mat2.TabIndex = 13;
            // 
            // Random1
            // 
            this.Random1.Location = new System.Drawing.Point(918, 38);
            this.Random1.Name = "Random1";
            this.Random1.Size = new System.Drawing.Size(145, 58);
            this.Random1.TabIndex = 14;
            this.Random1.Text = "Сгенерировать случайно 1-ю матрицу";
            this.Random1.UseVisualStyleBackColor = true;
            this.Random1.Click += new System.EventHandler(this.Random1_Click_1);
            // 
            // Random2
            // 
            this.Random2.Location = new System.Drawing.Point(918, 102);
            this.Random2.Name = "Random2";
            this.Random2.Size = new System.Drawing.Size(145, 58);
            this.Random2.TabIndex = 15;
            this.Random2.Text = "Сгенерировать случайно 2-ю матрицу";
            this.Random2.UseVisualStyleBackColor = true;
            this.Random2.Click += new System.EventHandler(this.Random2_Click);
            // 
            // Random3
            // 
            this.Random3.Location = new System.Drawing.Point(918, 166);
            this.Random3.Name = "Random3";
            this.Random3.Size = new System.Drawing.Size(145, 58);
            this.Random3.TabIndex = 16;
            this.Random3.Text = "Сгенерировать случайно обе матрицы";
            this.Random3.UseVisualStyleBackColor = true;
            this.Random3.Click += new System.EventHandler(this.Random3_Click);
            // 
            // Det2
            // 
            this.Det2.Location = new System.Drawing.Point(0, 244);
            this.Det2.Name = "Det2";
            this.Det2.Size = new System.Drawing.Size(123, 55);
            this.Det2.TabIndex = 17;
            this.Det2.Text = "Определитель 2 матрицы";
            this.Det2.UseVisualStyleBackColor = true;
            this.Det2.Click += new System.EventHandler(this.Det2_Click);
            // 
            // Det1
            // 
            this.Det1.Location = new System.Drawing.Point(0, 179);
            this.Det1.Name = "Det1";
            this.Det1.Size = new System.Drawing.Size(123, 59);
            this.Det1.TabIndex = 18;
            this.Det1.Text = "Определитель 1 матрицы";
            this.Det1.UseVisualStyleBackColor = true;
            this.Det1.Click += new System.EventHandler(this.Det1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 35);
            this.label1.TabIndex = 19;
            this.label1.Text = "Меню";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MultiplayNum1
            // 
            this.MultiplayNum1.Location = new System.Drawing.Point(0, 367);
            this.MultiplayNum1.Name = "MultiplayNum1";
            this.MultiplayNum1.Size = new System.Drawing.Size(123, 51);
            this.MultiplayNum1.TabIndex = 20;
            this.MultiplayNum1.Text = "Умножение на число 1-ю матрицу";
            this.MultiplayNum1.UseVisualStyleBackColor = true;
            this.MultiplayNum1.Click += new System.EventHandler(this.MultiplayNum1_Click_1);
            // 
            // Transposition1
            // 
            this.Transposition1.Location = new System.Drawing.Point(0, 305);
            this.Transposition1.Name = "Transposition1";
            this.Transposition1.Size = new System.Drawing.Size(123, 56);
            this.Transposition1.TabIndex = 21;
            this.Transposition1.Text = "Транспонирование 1-й матрицы";
            this.Transposition1.UseVisualStyleBackColor = true;
            this.Transposition1.Click += new System.EventHandler(this.Transposition1_Click);
            // 
            // Multiplay1
            // 
            this.Multiplay1.Location = new System.Drawing.Point(0, 424);
            this.Multiplay1.Name = "Multiplay1";
            this.Multiplay1.Size = new System.Drawing.Size(123, 50);
            this.Multiplay1.TabIndex = 22;
            this.Multiplay1.Text = "Умножить";
            this.Multiplay1.UseVisualStyleBackColor = true;
            this.Multiplay1.Click += new System.EventHandler(this.Multiplay1_Click);
            // 
            // pan_num1
            // 
            this.pan_num1.Location = new System.Drawing.Point(142, 401);
            this.pan_num1.Name = "pan_num1";
            this.pan_num1.Size = new System.Drawing.Size(56, 47);
            this.pan_num1.TabIndex = 23;
            // 
            // MultiplayNum2
            // 
            this.MultiplayNum2.Location = new System.Drawing.Point(0, 480);
            this.MultiplayNum2.Name = "MultiplayNum2";
            this.MultiplayNum2.Size = new System.Drawing.Size(123, 51);
            this.MultiplayNum2.TabIndex = 24;
            this.MultiplayNum2.Text = "Умножение на число 2-ю матрицу";
            this.MultiplayNum2.UseVisualStyleBackColor = true;
            this.MultiplayNum2.Click += new System.EventHandler(this.MultiplayNum2_Click);
            // 
            // Multiplay2
            // 
            this.Multiplay2.Location = new System.Drawing.Point(0, 537);
            this.Multiplay2.Name = "Multiplay2";
            this.Multiplay2.Size = new System.Drawing.Size(123, 50);
            this.Multiplay2.TabIndex = 25;
            this.Multiplay2.Text = "Умножить";
            this.Multiplay2.UseVisualStyleBackColor = true;
            this.Multiplay2.Click += new System.EventHandler(this.Multiplay2_Click);
            // 
            // pan_num2
            // 
            this.pan_num2.Location = new System.Drawing.Point(142, 512);
            this.pan_num2.Name = "pan_num2";
            this.pan_num2.Size = new System.Drawing.Size(56, 47);
            this.pan_num2.TabIndex = 26;
            // 
            // Transposition2
            // 
            this.Transposition2.Location = new System.Drawing.Point(142, 305);
            this.Transposition2.Name = "Transposition2";
            this.Transposition2.Size = new System.Drawing.Size(123, 56);
            this.Transposition2.TabIndex = 27;
            this.Transposition2.Text = "Транспонирование 2-й матрицы";
            this.Transposition2.UseVisualStyleBackColor = true;
            this.Transposition2.Click += new System.EventHandler(this.Transposition2_Click);
            // 
            // pan_det1
            // 
            this.pan_det1.Location = new System.Drawing.Point(440, 296);
            this.pan_det1.Name = "pan_det1";
            this.pan_det1.Size = new System.Drawing.Size(56, 47);
            this.pan_det1.TabIndex = 28;
            // 
            // pan_det2
            // 
            this.pan_det2.Location = new System.Drawing.Point(546, 296);
            this.pan_det2.Name = "pan_det2";
            this.pan_det2.Size = new System.Drawing.Size(56, 47);
            this.pan_det2.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 638);
            this.Controls.Add(this.pan_det2);
            this.Controls.Add(this.pan_det1);
            this.Controls.Add(this.Transposition2);
            this.Controls.Add(this.pan_num2);
            this.Controls.Add(this.Multiplay2);
            this.Controls.Add(this.MultiplayNum2);
            this.Controls.Add(this.pan_num1);
            this.Controls.Add(this.Multiplay1);
            this.Controls.Add(this.Transposition1);
            this.Controls.Add(this.MultiplayNum1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Det1);
            this.Controls.Add(this.Det2);
            this.Controls.Add(this.Random3);
            this.Controls.Add(this.pan_mat2);
            this.Controls.Add(this.Random2);
            this.Controls.Add(this.Random1);
            this.Controls.Add(this.pan_res);
            this.Controls.Add(this.pan_mat1);
            this.Controls.Add(this.CreateMatrix);
            this.Controls.Add(this.Col2);
            this.Controls.Add(this.Row2);
            this.Controls.Add(this.Col1);
            this.Controls.Add(this.Row1);
            this.Controls.Add(this.MultiplayMatrix);
            this.Controls.Add(this.MinusMatrix);
            this.Controls.Add(this.SumMatrix);
            this.Name = "Form1";
            this.Text = "Калькулятор матриц";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SumMatrix;
        private System.Windows.Forms.Button MinusMatrix;
        private System.Windows.Forms.Button MultiplayMatrix;
        private System.Windows.Forms.TextBox Row1;
        private System.Windows.Forms.TextBox Col1;
        private System.Windows.Forms.TextBox Row2;
        private System.Windows.Forms.TextBox Col2;
        private System.Windows.Forms.Button CreateMatrix;
        private System.Windows.Forms.Panel pan_mat1;
        private System.Windows.Forms.Panel pan_res;
        private System.Windows.Forms.Panel pan_mat2;
        private System.Windows.Forms.Button Random1;
        private System.Windows.Forms.Button Random2;
        private System.Windows.Forms.Button Random3;
        private System.Windows.Forms.Button Det2;
        private System.Windows.Forms.Button Det1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MultiplayNum1;
        private System.Windows.Forms.Button Transposition1;
        private System.Windows.Forms.Button Multiplay1;
        private System.Windows.Forms.Panel pan_num1;
        private System.Windows.Forms.Button MultiplayNum2;
        private System.Windows.Forms.Button Multiplay2;
        private System.Windows.Forms.Panel pan_num2;
        private System.Windows.Forms.Button Transposition2;
        private System.Windows.Forms.Panel pan_det1;
        private System.Windows.Forms.Panel pan_det2;
    }
}

