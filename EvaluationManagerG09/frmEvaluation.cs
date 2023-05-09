using Evaluation_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager {
    public partial class frmEvaluation : Form {
        public frmEvaluation() {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) {

        }

        private void frmEvaluation_Load(object sender, EventArgs e) {

        }

        private void cboActivities_SelectedIndexChanged(object sender, EventArgs e) {
            var currentActivity = cboActivities.SelectedItem as Activity;
            txtActivityDescription.Text = currentActivity.Description;
            txtMinForGrade.Text = currentActivity.MinPointsForGrade + "/" + currentActivity.MaxPoints;
            txtMinForSignature = currentActivity.MinPointsForSignature + "/" + currentActivity.MaxPoints;
            numPoints.Minimum = 0;
            numPoints.Maximum = currentActivity.MaxPoints;
    }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
