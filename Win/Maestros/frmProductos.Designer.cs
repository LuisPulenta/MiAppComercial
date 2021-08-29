
namespace Win.Maestros
{
    partial class frmProductos
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
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label iDCategoriaLabel;
            System.Windows.Forms.Label iDIVALabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label notasLabel;
            System.Windows.Forms.Label imagenLabel;
            System.Windows.Forms.Label iDUnidadLabel;
            System.Windows.Forms.Label medidaLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dSMiAppComercial = new Win.DSMiAppComercial();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new Win.DSMiAppComercialTableAdapters.ProductoTableAdapter();
            this.tableAdapterManager = new Win.DSMiAppComercialTableAdapters.TableAdapterManager();
            this.categoriaTableAdapter = new Win.DSMiAppComercialTableAdapters.CategoriaTableAdapter();
            this.iVATableAdapter = new Win.DSMiAppComercialTableAdapters.IVATableAdapter();
            this.unidadTableAdapter = new Win.DSMiAppComercialTableAdapters.UnidadTableAdapter();
            this.productoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorEditItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCancelItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSearchItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPrint = new System.Windows.Forms.ToolStripButton();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.iDCategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.iDIVAComboBox = new System.Windows.Forms.ComboBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.notasTextBox = new System.Windows.Forms.TextBox();
            this.imagenTextBox = new System.Windows.Forms.TextBox();
            this.iDUnidadComboBox = new System.Windows.Forms.ComboBox();
            this.unidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medidaTextBox = new System.Windows.Forms.TextBox();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxBodegas = new System.Windows.Forms.GroupBox();
            this.btnAgregarBodega = new System.Windows.Forms.Button();
            this.almacenesDataGridView = new System.Windows.Forms.DataGridView();
            this.iDAlmacenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.almacenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasReposicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadMinima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.almacenProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbxBarras = new System.Windows.Forms.GroupBox();
            this.btnEliminarBarra = new System.Windows.Forms.Button();
            this.btnAgregarBarra = new System.Windows.Forms.Button();
            this.barrasDataGridView = new System.Windows.Forms.DataGridView();
            this.barraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barraTableAdapter = new Win.DSMiAppComercialTableAdapters.BarraTableAdapter();
            this.almacenProductoTableAdapter = new Win.DSMiAppComercialTableAdapters.AlmacenProductoTableAdapter();
            this.btnBuscarImagen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.almacenTableAdapter = new Win.DSMiAppComercialTableAdapters.AlmacenTableAdapter();
            codigoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            iDCategoriaLabel = new System.Windows.Forms.Label();
            iDIVALabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            notasLabel = new System.Windows.Forms.Label();
            imagenLabel = new System.Windows.Forms.Label();
            iDUnidadLabel = new System.Windows.Forms.Label();
            medidaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingNavigator)).BeginInit();
            this.productoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxBodegas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.almacenesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenProductoBindingSource)).BeginInit();
            this.gbxBarras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barrasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(36, 37);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(56, 17);
            codigoLabel.TabIndex = 0;
            codigoLabel.Text = "Código:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(6, 88);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(86, 17);
            descripcionLabel.TabIndex = 4;
            descripcionLabel.Text = "Descripción:";
            // 
            // iDCategoriaLabel
            // 
            iDCategoriaLabel.AutoSize = true;
            iDCategoriaLabel.Location = new System.Drawing.Point(19, 62);
            iDCategoriaLabel.Name = "iDCategoriaLabel";
            iDCategoriaLabel.Size = new System.Drawing.Size(73, 17);
            iDCategoriaLabel.TabIndex = 2;
            iDCategoriaLabel.Text = "Categoría:";
            // 
            // iDIVALabel
            // 
            iDIVALabel.AutoSize = true;
            iDIVALabel.Location = new System.Drawing.Point(59, 139);
            iDIVALabel.Name = "iDIVALabel";
            iDIVALabel.Size = new System.Drawing.Size(33, 17);
            iDIVALabel.TabIndex = 10;
            iDIVALabel.Text = "IVA:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(40, 164);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(52, 17);
            precioLabel.TabIndex = 12;
            precioLabel.Text = "Precio:";
            // 
            // notasLabel
            // 
            notasLabel.AutoSize = true;
            notasLabel.Location = new System.Drawing.Point(546, 43);
            notasLabel.Name = "notasLabel";
            notasLabel.Size = new System.Drawing.Size(49, 17);
            notasLabel.TabIndex = 14;
            notasLabel.Text = "Notas:";
            // 
            // imagenLabel
            // 
            imagenLabel.AutoSize = true;
            imagenLabel.Location = new System.Drawing.Point(537, 156);
            imagenLabel.Name = "imagenLabel";
            imagenLabel.Size = new System.Drawing.Size(58, 17);
            imagenLabel.TabIndex = 16;
            imagenLabel.Text = "Imagen:";
            // 
            // iDUnidadLabel
            // 
            iDUnidadLabel.AutoSize = true;
            iDUnidadLabel.Location = new System.Drawing.Point(35, 116);
            iDUnidadLabel.Name = "iDUnidadLabel";
            iDUnidadLabel.Size = new System.Drawing.Size(57, 17);
            iDUnidadLabel.TabIndex = 6;
            iDUnidadLabel.Text = "Unidad:";
            // 
            // medidaLabel
            // 
            medidaLabel.AutoSize = true;
            medidaLabel.Location = new System.Drawing.Point(299, 112);
            medidaLabel.Name = "medidaLabel";
            medidaLabel.Size = new System.Drawing.Size(58, 17);
            medidaLabel.TabIndex = 8;
            medidaLabel.Text = "Medida:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // dSMiAppComercial
            // 
            this.dSMiAppComercial.DataSetName = "DSMiAppComercial";
            this.dSMiAppComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlmacenProductoTableAdapter = null;
            this.tableAdapterManager.AlmacenTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BarraTableAdapter = null;
            this.tableAdapterManager.CategoriaTableAdapter = this.categoriaTableAdapter;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.ConceptoTableAdapter = null;
            this.tableAdapterManager.IVATableAdapter = this.iVATableAdapter;
            this.tableAdapterManager.ProductoTableAdapter = this.productoTableAdapter;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.TipoDocumentoTableAdapter = null;
            this.tableAdapterManager.UnidadTableAdapter = this.unidadTableAdapter;
            this.tableAdapterManager.UpdateOrder = Win.DSMiAppComercialTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // iVATableAdapter
            // 
            this.iVATableAdapter.ClearBeforeFill = true;
            // 
            // unidadTableAdapter
            // 
            this.unidadTableAdapter.ClearBeforeFill = true;
            // 
            // productoBindingNavigator
            // 
            this.productoBindingNavigator.AddNewItem = null;
            this.productoBindingNavigator.BindingSource = this.productoBindingSource;
            this.productoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productoBindingNavigator.DeleteItem = null;
            this.productoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.productoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorEditItem,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSaveItem,
            this.bindingNavigatorCancelItem,
            this.bindingNavigatorSearchItem,
            this.bindingNavigatorPrint});
            this.productoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productoBindingNavigator.Name = "productoBindingNavigator";
            this.productoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productoBindingNavigator.Size = new System.Drawing.Size(1318, 27);
            this.productoBindingNavigator.TabIndex = 0;
            this.productoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorEditItem
            // 
            this.bindingNavigatorEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorEditItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorEditItem.Image")));
            this.bindingNavigatorEditItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorEditItem.Name = "bindingNavigatorEditItem";
            this.bindingNavigatorEditItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorEditItem.Text = "toolStripButton1";
            this.bindingNavigatorEditItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bindingNavigatorEditItem.ToolTipText = "Edita el Registro actual";
            this.bindingNavigatorEditItem.Click += new System.EventHandler(this.bindingNavigatorEditItem_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.ToolTipText = "Agregar nuevo Registro";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.ToolTipText = "Eliminar el Registro actual";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveItem.Enabled = false;
            this.bindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveItem.Image")));
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorSaveItem.Text = "Guardar datos";
            this.bindingNavigatorSaveItem.ToolTipText = "Guardar cambios";
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorCancelItem
            // 
            this.bindingNavigatorCancelItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorCancelItem.Enabled = false;
            this.bindingNavigatorCancelItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorCancelItem.Image")));
            this.bindingNavigatorCancelItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorCancelItem.Name = "bindingNavigatorCancelItem";
            this.bindingNavigatorCancelItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorCancelItem.Text = "toolStripButton2";
            this.bindingNavigatorCancelItem.ToolTipText = "Cancelar cambios en  el Registro actual";
            this.bindingNavigatorCancelItem.Click += new System.EventHandler(this.bindingNavigatorCancelItem_Click);
            // 
            // bindingNavigatorSearchItem
            // 
            this.bindingNavigatorSearchItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSearchItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSearchItem.Image")));
            this.bindingNavigatorSearchItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSearchItem.Name = "bindingNavigatorSearchItem";
            this.bindingNavigatorSearchItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorSearchItem.Text = "toolStripButton3";
            this.bindingNavigatorSearchItem.ToolTipText = "Buscar un Registro";
            this.bindingNavigatorSearchItem.Click += new System.EventHandler(this.bindingNavigatorSearchItem_Click);
            // 
            // bindingNavigatorPrint
            // 
            this.bindingNavigatorPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorPrint.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorPrint.Image")));
            this.bindingNavigatorPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorPrint.Name = "bindingNavigatorPrint";
            this.bindingNavigatorPrint.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorPrint.Text = "toolStripButton1";
            this.bindingNavigatorPrint.ToolTipText = "Listado de Productos";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 7.8F);
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDatos.AutoGenerateColumns = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvDatos.DataSource = this.productoBindingSource;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvDatos.Location = new System.Drawing.Point(0, 415);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(1318, 252);
            this.dgvDatos.TabIndex = 21;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDCategoria";
            this.dataGridViewTextBoxColumn3.DataSource = this.categoriaBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Categoría";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "IDCategoria";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IDIVA";
            this.dataGridViewTextBoxColumn4.DataSource = this.iVABindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn4.HeaderText = "IVA";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "IDIVA";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // iVABindingSource
            // 
            this.iVABindingSource.DataMember = "IVA";
            this.iVABindingSource.DataSource = this.dSMiAppComercial;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Precio";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IDUnidad";
            this.dataGridViewTextBoxColumn8.HeaderText = "Unidad";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Medida";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn9.HeaderText = "Medida";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(98, 34);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.ReadOnly = true;
            this.codigoTextBox.Size = new System.Drawing.Size(100, 22);
            this.codigoTextBox.TabIndex = 1;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(98, 85);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.ReadOnly = true;
            this.descripcionTextBox.Size = new System.Drawing.Size(450, 22);
            this.descripcionTextBox.TabIndex = 5;
            // 
            // iDCategoriaComboBox
            // 
            this.iDCategoriaComboBox.BackColor = System.Drawing.Color.Aquamarine;
            this.iDCategoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoBindingSource, "IDCategoria", true));
            this.iDCategoriaComboBox.DataSource = this.categoriaBindingSource;
            this.iDCategoriaComboBox.DisplayMember = "Descripcion";
            this.iDCategoriaComboBox.Enabled = false;
            this.iDCategoriaComboBox.FormattingEnabled = true;
            this.iDCategoriaComboBox.Location = new System.Drawing.Point(98, 59);
            this.iDCategoriaComboBox.Name = "iDCategoriaComboBox";
            this.iDCategoriaComboBox.Size = new System.Drawing.Size(296, 24);
            this.iDCategoriaComboBox.TabIndex = 3;
            this.iDCategoriaComboBox.ValueMember = "IDCategoria";
            // 
            // iDIVAComboBox
            // 
            this.iDIVAComboBox.BackColor = System.Drawing.Color.Aquamarine;
            this.iDIVAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoBindingSource, "IDIVA", true));
            this.iDIVAComboBox.DataSource = this.iVABindingSource;
            this.iDIVAComboBox.DisplayMember = "Descripcion";
            this.iDIVAComboBox.Enabled = false;
            this.iDIVAComboBox.FormattingEnabled = true;
            this.iDIVAComboBox.Location = new System.Drawing.Point(98, 135);
            this.iDIVAComboBox.Name = "iDIVAComboBox";
            this.iDIVAComboBox.Size = new System.Drawing.Size(127, 24);
            this.iDIVAComboBox.TabIndex = 11;
            this.iDIVAComboBox.ValueMember = "IDIVA";
            // 
            // precioTextBox
            // 
            this.precioTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(98, 161);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.ReadOnly = true;
            this.precioTextBox.Size = new System.Drawing.Size(127, 22);
            this.precioTextBox.TabIndex = 13;
            // 
            // notasTextBox
            // 
            this.notasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Notas", true));
            this.notasTextBox.Location = new System.Drawing.Point(601, 40);
            this.notasTextBox.Multiline = true;
            this.notasTextBox.Name = "notasTextBox";
            this.notasTextBox.ReadOnly = true;
            this.notasTextBox.Size = new System.Drawing.Size(515, 104);
            this.notasTextBox.TabIndex = 15;
            // 
            // imagenTextBox
            // 
            this.imagenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Imagen", true));
            this.imagenTextBox.Location = new System.Drawing.Point(601, 153);
            this.imagenTextBox.Name = "imagenTextBox";
            this.imagenTextBox.ReadOnly = true;
            this.imagenTextBox.Size = new System.Drawing.Size(361, 22);
            this.imagenTextBox.TabIndex = 17;
            // 
            // iDUnidadComboBox
            // 
            this.iDUnidadComboBox.BackColor = System.Drawing.Color.Aquamarine;
            this.iDUnidadComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoBindingSource, "IDUnidad", true));
            this.iDUnidadComboBox.DataSource = this.unidadBindingSource;
            this.iDUnidadComboBox.DisplayMember = "Descripcion";
            this.iDUnidadComboBox.Enabled = false;
            this.iDUnidadComboBox.FormattingEnabled = true;
            this.iDUnidadComboBox.Location = new System.Drawing.Point(98, 109);
            this.iDUnidadComboBox.Name = "iDUnidadComboBox";
            this.iDUnidadComboBox.Size = new System.Drawing.Size(179, 24);
            this.iDUnidadComboBox.TabIndex = 7;
            this.iDUnidadComboBox.ValueMember = "IDUnidad";
            // 
            // unidadBindingSource
            // 
            this.unidadBindingSource.DataMember = "Unidad";
            this.unidadBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // medidaTextBox
            // 
            this.medidaTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.medidaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Medida", true));
            this.medidaTextBox.Location = new System.Drawing.Point(363, 109);
            this.medidaTextBox.Name = "medidaTextBox";
            this.medidaTextBox.ReadOnly = true;
            this.medidaTextBox.Size = new System.Drawing.Size(100, 22);
            this.medidaTextBox.TabIndex = 9;
            // 
            // pbxImagen
            // 
            this.pbxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxImagen.Location = new System.Drawing.Point(1049, 156);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(253, 253);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 22;
            this.pbxImagen.TabStop = false;
            // 
            // btnExcel
            // 
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(1145, 76);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(40, 40);
            this.btnExcel.TabIndex = 24;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1206, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // gbxBodegas
            // 
            this.gbxBodegas.Controls.Add(this.btnAgregarBodega);
            this.gbxBodegas.Controls.Add(this.almacenesDataGridView);
            this.gbxBodegas.Location = new System.Drawing.Point(232, 189);
            this.gbxBodegas.Name = "gbxBodegas";
            this.gbxBodegas.Size = new System.Drawing.Size(811, 220);
            this.gbxBodegas.TabIndex = 20;
            this.gbxBodegas.TabStop = false;
            this.gbxBodegas.Text = "Parámetros de Bodega";
            // 
            // btnAgregarBodega
            // 
            this.btnAgregarBodega.Enabled = false;
            this.btnAgregarBodega.Location = new System.Drawing.Point(636, 21);
            this.btnAgregarBodega.Name = "btnAgregarBodega";
            this.btnAgregarBodega.Size = new System.Drawing.Size(155, 31);
            this.btnAgregarBodega.TabIndex = 0;
            this.btnAgregarBodega.Text = "Agregar / Modificar";
            this.btnAgregarBodega.UseVisualStyleBackColor = true;
            this.btnAgregarBodega.Click += new System.EventHandler(this.btnAgregarBodega_Click);
            // 
            // almacenesDataGridView
            // 
            this.almacenesDataGridView.AllowUserToAddRows = false;
            this.almacenesDataGridView.AllowUserToDeleteRows = false;
            this.almacenesDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 7.8F);
            this.almacenesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.almacenesDataGridView.AutoGenerateColumns = false;
            this.almacenesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.almacenesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAlmacenDataGridViewTextBoxColumn,
            this.Stock,
            this.Minimo,
            this.Maximo,
            this.DiasReposicion,
            this.CantidadMinima});
            this.almacenesDataGridView.DataSource = this.almacenProductoBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.almacenesDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.almacenesDataGridView.Location = new System.Drawing.Point(6, 57);
            this.almacenesDataGridView.Name = "almacenesDataGridView";
            this.almacenesDataGridView.ReadOnly = true;
            this.almacenesDataGridView.RowHeadersWidth = 51;
            this.almacenesDataGridView.RowTemplate.Height = 24;
            this.almacenesDataGridView.Size = new System.Drawing.Size(785, 143);
            this.almacenesDataGridView.TabIndex = 1;
            // 
            // iDAlmacenDataGridViewTextBoxColumn
            // 
            this.iDAlmacenDataGridViewTextBoxColumn.DataPropertyName = "IDAlmacen";
            this.iDAlmacenDataGridViewTextBoxColumn.DataSource = this.almacenBindingSource;
            this.iDAlmacenDataGridViewTextBoxColumn.DisplayMember = "Descripcion";
            this.iDAlmacenDataGridViewTextBoxColumn.HeaderText = "Almacén";
            this.iDAlmacenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDAlmacenDataGridViewTextBoxColumn.Name = "iDAlmacenDataGridViewTextBoxColumn";
            this.iDAlmacenDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDAlmacenDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDAlmacenDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDAlmacenDataGridViewTextBoxColumn.ValueMember = "IDAlmacen";
            this.iDAlmacenDataGridViewTextBoxColumn.Width = 125;
            // 
            // almacenBindingSource
            // 
            this.almacenBindingSource.DataMember = "Almacen";
            this.almacenBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Stock.DefaultCellStyle = dataGridViewCellStyle2;
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 125;
            // 
            // Minimo
            // 
            this.Minimo.DataPropertyName = "Minimo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Minimo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Minimo.HeaderText = "Mínimo";
            this.Minimo.MinimumWidth = 6;
            this.Minimo.Name = "Minimo";
            this.Minimo.ReadOnly = true;
            this.Minimo.Width = 125;
            // 
            // Maximo
            // 
            this.Maximo.DataPropertyName = "Maximo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Maximo.DefaultCellStyle = dataGridViewCellStyle4;
            this.Maximo.HeaderText = "Máximo";
            this.Maximo.MinimumWidth = 6;
            this.Maximo.Name = "Maximo";
            this.Maximo.ReadOnly = true;
            this.Maximo.Width = 125;
            // 
            // DiasReposicion
            // 
            this.DiasReposicion.DataPropertyName = "DiasReposicion";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.DiasReposicion.DefaultCellStyle = dataGridViewCellStyle5;
            this.DiasReposicion.HeaderText = "Días Reposición";
            this.DiasReposicion.MinimumWidth = 6;
            this.DiasReposicion.Name = "DiasReposicion";
            this.DiasReposicion.ReadOnly = true;
            this.DiasReposicion.Width = 125;
            // 
            // CantidadMinima
            // 
            this.CantidadMinima.DataPropertyName = "CantidadMinima";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.CantidadMinima.DefaultCellStyle = dataGridViewCellStyle6;
            this.CantidadMinima.HeaderText = "Cant. Mínima";
            this.CantidadMinima.MinimumWidth = 6;
            this.CantidadMinima.Name = "CantidadMinima";
            this.CantidadMinima.ReadOnly = true;
            this.CantidadMinima.Width = 125;
            // 
            // almacenProductoBindingSource
            // 
            this.almacenProductoBindingSource.DataMember = "AlmacenProducto";
            this.almacenProductoBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // gbxBarras
            // 
            this.gbxBarras.Controls.Add(this.btnEliminarBarra);
            this.gbxBarras.Controls.Add(this.btnAgregarBarra);
            this.gbxBarras.Controls.Add(this.barrasDataGridView);
            this.gbxBarras.Location = new System.Drawing.Point(22, 189);
            this.gbxBarras.Name = "gbxBarras";
            this.gbxBarras.Size = new System.Drawing.Size(216, 220);
            this.gbxBarras.TabIndex = 19;
            this.gbxBarras.TabStop = false;
            this.gbxBarras.Text = "Códigos de Barras";
            // 
            // btnEliminarBarra
            // 
            this.btnEliminarBarra.Enabled = false;
            this.btnEliminarBarra.Location = new System.Drawing.Point(96, 20);
            this.btnEliminarBarra.Name = "btnEliminarBarra";
            this.btnEliminarBarra.Size = new System.Drawing.Size(75, 31);
            this.btnEliminarBarra.TabIndex = 1;
            this.btnEliminarBarra.Text = "Eliminar";
            this.btnEliminarBarra.UseVisualStyleBackColor = true;
            this.btnEliminarBarra.Click += new System.EventHandler(this.btnEliminarBarra_Click);
            // 
            // btnAgregarBarra
            // 
            this.btnAgregarBarra.Enabled = false;
            this.btnAgregarBarra.Location = new System.Drawing.Point(6, 21);
            this.btnAgregarBarra.Name = "btnAgregarBarra";
            this.btnAgregarBarra.Size = new System.Drawing.Size(75, 31);
            this.btnAgregarBarra.TabIndex = 0;
            this.btnAgregarBarra.Text = "Agregar";
            this.btnAgregarBarra.UseVisualStyleBackColor = true;
            this.btnAgregarBarra.Click += new System.EventHandler(this.btnAgregarBarra_Click);
            // 
            // barrasDataGridView
            // 
            this.barrasDataGridView.AllowUserToAddRows = false;
            this.barrasDataGridView.AllowUserToDeleteRows = false;
            this.barrasDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Narrow", 7.8F);
            this.barrasDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.barrasDataGridView.AutoGenerateColumns = false;
            this.barrasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.barrasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barraDataGridViewTextBoxColumn});
            this.barrasDataGridView.DataSource = this.barraBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.barrasDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.barrasDataGridView.Location = new System.Drawing.Point(6, 57);
            this.barrasDataGridView.Name = "barrasDataGridView";
            this.barrasDataGridView.ReadOnly = true;
            this.barrasDataGridView.RowHeadersWidth = 51;
            this.barrasDataGridView.RowTemplate.Height = 24;
            this.barrasDataGridView.Size = new System.Drawing.Size(190, 143);
            this.barrasDataGridView.TabIndex = 2;
            // 
            // barraDataGridViewTextBoxColumn
            // 
            this.barraDataGridViewTextBoxColumn.DataPropertyName = "Barra";
            this.barraDataGridViewTextBoxColumn.HeaderText = "Barra";
            this.barraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barraDataGridViewTextBoxColumn.Name = "barraDataGridViewTextBoxColumn";
            this.barraDataGridViewTextBoxColumn.ReadOnly = true;
            this.barraDataGridViewTextBoxColumn.Width = 125;
            // 
            // barraBindingSource
            // 
            this.barraBindingSource.DataMember = "Barra";
            this.barraBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // barraTableAdapter
            // 
            this.barraTableAdapter.ClearBeforeFill = true;
            // 
            // almacenProductoTableAdapter
            // 
            this.almacenProductoTableAdapter.ClearBeforeFill = true;
            // 
            // btnBuscarImagen
            // 
            this.btnBuscarImagen.Enabled = false;
            this.btnBuscarImagen.Location = new System.Drawing.Point(968, 150);
            this.btnBuscarImagen.Name = "btnBuscarImagen";
            this.btnBuscarImagen.Size = new System.Drawing.Size(56, 28);
            this.btnBuscarImagen.TabIndex = 18;
            this.btnBuscarImagen.Text = "...";
            this.btnBuscarImagen.UseVisualStyleBackColor = true;
            this.btnBuscarImagen.Click += new System.EventHandler(this.btnBuscarImagen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // almacenTableAdapter
            // 
            this.almacenTableAdapter.ClearBeforeFill = true;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1318, 669);
            this.Controls.Add(this.btnBuscarImagen);
            this.Controls.Add(this.gbxBodegas);
            this.Controls.Add(this.gbxBarras);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(medidaLabel);
            this.Controls.Add(this.medidaTextBox);
            this.Controls.Add(iDUnidadLabel);
            this.Controls.Add(this.iDUnidadComboBox);
            this.Controls.Add(imagenLabel);
            this.Controls.Add(this.imagenTextBox);
            this.Controls.Add(notasLabel);
            this.Controls.Add(this.notasTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(iDIVALabel);
            this.Controls.Add(this.iDIVAComboBox);
            this.Controls.Add(iDCategoriaLabel);
            this.Controls.Add(this.iDCategoriaComboBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.productoBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---Productos---";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingNavigator)).EndInit();
            this.productoBindingNavigator.ResumeLayout(false);
            this.productoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxBodegas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.almacenesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenProductoBindingSource)).EndInit();
            this.gbxBarras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barrasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.BindingNavigator productoBindingNavigator;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DSMiAppComercial dSMiAppComercial;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DSMiAppComercialTableAdapters.ProductoTableAdapter productoTableAdapter;
        private DSMiAppComercialTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox medidaTextBox;
        private System.Windows.Forms.ComboBox iDUnidadComboBox;
        private System.Windows.Forms.TextBox imagenTextBox;
        private System.Windows.Forms.TextBox notasTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.ComboBox iDIVAComboBox;
        private System.Windows.Forms.ComboBox iDCategoriaComboBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.DataGridView dgvDatos;
        private DSMiAppComercialTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private DSMiAppComercialTableAdapters.IVATableAdapter iVATableAdapter;
        private System.Windows.Forms.BindingSource iVABindingSource;
        private DSMiAppComercialTableAdapters.UnidadTableAdapter unidadTableAdapter;
        private System.Windows.Forms.BindingSource unidadBindingSource;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEditItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCancelItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSearchItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorPrint;
        private System.Windows.Forms.GroupBox gbxBodegas;
        private System.Windows.Forms.Button btnAgregarBodega;
        private System.Windows.Forms.DataGridView almacenesDataGridView;
        private System.Windows.Forms.GroupBox gbxBarras;
        private System.Windows.Forms.Button btnEliminarBarra;
        private System.Windows.Forms.Button btnAgregarBarra;
        private System.Windows.Forms.DataGridView barrasDataGridView;
        private System.Windows.Forms.BindingSource barraBindingSource;
        private DSMiAppComercialTableAdapters.BarraTableAdapter barraTableAdapter;
        private System.Windows.Forms.BindingSource almacenProductoBindingSource;
        private DSMiAppComercialTableAdapters.AlmacenProductoTableAdapter almacenProductoTableAdapter;
        private System.Windows.Forms.Button btnBuscarImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn barraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource almacenBindingSource;
        private DSMiAppComercialTableAdapters.AlmacenTableAdapter almacenTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDAlmacenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasReposicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadMinima;
    }
}