using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace POS {

    public partial class main_form : Form {
        private List<int> menu_indexes_changed = new List<int>();
        //private string db_connection_string = "";
        private string db_connection_string = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
            "AttachDbFilename=D:\\PROJECTS\\VS\\c#\\POS\\POS\\POS_DB.mdf;" +
            "Integrated Security=True";
        private SqlConnection connection;
        public main_form() {
            string current_directory = Directory.GetCurrentDirectory();
            InitializeComponent();
            initialize();
            db_connection_string = Properties.Settings.Default.PosDB;
            connection = new SqlConnection(db_connection_string);
            load_data_from_db();
        }

        public static double get_digits(string value) {
            return float.Parse(new String(value.Where(Char.IsDigit).ToArray()));
        }
        private void menu_click_event(object sender, EventArgs e) {

            Control object_clicked = sender as Control;
            switch (object_clicked.Tag) {
                case "home":
                    menu_clicked(menu_home_pnl, page_home_main_pnl);
                    break;
                case "menu":
                    menu_clicked(menu_items_menu_pnl, page_add_remove_items_pnl);
                    break;
                case "history":
                    menu_clicked(menu_order_history_pnl, page_order_history_panel_main_pnl);
                    break;
                case "stock":
                    menu_clicked(menu_stock_pnl, page_stock_panel_main_pnl);
                    break;

            }
        }

        private void Add_remove_items_add_btn_Click(object sender, EventArgs e) {
            add_item_dialogue add_item = new add_item_dialogue();
            add_item.ShowDialog(this);
            if (DialogResult.OK == add_item.result) {
                Item new_item = add_item.get_new_created_item();
                this.add_item_to_db(new_item);
                show_item_on_menu(new_item);
                show_item_on_home(new_item);
            }
        }

        private void show_item_on_home(Item new_item) {
            Menu_item_design menu_item = new Menu_item_design(new_item.get_image(), new_item.get_name(), new_item.get_price().ToString() + "Rs", new_item.get_name(), order_items_flow_layout_pnl, add_item);
            order_menu_area_flow_layout_pnl.Controls.Add(menu_item.get_order_panel());
        }

        private void add_item(int quantity, string price_of_single_item) {
            double total_quantity = get_digits(this.total_quantity_value_lbl.Text);
            double total_price = get_digits(this.sub_total_value_lbl.Text);
            double tax = get_digits(this.tax_lbl.Text);
            double price_of_one = get_digits(price_of_single_item);
            total_quantity += quantity;
            total_price += (quantity * price_of_one);
            double tax_price = total_price * tax / 100;
            this.tax_value_lbl.Text = tax_price + " Rs";
            this.total_quantity_value_lbl.Text = total_quantity + " Items";
            this.sub_total_value_lbl.Text = total_price + " Rs";
            this.total_amount_value_lbl.Text = (total_price + tax_price) + " Rs";
        }

        private void show_item_on_menu(Item new_item) {
            int new_index = this.menu_table_tbl.Rows.Add();
            DataGridViewRow new_row = this.menu_table_tbl.Rows[new_index];
            Image image = new_item.get_image();
            new_row.Cells["check_box"].Value = new_item.get_checked();
            new_row.Cells["item_name"].Value = new_item.get_name();
            new_row.Cells["item_price"].Value = new_item.get_price() + "Rs";
            new_row.Cells["item_ingredients"].Value = new_item.get_ingredients();
            new_row.Cells["item_image"].Value = new_item.get_image();
        }

        private void Menu_table_tbl_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == this.menu_table_tbl.Columns["item_delete"].Index && e.RowIndex >= 0) {
                if (MessageBox.Show("Do you want to delete this item?", "Delete Item", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {

                    this.menu_table_tbl.Rows.RemoveAt(e.RowIndex);
                    order_menu_area_flow_layout_pnl.Controls.RemoveAt(e.RowIndex);
                    this.remove_item_in_db(e.RowIndex);
                }
            }
            if (e.ColumnIndex == this.menu_table_tbl.Columns["item_image"].Index && e.RowIndex >= 0) {
                mark_row(e.RowIndex);
                OpenFileDialog file_dialogue = new OpenFileDialog();
                file_dialogue.Filter = "Image Files (*.png)|*.png";
                if (file_dialogue.ShowDialog(this) == DialogResult.OK) {
                    this.menu_table_tbl.Rows[e.RowIndex].Cells["item_image"].Value = Image.FromFile(file_dialogue.FileName);
                }
            }
        }

        private void Menu_table_tbl_CellEdit(object sender, DataGridViewCellCancelEventArgs e) {
            if ((e.ColumnIndex > 1 && e.ColumnIndex < this.menu_table_tbl.Columns["item_delete"].Index) && e.RowIndex >= 0)
                mark_row(e.RowIndex);
        }

        private void mark_row(int index) {
            this.add_remove_items_save_changes_btn.Enabled = true;
            if (!this.menu_indexes_changed.Contains(index))
                this.menu_indexes_changed.Add(index);
        }

        private void Delete_selected_Click(object sender, EventArgs e) {
            if(MessageBox.Show("Do you want to delete selected items?","Delete Items", MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
                foreach (DataGridViewRow row in this.menu_table_tbl.Rows)
                    if ((bool)row.Cells["check_box"].Value){
                        order_menu_area_flow_layout_pnl.Controls.RemoveAt(row.Index);
                        this.menu_table_tbl.Rows.Remove(row);
                        this.remove_item_in_db(row.Index);

                    }
        }

        private void Add_remove_items_save_changes_btn_Click(object sender, EventArgs e) {
            foreach (int row_index in this.menu_indexes_changed) {
                string item_name = (string)this.menu_table_tbl.Rows[row_index].Cells["item_name"].Value;
                string item_price = (string)this.menu_table_tbl.Rows[row_index].Cells["item_price"].Value;
                string item_ingredients = (string)this.menu_table_tbl.Rows[row_index].Cells["item_ingredients"].Value;
                Image item_image = (Image)this.menu_table_tbl.Rows[row_index].Cells["item_image"].Value;
                Control order_panel = order_menu_area_flow_layout_pnl.Controls[row_index];
                ((Label)get_control_by_name("item_lbl",order_panel)).Text = item_name;
                ((Label)get_control_by_name("price_lbl", order_panel)).Text = item_price;
                ((PictureBox)get_control_by_name("item_img_picture_box", order_panel)).Image = item_image;
                this.update_item_in_db(new Item(item_name,float.Parse(item_price.Replace("Rs","").Trim(' ')),item_ingredients,item_image), row_index);
            }
            this.menu_indexes_changed.Clear();
            this.add_remove_items_save_changes_btn.Enabled = false;
        }

        private Control get_control_by_name(string name, Control control_to_search) {
            if (control_to_search.Name == name)
                return control_to_search;
            foreach (Control control in control_to_search.Controls) {
                Control control_found = get_control_by_name(name, control);
                if (control_found != null)
                    return control_found;
            }
            return null;
        }

        private void Place_order_btn_Click(object sender, EventArgs e) {
            if (this.order_items_flow_layout_pnl.Controls.Count > 0) {
                DateTime date_time = DateTime.Now;
                string date = date_time.ToString("dd-MM-yy");
                string time = date_time.ToString("hh:mm tt");
                string order_id = this.order_id_lbl.Text;
                string total_quantity = get_digits(this.total_quantity_value_lbl.Text).ToString();
                string tax_price = get_digits(this.tax_value_lbl.Text).ToString();
                string total_price = get_digits(this.total_amount_value_lbl.Text).ToString();
                this.add_history(new Dictionary<string, string>() {
                    { "date", date},
                    {"time",time },
                    {"id", order_id },
                    {"quantity", total_quantity },
                    {"tax", tax_price },
                    {"price", total_price }
                });
                this.add_orders_to_db(new Dictionary<string, string>() {
                    { "date", date},
                    {"time",time },
                    {"id", order_id },
                    {"quantity", total_quantity },
                    {"tax", tax_price },
                    {"price", total_price }
                });
                this.order_id_lbl.Text = "#"+generate_order_id(10);
                this.clear_order();
            }
        }

        private void clear_order() {
            this.order_items_flow_layout_pnl.Controls.Clear();
            this.sub_total_value_lbl.Text = "0 Rs";
            this.total_quantity_value_lbl.Text = "0 Items";
            this.tax_value_lbl.Text = "0 Rs";
            this.total_amount_value_lbl.Text = "0 Rs";
        }

        private void add_history(Dictionary<string, string> order) {
            int new_index = this.order_history_table_tbl.Rows.Add();
            DataGridViewRow new_row = this.order_history_table_tbl.Rows[new_index];
            new_row.Cells["order_date_time"].Value = order["date"];
            new_row.Cells["order_time"].Value = order["time"];
            new_row.Cells["order_no"].Value = order["id"];
            new_row.Cells["item_quantity"].Value = order["quantity"];
            new_row.Cells["order_tax"].Value = order["tax"];
            new_row.Cells["total_price"].Value = order["price"];
        }

        private void out_stock(object sender, DataGridViewCellEventArgs e) {
            int selected_index = e.RowIndex;
            DataGridViewRow edit_row = this.stock_panel_tabel_tbl.Rows[selected_index];
            string stock_name = edit_row.Cells["stock_name"].Value.ToString();
            out_stock_dialog dialogue = new out_stock_dialog(stock_name);
            dialogue.ShowDialog();
            if (DialogResult.OK == dialogue.result) {
                int out_quantity = int.Parse(dialogue.get_out_quantity());
                int in_quantity = int.Parse(dialogue.get_in_quantity());
                int table_remaining_stock = int.Parse((string)edit_row.Cells["stock_remaining"].Value);
                int table_in_stock = int.Parse((string)edit_row.Cells["stock_in"].Value);
                int table_out_stock = int.Parse((string)edit_row.Cells["stock_out"].Value);
                table_remaining_stock += in_quantity;
                table_remaining_stock -= out_quantity;
                edit_row.Cells["stock_out"].Value = (out_quantity+table_out_stock).ToString();
                edit_row.Cells["stock_in"].Value = (in_quantity+table_in_stock).ToString();
                edit_row.Cells["stock_remaining"].Value = table_remaining_stock;
                this.update_stock_in_db(new Dictionary<string, string>() {
                    {"stock_in", (in_quantity+table_in_stock).ToString() },
                    {"stock_out", (out_quantity+table_out_stock).ToString() },
                    {"stock_remaining",table_remaining_stock.ToString() },
                }, e.RowIndex);
            }
        }

        private void Stock_panel_add_btn_Click(object sender, EventArgs e) {
            add_stock_dialog add_stock_dialog = new add_stock_dialog();
            add_stock_dialog.ShowDialog(this);
            if (add_stock_dialog.result == DialogResult.OK) {
                string item_name = add_stock_dialog.get_stock_name();
                string item_quantity = add_stock_dialog.get_quantity();
                string item_price = add_stock_dialog.get_price();
                string total_price = (float.Parse(item_price) * float.Parse(item_quantity)).ToString();
                this.add_stock(new Dictionary<string, string>() {
                    {"stock_name" ,item_name},
                    {"stock_in", item_quantity },
                    {"stock_out","0" },
                    {"stock_remaining",item_quantity },
                    {"single_stock_price",item_price },
                    {"stock_total",total_price }
                });
                this.add_stock_to_db(new Dictionary<string, string>() {
                    {"stock_name" ,item_name},
                    {"stock_in", item_quantity },
                    {"stock_out","0" },
                    {"stock_remaining",item_quantity },
                    {"single_stock_price",item_price },
                    {"stock_total",total_price }
                });
            }
        }

        private void add_stock(Dictionary<string, string> stock) {
            int new_index = this.stock_panel_tabel_tbl.Rows.Add();
                DataGridViewRow new_row = this.stock_panel_tabel_tbl.Rows[new_index];
                new_row.Cells["stock_name"].Value = stock["stock_name"];
                new_row.Cells["stock_in"].Value = stock["stock_in"];
                new_row.Cells["stock_out"].Value = stock["stock_out"];
                new_row.Cells["stock_remaining"].Value = stock["stock_remaining"];
                new_row.Cells["single_stock_price"].Value = stock["single_stock_price"];
                new_row.Cells["stock_total"].Value = stock["stock_total"];
        }
    }
}
