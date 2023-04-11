using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace lab12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int roundNum = 0;   
        Team[] teamList = new Team[8];

        int[,,] scenario = new int[7, 4, 2]        
        {{ { 0, 7 }, { 1, 6 }, { 2, 5 }, { 3, 4 }},
          {{ 6, 0 }, { 7, 5 }, { 1, 4 }, { 2, 3 }},
          {{ 0, 5 }, { 6, 4 }, { 7, 3 }, { 1, 2 }},
          {{ 4, 0 }, { 5, 3 }, { 6, 2 }, { 7, 1 }},
          {{ 0, 3 }, { 4, 2 }, { 5, 1 }, { 6, 7 }},
          {{ 2, 0 }, { 3, 1 }, { 4, 7 }, { 5, 6 }},
          {{ 0, 1 }, { 2, 7 }, { 3, 6 }, { 4, 5 } }}; 
        

        public void Form1_Load(object sender, EventArgs e)
        {
            teamList[0] = new Team("Snowkids",   4.29,  1);
            teamList[1] = new Team("Shadows", 3.33,  2);
            teamList[2] = new Team("Xenon",   2.83,  3);
            teamList[3] = new Team("Rikers",   2.81,  4);
            teamList[4] = new Team("Pirates", 4.00, 5);
            teamList[5] = new Team("Electro",    4.73, 6);
            teamList[6] = new Team("Vambas",  2.99, 7);
            teamList[7] = new Team("Lightning",   1.31, 8);
            


            func.setGrid(tt, teamList);
            func.updateGrid(tt, teamList);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (roundNum <= 6)
            {
                roundNum++;
                round.Text = "Кругов пройдено: " + (roundNum) + "/7";

                for (int i = 0; i < 4; i++)
                {
                    func.playMatch(teamList[scenario[roundNum-1,i,0]], 
                    teamList[scenario[roundNum-1, i, 1]]);
                }

                func.sort(teamList);
                func.getPos(teamList);
                func.updateGrid(tt, teamList);
            }
            else if (roundNum == 7)
            {
                roundNum++;

                func.winChecker(tt, teamList);

                label1.Text = "Победили - " + teamList[0].name + " !!! ";

                button1.Text = "Закончить турнир!";
            }
            else { Application.Exit(); }
        }
    }

    public class Team
    {
        public int PTS = 0, W = 0, L = 0, 
         D = 0, PLD = 0, POS = 0;
        public string name;
        public double lambda, GS = 0;
        public Team(string name, double lambda, int POS)
        {
            this.name = name;
            this.lambda = lambda;
            this.POS = POS;
        }
    }

    public class func
    {
        public static void setGrid(DataGridView grid, Team[] list)
        { for (int i = 0; i < 8; i++) grid.Rows.Add(); } 

        public static void updateGrid(DataGridView grid, Team[] list) 
        {
            for (int i = 0; i < 8; i++)
            {
                grid.Rows[i].Cells[0].Value = list[i].POS;
                grid.Rows[i].Cells[1].Value = list[i].name;
                grid.Rows[i].Cells[2].Value = list[i].PLD;
                grid.Rows[i].Cells[3].Value = list[i].W;
                grid.Rows[i].Cells[4].Value = list[i].D;
                grid.Rows[i].Cells[5].Value = list[i].L;
                grid.Rows[i].Cells[6].Value = list[i].GS;
                grid.Rows[i].Cells[7].Value = list[i].PTS;
            }
        } 

        public static int poisson(Team team)
        {
            Random rnd = new Random();
            int goals = 0;
            double Summ = 0;

            for (goals = -1; Summ >= -team.lambda; goals++) 
                Summ+= Math.Log(rnd.NextDouble());
            return goals;
        } 

        public static void playMatch(Team A, Team B)
        {
            int scoreA, scoreB;


            scoreA = poisson(A);
            scoreB = poisson(B);

            A.GS += scoreA;
            B.GS += scoreB;
            A.PLD++; B.PLD++;


            if (scoreA > scoreB)
            {
                A.PTS += 3; A.W++; B.L++;
            } 
            else if (scoreA < scoreB)
            {
                B.PTS += 3; B.W++; A.L++;
            }
            else
            {
                A.PTS++; B.PTS++;
                A.D++; B.D++;
            }

        } 

        public static void sort(Team[] teamList)
        {
            Team temp;
            for (int i = 0; i < teamList.Length - 1; i++)
            {
                for (int j = 0; j < teamList.Length - i - 1; j++)
                {
                    if (teamList[j].PTS < teamList[j + 1].PTS)
                    {
                        temp = teamList[j];
                        teamList[j] = teamList[j + 1];
                        teamList[j + 1] = temp;
                    }
                }
            }
        } 

        public static void getPos(Team[] teamList)
         {
            for (int i = 0; i < 8; i++) 
                teamList[i].POS = i + 1;
        } 


        public static void winChecker(DataGridView grid, Team[] list) 
        {                                        
            if (list[0].PTS == list[1].PTS)
            {
                Team temp;
                if (list[0].GS < list[1].GS)
                {
                    temp = list[0];
                    list[0] = list[1];
                    list[1] = temp;
                }
                func.updateGrid(grid, list);
            }
        }
    }
}

