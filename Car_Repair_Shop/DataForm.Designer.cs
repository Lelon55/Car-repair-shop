namespace Car_Repair_Shop
{
    partial class DataForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableTop = new System.Windows.Forms.TableLayoutPanel();
            this.label_SearchText = new System.Windows.Forms.Label();
            this.tableDataGridView = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year_production = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repaired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parts_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labor_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acceptance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devotion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.generate_pdf = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete_record = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableOptions = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTop.SuspendLayout();
            this.tableDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableTop
            // 
            this.tableTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableTop.AutoSize = true;
            this.tableTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableTop.ColumnCount = 1;
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableTop.Controls.Add(this.label_SearchText, 0, 0);
            this.tableTop.Location = new System.Drawing.Point(12, 12);
            this.tableTop.Name = "tableTop";
            this.tableTop.RowCount = 1;
            this.tableTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableTop.Size = new System.Drawing.Size(556, 40);
            this.tableTop.TabIndex = 4;
            // 
            // label_SearchText
            // 
            this.label_SearchText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_SearchText.AutoSize = true;
            this.label_SearchText.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_SearchText.Location = new System.Drawing.Point(3, 0);
            this.label_SearchText.Name = "label_SearchText";
            this.label_SearchText.Size = new System.Drawing.Size(550, 40);
            this.label_SearchText.TabIndex = 0;
            this.label_SearchText.Text = "VIN: xyz 000 123 456 789";
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableDataGridView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableDataGridView.ColumnCount = 1;
            this.tableDataGridView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDataGridView.Controls.Add(this.dataGridView1, 0, 0);
            this.tableDataGridView.Location = new System.Drawing.Point(12, 58);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.RowCount = 1;
            this.tableDataGridView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDataGridView.Size = new System.Drawing.Size(986, 498);
            this.tableDataGridView.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.vin,
            this.plate,
            this.brand,
            this.model,
            this.year_production,
            this.todo,
            this.repaired,
            this.parts_cost,
            this.labor_cost,
            this.mileage,
            this.acceptance,
            this.devotion,
            this.comment,
            this.update,
            this.generate_pdf,
            this.delete_record});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridView1.RowHeadersWidth = 40;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(980, 492);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.ChooseColumns);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OptionsData_ButtonClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.TextToUpper);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.WriteChar);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataGridViewKeyPress);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 43;
            // 
            // vin
            // 
            this.vin.HeaderText = "VIN";
            this.vin.MaxInputLength = 17;
            this.vin.Name = "vin";
            this.vin.Width = 50;
            // 
            // plate
            // 
            this.plate.HeaderText = "Plate";
            this.plate.MaxInputLength = 9;
            this.plate.Name = "plate";
            this.plate.Width = 56;
            // 
            // brand
            // 
            this.brand.HeaderText = "Brand";
            this.brand.MaxInputLength = 32;
            this.brand.Name = "brand";
            this.brand.Width = 60;
            // 
            // model
            // 
            this.model.HeaderText = "Model";
            this.model.MaxInputLength = 32;
            this.model.Name = "model";
            this.model.Width = 61;
            // 
            // year_production
            // 
            this.year_production.FillWeight = 60F;
            this.year_production.HeaderText = "Year production";
            this.year_production.MaxInputLength = 4;
            this.year_production.Name = "year_production";
            this.year_production.Width = 98;
            // 
            // todo
            // 
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.todo.DefaultCellStyle = dataGridViewCellStyle25;
            this.todo.HeaderText = "To do";
            this.todo.MaxInputLength = 5000;
            this.todo.Name = "todo";
            this.todo.Width = 45;
            // 
            // repaired
            // 
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.repaired.DefaultCellStyle = dataGridViewCellStyle26;
            this.repaired.HeaderText = "Repaired";
            this.repaired.MaxInputLength = 5000;
            this.repaired.Name = "repaired";
            this.repaired.Width = 75;
            // 
            // parts_cost
            // 
            this.parts_cost.FillWeight = 75F;
            this.parts_cost.HeaderText = "Parts Cost";
            this.parts_cost.MaxInputLength = 8;
            this.parts_cost.Name = "parts_cost";
            this.parts_cost.Width = 74;
            // 
            // labor_cost
            // 
            this.labor_cost.FillWeight = 75F;
            this.labor_cost.HeaderText = "Labor Cost";
            this.labor_cost.MaxInputLength = 8;
            this.labor_cost.Name = "labor_cost";
            this.labor_cost.Width = 77;
            // 
            // mileage
            // 
            this.mileage.FillWeight = 75F;
            this.mileage.HeaderText = "Mileage";
            this.mileage.MaxInputLength = 8;
            this.mileage.Name = "mileage";
            this.mileage.Width = 69;
            // 
            // acceptance
            // 
            this.acceptance.HeaderText = "Acceptance Car";
            this.acceptance.Name = "acceptance";
            // 
            // devotion
            // 
            this.devotion.HeaderText = "Devotion Car";
            this.devotion.Name = "devotion";
            this.devotion.Width = 87;
            // 
            // comment
            // 
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.comment.DefaultCellStyle = dataGridViewCellStyle27;
            this.comment.HeaderText = "Comment";
            this.comment.MaxInputLength = 5000;
            this.comment.Name = "comment";
            this.comment.Width = 76;
            // 
            // update
            // 
            this.update.HeaderText = "Update data";
            this.update.Name = "update";
            this.update.ReadOnly = true;
            this.update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.update.Text = "Update";
            this.update.ToolTipText = "Update this data";
            this.update.UseColumnTextForButtonValue = true;
            this.update.Width = 84;
            // 
            // generate_pdf
            // 
            this.generate_pdf.HeaderText = "Generate PDF";
            this.generate_pdf.Name = "generate_pdf";
            this.generate_pdf.ReadOnly = true;
            this.generate_pdf.Text = "Generate";
            this.generate_pdf.ToolTipText = "Generate PDF files for record";
            this.generate_pdf.UseColumnTextForButtonValue = true;
            this.generate_pdf.Width = 73;
            // 
            // delete_record
            // 
            this.delete_record.HeaderText = "Delete data";
            this.delete_record.Name = "delete_record";
            this.delete_record.ReadOnly = true;
            this.delete_record.Text = "Delete";
            this.delete_record.ToolTipText = "Delete record";
            this.delete_record.UseColumnTextForButtonValue = true;
            this.delete_record.Width = 61;
            // 
            // tableOptions
            // 
            this.tableOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableOptions.AutoSize = true;
            this.tableOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableOptions.ColumnCount = 1;
            this.tableOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOptions.Controls.Add(this.btnBack, 0, 0);
            this.tableOptions.Location = new System.Drawing.Point(12, 574);
            this.tableOptions.Name = "tableOptions";
            this.tableOptions.RowCount = 1;
            this.tableOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOptions.Size = new System.Drawing.Size(144, 48);
            this.tableOptions.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(138, 42);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1016, 673);
            this.Controls.Add(this.tableOptions);
            this.Controls.Add(this.tableDataGridView);
            this.Controls.Add(this.tableTop);
            this.Name = "DataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataForm_FormClosing);
            this.Load += new System.EventHandler(this.DataForm_Load);
            this.tableTop.ResumeLayout(false);
            this.tableTop.PerformLayout();
            this.tableDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableTop;
        private System.Windows.Forms.Label label_SearchText;
        private System.Windows.Forms.TableLayoutPanel tableDataGridView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableOptions;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn vin;
        private System.Windows.Forms.DataGridViewTextBoxColumn plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn year_production;
        private System.Windows.Forms.DataGridViewTextBoxColumn todo;
        private System.Windows.Forms.DataGridViewTextBoxColumn repaired;
        private System.Windows.Forms.DataGridViewTextBoxColumn parts_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn labor_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn mileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn acceptance;
        private System.Windows.Forms.DataGridViewTextBoxColumn devotion;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
        private System.Windows.Forms.DataGridViewButtonColumn update;
        private System.Windows.Forms.DataGridViewButtonColumn generate_pdf;
        private System.Windows.Forms.DataGridViewButtonColumn delete_record;
        private System.Windows.Forms.BindingSource dataFormBindingSource;
    }
}