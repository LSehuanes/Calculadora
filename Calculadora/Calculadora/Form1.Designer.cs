namespace Calculadora
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
            txtResultado = new TextBox();
            btnUno = new Button();
            btnSigno = new Button();
            btnDos = new Button();
            btnTres = new Button();
            btnSeis = new Button();
            btnCinco = new Button();
            btnCuatro = new Button();
            btn9 = new Button();
            btnOcho = new Button();
            btnSiete = new Button();
            BtnBorrar = new Button();
            btnBorrarTodo = new Button();
            btnQuitar = new Button();
            btnElevarCuadrado = new Button();
            btnRaiz = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            btnRestar = new Button();
            btnSumar = new Button();
            btnIgual = new Button();
            btnCero = new Button();
            btnPunto = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(12, 8);
            txtResultado.MaxLength = 21;
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(273, 43);
            txtResultado.TabIndex = 0;
            txtResultado.Text = "0";
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnUno
            // 
            btnUno.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUno.Location = new Point(12, 246);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(45, 45);
            btnUno.TabIndex = 1;
            btnUno.Text = "1";
            btnUno.UseVisualStyleBackColor = true;
            btnUno.Click += agregarNumero;
            // 
            // btnSigno
            // 
            btnSigno.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSigno.Location = new Point(12, 297);
            btnSigno.Name = "btnSigno";
            btnSigno.Size = new Size(45, 45);
            btnSigno.TabIndex = 2;
            btnSigno.Text = "±";
            btnSigno.UseVisualStyleBackColor = true;
            btnSigno.Click += btnSigno_Click;
            // 
            // btnDos
            // 
            btnDos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDos.Location = new Point(63, 246);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(45, 45);
            btnDos.TabIndex = 3;
            btnDos.Text = "2";
            btnDos.UseVisualStyleBackColor = true;
            btnDos.Click += agregarNumero;
            // 
            // btnTres
            // 
            btnTres.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTres.Location = new Point(114, 246);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(45, 45);
            btnTres.TabIndex = 4;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += agregarNumero;
            // 
            // btnSeis
            // 
            btnSeis.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeis.Location = new Point(114, 195);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(45, 45);
            btnSeis.TabIndex = 7;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += agregarNumero;
            // 
            // btnCinco
            // 
            btnCinco.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCinco.Location = new Point(63, 195);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(45, 45);
            btnCinco.TabIndex = 6;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += agregarNumero;
            // 
            // btnCuatro
            // 
            btnCuatro.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCuatro.Location = new Point(12, 195);
            btnCuatro.Name = "btnCuatro";
            btnCuatro.Size = new Size(45, 45);
            btnCuatro.TabIndex = 5;
            btnCuatro.Text = "4";
            btnCuatro.UseVisualStyleBackColor = true;
            btnCuatro.Click += agregarNumero;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(114, 144);
            btn9.Name = "btn9";
            btn9.Size = new Size(45, 45);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += agregarNumero;
            // 
            // btnOcho
            // 
            btnOcho.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOcho.Location = new Point(63, 144);
            btnOcho.Name = "btnOcho";
            btnOcho.Size = new Size(45, 45);
            btnOcho.TabIndex = 9;
            btnOcho.Text = "8";
            btnOcho.UseVisualStyleBackColor = true;
            btnOcho.Click += agregarNumero;
            // 
            // btnSiete
            // 
            btnSiete.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSiete.Location = new Point(12, 144);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new Size(45, 45);
            btnSiete.TabIndex = 8;
            btnSiete.Text = "7";
            btnSiete.UseVisualStyleBackColor = true;
            btnSiete.Click += agregarNumero;
            // 
            // BtnBorrar
            // 
            BtnBorrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBorrar.Location = new Point(12, 93);
            BtnBorrar.Name = "BtnBorrar";
            BtnBorrar.Size = new Size(45, 45);
            BtnBorrar.TabIndex = 11;
            BtnBorrar.Text = "CE ";
            BtnBorrar.UseVisualStyleBackColor = true;
            BtnBorrar.Click += BtnBorrar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBorrarTodo.Location = new Point(63, 93);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(45, 45);
            btnBorrarTodo.TabIndex = 12;
            btnBorrarTodo.Text = "C";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuitar.Location = new Point(114, 93);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(45, 45);
            btnQuitar.TabIndex = 13;
            btnQuitar.Text = "<-";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnElevarCuadrado
            // 
            btnElevarCuadrado.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnElevarCuadrado.Location = new Point(251, 93);
            btnElevarCuadrado.Name = "btnElevarCuadrado";
            btnElevarCuadrado.Size = new Size(45, 45);
            btnElevarCuadrado.TabIndex = 15;
            btnElevarCuadrado.Tag = "²";
            btnElevarCuadrado.Text = "x²";
            btnElevarCuadrado.UseVisualStyleBackColor = true;
            btnElevarCuadrado.Click += clickOperador;
            // 
            // btnRaiz
            // 
            btnRaiz.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRaiz.Location = new Point(200, 93);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(45, 45);
            btnRaiz.TabIndex = 14;
            btnRaiz.Tag = "√";
            btnRaiz.Text = "√";
            btnRaiz.UseVisualStyleBackColor = true;
            btnRaiz.Click += clickOperador;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiplicar.Location = new Point(251, 144);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(45, 45);
            btnMultiplicar.TabIndex = 17;
            btnMultiplicar.Tag = "X";
            btnMultiplicar.Text = "X";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += clickOperador;
            // 
            // btnDividir
            // 
            btnDividir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDividir.Location = new Point(200, 144);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(45, 45);
            btnDividir.TabIndex = 16;
            btnDividir.Tag = "/";
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += clickOperador;
            // 
            // btnRestar
            // 
            btnRestar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestar.Location = new Point(251, 195);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(45, 45);
            btnRestar.TabIndex = 19;
            btnRestar.Tag = "-";
            btnRestar.Text = "-";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += clickOperador;
            // 
            // btnSumar
            // 
            btnSumar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSumar.Location = new Point(200, 195);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(45, 45);
            btnSumar.TabIndex = 18;
            btnSumar.Tag = "+";
            btnSumar.Text = "+";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += clickOperador;
            // 
            // btnIgual
            // 
            btnIgual.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIgual.Location = new Point(200, 246);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(96, 45);
            btnIgual.TabIndex = 20;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnCero
            // 
            btnCero.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCero.Location = new Point(63, 297);
            btnCero.Name = "btnCero";
            btnCero.Size = new Size(45, 45);
            btnCero.TabIndex = 21;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = true;
            // 
            // btnPunto
            // 
            btnPunto.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPunto.Location = new Point(114, 297);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(45, 45);
            btnPunto.TabIndex = 22;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += btnPunto_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 345);
            Controls.Add(btnPunto);
            Controls.Add(btnCero);
            Controls.Add(btnIgual);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnDividir);
            Controls.Add(btnElevarCuadrado);
            Controls.Add(btnRaiz);
            Controls.Add(btnQuitar);
            Controls.Add(btnBorrarTodo);
            Controls.Add(BtnBorrar);
            Controls.Add(btn9);
            Controls.Add(btnOcho);
            Controls.Add(btnSiete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnCuatro);
            Controls.Add(btnTres);
            Controls.Add(btnDos);
            Controls.Add(btnSigno);
            Controls.Add(btnUno);
            Controls.Add(txtResultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnUno;
        private Button btnSigno;
        private Button btnDos;
        private Button btnTres;
        private Button btnSeis;
        private Button btnCinco;
        private Button btnCuatro;
        private Button btn9;
        private Button btnOcho;
        private Button btnSiete;
        private Button BtnBorrar;
        private Button btnBorrarTodo;
        private Button btnQuitar;
        private Button btnElevarCuadrado;
        private Button btnRaiz;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnRestar;
        private Button btnSumar;
        private Button btnIgual;
        private Button btnCero;
        private Button btnPunto;
    }
}
