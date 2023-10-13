using System.Text.Json;
using System.Windows.Forms;

namespace WordPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> font = new List<string>();
            List<string> size = new List<string>()
           { "8","9","10","11","12","14","16","18","20","22","24","26","28","36","48","72"};
            size_combo.DataSource = size;
            color_combo.Text = "Black";
            foreach (var item in FontFamily.Families)
                font.Add(item.Name);

            font_combo.DataSource = font;
        }

        private void bold_button_Click(object sender, EventArgs e)
        {

            if (text_box.Font.Style == FontStyle.Bold)
            {

                text_box.Font = new System.Drawing.Font(text_box.Font, System.Drawing.FontStyle.Regular);
            }
            else
                text_box.Font = new System.Drawing.Font(text_box.Font, System.Drawing.FontStyle.Bold);

        }

        private void underline_button_Click(object sender, EventArgs e)
        {
            if (text_box.Font.Style == FontStyle.Underline)
            {

                text_box.Font = new System.Drawing.Font(text_box.Font, System.Drawing.FontStyle.Regular);
            }
            else
                text_box.Font = new System.Drawing.Font(text_box.Font, System.Drawing.FontStyle.Underline);

        }

        private void italic_button_Click(object sender, EventArgs e)
        {
            if (text_box.Font.Style == FontStyle.Italic)
            {

                text_box.Font = new System.Drawing.Font(text_box.Font, System.Drawing.FontStyle.Regular);
            }
            else
                text_box.Font = new System.Drawing.Font(text_box.Font, System.Drawing.FontStyle.Italic);

        }

        private void left_button_Click(object sender, EventArgs e)
        {
            text_box.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void center_button_Click(object sender, EventArgs e)
        {
            text_box.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void right_button_Click(object sender, EventArgs e)
        {
            text_box.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void color_combo_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void color_combo_Click(object sender, EventArgs e)
        {
            var result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                text_box.ForeColor = colorDialog1.Color;
                color_combo.Text = colorDialog1.Color.ToString().Remove(0, 6);
            }
        }

        private void size_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedFontSize = int.Parse(size_combo.SelectedItem.ToString());


            text_box.Font = new Font(text_box.Font.FontFamily, selectedFontSize);
        }
        private void save_button_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Save Ankets";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";

            var file = openFileDialog1.ShowDialog();
            if (file == DialogResult.OK)
            {
                var filename = openFileDialog1.FileName;
                File.WriteAllText(filename, text_box.Text);
            }
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Save Ankets";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";

            var file = openFileDialog1.ShowDialog();
            if (file == DialogResult.OK)
            {
                var filename = openFileDialog1.FileName;
                text_box.Text = File.ReadAllText(filename);
            }
        }
    }
}