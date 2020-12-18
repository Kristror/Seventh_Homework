
namespace Doubler
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
            this.numberLablel = new System.Windows.Forms.Label();
            this.add1Button = new System.Windows.Forms.Button();
            this.doublerButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.number2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberLablel
            // 
            this.numberLablel.AutoSize = true;
            this.numberLablel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLablel.Location = new System.Drawing.Point(12, 51);
            this.numberLablel.Name = "numberLablel";
            this.numberLablel.Size = new System.Drawing.Size(54, 20);
            this.numberLablel.TabIndex = 0;
            this.numberLablel.Text = "число";
            // 
            // add1Button
            // 
            this.add1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add1Button.Location = new System.Drawing.Point(258, 12);
            this.add1Button.Name = "add1Button";
            this.add1Button.Size = new System.Drawing.Size(103, 34);
            this.add1Button.TabIndex = 1;
            this.add1Button.Text = "+ 1";
            this.add1Button.UseVisualStyleBackColor = true;
            this.add1Button.Click += new System.EventHandler(this.Add1Button_Click);
            // 
            // doublerButton
            // 
            this.doublerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doublerButton.Location = new System.Drawing.Point(258, 51);
            this.doublerButton.Name = "doublerButton";
            this.doublerButton.Size = new System.Drawing.Size(103, 34);
            this.doublerButton.TabIndex = 2;
            this.doublerButton.Text = "x 2";
            this.doublerButton.UseVisualStyleBackColor = true;
            this.doublerButton.Click += new System.EventHandler(this.DoublerButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(258, 131);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(103, 34);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Сброс";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.undoButton.Location = new System.Drawing.Point(258, 91);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(103, 34);
            this.undoButton.TabIndex = 4;
            this.undoButton.Text = "Отменить";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playButton.Location = new System.Drawing.Point(126, 168);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(103, 34);
            this.playButton.TabIndex = 5;
            this.playButton.Text = "Играть";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Нужно получить:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ваше число:";
            // 
            // number2Label
            // 
            this.number2Label.AutoSize = true;
            this.number2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number2Label.Location = new System.Drawing.Point(12, 131);
            this.number2Label.Name = "number2Label";
            this.number2Label.Size = new System.Drawing.Size(63, 20);
            this.number2Label.TabIndex = 8;
            this.number2Label.Text = "число2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 214);
            this.Controls.Add(this.number2Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.doublerButton);
            this.Controls.Add(this.add1Button);
            this.Controls.Add(this.numberLablel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удвоитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberLablel;
        private System.Windows.Forms.Button add1Button;
        private System.Windows.Forms.Button doublerButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label number2Label;
    }
}

