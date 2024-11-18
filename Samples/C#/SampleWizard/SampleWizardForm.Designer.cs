// *****************************************************************************
// 
//  (c) Crownwood Consulting Limited 2002 
//  All rights reserved. The software and associated documentation 
//  supplied hereunder are the proprietary information of Crownwood Consulting 
//	Limited, Haxey, North Lincolnshire, England and are supplied subject to 
//	licence terms.
// 
//  Magic Version 1.7	www.dotnetmagic.com
// *****************************************************************************

namespace SampleWizard;

public partial class SampleWizard
{
    private Crownwood.Magic.Controls.WizardPage wizardStartPage;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private Crownwood.Magic.Controls.WizardPage wizardInfo1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.RadioButton radioButton3;
    private Crownwood.Magic.Controls.WizardPage wizardLegal;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.RadioButton radioButton4;
    private System.Windows.Forms.RadioButton radioButton5;
    private Crownwood.Magic.Controls.WizardPage wizardInstall;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Label label7;
    private Crownwood.Magic.Controls.WizardPage wizardFinish;
    private Crownwood.Magic.Controls.WizardPage wizardWarn;
    private Crownwood.Magic.Controls.WizardPage wizardInfo2;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleWizard));
        wizardStartPage = new Crownwood.Magic.Controls.WizardPage();
        label3 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        wizardInfo1 = new Crownwood.Magic.Controls.WizardPage();
        groupBox1 = new System.Windows.Forms.GroupBox();
        radioButton3 = new System.Windows.Forms.RadioButton();
        radioButton2 = new System.Windows.Forms.RadioButton();
        radioButton1 = new System.Windows.Forms.RadioButton();
        wizardLegal = new Crownwood.Magic.Controls.WizardPage();
        radioButton5 = new System.Windows.Forms.RadioButton();
        radioButton4 = new System.Windows.Forms.RadioButton();
        label4 = new System.Windows.Forms.Label();
        textBox1 = new System.Windows.Forms.TextBox();
        wizardWarn = new Crownwood.Magic.Controls.WizardPage();
        label6 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        wizardInstall = new Crownwood.Magic.Controls.WizardPage();
        label7 = new System.Windows.Forms.Label();
        progressBar1 = new System.Windows.Forms.ProgressBar();
        wizardFinish = new Crownwood.Magic.Controls.WizardPage();
        label10 = new System.Windows.Forms.Label();
        wizardInfo2 = new Crownwood.Magic.Controls.WizardPage();
        label9 = new System.Windows.Forms.Label();
        textBox3 = new System.Windows.Forms.TextBox();
        label8 = new System.Windows.Forms.Label();
        textBox2 = new System.Windows.Forms.TextBox();
        wizardStartPage.SuspendLayout();
        wizardInfo1.SuspendLayout();
        groupBox1.SuspendLayout();
        wizardLegal.SuspendLayout();
        wizardWarn.SuspendLayout();
        wizardInstall.SuspendLayout();
        wizardFinish.SuspendLayout();
        wizardInfo2.SuspendLayout();
        SuspendLayout();
        // 
        // wizardControl
        // 
        wizardControl.AssignDefaultButton = true;
        wizardControl.Profile = Crownwood.Magic.Controls.WizardControl.Profiles.Install;
        wizardControl.SelectedIndex = 0;
        wizardControl.Size = new System.Drawing.Size(484, 422);
        wizardControl.Title = "Sample Wizard using Install Profile";
        wizardControl.WizardPages.AddRange(new Crownwood.Magic.Controls.WizardPage[] { wizardStartPage, wizardLegal, wizardInfo1, wizardInfo2, wizardWarn, wizardInstall, wizardFinish });
        // 
        // wizardStartPage
        // 
        wizardStartPage.CaptionTitle = "Sample Description";
        wizardStartPage.Controls.Add(label3);
        wizardStartPage.Controls.Add(label2);
        wizardStartPage.Controls.Add(label1);
        wizardStartPage.FullPage = false;
        wizardStartPage.Location = new System.Drawing.Point(0, 0);
        wizardStartPage.Name = "wizardStartPage";
        wizardStartPage.Size = new System.Drawing.Size(484, 293);
        wizardStartPage.SubTitle = "Start page explaining what this sample demonstrates";
        wizardStartPage.TabIndex = 3;
        wizardStartPage.Title = "Start";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(10, 167);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(480, 79);
        label3.TabIndex = 3;
        label3.Text = resources.GetString("label3.Text");
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(10, 89);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(480, 78);
        label2.TabIndex = 2;
        label2.Text = resources.GetString("label2.Text");
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(10, 10);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(480, 69);
        label1.TabIndex = 1;
        label1.Tag = "s";
        label1.Text = resources.GetString("label1.Text");
        // 
        // wizardInfo1
        // 
        wizardInfo1.CaptionTitle = "Gather Info 1";
        wizardInfo1.Controls.Add(groupBox1);
        wizardInfo1.FullPage = false;
        wizardInfo1.Location = new System.Drawing.Point(0, 0);
        wizardInfo1.Name = "wizardInfo1";
        wizardInfo1.Selected = false;
        wizardInfo1.Size = new System.Drawing.Size(484, 293);
        wizardInfo1.SubTitle = "This is the first of two pages for gathering input";
        wizardInfo1.TabIndex = 4;
        wizardInfo1.Title = "Info1";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(radioButton3);
        groupBox1.Controls.Add(radioButton2);
        groupBox1.Controls.Add(radioButton1);
        groupBox1.Location = new System.Drawing.Point(29, 20);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(192, 187);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Example of Selection";
        // 
        // radioButton3
        // 
        radioButton3.Location = new System.Drawing.Point(38, 138);
        radioButton3.Name = "radioButton3";
        radioButton3.Size = new System.Drawing.Size(125, 29);
        radioButton3.TabIndex = 2;
        radioButton3.Text = "Debug Install";
        // 
        // radioButton2
        // 
        radioButton2.Location = new System.Drawing.Point(38, 89);
        radioButton2.Name = "radioButton2";
        radioButton2.Size = new System.Drawing.Size(125, 29);
        radioButton2.TabIndex = 1;
        radioButton2.Text = "Server Install";
        // 
        // radioButton1
        // 
        radioButton1.Location = new System.Drawing.Point(38, 39);
        radioButton1.Name = "radioButton1";
        radioButton1.Size = new System.Drawing.Size(125, 30);
        radioButton1.TabIndex = 0;
        radioButton1.Text = "Client Install";
        // 
        // wizardLegal
        // 
        wizardLegal.CaptionTitle = "Standard Legal Notice";
        wizardLegal.Controls.Add(radioButton5);
        wizardLegal.Controls.Add(radioButton4);
        wizardLegal.Controls.Add(label4);
        wizardLegal.Controls.Add(textBox1);
        wizardLegal.FullPage = false;
        wizardLegal.Location = new System.Drawing.Point(0, 0);
        wizardLegal.Name = "wizardLegal";
        wizardLegal.Selected = false;
        wizardLegal.Size = new System.Drawing.Size(484, 293);
        wizardLegal.SubTitle = "Force the user to agree a license agreement for product";
        wizardLegal.TabIndex = 5;
        wizardLegal.Title = "Legal";
        // 
        // radioButton5
        // 
        radioButton5.Checked = true;
        radioButton5.Location = new System.Drawing.Point(259, 197);
        radioButton5.Name = "radioButton5";
        radioButton5.Size = new System.Drawing.Size(106, 29);
        radioButton5.TabIndex = 3;
        radioButton5.TabStop = true;
        radioButton5.Text = "I Disagree";
        radioButton5.CheckedChanged += radioButton5_CheckedChanged;
        // 
        // radioButton4
        // 
        radioButton4.Location = new System.Drawing.Point(144, 197);
        radioButton4.Name = "radioButton4";
        radioButton4.Size = new System.Drawing.Size(86, 29);
        radioButton4.TabIndex = 2;
        radioButton4.Text = "I Agree";
        radioButton4.CheckedChanged += radioButton4_CheckedChanged;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(38, 10);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(120, 28);
        label4.TabIndex = 1;
        label4.Text = "Must Agree Terms";
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(38, 39);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(423, 148);
        textBox1.TabIndex = 0;
        textBox1.Text = "You must select 'I Agree' before the 'Next' button will enable itself. This custom action is not part of the WizardControl, see the sample code which is trivial.";
        // 
        // wizardWarn
        // 
        wizardWarn.CaptionTitle = "Warning, about to install";
        wizardWarn.Controls.Add(label6);
        wizardWarn.Controls.Add(label5);
        wizardWarn.FullPage = false;
        wizardWarn.Location = new System.Drawing.Point(0, 0);
        wizardWarn.Name = "wizardWarn";
        wizardWarn.Selected = false;
        wizardWarn.Size = new System.Drawing.Size(484, 293);
        wizardWarn.SubTitle = "This warns user that installation is about to begin";
        wizardWarn.TabIndex = 6;
        wizardWarn.Title = "Warn";
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(48, 69);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(432, 79);
        label6.TabIndex = 1;
        label6.Text = "Warn user that pressing 'Next' will begin installation process.";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(48, 20);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(336, 29);
        label5.TabIndex = 0;
        label5.Text = "Last page before installation.";
        // 
        // wizardInstall
        // 
        wizardInstall.CaptionTitle = "Installing";
        wizardInstall.Controls.Add(label7);
        wizardInstall.Controls.Add(progressBar1);
        wizardInstall.FullPage = false;
        wizardInstall.Location = new System.Drawing.Point(0, 0);
        wizardInstall.Name = "wizardInstall";
        wizardInstall.Selected = false;
        wizardInstall.Size = new System.Drawing.Size(484, 293);
        wizardInstall.SubTitle = "Perform some fake installation process";
        wizardInstall.TabIndex = 7;
        wizardInstall.Title = "Install";
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(48, 20);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(120, 28);
        label7.TabIndex = 1;
        label7.Text = "Fake Installation";
        // 
        // progressBar1
        // 
        progressBar1.Location = new System.Drawing.Point(48, 59);
        progressBar1.Name = "progressBar1";
        progressBar1.Size = new System.Drawing.Size(394, 30);
        progressBar1.TabIndex = 0;
        // 
        // wizardFinish
        // 
        wizardFinish.CaptionTitle = "Intall Complete";
        wizardFinish.Controls.Add(label10);
        wizardFinish.FullPage = false;
        wizardFinish.Location = new System.Drawing.Point(0, 0);
        wizardFinish.Name = "wizardFinish";
        wizardFinish.Selected = false;
        wizardFinish.Size = new System.Drawing.Size(484, 293);
        wizardFinish.SubTitle = "This page gives the success or failure of attempting the previous install process";
        wizardFinish.TabIndex = 8;
        wizardFinish.Title = "Finished";
        // 
        // label10
        // 
        label10.Location = new System.Drawing.Point(38, 20);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(365, 128);
        label10.TabIndex = 0;
        label10.Text = "Installation has completed with success.";
        // 
        // wizardInfo2
        // 
        wizardInfo2.CaptionTitle = "Gather Info 2";
        wizardInfo2.Controls.Add(label9);
        wizardInfo2.Controls.Add(textBox3);
        wizardInfo2.Controls.Add(label8);
        wizardInfo2.Controls.Add(textBox2);
        wizardInfo2.FullPage = false;
        wizardInfo2.Location = new System.Drawing.Point(0, 0);
        wizardInfo2.Name = "wizardInfo2";
        wizardInfo2.Selected = false;
        wizardInfo2.Size = new System.Drawing.Size(484, 293);
        wizardInfo2.SubTitle = "This is the second of two pages for gathering input";
        wizardInfo2.TabIndex = 9;
        wizardInfo2.Title = "Info2";
        // 
        // label9
        // 
        label9.Location = new System.Drawing.Point(58, 98);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(163, 29);
        label9.TabIndex = 3;
        label9.Text = "Enter Company Name";
        // 
        // textBox3
        // 
        textBox3.Location = new System.Drawing.Point(58, 128);
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(192, 23);
        textBox3.TabIndex = 2;
        textBox3.Text = "ACNE Corp.";
        // 
        // label8
        // 
        label8.Location = new System.Drawing.Point(58, 20);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(120, 28);
        label8.TabIndex = 1;
        label8.Text = "Enter Username";
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(58, 49);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(192, 23);
        textBox2.TabIndex = 0;
        textBox2.Text = "Anon";
        // 
        // SampleWizard
        // 
        AutoScaleBaseSize = new System.Drawing.Size(6, 16);
        ClientSize = new System.Drawing.Size(500, 420);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        Name = "SampleWizard";
        TitleMode = TitleModes.Steps;
        wizardStartPage.ResumeLayout(false);
        wizardInfo1.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        wizardLegal.ResumeLayout(false);
        wizardLegal.PerformLayout();
        wizardWarn.ResumeLayout(false);
        wizardInstall.ResumeLayout(false);
        wizardFinish.ResumeLayout(false);
        wizardInfo2.ResumeLayout(false);
        wizardInfo2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
}

