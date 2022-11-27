namespace assignment11_yevhenii
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
            this.button_create = new System.Windows.Forms.Button();
            this.input_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.select_type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_list = new System.Windows.Forms.Label();
            this.input_age = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.input_age)).BeginInit();
            this.SuspendLayout();
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(178, 109);
            this.button_create.Margin = new System.Windows.Forms.Padding(4);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(124, 36);
            this.button_create.TabIndex = 0;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // input_name
            // 
            this.input_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.input_name.Location = new System.Drawing.Point(24, 75);
            this.input_name.Margin = new System.Windows.Forms.Padding(4);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(124, 26);
            this.input_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(180, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Create new pet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(222, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(62, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // select_type
            // 
            this.select_type.FormattingEnabled = true;
            this.select_type.Location = new System.Drawing.Point(330, 73);
            this.select_type.Name = "select_type";
            this.select_type.Size = new System.Drawing.Size(121, 28);
            this.select_type.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(369, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type";
            // 
            // label_list
            // 
            this.label_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_list.Location = new System.Drawing.Point(24, 161);
            this.label_list.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_list.Name = "label_list";
            this.label_list.Size = new System.Drawing.Size(426, 178);
            this.label_list.TabIndex = 8;
            // 
            // input_age
            // 
            this.input_age.Location = new System.Drawing.Point(184, 75);
            this.input_age.Name = "input_age";
            this.input_age.Size = new System.Drawing.Size(120, 26);
            this.input_age.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 359);
            this.Controls.Add(this.input_age);
            this.Controls.Add(this.label_list);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.select_type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.button_create);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Pet creator";
            ((System.ComponentModel.ISupportInitialize)(this.input_age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox select_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_list;
        private System.Windows.Forms.NumericUpDown input_age;
    }
}

