namespace View
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_nombreC = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_modificarC = new System.Windows.Forms.Button();
            this.btn_borrarC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_saldarDeuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "HUÉSPEDES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscar.Location = new System.Drawing.Point(587, 66);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(96, 35);
            this.btn_buscar.TabIndex = 55;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_nombreC
            // 
            this.txt_nombreC.Location = new System.Drawing.Point(251, 74);
            this.txt_nombreC.Name = "txt_nombreC";
            this.txt_nombreC.Size = new System.Drawing.Size(314, 20);
            this.txt_nombreC.TabIndex = 54;
            this.txt_nombreC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPressed);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DarkGreen;
            this.label20.Location = new System.Drawing.Point(155, 73);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 19);
            this.label20.TabIndex = 53;
            this.label20.Text = "Cliente:";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 107);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(780, 294);
            this.dataGridView.TabIndex = 56;
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_regresar.Location = new System.Drawing.Point(21, 28);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(75, 43);
            this.btn_regresar.TabIndex = 75;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_modificarC
            // 
            this.btn_modificarC.BackColor = System.Drawing.Color.Yellow;
            this.btn_modificarC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_modificarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_modificarC.Location = new System.Drawing.Point(596, 28);
            this.btn_modificarC.Name = "btn_modificarC";
            this.btn_modificarC.Size = new System.Drawing.Size(75, 43);
            this.btn_modificarC.TabIndex = 76;
            this.btn_modificarC.Text = "Modificar";
            this.btn_modificarC.UseVisualStyleBackColor = false;
            this.btn_modificarC.Click += new System.EventHandler(this.btn_modificarC_Click);
            // 
            // btn_borrarC
            // 
            this.btn_borrarC.BackColor = System.Drawing.Color.Red;
            this.btn_borrarC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_borrarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrarC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_borrarC.Location = new System.Drawing.Point(689, 28);
            this.btn_borrarC.Name = "btn_borrarC";
            this.btn_borrarC.Size = new System.Drawing.Size(75, 43);
            this.btn_borrarC.TabIndex = 77;
            this.btn_borrarC.Text = "Eliminar";
            this.btn_borrarC.UseVisualStyleBackColor = false;
            this.btn_borrarC.Click += new System.EventHandler(this.Delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_saldarDeuda);
            this.groupBox1.Controls.Add(this.btn_regresar);
            this.groupBox1.Controls.Add(this.btn_borrarC);
            this.groupBox1.Controls.Add(this.btn_modificarC);
            this.groupBox1.Location = new System.Drawing.Point(12, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 91);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(587, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 35);
            this.button1.TabIndex = 55;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_saldarDeuda
            // 
            this.btn_saldarDeuda.BackColor = System.Drawing.Color.Lime;
            this.btn_saldarDeuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_saldarDeuda.BackgroundImage")));
            this.btn_saldarDeuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_saldarDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saldarDeuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_saldarDeuda.Location = new System.Drawing.Point(471, 28);
            this.btn_saldarDeuda.Name = "btn_saldarDeuda";
            this.btn_saldarDeuda.Size = new System.Drawing.Size(109, 43);
            this.btn_saldarDeuda.TabIndex = 78;
            this.btn_saldarDeuda.Text = "Saldar Deuda";
            this.btn_saldarDeuda.UseVisualStyleBackColor = false;
            this.btn_saldarDeuda.Click += new System.EventHandler(this.btn_saldarDeuda_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_nombreC);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSCAR HUÉSPED";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExitForm);
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_nombreC;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_modificarC;
        private System.Windows.Forms.Button btn_borrarC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_saldarDeuda;
    }
}