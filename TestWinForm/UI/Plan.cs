﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWinForm.UI
{
    public partial class Plan : Form
    {
        public Plan()
        {
            InitializeComponent();
            dataGridView1.DataSource = NetworkService.GetMajorCourses();
        }
    }
}
