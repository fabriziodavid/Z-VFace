using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_VFace.Models
{
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
}
