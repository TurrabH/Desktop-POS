using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS {
    public partial class add_item_dialogue : Form {
        public DialogResult result = DialogResult.Cancel;
        public add_item_dialogue() {
            InitializeComponent();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e) {

        }

        private void Add_remove_items_add_btn_Click(object sender, EventArgs e) {
            if (get_name().Length == 0 || get_ingredients().Length == 0 || get_image_path().Length == 0 || get_price().Length == 0)
                MessageBox.Show("Some fields are empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                try {
                    float.Parse(get_price());
                    result = DialogResult.OK;
                    this.Close();
                } catch (System.FormatException) {
                    MessageBox.Show("Price Error!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public string get_name() {
            return this.item_name_txt_box.Text;
        }
        public string get_price() {
            return this.item_price_txt_box.Text;
        }

        public string get_ingredients() {
            return this.item_ingredients_txt_box.Text;
        }

        public string get_image_path() {
            return file_name_lbl.Text;
        }

        public Item get_new_created_item() {
            return new Item(get_name(), float.Parse(get_price()), get_ingredients(), get_image_path());
        }

        private void Choose_file_btn_Click(object sender, EventArgs e) {
            OpenFileDialog file_dialogue = new OpenFileDialog();
            file_dialogue.Filter = "Image Files (*.png)|*.png";
            if (file_dialogue.ShowDialog() == DialogResult.OK) {
                this.file_name_lbl.Text = file_dialogue.FileName;
            }
        }
    }
}
