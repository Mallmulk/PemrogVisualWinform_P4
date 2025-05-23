﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ntahlah
{
    public partial class FormStart : Form
    {
        private string _username;

        public FormStart(string username)
        {
            InitializeComponent();
            _username = username;
            label1.Text = $"Selamat datang di quiz, {_username}!";
        }

        private void btnMulai_Click(object sender, EventArgs e)
        {
            FormQuiz quiz = new FormQuiz(_username);
            this.Hide();
            quiz.Show();
        }
    }
}
