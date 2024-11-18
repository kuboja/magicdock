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

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Crownwood.Magic.Controls;


namespace SampleWizard;

public partial class SampleWizard : Crownwood.Magic.Forms.WizardDialog
{
    private Timer installTimer;
    private int installCount;

    public SampleWizard()
    {
        // This call is required by the Windows Form Designer.
        InitializeComponent();

        // TODO: Add any initialization after the InitializeComponent call
    }

    private void radioButton4_CheckedChanged(object sender, System.EventArgs e)
    {
        if (this.radioButton4.Checked)
        {
            this.wizardControl.EnableNextButton = WizardControl.Status.Default;
            radioButton5.Checked = false;
        }
        else
        {
            this.wizardControl.EnableNextButton = WizardControl.Status.No;
            radioButton5.Checked = true;
        }
    }

    private void radioButton5_CheckedChanged(object sender, System.EventArgs e)
    {
        if (this.radioButton5.Checked)
        {
            this.wizardControl.EnableNextButton = WizardControl.Status.No;
            radioButton4.Checked = false;
        }
        else
        {
            this.wizardControl.EnableNextButton = WizardControl.Status.Default;
            radioButton4.Checked = true;
        }
    }

    protected override void OnWizardPageEnter(Crownwood.Magic.Controls.WizardPage wp,
                                              Crownwood.Magic.Controls.WizardControl wc)
    {
        // Asking for licence terms by entering page?
        if (wp.Name == "wizardLegal")
        {
            if (this.radioButton4.Checked)
                wc.EnableNextButton = WizardControl.Status.Default;
            else
                wc.EnableNextButton = WizardControl.Status.No;
        }

        // Started the installation process by entering page 5?
        if (wp.Name == "wizardInstall")
        {
            // Kick off a timer to represent progress
            installCount = 0;
            installTimer = new Timer();
            installTimer.Interval = 250;
            installTimer.Tick += new EventHandler(OnProgressTick);
            installTimer.Start();
        }
    }

    protected override void OnWizardPageLeave(Crownwood.Magic.Controls.WizardPage wp,
                                              Crownwood.Magic.Controls.WizardControl wc)
    {
        // Leaving page means we have to restore default status of next button
        if (wp.Name == "wizardLegal")
        {
            // Default the next button to disable
            wc.EnableNextButton = WizardControl.Status.Default;
        }
    }

    protected override void OnCancelClick(object sender, System.EventArgs e)
    {
        // Suspend any installation process if happening
        if (installTimer != null)
            installTimer.Stop();

        if (MessageBox.Show(this, "Sure you want to exit?", "Cancel Pressed", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            // Let base class close the form
            base.OnCancelClick(sender, e);
        }
        else
        {
            // Resume any installation process if happening
            if (installTimer != null)
                installTimer.Start();
        }
    }

    private void OnProgressTick(object sender, EventArgs e)
    {
        installCount++;

        // Finished yet?
        if (installCount >= 20)
        {
            // No longer need to simulate actions
            installTimer.Stop();

            // Move to last page
            base.wizardControl.SelectedIndex = base.wizardControl.WizardPages.Count - 1;
        }
        else
        {
            // Update percentage completed
            progressBar1.Value = 100 / 20 * installCount;
        }
    }

    private void button1_Click(object sender, System.EventArgs e)
    {
        this.wizardControl.WizardPages.Add(new WizardPage());
    }
}

