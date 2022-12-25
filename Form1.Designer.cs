namespace NoteTakingAppFinal
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.TextBox();
            this.Body = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.DisplaySQL = new System.Windows.Forms.DataGridView();
            this.NoteTitles = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DisplaySQL)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title Description";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(151, 56);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(292, 23);
            this.Title.TabIndex = 2;
            this.Title.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Body
            // 
            this.Body.Location = new System.Drawing.Point(151, 100);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(292, 298);
            this.Body.TabIndex = 3;
            this.Body.Text = "";
            this.Body.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Note Body";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(756, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "View Note";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DisplaySQL
            // 
            this.DisplaySQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplaySQL.Location = new System.Drawing.Point(464, 100);
            this.DisplaySQL.Name = "DisplaySQL";
            this.DisplaySQL.RowTemplate.Height = 25;
            this.DisplaySQL.Size = new System.Drawing.Size(458, 298);
            this.DisplaySQL.TabIndex = 6;
            this.DisplaySQL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DisplaySQL_CellContentClick);
            // 
            // NoteTitles
            // 
            this.NoteTitles.FormattingEnabled = true;
            this.NoteTitles.Location = new System.Drawing.Point(571, 405);
            this.NoteTitles.Name = "NoteTitles";
            this.NoteTitles.Size = new System.Drawing.Size(121, 23);
            this.NoteTitles.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(464, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Load Note Titles";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(837, 405);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Delete Note";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 459);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.NoteTitles);
            this.Controls.Add(this.DisplaySQL);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Note Taking App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DisplaySQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox Title;
        private RichTextBox Body;
        private Label label2;
        private Button button2;
        private DataGridView DisplaySQL;
        private ComboBox NoteTitles;
        private Button button3;
        private Button button4;
    }
}