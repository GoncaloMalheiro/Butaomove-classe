﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Butaomove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Class1 Classe = new Class1();

        private void Button1_Click(object sender, EventArgs e)
        {
            Classe.Move(sender);
        }
    }
}
