
namespace Radiales
{
    partial class Radiales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Radiales));
            this.PnContenido = new System.Windows.Forms.Panel();
            this.PnPresentacion = new System.Windows.Forms.Panel();
            this.BtnReiniciar = new System.Windows.Forms.Button();
            this.BtnPausa = new System.Windows.Forms.Button();
            this.BtnSimulation = new System.Windows.Forms.Button();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.NbError = new System.Windows.Forms.NumericUpDown();
            this.NbRadiales = new System.Windows.Forms.NumericUpDown();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LbSalidas = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LbPatrones = new System.Windows.Forms.Label();
            this.LbEntrada = new System.Windows.Forms.Label();
            this.Label54 = new System.Windows.Forms.Label();
            this.fff = new System.Windows.Forms.Label();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.PnPresentacion.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NbError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbRadiales)).BeginInit();
            this.SuspendLayout();
            // 
            // PnContenido
            // 
            this.PnContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.PnContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnContenido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PnContenido.Location = new System.Drawing.Point(213, 107);
            this.PnContenido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnContenido.Name = "PnContenido";
            this.PnContenido.Size = new System.Drawing.Size(758, 478);
            this.PnContenido.TabIndex = 9;
            // 
            // PnPresentacion
            // 
            this.PnPresentacion.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.PnPresentacion.Controls.Add(this.BtnPausa);
            this.PnPresentacion.Controls.Add(this.BtnIniciar);
            this.PnPresentacion.Controls.Add(this.BtnSave);
            this.PnPresentacion.Controls.Add(this.BtnOpen);
            this.PnPresentacion.Controls.Add(this.label1);
            this.PnPresentacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnPresentacion.ForeColor = System.Drawing.Color.Transparent;
            this.PnPresentacion.Location = new System.Drawing.Point(0, 0);
            this.PnPresentacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnPresentacion.Name = "PnPresentacion";
            this.PnPresentacion.Size = new System.Drawing.Size(971, 107);
            this.PnPresentacion.TabIndex = 7;
            // 
            // BtnReiniciar
            // 
            this.BtnReiniciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnReiniciar.BackgroundImage")));
            this.BtnReiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReiniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.BtnReiniciar.FlatAppearance.BorderSize = 0;
            this.BtnReiniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnReiniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.BtnReiniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnReiniciar.Location = new System.Drawing.Point(22, 401);
            this.BtnReiniciar.Name = "BtnReiniciar";
            this.BtnReiniciar.Size = new System.Drawing.Size(35, 35);
            this.BtnReiniciar.TabIndex = 59;
            this.BtnReiniciar.UseVisualStyleBackColor = true;
            this.BtnReiniciar.Click += new System.EventHandler(this.Reset);
            // 
            // BtnPausa
            // 
            this.BtnPausa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPausa.BackgroundImage")));
            this.BtnPausa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPausa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPausa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.BtnPausa.FlatAppearance.BorderSize = 0;
            this.BtnPausa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnPausa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnPausa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.BtnPausa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnPausa.Location = new System.Drawing.Point(904, 37);
            this.BtnPausa.Name = "BtnPausa";
            this.BtnPausa.Size = new System.Drawing.Size(35, 35);
            this.BtnPausa.TabIndex = 22;
            this.BtnPausa.UseVisualStyleBackColor = true;
            this.BtnPausa.Click += new System.EventHandler(this.BtnPausa_Click);
            // 
            // BtnSimulation
            // 
            this.BtnSimulation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSimulation.BackgroundImage")));
            this.BtnSimulation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSimulation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSimulation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.BtnSimulation.FlatAppearance.BorderSize = 0;
            this.BtnSimulation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnSimulation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnSimulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSimulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.BtnSimulation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnSimulation.Location = new System.Drawing.Point(147, 401);
            this.BtnSimulation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSimulation.Name = "BtnSimulation";
            this.BtnSimulation.Size = new System.Drawing.Size(35, 35);
            this.BtnSimulation.TabIndex = 13;
            this.BtnSimulation.UseVisualStyleBackColor = true;
            this.BtnSimulation.Click += new System.EventHandler(this.Simular);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnIniciar.BackgroundImage")));
            this.BtnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.BtnIniciar.FlatAppearance.BorderSize = 0;
            this.BtnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.BtnIniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnIniciar.Location = new System.Drawing.Point(907, 36);
            this.BtnIniciar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(35, 35);
            this.BtnIniciar.TabIndex = 15;
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.Training);
            // 
            // BtnSave
            // 
            this.BtnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSave.BackgroundImage")));
            this.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.BtnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnSave.Location = new System.Drawing.Point(840, 37);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(35, 35);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnOpen
            // 
            this.BtnOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnOpen.BackgroundImage")));
            this.BtnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.BtnOpen.FlatAppearance.BorderSize = 0;
            this.BtnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(144)))), ((int)(((byte)(166)))));
            this.BtnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.BtnOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnOpen.Location = new System.Drawing.Point(772, 36);
            this.BtnOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(35, 35);
            this.BtnOpen.TabIndex = 10;
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 34F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Funciones de base radial";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel7.Controls.Add(this.BtnReiniciar);
            this.panel7.Controls.Add(this.BtnSimulation);
            this.panel7.Controls.Add(this.NbError);
            this.panel7.Controls.Add(this.NbRadiales);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.LbSalidas);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.LbPatrones);
            this.panel7.Controls.Add(this.LbEntrada);
            this.panel7.Controls.Add(this.Label54);
            this.panel7.Controls.Add(this.fff);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 107);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(213, 478);
            this.panel7.TabIndex = 10;
            // 
            // NbError
            // 
            this.NbError.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.NbError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NbError.DecimalPlaces = 3;
            this.NbError.Font = new System.Drawing.Font("Arial", 9.75F);
            this.NbError.ForeColor = System.Drawing.Color.White;
            this.NbError.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.NbError.Location = new System.Drawing.Point(112, 64);
            this.NbError.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NbError.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NbError.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.NbError.Name = "NbError";
            this.NbError.Size = new System.Drawing.Size(59, 18);
            this.NbError.TabIndex = 37;
            this.NbError.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.NbError.ValueChanged += new System.EventHandler(this.GlChange);
            // 
            // NbRadiales
            // 
            this.NbRadiales.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.NbRadiales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NbRadiales.Font = new System.Drawing.Font("Arial", 9.75F);
            this.NbRadiales.ForeColor = System.Drawing.Color.White;
            this.NbRadiales.Location = new System.Drawing.Point(112, 125);
            this.NbRadiales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NbRadiales.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NbRadiales.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NbRadiales.Name = "NbRadiales";
            this.NbRadiales.Size = new System.Drawing.Size(56, 18);
            this.NbRadiales.TabIndex = 36;
            this.NbRadiales.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NbRadiales.ValueChanged += new System.EventHandler(this.RdChange);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.panel6.Location = new System.Drawing.Point(112, 147);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(56, 1);
            this.panel6.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label6.Location = new System.Drawing.Point(32, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Radiales:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.panel5.Location = new System.Drawing.Point(112, 86);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(60, 1);
            this.panel5.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label4.Location = new System.Drawing.Point(32, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Goal:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel4.Location = new System.Drawing.Point(566, 10);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 20);
            this.panel4.TabIndex = 21;
            // 
            // LbSalidas
            // 
            this.LbSalidas.AutoSize = true;
            this.LbSalidas.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LbSalidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LbSalidas.Location = new System.Drawing.Point(109, 292);
            this.LbSalidas.Name = "LbSalidas";
            this.LbSalidas.Size = new System.Drawing.Size(15, 16);
            this.LbSalidas.TabIndex = 20;
            this.LbSalidas.Text = "#";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label13.Location = new System.Drawing.Point(32, 292);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Salidas:";
            // 
            // LbPatrones
            // 
            this.LbPatrones.AutoSize = true;
            this.LbPatrones.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LbPatrones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LbPatrones.Location = new System.Drawing.Point(109, 241);
            this.LbPatrones.Name = "LbPatrones";
            this.LbPatrones.Size = new System.Drawing.Size(15, 16);
            this.LbPatrones.TabIndex = 17;
            this.LbPatrones.Text = "#";
            // 
            // LbEntrada
            // 
            this.LbEntrada.AutoSize = true;
            this.LbEntrada.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LbEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LbEntrada.Location = new System.Drawing.Point(109, 185);
            this.LbEntrada.Name = "LbEntrada";
            this.LbEntrada.Size = new System.Drawing.Size(15, 16);
            this.LbEntrada.TabIndex = 16;
            this.LbEntrada.Text = "#";
            // 
            // Label54
            // 
            this.Label54.AutoSize = true;
            this.Label54.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Label54.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Label54.Location = new System.Drawing.Point(32, 241);
            this.Label54.Name = "Label54";
            this.Label54.Size = new System.Drawing.Size(64, 16);
            this.Label54.TabIndex = 14;
            this.Label54.Text = "Patrones:";
            // 
            // fff
            // 
            this.fff.AutoSize = true;
            this.fff.Font = new System.Drawing.Font("Arial", 9.75F);
            this.fff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.fff.Location = new System.Drawing.Point(32, 185);
            this.fff.Name = "fff";
            this.fff.Size = new System.Drawing.Size(64, 16);
            this.fff.TabIndex = 13;
            this.fff.Text = "Entradas:";
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // Radiales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 585);
            this.Controls.Add(this.PnContenido);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.PnPresentacion);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Radiales";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radiales";
            this.PnPresentacion.ResumeLayout(false);
            this.PnPresentacion.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NbError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbRadiales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnContenido;
        private System.Windows.Forms.Panel PnPresentacion;
        private System.Windows.Forms.Button BtnSimulation;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label LbSalidas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LbPatrones;
        private System.Windows.Forms.Label LbEntrada;
        private System.Windows.Forms.Label Label54;
        private System.Windows.Forms.Label fff;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.NumericUpDown NbRadiales;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown NbError;
        private System.Windows.Forms.Button BtnPausa;
        private System.Windows.Forms.Button BtnReiniciar;
    }
}