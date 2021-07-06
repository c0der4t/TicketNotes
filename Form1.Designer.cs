
namespace MaterialSkin_TestApp
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmr_HideForm = new System.Windows.Forms.Timer(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabNotes = new System.Windows.Forms.TabPage();
            this.lblTicketNotes = new MaterialSkin.Controls.MaterialLabel();
            this.materialMultiLineTextBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.switchAutoSaveNotes = new MaterialSkin.Controls.MaterialSwitch();
            this.materialSlider1 = new MaterialSkin.Controls.MaterialSlider();
            this.switch_ThemeMode = new MaterialSkin.Controls.MaterialSwitch();
            this.tabselector_Options = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1.SuspendLayout();
            this.tabNotes.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmr_HideForm
            // 
            this.tmr_HideForm.Enabled = true;
            this.tmr_HideForm.Interval = 5000;
            this.tmr_HideForm.Tick += new System.EventHandler(this.tmr_HideForm_Tick);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabNotes);
            this.materialTabControl1.Controls.Add(this.tabSettings);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(534, 413);
            this.materialTabControl1.TabIndex = 2;
            // 
            // tabNotes
            // 
            this.tabNotes.Controls.Add(this.materialButton1);
            this.tabNotes.Controls.Add(this.lblTicketNotes);
            this.tabNotes.Controls.Add(this.materialMultiLineTextBox1);
            this.tabNotes.Location = new System.Drawing.Point(4, 24);
            this.tabNotes.Name = "tabNotes";
            this.tabNotes.Padding = new System.Windows.Forms.Padding(3);
            this.tabNotes.Size = new System.Drawing.Size(526, 385);
            this.tabNotes.TabIndex = 0;
            this.tabNotes.Text = "Notes";
            this.tabNotes.UseVisualStyleBackColor = true;
            // 
            // lblTicketNotes
            // 
            this.lblTicketNotes.AutoSize = true;
            this.lblTicketNotes.Depth = 0;
            this.lblTicketNotes.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTicketNotes.Location = new System.Drawing.Point(3, 113);
            this.lblTicketNotes.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTicketNotes.Name = "lblTicketNotes";
            this.lblTicketNotes.Size = new System.Drawing.Size(89, 19);
            this.lblTicketNotes.TabIndex = 1;
            this.lblTicketNotes.Text = "Ticket Notes";
            // 
            // materialMultiLineTextBox1
            // 
            this.materialMultiLineTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialMultiLineTextBox1.Depth = 0;
            this.materialMultiLineTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialMultiLineTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBox1.Hint = "Write your ticket notes here.";
            this.materialMultiLineTextBox1.Location = new System.Drawing.Point(3, 112);
            this.materialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBox1.Name = "materialMultiLineTextBox1";
            this.materialMultiLineTextBox1.Size = new System.Drawing.Size(520, 270);
            this.materialMultiLineTextBox1.TabIndex = 0;
            this.materialMultiLineTextBox1.Text = "";
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.materialSwitch1);
            this.tabSettings.Controls.Add(this.switchAutoSaveNotes);
            this.tabSettings.Controls.Add(this.materialSlider1);
            this.tabSettings.Controls.Add(this.switch_ThemeMode);
            this.tabSettings.Location = new System.Drawing.Point(4, 24);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(526, 385);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.BackColor = System.Drawing.Color.DimGray;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.materialSwitch1.ForeColor = System.Drawing.Color.White;
            this.materialSwitch1.Location = new System.Drawing.Point(6, 107);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(171, 29);
            this.materialSwitch1.TabIndex = 4;
            this.materialSwitch1.Text = "Estimate Time";
            this.materialSwitch1.UseVisualStyleBackColor = false;
            // 
            // switchAutoSaveNotes
            // 
            this.switchAutoSaveNotes.BackColor = System.Drawing.Color.DimGray;
            this.switchAutoSaveNotes.Depth = 0;
            this.switchAutoSaveNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.switchAutoSaveNotes.ForeColor = System.Drawing.Color.White;
            this.switchAutoSaveNotes.Location = new System.Drawing.Point(6, 66);
            this.switchAutoSaveNotes.Margin = new System.Windows.Forms.Padding(0);
            this.switchAutoSaveNotes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchAutoSaveNotes.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchAutoSaveNotes.Name = "switchAutoSaveNotes";
            this.switchAutoSaveNotes.Ripple = true;
            this.switchAutoSaveNotes.Size = new System.Drawing.Size(171, 29);
            this.switchAutoSaveNotes.TabIndex = 3;
            this.switchAutoSaveNotes.Text = "Autosave";
            this.switchAutoSaveNotes.UseVisualStyleBackColor = false;
            // 
            // materialSlider1
            // 
            this.materialSlider1.Depth = 0;
            this.materialSlider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider1.Location = new System.Drawing.Point(6, 3);
            this.materialSlider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider1.Name = "materialSlider1";
            this.materialSlider1.RangeMax = 10;
            this.materialSlider1.Size = new System.Drawing.Size(330, 40);
            this.materialSlider1.TabIndex = 2;
            this.materialSlider1.Text = "Auto Hide Timeout (m)";
            this.materialSlider1.Value = 5;
            // 
            // switch_ThemeMode
            // 
            this.switch_ThemeMode.BackColor = System.Drawing.Color.DimGray;
            this.switch_ThemeMode.Depth = 0;
            this.switch_ThemeMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.switch_ThemeMode.ForeColor = System.Drawing.Color.White;
            this.switch_ThemeMode.Location = new System.Drawing.Point(354, 3);
            this.switch_ThemeMode.Margin = new System.Windows.Forms.Padding(0);
            this.switch_ThemeMode.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switch_ThemeMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.switch_ThemeMode.Name = "switch_ThemeMode";
            this.switch_ThemeMode.Ripple = true;
            this.switch_ThemeMode.Size = new System.Drawing.Size(159, 40);
            this.switch_ThemeMode.TabIndex = 1;
            this.switch_ThemeMode.Text = "Dark Mode";
            this.switch_ThemeMode.UseVisualStyleBackColor = false;
            this.switch_ThemeMode.CheckedChanged += new System.EventHandler(this.switch_ThemeMode_CheckedChanged);
            // 
            // tabselector_Options
            // 
            this.tabselector_Options.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabselector_Options.BaseTabControl = this.materialTabControl1;
            this.tabselector_Options.Depth = 0;
            this.tabselector_Options.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabselector_Options.Location = new System.Drawing.Point(132, 32);
            this.tabselector_Options.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabselector_Options.Name = "tabselector_Options";
            this.tabselector_Options.Size = new System.Drawing.Size(401, 26);
            this.tabselector_Options.TabIndex = 4;
            this.tabselector_Options.TabIndicatorHeight = 1;
            this.tabselector_Options.Text = "Options";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(389, 113);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(137, 19);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.Text = "COPY NOTES";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(540, 480);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.tabselector_Options);
            this.DrawerAutoHide = false;
            this.DrawerAutoShow = true;
            this.DrawerIndicatorWidth = 1;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Ticket Notes";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.ResizeEnd += new System.EventHandler(this.frmMain_ResizeEnd);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.MouseEnter += new System.EventHandler(this.frmMain_MouseEnter);
            this.materialTabControl1.ResumeLayout(false);
            this.tabNotes.ResumeLayout(false);
            this.tabNotes.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmr_HideForm;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabNotes;
        private System.Windows.Forms.TabPage tabSettings;
        private MaterialSkin.Controls.MaterialSwitch switch_ThemeMode;
        private MaterialSkin.Controls.MaterialTabSelector tabselector_Options;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox1;
        private MaterialSkin.Controls.MaterialLabel lblTicketNotes;
        private MaterialSkin.Controls.MaterialSlider materialSlider1;
        private MaterialSkin.Controls.MaterialSwitch switchAutoSaveNotes;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}

