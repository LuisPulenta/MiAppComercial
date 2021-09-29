
namespace Win.Consultas
{
    partial class frmUnaSalida
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnaSalida));
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.almacenTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iDSalidaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.conceptoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalUltimoCostoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalCostoPromedioTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.totalItemsTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.Location = new System.Drawing.Point(7, 122);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(1165, 536);
            this.dgvDatos.TabIndex = 92;
            // 
            // almacenTextBox
            // 
            this.almacenTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.almacenTextBox.Location = new System.Drawing.Point(133, 94);
            this.almacenTextBox.Name = "almacenTextBox";
            this.almacenTextBox.ReadOnly = true;
            this.almacenTextBox.Size = new System.Drawing.Size(196, 22);
            this.almacenTextBox.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 90;
            this.label3.Text = "Almacén:";
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
            this.label1.Location = new System.Drawing.Point(79, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 86;
            this.label1.Text = "Fecha:";
            // 
            // iDSalidaTextBox
            // 
            this.iDSalidaTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.iDSalidaTextBox.Location = new System.Drawing.Point(133, 12);
            this.iDSalidaTextBox.Name = "iDSalidaTextBox";
            this.iDSalidaTextBox.ReadOnly = true;
            this.iDSalidaTextBox.Size = new System.Drawing.Size(100, 22);
            this.iDSalidaTextBox.TabIndex = 85;
            this.iDSalidaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.iDSalidaTextBox_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 84;
            this.label4.Text = "Salida:";
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
            // conceptoTextBox
            // 
            this.conceptoTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.conceptoTextBox.Location = new System.Drawing.Point(133, 68);
            this.conceptoTextBox.Name = "conceptoTextBox";
            this.conceptoTextBox.ReadOnly = true;
            this.conceptoTextBox.Size = new System.Drawing.Size(196, 22);
            this.conceptoTextBox.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 105;
            this.label2.Text = "Concepto:";
            // 
            // totalUltimoCostoTextBox
            // 
            this.totalUltimoCostoTextBox.Location = new System.Drawing.Point(1011, 664);
            this.totalUltimoCostoTextBox.Name = "totalUltimoCostoTextBox";
            this.totalUltimoCostoTextBox.ReadOnly = true;
            this.totalUltimoCostoTextBox.Size = new System.Drawing.Size(160, 22);
            this.totalUltimoCostoTextBox.TabIndex = 109;
            this.totalUltimoCostoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(859, 667);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 110;
            this.label5.Text = "Total Último Costo:";
            // 
            // totalCostoPromedioTextBox
            // 
            this.totalCostoPromedioTextBox.Location = new System.Drawing.Point(655, 664);
            this.totalCostoPromedioTextBox.Name = "totalCostoPromedioTextBox";
            this.totalCostoPromedioTextBox.ReadOnly = true;
            this.totalCostoPromedioTextBox.Size = new System.Drawing.Size(160, 22);
            this.totalCostoPromedioTextBox.TabIndex = 107;
            this.totalCostoPromedioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(480, 667);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 17);
            this.label13.TabIndex = 108;
            this.label13.Text = "Total Costo Promedio:";
            // 
            // totalItemsTextBox
            // 
            this.totalItemsTextBox.Location = new System.Drawing.Point(305, 666);
            this.totalItemsTextBox.Name = "totalItemsTextBox";
            this.totalItemsTextBox.ReadOnly = true;
            this.totalItemsTextBox.Size = new System.Drawing.Size(66, 22);
            this.totalItemsTextBox.TabIndex = 111;
            this.totalItemsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(206, 669);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 112;
            this.label6.Text = "Total Items:";
            // 
            // frmUnaSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1179, 693);
            this.Controls.Add(this.totalItemsTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalUltimoCostoTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalCostoPromedioTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.conceptoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.almacenTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fechaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iDSalidaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUnaSalida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---Salida---";
            this.Load += new System.EventHandler(this.frmUnaSalida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TextBox almacenTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fechaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iDSalidaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox conceptoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalUltimoCostoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalCostoPromedioTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox totalItemsTextBox;
        private System.Windows.Forms.Label label6;
    }
}