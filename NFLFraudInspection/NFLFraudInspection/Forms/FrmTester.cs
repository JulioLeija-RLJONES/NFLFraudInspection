using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NFLFraudInspection.Forms
{
    public partial class FrmTester : Form
    {

        FraudInspectionDb Db = new FraudInspectionDb();
        private int PSUResult = 0, MagnetResult = 1, BScreenResult = 2, XrayResult = 3;

        //private string[] Result = { String.Empty,// PSU Test result
        //                            String.Empty,// Magnet Test result
        //                            String.Empty,// BlueScreen Test result
        //                            String.Empty};// Xray Test result
        private InspectionResult[] Result = { InspectionResult.NONE,// PSU Test result
                                                InspectionResult.NONE,// Magnet Test result
                                                InspectionResult.NONE,// BlueScreen Test result
                                                InspectionResult.NONE};// Xray Test result

        public FrmTester()
        {
            InitializeComponent();
        }
        public enum InspectionResult
        {
            NONE,
            FAIL,
            PASS,
            BYPASS
        }

        private void FrmTester_Load(object sender, EventArgs e)
        {
            MsgTypes.printme("scan serial number to start fraud tests.", this);
        }


        #region Logic
        private void SNScannedAction()
        {
            // 1. When serial number is scanned pull latest Fraud Tracker data.
            FraudTracker fraudData = Db.GetFraudTracker(GetSerialNumber());
            // 2. Populate data into GUI.



        }
        private void SetFormValues(FraudTracker data)
        {
            SetPSUTestResult(data);
            SetMagnetResult(data);
            SetBlueScreenResult(data);
            SetXrayResult(data);
        }
        private InspectionResult ParseResult(string result)
        {
            InspectionResult parsed= InspectionResult.NONE;
            switch (result)
            {
                case "PASS":
                    parsed = InspectionResult.PASS;
                    break;
                case "FAIL":
                    parsed = InspectionResult.FAIL;
                    break;
                case "BYPASS":
                    parsed = InspectionResult.BYPASS;
                    break;
            }
            return parsed;
        }
        #endregion

        #region Controls
        private string GetSerialNumber()
        {
            return textBoxSN.Text;
        }
        private void textBoxSN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }
        private void SetPSUTestResult(FraudTracker data) 
        {
            if (data.PSUTest != "")
                Result[PSUResult] = ParseResult(data.PSUTest);
        }
        private void SetMagnetResult(FraudTracker data)
        {
            if (data.MagnetTest != "")
                Result[MagnetResult] = ParseResult(data.MagnetTest);
        }
        private void SetBlueScreenResult(FraudTracker data)
        {
            if (data.BlueScreenInspection != "")
            {
                Result[BScreenResult] = ParseResult(data.BlueScreenInspection);
            }
        }
        private void SetXrayResult(FraudTracker data)
        {
            if (data.XrayTest != "")
                Result[XrayResult] = ParseResult(data.XrayTest);
        }

        private void RadPSUPass_CheckedChanged(object sender, EventArgs e)
        {
            Result[PSUResult] = InspectionResult.PASS;
            BtnConfirm.Enabled = (RadPSUPass.Checked || RadPSUFail.Checked) &
                                 (RadMagnetPass.Checked || RadMagnetFail.Checked) &
                                 (RadBScreenPass.Checked || RadBScreenFail.Checked) &
                                 (RadXrayPass.Checked || RadXrayFail.Checked);
        }

        private void RadPSUFail_CheckedChanged(object sender, EventArgs e)
        {
            Result[PSUResult] = InspectionResult.FAIL;
            BtnConfirm.Enabled = (RadPSUPass.Checked || RadPSUFail.Checked) &
                                 (RadMagnetPass.Checked || RadMagnetFail.Checked) &
                                 (RadBScreenPass.Checked || RadBScreenFail.Checked) &
                                 (RadXrayPass.Checked || RadXrayFail.Checked);
        }

        private void RadMagnetPass_CheckedChanged(object sender, EventArgs e)
        {
            Result[MagnetResult] = InspectionResult.PASS;
            BtnConfirm.Enabled = (RadPSUPass.Checked || RadPSUFail.Checked) &
                                 (RadMagnetPass.Checked || RadMagnetFail.Checked) &
                                 (RadBScreenPass.Checked || RadBScreenFail.Checked) &
                                 (RadXrayPass.Checked || RadXrayFail.Checked);
        }

        private void RadMagnetFail_CheckedChanged(object sender, EventArgs e)
        {
            Result[MagnetResult] = InspectionResult.FAIL;
            BtnConfirm.Enabled = (RadPSUPass.Checked || RadPSUFail.Checked) &
                                 (RadMagnetPass.Checked || RadMagnetFail.Checked) &
                                 (RadBScreenPass.Checked || RadBScreenFail.Checked) &
                                 (RadXrayPass.Checked || RadXrayFail.Checked);
        }

        private void RadBScreenPass_CheckedChanged(object sender, EventArgs e)
        {
            Result[BScreenResult] = InspectionResult.PASS;
            BtnConfirm.Enabled = (RadPSUPass.Checked || RadPSUFail.Checked) &
                                 (RadMagnetPass.Checked || RadMagnetFail.Checked) &
                                 (RadBScreenPass.Checked || RadBScreenFail.Checked) &
                                 (RadXrayPass.Checked || RadXrayFail.Checked);
        }

        private void RadBScreenFail_CheckedChanged(object sender, EventArgs e)
        {
            Result[BScreenResult] = InspectionResult.FAIL;
            BtnConfirm.Enabled = (RadPSUPass.Checked || RadPSUFail.Checked) &
                                 (RadMagnetPass.Checked || RadMagnetFail.Checked) &
                                 (RadBScreenPass.Checked || RadBScreenFail.Checked) &
                                 (RadXrayPass.Checked || RadXrayFail.Checked);
        }

        private void RadXrayPass_CheckedChanged(object sender, EventArgs e)
        {
            Result[XrayResult] = InspectionResult.PASS;
            BtnConfirm.Enabled = (RadPSUPass.Checked || RadPSUFail.Checked) &
                                 (RadMagnetPass.Checked || RadMagnetFail.Checked) &
                                 (RadBScreenPass.Checked || RadBScreenFail.Checked) &
                                 (RadXrayPass.Checked || RadXrayFail.Checked);
        }

        private void RadXrayFail_CheckedChanged(object sender, EventArgs e)
        {
            Result[XrayResult] = InspectionResult.FAIL;
            BtnConfirm.Enabled = (RadPSUPass.Checked || RadPSUFail.Checked) &
                                 (RadMagnetPass.Checked || RadMagnetFail.Checked) &
                                 (RadBScreenPass.Checked || RadBScreenFail.Checked) &
                                 (RadXrayPass.Checked || RadXrayFail.Checked);
        }
        #endregion


    }
}
