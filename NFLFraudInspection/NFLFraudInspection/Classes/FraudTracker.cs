using System;

namespace NFLFraudInspection
{
    public class FraudTracker
    {
        public int FraudId { get; set; }
        public int UnitId { get; set; }
        public string PartNumber { get; set; }
        public string Family { get; set; }
        public int IsFraudTarget { get; set; }
        public DateTime ReceivedDate { get; set; }
        public string Channel { get; set; }
        public int IsCaptured { get; set; }
        public DateTime CaptureDate { get; set; }
        public int FraudLoop { get; set; }
        public string DeviceType { get; set; }
        public string ManualCID { get; set; }
        public string AFCTest { get; set; }
        public string PSUTest { get; set; }
        public string MagnetTest { get; set; }
        public string BlueScreenInspection { get; set; }
        public string XrayTest { get; set; }
        public int IsFraudLoopComplete { get; set; }
        public string SerialNumber { get; set; }
        public string ReceivingUser { get; set; }
        public string OrderNumber { get; set; }


        public override string ToString()
        {
            return "sn: " + this.SerialNumber + " order: " + this.OrderNumber + " tests: [" + this.AFCTest + ", " +
                this.PSUTest + ", " + this.MagnetTest + ", " + this.BlueScreenInspection +"]" ;
        }


        #region Legacy Code
        /*
         * Legacy Code
         * Not fitting into new database schema
         */
        //public DateTime Date { get; set; }
        #endregion
    }
}