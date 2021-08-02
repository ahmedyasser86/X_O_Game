using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O_Game
{
    public partial class TheGame : Form
    {
        int[] X = new int[5];
        int[] O = new int[5];
        int PCount = 0;
        string nextPlayer = "X";
        bool Playable = true;

        private void AddLabelToPanel(string Player, Panel P)
        {
            Label l = new Label();
            l.Dock = DockStyle.Fill;
            l.AutoSize = false;
            l.TextAlign = ContentAlignment.MiddleCenter;
            l.Text = Player;
            l.Font = new Font("Tahoma", 100);
            if(Player == "X")
            {
                l.BackColor = Color.FromArgb(73, 47, 16);
                l.ForeColor = Color.FromArgb(236, 239, 164);
            }
            else
            {
                l.BackColor = Color.FromArgb(213, 76, 76);
                l.ForeColor = Color.FromArgb(236, 239, 164);
            }
            P.Controls.Add(l);
            l.Show();
        }

        public TheGame()
        {
            InitializeComponent();
        }

        private void TheGame_Load(object sender, EventArgs e)
        {

        }

        private void Clicks(object sender, EventArgs e)
        {
            if (Playable)
            {
                var P = sender as Panel;

                int name = Convert.ToInt32(P.Name.Substring(1));

                AddLabelToPanel(nextPlayer, sender as Panel);

                if (nextPlayer == "X")
                {
                    nextPlayer = "O";
                    X[Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(PCount) / 2))] = name;
                }
                else
                {
                    nextPlayer = "X";
                    O[Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(PCount) / 2))] = name;
                }

                if (PCount >= 4)
                {
                    bool win = false;

                    int i = 0;
                    while (!win && i <= Math.Ceiling(Convert.ToDecimal(PCount) / 2))
                    {
                        win = CheckWin(X[i], X);
                        i++;
                    }

                    if (win)
                    {
                        Playable = false;

                        if (nextPlayer == "O") // X Wins
                        {

                        }
                        if (nextPlayer == "X") // O Wins
                        {

                        }
                    }
                }

                if(PCount >= 9) // Game Ended
                {
                    
                }

                else PCount++;
            }
        }

        private bool CheckWin(int name, int[] arr)
        {
            if(name < 4)
            {
                if(Array.IndexOf(arr, name + 1) > -1 && Array.IndexOf(arr, name + 2) > -1)
                {
                    return true;
                }

                else if(Array.IndexOf(arr, name + 3) > -1 && Array.IndexOf(arr, name + 6) > -1)
                {
                    return true;
                }

                else if (Array.IndexOf(arr, name + 4) > -1 && Array.IndexOf(arr, name + 8) > -1)
                {
                    return true;
                }

                return false;
            }

            else if (name < 7)
            {
                if (Array.IndexOf(arr, name + 1) > -1 && Array.IndexOf(arr, name + 2) > -1)
                {
                    return true;
                }
                return false;
            }

            else if (name < 10)
            {
                if (Array.IndexOf(arr, name + 1) > -1 && Array.IndexOf(arr, name + 2) > -1)
                {
                    return true;
                }
                return false;
            }

            return false;
        }
    }
}
