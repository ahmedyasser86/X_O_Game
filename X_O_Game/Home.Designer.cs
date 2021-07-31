
namespace X_O_Game
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.pnl_Holder = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnl_Home = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_Exit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_Options = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_Start = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnl_Holder.SuspendLayout();
            this.pnl_Home.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = false;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = true;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = true;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // pnl_Holder
            // 
            this.pnl_Holder.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnl_Holder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Holder.BackgroundImage")));
            this.pnl_Holder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Holder.BorderColor = System.Drawing.Color.Transparent;
            this.pnl_Holder.BorderRadius = 3;
            this.pnl_Holder.BorderThickness = 1;
            this.pnl_Holder.Controls.Add(this.pnl_Home);
            this.pnl_Holder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Holder.Location = new System.Drawing.Point(0, 0);
            this.pnl_Holder.Name = "pnl_Holder";
            this.pnl_Holder.ShowBorders = true;
            this.pnl_Holder.Size = new System.Drawing.Size(1024, 686);
            this.pnl_Holder.TabIndex = 0;
            // 
            // pnl_Home
            // 
            this.pnl_Home.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnl_Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Home.BackgroundImage")));
            this.pnl_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Home.BorderColor = System.Drawing.Color.Transparent;
            this.pnl_Home.BorderRadius = 3;
            this.pnl_Home.BorderThickness = 1;
            this.pnl_Home.Controls.Add(this.btn_Exit);
            this.pnl_Home.Controls.Add(this.btn_Options);
            this.pnl_Home.Controls.Add(this.btn_Start);
            this.pnl_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Home.Location = new System.Drawing.Point(0, 0);
            this.pnl_Home.Name = "pnl_Home";
            this.pnl_Home.ShowBorders = true;
            this.pnl_Home.Size = new System.Drawing.Size(1024, 686);
            this.pnl_Home.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.AllowAnimations = true;
            this.btn_Exit.AllowMouseEffects = true;
            this.btn_Exit.AllowToggling = false;
            this.btn_Exit.AnimationSpeed = 200;
            this.btn_Exit.AutoGenerateColors = false;
            this.btn_Exit.AutoRoundBorders = true;
            this.btn_Exit.AutoSizeLeftIcon = true;
            this.btn_Exit.AutoSizeRightIcon = true;
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(164)))));
            this.btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.BackgroundImage")));
            this.btn_Exit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Exit.ButtonText = "Quit";
            this.btn_Exit.ButtonTextMarginLeft = 0;
            this.btn_Exit.ColorContrastOnClick = 45;
            this.btn_Exit.ColorContrastOnHover = 45;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_Exit.CustomizableEdges = borderEdges1;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Exit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Exit.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Exit.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Exit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Exit.Font = new System.Drawing.Font("Showcard Gothic", 24F);
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Exit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Exit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Exit.IconMarginLeft = 11;
            this.btn_Exit.IconPadding = 10;
            this.btn_Exit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Exit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Exit.IconSize = 25;
            this.btn_Exit.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Exit.IdleBorderRadius = 70;
            this.btn_Exit.IdleBorderThickness = 1;
            this.btn_Exit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(164)))));
            this.btn_Exit.IdleIconLeftImage = null;
            this.btn_Exit.IdleIconRightImage = null;
            this.btn_Exit.IndicateFocus = false;
            this.btn_Exit.Location = new System.Drawing.Point(386, 412);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Exit.OnDisabledState.BorderRadius = 1;
            this.btn_Exit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Exit.OnDisabledState.BorderThickness = 1;
            this.btn_Exit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Exit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Exit.OnDisabledState.IconLeftImage = null;
            this.btn_Exit.OnDisabledState.IconRightImage = null;
            this.btn_Exit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btn_Exit.onHoverState.BorderRadius = 1;
            this.btn_Exit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Exit.onHoverState.BorderThickness = 1;
            this.btn_Exit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btn_Exit.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(164)))));
            this.btn_Exit.onHoverState.IconLeftImage = null;
            this.btn_Exit.onHoverState.IconRightImage = null;
            this.btn_Exit.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Exit.OnIdleState.BorderRadius = 1;
            this.btn_Exit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Exit.OnIdleState.BorderThickness = 1;
            this.btn_Exit.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(164)))));
            this.btn_Exit.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Exit.OnIdleState.IconLeftImage = null;
            this.btn_Exit.OnIdleState.IconRightImage = null;
            this.btn_Exit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Exit.OnPressedState.BorderRadius = 1;
            this.btn_Exit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Exit.OnPressedState.BorderThickness = 1;
            this.btn_Exit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(164)))));
            this.btn_Exit.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Exit.OnPressedState.IconLeftImage = null;
            this.btn_Exit.OnPressedState.IconRightImage = null;
            this.btn_Exit.Size = new System.Drawing.Size(252, 72);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Exit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Exit.TextMarginLeft = 0;
            this.btn_Exit.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Exit.UseDefaultRadiusAndThickness = true;
            // 
            // btn_Options
            // 
            this.btn_Options.AllowAnimations = true;
            this.btn_Options.AllowMouseEffects = true;
            this.btn_Options.AllowToggling = false;
            this.btn_Options.AnimationSpeed = 200;
            this.btn_Options.AutoGenerateColors = false;
            this.btn_Options.AutoRoundBorders = true;
            this.btn_Options.AutoSizeLeftIcon = true;
            this.btn_Options.AutoSizeRightIcon = true;
            this.btn_Options.BackColor = System.Drawing.Color.Transparent;
            this.btn_Options.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(164)))));
            this.btn_Options.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Options.BackgroundImage")));
            this.btn_Options.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Options.ButtonText = "Options";
            this.btn_Options.ButtonTextMarginLeft = 0;
            this.btn_Options.ColorContrastOnClick = 45;
            this.btn_Options.ColorContrastOnHover = 45;
            this.btn_Options.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_Options.CustomizableEdges = borderEdges2;
            this.btn_Options.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Options.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Options.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Options.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Options.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Options.Font = new System.Drawing.Font("Showcard Gothic", 24F);
            this.btn_Options.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Options.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Options.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Options.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Options.IconMarginLeft = 11;
            this.btn_Options.IconPadding = 10;
            this.btn_Options.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Options.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Options.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Options.IconSize = 25;
            this.btn_Options.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Options.IdleBorderRadius = 70;
            this.btn_Options.IdleBorderThickness = 1;
            this.btn_Options.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(164)))));
            this.btn_Options.IdleIconLeftImage = null;
            this.btn_Options.IdleIconRightImage = null;
            this.btn_Options.IndicateFocus = false;
            this.btn_Options.Location = new System.Drawing.Point(386, 307);
            this.btn_Options.Name = "btn_Options";
            this.btn_Options.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Options.OnDisabledState.BorderRadius = 1;
            this.btn_Options.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Options.OnDisabledState.BorderThickness = 1;
            this.btn_Options.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Options.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Options.OnDisabledState.IconLeftImage = null;
            this.btn_Options.OnDisabledState.IconRightImage = null;
            this.btn_Options.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btn_Options.onHoverState.BorderRadius = 1;
            this.btn_Options.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Options.onHoverState.BorderThickness = 1;
            this.btn_Options.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btn_Options.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(164)))));
            this.btn_Options.onHoverState.IconLeftImage = null;
            this.btn_Options.onHoverState.IconRightImage = null;
            this.btn_Options.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Options.OnIdleState.BorderRadius = 1;
            this.btn_Options.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Options.OnIdleState.BorderThickness = 1;
            this.btn_Options.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(164)))));
            this.btn_Options.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Options.OnIdleState.IconLeftImage = null;
            this.btn_Options.OnIdleState.IconRightImage = null;
            this.btn_Options.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Options.OnPressedState.BorderRadius = 1;
            this.btn_Options.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Options.OnPressedState.BorderThickness = 1;
            this.btn_Options.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(164)))));
            this.btn_Options.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Options.OnPressedState.IconLeftImage = null;
            this.btn_Options.OnPressedState.IconRightImage = null;
            this.btn_Options.Size = new System.Drawing.Size(252, 72);
            this.btn_Options.TabIndex = 2;
            this.btn_Options.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Options.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Options.TextMarginLeft = 0;
            this.btn_Options.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Options.UseDefaultRadiusAndThickness = true;
            // 
            // btn_Start
            // 
            this.btn_Start.AllowAnimations = true;
            this.btn_Start.AllowMouseEffects = true;
            this.btn_Start.AllowToggling = false;
            this.btn_Start.AnimationSpeed = 200;
            this.btn_Start.AutoGenerateColors = false;
            this.btn_Start.AutoRoundBorders = true;
            this.btn_Start.AutoSizeLeftIcon = true;
            this.btn_Start.AutoSizeRightIcon = true;
            this.btn_Start.BackColor = System.Drawing.Color.Transparent;
            this.btn_Start.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Start.BackgroundImage")));
            this.btn_Start.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Start.ButtonText = "Start";
            this.btn_Start.ButtonTextMarginLeft = 0;
            this.btn_Start.ColorContrastOnClick = 45;
            this.btn_Start.ColorContrastOnHover = 45;
            this.btn_Start.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btn_Start.CustomizableEdges = borderEdges3;
            this.btn_Start.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Start.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Start.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Start.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Start.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Start.Font = new System.Drawing.Font("Showcard Gothic", 24F);
            this.btn_Start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(164)))));
            this.btn_Start.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Start.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Start.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Start.IconMarginLeft = 11;
            this.btn_Start.IconPadding = 10;
            this.btn_Start.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Start.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Start.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Start.IconSize = 25;
            this.btn_Start.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Start.IdleBorderRadius = 70;
            this.btn_Start.IdleBorderThickness = 1;
            this.btn_Start.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Start.IdleIconLeftImage = null;
            this.btn_Start.IdleIconRightImage = null;
            this.btn_Start.IndicateFocus = false;
            this.btn_Start.Location = new System.Drawing.Point(386, 202);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Start.OnDisabledState.BorderRadius = 1;
            this.btn_Start.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Start.OnDisabledState.BorderThickness = 1;
            this.btn_Start.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Start.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Start.OnDisabledState.IconLeftImage = null;
            this.btn_Start.OnDisabledState.IconRightImage = null;
            this.btn_Start.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btn_Start.onHoverState.BorderRadius = 1;
            this.btn_Start.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Start.onHoverState.BorderThickness = 1;
            this.btn_Start.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btn_Start.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(164)))));
            this.btn_Start.onHoverState.IconLeftImage = null;
            this.btn_Start.onHoverState.IconRightImage = null;
            this.btn_Start.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Start.OnIdleState.BorderRadius = 1;
            this.btn_Start.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Start.OnIdleState.BorderThickness = 1;
            this.btn_Start.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Start.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(164)))));
            this.btn_Start.OnIdleState.IconLeftImage = null;
            this.btn_Start.OnIdleState.IconRightImage = null;
            this.btn_Start.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Start.OnPressedState.BorderRadius = 1;
            this.btn_Start.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Start.OnPressedState.BorderThickness = 1;
            this.btn_Start.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Start.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(164)))));
            this.btn_Start.OnPressedState.IconLeftImage = null;
            this.btn_Start.OnPressedState.IconRightImage = null;
            this.btn_Start.Size = new System.Drawing.Size(252, 72);
            this.btn_Start.TabIndex = 3;
            this.btn_Start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Start.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Start.TextMarginLeft = 0;
            this.btn_Start.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Start.UseDefaultRadiusAndThickness = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(1024, 686);
            this.Controls.Add(this.pnl_Holder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.pnl_Holder.ResumeLayout(false);
            this.pnl_Home.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private Bunifu.UI.WinForms.BunifuPanel pnl_Holder;
        private Bunifu.UI.WinForms.BunifuPanel pnl_Home;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Exit;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Options;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Start;
    }
}

