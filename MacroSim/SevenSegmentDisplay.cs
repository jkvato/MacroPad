using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MacroSim
{
    public enum FrequencySelection
    {
        None,
        MHz,
        KHz
    }

    public partial class SevenSegmentDisplay : UserControl
    {
        private readonly Color DefaultFontColor = Color.Red;
        private readonly Color DefaultSelectionColor = Color.Yellow;
        private readonly int DefaultDisplayMargin = 3;
        private readonly int DefaultSelectionMargin = 2;
        private readonly int DefaultSelectionWidth = 2;
        private readonly int DefaultDecimalWidth = 2;

        private decimal _value;
        private FrequencySelection _selection;

        /// <summary>
        /// Gets or sets the number of whole digits.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue(3)]
        public int WholeDigits { get; set; }

        /// <summary>
        /// Gets or sets the number of fractional digits.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue(3)]
        public int FractDigits { get; set; }

        /// <summary>
        /// Gets or sets the left margin in pixels.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue(3)]
        public int LeftMargin { get; set; }

        /// <summary>
        /// Gets or sets the right margin in pixels.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue(3)]
        public int RightMargin { get; set; }

        /// <summary>
        /// Gets or sets the top margin in pixels.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue(3)]
        public int TopMargin { get; set; }

        /// <summary>
        /// Gets or sets the bottom margin in pixels.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue(3)]
        public int BottomMargin { get; set; }


        /// <summary>
        /// Gets or sets the string format for the display.
        /// </summary>
        public string DisplayFormat
        {
            get
            {
                string wholeStr = WholeDigits > 0 ? new string('0', WholeDigits) : "";
                string fractStr = FractDigits > 0 ? new string('0', FractDigits) : "";
                string result = "{0:";
                result += wholeStr;
                if (fractStr.Length > 0)
                {
                    result += ".";
                    result += fractStr;
                }
                result += "}";
                return result;
            }
        }


        /// <summary>
        /// Gets or sets the decimal value to display.
        /// </summary>
        public decimal Value
        {
            get => _value;
            set
            {
                bool changing = (_value != value);
                _value = value;
                if (changing)
                {
                    Invalidate();
                }
            }
        }

        /// <summary>
        /// Gets or sets the frequency selection.
        /// </summary>
        public FrequencySelection Selection
        {
            get => _selection;
            set
            {
                _selection = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the font color.
        /// </summary>
        public Color FontColor { get; set; }

        /// <summary>
        /// Gets or sets the selection color.
        /// </summary>
        public Color SelectionColor { get; set; }

        public SevenSegmentDisplay()
        {
            InitializeComponent();
            Selection = FrequencySelection.None;
            WholeDigits = 3;
            FractDigits = 3;
            FontColor = DefaultFontColor;
            SelectionColor = DefaultSelectionColor;
            Value = 0;
            TopMargin = DefaultDisplayMargin;
            BottomMargin = DefaultDisplayMargin;
            LeftMargin = DefaultDisplayMargin;
            RightMargin = DefaultDisplayMargin;
            SetNewSize();
        }

        public SevenSegmentDisplay(int wholeDigits, int fractDigits, decimal value = 0.0M) : this()
        {
            WholeDigits = wholeDigits;
            FractDigits = fractDigits;
            Value = value;
            Selection = FrequencySelection.None;
            FontColor = DefaultFontColor;
            SetNewSize();
        }

        public SizeF SetNewSize()
        {
            // Divide the value into whole and fraction.
            string str = string.Format(DisplayFormat, Value);
            string whole = "";
            string fraction = "";
            bool hasFraction = false;

            if (str.IndexOf('.') > -1)
            {
                var strings = str.Split('.');
                whole = strings[0];
                fraction = strings[1];
                hasFraction = true;
            }
            else
            {
                whole = str;
                hasFraction = false;
            }

            // Measure the whole and fractional strings.
            using var textFont = new Font("DSEG7 Classic Mini", 24, FontStyle.Italic);
            using var g = CreateGraphics();
            var wholeSize = g.MeasureString(whole, textFont);
            var fractSize = g.MeasureString(fraction, textFont);

            // Calculate the new size of the control.
            float width, height;
            if (hasFraction)
            {
                width = LeftMargin + wholeSize.Width + DefaultDecimalWidth + fractSize.Width + RightMargin;
                height = TopMargin + wholeSize.Height + BottomMargin;
            }
            else
            {
                width = LeftMargin + wholeSize.Width + RightMargin;
                height = TopMargin + wholeSize.Height + BottomMargin;
            }

            height += DefaultSelectionMargin + DefaultSelectionMargin + DefaultSelectionWidth;

            // Set the control size.
            Width = Convert.ToInt32(width);
            Height = Convert.ToInt32(height);

            //System.Diagnostics.Debug.WriteLine($"Width={Width} Height={Height}");

            return new SizeF(width, height);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Pens, fonts and brushes
            using var selectionPen = new Pen(SelectionColor, DefaultSelectionWidth);
            using var textPen = new Pen(FontColor, DefaultDecimalWidth);
            using var textFont = new Font("DSEG7 Classic Mini", 24, FontStyle.Italic);
            using var textBrush = new SolidBrush(FontColor);
            using var bgtextBrush = new SolidBrush(Color.FromArgb(64, 0, 0));

            // Divide the value into whole and fraction
            //System.Diagnostics.Debug.WriteLine($"Value={Value}");
            string str = string.Format(DisplayFormat, Value);
            string whole = "";
            string fraction = "";
            bool hasFraction = false;

            if (str.IndexOf('.') > -1)
            {
                var strings = str.Split('.');
                whole = strings[0];
                fraction = strings[1];
                hasFraction = true;
            }
            else
            {
                whole = str;
                hasFraction = false;
            }

            // Make the background 8s
            string bgWhole = new string('8', whole.Length);
            string bgFraction = new string('8', fraction.Length);

            //System.Diagnostics.Debug.WriteLine($"Whole={whole}, Fraction={fraction}");

            // Measure the whole and fractional strings.
            var wholeSize = e.Graphics.MeasureString(whole, textFont);
            var decimalSize = hasFraction ? DefaultDecimalWidth : 0;
            var fractSize = hasFraction ? e.Graphics.MeasureString(fraction, textFont) : new SizeF(0, 0);

            int wholeWidth = Convert.ToInt32(wholeSize.Width);
            int wholeHeight = Convert.ToInt32(wholeSize.Height);

            // Draw the whole and fractional parts
            //System.Diagnostics.Debug.WriteLine($"Top={TopMargin}, Left={LeftMargin}");
            e.Graphics.DrawString(bgWhole, textFont, bgtextBrush, LeftMargin, TopMargin);
            e.Graphics.DrawString(whole, textFont, textBrush, LeftMargin, TopMargin);
            //e.Graphics.DrawRectangle(selectionPen, LeftMargin, TopMargin, wholeSize.Width, wholeSize.Height);
            if (hasFraction)
            {
                e.Graphics.DrawString(bgFraction, textFont, bgtextBrush, LeftMargin + wholeWidth + decimalSize, TopMargin);
                e.Graphics.DrawString(fraction, textFont, textBrush, LeftMargin + wholeWidth + decimalSize, TopMargin);
                //e.Graphics.DrawRectangle(selectionPen, LeftMargin + wholeWidth + decimalSize, TopMargin, fractSize.Width, fractSize.Height);

                // Draw the decimal
                //e.Graphics.DrawRectangle(textPen, 83, 37, 2, 2);
                e.Graphics.DrawRectangle(textPen, LeftMargin + wholeWidth - 2, TopMargin + wholeHeight - 6, DefaultDecimalWidth, DefaultDecimalWidth);
            }

            // Underline the selected segment, if any
            switch (Selection)
            {
                case FrequencySelection.None:
                default:
                    break;
                case FrequencySelection.MHz:
                    //e.Graphics.DrawLine(selectionPen, 10, 45, 79, 45);
                    e.Graphics.DrawLine(
                        selectionPen,
                        LeftMargin,
                        TopMargin + wholeHeight + DefaultSelectionMargin,
                        LeftMargin + wholeWidth,
                        TopMargin + wholeHeight + DefaultSelectionMargin);
                    break;
                case FrequencySelection.KHz:
                    //e.Graphics.DrawLine(selectionPen, 90, 45, 159, 45);
                    e.Graphics.DrawLine(
                        selectionPen,
                        LeftMargin + wholeWidth,
                        TopMargin + wholeHeight + DefaultSelectionMargin,
                        LeftMargin + wholeWidth + fractSize.Width,
                        TopMargin + wholeHeight + DefaultSelectionMargin);
                    break;
            }
        }
    }
}
