namespace guestEnterShabat
{
    partial class FoodForm
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            button1 = new Button();
            textBox1 = new TextBox();
            buttonNext = new Button();
            buttonPrev = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(515, 61);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(161, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(799, 300);
            dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(161, 531);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 82;
            dataGridView2.Size = new Size(799, 300);
            dataGridView2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(616, 465);
            button1.Name = "button1";
            button1.Size = new Size(190, 46);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(326, 469);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 39);
            textBox1.TabIndex = 4;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(714, 895);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(185, 66);
            buttonNext.TabIndex = 5;
            buttonNext.Text = ">>";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // buttonPrev
            // 
            buttonPrev.Location = new Point(254, 895);
            buttonPrev.Name = "buttonPrev";
            buttonPrev.Size = new Size(185, 66);
            buttonPrev.TabIndex = 6;
            buttonPrev.Text = "<<";
            buttonPrev.UseVisualStyleBackColor = true;
            buttonPrev.Click += buttonPrev_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(482, 61);
            label2.Name = "label2";
            label2.Size = new Size(27, 32);
            label2.TabIndex = 7;
            label2.Text = "1";
            // 
            // FoodForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 1032);
            Controls.Add(label2);
            Controls.Add(buttonPrev);
            Controls.Add(buttonNext);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "FoodForm";
            Text = "Food";
            FormClosed += FoodForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button button1;
        private TextBox textBox1;
        private Button buttonNext;
        private Button buttonPrev;
        private Label label2;
    }
}