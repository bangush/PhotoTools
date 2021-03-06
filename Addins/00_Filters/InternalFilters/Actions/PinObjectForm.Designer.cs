﻿using NetCharm.Common;

namespace InternalFilters.Actions
{
    partial class PinObjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PinObjectForm));
            Cyotek.Windows.Forms.ZoomLevelCollection zoomLevelCollection1 = new Cyotek.Windows.Forms.ZoomLevelCollection();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.imgPicture = new Cyotek.Windows.Forms.ImageBox();
            this.btnOpenPic = new System.Windows.Forms.Button();
            this.btnColorPicker = new System.Windows.Forms.Button();
            this.btnOpenFont = new System.Windows.Forms.Button();
            this.btnEffectDown = new System.Windows.Forms.Button();
            this.btnEffectUp = new System.Windows.Forms.Button();
            this.btnEffectRemove = new System.Windows.Forms.Button();
            this.btnEffectAdd = new System.Windows.Forms.Button();
            this.btnPosRandom = new System.Windows.Forms.Button();
            this.btnOriginalPic = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpCommonSetting = new System.Windows.Forms.GroupBox();
            this.slideOffsetY = new NetCharm.Common.Controls.SlideNumber();
            this.slideOffsetX = new NetCharm.Common.Controls.SlideNumber();
            this.slideMarginY = new NetCharm.Common.Controls.SlideNumber();
            this.slideMarginX = new NetCharm.Common.Controls.SlideNumber();
            this.pnlPosMode = new System.Windows.Forms.Panel();
            this.chkEnabled = new System.Windows.Forms.CheckBox();
            this.chkTile = new System.Windows.Forms.CheckBox();
            this.csSelect = new NetCharm.Common.Controls.CornerSide();
            this.slideBlend = new NetCharm.Common.Controls.SlideNumber();
            this.slideOpacity = new NetCharm.Common.Controls.SlideNumber();
            this.lvFilters = new System.Windows.Forms.ListView();
            this.ilLarge = new System.Windows.Forms.ImageList(this.components);
            this.ilSmall = new System.Windows.Forms.ImageList(this.components);
            this.pnlEffectTools = new System.Windows.Forms.Panel();
            this.pnlCustom = new System.Windows.Forms.Panel();
            this.tabObject = new System.Windows.Forms.TabControl();
            this.tabPagePicture = new System.Windows.Forms.TabPage();
            this.tabPageText = new System.Windows.Forms.TabPage();
            this.imgText = new Cyotek.Windows.Forms.ImageBox();
            this.edText = new System.Windows.Forms.TextBox();
            this.tabPageTag = new System.Windows.Forms.TabPage();
            this.imgPreview = new Cyotek.Windows.Forms.ImageBox();
            this.imageActions = new NetCharm.Common.Controls.ImageActions();
            this.dlgFontEx = new NetCharm.Common.Controls.FontDialogEx();
            this.grpCommonSetting.SuspendLayout();
            this.pnlPosMode.SuspendLayout();
            this.pnlEffectTools.SuspendLayout();
            this.pnlCustom.SuspendLayout();
            this.tabObject.SuspendLayout();
            this.tabPagePicture.SuspendLayout();
            this.tabPageText.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgPicture
            // 
            this.imgPicture.AllowDoubleClick = true;
            this.imgPicture.AllowDrop = true;
            this.imgPicture.AllowUnfocusedMouseWheel = true;
            resources.ApplyResources(this.imgPicture, "imgPicture");
            this.imgPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPicture.ImageBorderStyle = Cyotek.Windows.Forms.ImageBoxBorderStyle.FixedSingleGlowShadow;
            this.imgPicture.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.imgPicture.Name = "imgPicture";
            this.imgPicture.ShowPixelGrid = true;
            this.imgPicture.SizeMode = Cyotek.Windows.Forms.ImageBoxSizeMode.Fit;
            this.toolTip.SetToolTip(this.imgPicture, resources.GetString("imgPicture.ToolTip"));
            this.imgPicture.DragDrop += new System.Windows.Forms.DragEventHandler(this._DragDrop);
            this.imgPicture.DragEnter += new System.Windows.Forms.DragEventHandler(this._DragEnter);
            this.imgPicture.DoubleClick += new System.EventHandler(this.imgPicture_DoubleClick);
            // 
            // btnOpenPic
            // 
            resources.ApplyResources(this.btnOpenPic, "btnOpenPic");
            this.btnOpenPic.Image = global::InternalFilters.Properties.Resources.ImageLoader_24x;
            this.btnOpenPic.Name = "btnOpenPic";
            this.toolTip.SetToolTip(this.btnOpenPic, resources.GetString("btnOpenPic.ToolTip"));
            this.btnOpenPic.UseVisualStyleBackColor = true;
            this.btnOpenPic.Click += new System.EventHandler(this.btnOpenPic_Click);
            // 
            // btnColorPicker
            // 
            resources.ApplyResources(this.btnColorPicker, "btnColorPicker");
            this.btnColorPicker.Image = global::InternalFilters.Properties.Resources.ColorPicker_24x;
            this.btnColorPicker.Name = "btnColorPicker";
            this.toolTip.SetToolTip(this.btnColorPicker, resources.GetString("btnColorPicker.ToolTip"));
            this.btnColorPicker.UseVisualStyleBackColor = true;
            this.btnColorPicker.Click += new System.EventHandler(this.btnColorPicker_Click);
            // 
            // btnOpenFont
            // 
            resources.ApplyResources(this.btnOpenFont, "btnOpenFont");
            this.btnOpenFont.Image = global::InternalFilters.Properties.Resources.Font_24x;
            this.btnOpenFont.Name = "btnOpenFont";
            this.toolTip.SetToolTip(this.btnOpenFont, resources.GetString("btnOpenFont.ToolTip"));
            this.btnOpenFont.UseVisualStyleBackColor = true;
            this.btnOpenFont.Click += new System.EventHandler(this.btnOpenFont_Click);
            // 
            // btnEffectDown
            // 
            resources.ApplyResources(this.btnEffectDown, "btnEffectDown");
            this.btnEffectDown.Image = global::InternalFilters.Properties.Resources.effect_down_24x;
            this.btnEffectDown.Name = "btnEffectDown";
            this.toolTip.SetToolTip(this.btnEffectDown, resources.GetString("btnEffectDown.ToolTip"));
            this.btnEffectDown.UseVisualStyleBackColor = true;
            this.btnEffectDown.Click += new System.EventHandler(this.btnEffectDown_Click);
            // 
            // btnEffectUp
            // 
            resources.ApplyResources(this.btnEffectUp, "btnEffectUp");
            this.btnEffectUp.Image = global::InternalFilters.Properties.Resources.effect_up_24x;
            this.btnEffectUp.Name = "btnEffectUp";
            this.toolTip.SetToolTip(this.btnEffectUp, resources.GetString("btnEffectUp.ToolTip"));
            this.btnEffectUp.UseVisualStyleBackColor = true;
            this.btnEffectUp.Click += new System.EventHandler(this.btnEffectUp_Click);
            // 
            // btnEffectRemove
            // 
            resources.ApplyResources(this.btnEffectRemove, "btnEffectRemove");
            this.btnEffectRemove.Image = global::InternalFilters.Properties.Resources.effect_remove_24x;
            this.btnEffectRemove.Name = "btnEffectRemove";
            this.toolTip.SetToolTip(this.btnEffectRemove, resources.GetString("btnEffectRemove.ToolTip"));
            this.btnEffectRemove.UseVisualStyleBackColor = true;
            this.btnEffectRemove.Click += new System.EventHandler(this.btnEffectRemove_Click);
            // 
            // btnEffectAdd
            // 
            resources.ApplyResources(this.btnEffectAdd, "btnEffectAdd");
            this.btnEffectAdd.Image = global::InternalFilters.Properties.Resources.effect_add_24x;
            this.btnEffectAdd.Name = "btnEffectAdd";
            this.toolTip.SetToolTip(this.btnEffectAdd, resources.GetString("btnEffectAdd.ToolTip"));
            this.btnEffectAdd.UseVisualStyleBackColor = true;
            this.btnEffectAdd.Click += new System.EventHandler(this.btnEffectAdd_Click);
            // 
            // btnPosRandom
            // 
            resources.ApplyResources(this.btnPosRandom, "btnPosRandom");
            this.btnPosRandom.Image = global::InternalFilters.Properties.Resources.Dice_24x;
            this.btnPosRandom.Name = "btnPosRandom";
            this.toolTip.SetToolTip(this.btnPosRandom, resources.GetString("btnPosRandom.ToolTip"));
            this.btnPosRandom.UseVisualStyleBackColor = true;
            this.btnPosRandom.Click += new System.EventHandler(this.btnPosRandom_Click);
            // 
            // btnOriginalPic
            // 
            resources.ApplyResources(this.btnOriginalPic, "btnOriginalPic");
            this.btnOriginalPic.Image = global::InternalFilters.Properties.Resources.Compare_24x;
            this.btnOriginalPic.Name = "btnOriginalPic";
            this.toolTip.SetToolTip(this.btnOriginalPic, resources.GetString("btnOriginalPic.ToolTip"));
            this.btnOriginalPic.UseVisualStyleBackColor = true;
            this.btnOriginalPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnOriginalPic_MouseDown);
            this.btnOriginalPic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnOriginalPic_MouseUp);
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // grpCommonSetting
            // 
            resources.ApplyResources(this.grpCommonSetting, "grpCommonSetting");
            this.grpCommonSetting.Controls.Add(this.slideOffsetY);
            this.grpCommonSetting.Controls.Add(this.slideOffsetX);
            this.grpCommonSetting.Controls.Add(this.slideMarginY);
            this.grpCommonSetting.Controls.Add(this.slideMarginX);
            this.grpCommonSetting.Controls.Add(this.pnlPosMode);
            this.grpCommonSetting.Controls.Add(this.slideBlend);
            this.grpCommonSetting.Controls.Add(this.slideOpacity);
            this.grpCommonSetting.Name = "grpCommonSetting";
            this.grpCommonSetting.TabStop = false;
            // 
            // slideOffsetY
            // 
            this.slideOffsetY.Caption = "Offset Y";
            this.slideOffsetY.DecimalPlaces = 0;
            resources.ApplyResources(this.slideOffsetY, "slideOffsetY");
            this.slideOffsetY.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.slideOffsetY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.slideOffsetY.Name = "slideOffsetY";
            this.slideOffsetY.Step = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.slideOffsetY.Unit = "%";
            this.slideOffsetY.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.slideOffsetY.ValueChanged += new System.EventHandler(this.slideValue_ValueChanged);
            // 
            // slideOffsetX
            // 
            this.slideOffsetX.Caption = "Offset X";
            this.slideOffsetX.DecimalPlaces = 0;
            resources.ApplyResources(this.slideOffsetX, "slideOffsetX");
            this.slideOffsetX.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.slideOffsetX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.slideOffsetX.Name = "slideOffsetX";
            this.slideOffsetX.Step = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.slideOffsetX.Unit = "%";
            this.slideOffsetX.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.slideOffsetX.ValueChanged += new System.EventHandler(this.slideValue_ValueChanged);
            // 
            // slideMarginY
            // 
            this.slideMarginY.Caption = "Margin Y";
            this.slideMarginY.DecimalPlaces = 0;
            resources.ApplyResources(this.slideMarginY, "slideMarginY");
            this.slideMarginY.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.slideMarginY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.slideMarginY.Name = "slideMarginY";
            this.slideMarginY.Step = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.slideMarginY.Unit = "%";
            this.slideMarginY.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.slideMarginY.ValueChanged += new System.EventHandler(this.slideValue_ValueChanged);
            // 
            // slideMarginX
            // 
            this.slideMarginX.Caption = "Margin X";
            this.slideMarginX.DecimalPlaces = 0;
            resources.ApplyResources(this.slideMarginX, "slideMarginX");
            this.slideMarginX.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.slideMarginX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.slideMarginX.Name = "slideMarginX";
            this.slideMarginX.Step = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.slideMarginX.Unit = "%";
            this.slideMarginX.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.slideMarginX.ValueChanged += new System.EventHandler(this.slideValue_ValueChanged);
            // 
            // pnlPosMode
            // 
            this.pnlPosMode.Controls.Add(this.chkEnabled);
            this.pnlPosMode.Controls.Add(this.chkTile);
            this.pnlPosMode.Controls.Add(this.btnPosRandom);
            this.pnlPosMode.Controls.Add(this.csSelect);
            resources.ApplyResources(this.pnlPosMode, "pnlPosMode");
            this.pnlPosMode.Name = "pnlPosMode";
            // 
            // chkEnabled
            // 
            resources.ApplyResources(this.chkEnabled, "chkEnabled");
            this.chkEnabled.AutoEllipsis = true;
            this.chkEnabled.Checked = true;
            this.chkEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.UseVisualStyleBackColor = true;
            // 
            // chkTile
            // 
            resources.ApplyResources(this.chkTile, "chkTile");
            this.chkTile.AutoEllipsis = true;
            this.chkTile.Name = "chkTile";
            this.chkTile.UseVisualStyleBackColor = true;
            this.chkTile.Click += new System.EventHandler(this.chkTile_Click);
            // 
            // csSelect
            // 
            resources.ApplyResources(this.csSelect, "csSelect");
            this.csSelect.CornetRegion = NetCharm.Common.CornerRegionType.None;
            this.csSelect.Name = "csSelect";
            this.csSelect.CornetRegionClick += new System.EventHandler(this.csSelect_CornetRegionClick);
            // 
            // slideBlend
            // 
            this.slideBlend.Caption = "Blend";
            this.slideBlend.DecimalPlaces = 0;
            resources.ApplyResources(this.slideBlend, "slideBlend");
            this.slideBlend.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.slideBlend.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.slideBlend.Name = "slideBlend";
            this.slideBlend.Step = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.slideBlend.Unit = "%";
            this.slideBlend.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.slideBlend.ValueChanged += new System.EventHandler(this.slideValue_ValueChanged);
            // 
            // slideOpacity
            // 
            this.slideOpacity.Caption = "Opacity";
            this.slideOpacity.DecimalPlaces = 0;
            resources.ApplyResources(this.slideOpacity, "slideOpacity");
            this.slideOpacity.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.slideOpacity.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.slideOpacity.Name = "slideOpacity";
            this.slideOpacity.Step = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.slideOpacity.Unit = "%";
            this.slideOpacity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.slideOpacity.ValueChanged += new System.EventHandler(this.slideValue_ValueChanged);
            // 
            // lvFilters
            // 
            resources.ApplyResources(this.lvFilters, "lvFilters");
            this.lvFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvFilters.CheckBoxes = true;
            this.lvFilters.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvFilters.HideSelection = false;
            this.lvFilters.LargeImageList = this.ilLarge;
            this.lvFilters.Name = "lvFilters";
            this.lvFilters.ShowItemToolTips = true;
            this.lvFilters.SmallImageList = this.ilSmall;
            this.lvFilters.UseCompatibleStateImageBehavior = false;
            this.lvFilters.View = System.Windows.Forms.View.List;
            this.lvFilters.VirtualMode = true;
            this.lvFilters.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.lvFilters_RetrieveVirtualItem);
            this.lvFilters.DoubleClick += new System.EventHandler(this.lvFilters_DoubleClick);
            this.lvFilters.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvFilters_KeyPress);
            this.lvFilters.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvFilters_MouseClick);
            // 
            // ilLarge
            // 
            this.ilLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            resources.ApplyResources(this.ilLarge, "ilLarge");
            this.ilLarge.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ilSmall
            // 
            this.ilSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            resources.ApplyResources(this.ilSmall, "ilSmall");
            this.ilSmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pnlEffectTools
            // 
            resources.ApplyResources(this.pnlEffectTools, "pnlEffectTools");
            this.pnlEffectTools.Controls.Add(this.btnEffectDown);
            this.pnlEffectTools.Controls.Add(this.btnEffectUp);
            this.pnlEffectTools.Controls.Add(this.btnEffectRemove);
            this.pnlEffectTools.Controls.Add(this.btnEffectAdd);
            this.pnlEffectTools.Name = "pnlEffectTools";
            // 
            // pnlCustom
            // 
            resources.ApplyResources(this.pnlCustom, "pnlCustom");
            this.pnlCustom.Controls.Add(this.tabObject);
            this.pnlCustom.Name = "pnlCustom";
            // 
            // tabObject
            // 
            resources.ApplyResources(this.tabObject, "tabObject");
            this.tabObject.Controls.Add(this.tabPagePicture);
            this.tabObject.Controls.Add(this.tabPageText);
            this.tabObject.Controls.Add(this.tabPageTag);
            this.tabObject.Name = "tabObject";
            this.tabObject.SelectedIndex = 0;
            this.tabObject.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabObject.SelectedIndexChanged += new System.EventHandler(this.tabObject_SelectedIndexChanged);
            // 
            // tabPagePicture
            // 
            this.tabPagePicture.Controls.Add(this.btnOriginalPic);
            this.tabPagePicture.Controls.Add(this.btnOpenPic);
            this.tabPagePicture.Controls.Add(this.imgPicture);
            resources.ApplyResources(this.tabPagePicture, "tabPagePicture");
            this.tabPagePicture.Name = "tabPagePicture";
            this.tabPagePicture.UseVisualStyleBackColor = true;
            // 
            // tabPageText
            // 
            this.tabPageText.Controls.Add(this.btnColorPicker);
            this.tabPageText.Controls.Add(this.imgText);
            this.tabPageText.Controls.Add(this.edText);
            this.tabPageText.Controls.Add(this.btnOpenFont);
            resources.ApplyResources(this.tabPageText, "tabPageText");
            this.tabPageText.Name = "tabPageText";
            this.tabPageText.UseVisualStyleBackColor = true;
            // 
            // imgText
            // 
            this.imgText.AllowDoubleClick = true;
            this.imgText.AllowDrop = true;
            this.imgText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.imgText, "imgText");
            this.imgText.ImageBorderStyle = Cyotek.Windows.Forms.ImageBoxBorderStyle.FixedSingleGlowShadow;
            this.imgText.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.imgText.Name = "imgText";
            this.imgText.ShowPixelGrid = true;
            // 
            // edText
            // 
            resources.ApplyResources(this.edText, "edText");
            this.edText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edText.Name = "edText";
            this.edText.TextChanged += new System.EventHandler(this.edText_TextChanged);
            // 
            // tabPageTag
            // 
            resources.ApplyResources(this.tabPageTag, "tabPageTag");
            this.tabPageTag.Name = "tabPageTag";
            this.tabPageTag.UseVisualStyleBackColor = true;
            // 
            // imgPreview
            // 
            this.imgPreview.AllowUnfocusedMouseWheel = true;
            resources.ApplyResources(this.imgPreview, "imgPreview");
            this.imgPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPreview.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.imgPreview.Name = "imgPreview";
            this.imgPreview.ShowPixelGrid = true;
            // 
            // imageActions
            // 
            resources.ApplyResources(this.imageActions, "imageActions");
            this.imageActions.BackColor = System.Drawing.SystemColors.Control;
            this.imageActions.ImageBox = this.imgPreview;
            this.imageActions.Name = "imageActions";
            this.imageActions.Source = null;
            this.imageActions.Zoom = 100;
            this.imageActions.ZoomLevels = zoomLevelCollection1;
            this.imageActions.ZoomOut += new System.EventHandler(this.imageActions_ZoomOut);
            this.imageActions.ZoomIn += new System.EventHandler(this.imageActions_ZoomIn);
            this.imageActions.ZoomChanged += new System.EventHandler(this.imageActions_ZoomChanged);
            this.imageActions.ViewOriginalDown += new System.EventHandler(this.imageActions_ViewOriginalDown);
            this.imageActions.ViewOriginalUp += new System.EventHandler(this.imageActions_ViewOriginalUp);
            // 
            // dlgFontEx
            // 
            this.dlgFontEx.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dlgFontEx.ShowApply = true;
            this.dlgFontEx.Size = 12F;
            this.dlgFontEx.Strikeout = false;
            this.dlgFontEx.Underline = false;
            this.dlgFontEx.UseFont = false;
            this.dlgFontEx.Apply += new System.EventHandler(this.dlgFont_Apply);
            // 
            // PinObjectForm
            // 
            this.AcceptButton = this.btnOk;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.imgPreview);
            this.Controls.Add(this.imageActions);
            this.Controls.Add(this.pnlCustom);
            this.Controls.Add(this.pnlEffectTools);
            this.Controls.Add(this.lvFilters);
            this.Controls.Add(this.grpCommonSetting);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "PinObjectForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.PinObjectForm_Load);
            this.grpCommonSetting.ResumeLayout(false);
            this.pnlPosMode.ResumeLayout(false);
            this.pnlEffectTools.ResumeLayout(false);
            this.pnlCustom.ResumeLayout(false);
            this.tabObject.ResumeLayout(false);
            this.tabPagePicture.ResumeLayout(false);
            this.tabPageText.ResumeLayout(false);
            this.tabPageText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpCommonSetting;
        private NetCharm.Common.Controls.SlideNumber slideBlend;
        private NetCharm.Common.Controls.SlideNumber slideOpacity;
        private System.Windows.Forms.Panel pnlPosMode;
        private System.Windows.Forms.CheckBox chkEnabled;
        private System.Windows.Forms.CheckBox chkTile;
        private System.Windows.Forms.Button btnPosRandom;
        private NetCharm.Common.Controls.CornerSide csSelect;
        private System.Windows.Forms.ListView lvFilters;
        private System.Windows.Forms.Panel pnlEffectTools;
        private System.Windows.Forms.Button btnEffectDown;
        private System.Windows.Forms.Button btnEffectUp;
        private System.Windows.Forms.Button btnEffectRemove;
        private System.Windows.Forms.Button btnEffectAdd;
        private System.Windows.Forms.Panel pnlCustom;
        private System.Windows.Forms.ImageList ilSmall;
        private System.Windows.Forms.ImageList ilLarge;
        private NetCharm.Common.Controls.SlideNumber slideOffsetY;
        private NetCharm.Common.Controls.SlideNumber slideOffsetX;
        private NetCharm.Common.Controls.SlideNumber slideMarginY;
        private NetCharm.Common.Controls.SlideNumber slideMarginX;
        private System.Windows.Forms.TabControl tabObject;
        private System.Windows.Forms.TabPage tabPagePicture;
        private System.Windows.Forms.TabPage tabPageText;
        private Cyotek.Windows.Forms.ImageBox imgPicture;
        private System.Windows.Forms.Button btnOpenPic;
        private System.Windows.Forms.TabPage tabPageTag;
        private System.Windows.Forms.TextBox edText;
        private System.Windows.Forms.Button btnOpenFont;
        private Cyotek.Windows.Forms.ImageBox imgText;
        private System.Windows.Forms.Button btnColorPicker;
        private NetCharm.Common.Controls.FontDialogEx dlgFontEx;
        private System.Windows.Forms.Button btnOriginalPic;
        private NetCharm.Common.Controls.ImageActions imageActions;
        private Cyotek.Windows.Forms.ImageBox imgPreview;
    }
}