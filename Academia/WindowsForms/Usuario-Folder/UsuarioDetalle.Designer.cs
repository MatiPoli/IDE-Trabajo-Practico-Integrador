﻿namespace WindowsForms
{
    partial class UsuarioDetalle
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            aceptarButton = new Button();
            cancelarButton = new Button();
            direccionTextBox = new TextBox();
            apellidoTextBox = new TextBox();
            emailTextBox = new TextBox();
            nombreTextBox = new TextBox();
            telefonoTextBox = new TextBox();
            legajoTextBox = new TextBox();
            fechaNacDateTimePicker = new DateTimePicker();
            errorProvider = new ErrorProvider(components);
            label8 = new Label();
            tipoPersonaComboBox = new ComboBox();
            label9 = new Label();
            claveTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 92);
            label1.Margin = new Padding(3, 0, 3, 20);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 127);
            label2.Margin = new Padding(3, 0, 3, 20);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 162);
            label3.Margin = new Padding(3, 0, 3, 20);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Dirección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 20);
            label4.Margin = new Padding(3, 0, 3, 20);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 197);
            label5.Margin = new Padding(3, 0, 3, 20);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 232);
            label6.Margin = new Padding(3, 0, 3, 20);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 5;
            label6.Text = "Fecha Nacimiento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 267);
            label7.Margin = new Padding(3, 0, 3, 20);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 6;
            label7.Text = "Legajo";
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(23, 341);
            aceptarButton.Margin = new Padding(3, 3, 20, 3);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(75, 23);
            aceptarButton.TabIndex = 10;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(186, 341);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(75, 23);
            cancelarButton.TabIndex = 11;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // direccionTextBox
            // 
            direccionTextBox.Location = new Point(116, 159);
            direccionTextBox.Name = "direccionTextBox";
            direccionTextBox.Size = new Size(145, 23);
            direccionTextBox.TabIndex = 5;
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.Location = new Point(116, 124);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(145, 23);
            apellidoTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(116, 17);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(145, 23);
            emailTextBox.TabIndex = 1;
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(116, 89);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(145, 23);
            nombreTextBox.TabIndex = 3;
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.Location = new Point(116, 194);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.Size = new Size(145, 23);
            telefonoTextBox.TabIndex = 6;
            // 
            // legajoTextBox
            // 
            legajoTextBox.Location = new Point(116, 264);
            legajoTextBox.Name = "legajoTextBox";
            legajoTextBox.Size = new Size(145, 23);
            legajoTextBox.TabIndex = 8;
            // 
            // fechaNacDateTimePicker
            // 
            fechaNacDateTimePicker.CustomFormat = "dd/MM/yyyy";
            fechaNacDateTimePicker.Format = DateTimePickerFormat.Custom;
            fechaNacDateTimePicker.Location = new Point(132, 226);
            fechaNacDateTimePicker.MaxDate = new DateTime(2024, 9, 6, 0, 0, 0, 0);
            fechaNacDateTimePicker.Name = "fechaNacDateTimePicker";
            fechaNacDateTimePicker.Size = new Size(129, 23);
            fechaNacDateTimePicker.TabIndex = 7;
            fechaNacDateTimePicker.Value = new DateTime(2024, 9, 6, 0, 0, 0, 0);
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 302);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 10;
            label8.Text = "Tipo Persona";
            // 
            // tipoPersonaComboBox
            // 
            tipoPersonaComboBox.FormattingEnabled = true;
            tipoPersonaComboBox.Items.AddRange(new object[] { "Alumno", "Docente", "Admin" });
            tipoPersonaComboBox.Location = new Point(116, 299);
            tipoPersonaComboBox.Name = "tipoPersonaComboBox";
            tipoPersonaComboBox.Size = new Size(145, 23);
            tipoPersonaComboBox.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 55);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 11;
            label9.Text = "Clave";
            // 
            // claveTextBox
            // 
            claveTextBox.Location = new Point(116, 52);
            claveTextBox.Name = "claveTextBox";
            claveTextBox.Size = new Size(145, 23);
            claveTextBox.TabIndex = 2;
            // 
            // UsuarioDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 387);
            Controls.Add(claveTextBox);
            Controls.Add(label9);
            Controls.Add(tipoPersonaComboBox);
            Controls.Add(label8);
            Controls.Add(fechaNacDateTimePicker);
            Controls.Add(legajoTextBox);
            Controls.Add(telefonoTextBox);
            Controls.Add(nombreTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(apellidoTextBox);
            Controls.Add(direccionTextBox);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(300, 426);
            MinimumSize = new Size(300, 426);
            Name = "UsuarioDetalle";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Usuario";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button aceptarButton;
        private Button cancelarButton;
        private TextBox direccionTextBox;
        private TextBox apellidoTextBox;
        private TextBox emailTextBox;
        private TextBox nombreTextBox;
        private TextBox telefonoTextBox;
        private TextBox legajoTextBox;
        private DateTimePicker fechaNacDateTimePicker;
        private ErrorProvider errorProvider;
        private ComboBox tipoPersonaComboBox;
        private Label label8;
        private TextBox claveTextBox;
        private Label label9;
    }
}