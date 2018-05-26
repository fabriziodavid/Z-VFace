using System;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.XPath;

namespace Z_VFace.Utilities
{
    public class ZMod
    {


        private XPathDocument doc = null;
        private XPathNavigator nav = null;
        public string Path { get; set; }

        public SezGeneral General = new SezGeneral();
        public SezOther Other = new SezOther();



        #region GENERAL
        public class SezGeneral
        {
            public short TempExtruder { get; set; }
            public short TempBed { get; set; }
            public bool EnableRaft { get; set; }
            public bool EnableSupport { get; set; }
            public bool AutofanEnable { get; set; }
            public short AutofanMaxTime { get; set; }
            public short AutofanMinTime { get; set; }
            public bool AutofanFixedEnabled { get; set; }
            public double AutofanFixedSpeed { get; set; }
            public bool VisibleBottomFirst { get; set; }
            public bool EnableFirstLayer { get; set; }
            public bool EnableBridge { get; set; }
        }
        #endregion

        #region OTHER
        public class SezOther
        {
            private string _StartGCode = null;

            private string _EndGCode = null;
            public short AvoidHoles { get; set; }
            public double AvoidHolesOffset { get; set; }
            public short CheapestTravelComputationsLimit { get; set; }
            public short ContourEntranceAngle { get; set; }
            public double ContourEntranceFeed { get; set; }
            public double ContourEntranceLength { get; set; }
            public short ContourExitAngle { get; set; }
            public short ContourExitFeed { get; set; }
            public double ContourExitLength { get; set; }
            public double CutContour { get; set; }
            public double CutContourSecond { get; set; }
            public double CutContourSecondStart { get; set; }
            public double CutContourStart { get; set; }
            public double CutInfill { get; set; }
            public bool EnableEdgeConnectors { get; set; }
            public bool EnableMinimalPrintFeederate { get; set; }
            public bool EnableVisibleDefInnerContour { get; set; }
            public string StartGCode
            {
                get
                {
                    if (string.IsNullOrWhiteSpace(this._StartGCode))
                    {
                        this._StartGCode = String.Concat("G21        ;metric values\r\n",
                                                            "G90        ;absolute positioning\r\n",
                                                            "G28 X0 Y0  ;move X/Y to min endstops\r\n",
                                                            "G28 Z0     ;move Z to min endstops\r\n",
                                                            "G92 X0 Y0 Z0 E0         ;reset software position to front/left/z=0.0\r\n",
                                                            "G1 Z15.0 F180\r\n",
                                                            "G92 E0                  ;zero the extruded length\r\n");
                    }
                    return this._StartGCode;
                }
                set
                {
                    this._StartGCode = value;
                }
            }
            public string EndGCode
            {
                get
                {
                    if (string.IsNullOrWhiteSpace(this._EndGCode))
                    {
                        this._EndGCode = String.Concat("M104 S0                    ;extruder heat off\r\n",
                                            "G91                        ;relative positioning\r\n",
                                            "G28 X0 Y0                  ;move X/Y to min endstops. so the head is out of the way\r\n",
                                            "M84                        ;steppers off\r\n");
                    }
                    return this._EndGCode;
                }
                set
                {
                    this._EndGCode = value;
                }
            }
            public short ExtruderNrModel { get; set; }
            public short ExtruderNrRaft { get; set; }
            public short ExtruderNrSupport { get; set; }
            public bool FastIdleMoveSpeed { get; set; }
            public bool HideSeamsInCorners { get; set; }
            public short IdleMoveSpeed { get; set; }
            public bool InfillLineStart { get; set; }
            public bool IsSecondContourFirst { get; set; }
            public short LashCorrectionX { get; set; }
            public short LashCorrectionY { get; set; }
            public short LashSwitchMargin { get; set; }
            public short MinimalPrintFeederate { get; set; }
            public short NarrowSpaceMinimalArea { get; set; }
            public double NarrowSpaceRemovalOffset { get; set; }
            public double NozzleOffsetHole { get; set; }
            public short OffsetDisappearPolygon { get; set; }
            public double OffsetVisibleFirst { get; set; }
            public short OffsetVisibleSecond { get; set; }
            public short PolygonLenght { get; set; }
            public short PolygonPercentage { get; set; }
            public bool RaftBaseDoubleContour { get; set; }
            public double SeamZigZag { get; set; }
            public double SimplifyDistanceContour { get; set; }
            public double SimplifyDistanceSupport { get; set; }
            public double SliceThickness { get; set; }

            public bool SwitchExtruder { get; set; }
        }
        #endregion

        public ZMod(string path = null)
        {
            if (path != null)
            {
                this.Path = path;
                try
                {
                    this.doc = new XPathDocument(this.Path);
                    this.nav = this.doc.CreateNavigator();
                }
                catch (Exception exception)
                {
                    throw new Exception("Errore nel formato xml o file non valido");
                }
            }
        }

        public bool getData()
        {
            short ival;
            bool retval = false;
            double dval = 0;
            XPathNavigator cnav = null;
            if (this.Path != null)
            {
                if ((this.nav == null ? false : this.nav.SelectSingleNode("Settings/General") != null))
                {
                    cnav = this.nav.SelectSingleNode("Settings/General/TempExtruder");
                    if (cnav != null)
                    {
                        this.General.TempExtruder = 0;
                        if (short.TryParse(cnav.ToString(), out ival))
                        {
                            this.General.TempExtruder = ival;
                        }
                    }
                    cnav = this.nav.SelectSingleNode("Settings/General/TempBed");
                    if (cnav != null)
                    {
                        this.General.TempBed = 0;
                        if (short.TryParse(cnav.ToString(), out ival))
                        {
                            this.General.TempBed = ival;
                        }
                    }
                    cnav = this.nav.SelectSingleNode("Settings/General/EnableRaft");
                    if (cnav != null)
                    {
                        this.General.EnableRaft = false;
                        if (cnav.ToString().ToLower().Equals("true"))
                        {
                            this.General.EnableRaft = true;
                        }
                    }
                    cnav = this.nav.SelectSingleNode("Settings/General/EnableSupport");
                    if (cnav != null)
                    {
                        this.General.EnableSupport = false;
                        if (cnav.ToString().ToLower().Equals("true"))
                        {
                            this.General.EnableSupport = true;
                        }
                    }
                    cnav = this.nav.SelectSingleNode("Settings/General/AutofanEnable");
                    if (cnav != null)
                    {
                        this.General.AutofanEnable = false;
                        if (cnav.ToString().ToLower().Equals("true"))
                        {
                            this.General.AutofanEnable = true;
                        }
                    }
                    cnav = this.nav.SelectSingleNode("Settings/General/AutofanMinTime");
                    if (cnav != null)
                    {
                        this.General.AutofanMinTime = 0;
                        if (short.TryParse(cnav.ToString(), out ival))
                        {
                            this.General.AutofanMinTime = ival;
                        }
                    }
                    cnav = this.nav.SelectSingleNode("Settings/General/AutofanMaxTime");
                    if (cnav != null)
                    {
                        this.General.AutofanMaxTime = 0;
                        if (short.TryParse(cnav.ToString(), out ival))
                        {
                            this.General.AutofanMaxTime = ival;
                        }
                    }
                    cnav = this.nav.SelectSingleNode("Settings/General/AutofanFixedEnabled");
                    if (cnav != null)
                    {
                        this.General.AutofanFixedEnabled = false;
                        if (cnav.ToString().ToLower().Equals("true"))
                        {
                            this.General.AutofanFixedEnabled = true;
                        }
                    }
                    cnav = this.nav.SelectSingleNode("Settings/General/AutofanFixedSpeed");
                    if (cnav != null)
                    {
                        this.General.AutofanFixedSpeed = 0;
                        if (double.TryParse(cnav.ToString(), out dval))
                        {
                            this.General.AutofanFixedSpeed = dval;
                        }
                    }
                    cnav = this.nav.SelectSingleNode("Settings/General/AutofanMaxTime");
                    if (cnav != null)
                    {
                        this.General.AutofanMaxTime = 0;
                        if (short.TryParse(cnav.ToString(), out ival))
                        {
                            this.General.AutofanMaxTime = ival;
                        }
                    }
                    cnav = this.nav.SelectSingleNode("Settings/General/AutofanMaxTime");
                    if (cnav != null)
                    {
                        this.General.AutofanMaxTime = 0;
                        if (short.TryParse(cnav.ToString(), out ival))
                        {
                            this.General.AutofanMaxTime = ival;
                        }
                    }
                    cnav = this.nav.SelectSingleNode("Settings/General/VisibleBottomFirst");
                    if (cnav != null)
                    {
                        this.General.VisibleBottomFirst = false;
                        if (cnav.ToString().ToLower().Equals("true"))
                        {
                            this.General.VisibleBottomFirst = true;
                        }
                    }
                    cnav = this.nav.SelectSingleNode("Settings/General/EnableFirstLayer");
                    if (cnav != null)
                    {
                        this.General.EnableFirstLayer = false;
                        if (cnav.ToString().ToLower().Equals("true"))
                        {
                            this.General.EnableFirstLayer = true;
                        }
                    }
                    cnav = this.nav.SelectSingleNode("Settings/General/EnableBridge");
                    if (cnav != null)
                    {
                        this.General.EnableBridge = false;
                        if (cnav.ToString().ToLower().Equals("true"))
                        {
                            this.General.EnableBridge = true;
                        }
                    }
                    retval = true;
                }
            }
            return retval;
        }

        public void saveData(string filename)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(this.nav.InnerXml);
            doc.InsertBefore(doc.CreateXmlDeclaration("1.0", "utf-8", ""), doc.FirstChild);
            XmlNode node = doc.SelectSingleNode("Settings/General/TempExtruder");
            node.InnerText = this.General.TempExtruder.ToString();
            node = doc.SelectSingleNode("Settings/General/TempBed");
            node.InnerText = this.General.TempBed.ToString();
            node = doc.SelectSingleNode("Settings/General/AutofanFixedSpeed");
            double autofanFixedSpeed = this.General.AutofanFixedSpeed;
            node.InnerText = autofanFixedSpeed.ToString().Replace(',', '.');
            node = doc.SelectSingleNode("Settings/General/AutofanMinTime");
            node.InnerText = this.General.AutofanMinTime.ToString();
            node = doc.SelectSingleNode("Settings/General/AutofanMaxTime");
            node.InnerText = this.General.AutofanMaxTime.ToString();
            doc.SelectSingleNode("Settings/General/AutofanEnable").InnerText = (this.General.AutofanEnable ? "true" : "false");
            doc.SelectSingleNode("Settings/General/EnableRaft").InnerText = (this.General.EnableRaft ? "true" : "false");
            doc.SelectSingleNode("Settings/General/EnableSupport").InnerText = (this.General.EnableSupport ? "true" : "false");
            doc.SelectSingleNode("Settings/General/AutofanFixedEnabled").InnerText = (this.General.AutofanFixedEnabled ? "true" : "false");
            doc.SelectSingleNode("Settings/General/VisibleBottomFirst").InnerText = (this.General.VisibleBottomFirst ? "true" : "false");
            doc.SelectSingleNode("Settings/General/EnableFirstLayer").InnerText = (this.General.EnableFirstLayer ? "true" : "false");
            doc.SelectSingleNode("Settings/General/EnableBridge").InnerText = (this.General.EnableBridge ? "true" : "false");
            doc.Save(filename);
        }
    }
}