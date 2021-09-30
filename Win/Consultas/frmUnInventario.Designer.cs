
namespace Win.Consultas
{
    partial class frmUnInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnInventario));
            this.totalItemsTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.categoriaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.almacenTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iDInventarioTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.totalSobranteCostoPromedioTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.totalSobranteUltimoCostoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalFaltanteUltimoCostoTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.totalFaltanteCostoPromedioTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // totalItemsTextBox
            // 
            this.totalItemsTextBox.Location = new System.Drawing.Point(167, 641);
            this.totalItemsTextBox.Name = "totalItemsTextBox";
            this.totalItemsTextBox.ReadOnly = true;
            this.totalItemsTextBox.Size = new System.Drawing.Size(66, 22);
            this.totalItemsTextBox.TabIndex = 127;
            this.totalItemsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 644);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 128;
            this.label6.Text = "Total Items:";
            // 
            // categoriaTextBox
            // 
            this.categoriaTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.categoriaTextBox.Location = new System.Drawing.Point(133, 64);
            this.categoriaTextBox.Name = "categoriaTextBox";
            this.categoriaTextBox.ReadOnly = true;
            this.categoriaTextBox.Size = new System.Drawing.Size(196, 22);
            this.categoriaTextBox.TabIndex = 122;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 121;
            this.label2.Text = "Categoría:";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatos.Location = new System.Drawing.Point(7, 118);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(1165, 519);
            this.dgvDatos.TabIndex = 120;
            // 
            // almacenTextBox
            // 
            this.almacenTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.almacenTextBox.Location = new System.Drawing.Point(133, 90);
            this.almacenTextBox.Name = "almacenTextBox";
            this.almacenTextBox.ReadOnly = true;
            this.almacenTextBox.Size = new System.Drawing.Size(196, 22);
            this.almacenTextBox.TabIndex = 119;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 118;
            this.label3.Text = "Almacén:";
            // 
            // fechaTextBox
            // 
            this.fechaTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.fechaTextBox.Location = new System.Drawing.Point(133, 36);
            this.fechaTextBox.Name = "fechaTextBox";
            this.fechaTextBox.ReadOnly = true;
            this.fechaTextBox.Size = new System.Drawing.Size(293, 22);
            this.fechaTextBox.TabIndex = 117;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 116;
            this.label1.Text = "Fecha:";
            // 
            // iDInventarioTextBox
            // 
            this.iDInventarioTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.iDInventarioTextBox.Location = new System.Drawing.Point(133, 8);
            this.iDInventarioTextBox.Name = "iDInventarioTextBox";
            this.iDInventarioTextBox.ReadOnly = true;
            this.iDInventarioTextBox.Size = new System.Drawing.Size(100, 22);
            this.iDInventarioTextBox.TabIndex = 115;
            this.iDInventarioTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.iDInventarioTextBox_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 114;
            this.label4.Text = "Inventario:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1092, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 113;
            this.pictureBox1.TabStop = false;
            // 
            // totalSobranteCostoPromedioTextBox
            // 
            this.totalSobranteCostoPromedioTextBox.Location = new System.Drawing.Point(586, 669);
            this.totalSobranteCostoPromedioTextBox.Name = "totalSobranteCostoPromedioTextBox";
            this.totalSobranteCostoPromedioTextBox.ReadOnly = true;
            this.totalSobranteCostoPromedioTextBox.Size = new System.Drawing.Size(160, 22);
            this.totalSobranteCostoPromedioTextBox.TabIndex = 135;
            this.totalSobranteCostoPromedioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(341, 672);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 17);
            this.label7.TabIndex = 136;
            this.label7.Text = "Total Sobrante Costo Promedio:";
            // 
            // totalSobranteUltimoCostoTextBox
            // 
            this.totalSobranteUltimoCostoTextBox.Location = new System.Drawing.Point(586, 643);
            this.totalSobranteUltimoCostoTextBox.Name = "totalSobranteUltimoCostoTextBox";
            this.totalSobranteUltimoCostoTextBox.ReadOnly = true;
            this.totalSobranteUltimoCostoTextBox.Size = new System.Drawing.Size(160, 22);
            this.totalSobranteUltimoCostoTextBox.TabIndex = 133;
            this.totalSobranteUltimoCostoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(364, 646);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 17);
            this.label5.TabIndex = 134;
            this.label5.Text = "Total Sobrante Último Costo:";
            // 
            // totalFaltanteUltimoCostoTextBox
            // 
            this.totalFaltanteUltimoCostoTextBox.Location = new System.Drawing.Point(1012, 643);
            this.totalFaltanteUltimoCostoTextBox.Name = "totalFaltanteUltimoCostoTextBox";
            this.totalFaltanteUltimoCostoTextBox.ReadOnly = true;
            this.totalFaltanteUltimoCostoTextBox.Size = new System.Drawing.Size(160, 22);
            this.totalFaltanteUltimoCostoTextBox.TabIndex = 131;
            this.totalFaltanteUltimoCostoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(796, 646);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 17);
            this.label8.TabIndex = 132;
            this.label8.Text = "Total Faltante Último Costo:";
            // 
            // totalFaltanteCostoPromedioTextBox
            // 
            this.totalFaltanteCostoPromedioTextBox.Location = new System.Drawing.Point(1012, 669);
            this.totalFaltanteCostoPromedioTextBox.Name = "totalFaltanteCostoPromedioTextBox";
            this.totalFaltanteCostoPromedioTextBox.ReadOnly = true;
            this.totalFaltanteCostoPromedioTextBox.Size = new System.Drawing.Size(160, 22);
            this.totalFaltanteCostoPromedioTextBox.TabIndex = 129;
            this.totalFaltanteCostoPromedioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(773, 672);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(233, 17);
            this.label13.TabIndex = 130;
            this.label13.Text = "Total Faltante Costo Promedio:";
            // 
            // frmUnInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1179, 693);
            this.Controls.Add(this.totalSobranteCostoPromedioTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.totalSobranteUltimoCostoTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalFaltanteUltimoCostoTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.totalFaltanteCostoPromedioTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.totalItemsTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.categoriaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.almacenTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fechaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iDInventarioTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUnInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---Inventario---";
            this.Load += new System.EventHandler(this.frmUnInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox totalItemsTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox categoriaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TextBox almacenTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fechaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iDInventarioTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox totalSobranteCostoPromedioTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox totalSobranteUltimoCostoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalFaltanteUltimoCostoTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox totalFaltanteCostoPromedioTextBox;
        private System.Windows.Forms.Label label13;
    }
}