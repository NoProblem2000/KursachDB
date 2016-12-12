using System;
using System.Windows.Forms;


namespace KursachDB
{
    public partial class ItemsReport : Form
    {
        
        public ItemsReport( )
        {
            InitializeComponent();
            InitializeReport();
        }

        private void InitializeReport()
        {
            //ReportDocument cryRpt = new ReportDocument();
            //cryRpt.Load(@"C:\Users\Гость\Documents\Visual Studio 2010\Projects\KursachDB\KursachDB\CrystalReport1.rpt");

            //ParameterFieldDefinitions crParameterFieldDefinitions;
            //ParameterFieldDefinition crParameterFieldDefinition;
            //ParameterValues crParameterValues = new ParameterValues();
            //ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            //crParameterDiscreteValue.Value = nameGame;
            //crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            //crParameterFieldDefinition = crParameterFieldDefinitions["nameGame"];
            //crParameterValues = crParameterFieldDefinition.CurrentValues;

            //crParameterValues.Clear();
            //crParameterValues.Add(crParameterDiscreteValue);
            //crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

           crystalReportViewer1.ReportSource = CrystalReport11;
           crystalReportViewer1.Refresh();
            
            
            
        }
       
    }
}
