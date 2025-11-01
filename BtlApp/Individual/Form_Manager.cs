using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtlApp.Individual
{
    public partial class Form_Manager : Form
    {
        // ================== slot group ====================
        private const int GROUP_WIDTH = 150;
        private const int GROUP_HEIGHT = 60;
        private const int NUM_GROUP = 4; // số nhóm 1 hàng
        private readonly int GROUP_GAP = (int)((650 - NUM_GROUP * GROUP_WIDTH) / 5); //flp_group.Width = 650;

        private readonly Color GROUP_BACKCOLOR = Color.FromArgb(56,56, 56);

        // ====================== Biến ======================
        private readonly string userId;
        private bool isLogout = false;

        public Form_Manager(string userId)
        {
            this.userId = userId;
            InitializeComponent();
            GROUP_GAP -= SystemInformation.VerticalScrollBarWidth / 5;
        }
// =====================================================================
// =====================================================================
        // ====================== Hàm ======================
        public bool IsLogout() { return isLogout; }

        public string getUserId() { return userId; }


        // ============= Giao diện tab: Nhóm ===============
        private void addNewGroup(string groupId)
        {
            UIPanel panel = new UIPanel
            {
                Size = new Size(GROUP_WIDTH, GROUP_HEIGHT),
                FillColor = GROUP_BACKCOLOR,
                RectColor = GROUP_BACKCOLOR,
                Radius = 10,
                Margin = new Padding(GROUP_GAP, GROUP_GAP, 0, 0),
                Padding = new Padding(5),
                Tag = groupId
            };
            flp_group.Controls.Add(panel);
        }




        // =====================================================================
        // =====================================================================
        // ================== Sự kiện form ===================
        private void Form_Manager_Load(object sender, EventArgs e)
        {
            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isLogout = true;
            this.Close();
        }

        private void btn_MySchedule_Click(object sender, EventArgs e)
        {
            Form_MySchedule formMySchedule = new Form_MySchedule(this);
            formMySchedule.Show();
            this.Hide();
        }

        private void btn_CreateGroup_Click(object sender, EventArgs e)
        {
            addNewGroup("HeHe");
        }
    }
}
