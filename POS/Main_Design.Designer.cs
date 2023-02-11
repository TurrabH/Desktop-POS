using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace POS {
    partial class main_form {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.main_tbl_layout_pnl = new System.Windows.Forms.TableLayoutPanel();
            this.left_tbl_layout_pnl = new System.Windows.Forms.TableLayoutPanel();
            this.pos_info_tbl_layout_pnl = new System.Windows.Forms.TableLayoutPanel();
            this.pos_title_lbl = new System.Windows.Forms.Label();
            this.pos_image_panel_pnl = new System.Windows.Forms.Panel();
            this.pos_icon_picture_box = new System.Windows.Forms.PictureBox();
            this.menu_pnl = new System.Windows.Forms.Panel();
            this.menu_order_history_pnl = new System.Windows.Forms.Panel();
            this.menu_order_history_tbl_layout_pnl = new System.Windows.Forms.TableLayoutPanel();
            this.history_lbl = new System.Windows.Forms.Label();
            this.order_history_picture_box = new System.Windows.Forms.PictureBox();
            this.menu_stock_pnl = new System.Windows.Forms.Panel();
            this.menu_stock_tbl_layout_pnl = new System.Windows.Forms.TableLayoutPanel();
            this.stock_lbl = new System.Windows.Forms.Label();
            this.stock_picture_box = new System.Windows.Forms.PictureBox();
            this.menu_items_menu_pnl = new System.Windows.Forms.Panel();
            this.menu_items_menu_tbl_layout_pnl = new System.Windows.Forms.TableLayoutPanel();
            this.menu_item_lbl = new System.Windows.Forms.Label();
            this.menu_item_picture_box = new System.Windows.Forms.PictureBox();
            this.menu_home_pnl = new System.Windows.Forms.Panel();
            this.menu_home_tbl_layout_pnl = new System.Windows.Forms.TableLayoutPanel();
            this.home_lbl = new System.Windows.Forms.Label();
            this.home_picture_box = new System.Windows.Forms.PictureBox();
            this.stack_pane_pnl = new System.Windows.Forms.Panel();
            this.page_home_main_pnl = new System.Windows.Forms.Panel();
            this.home_secondary_pnl = new System.Windows.Forms.Panel();
            this.home_main_tbl_layout_pnl = new System.Windows.Forms.TableLayoutPanel();
            this.order_side_tbl_layout_pnl = new System.Windows.Forms.TableLayoutPanel();
            this.order_info_tbl_layout_pnl = new System.Windows.Forms.TableLayoutPanel();
            this.order_lbl = new System.Windows.Forms.Label();
            this.order_id_lbl = new System.Windows.Forms.Label();
            this.price_details_pnl = new System.Windows.Forms.Panel();
            this.price_details_sub_panel = new System.Windows.Forms.Panel();
            this.price_details_tbl_layout_pnl = new System.Windows.Forms.TableLayoutPanel();
            this.place_order_pnl = new System.Windows.Forms.Panel();
            this.place_order_btn = new System.Windows.Forms.Button();
            this.price_details_main_pnl = new System.Windows.Forms.Panel();
            this.total_amount_value_lbl = new System.Windows.Forms.Label();
            this.total_amount_lbl = new System.Windows.Forms.Label();
            this.divider_lbl = new System.Windows.Forms.Label();
            this.tax_value_lbl = new System.Windows.Forms.Label();
            this.sub_total_value_lbl = new System.Windows.Forms.Label();
            this.total_quantity_value_lbl = new System.Windows.Forms.Label();
            this.tax_lbl = new System.Windows.Forms.Label();
            this.sub_total_lbl = new System.Windows.Forms.Label();
            this.total_quantity_lbl = new System.Windows.Forms.Label();
            this.order_items_pnl = new System.Windows.Forms.Panel();
            this.order_items_flow_layout_pnl = new System.Windows.Forms.FlowLayoutPanel();
            this.home_menu_panel_pnl = new System.Windows.Forms.Panel();
            this.home_menu_tbl_layout_pnl = new System.Windows.Forms.TableLayoutPanel();
            this.home_top_bar_panel_pnl = new System.Windows.Forms.TableLayoutPanel();
            this.shop_info_tbl_layout_pnl = new System.Windows.Forms.TableLayoutPanel();
            this.shop_name_lbl = new System.Windows.Forms.Label();
            this.date_time_lbl = new System.Windows.Forms.Label();
            this.search_bar_main_pnl = new System.Windows.Forms.Panel();
            this.search_bar_pnl = new System.Windows.Forms.Panel();
            this.search_bar_tbl_layout_pnl = new System.Windows.Forms.TableLayoutPanel();
            this.search_bar_picture_box = new System.Windows.Forms.PictureBox();
            this.search_bar_txt_field_pnl = new System.Windows.Forms.Panel();
            this.search_bar_txt_field = new System.Windows.Forms.TextBox();
            this.order_menu_area_pnl = new System.Windows.Forms.Panel();
            this.order_menu_area_flow_layout_pnl = new System.Windows.Forms.FlowLayoutPanel();
            this.page_add_remove_items_pnl = new System.Windows.Forms.Panel();
            this.add_remove_items_tbl_layout_pnl = new System.Windows.Forms.TableLayoutPanel();
            this.add_remove_items_flow_layout_pnl = new System.Windows.Forms.FlowLayoutPanel();
            this.add_remove_items_save_changes_btn = new System.Windows.Forms.Button();
            this.delete_selected = new System.Windows.Forms.Button();
            this.add_remove_items_add_btn = new System.Windows.Forms.Button();
            this.menu_table_pnl = new System.Windows.Forms.Panel();
            this.menu_table_tbl = new System.Windows.Forms.DataGridView();
            this.check_box = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.item_image = new System.Windows.Forms.DataGridViewImageColumn();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_ingredients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.page_order_history_panel_main_pnl = new System.Windows.Forms.Panel();
            this.order_history_panel_main_tbl_layout_pnl = new System.Windows.Forms.TableLayoutPanel();
            this.order_history_panel_table_pnl = new System.Windows.Forms.Panel();
            this.order_history_table_tbl = new System.Windows.Forms.DataGridView();
            this.order_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_date_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.history_panel_top_flow_layout_pnl = new System.Windows.Forms.FlowLayoutPanel();
            this.history_panel_filter_combo_box = new System.Windows.Forms.ComboBox();
            this.history_panel_filter_lbl = new System.Windows.Forms.Label();
            this.page_stock_panel_main_pnl = new System.Windows.Forms.Panel();
            this.stock_panel_main_tbl_layout_pnl = new System.Windows.Forms.TableLayoutPanel();
            this.stock_panel_tabel_pnl = new System.Windows.Forms.Panel();
            this.stock_panel_tabel_tbl = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_in = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_remaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.single_stock_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_panel_bottom_flow_layout_pnl = new System.Windows.Forms.FlowLayoutPanel();
            this.stock_panel_add_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.main_tbl_layout_pnl.SuspendLayout();
            this.left_tbl_layout_pnl.SuspendLayout();
            this.pos_info_tbl_layout_pnl.SuspendLayout();
            this.pos_image_panel_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pos_icon_picture_box)).BeginInit();
            this.menu_pnl.SuspendLayout();
            this.menu_order_history_pnl.SuspendLayout();
            this.menu_order_history_tbl_layout_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_history_picture_box)).BeginInit();
            this.menu_stock_pnl.SuspendLayout();
            this.menu_stock_tbl_layout_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stock_picture_box)).BeginInit();
            this.menu_items_menu_pnl.SuspendLayout();
            this.menu_items_menu_tbl_layout_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu_item_picture_box)).BeginInit();
            this.menu_home_pnl.SuspendLayout();
            this.menu_home_tbl_layout_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_picture_box)).BeginInit();
            this.stack_pane_pnl.SuspendLayout();
            this.page_home_main_pnl.SuspendLayout();
            this.home_secondary_pnl.SuspendLayout();
            this.home_main_tbl_layout_pnl.SuspendLayout();
            this.order_side_tbl_layout_pnl.SuspendLayout();
            this.order_info_tbl_layout_pnl.SuspendLayout();
            this.price_details_pnl.SuspendLayout();
            this.price_details_sub_panel.SuspendLayout();
            this.price_details_tbl_layout_pnl.SuspendLayout();
            this.place_order_pnl.SuspendLayout();
            this.price_details_main_pnl.SuspendLayout();
            this.order_items_pnl.SuspendLayout();
            this.home_menu_panel_pnl.SuspendLayout();
            this.home_menu_tbl_layout_pnl.SuspendLayout();
            this.home_top_bar_panel_pnl.SuspendLayout();
            this.shop_info_tbl_layout_pnl.SuspendLayout();
            this.search_bar_main_pnl.SuspendLayout();
            this.search_bar_pnl.SuspendLayout();
            this.search_bar_tbl_layout_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_bar_picture_box)).BeginInit();
            this.search_bar_txt_field_pnl.SuspendLayout();
            this.order_menu_area_pnl.SuspendLayout();
            this.page_add_remove_items_pnl.SuspendLayout();
            this.add_remove_items_tbl_layout_pnl.SuspendLayout();
            this.add_remove_items_flow_layout_pnl.SuspendLayout();
            this.menu_table_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu_table_tbl)).BeginInit();
            this.page_order_history_panel_main_pnl.SuspendLayout();
            this.order_history_panel_main_tbl_layout_pnl.SuspendLayout();
            this.order_history_panel_table_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_history_table_tbl)).BeginInit();
            this.history_panel_top_flow_layout_pnl.SuspendLayout();
            this.page_stock_panel_main_pnl.SuspendLayout();
            this.stock_panel_main_tbl_layout_pnl.SuspendLayout();
            this.stock_panel_tabel_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stock_panel_tabel_tbl)).BeginInit();
            this.stock_panel_bottom_flow_layout_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_tbl_layout_pnl
            // 
            this.main_tbl_layout_pnl.AutoScroll = true;
            this.main_tbl_layout_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.main_tbl_layout_pnl.ColumnCount = 2;
            this.main_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.main_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.main_tbl_layout_pnl.Controls.Add(this.left_tbl_layout_pnl, 0, 0);
            this.main_tbl_layout_pnl.Controls.Add(this.stack_pane_pnl, 1, 0);
            this.main_tbl_layout_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_tbl_layout_pnl.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.main_tbl_layout_pnl.Location = new System.Drawing.Point(0, 0);
            this.main_tbl_layout_pnl.Name = "main_tbl_layout_pnl";
            this.main_tbl_layout_pnl.RowCount = 1;
            this.main_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.main_tbl_layout_pnl.Size = new System.Drawing.Size(1904, 1041);
            this.main_tbl_layout_pnl.TabIndex = 0;
            // 
            // left_tbl_layout_pnl
            // 
            this.left_tbl_layout_pnl.AutoSize = true;
            this.left_tbl_layout_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.left_tbl_layout_pnl.ColumnCount = 1;
            this.left_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.left_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.left_tbl_layout_pnl.Controls.Add(this.pos_info_tbl_layout_pnl, 0, 0);
            this.left_tbl_layout_pnl.Controls.Add(this.menu_pnl, 0, 1);
            this.left_tbl_layout_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.left_tbl_layout_pnl.Location = new System.Drawing.Point(3, 3);
            this.left_tbl_layout_pnl.MinimumSize = new System.Drawing.Size(129, 0);
            this.left_tbl_layout_pnl.Name = "left_tbl_layout_pnl";
            this.left_tbl_layout_pnl.RowCount = 2;
            this.left_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.69082F));
            this.left_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.30918F));
            this.left_tbl_layout_pnl.Size = new System.Drawing.Size(129, 1035);
            this.left_tbl_layout_pnl.TabIndex = 0;
            // 
            // pos_info_tbl_layout_pnl
            // 
            this.pos_info_tbl_layout_pnl.ColumnCount = 1;
            this.pos_info_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pos_info_tbl_layout_pnl.Controls.Add(this.pos_title_lbl, 0, 1);
            this.pos_info_tbl_layout_pnl.Controls.Add(this.pos_image_panel_pnl, 0, 0);
            this.pos_info_tbl_layout_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pos_info_tbl_layout_pnl.Location = new System.Drawing.Point(3, 3);
            this.pos_info_tbl_layout_pnl.MinimumSize = new System.Drawing.Size(123, 114);
            this.pos_info_tbl_layout_pnl.Name = "pos_info_tbl_layout_pnl";
            this.pos_info_tbl_layout_pnl.RowCount = 2;
            this.pos_info_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pos_info_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.pos_info_tbl_layout_pnl.Size = new System.Drawing.Size(123, 114);
            this.pos_info_tbl_layout_pnl.TabIndex = 0;
            // 
            // pos_title_lbl
            // 
            this.pos_title_lbl.AutoSize = true;
            this.pos_title_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.pos_title_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pos_title_lbl.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos_title_lbl.ForeColor = System.Drawing.Color.White;
            this.pos_title_lbl.Location = new System.Drawing.Point(3, 68);
            this.pos_title_lbl.Name = "pos_title_lbl";
            this.pos_title_lbl.Size = new System.Drawing.Size(117, 46);
            this.pos_title_lbl.TabIndex = 0;
            this.pos_title_lbl.Text = "POS Food";
            this.pos_title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pos_image_panel_pnl
            // 
            this.pos_image_panel_pnl.Controls.Add(this.pos_icon_picture_box);
            this.pos_image_panel_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pos_image_panel_pnl.Location = new System.Drawing.Point(3, 3);
            this.pos_image_panel_pnl.MinimumSize = new System.Drawing.Size(0, 62);
            this.pos_image_panel_pnl.Name = "pos_image_panel_pnl";
            this.pos_image_panel_pnl.Padding = new System.Windows.Forms.Padding(33, 9, 33, 0);
            this.pos_image_panel_pnl.Size = new System.Drawing.Size(117, 62);
            this.pos_image_panel_pnl.TabIndex = 1;
            // 
            // pos_icon_picture_box
            // 
            this.pos_icon_picture_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pos_icon_picture_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pos_icon_picture_box.Image = global::POS.Properties.Resources.POs_LOGO;
            this.pos_icon_picture_box.Location = new System.Drawing.Point(33, 9);
            this.pos_icon_picture_box.Margin = new System.Windows.Forms.Padding(10);
            this.pos_icon_picture_box.Name = "pos_icon_picture_box";
            this.pos_icon_picture_box.Size = new System.Drawing.Size(51, 53);
            this.pos_icon_picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pos_icon_picture_box.TabIndex = 2;
            this.pos_icon_picture_box.TabStop = false;
            // 
            // menu_pnl
            // 
            this.menu_pnl.AutoScroll = true;
            this.menu_pnl.AutoSize = true;
            this.menu_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menu_pnl.Controls.Add(this.menu_order_history_pnl);
            this.menu_pnl.Controls.Add(this.menu_stock_pnl);
            this.menu_pnl.Controls.Add(this.menu_items_menu_pnl);
            this.menu_pnl.Controls.Add(this.menu_home_pnl);
            this.menu_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_pnl.Location = new System.Drawing.Point(3, 123);
            this.menu_pnl.Name = "menu_pnl";
            this.menu_pnl.Padding = new System.Windows.Forms.Padding(0, 200, 0, 0);
            this.menu_pnl.Size = new System.Drawing.Size(123, 909);
            this.menu_pnl.TabIndex = 1;
            // 
            // menu_order_history_pnl
            // 
            this.menu_order_history_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menu_order_history_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.menu_order_history_pnl.Controls.Add(this.menu_order_history_tbl_layout_pnl);
            this.menu_order_history_pnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_order_history_pnl.Location = new System.Drawing.Point(21, 307);
            this.menu_order_history_pnl.Name = "menu_order_history_pnl";
            this.menu_order_history_pnl.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.menu_order_history_pnl.Size = new System.Drawing.Size(78, 100);
            this.menu_order_history_pnl.TabIndex = 2;
            this.menu_order_history_pnl.Tag = "history";
            // 
            // menu_order_history_tbl_layout_pnl
            // 
            this.menu_order_history_tbl_layout_pnl.ColumnCount = 1;
            this.menu_order_history_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menu_order_history_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menu_order_history_tbl_layout_pnl.Controls.Add(this.history_lbl, 0, 1);
            this.menu_order_history_tbl_layout_pnl.Controls.Add(this.order_history_picture_box, 0, 0);
            this.menu_order_history_tbl_layout_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_order_history_tbl_layout_pnl.Location = new System.Drawing.Point(0, 20);
            this.menu_order_history_tbl_layout_pnl.Name = "menu_order_history_tbl_layout_pnl";
            this.menu_order_history_tbl_layout_pnl.RowCount = 2;
            this.menu_order_history_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.menu_order_history_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.menu_order_history_tbl_layout_pnl.Size = new System.Drawing.Size(78, 60);
            this.menu_order_history_tbl_layout_pnl.TabIndex = 0;
            this.menu_order_history_tbl_layout_pnl.Tag = "history";
            // 
            // history_lbl
            // 
            this.history_lbl.AutoSize = true;
            this.history_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.history_lbl.Location = new System.Drawing.Point(3, 42);
            this.history_lbl.Name = "history_lbl";
            this.history_lbl.Size = new System.Drawing.Size(72, 18);
            this.history_lbl.TabIndex = 0;
            this.history_lbl.Tag = "history";
            this.history_lbl.Text = "History";
            this.history_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // order_history_picture_box
            // 
            this.order_history_picture_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.order_history_picture_box.Image = global::POS.Properties.Resources.history;
            this.order_history_picture_box.Location = new System.Drawing.Point(3, 3);
            this.order_history_picture_box.Name = "order_history_picture_box";
            this.order_history_picture_box.Size = new System.Drawing.Size(72, 36);
            this.order_history_picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.order_history_picture_box.TabIndex = 1;
            this.order_history_picture_box.TabStop = false;
            this.order_history_picture_box.Tag = "history";
            // 
            // menu_stock_pnl
            // 
            this.menu_stock_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menu_stock_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.menu_stock_pnl.Controls.Add(this.menu_stock_tbl_layout_pnl);
            this.menu_stock_pnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_stock_pnl.Location = new System.Drawing.Point(21, 436);
            this.menu_stock_pnl.Name = "menu_stock_pnl";
            this.menu_stock_pnl.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.menu_stock_pnl.Size = new System.Drawing.Size(78, 100);
            this.menu_stock_pnl.TabIndex = 1;
            this.menu_stock_pnl.Tag = "stock";
            // 
            // menu_stock_tbl_layout_pnl
            // 
            this.menu_stock_tbl_layout_pnl.ColumnCount = 1;
            this.menu_stock_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menu_stock_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menu_stock_tbl_layout_pnl.Controls.Add(this.stock_lbl, 0, 1);
            this.menu_stock_tbl_layout_pnl.Controls.Add(this.stock_picture_box, 0, 0);
            this.menu_stock_tbl_layout_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_stock_tbl_layout_pnl.Location = new System.Drawing.Point(0, 20);
            this.menu_stock_tbl_layout_pnl.Name = "menu_stock_tbl_layout_pnl";
            this.menu_stock_tbl_layout_pnl.RowCount = 2;
            this.menu_stock_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.menu_stock_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.menu_stock_tbl_layout_pnl.Size = new System.Drawing.Size(78, 60);
            this.menu_stock_tbl_layout_pnl.TabIndex = 0;
            this.menu_stock_tbl_layout_pnl.Tag = "stock";
            // 
            // stock_lbl
            // 
            this.stock_lbl.AutoSize = true;
            this.stock_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stock_lbl.Location = new System.Drawing.Point(3, 42);
            this.stock_lbl.Name = "stock_lbl";
            this.stock_lbl.Size = new System.Drawing.Size(72, 18);
            this.stock_lbl.TabIndex = 0;
            this.stock_lbl.Tag = "stock";
            this.stock_lbl.Text = "Stock";
            this.stock_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stock_picture_box
            // 
            this.stock_picture_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stock_picture_box.Image = global::POS.Properties.Resources.stock;
            this.stock_picture_box.Location = new System.Drawing.Point(3, 3);
            this.stock_picture_box.Name = "stock_picture_box";
            this.stock_picture_box.Size = new System.Drawing.Size(72, 36);
            this.stock_picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stock_picture_box.TabIndex = 1;
            this.stock_picture_box.TabStop = false;
            this.stock_picture_box.Tag = "stock";
            // 
            // menu_items_menu_pnl
            // 
            this.menu_items_menu_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menu_items_menu_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.menu_items_menu_pnl.Controls.Add(this.menu_items_menu_tbl_layout_pnl);
            this.menu_items_menu_pnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_items_menu_pnl.Location = new System.Drawing.Point(21, 176);
            this.menu_items_menu_pnl.Name = "menu_items_menu_pnl";
            this.menu_items_menu_pnl.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.menu_items_menu_pnl.Size = new System.Drawing.Size(78, 100);
            this.menu_items_menu_pnl.TabIndex = 1;
            this.menu_items_menu_pnl.Tag = "menu";
            // 
            // menu_items_menu_tbl_layout_pnl
            // 
            this.menu_items_menu_tbl_layout_pnl.ColumnCount = 1;
            this.menu_items_menu_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menu_items_menu_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menu_items_menu_tbl_layout_pnl.Controls.Add(this.menu_item_lbl, 0, 1);
            this.menu_items_menu_tbl_layout_pnl.Controls.Add(this.menu_item_picture_box, 0, 0);
            this.menu_items_menu_tbl_layout_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_items_menu_tbl_layout_pnl.Location = new System.Drawing.Point(0, 20);
            this.menu_items_menu_tbl_layout_pnl.Name = "menu_items_menu_tbl_layout_pnl";
            this.menu_items_menu_tbl_layout_pnl.RowCount = 2;
            this.menu_items_menu_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.menu_items_menu_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.menu_items_menu_tbl_layout_pnl.Size = new System.Drawing.Size(78, 60);
            this.menu_items_menu_tbl_layout_pnl.TabIndex = 0;
            this.menu_items_menu_tbl_layout_pnl.Tag = "menu";
            // 
            // menu_item_lbl
            // 
            this.menu_item_lbl.AutoSize = true;
            this.menu_item_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_item_lbl.Location = new System.Drawing.Point(3, 42);
            this.menu_item_lbl.Name = "menu_item_lbl";
            this.menu_item_lbl.Size = new System.Drawing.Size(72, 18);
            this.menu_item_lbl.TabIndex = 0;
            this.menu_item_lbl.Tag = "menu";
            this.menu_item_lbl.Text = "Menu";
            this.menu_item_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menu_item_picture_box
            // 
            this.menu_item_picture_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_item_picture_box.Image = global::POS.Properties.Resources.list;
            this.menu_item_picture_box.Location = new System.Drawing.Point(3, 3);
            this.menu_item_picture_box.Name = "menu_item_picture_box";
            this.menu_item_picture_box.Size = new System.Drawing.Size(72, 36);
            this.menu_item_picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.menu_item_picture_box.TabIndex = 1;
            this.menu_item_picture_box.TabStop = false;
            this.menu_item_picture_box.Tag = "menu";
            // 
            // menu_home_pnl
            // 
            this.menu_home_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menu_home_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.menu_home_pnl.Controls.Add(this.menu_home_tbl_layout_pnl);
            this.menu_home_pnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_home_pnl.Location = new System.Drawing.Point(21, 48);
            this.menu_home_pnl.Name = "menu_home_pnl";
            this.menu_home_pnl.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.menu_home_pnl.Size = new System.Drawing.Size(78, 100);
            this.menu_home_pnl.TabIndex = 0;
            this.menu_home_pnl.Tag = "home";
            // 
            // menu_home_tbl_layout_pnl
            // 
            this.menu_home_tbl_layout_pnl.CausesValidation = false;
            this.menu_home_tbl_layout_pnl.ColumnCount = 1;
            this.menu_home_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menu_home_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menu_home_tbl_layout_pnl.Controls.Add(this.home_lbl, 0, 1);
            this.menu_home_tbl_layout_pnl.Controls.Add(this.home_picture_box, 0, 0);
            this.menu_home_tbl_layout_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_home_tbl_layout_pnl.Location = new System.Drawing.Point(0, 20);
            this.menu_home_tbl_layout_pnl.Name = "menu_home_tbl_layout_pnl";
            this.menu_home_tbl_layout_pnl.RowCount = 2;
            this.menu_home_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.menu_home_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.menu_home_tbl_layout_pnl.Size = new System.Drawing.Size(78, 60);
            this.menu_home_tbl_layout_pnl.TabIndex = 0;
            this.menu_home_tbl_layout_pnl.Tag = "home";
            // 
            // home_lbl
            // 
            this.home_lbl.AutoSize = true;
            this.home_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_lbl.Location = new System.Drawing.Point(3, 42);
            this.home_lbl.Name = "home_lbl";
            this.home_lbl.Size = new System.Drawing.Size(72, 18);
            this.home_lbl.TabIndex = 0;
            this.home_lbl.Tag = "home";
            this.home_lbl.Text = "Home";
            this.home_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // home_picture_box
            // 
            this.home_picture_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_picture_box.Image = global::POS.Properties.Resources.home;
            this.home_picture_box.Location = new System.Drawing.Point(3, 3);
            this.home_picture_box.Name = "home_picture_box";
            this.home_picture_box.Size = new System.Drawing.Size(72, 36);
            this.home_picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.home_picture_box.TabIndex = 1;
            this.home_picture_box.TabStop = false;
            this.home_picture_box.Tag = "home";
            // 
            // stack_pane_pnl
            // 
            this.stack_pane_pnl.AutoSize = true;
            this.stack_pane_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stack_pane_pnl.Controls.Add(this.page_home_main_pnl);
            this.stack_pane_pnl.Controls.Add(this.page_add_remove_items_pnl);
            this.stack_pane_pnl.Controls.Add(this.page_order_history_panel_main_pnl);
            this.stack_pane_pnl.Controls.Add(this.page_stock_panel_main_pnl);
            this.stack_pane_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stack_pane_pnl.Location = new System.Drawing.Point(132, 3);
            this.stack_pane_pnl.Name = "stack_pane_pnl";
            this.stack_pane_pnl.Size = new System.Drawing.Size(1769, 1035);
            this.stack_pane_pnl.TabIndex = 1;
            // 
            // page_home_main_pnl
            // 
            this.page_home_main_pnl.AutoSize = true;
            this.page_home_main_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.page_home_main_pnl.Controls.Add(this.home_secondary_pnl);
            this.page_home_main_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_home_main_pnl.Location = new System.Drawing.Point(0, 0);
            this.page_home_main_pnl.Name = "page_home_main_pnl";
            this.page_home_main_pnl.Padding = new System.Windows.Forms.Padding(0, 25, 0, 50);
            this.page_home_main_pnl.Size = new System.Drawing.Size(1769, 1035);
            this.page_home_main_pnl.TabIndex = 2;
            // 
            // home_secondary_pnl
            // 
            this.home_secondary_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.home_secondary_pnl.Controls.Add(this.home_main_tbl_layout_pnl);
            this.home_secondary_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_secondary_pnl.Location = new System.Drawing.Point(0, 25);
            this.home_secondary_pnl.Name = "home_secondary_pnl";
            this.home_secondary_pnl.Size = new System.Drawing.Size(1769, 960);
            this.home_secondary_pnl.TabIndex = 0;
            // 
            // home_main_tbl_layout_pnl
            // 
            this.home_main_tbl_layout_pnl.ColumnCount = 2;
            this.home_main_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.home_main_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 353F));
            this.home_main_tbl_layout_pnl.Controls.Add(this.order_side_tbl_layout_pnl, 1, 0);
            this.home_main_tbl_layout_pnl.Controls.Add(this.home_menu_panel_pnl, 0, 0);
            this.home_main_tbl_layout_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_main_tbl_layout_pnl.Location = new System.Drawing.Point(0, 0);
            this.home_main_tbl_layout_pnl.Name = "home_main_tbl_layout_pnl";
            this.home_main_tbl_layout_pnl.RowCount = 1;
            this.home_main_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.home_main_tbl_layout_pnl.Size = new System.Drawing.Size(1769, 960);
            this.home_main_tbl_layout_pnl.TabIndex = 0;
            // 
            // order_side_tbl_layout_pnl
            // 
            this.order_side_tbl_layout_pnl.AutoSize = true;
            this.order_side_tbl_layout_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.order_side_tbl_layout_pnl.ColumnCount = 1;
            this.order_side_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.order_side_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.order_side_tbl_layout_pnl.Controls.Add(this.order_info_tbl_layout_pnl, 0, 0);
            this.order_side_tbl_layout_pnl.Controls.Add(this.price_details_pnl, 0, 2);
            this.order_side_tbl_layout_pnl.Controls.Add(this.order_items_pnl, 0, 1);
            this.order_side_tbl_layout_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.order_side_tbl_layout_pnl.Location = new System.Drawing.Point(1419, 3);
            this.order_side_tbl_layout_pnl.MinimumSize = new System.Drawing.Size(351, 0);
            this.order_side_tbl_layout_pnl.Name = "order_side_tbl_layout_pnl";
            this.order_side_tbl_layout_pnl.RowCount = 3;
            this.order_side_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.896034F));
            this.order_side_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.10397F));
            this.order_side_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 287F));
            this.order_side_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.order_side_tbl_layout_pnl.Size = new System.Drawing.Size(351, 954);
            this.order_side_tbl_layout_pnl.TabIndex = 0;
            // 
            // order_info_tbl_layout_pnl
            // 
            this.order_info_tbl_layout_pnl.ColumnCount = 1;
            this.order_info_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.order_info_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.order_info_tbl_layout_pnl.Controls.Add(this.order_lbl, 0, 0);
            this.order_info_tbl_layout_pnl.Controls.Add(this.order_id_lbl, 0, 1);
            this.order_info_tbl_layout_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.order_info_tbl_layout_pnl.Location = new System.Drawing.Point(3, 3);
            this.order_info_tbl_layout_pnl.MinimumSize = new System.Drawing.Size(0, 53);
            this.order_info_tbl_layout_pnl.Name = "order_info_tbl_layout_pnl";
            this.order_info_tbl_layout_pnl.RowCount = 2;
            this.order_info_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.33766F));
            this.order_info_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.66234F));
            this.order_info_tbl_layout_pnl.Size = new System.Drawing.Size(345, 53);
            this.order_info_tbl_layout_pnl.TabIndex = 0;
            // 
            // order_lbl
            // 
            this.order_lbl.AutoSize = true;
            this.order_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.order_lbl.Font = new System.Drawing.Font("Gilroy ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_lbl.Location = new System.Drawing.Point(3, 0);
            this.order_lbl.Name = "order_lbl";
            this.order_lbl.Size = new System.Drawing.Size(339, 33);
            this.order_lbl.TabIndex = 0;
            this.order_lbl.Text = "Order";
            this.order_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // order_id_lbl
            // 
            this.order_id_lbl.AutoSize = true;
            this.order_id_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.order_id_lbl.Font = new System.Drawing.Font("Gilroy Light", 10F);
            this.order_id_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.order_id_lbl.Location = new System.Drawing.Point(3, 33);
            this.order_id_lbl.Name = "order_id_lbl";
            this.order_id_lbl.Size = new System.Drawing.Size(339, 20);
            this.order_id_lbl.TabIndex = 1;
            this.order_id_lbl.Text = "#F12034D";
            // 
            // price_details_pnl
            // 
            this.price_details_pnl.Controls.Add(this.price_details_sub_panel);
            this.price_details_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.price_details_pnl.Location = new System.Drawing.Point(3, 669);
            this.price_details_pnl.Name = "price_details_pnl";
            this.price_details_pnl.Padding = new System.Windows.Forms.Padding(10);
            this.price_details_pnl.Size = new System.Drawing.Size(345, 282);
            this.price_details_pnl.TabIndex = 1;
            // 
            // price_details_sub_panel
            // 
            this.price_details_sub_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.price_details_sub_panel.Controls.Add(this.price_details_tbl_layout_pnl);
            this.price_details_sub_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.price_details_sub_panel.Location = new System.Drawing.Point(10, 10);
            this.price_details_sub_panel.Name = "price_details_sub_panel";
            this.price_details_sub_panel.Size = new System.Drawing.Size(325, 262);
            this.price_details_sub_panel.TabIndex = 0;
            // 
            // price_details_tbl_layout_pnl
            // 
            this.price_details_tbl_layout_pnl.ColumnCount = 1;
            this.price_details_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.price_details_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.price_details_tbl_layout_pnl.Controls.Add(this.place_order_pnl, 0, 1);
            this.price_details_tbl_layout_pnl.Controls.Add(this.price_details_main_pnl, 0, 0);
            this.price_details_tbl_layout_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.price_details_tbl_layout_pnl.Location = new System.Drawing.Point(0, 0);
            this.price_details_tbl_layout_pnl.Name = "price_details_tbl_layout_pnl";
            this.price_details_tbl_layout_pnl.RowCount = 2;
            this.price_details_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.17558F));
            this.price_details_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.82443F));
            this.price_details_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.price_details_tbl_layout_pnl.Size = new System.Drawing.Size(325, 262);
            this.price_details_tbl_layout_pnl.TabIndex = 0;
            // 
            // place_order_pnl
            // 
            this.place_order_pnl.Controls.Add(this.place_order_btn);
            this.place_order_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.place_order_pnl.Location = new System.Drawing.Point(3, 179);
            this.place_order_pnl.Name = "place_order_pnl";
            this.place_order_pnl.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.place_order_pnl.Size = new System.Drawing.Size(319, 80);
            this.place_order_pnl.TabIndex = 0;
            // 
            // place_order_btn
            // 
            this.place_order_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.place_order_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.place_order_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.place_order_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.place_order_btn.FlatAppearance.BorderSize = 0;
            this.place_order_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.place_order_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.place_order_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place_order_btn.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.place_order_btn.ForeColor = System.Drawing.Color.White;
            this.place_order_btn.Image = global::POS.Properties.Resources.shopping_list1;
            this.place_order_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.place_order_btn.Location = new System.Drawing.Point(20, 10);
            this.place_order_btn.Name = "place_order_btn";
            this.place_order_btn.Size = new System.Drawing.Size(279, 50);
            this.place_order_btn.TabIndex = 0;
            this.place_order_btn.Text = "Place Order";
            this.place_order_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.place_order_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.place_order_btn.UseVisualStyleBackColor = false;
            this.place_order_btn.Click += new System.EventHandler(this.Place_order_btn_Click);
            // 
            // price_details_main_pnl
            // 
            this.price_details_main_pnl.Controls.Add(this.total_amount_value_lbl);
            this.price_details_main_pnl.Controls.Add(this.total_amount_lbl);
            this.price_details_main_pnl.Controls.Add(this.divider_lbl);
            this.price_details_main_pnl.Controls.Add(this.tax_value_lbl);
            this.price_details_main_pnl.Controls.Add(this.sub_total_value_lbl);
            this.price_details_main_pnl.Controls.Add(this.total_quantity_value_lbl);
            this.price_details_main_pnl.Controls.Add(this.tax_lbl);
            this.price_details_main_pnl.Controls.Add(this.sub_total_lbl);
            this.price_details_main_pnl.Controls.Add(this.total_quantity_lbl);
            this.price_details_main_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.price_details_main_pnl.Location = new System.Drawing.Point(3, 3);
            this.price_details_main_pnl.Name = "price_details_main_pnl";
            this.price_details_main_pnl.Size = new System.Drawing.Size(319, 170);
            this.price_details_main_pnl.TabIndex = 1;
            // 
            // total_amount_value_lbl
            // 
            this.total_amount_value_lbl.AutoSize = true;
            this.total_amount_value_lbl.Font = new System.Drawing.Font("Gilroy Light", 10F);
            this.total_amount_value_lbl.Location = new System.Drawing.Point(193, 114);
            this.total_amount_value_lbl.Name = "total_amount_value_lbl";
            this.total_amount_value_lbl.Size = new System.Drawing.Size(36, 16);
            this.total_amount_value_lbl.TabIndex = 8;
            this.total_amount_value_lbl.Text = "0 Rs";
            // 
            // total_amount_lbl
            // 
            this.total_amount_lbl.AutoSize = true;
            this.total_amount_lbl.Font = new System.Drawing.Font("Gilroy Light", 10F);
            this.total_amount_lbl.Location = new System.Drawing.Point(26, 114);
            this.total_amount_lbl.Name = "total_amount_lbl";
            this.total_amount_lbl.Size = new System.Drawing.Size(41, 16);
            this.total_amount_lbl.TabIndex = 7;
            this.total_amount_lbl.Text = "Total";
            // 
            // divider_lbl
            // 
            this.divider_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.divider_lbl.Location = new System.Drawing.Point(20, 93);
            this.divider_lbl.Name = "divider_lbl";
            this.divider_lbl.Size = new System.Drawing.Size(279, 2);
            this.divider_lbl.TabIndex = 6;
            // 
            // tax_value_lbl
            // 
            this.tax_value_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tax_value_lbl.AutoSize = true;
            this.tax_value_lbl.Font = new System.Drawing.Font("Gilroy Light", 10F);
            this.tax_value_lbl.Location = new System.Drawing.Point(193, 62);
            this.tax_value_lbl.Name = "tax_value_lbl";
            this.tax_value_lbl.Size = new System.Drawing.Size(36, 16);
            this.tax_value_lbl.TabIndex = 5;
            this.tax_value_lbl.Text = "0 Rs";
            // 
            // sub_total_value_lbl
            // 
            this.sub_total_value_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sub_total_value_lbl.AutoSize = true;
            this.sub_total_value_lbl.Font = new System.Drawing.Font("Gilroy Light", 10F);
            this.sub_total_value_lbl.Location = new System.Drawing.Point(193, 40);
            this.sub_total_value_lbl.Name = "sub_total_value_lbl";
            this.sub_total_value_lbl.Size = new System.Drawing.Size(36, 16);
            this.sub_total_value_lbl.TabIndex = 4;
            this.sub_total_value_lbl.Text = "0 Rs";
            // 
            // total_quantity_value_lbl
            // 
            this.total_quantity_value_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.total_quantity_value_lbl.AutoSize = true;
            this.total_quantity_value_lbl.Font = new System.Drawing.Font("Gilroy Light", 10F);
            this.total_quantity_value_lbl.Location = new System.Drawing.Point(193, 18);
            this.total_quantity_value_lbl.Name = "total_quantity_value_lbl";
            this.total_quantity_value_lbl.Size = new System.Drawing.Size(55, 16);
            this.total_quantity_value_lbl.TabIndex = 3;
            this.total_quantity_value_lbl.Text = "0 Items";
            // 
            // tax_lbl
            // 
            this.tax_lbl.AutoSize = true;
            this.tax_lbl.Font = new System.Drawing.Font("Gilroy Light", 10F);
            this.tax_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.tax_lbl.Location = new System.Drawing.Point(26, 62);
            this.tax_lbl.Name = "tax_lbl";
            this.tax_lbl.Size = new System.Drawing.Size(62, 16);
            this.tax_lbl.TabIndex = 2;
            this.tax_lbl.Text = "Tax (0%)";
            // 
            // sub_total_lbl
            // 
            this.sub_total_lbl.AutoSize = true;
            this.sub_total_lbl.Font = new System.Drawing.Font("Gilroy Light", 10F);
            this.sub_total_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.sub_total_lbl.Location = new System.Drawing.Point(26, 40);
            this.sub_total_lbl.Name = "sub_total_lbl";
            this.sub_total_lbl.Size = new System.Drawing.Size(70, 16);
            this.sub_total_lbl.TabIndex = 1;
            this.sub_total_lbl.Text = "Sub Total";
            // 
            // total_quantity_lbl
            // 
            this.total_quantity_lbl.AutoSize = true;
            this.total_quantity_lbl.Font = new System.Drawing.Font("Gilroy Light", 10F);
            this.total_quantity_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.total_quantity_lbl.Location = new System.Drawing.Point(26, 18);
            this.total_quantity_lbl.Name = "total_quantity_lbl";
            this.total_quantity_lbl.Size = new System.Drawing.Size(101, 16);
            this.total_quantity_lbl.TabIndex = 0;
            this.total_quantity_lbl.Text = "Total Quantity";
            // 
            // order_items_pnl
            // 
            this.order_items_pnl.AutoScroll = true;
            this.order_items_pnl.Controls.Add(this.order_items_flow_layout_pnl);
            this.order_items_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.order_items_pnl.Location = new System.Drawing.Point(3, 62);
            this.order_items_pnl.Name = "order_items_pnl";
            this.order_items_pnl.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.order_items_pnl.Size = new System.Drawing.Size(345, 601);
            this.order_items_pnl.TabIndex = 2;
            // 
            // order_items_flow_layout_pnl
            // 
            this.order_items_flow_layout_pnl.AutoScroll = true;
            this.order_items_flow_layout_pnl.AutoSize = true;
            this.order_items_flow_layout_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.order_items_flow_layout_pnl.Location = new System.Drawing.Point(0, 20);
            this.order_items_flow_layout_pnl.Name = "order_items_flow_layout_pnl";
            this.order_items_flow_layout_pnl.Size = new System.Drawing.Size(345, 561);
            this.order_items_flow_layout_pnl.TabIndex = 2;
            // 
            // home_menu_panel_pnl
            // 
            this.home_menu_panel_pnl.Controls.Add(this.home_menu_tbl_layout_pnl);
            this.home_menu_panel_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_menu_panel_pnl.Location = new System.Drawing.Point(3, 3);
            this.home_menu_panel_pnl.Name = "home_menu_panel_pnl";
            this.home_menu_panel_pnl.Size = new System.Drawing.Size(1410, 954);
            this.home_menu_panel_pnl.TabIndex = 1;
            // 
            // home_menu_tbl_layout_pnl
            // 
            this.home_menu_tbl_layout_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.home_menu_tbl_layout_pnl.ColumnCount = 1;
            this.home_menu_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.home_menu_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.home_menu_tbl_layout_pnl.Controls.Add(this.home_top_bar_panel_pnl, 0, 0);
            this.home_menu_tbl_layout_pnl.Controls.Add(this.order_menu_area_pnl, 0, 1);
            this.home_menu_tbl_layout_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_menu_tbl_layout_pnl.Font = new System.Drawing.Font("Gilroy Light", 10F);
            this.home_menu_tbl_layout_pnl.Location = new System.Drawing.Point(0, 0);
            this.home_menu_tbl_layout_pnl.Name = "home_menu_tbl_layout_pnl";
            this.home_menu_tbl_layout_pnl.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.home_menu_tbl_layout_pnl.RowCount = 2;
            this.home_menu_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.071279F));
            this.home_menu_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.92872F));
            this.home_menu_tbl_layout_pnl.Size = new System.Drawing.Size(1410, 954);
            this.home_menu_tbl_layout_pnl.TabIndex = 0;
            // 
            // home_top_bar_panel_pnl
            // 
            this.home_top_bar_panel_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.home_top_bar_panel_pnl.ColumnCount = 2;
            this.home_top_bar_panel_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.home_top_bar_panel_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.home_top_bar_panel_pnl.Controls.Add(this.shop_info_tbl_layout_pnl, 0, 0);
            this.home_top_bar_panel_pnl.Controls.Add(this.search_bar_main_pnl, 1, 0);
            this.home_top_bar_panel_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_top_bar_panel_pnl.Location = new System.Drawing.Point(3, 3);
            this.home_top_bar_panel_pnl.MinimumSize = new System.Drawing.Size(0, 70);
            this.home_top_bar_panel_pnl.Name = "home_top_bar_panel_pnl";
            this.home_top_bar_panel_pnl.RowCount = 1;
            this.home_top_bar_panel_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.home_top_bar_panel_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.home_top_bar_panel_pnl.Size = new System.Drawing.Size(1394, 70);
            this.home_top_bar_panel_pnl.TabIndex = 0;
            // 
            // shop_info_tbl_layout_pnl
            // 
            this.shop_info_tbl_layout_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shop_info_tbl_layout_pnl.ColumnCount = 1;
            this.shop_info_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.shop_info_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.shop_info_tbl_layout_pnl.Controls.Add(this.shop_name_lbl, 0, 0);
            this.shop_info_tbl_layout_pnl.Controls.Add(this.date_time_lbl, 0, 1);
            this.shop_info_tbl_layout_pnl.Location = new System.Drawing.Point(3, 3);
            this.shop_info_tbl_layout_pnl.Name = "shop_info_tbl_layout_pnl";
            this.shop_info_tbl_layout_pnl.RowCount = 2;
            this.shop_info_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.shop_info_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.shop_info_tbl_layout_pnl.Size = new System.Drawing.Size(691, 64);
            this.shop_info_tbl_layout_pnl.TabIndex = 0;
            // 
            // shop_name_lbl
            // 
            this.shop_name_lbl.AutoEllipsis = true;
            this.shop_name_lbl.AutoSize = true;
            this.shop_name_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shop_name_lbl.Font = new System.Drawing.Font("Gilroy ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shop_name_lbl.Location = new System.Drawing.Point(3, 0);
            this.shop_name_lbl.Name = "shop_name_lbl";
            this.shop_name_lbl.Size = new System.Drawing.Size(685, 40);
            this.shop_name_lbl.TabIndex = 1;
            this.shop_name_lbl.Text = "UR CRUNCH AND PIZZA";
            this.shop_name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // date_time_lbl
            // 
            this.date_time_lbl.AutoEllipsis = true;
            this.date_time_lbl.AutoSize = true;
            this.date_time_lbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.date_time_lbl.Font = new System.Drawing.Font("Gilroy Light", 8F);
            this.date_time_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.date_time_lbl.Location = new System.Drawing.Point(3, 40);
            this.date_time_lbl.Name = "date_time_lbl";
            this.date_time_lbl.Size = new System.Drawing.Size(101, 24);
            this.date_time_lbl.TabIndex = 2;
            this.date_time_lbl.Text = "December 31, 2022";
            this.date_time_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // search_bar_main_pnl
            // 
            this.search_bar_main_pnl.Controls.Add(this.search_bar_pnl);
            this.search_bar_main_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_bar_main_pnl.Location = new System.Drawing.Point(700, 3);
            this.search_bar_main_pnl.Name = "search_bar_main_pnl";
            this.search_bar_main_pnl.Padding = new System.Windows.Forms.Padding(0, 11, 0, 11);
            this.search_bar_main_pnl.Size = new System.Drawing.Size(691, 64);
            this.search_bar_main_pnl.TabIndex = 1;
            // 
            // search_bar_pnl
            // 
            this.search_bar_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.search_bar_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.search_bar_pnl.Controls.Add(this.search_bar_tbl_layout_pnl);
            this.search_bar_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.search_bar_pnl.Location = new System.Drawing.Point(351, 11);
            this.search_bar_pnl.Name = "search_bar_pnl";
            this.search_bar_pnl.Padding = new System.Windows.Forms.Padding(5);
            this.search_bar_pnl.Size = new System.Drawing.Size(340, 42);
            this.search_bar_pnl.TabIndex = 0;
            // 
            // search_bar_tbl_layout_pnl
            // 
            this.search_bar_tbl_layout_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.search_bar_tbl_layout_pnl.ColumnCount = 2;
            this.search_bar_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.393939F));
            this.search_bar_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.60606F));
            this.search_bar_tbl_layout_pnl.Controls.Add(this.search_bar_picture_box, 0, 0);
            this.search_bar_tbl_layout_pnl.Controls.Add(this.search_bar_txt_field_pnl, 1, 0);
            this.search_bar_tbl_layout_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_bar_tbl_layout_pnl.Location = new System.Drawing.Point(5, 5);
            this.search_bar_tbl_layout_pnl.Name = "search_bar_tbl_layout_pnl";
            this.search_bar_tbl_layout_pnl.RowCount = 1;
            this.search_bar_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.search_bar_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.search_bar_tbl_layout_pnl.Size = new System.Drawing.Size(330, 32);
            this.search_bar_tbl_layout_pnl.TabIndex = 0;
            // 
            // search_bar_picture_box
            // 
            this.search_bar_picture_box.Image = global::POS.Properties.Resources.search;
            this.search_bar_picture_box.Location = new System.Drawing.Point(3, 3);
            this.search_bar_picture_box.Name = "search_bar_picture_box";
            this.search_bar_picture_box.Padding = new System.Windows.Forms.Padding(2);
            this.search_bar_picture_box.Size = new System.Drawing.Size(24, 25);
            this.search_bar_picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search_bar_picture_box.TabIndex = 0;
            this.search_bar_picture_box.TabStop = false;
            // 
            // search_bar_txt_field_pnl
            // 
            this.search_bar_txt_field_pnl.Controls.Add(this.search_bar_txt_field);
            this.search_bar_txt_field_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_bar_txt_field_pnl.Location = new System.Drawing.Point(34, 3);
            this.search_bar_txt_field_pnl.Name = "search_bar_txt_field_pnl";
            this.search_bar_txt_field_pnl.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.search_bar_txt_field_pnl.Size = new System.Drawing.Size(293, 26);
            this.search_bar_txt_field_pnl.TabIndex = 1;
            // 
            // search_bar_txt_field
            // 
            this.search_bar_txt_field.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.search_bar_txt_field.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_bar_txt_field.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_bar_txt_field.ForeColor = System.Drawing.Color.DimGray;
            this.search_bar_txt_field.Location = new System.Drawing.Point(5, 0);
            this.search_bar_txt_field.MaximumSize = new System.Drawing.Size(0, 22);
            this.search_bar_txt_field.MinimumSize = new System.Drawing.Size(0, 22);
            this.search_bar_txt_field.Name = "search_bar_txt_field";
            this.search_bar_txt_field.Size = new System.Drawing.Size(288, 22);
            this.search_bar_txt_field.TabIndex = 0;
            this.search_bar_txt_field.Text = "Search Item";
            // 
            // order_menu_area_pnl
            // 
            this.order_menu_area_pnl.Controls.Add(this.order_menu_area_flow_layout_pnl);
            this.order_menu_area_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.order_menu_area_pnl.Location = new System.Drawing.Point(3, 79);
            this.order_menu_area_pnl.Name = "order_menu_area_pnl";
            this.order_menu_area_pnl.Padding = new System.Windows.Forms.Padding(20);
            this.order_menu_area_pnl.Size = new System.Drawing.Size(1394, 872);
            this.order_menu_area_pnl.TabIndex = 1;
            // 
            // order_menu_area_flow_layout_pnl
            // 
            this.order_menu_area_flow_layout_pnl.AutoScroll = true;
            this.order_menu_area_flow_layout_pnl.AutoSize = true;
            this.order_menu_area_flow_layout_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.order_menu_area_flow_layout_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.order_menu_area_flow_layout_pnl.Location = new System.Drawing.Point(20, 20);
            this.order_menu_area_flow_layout_pnl.Name = "order_menu_area_flow_layout_pnl";
            this.order_menu_area_flow_layout_pnl.Size = new System.Drawing.Size(1354, 832);
            this.order_menu_area_flow_layout_pnl.TabIndex = 0;
            // 
            // page_add_remove_items_pnl
            // 
            this.page_add_remove_items_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.page_add_remove_items_pnl.Controls.Add(this.add_remove_items_tbl_layout_pnl);
            this.page_add_remove_items_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_add_remove_items_pnl.Location = new System.Drawing.Point(0, 0);
            this.page_add_remove_items_pnl.Name = "page_add_remove_items_pnl";
            this.page_add_remove_items_pnl.Padding = new System.Windows.Forms.Padding(0, 25, 0, 50);
            this.page_add_remove_items_pnl.Size = new System.Drawing.Size(1769, 1035);
            this.page_add_remove_items_pnl.TabIndex = 0;
            // 
            // add_remove_items_tbl_layout_pnl
            // 
            this.add_remove_items_tbl_layout_pnl.AutoScroll = true;
            this.add_remove_items_tbl_layout_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.add_remove_items_tbl_layout_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.add_remove_items_tbl_layout_pnl.ColumnCount = 1;
            this.add_remove_items_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.add_remove_items_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.add_remove_items_tbl_layout_pnl.Controls.Add(this.add_remove_items_flow_layout_pnl, 0, 1);
            this.add_remove_items_tbl_layout_pnl.Controls.Add(this.menu_table_pnl, 0, 0);
            this.add_remove_items_tbl_layout_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_remove_items_tbl_layout_pnl.Location = new System.Drawing.Point(0, 25);
            this.add_remove_items_tbl_layout_pnl.Name = "add_remove_items_tbl_layout_pnl";
            this.add_remove_items_tbl_layout_pnl.Padding = new System.Windows.Forms.Padding(20);
            this.add_remove_items_tbl_layout_pnl.RowCount = 2;
            this.add_remove_items_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.37186F));
            this.add_remove_items_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.628141F));
            this.add_remove_items_tbl_layout_pnl.Size = new System.Drawing.Size(1769, 960);
            this.add_remove_items_tbl_layout_pnl.TabIndex = 0;
            // 
            // add_remove_items_flow_layout_pnl
            // 
            this.add_remove_items_flow_layout_pnl.AutoScroll = true;
            this.add_remove_items_flow_layout_pnl.AutoSize = true;
            this.add_remove_items_flow_layout_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.add_remove_items_flow_layout_pnl.Controls.Add(this.add_remove_items_save_changes_btn);
            this.add_remove_items_flow_layout_pnl.Controls.Add(this.delete_selected);
            this.add_remove_items_flow_layout_pnl.Controls.Add(this.add_remove_items_add_btn);
            this.add_remove_items_flow_layout_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_remove_items_flow_layout_pnl.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.add_remove_items_flow_layout_pnl.Location = new System.Drawing.Point(23, 891);
            this.add_remove_items_flow_layout_pnl.Name = "add_remove_items_flow_layout_pnl";
            this.add_remove_items_flow_layout_pnl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.add_remove_items_flow_layout_pnl.Size = new System.Drawing.Size(1723, 46);
            this.add_remove_items_flow_layout_pnl.TabIndex = 2;
            // 
            // add_remove_items_save_changes_btn
            // 
            this.add_remove_items_save_changes_btn.AutoSize = true;
            this.add_remove_items_save_changes_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.add_remove_items_save_changes_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.add_remove_items_save_changes_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.add_remove_items_save_changes_btn.FlatAppearance.BorderSize = 0;
            this.add_remove_items_save_changes_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_remove_items_save_changes_btn.ForeColor = System.Drawing.Color.White;
            this.add_remove_items_save_changes_btn.Location = new System.Drawing.Point(1490, 18);
            this.add_remove_items_save_changes_btn.MaximumSize = new System.Drawing.Size(230, 25);
            this.add_remove_items_save_changes_btn.MinimumSize = new System.Drawing.Size(230, 25);
            this.add_remove_items_save_changes_btn.Name = "add_remove_items_save_changes_btn";
            this.add_remove_items_save_changes_btn.Size = new System.Drawing.Size(230, 25);
            this.add_remove_items_save_changes_btn.TabIndex = 10;
            this.add_remove_items_save_changes_btn.Text = "Save Changes";
            this.add_remove_items_save_changes_btn.UseVisualStyleBackColor = false;
            this.add_remove_items_save_changes_btn.Click += new System.EventHandler(this.Add_remove_items_save_changes_btn_Click);
            // 
            // delete_selected
            // 
            this.delete_selected.AutoSize = true;
            this.delete_selected.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delete_selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.delete_selected.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.delete_selected.FlatAppearance.BorderSize = 0;
            this.delete_selected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_selected.ForeColor = System.Drawing.Color.White;
            this.delete_selected.Location = new System.Drawing.Point(1254, 18);
            this.delete_selected.MaximumSize = new System.Drawing.Size(230, 25);
            this.delete_selected.MinimumSize = new System.Drawing.Size(230, 25);
            this.delete_selected.Name = "delete_selected";
            this.delete_selected.Size = new System.Drawing.Size(230, 25);
            this.delete_selected.TabIndex = 11;
            this.delete_selected.Text = "Delete Selected";
            this.delete_selected.UseVisualStyleBackColor = false;
            this.delete_selected.Click += new System.EventHandler(this.Delete_selected_Click);
            // 
            // add_remove_items_add_btn
            // 
            this.add_remove_items_add_btn.AutoSize = true;
            this.add_remove_items_add_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.add_remove_items_add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.add_remove_items_add_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.add_remove_items_add_btn.FlatAppearance.BorderSize = 0;
            this.add_remove_items_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_remove_items_add_btn.ForeColor = System.Drawing.Color.White;
            this.add_remove_items_add_btn.Location = new System.Drawing.Point(1018, 18);
            this.add_remove_items_add_btn.MaximumSize = new System.Drawing.Size(230, 25);
            this.add_remove_items_add_btn.MinimumSize = new System.Drawing.Size(230, 25);
            this.add_remove_items_add_btn.Name = "add_remove_items_add_btn";
            this.add_remove_items_add_btn.Size = new System.Drawing.Size(230, 25);
            this.add_remove_items_add_btn.TabIndex = 9;
            this.add_remove_items_add_btn.Text = "Add Item";
            this.add_remove_items_add_btn.UseVisualStyleBackColor = false;
            this.add_remove_items_add_btn.Click += new System.EventHandler(this.Add_remove_items_add_btn_Click);
            // 
            // menu_table_pnl
            // 
            this.menu_table_pnl.AutoScroll = true;
            this.menu_table_pnl.AutoSize = true;
            this.menu_table_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menu_table_pnl.Controls.Add(this.menu_table_tbl);
            this.menu_table_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_table_pnl.Location = new System.Drawing.Point(23, 23);
            this.menu_table_pnl.Name = "menu_table_pnl";
            this.menu_table_pnl.Size = new System.Drawing.Size(1723, 862);
            this.menu_table_pnl.TabIndex = 1;
            // 
            // menu_table_tbl
            // 
            this.menu_table_tbl.AllowUserToAddRows = false;
            this.menu_table_tbl.AllowUserToDeleteRows = false;
            this.menu_table_tbl.AllowUserToResizeColumns = false;
            this.menu_table_tbl.AllowUserToResizeRows = false;
            this.menu_table_tbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menu_table_tbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gilroy Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menu_table_tbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.menu_table_tbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menu_table_tbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check_box,
            this.item_image,
            this.item_name,
            this.item_price,
            this.item_ingredients,
            this.item_delete});
            this.menu_table_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_table_tbl.Location = new System.Drawing.Point(0, 0);
            this.menu_table_tbl.Name = "menu_table_tbl";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gilroy Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menu_table_tbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.menu_table_tbl.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Gilroy Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.menu_table_tbl.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.menu_table_tbl.RowTemplate.Height = 25;
            this.menu_table_tbl.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.menu_table_tbl.Size = new System.Drawing.Size(1723, 862);
            this.menu_table_tbl.TabIndex = 0;
            this.menu_table_tbl.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Menu_table_tbl_CellEdit);
            this.menu_table_tbl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Menu_table_tbl_CellContentClick);
            // 
            // check_box
            // 
            this.check_box.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.check_box.FillWeight = 25F;
            this.check_box.HeaderText = "";
            this.check_box.MinimumWidth = 25;
            this.check_box.Name = "check_box";
            this.check_box.Width = 25;
            // 
            // item_image
            // 
            this.item_image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.item_image.HeaderText = "Item Image";
            this.item_image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.item_image.MinimumWidth = 100;
            this.item_image.Name = "item_image";
            // 
            // item_name
            // 
            this.item_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.item_name.HeaderText = "Item Name";
            this.item_name.MinimumWidth = 100;
            this.item_name.Name = "item_name";
            // 
            // item_price
            // 
            this.item_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.item_price.HeaderText = "Item Price";
            this.item_price.MinimumWidth = 100;
            this.item_price.Name = "item_price";
            // 
            // item_ingredients
            // 
            this.item_ingredients.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.item_ingredients.HeaderText = "Ingredients";
            this.item_ingredients.MinimumWidth = 100;
            this.item_ingredients.Name = "item_ingredients";
            // 
            // item_delete
            // 
            this.item_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.item_delete.HeaderText = "";
            this.item_delete.MinimumWidth = 100;
            this.item_delete.Name = "item_delete";
            this.item_delete.Text = "Delete";
            this.item_delete.ToolTipText = "Delete Item";
            this.item_delete.UseColumnTextForButtonValue = true;
            // 
            // page_order_history_panel_main_pnl
            // 
            this.page_order_history_panel_main_pnl.AutoScroll = true;
            this.page_order_history_panel_main_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.page_order_history_panel_main_pnl.Controls.Add(this.order_history_panel_main_tbl_layout_pnl);
            this.page_order_history_panel_main_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_order_history_panel_main_pnl.Location = new System.Drawing.Point(0, 0);
            this.page_order_history_panel_main_pnl.Name = "page_order_history_panel_main_pnl";
            this.page_order_history_panel_main_pnl.Padding = new System.Windows.Forms.Padding(0, 25, 10, 50);
            this.page_order_history_panel_main_pnl.Size = new System.Drawing.Size(1769, 1035);
            this.page_order_history_panel_main_pnl.TabIndex = 3;
            // 
            // order_history_panel_main_tbl_layout_pnl
            // 
            this.order_history_panel_main_tbl_layout_pnl.AutoScroll = true;
            this.order_history_panel_main_tbl_layout_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.order_history_panel_main_tbl_layout_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.order_history_panel_main_tbl_layout_pnl.ColumnCount = 1;
            this.order_history_panel_main_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.order_history_panel_main_tbl_layout_pnl.Controls.Add(this.order_history_panel_table_pnl, 0, 1);
            this.order_history_panel_main_tbl_layout_pnl.Controls.Add(this.history_panel_top_flow_layout_pnl, 0, 0);
            this.order_history_panel_main_tbl_layout_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.order_history_panel_main_tbl_layout_pnl.Location = new System.Drawing.Point(0, 25);
            this.order_history_panel_main_tbl_layout_pnl.Name = "order_history_panel_main_tbl_layout_pnl";
            this.order_history_panel_main_tbl_layout_pnl.Padding = new System.Windows.Forms.Padding(10);
            this.order_history_panel_main_tbl_layout_pnl.RowCount = 2;
            this.order_history_panel_main_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.order_history_panel_main_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.order_history_panel_main_tbl_layout_pnl.Size = new System.Drawing.Size(1759, 960);
            this.order_history_panel_main_tbl_layout_pnl.TabIndex = 0;
            // 
            // order_history_panel_table_pnl
            // 
            this.order_history_panel_table_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.order_history_panel_table_pnl.Controls.Add(this.order_history_table_tbl);
            this.order_history_panel_table_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.order_history_panel_table_pnl.Location = new System.Drawing.Point(13, 58);
            this.order_history_panel_table_pnl.Name = "order_history_panel_table_pnl";
            this.order_history_panel_table_pnl.Size = new System.Drawing.Size(1733, 889);
            this.order_history_panel_table_pnl.TabIndex = 0;
            // 
            // order_history_table_tbl
            // 
            this.order_history_table_tbl.AllowUserToAddRows = false;
            this.order_history_table_tbl.AllowUserToDeleteRows = false;
            this.order_history_table_tbl.AllowUserToResizeColumns = false;
            this.order_history_table_tbl.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Gilroy Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.order_history_table_tbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.order_history_table_tbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_history_table_tbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_no,
            this.order_date_time,
            this.order_time,
            this.item_quantity,
            this.order_tax,
            this.total_price});
            this.order_history_table_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.order_history_table_tbl.Location = new System.Drawing.Point(0, 0);
            this.order_history_table_tbl.Name = "order_history_table_tbl";
            this.order_history_table_tbl.ReadOnly = true;
            this.order_history_table_tbl.RowHeadersVisible = false;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.order_history_table_tbl.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.order_history_table_tbl.RowTemplate.ReadOnly = true;
            this.order_history_table_tbl.Size = new System.Drawing.Size(1733, 889);
            this.order_history_table_tbl.TabIndex = 0;
            // 
            // order_no
            // 
            this.order_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.order_no.HeaderText = "Order #";
            this.order_no.MinimumWidth = 100;
            this.order_no.Name = "order_no";
            this.order_no.ReadOnly = true;
            this.order_no.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // order_date_time
            // 
            this.order_date_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.order_date_time.HeaderText = "Date";
            this.order_date_time.MinimumWidth = 100;
            this.order_date_time.Name = "order_date_time";
            this.order_date_time.ReadOnly = true;
            this.order_date_time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // order_time
            // 
            this.order_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.order_time.HeaderText = "Time";
            this.order_time.MinimumWidth = 100;
            this.order_time.Name = "order_time";
            this.order_time.ReadOnly = true;
            this.order_time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // item_quantity
            // 
            this.item_quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.item_quantity.HeaderText = "Items Quantity";
            this.item_quantity.MinimumWidth = 100;
            this.item_quantity.Name = "item_quantity";
            this.item_quantity.ReadOnly = true;
            this.item_quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // order_tax
            // 
            this.order_tax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.order_tax.HeaderText = "Tax";
            this.order_tax.MinimumWidth = 100;
            this.order_tax.Name = "order_tax";
            this.order_tax.ReadOnly = true;
            this.order_tax.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // total_price
            // 
            this.total_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total_price.HeaderText = "Price";
            this.total_price.MinimumWidth = 100;
            this.total_price.Name = "total_price";
            this.total_price.ReadOnly = true;
            this.total_price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // history_panel_top_flow_layout_pnl
            // 
            this.history_panel_top_flow_layout_pnl.AutoScroll = true;
            this.history_panel_top_flow_layout_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.history_panel_top_flow_layout_pnl.Controls.Add(this.history_panel_filter_combo_box);
            this.history_panel_top_flow_layout_pnl.Controls.Add(this.history_panel_filter_lbl);
            this.history_panel_top_flow_layout_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.history_panel_top_flow_layout_pnl.Location = new System.Drawing.Point(13, 13);
            this.history_panel_top_flow_layout_pnl.Name = "history_panel_top_flow_layout_pnl";
            this.history_panel_top_flow_layout_pnl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.history_panel_top_flow_layout_pnl.Size = new System.Drawing.Size(1733, 39);
            this.history_panel_top_flow_layout_pnl.TabIndex = 1;
            // 
            // history_panel_filter_combo_box
            // 
            this.history_panel_filter_combo_box.BackColor = System.Drawing.Color.White;
            this.history_panel_filter_combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.history_panel_filter_combo_box.FormattingEnabled = true;
            this.history_panel_filter_combo_box.Items.AddRange(new object[] {
            "All Time"});
            this.history_panel_filter_combo_box.Location = new System.Drawing.Point(1504, 3);
            this.history_panel_filter_combo_box.Name = "history_panel_filter_combo_box";
            this.history_panel_filter_combo_box.Size = new System.Drawing.Size(226, 21);
            this.history_panel_filter_combo_box.TabIndex = 0;
            // 
            // history_panel_filter_lbl
            // 
            this.history_panel_filter_lbl.AutoSize = true;
            this.history_panel_filter_lbl.Location = new System.Drawing.Point(1440, 3);
            this.history_panel_filter_lbl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.history_panel_filter_lbl.MinimumSize = new System.Drawing.Size(0, 21);
            this.history_panel_filter_lbl.Name = "history_panel_filter_lbl";
            this.history_panel_filter_lbl.Size = new System.Drawing.Size(58, 21);
            this.history_panel_filter_lbl.TabIndex = 1;
            this.history_panel_filter_lbl.Text = "Date Filter";
            this.history_panel_filter_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // page_stock_panel_main_pnl
            // 
            this.page_stock_panel_main_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.page_stock_panel_main_pnl.Controls.Add(this.stock_panel_main_tbl_layout_pnl);
            this.page_stock_panel_main_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_stock_panel_main_pnl.Location = new System.Drawing.Point(0, 0);
            this.page_stock_panel_main_pnl.Name = "page_stock_panel_main_pnl";
            this.page_stock_panel_main_pnl.Padding = new System.Windows.Forms.Padding(0, 25, 0, 50);
            this.page_stock_panel_main_pnl.Size = new System.Drawing.Size(1769, 1035);
            this.page_stock_panel_main_pnl.TabIndex = 4;
            // 
            // stock_panel_main_tbl_layout_pnl
            // 
            this.stock_panel_main_tbl_layout_pnl.AutoScroll = true;
            this.stock_panel_main_tbl_layout_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stock_panel_main_tbl_layout_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.stock_panel_main_tbl_layout_pnl.ColumnCount = 1;
            this.stock_panel_main_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.stock_panel_main_tbl_layout_pnl.Controls.Add(this.stock_panel_tabel_pnl, 0, 0);
            this.stock_panel_main_tbl_layout_pnl.Controls.Add(this.stock_panel_bottom_flow_layout_pnl, 0, 1);
            this.stock_panel_main_tbl_layout_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stock_panel_main_tbl_layout_pnl.Location = new System.Drawing.Point(0, 25);
            this.stock_panel_main_tbl_layout_pnl.Name = "stock_panel_main_tbl_layout_pnl";
            this.stock_panel_main_tbl_layout_pnl.Padding = new System.Windows.Forms.Padding(10);
            this.stock_panel_main_tbl_layout_pnl.RowCount = 2;
            this.stock_panel_main_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.stock_panel_main_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.stock_panel_main_tbl_layout_pnl.Size = new System.Drawing.Size(1769, 960);
            this.stock_panel_main_tbl_layout_pnl.TabIndex = 0;
            // 
            // stock_panel_tabel_pnl
            // 
            this.stock_panel_tabel_pnl.Controls.Add(this.stock_panel_tabel_tbl);
            this.stock_panel_tabel_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stock_panel_tabel_pnl.Location = new System.Drawing.Point(13, 13);
            this.stock_panel_tabel_pnl.Name = "stock_panel_tabel_pnl";
            this.stock_panel_tabel_pnl.Size = new System.Drawing.Size(1743, 876);
            this.stock_panel_tabel_pnl.TabIndex = 0;
            // 
            // stock_panel_tabel_tbl
            // 
            this.stock_panel_tabel_tbl.AllowUserToAddRows = false;
            this.stock_panel_tabel_tbl.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Gilroy Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stock_panel_tabel_tbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.stock_panel_tabel_tbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stock_panel_tabel_tbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.stock_name,
            this.stock_in,
            this.stock_out,
            this.stock_remaining,
            this.single_stock_price,
            this.stock_total});
            this.stock_panel_tabel_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stock_panel_tabel_tbl.Location = new System.Drawing.Point(0, 0);
            this.stock_panel_tabel_tbl.Name = "stock_panel_tabel_tbl";
            this.stock_panel_tabel_tbl.ReadOnly = true;
            this.stock_panel_tabel_tbl.RowHeadersVisible = false;
            this.stock_panel_tabel_tbl.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.stock_panel_tabel_tbl.RowTemplate.ReadOnly = true;
            this.stock_panel_tabel_tbl.Size = new System.Drawing.Size(1743, 876);
            this.stock_panel_tabel_tbl.TabIndex = 0;
            this.stock_panel_tabel_tbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.out_stock);
            // 
            // id
            // 
            this.id.FillWeight = 25F;
            this.id.HeaderText = "#";
            this.id.MinimumWidth = 25;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 25;
            // 
            // stock_name
            // 
            this.stock_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stock_name.HeaderText = "Item Name";
            this.stock_name.Name = "stock_name";
            this.stock_name.ReadOnly = true;
            // 
            // stock_in
            // 
            this.stock_in.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stock_in.HeaderText = "In Quantity";
            this.stock_in.Name = "stock_in";
            this.stock_in.ReadOnly = true;
            // 
            // stock_out
            // 
            this.stock_out.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stock_out.HeaderText = "Out Quantity";
            this.stock_out.Name = "stock_out";
            this.stock_out.ReadOnly = true;
            // 
            // stock_remaining
            // 
            this.stock_remaining.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stock_remaining.HeaderText = "Remaining Quantity";
            this.stock_remaining.Name = "stock_remaining";
            this.stock_remaining.ReadOnly = true;
            // 
            // single_stock_price
            // 
            this.single_stock_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.single_stock_price.HeaderText = "Single Item Price";
            this.single_stock_price.Name = "single_stock_price";
            this.single_stock_price.ReadOnly = true;
            // 
            // stock_total
            // 
            this.stock_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stock_total.HeaderText = "Total Price";
            this.stock_total.Name = "stock_total";
            this.stock_total.ReadOnly = true;
            // 
            // stock_panel_bottom_flow_layout_pnl
            // 
            this.stock_panel_bottom_flow_layout_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stock_panel_bottom_flow_layout_pnl.Controls.Add(this.stock_panel_add_btn);
            this.stock_panel_bottom_flow_layout_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stock_panel_bottom_flow_layout_pnl.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.stock_panel_bottom_flow_layout_pnl.Location = new System.Drawing.Point(13, 895);
            this.stock_panel_bottom_flow_layout_pnl.Name = "stock_panel_bottom_flow_layout_pnl";
            this.stock_panel_bottom_flow_layout_pnl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.stock_panel_bottom_flow_layout_pnl.Size = new System.Drawing.Size(1743, 52);
            this.stock_panel_bottom_flow_layout_pnl.TabIndex = 1;
            // 
            // stock_panel_add_btn
            // 
            this.stock_panel_add_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stock_panel_add_btn.AutoSize = true;
            this.stock_panel_add_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stock_panel_add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.stock_panel_add_btn.FlatAppearance.BorderSize = 0;
            this.stock_panel_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stock_panel_add_btn.ForeColor = System.Drawing.Color.White;
            this.stock_panel_add_btn.Location = new System.Drawing.Point(1510, 24);
            this.stock_panel_add_btn.MaximumSize = new System.Drawing.Size(230, 25);
            this.stock_panel_add_btn.MinimumSize = new System.Drawing.Size(230, 25);
            this.stock_panel_add_btn.Name = "stock_panel_add_btn";
            this.stock_panel_add_btn.Size = new System.Drawing.Size(230, 25);
            this.stock_panel_add_btn.TabIndex = 11;
            this.stock_panel_add_btn.Text = "Add Stock";
            this.stock_panel_add_btn.UseVisualStyleBackColor = false;
            this.stock_panel_add_btn.Click += new System.EventHandler(this.Stock_panel_add_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Menu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "History";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Stock";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.main_tbl_layout_pnl);
            this.Font = new System.Drawing.Font("Gilroy Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main_form";
            this.Text = " POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.main_tbl_layout_pnl.ResumeLayout(false);
            this.main_tbl_layout_pnl.PerformLayout();
            this.left_tbl_layout_pnl.ResumeLayout(false);
            this.left_tbl_layout_pnl.PerformLayout();
            this.pos_info_tbl_layout_pnl.ResumeLayout(false);
            this.pos_info_tbl_layout_pnl.PerformLayout();
            this.pos_image_panel_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pos_icon_picture_box)).EndInit();
            this.menu_pnl.ResumeLayout(false);
            this.menu_order_history_pnl.ResumeLayout(false);
            this.menu_order_history_tbl_layout_pnl.ResumeLayout(false);
            this.menu_order_history_tbl_layout_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_history_picture_box)).EndInit();
            this.menu_stock_pnl.ResumeLayout(false);
            this.menu_stock_tbl_layout_pnl.ResumeLayout(false);
            this.menu_stock_tbl_layout_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stock_picture_box)).EndInit();
            this.menu_items_menu_pnl.ResumeLayout(false);
            this.menu_items_menu_tbl_layout_pnl.ResumeLayout(false);
            this.menu_items_menu_tbl_layout_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu_item_picture_box)).EndInit();
            this.menu_home_pnl.ResumeLayout(false);
            this.menu_home_tbl_layout_pnl.ResumeLayout(false);
            this.menu_home_tbl_layout_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_picture_box)).EndInit();
            this.stack_pane_pnl.ResumeLayout(false);
            this.stack_pane_pnl.PerformLayout();
            this.page_home_main_pnl.ResumeLayout(false);
            this.home_secondary_pnl.ResumeLayout(false);
            this.home_main_tbl_layout_pnl.ResumeLayout(false);
            this.home_main_tbl_layout_pnl.PerformLayout();
            this.order_side_tbl_layout_pnl.ResumeLayout(false);
            this.order_info_tbl_layout_pnl.ResumeLayout(false);
            this.order_info_tbl_layout_pnl.PerformLayout();
            this.price_details_pnl.ResumeLayout(false);
            this.price_details_sub_panel.ResumeLayout(false);
            this.price_details_tbl_layout_pnl.ResumeLayout(false);
            this.place_order_pnl.ResumeLayout(false);
            this.price_details_main_pnl.ResumeLayout(false);
            this.price_details_main_pnl.PerformLayout();
            this.order_items_pnl.ResumeLayout(false);
            this.order_items_pnl.PerformLayout();
            this.home_menu_panel_pnl.ResumeLayout(false);
            this.home_menu_tbl_layout_pnl.ResumeLayout(false);
            this.home_top_bar_panel_pnl.ResumeLayout(false);
            this.shop_info_tbl_layout_pnl.ResumeLayout(false);
            this.shop_info_tbl_layout_pnl.PerformLayout();
            this.search_bar_main_pnl.ResumeLayout(false);
            this.search_bar_pnl.ResumeLayout(false);
            this.search_bar_tbl_layout_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.search_bar_picture_box)).EndInit();
            this.search_bar_txt_field_pnl.ResumeLayout(false);
            this.search_bar_txt_field_pnl.PerformLayout();
            this.order_menu_area_pnl.ResumeLayout(false);
            this.order_menu_area_pnl.PerformLayout();
            this.page_add_remove_items_pnl.ResumeLayout(false);
            this.add_remove_items_tbl_layout_pnl.ResumeLayout(false);
            this.add_remove_items_tbl_layout_pnl.PerformLayout();
            this.add_remove_items_flow_layout_pnl.ResumeLayout(false);
            this.add_remove_items_flow_layout_pnl.PerformLayout();
            this.menu_table_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menu_table_tbl)).EndInit();
            this.page_order_history_panel_main_pnl.ResumeLayout(false);
            this.order_history_panel_main_tbl_layout_pnl.ResumeLayout(false);
            this.order_history_panel_table_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.order_history_table_tbl)).EndInit();
            this.history_panel_top_flow_layout_pnl.ResumeLayout(false);
            this.history_panel_top_flow_layout_pnl.PerformLayout();
            this.page_stock_panel_main_pnl.ResumeLayout(false);
            this.stock_panel_main_tbl_layout_pnl.ResumeLayout(false);
            this.stock_panel_tabel_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stock_panel_tabel_tbl)).EndInit();
            this.stock_panel_bottom_flow_layout_pnl.ResumeLayout(false);
            this.stock_panel_bottom_flow_layout_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        public void initialize() {
            reset_menu_color();
            reset_pages();
            make_page_visible(Pages.HOME);
            this.initialize_menu_clicks();
            this.add_remove_items_save_changes_btn.Enabled = false;
            this.order_id_lbl.Text = "#"+generate_order_id(10);
            this.date_time_lbl.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        public void load_data_from_db() {
            load_items();
            load_orders();
            load_stock();
        }


        public void load_items() {
            try {
                this.connection.Open();
                string query = "SELECT * FROM ITEM";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter data_adapter = new SqlDataAdapter(command);
                DataSet dataset = new DataSet();
                data_adapter.Fill(dataset, "temp_data");
                int total_rows = dataset.Tables["temp_data"].Rows.Count;
                for (int row_count = 0; row_count < total_rows; row_count++) {
                    string item_name = (string)dataset.Tables["temp_data"].Rows[row_count]["Item_name"];
                    float item_price = (float)((Double)dataset.Tables["temp_data"].Rows[row_count]["Item_price"]);
                    string item_ingredients = (string)dataset.Tables["temp_data"].Rows[row_count]["Item_ingredients"];
                    Image item_image = Image.FromStream(new MemoryStream((Byte[])dataset.Tables["temp_data"].Rows[row_count]["Item_image"]));
                    Item item = new Item(item_name, item_price, item_ingredients, item_image);
                    this.show_item_on_home(item);
                    this.show_item_on_menu(item);
                }
                data_adapter.Dispose();
                this.connection.Close();
                command.Dispose();
            }catch(Exception e) {
                MessageBox.Show(e.ToString());
            }
        }

        public void add_item_to_db(Item item) {
            string item_name = item.get_name();
            float item_price = item.get_price();
            string item_ingredients = item.get_ingredients();
            byte[] item_image = (byte[])(new ImageConverter()).ConvertTo(item.get_image(), typeof(byte[]));
            this.connection.Open();
            string query = "INSERT INTO ITEM VALUES (@image,@name,@price,@ingredients)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@image",item_image);
            command.Parameters.AddWithValue("@name", item_name);
            command.Parameters.AddWithValue("@price", item_price);
            command.Parameters.AddWithValue("@ingredients", item_ingredients);
            command.ExecuteNonQuery();
            this.connection.Close();
            command.Dispose();
        }

        public void update_item_in_db(Item item, int index) {
            string item_name = item.get_name();
            float item_price = item.get_price();
            string item_ingredients = item.get_ingredients();
            byte[] item_image = (byte[])(new ImageConverter()).ConvertTo(item.get_image(), typeof(byte[]));
            this.connection.Open();
            string query = "UPDATE Item " +
                "SET " +
                "Item_name = @name, " +
                "Item_price = @price, " +
                "Item_ingredients = @ingredients, " +
                "Item_image = @image " +
                "WHERE " +
                "Item_name = (" +
                    "SELECT Item_name FROM (" +
                        "SELECT Item_name, row_number() over(order by Item_name) " +
                        "AS " +
                        "line_number FROM Item" +
                    ") A " +
                    "WHERE " +
                    "line_number = " + (index+1) + 
                ")";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@name", item_name);
            command.Parameters.AddWithValue("@price", item_price);
            command.Parameters.AddWithValue("@ingredients", item_ingredients);
            command.Parameters.AddWithValue("@image", item_image);

            command.ExecuteNonQuery();
            this.connection.Close();
            command.Dispose();
        }

        public void remove_item_in_db(int index) {
            this.connection.Open();
            string query = "DELETE FROM ITEM " +
                "WHERE " +
                "Item_name = (" +
                    "SELECT Item_name FROM (" +
                        "SELECT Item_name, row_number() over(order by Item_name) " +
                        "AS " +
                        "LINE_NUMBER FROM ITEM" +
                     ")A " +
                     "WHERE " +
                     "LINE_NUMBER=" + (index + 1) + ")";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            this.connection.Close();
            command.Dispose();
        }

        public void load_orders() {
            this.connection.Open();
            string query = "SELECT * FROM ORDERS";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter data_adapter = new SqlDataAdapter(command);
            DataSet dataset = new DataSet();
            data_adapter.Fill(dataset, "temp_data");
            int total_rows = dataset.Tables["temp_data"].Rows.Count;
            for (int row_count = 0; row_count < total_rows; row_count++) {
                string order_id = (string)dataset.Tables["temp_data"].Rows[row_count]["order_id"];
                string order_date = (string)dataset.Tables["temp_data"].Rows[row_count]["order_date"];
                string order_time = (string)dataset.Tables["temp_data"].Rows[row_count]["order_time"];
                int order_quantity = (int)dataset.Tables["temp_data"].Rows[row_count]["order_item_quantity"];
                float order_tax = (float)((Double)dataset.Tables["temp_data"].Rows[row_count]["order_tax"]);
                float order_price = (float)((Double)dataset.Tables["temp_data"].Rows[row_count]["order_price"]);
                this.add_history(new Dictionary<string, string>() {
                    { "date", order_date},
                    {"time",order_time },
                    {"id", order_id },
                    {"quantity", order_quantity.ToString() },
                    {"tax", order_tax.ToString() },
                    {"price", order_price.ToString() }
                });
            }
            data_adapter.Dispose();
            this.connection.Close();
            command.Dispose();
        }

        public void add_orders_to_db(Dictionary<string,string> history) {
            string order_id = history["id"];
            string order_date = history["date"];
            string order_time = history["time"];
            int order_quantity = int.Parse(history["quantity"]);
            float order_tax = float.Parse(history["tax"]);
            float order_price = float.Parse(history["price"]);
            this.connection.Open();
            string query = "INSERT INTO Orders VALUES (@id,@date,@time,@quantity,@tax,@price)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", order_id);
            command.Parameters.AddWithValue("@date", order_date);
            command.Parameters.AddWithValue("@time", order_time);
            command.Parameters.AddWithValue("@quantity", order_quantity);
            command.Parameters.AddWithValue("@tax", order_tax);
            command.Parameters.AddWithValue("@price", order_price);
            command.ExecuteNonQuery();
            this.connection.Close();
            command.Dispose();
        }
        public void load_stock() {
            this.connection.Open();
            string query = "SELECT * FROM stock";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter data_adapter = new SqlDataAdapter(command);
            DataSet dataset = new DataSet();
            data_adapter.Fill(dataset, "temp_data");
            int total_rows = dataset.Tables["temp_data"].Rows.Count;
            for (int row_count = 0; row_count < total_rows; row_count++) {
                string stock_name = (string)dataset.Tables["temp_data"].Rows[row_count]["stock_name"];
                int stock_in = (int)dataset.Tables["temp_data"].Rows[row_count]["in_quantity"];
                int stock_out = (int)dataset.Tables["temp_data"].Rows[row_count]["out_quantity"];
                int stock_remaining = (int)dataset.Tables["temp_data"].Rows[row_count]["remaining_quantity"];
                float single_stock_price = (float)((Double)dataset.Tables["temp_data"].Rows[row_count]["single_item_price"]);
                float stock_total = (float)((Double)dataset.Tables["temp_data"].Rows[row_count]["total_price"]);
                this.add_stock(new Dictionary<string, string>() {
                    {"stock_name" ,stock_name.ToString()},
                    {"stock_in", stock_in.ToString() },
                    {"stock_out",stock_out.ToString() },
                    {"stock_remaining",stock_remaining.ToString() },
                    {"single_stock_price",single_stock_price.ToString() },
                    {"stock_total",stock_total.ToString() }
                });
            }
            data_adapter.Dispose();
            this.connection.Close();
            command.Dispose();
        }
        public void add_stock_to_db(Dictionary<string, string> stock) {
            string stock_name = stock["stock_name"];
            int stock_in = int.Parse(stock["stock_in"]);
            int stock_out = int.Parse(stock["stock_out"]);
            int stock_remaining = int.Parse(stock["stock_remaining"]);
            float single_stock_price = float.Parse(stock["single_stock_price"]);
            float stock_total = float.Parse(stock["stock_total"]);
            this.connection.Open();
            string query = "INSERT INTO stock VALUES (@name,@in,@out,@remaining,@single_price,@total_price)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", stock_name);
            command.Parameters.AddWithValue("@in", stock_in);
            command.Parameters.AddWithValue("@out", stock_out);
            command.Parameters.AddWithValue("@remaining", stock_remaining);
            command.Parameters.AddWithValue("@single_price", single_stock_price);
            command.Parameters.AddWithValue("@total_price", stock_total);
            command.ExecuteNonQuery();
            this.connection.Close();
            command.Dispose();
        }

        public void update_stock_in_db(Dictionary<string, string> stock, int index) {
            int stock_in = int.Parse(stock["stock_in"]);
            int stock_out = int.Parse(stock["stock_out"]);
            int stock_remaining = int.Parse(stock["stock_remaining"]);
            this.connection.Open();
            string query = "UPDATE stock " +
                "SET " +
                "in_quantity = @in, " +
                "out_quantity = @out, " +
                "remaining_quantity = @remaining " +
                "WHERE " +
                "stock_name = (" +
                    "SELECT stock_name FROM (" +
                        "SELECT stock_name, row_number() over(order by stock_name) " +
                        "AS " +
                        "line_number FROM stock" +
                    ") A " +
                    "WHERE " +
                    "line_number = " + (index + 1) +
                ")";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@in", stock_in);
            command.Parameters.AddWithValue("@out", stock_out);
            command.Parameters.AddWithValue("@remaining", stock_remaining);
            command.ExecuteNonQuery();
            this.connection.Close();
            command.Dispose();
        }

        private string generate_order_id(int length) {
            var rng = new RNGCryptoServiceProvider();
            var padded = (int)Math.Ceiling(length / 2.0m);
            var bytes = new byte[padded];
            rng.GetBytes(bytes);
            return bytes.Aggregate(new StringBuilder(), (f, s) => f.AppendFormat("{0:X2}", s)).ToString(0, length);
        }

        private void reset_menu_color() {
            menu_home_pnl.BackColor = menu_items_menu_pnl.BackColor = menu_order_history_pnl.BackColor = menu_stock_pnl.BackColor = black_color;
        }

        private void reset_pages() {
            page_home_main_pnl.Visible = page_add_remove_items_pnl.Visible = page_order_history_panel_main_pnl.Visible = page_stock_panel_main_pnl.Visible = false;
        }

        private void make_page_visible(Pages page) {
            switch (page) {
                case Pages.HOME:
                    menu_home_pnl.BackColor = pink_color;
                    page_home_main_pnl.Visible = true;
                    break;
                case Pages.MENU:
                    menu_items_menu_pnl.BackColor = pink_color;
                    page_add_remove_items_pnl.Visible = true;
                    break;
                case Pages.HISTORY:
                    menu_order_history_pnl.BackColor = pink_color;
                    page_order_history_panel_main_pnl.Visible = true;
                    break;
                case Pages.STOCK:
                    menu_stock_pnl.BackColor = pink_color;
                    page_stock_panel_main_pnl.Visible = true;
                    break;
            }
        }

        private enum Pages {
            HOME,MENU,HISTORY,STOCK
        }

        private void initialize_menu_clicks() {
            menu_home_pnl.Click += menu_click_event;
            home_lbl.Click += menu_click_event;
            home_picture_box.Click += menu_click_event;
            menu_home_tbl_layout_pnl.Click += menu_click_event;

            menu_items_menu_pnl.Click += menu_click_event;
            menu_item_lbl.Click += menu_click_event;
            menu_item_picture_box.Click += menu_click_event;
            menu_items_menu_tbl_layout_pnl.Click += menu_click_event;

            menu_stock_pnl.Click += menu_click_event;
            stock_lbl.Click += menu_click_event;
            stock_picture_box.Click += menu_click_event;
            menu_stock_tbl_layout_pnl.Click += menu_click_event; ;

            menu_order_history_pnl.Click += menu_click_event;
            history_lbl.Click += menu_click_event;
            order_history_picture_box.Click += menu_click_event;
            menu_order_history_tbl_layout_pnl.Click += menu_click_event;

        }

        private void menu_clicked(System.Windows.Forms.Panel menu_clicked, System.Windows.Forms.Panel panel_to_show) {
            if (!panel_to_show.Visible) {
                reset_menu_color();
                reset_pages();
                menu_clicked.BackColor = pink_color;
                panel_to_show.Visible = true;
            }

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel main_tbl_layout_pnl;
        private System.Windows.Forms.TableLayoutPanel left_tbl_layout_pnl;
        private System.Windows.Forms.TableLayoutPanel pos_info_tbl_layout_pnl;
        private System.Windows.Forms.Label pos_title_lbl;
        private System.Windows.Forms.Panel menu_pnl;
        private System.Windows.Forms.Panel menu_home_pnl;
        private System.Windows.Forms.TableLayoutPanel menu_home_tbl_layout_pnl;
        private System.Windows.Forms.Label home_lbl;
        private System.Windows.Forms.PictureBox home_picture_box;
        private System.Windows.Forms.Panel menu_items_menu_pnl;
        private System.Windows.Forms.TableLayoutPanel menu_items_menu_tbl_layout_pnl;
        private System.Windows.Forms.Label menu_item_lbl;
        private System.Windows.Forms.PictureBox menu_item_picture_box;
        private System.Windows.Forms.Panel menu_stock_pnl;
        private System.Windows.Forms.TableLayoutPanel menu_stock_tbl_layout_pnl;
        private System.Windows.Forms.Label stock_lbl;
        private System.Windows.Forms.PictureBox stock_picture_box;
        private System.Windows.Forms.Panel menu_order_history_pnl;
        private System.Windows.Forms.TableLayoutPanel menu_order_history_tbl_layout_pnl;
        private System.Windows.Forms.Label history_lbl;
        private System.Windows.Forms.PictureBox order_history_picture_box;
        private System.Windows.Forms.Panel pos_image_panel_pnl;
        private System.Windows.Forms.PictureBox pos_icon_picture_box;
        private System.Windows.Forms.Panel stack_pane_pnl;
        private System.Windows.Forms.Panel page_add_remove_items_pnl;
        private System.Windows.Forms.Panel page_home_main_pnl;
        private System.Windows.Forms.Panel home_secondary_pnl;
        private System.Windows.Forms.TableLayoutPanel home_main_tbl_layout_pnl;
        private System.Windows.Forms.TableLayoutPanel order_side_tbl_layout_pnl;
        private System.Windows.Forms.TableLayoutPanel order_info_tbl_layout_pnl;
        private System.Windows.Forms.Label order_lbl;
        private System.Windows.Forms.Label order_id_lbl;
        private System.Windows.Forms.Panel price_details_pnl;
        private System.Windows.Forms.Panel price_details_sub_panel;
        private System.Windows.Forms.TableLayoutPanel price_details_tbl_layout_pnl;
        private System.Windows.Forms.Panel place_order_pnl;
        private System.Windows.Forms.Button place_order_btn;
        private System.Windows.Forms.Panel price_details_main_pnl;
        private System.Windows.Forms.Label total_amount_value_lbl;
        private System.Windows.Forms.Label total_amount_lbl;
        private System.Windows.Forms.Label divider_lbl;
        private System.Windows.Forms.Label tax_value_lbl;
        private System.Windows.Forms.Label sub_total_value_lbl;
        private System.Windows.Forms.Label total_quantity_value_lbl;
        private System.Windows.Forms.Label tax_lbl;
        private System.Windows.Forms.Label sub_total_lbl;
        private System.Windows.Forms.Label total_quantity_lbl;
        private System.Windows.Forms.Panel order_items_pnl;
        private System.Windows.Forms.FlowLayoutPanel order_items_flow_layout_pnl;
        private System.Windows.Forms.Panel home_menu_panel_pnl;
        private System.Windows.Forms.TableLayoutPanel home_menu_tbl_layout_pnl;
        private System.Windows.Forms.TableLayoutPanel home_top_bar_panel_pnl;
        private System.Windows.Forms.TableLayoutPanel shop_info_tbl_layout_pnl;
        private System.Windows.Forms.Label shop_name_lbl;
        private System.Windows.Forms.Label date_time_lbl;
        private System.Windows.Forms.Panel search_bar_main_pnl;
        private System.Windows.Forms.Panel search_bar_pnl;
        private System.Windows.Forms.TableLayoutPanel search_bar_tbl_layout_pnl;
        private System.Windows.Forms.PictureBox search_bar_picture_box;
        private System.Windows.Forms.Panel search_bar_txt_field_pnl;
        private System.Windows.Forms.TextBox search_bar_txt_field;
        private System.Windows.Forms.Panel order_menu_area_pnl;
        private System.Windows.Forms.FlowLayoutPanel order_menu_area_flow_layout_pnl;
        private System.Windows.Forms.TableLayoutPanel add_remove_items_tbl_layout_pnl;
        private System.Windows.Forms.Panel menu_table_pnl;
        private System.Windows.Forms.DataGridView menu_table_tbl;
        private System.Windows.Forms.Panel page_order_history_panel_main_pnl;
        private System.Windows.Forms.TableLayoutPanel order_history_panel_main_tbl_layout_pnl;
        private System.Windows.Forms.Panel order_history_panel_table_pnl;
        private System.Windows.Forms.DataGridView order_history_table_tbl;
        private System.Windows.Forms.FlowLayoutPanel history_panel_top_flow_layout_pnl;
        private System.Windows.Forms.ComboBox history_panel_filter_combo_box;
        private System.Windows.Forms.Panel page_stock_panel_main_pnl;
        private System.Windows.Forms.TableLayoutPanel stock_panel_main_tbl_layout_pnl;
        private System.Windows.Forms.Panel stock_panel_tabel_pnl;
        private System.Windows.Forms.DataGridView stock_panel_tabel_tbl;
        private System.Windows.Forms.FlowLayoutPanel stock_panel_bottom_flow_layout_pnl;
        private System.Windows.Forms.Button stock_panel_add_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label history_panel_filter_lbl;
        System.Drawing.Color pink_color = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
        System.Drawing.Color black_color = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn stock_name;
        private DataGridViewTextBoxColumn stock_in;
        private DataGridViewTextBoxColumn stock_out;
        private DataGridViewTextBoxColumn stock_remaining;
        private DataGridViewTextBoxColumn single_stock_price;
        private DataGridViewTextBoxColumn stock_total;
        private FlowLayoutPanel add_remove_items_flow_layout_pnl;
        private Button add_remove_items_save_changes_btn;
        private Button delete_selected;
        private Button add_remove_items_add_btn;
        private DataGridViewCheckBoxColumn check_box;
        private DataGridViewImageColumn item_image;
        private DataGridViewTextBoxColumn item_name;
        private DataGridViewTextBoxColumn item_price;
        private DataGridViewTextBoxColumn item_ingredients;
        private DataGridViewButtonColumn item_delete;
        private DataGridViewTextBoxColumn order_no;
        private DataGridViewTextBoxColumn order_date_time;
        private DataGridViewTextBoxColumn order_time;
        private DataGridViewTextBoxColumn item_quantity;
        private DataGridViewTextBoxColumn order_tax;
        private DataGridViewTextBoxColumn total_price;
    }
}

