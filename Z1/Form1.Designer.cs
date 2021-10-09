
namespace Lab2_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lenghtBox1 = new System.Windows.Forms.TextBox();
            this.widthBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.answerBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите длину прямоугольника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите ширину прямоугольника";
            // 
            // lenghtBox1
            // 
            this.lenghtBox1.Location = new System.Drawing.Point(201, 90);
            this.lenghtBox1.Name = "lenghtBox1";
            this.lenghtBox1.Size = new System.Drawing.Size(102, 20);
            this.lenghtBox1.TabIndex = 1;
            this.lenghtBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lenghtBox1_KeyDown);
            // 
            // widthBox2
            // 
            this.widthBox2.Location = new System.Drawing.Point(201, 116);
            this.widthBox2.Name = "widthBox2";
            this.widthBox2.Size = new System.Drawing.Size(102, 20);
            this.widthBox2.TabIndex = 2;
            this.widthBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.widthBox2_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Разрезать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.answerBox1);
            this.groupBox1.Location = new System.Drawing.Point(9, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "";
            this.groupBox1.Text = "Ответ";
            // 
            // answerBox1
            // 
            this.answerBox1.Enabled = false;
            this.answerBox1.Location = new System.Drawing.Point(4, 16);
            this.answerBox1.Name = "answerBox1";
            this.answerBox1.ReadOnly = true;
            this.answerBox1.Size = new System.Drawing.Size(289, 94);
            this.answerBox1.TabIndex = 0;
            this.answerBox1.Text = "";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 78);
            this.label3.TabIndex = 6;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 289);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.widthBox2);
            this.Controls.Add(this.lenghtBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cut";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lenghtBox1;
        private System.Windows.Forms.TextBox widthBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox answerBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

