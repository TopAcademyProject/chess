using ChessClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class main : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private bool fieldActive;
        public Font mainFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
        public main()
        {
            InitializeComponent();
            ThemeColor.primaryColor = Color.FromArgb(51, 51, 76);
            random = new Random();
            //panelLogo.BackColor = SelectThemeColor();
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.colorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.colorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.colorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender && currentButton != null)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = mainFont;
                }
            }
        }
        private void DisableButton()
        {
            foreach(Control previousBtn in SideBar.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor= Color.FromArgb(51,51,76);
                    previousBtn.ForeColor= Color.White;
                    previousBtn.Font = mainFont;
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            //ActivateButton(btnSender);
            activeForm?.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFormField.Controls.Add(childForm);
            panelFormField.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            if (fieldActive)
            {
                DialogResult result = MessageBox.Show("Вы точно хотите начать новую игру? Текущая игра будет удалена!", "Новая игра", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    fieldActive = true;
                    panelGameInfo.BackColor = SelectThemeColor();
                    OpenChildForm(new Forms.ChessField(), sender);
                    labelGameInfo.Text = "Chess";
                }
            }
            else
            {
                labelGameInfo.Text = "Chess";
                fieldActive = true;
                panelGameInfo.BackColor = SelectThemeColor();
                OpenChildForm(new Forms.ChessField(), sender);
            }
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null && fieldActive != false)
            {
                DialogResult result = MessageBox.Show("Вы точно хотите завершить игру? Изменения не будут сохранены!", "Выход из игровой сессии",
                MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    fieldActive = false;
                    labelGameInfo.Text = "Select game";
                    activeForm.Close();
                    panelGameInfo.BackColor = ThemeColor.primaryColor;
                }
            }
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Выйти из игры? Изменения не будут сохранены!", "Выход из игры", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK) Application.Exit();
        }
    }
}
