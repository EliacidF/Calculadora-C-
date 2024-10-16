namespace calculadora
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnltitulo = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            button5 = new Button();
            btnHistorial = new Button();
            textdisplay2 = new TextBox();
            textdisplay1 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnBorrar = new CustomControls.RJControls.RJButton();
            btnPorcentaje = new CustomControls.RJControls.RJButton();
            btnC = new CustomControls.RJControls.RJButton();
            btnCE = new CustomControls.RJControls.RJButton();
            btnX2 = new CustomControls.RJControls.RJButton();
            btnRaiz = new CustomControls.RJControls.RJButton();
            btn1X = new CustomControls.RJControls.RJButton();
            btnDividir = new CustomControls.RJControls.RJButton();
            btnOcho = new CustomControls.RJControls.RJButton();
            btnNueve = new CustomControls.RJControls.RJButton();
            btnSiete = new CustomControls.RJControls.RJButton();
            btnMultiplicacion = new CustomControls.RJControls.RJButton();
            btnCinco = new CustomControls.RJControls.RJButton();
            btnSeia = new CustomControls.RJControls.RJButton();
            btnCuatro = new CustomControls.RJControls.RJButton();
            btnResta = new CustomControls.RJControls.RJButton();
            btnDos = new CustomControls.RJControls.RJButton();
            btnTres = new CustomControls.RJControls.RJButton();
            btnUno = new CustomControls.RJControls.RJButton();
            btnSuma = new CustomControls.RJControls.RJButton();
            btnCero = new CustomControls.RJControls.RJButton();
            btnDesimal = new CustomControls.RJControls.RJButton();
            btnPM = new CustomControls.RJControls.RJButton();
            btnIgual = new CustomControls.RJControls.RJButton();
            bntLimpiarHistorias = new Button();
            RtBoxDisplayHistory = new RichTextBox();
            pnlHistorial = new Panel();
            pnltitulo.SuspendLayout();
            panel1.SuspendLayout();
            pnlHistorial.SuspendLayout();
            SuspendLayout();
            // 
            // pnltitulo
            // 
            pnltitulo.Controls.Add(button2);
            pnltitulo.Controls.Add(button1);
            pnltitulo.Location = new Point(0, 1);
            pnltitulo.Name = "pnltitulo";
            pnltitulo.Size = new Size(586, 40);
            pnltitulo.TabIndex = 0;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.Lime;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(460, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(42, 40);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(544, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(42, 40);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(btnHistorial);
            panel1.Location = new Point(0, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(586, 40);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Joanna MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 8);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 5;
            label2.Text = "Calculadora";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(449, 6);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 4;
            label1.Text = "Historial";
            // 
            // button5
            // 
            button5.Dock = DockStyle.Left;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.Red;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(0, 0);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(42, 40);
            button5.TabIndex = 3;
            button5.UseVisualStyleBackColor = true;
            // 
            // btnHistorial
            // 
            btnHistorial.FlatAppearance.BorderSize = 0;
            btnHistorial.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 32, 32);
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Image = (Image)resources.GetObject("btnHistorial.Image");
            btnHistorial.Location = new Point(544, -3);
            btnHistorial.Margin = new Padding(0);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(42, 40);
            btnHistorial.TabIndex = 2;
            btnHistorial.UseVisualStyleBackColor = true;
            // 
            // textdisplay2
            // 
            textdisplay2.BackColor = Color.FromArgb(32, 32, 32);
            textdisplay2.BorderStyle = BorderStyle.None;
            textdisplay2.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textdisplay2.ForeColor = Color.Silver;
            textdisplay2.Location = new Point(0, 90);
            textdisplay2.Margin = new Padding(0);
            textdisplay2.Multiline = true;
            textdisplay2.Name = "textdisplay2";
            textdisplay2.Size = new Size(350, 20);
            textdisplay2.TabIndex = 6;
            textdisplay2.TextAlign = HorizontalAlignment.Right;
            // 
            // textdisplay1
            // 
            textdisplay1.BackColor = Color.FromArgb(32, 32, 32);
            textdisplay1.BorderStyle = BorderStyle.None;
            textdisplay1.Font = new Font("Gadugi", 32F, FontStyle.Bold);
            textdisplay1.ForeColor = Color.WhiteSmoke;
            textdisplay1.Location = new Point(0, 110);
            textdisplay1.Margin = new Padding(0);
            textdisplay1.Multiline = true;
            textdisplay1.Name = "textdisplay1";
            textdisplay1.Size = new Size(350, 50);
            textdisplay1.TabIndex = 7;
            textdisplay1.Text = "0";
            textdisplay1.TextAlign = HorizontalAlignment.Right;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.FromArgb(60, 60, 60);
            btnBorrar.BackgroundColor = Color.FromArgb(60, 60, 60);
            btnBorrar.BorderColor = Color.FromArgb(32, 32, 32);
            btnBorrar.BorderRadius = 10;
            btnBorrar.BorderSize = 0;
            btnBorrar.FlatAppearance.BorderSize = 0;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.ForeColor = Color.Silver;
            btnBorrar.Image = (Image)resources.GetObject("btnBorrar.Image");
            btnBorrar.Location = new Point(259, 199);
            btnBorrar.Margin = new Padding(0);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(85, 55);
            btnBorrar.TabIndex = 8;
            btnBorrar.TextColor = Color.Silver;
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnPorcentaje
            // 
            btnPorcentaje.BackColor = Color.FromArgb(60, 60, 60);
            btnPorcentaje.BackgroundColor = Color.FromArgb(60, 60, 60);
            btnPorcentaje.BorderColor = Color.FromArgb(32, 32, 32);
            btnPorcentaje.BorderRadius = 10;
            btnPorcentaje.BorderSize = 0;
            btnPorcentaje.FlatAppearance.BorderSize = 0;
            btnPorcentaje.FlatStyle = FlatStyle.Flat;
            btnPorcentaje.ForeColor = Color.Silver;
            btnPorcentaje.Location = new Point(5, 199);
            btnPorcentaje.Margin = new Padding(0);
            btnPorcentaje.Name = "btnPorcentaje";
            btnPorcentaje.Size = new Size(85, 55);
            btnPorcentaje.TabIndex = 15;
            btnPorcentaje.Text = "%";
            btnPorcentaje.TextColor = Color.Silver;
            btnPorcentaje.UseVisualStyleBackColor = false;
            btnPorcentaje.Click += Btn_Operaciones_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.FromArgb(60, 60, 60);
            btnC.BackgroundColor = Color.FromArgb(60, 60, 60);
            btnC.BorderColor = Color.FromArgb(32, 32, 32);
            btnC.BorderRadius = 10;
            btnC.BorderSize = 0;
            btnC.FlatAppearance.BorderSize = 0;
            btnC.FlatStyle = FlatStyle.Flat;
            btnC.ForeColor = Color.Silver;
            btnC.Location = new Point(175, 199);
            btnC.Margin = new Padding(0);
            btnC.Name = "btnC";
            btnC.Size = new Size(85, 55);
            btnC.TabIndex = 16;
            btnC.Text = "C";
            btnC.TextColor = Color.Silver;
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btnCE
            // 
            btnCE.BackColor = Color.FromArgb(60, 60, 60);
            btnCE.BackgroundColor = Color.FromArgb(60, 60, 60);
            btnCE.BorderColor = Color.FromArgb(32, 32, 32);
            btnCE.BorderRadius = 10;
            btnCE.BorderSize = 0;
            btnCE.FlatAppearance.BorderSize = 0;
            btnCE.FlatStyle = FlatStyle.Flat;
            btnCE.ForeColor = Color.Silver;
            btnCE.Location = new Point(90, 199);
            btnCE.Margin = new Padding(0);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(85, 55);
            btnCE.TabIndex = 17;
            btnCE.Text = "CE";
            btnCE.TextColor = Color.Silver;
            btnCE.UseVisualStyleBackColor = false;
            btnCE.Click += btnCE_Click;
            // 
            // btnX2
            // 
            btnX2.BackColor = Color.FromArgb(60, 60, 60);
            btnX2.BackgroundColor = Color.FromArgb(60, 60, 60);
            btnX2.BorderColor = Color.FromArgb(32, 32, 32);
            btnX2.BorderRadius = 10;
            btnX2.BorderSize = 0;
            btnX2.FlatAppearance.BorderSize = 0;
            btnX2.FlatStyle = FlatStyle.Flat;
            btnX2.ForeColor = Color.Silver;
            btnX2.Location = new Point(90, 254);
            btnX2.Margin = new Padding(0);
            btnX2.Name = "btnX2";
            btnX2.Size = new Size(85, 55);
            btnX2.TabIndex = 21;
            btnX2.Text = "^2";
            btnX2.TextColor = Color.Silver;
            btnX2.UseVisualStyleBackColor = false;
            btnX2.Click += Btn_Operaciones_Click;
            // 
            // btnRaiz
            // 
            btnRaiz.BackColor = Color.FromArgb(60, 60, 60);
            btnRaiz.BackgroundColor = Color.FromArgb(60, 60, 60);
            btnRaiz.BorderColor = Color.FromArgb(32, 32, 32);
            btnRaiz.BorderRadius = 10;
            btnRaiz.BorderSize = 0;
            btnRaiz.FlatAppearance.BorderSize = 0;
            btnRaiz.FlatStyle = FlatStyle.Flat;
            btnRaiz.ForeColor = Color.Silver;
            btnRaiz.Location = new Point(175, 254);
            btnRaiz.Margin = new Padding(0);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(85, 55);
            btnRaiz.TabIndex = 20;
            btnRaiz.Text = "√x";
            btnRaiz.TextColor = Color.Silver;
            btnRaiz.UseVisualStyleBackColor = false;
            btnRaiz.Click += Btn_Operaciones_Click;
            // 
            // btn1X
            // 
            btn1X.BackColor = Color.FromArgb(60, 60, 60);
            btn1X.BackgroundColor = Color.FromArgb(60, 60, 60);
            btn1X.BorderColor = Color.FromArgb(32, 32, 32);
            btn1X.BorderRadius = 10;
            btn1X.BorderSize = 0;
            btn1X.FlatAppearance.BorderSize = 0;
            btn1X.FlatStyle = FlatStyle.Flat;
            btn1X.ForeColor = Color.Silver;
            btn1X.Location = new Point(5, 254);
            btn1X.Margin = new Padding(0);
            btn1X.Name = "btn1X";
            btn1X.Size = new Size(85, 55);
            btn1X.TabIndex = 19;
            btn1X.Text = "⅟";
            btn1X.TextColor = Color.Silver;
            btn1X.UseVisualStyleBackColor = false;
            btn1X.Click += Btn_Operaciones_Click;
            // 
            // btnDividir
            // 
            btnDividir.BackColor = Color.FromArgb(60, 60, 60);
            btnDividir.BackgroundColor = Color.FromArgb(60, 60, 60);
            btnDividir.BorderColor = Color.FromArgb(32, 32, 32);
            btnDividir.BorderRadius = 10;
            btnDividir.BorderSize = 0;
            btnDividir.FlatAppearance.BorderSize = 0;
            btnDividir.FlatStyle = FlatStyle.Flat;
            btnDividir.ForeColor = Color.Silver;
            btnDividir.Location = new Point(259, 254);
            btnDividir.Margin = new Padding(0);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(85, 55);
            btnDividir.TabIndex = 18;
            btnDividir.Text = "÷";
            btnDividir.TextColor = Color.Silver;
            btnDividir.UseVisualStyleBackColor = false;
            btnDividir.Click += BtnOperador_click;
            // 
            // btnOcho
            // 
            btnOcho.BackColor = Color.FromArgb(60, 60, 60);
            btnOcho.BackgroundColor = Color.FromArgb(60, 60, 60);
            btnOcho.BorderColor = Color.FromArgb(32, 32, 32);
            btnOcho.BorderRadius = 10;
            btnOcho.BorderSize = 0;
            btnOcho.FlatAppearance.BorderSize = 0;
            btnOcho.FlatStyle = FlatStyle.Flat;
            btnOcho.ForeColor = Color.Silver;
            btnOcho.Location = new Point(90, 309);
            btnOcho.Margin = new Padding(0);
            btnOcho.Name = "btnOcho";
            btnOcho.Size = new Size(85, 55);
            btnOcho.TabIndex = 25;
            btnOcho.Text = "8";
            btnOcho.TextColor = Color.Silver;
            btnOcho.UseVisualStyleBackColor = false;
            btnOcho.Click += BtnNum_click;
            // 
            // btnNueve
            // 
            btnNueve.BackColor = Color.FromArgb(60, 60, 60);
            btnNueve.BackgroundColor = Color.FromArgb(60, 60, 60);
            btnNueve.BorderColor = Color.FromArgb(32, 32, 32);
            btnNueve.BorderRadius = 10;
            btnNueve.BorderSize = 0;
            btnNueve.FlatAppearance.BorderSize = 0;
            btnNueve.FlatStyle = FlatStyle.Flat;
            btnNueve.ForeColor = Color.Silver;
            btnNueve.Location = new Point(175, 309);
            btnNueve.Margin = new Padding(0);
            btnNueve.Name = "btnNueve";
            btnNueve.Size = new Size(85, 55);
            btnNueve.TabIndex = 24;
            btnNueve.Text = "9";
            btnNueve.TextColor = Color.Silver;
            btnNueve.UseVisualStyleBackColor = false;
            btnNueve.Click += BtnNum_click;
            // 
            // btnSiete
            // 
            btnSiete.BackColor = Color.FromArgb(60, 60, 60);
            btnSiete.BackgroundColor = Color.FromArgb(60, 60, 60);
            btnSiete.BorderColor = Color.FromArgb(32, 32, 32);
            btnSiete.BorderRadius = 10;
            btnSiete.BorderSize = 0;
            btnSiete.FlatAppearance.BorderSize = 0;
            btnSiete.FlatStyle = FlatStyle.Flat;
            btnSiete.ForeColor = Color.Silver;
            btnSiete.Location = new Point(5, 309);
            btnSiete.Margin = new Padding(0);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new Size(85, 55);
            btnSiete.TabIndex = 23;
            btnSiete.Text = "7";
            btnSiete.TextColor = Color.Silver;
            btnSiete.UseVisualStyleBackColor = false;
            btnSiete.Click += BtnNum_click;
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.BackColor = Color.FromArgb(60, 60, 60);
            btnMultiplicacion.BackgroundColor = Color.FromArgb(60, 60, 60);
            btnMultiplicacion.BorderColor = Color.FromArgb(32, 32, 32);
            btnMultiplicacion.BorderRadius = 10;
            btnMultiplicacion.BorderSize = 0;
            btnMultiplicacion.FlatAppearance.BorderSize = 0;
            btnMultiplicacion.FlatStyle = FlatStyle.Flat;
            btnMultiplicacion.ForeColor = Color.Silver;
            btnMultiplicacion.Location = new Point(260, 309);
            btnMultiplicacion.Margin = new Padding(0);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(85, 55);
            btnMultiplicacion.TabIndex = 22;
            btnMultiplicacion.Text = "X";
            btnMultiplicacion.TextColor = Color.Silver;
            btnMultiplicacion.UseVisualStyleBackColor = false;
            btnMultiplicacion.Click += BtnOperador_click;
            // 
            // btnCinco
            // 
            btnCinco.BackColor = Color.FromArgb(60, 60, 60);
            btnCinco.BackgroundColor = Color.FromArgb(60, 60, 60);
            btnCinco.BorderColor = Color.FromArgb(32, 32, 32);
            btnCinco.BorderRadius = 10;
            btnCinco.BorderSize = 0;
            btnCinco.FlatAppearance.BorderSize = 0;
            btnCinco.FlatStyle = FlatStyle.Flat;
            btnCinco.ForeColor = Color.Silver;
            btnCinco.Location = new Point(90, 364);
            btnCinco.Margin = new Padding(0);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(85, 55);
            btnCinco.TabIndex = 29;
            btnCinco.Text = "5";
            btnCinco.TextColor = Color.Silver;
            btnCinco.UseVisualStyleBackColor = false;
            btnCinco.Click += BtnNum_click;
            // 
            // btnSeia
            // 
            btnSeia.BackColor = Color.FromArgb(60, 60, 60);
            btnSeia.BackgroundColor = Color.FromArgb(60, 60, 60);
            btnSeia.BorderColor = Color.FromArgb(32, 32, 32);
            btnSeia.BorderRadius = 10;
            btnSeia.BorderSize = 0;
            btnSeia.FlatAppearance.BorderSize = 0;
            btnSeia.FlatStyle = FlatStyle.Flat;
            btnSeia.ForeColor = Color.Silver;
            btnSeia.Location = new Point(175, 364);
            btnSeia.Margin = new Padding(0);
            btnSeia.Name = "btnSeia";
            btnSeia.Size = new Size(85, 55);
            btnSeia.TabIndex = 28;
            btnSeia.Text = "6";
            btnSeia.TextColor = Color.Silver;
            btnSeia.UseVisualStyleBackColor = false;
            btnSeia.Click += BtnNum_click;
            // 
            // btnCuatro
            // 
            btnCuatro.BackColor = Color.FromArgb(60, 60, 60);
            btnCuatro.BackgroundColor = Color.FromArgb(60, 60, 60);
            btnCuatro.BorderColor = Color.FromArgb(32, 32, 32);
            btnCuatro.BorderRadius = 10;
            btnCuatro.BorderSize = 0;
            btnCuatro.FlatAppearance.BorderSize = 0;
            btnCuatro.FlatStyle = FlatStyle.Flat;
            btnCuatro.ForeColor = Color.Silver;
            btnCuatro.Location = new Point(5, 364);
            btnCuatro.Margin = new Padding(0);
            btnCuatro.Name = "btnCuatro";
            btnCuatro.Size = new Size(85, 55);
            btnCuatro.TabIndex = 27;
            btnCuatro.Text = "4";
            btnCuatro.TextColor = Color.Silver;
            btnCuatro.UseVisualStyleBackColor = false;
            btnCuatro.Click += BtnNum_click;
            // 
            // btnResta
            // 
            btnResta.BackColor = Color.FromArgb(60, 60, 60);
            btnResta.BackgroundColor = Color.FromArgb(60, 60, 60);
            btnResta.BorderColor = Color.FromArgb(32, 32, 32);
            btnResta.BorderRadius = 10;
            btnResta.BorderSize = 0;
            btnResta.FlatAppearance.BorderSize = 0;
            btnResta.FlatStyle = FlatStyle.Flat;
            btnResta.ForeColor = Color.Silver;
            btnResta.Location = new Point(260, 364);
            btnResta.Margin = new Padding(0);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(85, 55);
            btnResta.TabIndex = 26;
            btnResta.Text = "-";
            btnResta.TextColor = Color.Silver;
            btnResta.UseVisualStyleBackColor = false;
            btnResta.Click += BtnOperador_click;
            // 
            // btnDos
            // 
            btnDos.BackColor = Color.FromArgb(60, 60, 60);
            btnDos.BackgroundColor = Color.FromArgb(60, 60, 60);
            btnDos.BorderColor = Color.FromArgb(32, 32, 32);
            btnDos.BorderRadius = 10;
            btnDos.BorderSize = 0;
            btnDos.FlatAppearance.BorderSize = 0;
            btnDos.FlatStyle = FlatStyle.Flat;
            btnDos.ForeColor = Color.Silver;
            btnDos.Location = new Point(90, 419);
            btnDos.Margin = new Padding(0);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(85, 55);
            btnDos.TabIndex = 33;
            btnDos.Text = "2";
            btnDos.TextColor = Color.Silver;
            btnDos.UseVisualStyleBackColor = false;
            btnDos.Click += BtnNum_click;
            // 
            // btnTres
            // 
            btnTres.BackColor = Color.FromArgb(60, 60, 60);
            btnTres.BackgroundColor = Color.FromArgb(60, 60, 60);
            btnTres.BorderColor = Color.FromArgb(32, 32, 32);
            btnTres.BorderRadius = 10;
            btnTres.BorderSize = 0;
            btnTres.FlatAppearance.BorderSize = 0;
            btnTres.FlatStyle = FlatStyle.Flat;
            btnTres.ForeColor = Color.Silver;
            btnTres.Location = new Point(175, 419);
            btnTres.Margin = new Padding(0);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(85, 55);
            btnTres.TabIndex = 32;
            btnTres.Text = "3";
            btnTres.TextColor = Color.Silver;
            btnTres.UseVisualStyleBackColor = false;
            btnTres.Click += BtnNum_click;
            // 
            // btnUno
            // 
            btnUno.BackColor = Color.FromArgb(60, 60, 60);
            btnUno.BackgroundColor = Color.FromArgb(60, 60, 60);
            btnUno.BorderColor = Color.FromArgb(32, 32, 32);
            btnUno.BorderRadius = 10;
            btnUno.BorderSize = 0;
            btnUno.FlatAppearance.BorderSize = 0;
            btnUno.FlatStyle = FlatStyle.Flat;
            btnUno.ForeColor = Color.Silver;
            btnUno.Location = new Point(5, 419);
            btnUno.Margin = new Padding(0);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(85, 55);
            btnUno.TabIndex = 31;
            btnUno.Text = "1";
            btnUno.TextColor = Color.Silver;
            btnUno.UseVisualStyleBackColor = false;
            btnUno.Click += BtnNum_click;
            // 
            // btnSuma
            // 
            btnSuma.BackColor = Color.FromArgb(60, 60, 60);
            btnSuma.BackgroundColor = Color.FromArgb(60, 60, 60);
            btnSuma.BorderColor = Color.FromArgb(32, 32, 32);
            btnSuma.BorderRadius = 10;
            btnSuma.BorderSize = 0;
            btnSuma.FlatAppearance.BorderSize = 0;
            btnSuma.FlatStyle = FlatStyle.Flat;
            btnSuma.ForeColor = Color.Silver;
            btnSuma.Location = new Point(260, 419);
            btnSuma.Margin = new Padding(0);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(85, 55);
            btnSuma.TabIndex = 30;
            btnSuma.Text = "+";
            btnSuma.TextColor = Color.Silver;
            btnSuma.UseVisualStyleBackColor = false;
            btnSuma.Click += BtnOperador_click;
            // 
            // btnCero
            // 
            btnCero.BackColor = Color.FromArgb(60, 60, 60);
            btnCero.BackgroundColor = Color.FromArgb(60, 60, 60);
            btnCero.BorderColor = Color.FromArgb(32, 32, 32);
            btnCero.BorderRadius = 10;
            btnCero.BorderSize = 0;
            btnCero.FlatAppearance.BorderSize = 0;
            btnCero.FlatStyle = FlatStyle.Flat;
            btnCero.ForeColor = Color.Silver;
            btnCero.Location = new Point(90, 474);
            btnCero.Margin = new Padding(0);
            btnCero.Name = "btnCero";
            btnCero.Size = new Size(85, 55);
            btnCero.TabIndex = 37;
            btnCero.Text = "0";
            btnCero.TextColor = Color.Silver;
            btnCero.UseVisualStyleBackColor = false;
            btnCero.Click += BtnNum_click;
            // 
            // btnDesimal
            // 
            btnDesimal.BackColor = Color.FromArgb(60, 60, 60);
            btnDesimal.BackgroundColor = Color.FromArgb(60, 60, 60);
            btnDesimal.BorderColor = Color.FromArgb(32, 32, 32);
            btnDesimal.BorderRadius = 10;
            btnDesimal.BorderSize = 0;
            btnDesimal.FlatAppearance.BorderSize = 0;
            btnDesimal.FlatStyle = FlatStyle.Flat;
            btnDesimal.ForeColor = Color.Silver;
            btnDesimal.Location = new Point(175, 474);
            btnDesimal.Margin = new Padding(0);
            btnDesimal.Name = "btnDesimal";
            btnDesimal.Size = new Size(85, 55);
            btnDesimal.TabIndex = 36;
            btnDesimal.Text = ".";
            btnDesimal.TextColor = Color.Silver;
            btnDesimal.UseVisualStyleBackColor = false;
            btnDesimal.Click += BtnNum_click;
            // 
            // btnPM
            // 
            btnPM.BackColor = Color.FromArgb(60, 60, 60);
            btnPM.BackgroundColor = Color.FromArgb(60, 60, 60);
            btnPM.BorderColor = Color.FromArgb(32, 32, 32);
            btnPM.BorderRadius = 10;
            btnPM.BorderSize = 0;
            btnPM.FlatAppearance.BorderSize = 0;
            btnPM.FlatStyle = FlatStyle.Flat;
            btnPM.ForeColor = Color.Silver;
            btnPM.Location = new Point(5, 474);
            btnPM.Margin = new Padding(0);
            btnPM.Name = "btnPM";
            btnPM.Size = new Size(85, 55);
            btnPM.TabIndex = 35;
            btnPM.Text = "±";
            btnPM.TextColor = Color.Silver;
            btnPM.UseVisualStyleBackColor = false;
            btnPM.Click += Btn_Operaciones_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.FromArgb(128, 255, 128);
            btnIgual.BackgroundColor = Color.FromArgb(128, 255, 128);
            btnIgual.BorderColor = Color.FromArgb(32, 32, 32);
            btnIgual.BorderRadius = 10;
            btnIgual.BorderSize = 0;
            btnIgual.FlatAppearance.BorderSize = 0;
            btnIgual.FlatStyle = FlatStyle.Flat;
            btnIgual.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIgual.ForeColor = Color.Silver;
            btnIgual.Location = new Point(260, 474);
            btnIgual.Margin = new Padding(0);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(85, 55);
            btnIgual.TabIndex = 34;
            btnIgual.Text = "=";
            btnIgual.TextColor = Color.Silver;
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // bntLimpiarHistorias
            // 
            bntLimpiarHistorias.Dock = DockStyle.Bottom;
            bntLimpiarHistorias.FlatAppearance.BorderSize = 0;
            bntLimpiarHistorias.FlatStyle = FlatStyle.Flat;
            bntLimpiarHistorias.Image = (Image)resources.GetObject("bntLimpiarHistorias.Image");
            bntLimpiarHistorias.Location = new Point(0, 405);
            bntLimpiarHistorias.Margin = new Padding(0);
            bntLimpiarHistorias.Name = "bntLimpiarHistorias";
            bntLimpiarHistorias.Size = new Size(238, 40);
            bntLimpiarHistorias.TabIndex = 4;
            bntLimpiarHistorias.UseVisualStyleBackColor = true;
            bntLimpiarHistorias.Click += bntLimpiarHistorias_Click;
            // 
            // RtBoxDisplayHistory
            // 
            RtBoxDisplayHistory.AcceptsTab = true;
            RtBoxDisplayHistory.BackColor = Color.FromArgb(32, 32, 32);
            RtBoxDisplayHistory.BorderStyle = BorderStyle.None;
            RtBoxDisplayHistory.Dock = DockStyle.Fill;
            RtBoxDisplayHistory.ForeColor = Color.Silver;
            RtBoxDisplayHistory.Location = new Point(0, 0);
            RtBoxDisplayHistory.Margin = new Padding(0);
            RtBoxDisplayHistory.Name = "RtBoxDisplayHistory";
            RtBoxDisplayHistory.ScrollBars = RichTextBoxScrollBars.Horizontal;
            RtBoxDisplayHistory.Size = new Size(238, 405);
            RtBoxDisplayHistory.TabIndex = 9;
            RtBoxDisplayHistory.Text = "";
            RtBoxDisplayHistory.TextChanged += RtBoxDisplayHistory_TextChanged;
            // 
            // pnlHistorial
            // 
            pnlHistorial.Controls.Add(RtBoxDisplayHistory);
            pnlHistorial.Controls.Add(bntLimpiarHistorias);
            pnlHistorial.ForeColor = Color.Silver;
            pnlHistorial.Location = new Point(348, 84);
            pnlHistorial.Name = "pnlHistorial";
            pnlHistorial.Size = new Size(238, 445);
            pnlHistorial.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(586, 539);
            Controls.Add(btnCero);
            Controls.Add(btnDesimal);
            Controls.Add(btnPM);
            Controls.Add(btnIgual);
            Controls.Add(btnDos);
            Controls.Add(btnTres);
            Controls.Add(btnUno);
            Controls.Add(btnSuma);
            Controls.Add(btnCinco);
            Controls.Add(btnSeia);
            Controls.Add(btnCuatro);
            Controls.Add(btnResta);
            Controls.Add(btnOcho);
            Controls.Add(btnNueve);
            Controls.Add(btnSiete);
            Controls.Add(btnMultiplicacion);
            Controls.Add(btnX2);
            Controls.Add(btnRaiz);
            Controls.Add(btn1X);
            Controls.Add(btnDividir);
            Controls.Add(btnCE);
            Controls.Add(btnC);
            Controls.Add(btnPorcentaje);
            Controls.Add(btnBorrar);
            Controls.Add(textdisplay1);
            Controls.Add(textdisplay2);
            Controls.Add(panel1);
            Controls.Add(pnlHistorial);
            Controls.Add(pnltitulo);
            Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            pnltitulo.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlHistorial.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnltitulo;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Button button5;
        private TextBox textdisplay2;
        private TextBox textdisplay1;
        private ContextMenuStrip contextMenuStrip1;
        private CustomControls.RJControls.RJButton btnBorrar;
        private CustomControls.RJControls.RJButton btnPorcentaje;
        private CustomControls.RJControls.RJButton btnC;
        private CustomControls.RJControls.RJButton btnCE;
        private CustomControls.RJControls.RJButton btnX2;
        private CustomControls.RJControls.RJButton btnRaiz;
        private CustomControls.RJControls.RJButton btn1X;
        private CustomControls.RJControls.RJButton btnDividir;
        private CustomControls.RJControls.RJButton btnOcho;
        private CustomControls.RJControls.RJButton btnNueve;
        private CustomControls.RJControls.RJButton btnSiete;
        private CustomControls.RJControls.RJButton btnMultiplicacion;
        private CustomControls.RJControls.RJButton btnCinco;
        private CustomControls.RJControls.RJButton btnSeia;
        private CustomControls.RJControls.RJButton btnCuatro;
        private CustomControls.RJControls.RJButton btnResta;
        private CustomControls.RJControls.RJButton btnDos;
        private CustomControls.RJControls.RJButton btnTres;
        private CustomControls.RJControls.RJButton btnUno;
        private CustomControls.RJControls.RJButton btnSuma;
        private CustomControls.RJControls.RJButton btnCero;
        private CustomControls.RJControls.RJButton btnDesimal;
        private CustomControls.RJControls.RJButton btnPM;
        private CustomControls.RJControls.RJButton btnIgual;
        private Button bntLimpiarHistorias;
        private RichTextBox RtBoxDisplayHistory;
        private Panel pnlHistorial;
        private Label label1;
        private Button btnHistorial;
        private Label label2;
    }
}
