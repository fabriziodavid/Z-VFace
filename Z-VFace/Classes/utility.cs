using System;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.XPath;
using Z_VFace.Exceptions;
using Z_VFace.Models;

namespace Z_VFace.Utilities
{
    public class ZMod
    {


        private XPathDocument doc = null;
        private XPathNavigator nav = null;
        public string Path { get; set; }

        public SezGeneral General = new SezGeneral();
        public SezOther Other = new SezOther();




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
                    throw new ZmodException("Errore nel formato xml o file non valido");
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