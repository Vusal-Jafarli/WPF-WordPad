namespace WordPad
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            font_combo = new ComboBox();
            size_combo = new ComboBox();
            color_combo = new ComboBox();
            right_button = new Button();
            center_button = new Button();
            left_button = new Button();
            italic_button = new Button();
            underline_button = new Button();
            bold_button = new Button();
            save_button = new Button();
            load_button = new Button();
            save_text = new RichTextBox();
            load_text = new RichTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            text_box = new RichTextBox();
            colorDialog1 = new ColorDialog();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(font_combo);
            panel1.Controls.Add(size_combo);
            panel1.Controls.Add(color_combo);
            panel1.Controls.Add(right_button);
            panel1.Controls.Add(center_button);
            panel1.Controls.Add(left_button);
            panel1.Controls.Add(italic_button);
            panel1.Controls.Add(underline_button);
            panel1.Controls.Add(bold_button);
            panel1.Controls.Add(save_button);
            panel1.Controls.Add(load_button);
            panel1.Controls.Add(save_text);
            panel1.Controls.Add(load_text);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 82);
            panel1.TabIndex = 0;
            // 
            // font_combo
            // 
            font_combo.FormattingEnabled = true;
            font_combo.Location = new Point(11, 36);
            font_combo.Name = "font_combo";
            font_combo.Size = new Size(92, 23);
            font_combo.TabIndex = 15;
            // 
            // size_combo
            // 
            size_combo.FormattingEnabled = true;
            size_combo.Location = new Point(117, 36);
            size_combo.Name = "size_combo";
            size_combo.Size = new Size(40, 23);
            size_combo.TabIndex = 14;
            size_combo.SelectedIndexChanged += size_combo_SelectedIndexChanged;
            // 
            // color_combo
            // 
            color_combo.FormattingEnabled = true;
            color_combo.Location = new Point(401, 37);
            color_combo.Name = "color_combo";
            color_combo.Size = new Size(121, 23);
            color_combo.TabIndex = 3;
            color_combo.SelectedIndexChanged += color_combo_SelectedIndexChanged;
            color_combo.Click += color_combo_Click;
            // 
            // right_button
            // 
            right_button.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            right_button.Location = new Point(354, 36);
            right_button.Name = "right_button";
            right_button.Size = new Size(27, 23);
            right_button.TabIndex = 13;
            right_button.Text = "R";
            right_button.UseVisualStyleBackColor = true;
            right_button.Click += right_button_Click;
            // 
            // center_button
            // 
            center_button.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            center_button.Location = new Point(321, 36);
            center_button.Name = "center_button";
            center_button.Size = new Size(27, 23);
            center_button.TabIndex = 12;
            center_button.Text = "C";
            center_button.UseVisualStyleBackColor = true;
            center_button.Click += center_button_Click;
            // 
            // left_button
            // 
            left_button.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            left_button.Location = new Point(288, 36);
            left_button.Name = "left_button";
            left_button.Size = new Size(27, 23);
            left_button.TabIndex = 11;
            left_button.Text = "L";
            left_button.UseVisualStyleBackColor = true;
            left_button.Click += left_button_Click;
            // 
            // italic_button
            // 
            italic_button.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point);
            italic_button.Location = new Point(238, 36);
            italic_button.Name = "italic_button";
            italic_button.Size = new Size(27, 23);
            italic_button.TabIndex = 10;
            italic_button.Text = "/";
            italic_button.UseVisualStyleBackColor = true;
            italic_button.Click += italic_button_Click;
            // 
            // underline_button
            // 
            underline_button.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            underline_button.Location = new Point(205, 36);
            underline_button.Name = "underline_button";
            underline_button.Size = new Size(27, 23);
            underline_button.TabIndex = 9;
            underline_button.Text = "U";
            underline_button.UseVisualStyleBackColor = true;
            underline_button.Click += underline_button_Click;
            // 
            // bold_button
            // 
            bold_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bold_button.Location = new Point(172, 36);
            bold_button.Name = "bold_button";
            bold_button.Size = new Size(27, 23);
            bold_button.TabIndex = 8;
            bold_button.Text = "B";
            bold_button.UseVisualStyleBackColor = true;
            bold_button.Click += bold_button_Click;
            // 
            // save_button
            // 
            save_button.BackColor = Color.White;
            save_button.Location = new Point(702, 41);
            save_button.Name = "save_button";
            save_button.Size = new Size(75, 23);
            save_button.TabIndex = 7;
            save_button.Text = "Save";
            save_button.UseVisualStyleBackColor = false;
            save_button.Click += save_button_Click;
            // 
            // load_button
            // 
            load_button.BackColor = Color.White;
            load_button.Location = new Point(702, 6);
            load_button.Name = "load_button";
            load_button.Size = new Size(75, 23);
            load_button.TabIndex = 6;
            load_button.Text = "Load";
            load_button.UseVisualStyleBackColor = false;
            load_button.Click += load_button_Click;
            // 
            // save_text
            // 
            save_text.Location = new Point(541, 41);
            save_text.Name = "save_text";
            save_text.Size = new Size(152, 22);
            save_text.TabIndex = 5;
            save_text.Text = "";
            // 
            // load_text
            // 
            load_text.Location = new Point(541, 8);
            load_text.Name = "load_text";
            load_text.Size = new Size(152, 22);
            load_text.TabIndex = 3;
            load_text.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(439, 8);
            label5.Name = "label5";
            label5.Size = new Size(40, 17);
            label5.TabIndex = 4;
            label5.Text = "Color";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(305, 8);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 3;
            label4.Text = "Allignment";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(194, 8);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 2;
            label3.Text = "FontSytle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(123, 9);
            label2.Name = "label2";
            label2.Size = new Size(31, 17);
            label2.TabIndex = 1;
            label2.Text = "Size";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 8);
            label1.Name = "label1";
            label1.Size = new Size(33, 17);
            label1.TabIndex = 0;
            label1.Text = "Font";
            // 
            // text_box
            // 
            text_box.Location = new Point(-2, 72);
            text_box.Name = "text_box";
            text_box.Size = new Size(800, 366);
            text_box.TabIndex = 2;
            text_box.Text = "";
            text_box.TextChanged += richTextBox1_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(text_box);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "WordPad";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RichTextBox text_box;
        private Label label2;
        private Label label1;
        private Button left_button;
        private Button italic_button;
        private Button underline_button;
        private Button bold_button;
        private Button save_button;
        private Button load_button;
        private RichTextBox save_text;
        private RichTextBox load_text;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button right_button;
        private Button center_button;
        private ComboBox color_combo;
        private ComboBox font_combo;
        private ComboBox size_combo;
        private ColorDialog colorDialog1;
        private OpenFileDialog openFileDialog1;
    }
}