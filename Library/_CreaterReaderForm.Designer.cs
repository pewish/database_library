namespace Library
{
    partial class _CreaterReaderForm
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFIO_reader = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnAddRead = new System.Windows.Forms.Button();
            this.txtBday = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО читателя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Номер телефона";
            // 
            // txtFIO_reader
            // 
            this.txtFIO_reader.Location = new System.Drawing.Point(178, 142);
            this.txtFIO_reader.Name = "txtFIO_reader";
            this.txtFIO_reader.Size = new System.Drawing.Size(332, 22);
            this.txtFIO_reader.TabIndex = 5;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(178, 303);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(148, 22);
            this.txtNum.TabIndex = 7;
            // 
            // btnAddRead
            // 
            this.btnAddRead.Location = new System.Drawing.Point(159, 377);
            this.btnAddRead.Name = "btnAddRead";
            this.btnAddRead.Size = new System.Drawing.Size(167, 38);
            this.btnAddRead.TabIndex = 8;
            this.btnAddRead.Text = "Добавить";
            this.btnAddRead.UseVisualStyleBackColor = true;
            this.btnAddRead.Click += new System.EventHandler(this.btnAddRead_Click);
            // 
            // txtBday
            // 
            this.txtBday.Location = new System.Drawing.Point(178, 226);
            this.txtBday.Name = "txtBday";
            this.txtBday.Size = new System.Drawing.Size(148, 22);
            this.txtBday.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(395, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 27);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // _CreaterReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 485);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtBday);
            this.Controls.Add(this.btnAddRead);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtFIO_reader);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "_CreaterReaderForm";
            this.Text = "_CreaterReaderForm";
            this.Load += new System.EventHandler(this._CreaterReaderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker txtBday;
        private System.Windows.Forms.Button btnAddRead;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtFIO_reader;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
    }
}