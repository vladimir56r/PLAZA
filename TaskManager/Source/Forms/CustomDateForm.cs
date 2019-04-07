﻿using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TaskManager.Source.Data;

namespace TaskManager.Source.Forms {
    public partial class CustomDateForm : XtraForm {
        Task currentTask;
        public CustomDateForm() {
            InitializeComponent();
        }
        public CustomDateForm(Task task) {
            InitializeComponent();
            this.currentTask = task;
            if(task.StartDate.HasValue)
                dateEdit1.DateTime = task.StartDate.Value;
            if(task.DueDate.HasValue)
                dateEdit2.DateTime = task.DueDate.Value;
        }
        protected override void OnClosing(CancelEventArgs e) {
            base.OnClosing(e);
            if(DialogResult == DialogResult.OK) {
                if(dateEdit1.DateTime > DateTime.MinValue)
                    currentTask.StartDate = dateEdit1.DateTime;
                else currentTask.StartDate = null;
                if(dateEdit2.DateTime > DateTime.MinValue)
                    currentTask.DueDate = dateEdit2.DateTime;
                else currentTask.DueDate = null;
            }
        }
    }
}
