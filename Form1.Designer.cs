namespace Calculadora_De_Salario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TXTNombre = new TextBox();
            Txt1 = new Label();
            label1 = new Label();
            label2 = new Label();
            TxtSalario = new TextBox();
            TABLA = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Salario = new DataGridViewTextBoxColumn();
            ISSS = new DataGridViewTextBoxColumn();
            AFP = new DataGridViewTextBoxColumn();
            Renta = new DataGridViewTextBoxColumn();
            impuestoSobreLarenta = new DataGridViewTextBoxColumn();
            Liquido = new DataGridViewTextBoxColumn();
            ColumnaISSSPatronal = new DataGridViewTextBoxColumn();
            ColumnaAFPPatronal = new DataGridViewTextBoxColumn();
            TotalISSS = new DataGridViewTextBoxColumn();
            TotalAFP = new DataGridViewTextBoxColumn();
            label3 = new Label();
            TxtCargo = new TextBox();
            BotonCalcular = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)TABLA).BeginInit();
            SuspendLayout();
            // 
            // TXTNombre
            // 
            TXTNombre.Location = new Point(12, 99);
            TXTNombre.Name = "TXTNombre";
            TXTNombre.Size = new Size(274, 23);
            TXTNombre.TabIndex = 0;
            TXTNombre.TextChanged += textBox1_TextChanged;
            TXTNombre.KeyPress += textBox1_KeyPress;
            // 
            // Txt1
            // 
            Txt1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Txt1.AutoSize = true;
            Txt1.Font = new Font("Arial Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Txt1.ForeColor = SystemColors.Desktop;
            Txt1.Location = new Point(511, 9);
            Txt1.Name = "Txt1";
            Txt1.Size = new Size(538, 68);
            Txt1.TabIndex = 1;
            Txt1.Text = "Planilla De Salarios";
            Txt1.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 76);
            label1.Name = "label1";
            label1.Size = new Size(241, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre Completo del trabajador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 225);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 3;
            label2.Text = "Ingrese el Salario";
            // 
            // TxtSalario
            // 
            TxtSalario.Location = new Point(12, 248);
            TxtSalario.Name = "TxtSalario";
            TxtSalario.Size = new Size(120, 23);
            TxtSalario.TabIndex = 4;
            TxtSalario.TextChanged += textBox2_TextChanged;
            TxtSalario.KeyPress += textBox2_KeyPress;
            // 
            // TABLA
            // 
            TABLA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TABLA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TABLA.Columns.AddRange(new DataGridViewColumn[] { Nombre, Cargo, Salario, ISSS, AFP, Renta, impuestoSobreLarenta, Liquido, ColumnaISSSPatronal, ColumnaAFPPatronal, TotalISSS, TotalAFP });
            TABLA.Location = new Point(292, 99);
            TABLA.Name = "TABLA";
            TABLA.Size = new Size(1360, 338);
            TABLA.TabIndex = 5;
            TABLA.CellContentClick += TABLA_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 220;
            // 
            // Cargo
            // 
            Cargo.HeaderText = "Cargo";
            Cargo.Name = "Cargo";
            // 
            // Salario
            // 
            Salario.HeaderText = "Salario";
            Salario.Name = "Salario";
            // 
            // ISSS
            // 
            ISSS.HeaderText = "ISSS";
            ISSS.Name = "ISSS";
            // 
            // AFP
            // 
            AFP.HeaderText = "AFP";
            AFP.Name = "AFP";
            // 
            // Renta
            // 
            Renta.HeaderText = "Renta Imponible";
            Renta.Name = "Renta";
            // 
            // impuestoSobreLarenta
            // 
            impuestoSobreLarenta.HeaderText = "Impuesto Sobre la Renta";
            impuestoSobreLarenta.Name = "impuestoSobreLarenta";
            // 
            // Liquido
            // 
            Liquido.HeaderText = "Salario Liquido";
            Liquido.Name = "Liquido";
            // 
            // ColumnaISSSPatronal
            // 
            ColumnaISSSPatronal.HeaderText = "ISSS Patronal";
            ColumnaISSSPatronal.Name = "ColumnaISSSPatronal";
            // 
            // ColumnaAFPPatronal
            // 
            ColumnaAFPPatronal.HeaderText = "AFP Patronal";
            ColumnaAFPPatronal.Name = "ColumnaAFPPatronal";
            // 
            // TotalISSS
            // 
            TotalISSS.HeaderText = "Total ISSS";
            TotalISSS.Name = "TotalISSS";
            // 
            // TotalAFP
            // 
            TotalAFP.HeaderText = "Total AFP";
            TotalAFP.Name = "TotalAFP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 152);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 6;
            label3.Text = "Cargo Que Ocupa";
            // 
            // TxtCargo
            // 
            TxtCargo.Location = new Point(10, 175);
            TxtCargo.Name = "TxtCargo";
            TxtCargo.Size = new Size(276, 23);
            TxtCargo.TabIndex = 7;
            TxtCargo.KeyPress += textBox1_KeyPress_1;
            // 
            // BotonCalcular
            // 
            BotonCalcular.BackColor = Color.SteelBlue;
            BotonCalcular.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonCalcular.Location = new Point(17, 317);
            BotonCalcular.Name = "BotonCalcular";
            BotonCalcular.Size = new Size(264, 52);
            BotonCalcular.TabIndex = 8;
            BotonCalcular.Text = "CALCULAR";
            BotonCalcular.UseVisualStyleBackColor = false;
            BotonCalcular.Click += BotonCalcular_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1, 505);
            label4.Name = "label4";
            label4.Size = new Size(0, 30);
            label4.TabIndex = 9;
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1664, 544);
            Controls.Add(label4);
            Controls.Add(BotonCalcular);
            Controls.Add(TxtCargo);
            Controls.Add(label3);
            Controls.Add(TABLA);
            Controls.Add(TxtSalario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Txt1);
            Controls.Add(TXTNombre);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Planilla de Salarios";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)TABLA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TXTNombre;
        private Label Txt1;
        private Label label1;
        private Label label2;
        private TextBox TxtSalario;
        private DataGridView TABLA;
        private Label label3;
        private TextBox TxtCargo;
        private Button BotonCalcular;
        private Label label4;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Salario;
        private DataGridViewTextBoxColumn ISSS;
        private DataGridViewTextBoxColumn AFP;
        private DataGridViewTextBoxColumn Renta;
        private DataGridViewTextBoxColumn impuestoSobreLarenta;
        private DataGridViewTextBoxColumn Liquido;
        private DataGridViewTextBoxColumn ColumnaISSSPatronal;
        private DataGridViewTextBoxColumn ColumnaAFPPatronal;
        private DataGridViewTextBoxColumn TotalISSS;
        private DataGridViewTextBoxColumn TotalAFP;
    }
}
