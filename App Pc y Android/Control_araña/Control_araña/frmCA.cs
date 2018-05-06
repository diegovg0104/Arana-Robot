using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace Control_araña
{
    public partial class frmControl_Araña : Form
    {
        
         System.IO.Ports.SerialPort Arduinoport;

        public frmControl_Araña()
        {
            InitializeComponent();
           


        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int N1;
            N1 = 0;
            try
            {
              

                Arduinoport = new System.IO.Ports.SerialPort();
                Arduinoport.PortName = "COM9";
                Arduinoport.BaudRate = 9600;
                Arduinoport.Open();
            }

            catch (Exception)
            {
                MessageBox.Show("Error de conexion");
                N1 = 1;
                
            }


            if (N1 == 1)
            {
                MessageBox.Show("El dispositivo no esta enlazado " + System.Environment.NewLine + "Conecte su dispositivo");


            }
            else
            {
                this.btndes.MouseDown += btndes_Click;
                this.btnup.MouseDown += btnup_Click;
                this.btnr.MouseDown += btnr_Click;
                this.btnd.MouseDown += btnd_Click;
                this.btnl.MouseDown += btnl_Click;
                this.btnstop.MouseDown += btnstop_Click;
                this.btna.MouseDown += btna_Click;
                this.btnt.MouseDown += btnt_Click;
                this.btngr.MouseDown += btngr_Click;
                this.btnsm.MouseDown += btnsm_Click;
                this.btngl.MouseDown += btngl_Click;

                this.btndes.Enabled = true;
                this.btnup.Enabled = true;
                this.btnr.Enabled = true;
                this.btnd.Enabled = true;
                this.btnl.Enabled = true;
                this.btnstop.Enabled = true;
                this.btna.Enabled = true;
                this.btnt.Enabled = true;
                this.btngr.Enabled = true;
                this.btnsm.Enabled = true;
                this.btngl.Enabled = true;
            }
        
            
        
        }
        

        private void btndes_Click(object sender, EventArgs e)
        {
        Arduinoport.Close();
        this.btndes.Enabled = false;
        this.btnup.Enabled = false;
        this.btnr.Enabled = false;
        this.btnd.Enabled = false;
        this.btnl.Enabled = false;
        this.btnstop.Enabled = false;
        this.btna.Enabled = false;
        this.btnt.Enabled = false;
        this.btngr.Enabled = false;
        this.btnsm.Enabled = false;
        this.btngl.Enabled = false;
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            Arduinoport.Write("a");
        }

        private void btnr_Click(object sender, EventArgs e)
        {
            Arduinoport.Write("d");
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            Arduinoport.Write("b");
        }

        private void btnl_Click(object sender, EventArgs e)
        {
            Arduinoport.Write("c");
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            Arduinoport.Write("g");
        }

        private void btna_Click(object sender, EventArgs e)
        {
            Arduinoport.Write("f");
            

        }

        private void btnt_Click(object sender, EventArgs e)
        {
            Arduinoport.Write("i");
        }

        private void btngr_Click(object sender, EventArgs e)
        {
            Arduinoport.Write("e");
        }

        private void btnsm_Click(object sender, EventArgs e)
        {
            Arduinoport.Write("j");
        }

        private void btngl_Click(object sender, EventArgs e)
        {
            Arduinoport.Write("h");
        }
     
        

        }
    }

