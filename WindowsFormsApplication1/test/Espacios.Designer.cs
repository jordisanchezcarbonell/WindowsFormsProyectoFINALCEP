﻿namespace COMPLETE_FLAT_UI
{
    partial class Espacios
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
            this.comboBoxInstalacion = new System.Windows.Forms.ComboBox();
            this.bindingSourceInstalaciones = new System.Windows.Forms.BindingSource(this.components);
            this.materialSingleLineTextFieldPrecio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bindingSourceEspacios = new System.Windows.Forms.BindingSource(this.components);
            this.materialLabelExterior = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelPreu = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridViewEspacios = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exteriorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idinstalacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.materialLabelInstalacion = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButtonBorrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButtonModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButtonAgregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.checkBoxExterior = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstalaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEspacios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEspacios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxInstalacion
            // 
            this.comboBoxInstalacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxInstalacion.DataSource = this.bindingSourceInstalaciones;
            this.comboBoxInstalacion.DisplayMember = "nombre";
            this.comboBoxInstalacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInstalacion.FormattingEnabled = true;
            this.comboBoxInstalacion.Location = new System.Drawing.Point(169, 84);
            this.comboBoxInstalacion.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxInstalacion.Name = "comboBoxInstalacion";
            this.comboBoxInstalacion.Size = new System.Drawing.Size(202, 21);
            this.comboBoxInstalacion.TabIndex = 30;
            this.comboBoxInstalacion.ValueMember = "id";
            this.comboBoxInstalacion.SelectedIndexChanged += new System.EventHandler(this.comboBoxInstalacion_SelectedIndexChanged);
            // 
            // bindingSourceInstalaciones
            // 
            this.bindingSourceInstalaciones.DataSource = typeof(COMPLETE_FLAT_UI.Instalacion);
            // 
            // materialSingleLineTextFieldPrecio
            // 
            this.materialSingleLineTextFieldPrecio.Depth = 0;
            this.materialSingleLineTextFieldPrecio.Hint = "";
            this.materialSingleLineTextFieldPrecio.Location = new System.Drawing.Point(169, 175);
            this.materialSingleLineTextFieldPrecio.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldPrecio.Name = "materialSingleLineTextFieldPrecio";
            this.materialSingleLineTextFieldPrecio.PasswordChar = '\0';
            this.materialSingleLineTextFieldPrecio.SelectedText = "";
            this.materialSingleLineTextFieldPrecio.SelectionLength = 0;
            this.materialSingleLineTextFieldPrecio.SelectionStart = 0;
            this.materialSingleLineTextFieldPrecio.Size = new System.Drawing.Size(98, 23);
            this.materialSingleLineTextFieldPrecio.TabIndex = 31;
            this.materialSingleLineTextFieldPrecio.TabStop = false;
            this.materialSingleLineTextFieldPrecio.UseSystemPasswordChar = false;
            this.materialSingleLineTextFieldPrecio.Click += new System.EventHandler(this.materialSingleLineTextFieldPrecio_Click);
            // 
            // materialSingleLineTextFieldNombre
            // 
            this.materialSingleLineTextFieldNombre.Depth = 0;
            this.materialSingleLineTextFieldNombre.Hint = "";
            this.materialSingleLineTextFieldNombre.Location = new System.Drawing.Point(169, 128);
            this.materialSingleLineTextFieldNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldNombre.Name = "materialSingleLineTextFieldNombre";
            this.materialSingleLineTextFieldNombre.PasswordChar = '\0';
            this.materialSingleLineTextFieldNombre.SelectedText = "";
            this.materialSingleLineTextFieldNombre.SelectionLength = 0;
            this.materialSingleLineTextFieldNombre.SelectionStart = 0;
            this.materialSingleLineTextFieldNombre.Size = new System.Drawing.Size(202, 23);
            this.materialSingleLineTextFieldNombre.TabIndex = 32;
            this.materialSingleLineTextFieldNombre.TabStop = false;
            this.materialSingleLineTextFieldNombre.UseSystemPasswordChar = false;
            // 
            // bindingSourceEspacios
            // 
            this.bindingSourceEspacios.DataSource = typeof(COMPLETE_FLAT_UI.Espacio);
            // 
            // materialLabelExterior
            // 
            this.materialLabelExterior.AutoSize = true;
            this.materialLabelExterior.Depth = 0;
            this.materialLabelExterior.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelExterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabelExterior.Location = new System.Drawing.Point(70, 232);
            this.materialLabelExterior.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelExterior.Name = "materialLabelExterior";
            this.materialLabelExterior.Size = new System.Drawing.Size(68, 19);
            this.materialLabelExterior.TabIndex = 34;
            this.materialLabelExterior.Text = "Exterior?";
            // 
            // materialLabelPreu
            // 
            this.materialLabelPreu.AutoSize = true;
            this.materialLabelPreu.Depth = 0;
            this.materialLabelPreu.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelPreu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabelPreu.Location = new System.Drawing.Point(70, 179);
            this.materialLabelPreu.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelPreu.Name = "materialLabelPreu";
            this.materialLabelPreu.Size = new System.Drawing.Size(39, 19);
            this.materialLabelPreu.TabIndex = 35;
            this.materialLabelPreu.Text = "Preu";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel2.Location = new System.Drawing.Point(70, 132);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(42, 19);
            this.materialLabel2.TabIndex = 36;
            this.materialLabel2.Text = "Nom";
            // 
            // dataGridViewEspacios
            // 
            this.dataGridViewEspacios.AllowUserToAddRows = false;
            this.dataGridViewEspacios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEspacios.AutoGenerateColumns = false;
            this.dataGridViewEspacios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewEspacios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEspacios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.exteriorDataGridViewCheckBoxColumn,
            this.idinstalacionDataGridViewTextBoxColumn});
            this.dataGridViewEspacios.DataSource = this.bindingSourceEspacios;
            this.dataGridViewEspacios.Location = new System.Drawing.Point(74, 270);
            this.dataGridViewEspacios.Name = "dataGridViewEspacios";
            this.dataGridViewEspacios.Size = new System.Drawing.Size(632, 275);
            this.dataGridViewEspacios.TabIndex = 37;
            this.dataGridViewEspacios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEspacios_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // exteriorDataGridViewCheckBoxColumn
            // 
            this.exteriorDataGridViewCheckBoxColumn.DataPropertyName = "exterior";
            this.exteriorDataGridViewCheckBoxColumn.HeaderText = "exterior";
            this.exteriorDataGridViewCheckBoxColumn.Name = "exteriorDataGridViewCheckBoxColumn";
            // 
            // idinstalacionDataGridViewTextBoxColumn
            // 
            this.idinstalacionDataGridViewTextBoxColumn.DataPropertyName = "id_instalacion";
            this.idinstalacionDataGridViewTextBoxColumn.DataSource = this.bindingSourceInstalaciones;
            this.idinstalacionDataGridViewTextBoxColumn.DisplayMember = "nombre";
            this.idinstalacionDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idinstalacionDataGridViewTextBoxColumn.HeaderText = "Instalacion";
            this.idinstalacionDataGridViewTextBoxColumn.Name = "idinstalacionDataGridViewTextBoxColumn";
            this.idinstalacionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idinstalacionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idinstalacionDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(COMPLETE_FLAT_UI.Espacio);
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // materialLabelInstalacion
            // 
            this.materialLabelInstalacion.AutoSize = true;
            this.materialLabelInstalacion.Depth = 0;
            this.materialLabelInstalacion.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelInstalacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabelInstalacion.Location = new System.Drawing.Point(70, 86);
            this.materialLabelInstalacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelInstalacion.Name = "materialLabelInstalacion";
            this.materialLabelInstalacion.Size = new System.Drawing.Size(83, 19);
            this.materialLabelInstalacion.TabIndex = 38;
            this.materialLabelInstalacion.Text = "Instal·lació";
            // 
            // materialRaisedButtonBorrar
            // 
            this.materialRaisedButtonBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButtonBorrar.AutoSize = true;
            this.materialRaisedButtonBorrar.Depth = 0;
            this.materialRaisedButtonBorrar.Location = new System.Drawing.Point(621, 204);
            this.materialRaisedButtonBorrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonBorrar.Name = "materialRaisedButtonBorrar";
            this.materialRaisedButtonBorrar.Primary = true;
            this.materialRaisedButtonBorrar.Size = new System.Drawing.Size(83, 36);
            this.materialRaisedButtonBorrar.TabIndex = 41;
            this.materialRaisedButtonBorrar.Text = "Esborrar";
            this.materialRaisedButtonBorrar.UseVisualStyleBackColor = true;
            this.materialRaisedButtonBorrar.Click += new System.EventHandler(this.materialRaisedButtonBorrar_Click);
            // 
            // materialRaisedButtonModificar
            // 
            this.materialRaisedButtonModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButtonModificar.AutoSize = true;
            this.materialRaisedButtonModificar.Depth = 0;
            this.materialRaisedButtonModificar.Location = new System.Drawing.Point(623, 152);
            this.materialRaisedButtonModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonModificar.Name = "materialRaisedButtonModificar";
            this.materialRaisedButtonModificar.Primary = true;
            this.materialRaisedButtonModificar.Size = new System.Drawing.Size(83, 36);
            this.materialRaisedButtonModificar.TabIndex = 40;
            this.materialRaisedButtonModificar.Text = "Modificar";
            this.materialRaisedButtonModificar.UseVisualStyleBackColor = true;
            this.materialRaisedButtonModificar.Click += new System.EventHandler(this.materialRaisedButtonModificar_Click);
            // 
            // materialRaisedButtonAgregar
            // 
            this.materialRaisedButtonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButtonAgregar.AutoSize = true;
            this.materialRaisedButtonAgregar.Depth = 0;
            this.materialRaisedButtonAgregar.Location = new System.Drawing.Point(623, 96);
            this.materialRaisedButtonAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonAgregar.Name = "materialRaisedButtonAgregar";
            this.materialRaisedButtonAgregar.Primary = true;
            this.materialRaisedButtonAgregar.Size = new System.Drawing.Size(83, 36);
            this.materialRaisedButtonAgregar.TabIndex = 39;
            this.materialRaisedButtonAgregar.Text = "Agregar";
            this.materialRaisedButtonAgregar.UseVisualStyleBackColor = true;
            this.materialRaisedButtonAgregar.Click += new System.EventHandler(this.materialRaisedButtonAgregar_Click);
            // 
            // checkBoxExterior
            // 
            this.checkBoxExterior.AutoSize = true;
            this.checkBoxExterior.Location = new System.Drawing.Point(169, 237);
            this.checkBoxExterior.Name = "checkBoxExterior";
            this.checkBoxExterior.Size = new System.Drawing.Size(15, 14);
            this.checkBoxExterior.TabIndex = 42;
            this.checkBoxExterior.UseVisualStyleBackColor = true;
            // 
            // Espacios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 557);
            this.Controls.Add(this.checkBoxExterior);
            this.Controls.Add(this.materialRaisedButtonBorrar);
            this.Controls.Add(this.materialRaisedButtonModificar);
            this.Controls.Add(this.materialRaisedButtonAgregar);
            this.Controls.Add(this.materialLabelInstalacion);
            this.Controls.Add(this.dataGridViewEspacios);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabelPreu);
            this.Controls.Add(this.materialLabelExterior);
            this.Controls.Add(this.materialSingleLineTextFieldNombre);
            this.Controls.Add(this.materialSingleLineTextFieldPrecio);
            this.Controls.Add(this.comboBoxInstalacion);
            this.Name = "Espacios";
            this.Text = "Espacios";
            this.Activated += new System.EventHandler(this.Espacios_Activated);
            this.Load += new System.EventHandler(this.Espacios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInstalaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEspacios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEspacios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxInstalacion;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldPrecio;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldNombre;
        private MaterialSkin.Controls.MaterialLabel materialLabelExterior;
        private MaterialSkin.Controls.MaterialLabel materialLabelPreu;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridView dataGridViewEspacios;
        private MaterialSkin.Controls.MaterialLabel materialLabelInstalacion;
        private System.Windows.Forms.BindingSource bindingSourceInstalaciones;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSourceEspacios;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonBorrar;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonModificar;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonAgregar;
        private System.Windows.Forms.CheckBox checkBoxExterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn exteriorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idinstalacionDataGridViewTextBoxColumn;
    }
}