﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = "";
            nombre = txtMsg.Text;
            lblMsg.Text = "Bienvenido a la P.O.E " + nombre;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtMsg.Clear();
        }
    }
}
