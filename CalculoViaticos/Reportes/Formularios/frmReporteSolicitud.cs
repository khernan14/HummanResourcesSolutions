﻿using CalculoViaticos.Reportes.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoViaticos.Reportes.Formularios
{
    public partial class frmReporteSolicitud : Form
    {
        public List<DatosSolicitud> datosSolicitud = new List<DatosSolicitud>();
        public frmReporteSolicitud()
        {
            InitializeComponent();
        }

        private void frmReporteSolicitud_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", datosSolicitud));
            this.reportViewer1.RefreshReport();
        }
    }
}
