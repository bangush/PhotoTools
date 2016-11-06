﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NetCharm.Image.Addins;

namespace InternalFilters.Effects
{
    public partial class BlurForm : Form
    {
        internal AddinHost host;
        private IAddin addin;
        private Image thumb = null;
        private Image thumbBackup = null;

        private BlurMode blurMode = BlurMode.Normal;
        internal ParamItem ParamMode
        {
            get
            {
                ParamItem pi = new ParamItem();
                pi.Name = "BlurMode";
                pi.DisplayName = AddinUtils._( addin, pi.Name );
                pi.Type = blurMode.GetType();
                pi.Value = blurMode;
                return ( pi );
            }
            set { blurMode = (BlurMode) value.Value; }
        }
        private double gaussianSigma = 1.4;
        internal ParamItem ParmaGaussianSigma
        {
            get
            {
                ParamItem pi = new ParamItem();
                pi.Name = "GaussianSigma";
                pi.DisplayName = AddinUtils._( addin, pi.Name );
                pi.Type = gaussianSigma.GetType();
                pi.Value = gaussianSigma;
                return ( pi );
            }
            set { gaussianSigma = (double) value.Value; }
        }
        private int gaussianSize = 5;
        internal ParamItem ParmaGaussianSize
        {
            get
            {
                ParamItem pi = new ParamItem();
                pi.Name = "GaussianSize";
                pi.DisplayName = AddinUtils._( addin, pi.Name );
                pi.Type = gaussianSize.GetType();
                pi.Value = gaussianSize;
                return ( pi );
            }
            set { gaussianSize = (int) value.Value; }
        }
        private int gaussianThreshold = 0;
        internal ParamItem ParmaGaussianThreshold
        {
            get
            {
                ParamItem pi = new ParamItem();
                pi.Name = "GaussianThreshold";
                pi.DisplayName = AddinUtils._( addin, pi.Name );
                pi.Type = gaussianThreshold.GetType();
                pi.Value = gaussianThreshold;
                return ( pi );
            }
            set { gaussianThreshold = (int) value.Value; }
        }

        public BlurForm()
        {
            InitializeComponent();
        }

        public BlurForm( IAddin filter )
        {
            this.addin = filter;
            InitializeComponent();

            toolTip.ToolTipTitle = addin.DisplayName;
            AddinUtils.Translate( addin, this, toolTip );

            thumb = AddinUtils.CreateThumb( addin.ImageData, imgPreview.Size );
            imgPreview.Image = thumb;

        }

        private void BlurForm_Load( object sender, EventArgs e )
        {
            if ( blurMode == BlurMode.Normal )
            {
                btnModeNormal.Checked = true;
                grpGaussianParams.Enabled = false;
            }
            else
            {
                btnModeGaussian.Checked = true;
                grpGaussianParams.Enabled = true;
            }

            edGaussianSigma.Value = Convert.ToDecimal( gaussianSigma );
            edGaussianSize.Value = Convert.ToDecimal( gaussianSize );
            edGaussianThreshold.Value = Convert.ToDecimal( gaussianThreshold );
        }

        private void btnOriginal_Click( object sender, EventArgs e )
        {
            if(btnOriginal.Checked)
            {
                thumbBackup = imgPreview.Image;
                imgPreview.Image = thumb;
            }
            else
            {
                if ( thumbBackup is Image )
                    imgPreview.Image = thumbBackup;
            }
        }

        private void btnMode_Click( object sender, EventArgs e )
        {
            if ( sender == btnModeNormal )
            {
                blurMode = BlurMode.Normal;
                grpGaussianParams.Enabled = false;
            }
            else
            {
                blurMode = BlurMode.Gaussian;
                grpGaussianParams.Enabled = true;
            }
            imgPreview.Image = addin.Apply( thumb );
        }

        private void edGaussian_ValueChanged( object sender, EventArgs e )
        {
            gaussianSigma = Convert.ToDouble( edGaussianSigma.Value );
            gaussianSize = Convert.ToInt32( edGaussianSize.Value );
            gaussianThreshold = Convert.ToInt32( edGaussianThreshold.Value );

            imgPreview.Image = addin.Apply( thumb );
        }

    }
}