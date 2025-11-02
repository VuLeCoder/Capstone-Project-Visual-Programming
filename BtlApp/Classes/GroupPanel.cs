using BtlApp.Database.Models;
using Sunny.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BtlApp.Classes
{
    public class GroupPanel : UIPanel
    {
        private const string NAME = "Group_";

        private UILabel lblName;
        private UILabel lblDescription;
        private UIButton btnMore;
        private UIContextMenuStrip menu;

        public event Action OnLeaveGroup;
        //Size(220, 120)
        public GroupPanel(MyGroup group, Size panelSize, Padding panelMargin, Color blockColor)
        {
            // Cấu hình panel
            this.Name = NAME + group.GroupId.ToString();
            this.Size = panelSize;
            this.FillColor = blockColor;
            this.RectColor = blockColor;
            this.Radius = 10;
            this.Margin = panelMargin;
            this.Padding = new Padding(10);
            //this.Cursor = Cursors.Hand;

            // Label tên group
            lblName = new UILabel
            {
                Text = group.GroupName,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                AutoEllipsis = true,
                Location = new Point(10, 10),
                TextAlign = ContentAlignment.TopLeft
            };
            this.Controls.Add(lblName);

            //lblDescription = new UILabel
            //{
            //    Text = group.Description,
            //    ForeColor = Color.Gray,
            //    Font = new Font("Segoe UI", 10, FontStyle.Italic),
            //    AutoSize = true,
            //    Location = new Point(10, this.Height - 40),
            //    TextAlign = ContentAlignment.TopLeft
            //};
            //this.Controls.Add(lblDescription);

            lblDescription = new UILabel
            {
                Text = group.Description,
                ForeColor = Color.Gray,
                Font = new Font("Segoe UI", 10, FontStyle.Italic),
                AutoSize = false, // bắt buộc false để giới hạn height
                Size = new Size(this.Width - 50, 40), // 2 dòng ~ 40px (tùy font size)
                Location = new Point(10, 50),
                TextAlign = ContentAlignment.TopLeft,
                AutoEllipsis = true // hiển thị "..." nếu text quá dài
            };
            this.Controls.Add(lblDescription);


            // Nút "⋮" (ba chấm dọc)
            btnMore = new UIButton
            {
                Text = "⋮",
                Font = new Font("Segoe UI Symbol", 10, FontStyle.Bold),
                Size = new Size(30, 30),
                Location = new Point(this.Width - 40, this.Height - 40),
                FillColor = Color.Transparent,
                RectColor = Color.Transparent,
                ForeColor = Color.White,
                Cursor = Cursors.Hand,
                Visible = false
            };
            btnMore.Click += BtnMore_Click;
            btnMore.BringToFront();
            this.Controls.Add(btnMore);

            // Hover effect: hiện nút ⋮
            this.MouseEnter += (s, e) => btnMore.Visible = true;
            lblName.MouseEnter += (s, e) => btnMore.Visible = true;
            this.MouseLeave += (s, e) =>
            {
                // Ẩn nút nếu chuột rời cả panel và nút
                if (!btnMore.Bounds.Contains(PointToClient(Cursor.Position)))
                    btnMore.Visible = false;
            };
            btnMore.MouseLeave += (s, e) =>
            {
                // Ẩn nếu chuột rời nút mà không còn trong panel
                if (!this.Bounds.Contains(this.Parent.PointToClient(Cursor.Position)))
                    btnMore.Visible = false;
            };

            // Khi panel resize → đặt lại vị trí nút
            this.Resize += (s, e) =>
            {
                btnMore.Location = new Point(this.Width - btnMore.Width - 10, this.Height - btnMore.Height - 10);
                lblName.MaximumSize = new Size(this.Width - 20, this.Height - 20);
            };

            // Giới hạn hiển thị label để thêm "..."
            lblName.AutoEllipsis = true;
            lblName.MaximumSize = new Size(this.Width - 20, this.Height - 20);
        }

        private void BtnMore_Click(object sender, EventArgs e)
        {
            if (menu == null)
            {
                menu = new UIContextMenuStrip();
                menu.ForeColor = Color.White;
                menu.BackColor = Color.FromArgb(45, 45, 45);
                menu.ShowImageMargin = false;
                menu.Items.Add("Rời nhóm", null, (s, ev) => OnLeaveGroup?.Invoke());
            }
            menu.Show(btnMore, new Point(btnMore.Width, 0));
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GroupPanel
            // 
            this.Name = "GroupPanel";
            this.ResumeLayout(false);

        }
    }
}
