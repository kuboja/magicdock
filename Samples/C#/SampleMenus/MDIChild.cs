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

using System.Drawing;
using System.Windows.Forms;
using Crownwood.Magic.Menus;

namespace SampleMenus
{
    class MDIChild : Form
    {
        protected MDIContainer _mdiContainer;
		protected RichTextBox _box;

        public MDIChild(MDIContainer mdiContainer)
        {
            // Remember parent Form
            _mdiContainer = mdiContainer;

            // Create a RichTextBox to fill entire client area
            _box = new RichTextBox();
            _box.Text = "Right click inside this window to show a Popup menu.";
            _box.Dock = DockStyle.Fill;
            _box.BorderStyle = BorderStyle.None;
            _box.MouseUp += new MouseEventHandler(OnRichTextMouseUp);
            Controls.Add(_box);
        }

		public void AppendText(string text)
		{
			_box.Text = _box.Text + "\n" + text;
		}

        protected void OnRichTextMouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                RichTextBox box = sender as RichTextBox;

	            MenuCommand s0 = new MenuCommand("Italy", _mdiContainer.Images, 0);
                MenuCommand s1 = new MenuCommand("Spain", _mdiContainer.Images, 1);
                MenuCommand s2 = new MenuCommand("Canada", _mdiContainer.Images, 2);
                MenuCommand s3 = new MenuCommand("France", _mdiContainer.Images, 3);
                MenuCommand s4 = new MenuCommand("Belgium", _mdiContainer.Images, 4);
                MenuCommand spain0 = new MenuCommand("Nerja", _mdiContainer.Images, 5);
                MenuCommand spain1 = new MenuCommand("Madrid", _mdiContainer.Images, 6);
                MenuCommand spain2 = new MenuCommand("Barcelona", _mdiContainer.Images, 0);
                MenuCommand canada0 = new MenuCommand("Toronto", _mdiContainer.Images, 5);
                MenuCommand canada1 = new MenuCommand("Montreal", _mdiContainer.Images, 6);
                MenuCommand canada2 = new MenuCommand("Belleville", _mdiContainer.Images, 0);
                MenuCommand england = new MenuCommand("England", _mdiContainer.Images, 2);
                MenuCommand england1 = new MenuCommand("London", _mdiContainer.Images, 5);
                MenuCommand england2 = new MenuCommand("Birmingham", _mdiContainer.Images, 6);
                MenuCommand england3 = new MenuCommand("Nottingham", _mdiContainer.Images, 0);
                england.MenuCommands.AddRange(new MenuCommand[]{england1,england2,england3});
                s1.MenuCommands.AddRange(new MenuCommand[]{spain0, spain1, spain2});
                s2.MenuCommands.AddRange(new MenuCommand[]{canada0, canada1, canada2, england});

                // Create the popup menu object
                PopupMenu popup = new PopupMenu();

                // Define the list of menu commands
                popup.MenuCommands.AddRange(new MenuCommand[]{s0, s1, s2, s3, s4});

                // Define the properties to get appearance to match MenuControl
                popup.Style = _mdiContainer.Style;

                popup.Selected += new CommandHandler(OnSelected);
                popup.Deselected += new CommandHandler(OnDeselected);

                // Show it!
                popup.TrackPopup(box.PointToScreen(new Point(e.X, e.Y)));
            }
        }

        protected void OnSelected(MenuCommand mc)
        {
            _mdiContainer.SetStatusBarText("Selection over " + mc.Description);
        }

        protected void OnDeselected(MenuCommand mc)
        {
            _mdiContainer.SetStatusBarText("");
        }
    }
}