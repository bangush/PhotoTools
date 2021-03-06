﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cyotek.Windows.Forms;

namespace NetCharm.Common.Controls
{
    [ToolboxBitmap( typeof( TrackBar ), "SlideColor.bmp" )]
    [ToolboxItem( true )]
    public partial class SlideColorHue : UserControl
    {
        [Category( "Behavior" )]
        public string Caption
        {
            get { return ( lblCaption.Text ); }
            set { lblCaption.Text = value; }
        }

        [Category( "Behavior" )]
        public string Unit
        {
            get { return ( lblUnit.Text ); }
            set { lblUnit.Text = value; }
        }

        [Category( "Behavior" )]
        public decimal Value
        {
            get { return ( edValue.Value ); }
            set
            {
                edValue.Value = value;
                slideValue.Value = Convert.ToInt32( (float) value / factor );
            }
        }

        [Category( "Behavior" )]
        public decimal Step
        {
            get { return ( edValue.Increment ); }
            set
            {
                edValue.Increment = value;
            }
        }

        [Category( "Behavior" )]
        public int DecimalPlaces
        {
            get { return ( edValue.DecimalPlaces ); }
            set
            {
                edValue.DecimalPlaces = value;
                slideValue.Value = Convert.ToInt32( (float) edValue.Value / factor );
            }
        }

        [Category( "Appearance" )]
        public Color NubColor
        {
            get { return ( slideValue.NubColor ); }
            set { slideValue.NubColor = value; }
        }
        [Category( "Appearance" )]
        public Size NubSize
        {
            get { return ( slideValue.NubSize ); }
            set { slideValue.NubSize = value; }
        }
        [Category( "Appearance" )]
        public ColorSliderNubStyle NubStyle
        {
            get { return ( slideValue.NubStyle ); }
            set { slideValue.NubStyle = value; }
        }

        [Category( "Appearance" )]
        public bool ShowValueDivider
        {
            get { return ( slideValue.ShowValueDivider ); }
            set { slideValue.ShowValueDivider = value; }
        }



        private float factor = 1.0f;

        public event EventHandler ValueChanged;

        public SlideColorHue()
        {
            InitializeComponent();
        }

        private void ParamNumber_Load( object sender, EventArgs e )
        {
            edValue.ValueChanged += HandleValueChanged;
            slideValue.ValueChanged += HandleValueChanged;
        }

        private void HandleValueChanged( object sender, EventArgs e )
        {
            // we'll explain this in a minute
            this.OnValueChanged( EventArgs.Empty );
        }

        protected virtual void OnValueChanged( EventArgs e )
        {
            this.ValueChanged?.Invoke( this, e );
        }

        private void edValue_ValueChanged( object sender, EventArgs e )
        {
            slideValue.Value = (float) Convert.ToDouble( edValue.Value ) / factor;
        }

        private void slideValue_ValueChanged( object sender, EventArgs e )
        {
            edValue.Value = Convert.ToDecimal( slideValue.Value * factor );
        }

        public Color ToRgb( double sat, double lum )
        {
            return ( new HslColor( Convert.ToDouble( edValue.Value ), sat, lum ).ToRgbColor() );
        }

        public Color ToArgb( double sat, double lum, int alpha )
        {
            return ( new HslColor( alpha, Convert.ToDouble( edValue.Value ), sat, lum ).ToRgbColor() );
        }

    }
}
