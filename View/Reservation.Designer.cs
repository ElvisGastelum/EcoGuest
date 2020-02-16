namespace View
{
    partial class Reservation
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            this.lbl_resv = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_noReserva = new System.Windows.Forms.TextBox();
            this.txt_numRooms = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.dtp_dateIn = new System.Windows.Forms.DateTimePicker();
            this.dtp_dateOut = new System.Windows.Forms.DateTimePicker();
            this.txt_noAdult = new System.Windows.Forms.TextBox();
            this.txt_noKids = new System.Windows.Forms.TextBox();
            this.cmb_tipoRoom = new System.Windows.Forms.ComboBox();
            this.btn_reservar = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_habitaciones = new System.Windows.Forms.Button();
            this.txt_noRoom = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_daysIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_formaPay = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_resv
            // 
            this.lbl_resv.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbl_resv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_resv.Font = new System.Drawing.Font("High Tower Text", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resv.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_resv.Location = new System.Drawing.Point(1, 0);
            this.lbl_resv.Name = "lbl_resv";
            this.lbl_resv.Size = new System.Drawing.Size(900, 31);
            this.lbl_resv.TabIndex = 0;
            this.lbl_resv.Text = "RESERVAR";
            this.lbl_resv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(13, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha de ingreso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(13, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha de egreso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(12, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Datos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(13, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "No. de reservación:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGreen;
            this.label10.Location = new System.Drawing.Point(13, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "No. de Adultos:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkGreen;
            this.label11.Location = new System.Drawing.Point(12, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "No. de Niños:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkGreen;
            this.label13.Location = new System.Drawing.Point(469, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 19);
            this.label13.TabIndex = 13;
            this.label13.Text = "Tipo:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkGreen;
            this.label16.Location = new System.Drawing.Point(469, 166);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 19);
            this.label16.TabIndex = 16;
            this.label16.Text = "Precio:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkGreen;
            this.label17.Location = new System.Drawing.Point(15, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 19);
            this.label17.TabIndex = 17;
            this.label17.Text = "Total:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkGreen;
            this.label19.Location = new System.Drawing.Point(8, 317);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(176, 19);
            this.label19.TabIndex = 19;
            this.label19.Text = "Cant. habitacion(es):";
            // 
            // txt_noReserva
            // 
            this.txt_noReserva.Location = new System.Drawing.Point(196, 82);
            this.txt_noReserva.Name = "txt_noReserva";
            this.txt_noReserva.Size = new System.Drawing.Size(199, 20);
            this.txt_noReserva.TabIndex = 24;
            // 
            // txt_numRooms
            // 
            this.txt_numRooms.Location = new System.Drawing.Point(195, 318);
            this.txt_numRooms.Name = "txt_numRooms";
            this.txt_numRooms.Size = new System.Drawing.Size(200, 20);
            this.txt_numRooms.TabIndex = 25;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(658, 169);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(204, 20);
            this.txt_precio.TabIndex = 36;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(84, 33);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(204, 20);
            this.txt_total.TabIndex = 39;
            // 
            // dtp_dateIn
            // 
            this.dtp_dateIn.Location = new System.Drawing.Point(195, 124);
            this.dtp_dateIn.Name = "dtp_dateIn";
            this.dtp_dateIn.Size = new System.Drawing.Size(200, 20);
            this.dtp_dateIn.TabIndex = 41;
            // 
            // dtp_dateOut
            // 
            this.dtp_dateOut.Location = new System.Drawing.Point(195, 156);
            this.dtp_dateOut.Name = "dtp_dateOut";
            this.dtp_dateOut.Size = new System.Drawing.Size(200, 20);
            this.dtp_dateOut.TabIndex = 45;
            // 
            // txt_noAdult
            // 
            this.txt_noAdult.Location = new System.Drawing.Point(195, 249);
            this.txt_noAdult.Name = "txt_noAdult";
            this.txt_noAdult.Size = new System.Drawing.Size(199, 20);
            this.txt_noAdult.TabIndex = 46;
            // 
            // txt_noKids
            // 
            this.txt_noKids.Location = new System.Drawing.Point(195, 282);
            this.txt_noKids.Name = "txt_noKids";
            this.txt_noKids.Size = new System.Drawing.Size(199, 20);
            this.txt_noKids.TabIndex = 47;
            // 
            // cmb_tipoRoom
            // 
            this.cmb_tipoRoom.FormattingEnabled = true;
            this.cmb_tipoRoom.Items.AddRange(new object[] {
            "Suites",
            "Dobles",
            "Sencillas"});
            this.cmb_tipoRoom.Location = new System.Drawing.Point(658, 82);
            this.cmb_tipoRoom.Name = "cmb_tipoRoom";
            this.cmb_tipoRoom.Size = new System.Drawing.Size(204, 21);
            this.cmb_tipoRoom.TabIndex = 48;
            // 
            // btn_reservar
            // 
            this.btn_reservar.BackColor = System.Drawing.Color.Lime;
            this.btn_reservar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reservar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_reservar.Location = new System.Drawing.Point(576, 29);
            this.btn_reservar.Name = "btn_reservar";
            this.btn_reservar.Size = new System.Drawing.Size(83, 44);
            this.btn_reservar.TabIndex = 53;
            this.btn_reservar.Text = "Reservar";
            this.btn_reservar.UseVisualStyleBackColor = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cancel.Location = new System.Drawing.Point(6, 30);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(84, 43);
            this.btn_cancel.TabIndex = 54;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_salir.Location = new System.Drawing.Point(770, 31);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 43);
            this.btn_salir.TabIndex = 55;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            // 
            // btn_habitaciones
            // 
            this.btn_habitaciones.BackColor = System.Drawing.Color.Yellow;
            this.btn_habitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_habitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_habitaciones.Location = new System.Drawing.Point(262, 30);
            this.btn_habitaciones.Name = "btn_habitaciones";
            this.btn_habitaciones.Size = new System.Drawing.Size(116, 43);
            this.btn_habitaciones.TabIndex = 56;
            this.btn_habitaciones.Text = "Habitaciones";
            this.btn_habitaciones.UseVisualStyleBackColor = false;
            // 
            // txt_noRoom
            // 
            this.txt_noRoom.Location = new System.Drawing.Point(658, 127);
            this.txt_noRoom.Name = "txt_noRoom";
            this.txt_noRoom.Size = new System.Drawing.Size(204, 20);
            this.txt_noRoom.TabIndex = 58;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkGreen;
            this.label12.Location = new System.Drawing.Point(469, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 19);
            this.label12.TabIndex = 57;
            this.label12.Text = "No. de habitación:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkGreen;
            this.label15.Location = new System.Drawing.Point(469, 223);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 19);
            this.label15.TabIndex = 59;
            this.label15.Text = "Forma de pago:";
            // 
            // txt_daysIn
            // 
            this.txt_daysIn.Location = new System.Drawing.Point(195, 196);
            this.txt_daysIn.Name = "txt_daysIn";
            this.txt_daysIn.Size = new System.Drawing.Size(199, 20);
            this.txt_daysIn.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(12, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 19);
            this.label1.TabIndex = 63;
            this.label1.Text = "Días reservados:";
            // 
            // cmb_formaPay
            // 
            this.cmb_formaPay.FormattingEnabled = true;
            this.cmb_formaPay.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de Credito",
            "Tarjeta de Debito"});
            this.cmb_formaPay.Location = new System.Drawing.Point(658, 224);
            this.cmb_formaPay.Name = "cmb_formaPay";
            this.cmb_formaPay.Size = new System.Drawing.Size(204, 21);
            this.cmb_formaPay.TabIndex = 65;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_habitaciones);
            this.groupBox1.Controls.Add(this.btn_reservar);
            this.groupBox1.Controls.Add(this.btn_salir);
            this.groupBox1.Location = new System.Drawing.Point(17, 390);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 97);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txt_total);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Location = new System.Drawing.Point(568, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 83);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            // 
            // Reservation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 499);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_formaPay);
            this.Controls.Add(this.txt_daysIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_noRoom);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmb_tipoRoom);
            this.Controls.Add(this.txt_noKids);
            this.Controls.Add(this.txt_noAdult);
            this.Controls.Add(this.dtp_dateOut);
            this.Controls.Add(this.dtp_dateIn);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_numRooms);
            this.Controls.Add(this.txt_noReserva);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_resv);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Reservation";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservación";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_resv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_noReserva;
        private System.Windows.Forms.TextBox txt_numRooms;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.DateTimePicker dtp_dateIn;
        private System.Windows.Forms.DateTimePicker dtp_dateOut;
        private System.Windows.Forms.TextBox txt_noAdult;
        private System.Windows.Forms.TextBox txt_noKids;
        private System.Windows.Forms.ComboBox cmb_tipoRoom;
        private System.Windows.Forms.Button btn_reservar;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_habitaciones;
        private System.Windows.Forms.TextBox txt_noRoom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_daysIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_formaPay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

