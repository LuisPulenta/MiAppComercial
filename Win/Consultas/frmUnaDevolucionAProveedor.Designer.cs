﻿
namespace Win.Consultas
{
    partial class frmUnaDevolucionAProveedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnaDevolucionAProveedor));
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totalNetoTextBox = new System.Windows.Forms.TextBox();
            this.totalDescuentoTextBox = new System.Windows.Forms.TextBox();
            this.totalIVATextBox = new System.Windows.Forms.TextBox();
            this.totalBrutoTextBox = new System.Windows.Forms.TextBox();
            this.totalItemTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.proveedorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iDDevolucionAProveedorTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(869, 639);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 17);
            this.label14.TabIndex = 104;
            this.label14.Text = "Valor IVA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1072, 637);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 17);
            this.label13.TabIndex = 103;
            this.label13.Text = "Valor Neto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(975, 637);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 17);
            this.label12.TabIndex = 102;
            this.label12.Text = "Valor Desc.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(975, 637);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 101;
            this.label11.Text = "Valor IVA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(763, 639);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 100;
            this.label10.Text = "Valor Bruto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(662, 637);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 99;
            this.label9.Text = "Items";
            // 
            // totalNetoTextBox
            // 
            this.totalNetoTextBox.Location = new System.Drawing.Point(1072, 659);
            this.totalNetoTextBox.Name = "totalNetoTextBox";
            this.totalNetoTextBox.ReadOnly = true;
            this.totalNetoTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalNetoTextBox.TabIndex = 98;
            this.totalNetoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalDescuentoTextBox
            // 
            this.totalDescuentoTextBox.Location = new System.Drawing.Point(966, 659);
            this.totalDescuentoTextBox.Name = "totalDescuentoTextBox";
            this.totalDescuentoTextBox.ReadOnly = true;
            this.totalDescuentoTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalDescuentoTextBox.TabIndex = 97;
            this.totalDescuentoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalIVATextBox
            // 
            this.totalIVATextBox.Location = new System.Drawing.Point(860, 659);
            this.totalIVATextBox.Name = "totalIVATextBox";
            this.totalIVATextBox.ReadOnly = true;
            this.totalIVATextBox.Size = new System.Drawing.Size(100, 22);
            this.totalIVATextBox.TabIndex = 96;
            this.totalIVATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalBrutoTextBox
            // 
            this.totalBrutoTextBox.Location = new System.Drawing.Point(753, 659);
            this.totalBrutoTextBox.Name = "totalBrutoTextBox";
            this.totalBrutoTextBox.ReadOnly = true;
            this.totalBrutoTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalBrutoTextBox.TabIndex = 95;
            this.totalBrutoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalItemTextBox
            // 
            this.totalItemTextBox.Location = new System.Drawing.Point(647, 659);
            this.totalItemTextBox.Name = "totalItemTextBox";
            this.totalItemTextBox.ReadOnly = true;
            this.totalItemTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalItemTextBox.TabIndex = 94;
            this.totalItemTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(574, 662);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 93;
            this.label8.Text = "Totales:";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDatos.Location = new System.Drawing.Point(7, 134);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(1165, 500);
            this.dgvDatos.TabIndex = 92;
            // 
            // proveedorTextBox
            // 
            this.proveedorTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.proveedorTextBox.Location = new System.Drawing.Point(133, 68);
            this.proveedorTextBox.Name = "proveedorTextBox";
            this.proveedorTextBox.ReadOnly = true;
            this.proveedorTextBox.Size = new System.Drawing.Size(376, 22);
            this.proveedorTextBox.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 88;
            this.label2.Text = "Proveedor:";
            // 
            // fechaTextBox
            // 
            this.fechaTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.fechaTextBox.Location = new System.Drawing.Point(133, 40);
            this.fechaTextBox.Name = "fechaTextBox";
            this.fechaTextBox.ReadOnly = true;
            this.fechaTextBox.Size = new System.Drawing.Size(293, 22);
            this.fechaTextBox.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 86;
            this.label1.Text = "Fecha:";
            // 
            // iDDevolucionAProveedorTextBox
            // 
            this.iDDevolucionAProveedorTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.iDDevolucionAProveedorTextBox.Location = new System.Drawing.Point(133, 12);
            this.iDDevolucionAProveedorTextBox.Name = "iDDevolucionAProveedorTextBox";
            this.iDDevolucionAProveedorTextBox.ReadOnly = true;
            this.iDDevolucionAProveedorTextBox.Size = new System.Drawing.Size(100, 22);
            this.iDDevolucionAProveedorTextBox.TabIndex = 85;
            this.iDDevolucionAProveedorTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.iDDevolucionAProveedorTextBox_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 84;
            this.label4.Text = "Devolución:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1092, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // frmUnaDevolucionAProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1179, 693);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totalNetoTextBox);
            this.Controls.Add(this.totalDescuentoTextBox);
            this.Controls.Add(this.totalIVATextBox);
            this.Controls.Add(this.totalBrutoTextBox);
            this.Controls.Add(this.totalItemTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.proveedorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fechaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iDDevolucionAProveedorTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUnaDevolucionAProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---Devolución a Proveedor---";
            this.Load += new System.EventHandler(this.frmUnaDevolucionAProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalNetoTextBox;
        private System.Windows.Forms.TextBox totalDescuentoTextBox;
        private System.Windows.Forms.TextBox totalIVATextBox;
        private System.Windows.Forms.TextBox totalBrutoTextBox;
        private System.Windows.Forms.TextBox totalItemTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TextBox proveedorTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fechaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iDDevolucionAProveedorTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}