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
        FraudTracker fraudUnit;
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
            Db.Open();
            MsgTypes.printme("connection to database completed.", this);
            MsgTypes.printme("scan serial number to start fraud tests.", this);
        }


        #region Logic
        private void SNScannedAction()
        {
            //0. Reset tests
            resetTests();
            // 1. When serial number is scanned pull latest Fraud Tracker data.
            fraudUnit = Db.GetFraudTracker(GetSerialNumber());
            // 2. Populate data into GUI.
            if(fraudUnit.AFCTest != null) 
            {
                SetFormValues(fraudUnit);
            }
            else
            {
                MsgTypes.printme("Unit " + GetSerialNumber() + " has not been tested on AFC. Please perform AFT Test",this);
            }
        }
        private void CommitResultsAction()
        {
            Db.SetTestResult(fraudUnit.FraudId, "PSUTest", ResultToString(Result[PSUResult]));
            Db.SetTestResult(fraudUnit.FraudId, "MagnetTest", ResultToString(Result[MagnetResult]));
            Db.SetTestResult(fraudUnit.FraudId, "BlueScreenInspection", ResultToString(Result[BScreenResult]));
            Db.SetTestResult(fraudUnit.FraudId, "XrayTest", ResultToString(Result[XrayResult]));

            MsgTypes.printme("results committed.", this);
            MsgTypes.printme("PSU: " + Result[PSUResult],this);
            MsgTypes.printme("Magnet: " + Result[MagnetResult],this);
            MsgTypes.printme("BlueScreen: " + Result[BScreenResult],this);
            MsgTypes.printme("Xray: " + Result[XrayResult],this);
        }
        private void SetFormValues(FraudTracker data)
        {
            MsgTypes.printme("setting values of " + data.SerialNumber,this);
            SetPSUTestResult(data);
            SetMagnetResult(data);
            SetBlueScreenResult(data);
            SetXrayResult(data);
            DisplayResults();
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
        private string ResultToString(InspectionResult result)
        {
            switch (result)
            {
                case InspectionResult.PASS:
                    return "PASS";
                case InspectionResult.FAIL:
                    return "FAIL";
                case InspectionResult.BYPASS:
                    return "BYPASS";
                default:
                    return "NONE";
            }
        }
        #endregion

        #region Controls
        private void resetTests()
        {
            RadPSUPass.Enabled = true;
            RadPSUFail.Enabled = true;
            RadMagnetPass.Enabled = true;
            RadMagnetFail.Enabled = true;
            RadBScreenPass.Enabled = true;
            RadBScreenFail.Enabled = true;
            RadXrayPass.Enabled = true;
            RadXrayFail.Enabled = true;

            RadPSUPass.Checked = false;
            RadPSUFail.Checked = false;
            RadMagnetPass.Checked = false;
            RadMagnetFail.Checked = false;
            RadBScreenPass.Checked = false;
            RadBScreenFail.Checked = false;
            RadXrayPass.Checked = false;
            RadXrayFail.Checked = false;

            Result[PSUResult] = InspectionResult.NONE;
            Result[MagnetResult] = InspectionResult.NONE;
            Result[BScreenResult] = InspectionResult.NONE;
            Result[XrayResult] = InspectionResult.NONE;
        }
        private string GetSerialNumber()
        {
            return textBoxSN.Text;
        }
        private void textBoxSN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SNScannedAction();
            }
        }
        private void SetPSUTestResult(FraudTracker data) 
        {
            if (data.PSUTest != "")
            {
                Result[PSUResult] = ParseResult(data.PSUTest);
                MsgTypes.printme("psu = " + ResultToString(Result[PSUResult]),this);
            }
        }
        private void SetPSUTestResult(string result)
        {
            Result[PSUResult] = ParseResult(result);
        }
        
        private void SetMagnetResult(FraudTracker data)
        {
            if (data.MagnetTest != "")
            {
                Result[MagnetResult] = ParseResult(data.MagnetTest);
                MsgTypes.printme("magnet = " + ResultToString(Result[MagnetResult]), this);
            }
        }
        private void SetMagnetResult(string result)
        {
            Result[MagnetResult] = ParseResult(result);
        }
        private void SetBlueScreenResult(FraudTracker data)
        {
            if (data.BlueScreenInspection != "")
            {
                Result[BScreenResult] = ParseResult(data.BlueScreenInspection);
                MsgTypes.printme("bluescreen = " + ResultToString(Result[BScreenResult]), this);
            }
        }
        private void SetBlueScreenResult(string result)
        {
            Result[BScreenResult] = ParseResult(result);
        }
        private void SetXrayResult(FraudTracker data)
        {
            if (data.XrayTest != "")
            {
                Result[XrayResult] = ParseResult(data.XrayTest);
                MsgTypes.printme("xray = " + ResultToString(Result[XrayResult]), this);
            }
        }
        private void SetXrayResult(string result)
        {
            Result[XrayResult] = ParseResult(result);
        }
        private void DisplayResults()
        {
            if (Result[PSUResult] != InspectionResult.NONE)
            {
                if (Result[PSUResult] == InspectionResult.PASS)
                {
                    RadPSUPass.Checked = true;
                }
                else 
                {
                    RadPSUFail.Checked = true;
                }
                RadPSUPass.Enabled = false;
                RadPSUFail.Enabled = false;
            }
            if (Result[MagnetResult] != InspectionResult.NONE)
            {
                if (Result[MagnetResult] == InspectionResult.PASS)
                {
                    RadMagnetPass.Checked = true;
                }
                else
                {
                    RadMagnetFail.Checked = true;
                }
                RadMagnetPass.Enabled = false;
                RadMagnetFail.Enabled = false;
            }

            if (Result[BScreenResult] != InspectionResult.NONE)
            {
                if (Result[BScreenResult] == InspectionResult.PASS)
                {
                    RadBScreenPass.Checked = true;
                }
                else
                {
                    RadBScreenFail.Checked = true;
                }
                RadBScreenPass.Enabled = false;
                RadBScreenFail.Enabled = false;
            }

            if (Result[XrayResult] != InspectionResult.NONE)
            {
                if (Result[XrayResult] == InspectionResult.PASS)
                {
                    RadXrayPass.Checked = true;
                }
                else
                {
                    RadXrayFail.Checked = true;
                }
                RadXrayPass.Enabled = false;
                RadXrayFail.Enabled = false;
            }
            MsgTypes.printme("PSU: " + Result[PSUResult], this);
            MsgTypes.printme("Magnet: " + Result[MagnetResult], this);
            MsgTypes.printme("BlueScreen: " + Result[BScreenResult], this);
            MsgTypes.printme("Xray: " + Result[XrayResult], this);
        }

        private void RadPSUPass_CheckedChanged(object sender, EventArgs e)
        {
            Result[PSUResult] = InspectionResult.PASS;
            BtnConfirm.Enabled = (RadPSUPass.Checked);
        }

        private void RadPSUFail_CheckedChanged(object sender, EventArgs e)
        {
            Result[PSUResult] = InspectionResult.FAIL;
        }

        private void RadMagnetPass_CheckedChanged(object sender, EventArgs e)
        {
            Result[MagnetResult] = InspectionResult.PASS;
            BtnConfirm.Enabled = RadMagnetPass.Checked;
        }

        private void RadMagnetFail_CheckedChanged(object sender, EventArgs e)
        {
            Result[MagnetResult] = InspectionResult.FAIL;
        }

        private void RadBScreenPass_CheckedChanged(object sender, EventArgs e)
        {
            Result[BScreenResult] = InspectionResult.PASS;
            
        }
        private void RadBScreenFail_CheckedChanged(object sender, EventArgs e)
        {
            Result[BScreenResult] = InspectionResult.FAIL;
        }

        private void textBoxSN_TextChanged(object sender, EventArgs e)
        {
            //resetTests();
        }

        private void RadXrayPass_CheckedChanged(object sender, EventArgs e)
        {
            Result[XrayResult] = InspectionResult.PASS;
            BtnConfirm.Enabled = true;
        }

        private void RadXrayFail_CheckedChanged(object sender, EventArgs e)
        {
            Result[XrayResult] = InspectionResult.FAIL;
            BtnConfirm.Enabled = true;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            CommitResultsAction();
        }
        #endregion


    }
}
