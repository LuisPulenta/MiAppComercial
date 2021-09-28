
namespace Win.Consultas
{
    partial class frmUnaCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnaCompra));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iDCompraTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fechaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.proveedorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.almacenTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(871, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // iDCompraTextBox
            // 
            this.iDCompraTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.iDCompraTextBox.Location = new System.Drawing.Point(128, 12);
            this.iDCompraTextBox.Name = "iDCompraTextBox";
            this.iDCompraTextBox.ReadOnly = true;
            this.iDCompraTextBox.Size = new System.Drawing.Size(100, 22);
            this.iDCompraTextBox.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Compra:";
            // 
            // fechaTextBox
            // 
            this.fechaTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.fechaTextBox.Location = new System.Drawing.Point(128, 40);
            this.fechaTextBox.Name = "fechaTextBox";
            this.fechaTextBox.ReadOnly = true;
            this.fechaTextBox.Size = new System.Drawing.Size(293, 22);
            this.fechaTextBox.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Fecha:";
            // 
            // proveedorTextBox
            // 
            this.proveedorTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.proveedorTextBox.Location = new System.Drawing.Point(128, 68);
            this.proveedorTextBox.Name = "proveedorTextBox";
            this.proveedorTextBox.ReadOnly = true;
            this.proveedorTextBox.Size = new System.Drawing.Size(376, 22);
            this.proveedorTextBox.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Proveedor:";
            // 
            // almacenTextBox
            // 
            this.almacenTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.almacenTextBox.Location = new System.Drawing.Point(128, 96);
            this.almacenTextBox.Name = "almacenTextBox";
            this.almacenTextBox.ReadOnly = true;
            this.almacenTextBox.Size = new System.Drawing.Size(196, 22);
            this.almacenTextBox.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Almacén:";
            // 
            // frmUnaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(963, 693);
            this.Controls.Add(this.almacenTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.proveedorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fechaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iDCompraTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUnaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---Compra---";
            this.Load += new System.EventHandler(this.frmUnaCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox iDCompraTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fechaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox proveedorTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox almacenTextBox;
        private System.Windows.Forms.Label label3;
    }
}