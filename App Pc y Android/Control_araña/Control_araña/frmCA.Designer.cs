namespace Control_araña
{
    partial class frmControl_Araña
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControl_Araña));
            this.btnstop = new System.Windows.Forms.Button();
            this.btna = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btndes = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btngr = new System.Windows.Forms.Button();
            this.btnsm = new System.Windows.Forms.Button();
            this.btngl = new System.Windows.Forms.Button();
            this.btnt = new System.Windows.Forms.Button();
            this.btnd = new System.Windows.Forms.Button();
            this.btnl = new System.Windows.Forms.Button();
            this.btnr = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.btnsalu = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnstop
            // 
            this.btnstop.BackColor = System.Drawing.Color.Red;
            this.btnstop.Enabled = false;
            this.btnstop.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnstop.Location = new System.Drawing.Point(138, 265);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(88, 28);
            this.btnstop.TabIndex = 0;
            this.btnstop.Text = "STOP";
            this.btnstop.UseVisualStyleBackColor = false;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btna
            // 
            this.btna.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btna.Enabled = false;
            this.btna.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btna.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btna.Location = new System.Drawing.Point(268, 268);
            this.btna.Name = "btna";
            this.btna.Size = new System.Drawing.Size(89, 25);
            this.btna.TabIndex = 1;
            this.btna.Text = "AUTO";
            this.btna.UseVisualStyleBackColor = false;
            this.btna.Click += new System.EventHandler(this.btna_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape3,
            this.rectangleShape1,
            this.rectangleShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(500, 305);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape3.Location = new System.Drawing.Point(112, 254);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(272, 51);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.Location = new System.Drawing.Point(267, 86);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(188, 148);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape2.Location = new System.Drawing.Point(42, 86);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(182, 148);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.minimizarToolStripMenuItem,
            this.conectarToolStripMenuItem,
            this.btndes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.salirToolStripMenuItem.Text = "Salir ";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // minimizarToolStripMenuItem
            // 
            this.minimizarToolStripMenuItem.Name = "minimizarToolStripMenuItem";
            this.minimizarToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.minimizarToolStripMenuItem.Text = "Minimizar";
            this.minimizarToolStripMenuItem.Click += new System.EventHandler(this.minimizarToolStripMenuItem_Click);
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.conectarToolStripMenuItem.Text = "Conectar";
            this.conectarToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
            // 
            // btndes
            // 
            this.btndes.Enabled = false;
            this.btndes.Name = "btndes";
            this.btndes.Size = new System.Drawing.Size(84, 20);
            this.btndes.Text = "Desconectar";
            this.btndes.Click += new System.EventHandler(this.btndes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Araña Robot PC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Creado por Diego Vargas Gonzalez    V 1.0";
            // 
            // btngr
            // 
            this.btngr.BackgroundImage = global::Control_araña.Properties.Resources.gir_dert;
            this.btngr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngr.Enabled = false;
            this.btngr.Location = new System.Drawing.Point(396, 139);
            this.btngr.Name = "btngr";
            this.btngr.Size = new System.Drawing.Size(47, 41);
            this.btngr.TabIndex = 9;
            this.btngr.UseVisualStyleBackColor = true;
            this.btngr.Click += new System.EventHandler(this.btngr_Click);
            // 
            // btnsm
            // 
            this.btnsm.BackgroundImage = global::Control_araña.Properties.Resources.bajar;
            this.btnsm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsm.Enabled = false;
            this.btnsm.Location = new System.Drawing.Point(345, 185);
            this.btnsm.Name = "btnsm";
            this.btnsm.Size = new System.Drawing.Size(45, 41);
            this.btnsm.TabIndex = 8;
            this.btnsm.UseVisualStyleBackColor = true;
            this.btnsm.Click += new System.EventHandler(this.btnsm_Click);
            // 
            // btngl
            // 
            this.btngl.BackgroundImage = global::Control_araña.Properties.Resources.gir_izq;
            this.btngl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngl.Enabled = false;
            this.btngl.Location = new System.Drawing.Point(292, 139);
            this.btngl.Name = "btngl";
            this.btngl.Size = new System.Drawing.Size(47, 41);
            this.btngl.TabIndex = 7;
            this.btngl.UseVisualStyleBackColor = true;
            this.btngl.Click += new System.EventHandler(this.btngl_Click);
            // 
            // btnt
            // 
            this.btnt.BackgroundImage = global::Control_araña.Properties.Resources.subir;
            this.btnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnt.Enabled = false;
            this.btnt.Location = new System.Drawing.Point(345, 95);
            this.btnt.Name = "btnt";
            this.btnt.Size = new System.Drawing.Size(45, 41);
            this.btnt.TabIndex = 6;
            this.btnt.UseVisualStyleBackColor = true;
            this.btnt.Click += new System.EventHandler(this.btnt_Click);
            // 
            // btnd
            // 
            this.btnd.BackgroundImage = global::Control_araña.Properties.Resources.down;
            this.btnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnd.Enabled = false;
            this.btnd.Location = new System.Drawing.Point(112, 185);
            this.btnd.Name = "btnd";
            this.btnd.Size = new System.Drawing.Size(47, 41);
            this.btnd.TabIndex = 5;
            this.btnd.UseVisualStyleBackColor = true;
            this.btnd.Click += new System.EventHandler(this.btnd_Click);
            // 
            // btnl
            // 
            this.btnl.BackgroundImage = global::Control_araña.Properties.Resources.izq;
            this.btnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnl.Enabled = false;
            this.btnl.Location = new System.Drawing.Point(61, 139);
            this.btnl.Name = "btnl";
            this.btnl.Size = new System.Drawing.Size(47, 41);
            this.btnl.TabIndex = 4;
            this.btnl.UseVisualStyleBackColor = true;
            this.btnl.Click += new System.EventHandler(this.btnl_Click);
            // 
            // btnr
            // 
            this.btnr.BackgroundImage = global::Control_araña.Properties.Resources.der;
            this.btnr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnr.Enabled = false;
            this.btnr.Location = new System.Drawing.Point(163, 139);
            this.btnr.Name = "btnr";
            this.btnr.Size = new System.Drawing.Size(47, 41);
            this.btnr.TabIndex = 3;
            this.btnr.UseVisualStyleBackColor = true;
            this.btnr.Click += new System.EventHandler(this.btnr_Click);
            // 
            // btnup
            // 
            this.btnup.BackgroundImage = global::Control_araña.Properties.Resources.up;
            this.btnup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnup.Enabled = false;
            this.btnup.Location = new System.Drawing.Point(112, 95);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(47, 41);
            this.btnup.TabIndex = 2;
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // btnsalu
            // 
            this.btnsalu.Image = global::Control_araña.Properties.Resources.sal;
            this.btnsalu.Location = new System.Drawing.Point(345, 139);
            this.btnsalu.Name = "btnsalu";
            this.btnsalu.Size = new System.Drawing.Size(45, 40);
            this.btnsalu.TabIndex = 14;
            this.btnsalu.UseVisualStyleBackColor = true;
            this.btnsalu.Click += new System.EventHandler(this.btnsalu_Click);
            // 
            // frmControl_Araña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(500, 305);
            this.ControlBox = false;
            this.Controls.Add(this.btnsalu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btngr);
            this.Controls.Add(this.btnsm);
            this.Controls.Add(this.btngl);
            this.Controls.Add(this.btnt);
            this.Controls.Add(this.btnd);
            this.Controls.Add(this.btnl);
            this.Controls.Add(this.btnr);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.btna);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmControl_Araña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Araña Robot ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btna;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btnr;
        private System.Windows.Forms.Button btnl;
        private System.Windows.Forms.Button btnd;
        private System.Windows.Forms.Button btnt;
        private System.Windows.Forms.Button btngl;
        private System.Windows.Forms.Button btnsm;
        private System.Windows.Forms.Button btngr;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizarToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btndes;
        private System.Windows.Forms.Button btnsalu;
    }
}

