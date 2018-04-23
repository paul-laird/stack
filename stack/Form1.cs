﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stack
{
    public partial class Form1 : Form
    {
        NodeStack s;
        //StackOfInt s;
        public Form1()
        {
            s = new NodeStack();  //new StackOfInt(10);
            InitializeComponent();
        }

        private void Push_Click(object sender, EventArgs e)
        {
            s.push(int.Parse(Input.Text));
        }

        private void Pop_Click(object sender, EventArgs e)
        {
            Output.Text = "" + s.pop();
        }
    }
}
