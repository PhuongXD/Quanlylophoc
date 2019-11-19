﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class UpdateClassFrom : Form
    {
        private int ClassId;
        private ClassManagement Business;
        public UpdateClassFrom(int id)
        {
            InitializeComponent();
            this.ClassId = id;
            this.Business = new ClassManagement();
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;
            this.Load += UpdateClassFrom_Load;
        }

        void UpdateClassFrom_Load(object sender, EventArgs e)
        {
            var @class = this.Business.GetClass(this.ClassId);
            this.txtName.Text = @class.Name;
            this.txtDescription.Text = @class.Description;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var name = this.txtName.Text;
            var description = this.txtDescription.Text;
            this.Business.EditClass(this.ClassId, name, description);
            MessageBox.Show("Update class successfully");
            this.Close();
        }
    }
}
