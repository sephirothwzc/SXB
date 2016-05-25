﻿using SXB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SXB.SQLiteDemo
{

    public partial class EditEmployee : ContentPage
    {
        Employee mSelEmployee;

        public EditEmployee()
        {
            InitializeComponent();
        }
        public EditEmployee(Employee aSelectedEmp) 
        {
            InitializeComponent();
            mSelEmployee = aSelectedEmp;
            BindingContext = mSelEmployee;
        }

        public void OnSaveClicked(object sender, EventArgs args)
        {
            mSelEmployee.EmpName = txtEmpName.Text;
            mSelEmployee.Department = txtDepartment.Text;
            mSelEmployee.Designation = txtDesign.Text;
            mSelEmployee.Qualification = txtQualification.Text;
            App.DAUtil.EditEmployee(mSelEmployee);
            Navigation.PushAsync(new ManageEmployee());
        }
    }
}
