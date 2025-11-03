using BtlApp.Individual;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtlApp.Classes
{
    public partial class PanelGroup : UserControl
    {
        Form_Manager form_Manager;
        string groupName;
        string groupId;
        public PanelGroup(string GroupName, string GroupId, Form_Manager form_Manager)
        {  
            InitializeComponent();
            this.form_Manager = form_Manager;
            groupName = GroupName;
            groupId = GroupId;
            lblId.Text = "#" + GroupId;
            lblName.Text = GroupName;
            this.Size = new Size(220, 120);
            Console.WriteLine(this.Width + " " + this.Height);
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            menu.Show(btnMore, new Point(btnMore.Width, 0));
        }

        private void smiInformation_Click(object sender, EventArgs e)
        {

        }

        private void smiLeave_Click(object sender, EventArgs e)
        {
            form_Manager.LeaveGroup(Convert.ToInt32(groupId));
        }
    }
}
