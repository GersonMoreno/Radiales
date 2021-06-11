
namespace Radiales
{
    partial class Generalizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generalizador));
            this.LbPath = new System.Windows.Forms.Label();
            this.LbError = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LbPatrones = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.BtnIniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LbPath
            // 
            this.LbPath.AutoSize = true;
            this.LbPath.BackColor = System.Drawing.SystemColors.Control;
            this.LbPath.Font = new System.Drawing.Font("Arial", 10F);
            this.LbPath.ForeColor = System.Drawing.Color.Black;
            this.LbPath.Location = new System.Drawing.Point(92, 72);
            this.LbPath.Name = "LbPath";
            this.LbPath.Size = new System.Drawing.Size(16, 16);
            this.LbPath.TabIndex = 47;
            this.LbPath.Text = "#";
            this.LbPath.Visible = false;
            // 
            // LbError
            // 
            this.LbError.AutoSize = true;
            this.LbError.BackColor = System.Drawing.SystemColors.Control;
            this.LbError.Font = new System.Drawing.Font("Arial", 10F);
            this.LbError.ForeColor = System.Drawing.Color.Black;
            this.LbError.Location = new System.Drawing.Point(151, 96);
            this.LbError.Name = "LbError";
            this.LbError.Size = new System.Drawing.Size(16, 16);
            this.LbError.TabIndex = 40;
            this.LbError.Text = "#";
            this.LbError.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(45, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Error logrado: ";
            this.label5.Visible = false;
            // 
            // LbPatrones
            // 
            this.LbPatrones.AutoSize = true;
            this.LbPatrones.BackColor = System.Drawing.SystemColors.Control;
            this.LbPatrones.Font = new System.Drawing.Font("Arial", 10F);
            this.LbPatrones.ForeColor = System.Drawing.Color.Black;
            this.LbPatrones.Location = new System.Drawing.Point(198, 122);
            this.LbPatrones.Name = "LbPatrones";
            this.LbPatrones.Size = new System.Drawing.Size(16, 16);
            this.LbPatrones.TabIndex = 38;
            this.LbPatrones.Text = "#";
            this.LbPatrones.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(45, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Patrones cargados: ";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Path: ";
            this.label1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(48, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 305);
            this.dataGridView1.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(44, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 37);
            this.label6.TabIndex = 33;
            this.label6.Text = "Generalizar";
            this.label6.Click += new System.EventHandler(this.Start);
            // 
            // OFD
            // 
            this.OFD.Filter = "Archivo XML (*.XML)|*.XML";
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
            this.BtnIniciar.Location = new System.Drawing.Point(863, 114);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(40, 39);
            this.BtnIniciar.TabIndex = 34;
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Visible = false;
            this.BtnIniciar.Click += new System.EventHandler(this.Start);
            // 
            // Generalizador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(971, 440);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LbPath);
            this.Controls.Add(this.LbError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LbPatrones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Generalizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Generalizador";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbPath;
        private System.Windows.Forms.Label LbError;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LbPatrones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog OFD;
    }
}