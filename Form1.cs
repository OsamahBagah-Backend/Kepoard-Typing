using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keypord_typing_project
{
    public partial class Form1 : Form
    {
        public int Panel1_top;
        public Form1()
        {
            InitializeComponent();
        }
        
        struct ContainAllFaribles
        {
            public bool checkFromSizeState;
            public int SecondsCount;
            public int MinuteCount;
            public bool checkIfBtnClicked;
            public int topCounter;
            public int scoreCount;
            public bool checkIfBauseButtonIsClick;
        }

        internal static void ChangeTimerCount()
        {
            throw new NotImplementedException();
        }

        static ContainAllFaribles contain;
        
        void chickOfSize(bool check)
        {
            if (check)
            {
                panel1.Top = 500;
            }

            else
            {
                panel1.Top = 315;
                check = true;
            }
        }

        int returnKapitalCharOrSmaalChar()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 2);

            if (randomNumber == 1)
            {
                return rand.Next(97, 122);
            }

            else
            {
                return rand.Next(65, 90);
            }
        }

        char returnArabicCharcters()
        {
            Random rand = new Random();
            string allLetters = "أابتثجحخدذرزسشصضعغفقكملنيئءؤةهى";
            int randomNumber = rand.Next(1, 31);

            return allLetters[randomNumber]; 
        }

        void makingTheTextForButtonKepoard()
        {
            Random randomCharacters = new Random();

            if (cmbLanguage.SelectedItem.ToString() == "English")
            {
                if (cmType.Text == "characters")
                {
                    int randomText = returnKapitalCharOrSmaalChar();
                    btnKepoard.Text = Convert.ToChar(randomText).ToString();
                }

                else
                {
                    int randomText = randomCharacters.Next(48, 57);
                    btnKepoard.Text = Convert.ToChar(randomText).ToString();
                }
            }

            else
            {
                char letter = returnArabicCharcters();
                btnKepoard.Text = letter.ToString();
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Panel1_top = panel1.Top;
            //chickOfSize(contain.checkFromSizeState);

            //if (contain.checkFromSizeState)
            //{
            //    contain.checkFromSizeState = false;
            //}

            //else
            //{
            //    contain.checkFromSizeState = true;
            //}
        }

        int checkFromLevelOfGame()
        {
            if (cmLevel.Text == "Hard")
            {
                return 1;
            }

            else if (cmLevel.Text == "Medeium")
            {
                return 15;
            }

            else
            {
                return 33;
            }
        }

        string theResultOfTheGame()
        {
            if (Convert.ToInt32(lbScore.Text) > 50)
            {
                return "Excellent";
            }

            else if (Convert.ToInt32(lbScore.Text) > 40)
            {
                return "very Good";
            }

            else if (Convert.ToInt32(lbScore.Text) > 35)
            {
                return "Good";
            }

            else
            {
                return "Bad";
            }
        }

        void WhenButtonSatreClicked()
        {
            makingTheTextForButtonKepoard();
            btnKepoard.Top = 0;
            btnKepoard.Visible = true;
            btnKepoard.Focus();
            startGameTimer.Interval = checkFromLevelOfGame();
            startGameTimer.Enabled = true;
            cmType.Enabled = false;
            cmLevel.Enabled = false;
            cmbLanguage.Enabled = false;
            timer2.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contain.checkFromSizeState = true;
            panel1.Top = 315;
            contain.SecondsCount = 59;
            contain.MinuteCount = 1;
            contain.topCounter = 0;
            contain.checkIfBauseButtonIsClick = true;
            cmType.Text = "characters";
            cmLevel.Text = "Easy";
            cmbLanguage.Text = "English";
            this.Size = new Size(1000, 650);
            Panel1_top = panel1.Top;
        }

        void StoppingTheGame()
        {
            if(contain.checkIfBauseButtonIsClick)
            {
                timer2.Enabled = false;
                startGameTimer.Enabled = false;
            }

            else
            {
                timer2.Enabled = true;
                startGameTimer.Enabled = true ;
            }
        }

        void checkIfButtonTouchThePanelTop()
        {
            //if (panel1.Top == 315 && btnKepoard.Bottom >= 310 || panel1.Top == 500 && btnKepoard.Bottom >= 495)
            //{
            //    contain.checkIfBtnClicked = true;

            //    if (contain.scoreCount > 0)
            //    {
            //        contain.scoreCount--;
            //        lbScore.Text = contain.scoreCount.ToString();
            //    }
            //}

            //if (panel1.Top == 264 && btnKepoard.Bottom >= 255 || panel1.Top == 481 && btnKepoard.Bottom >= 475)
            //{
            //    contain.checkIfBtnClicked = true;

            //    if (contain.scoreCount > 0)
            //    {
            //        contain.scoreCount--;
            //        lbScore.Text = contain.scoreCount.ToString();
            //    }
            //}

            if (btnKepoard.Bottom >= Panel1_top - 6)
            {
                contain.checkIfBtnClicked = true;

                if (contain.scoreCount > 0)
                {
                    contain.scoreCount--;
                    lbScore.Text = contain.scoreCount.ToString();
                }
            }
        }

        void chooseTheRightChar(KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() ==btnKepoard.Text)
            {
                lbKepoardPassed.BackColor = Color.Green;
                btnKepoard.BackColor = Color.Green;
                contain.scoreCount++;
            }

            else
            {
                lbKepoardPassed.BackColor = Color.Red;
                btnKepoard.BackColor = Color.Red;
                if (contain.scoreCount > 0)
                {
                    contain.scoreCount--;
                }
            }

            lbKepoardPassed.Text = e.KeyChar.ToString();
            lbScore.Text = contain.scoreCount.ToString();
            btnKepoard.BackColor = Color.White;
        }

        void changeThelocationOfButton()
        {
            contain.topCounter = 10;
            btnKepoard.Top = contain.topCounter;
            Random randnumber = new Random();
            int btnWard = randnumber.Next(10, 900);
            btnKepoard.Left = btnWard;
            makingTheTextForButtonKepoard();
            btnKepoard.Visible = true;
            contain.checkIfBtnClicked = false;
            btnKepoard.Focus();
        }
        private void startGameTimer_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            checkIfButtonTouchThePanelTop();
            if (contain.checkIfBtnClicked)
            {
                changeThelocationOfButton();
            }

            else
            {
                btnKepoard.Top = contain.topCounter;
                contain.topCounter += 7;
            }
        }

        private void btnKepoard_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        void resetTheGameData()
        {
            startGameTimer.Enabled = false;
            timer2.Enabled = false;
            btnKepoard.Visible = false;
            lbScore.Text = "0";
            lbTimer.Text = "00:00";
            lbKepoardPassed.Text = "";
            contain.SecondsCount = 59;
            cmType.Enabled = true;
            cmLevel.Enabled = true;
            cmbLanguage.Enabled = true;
            btnKepoard.Top = 0;
            btnStartGame.Enabled = true;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            lbTimer.Text = "0" + (contain.MinuteCount - 1).ToString() + ":" + contain.SecondsCount;
            contain.SecondsCount--;

            if (contain.MinuteCount == 1)
            {
                if (contain.SecondsCount == 0)
                {
                    string score = lbScore.Text;
                    string resault = theResultOfTheGame();
                    resetTheGameData();
                    MessageBox.Show("over game your score is :" + score + "   and your mark :" + resault, "your result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmLevel.Enabled = true;
                    cmType.Enabled = true;
                    cmbLanguage.Enabled= true;
                }
            }

            else if (contain.SecondsCount == 1)
            {
                contain.MinuteCount--;
                contain.SecondsCount = 59;
            }
        }

        private void btnReset_MouseClick(object sender, MouseEventArgs e)
        {
            btnReset.Focus();
            resetTheGameData();
        }

        private void btnPause_MouseClick(object sender, MouseEventArgs e)
        {
            StoppingTheGame();

            if (contain.checkIfBauseButtonIsClick)
            {
                contain.checkIfBauseButtonIsClick = false;
            }

            else
            {
                contain.checkIfBauseButtonIsClick = true;
            }
        }

        private void btnKepoard_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            chooseTheRightChar(e);
            btnKepoard.Visible = false;
            contain.checkIfBtnClicked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void ChangeTimerCount(int count)
        {
            contain.MinuteCount= count;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            resetTheGameData();
            FrmSettings frm = new FrmSettings();

            frm.ShowDialog();
        }

        private void btnStartGame_MouseClick(object sender, MouseEventArgs e)
        {
            btnStartGame.Enabled = false;
            btnStartGame.ForeColor = Color.White;
            WhenButtonSatreClicked();
        }
    }
}
