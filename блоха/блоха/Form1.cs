using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace блоха
{

    public partial class Form1 : Form
    {

        //Глобальальные переменные
        int resClassic;
        int resSpeedrun;
        int resUltra;
        int keyClassic;
        int keySpeedrun;
        int keyUltra;
        int progSpeedrun = 0;
        int time1 = 0;
        int time2 = 0;
        int time3 = 0;
        bool yes = false;
        bool no = false;
        int resGlobalSpeedrun = 0;
        int valn7;
        int TOP1;
        int TOP2;
        int TOP3;
        int TOP4;
        int TOP5;
        int TOP6;
        int TOP7;
        int LEFT1;
        int LEFT2;
        int LEFT3;
        int LEFT4;
        int LEFT5;
        int LEFT6;
        int LEFT7;
        int T;
        int T1;
        int T2;
        int T3;
        int T4;
        int T5;
        int L;
        int L1;
        int L2;
        int L3;
        int L4;
        int L5;
        bool stopShuk = false;


        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Random t = new Random();
            int TOP = t.Next(0, 400);
            Random l = new Random();
            int LEFT = t.Next(0, 740);

            pictureBox2.Top = TOP;
            pictureBox2.Left = LEFT;
            if (keyClassic == 1 ||
                keySpeedrun == 1)
            {
                if (keyClassic == 1)
                {
                    resClassic += 1;
                    label3.Text = resClassic.ToString();
                    if (resClassic == 20)
                    {
                        Classic.Enabled = false;
                        MessageBox.Show($"ВЫ победили за {time1} сек");
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        label2.Text = 00.ToString();
                        label3.Text = 0.ToString();
                        resClassic = 0;
                        time1 = 0;
                        label1.Visible = true;
                        pictureBox2.Visible = false;
                        Жук1.Enabled = true;
                        Жук2.Enabled = true;
                        pictureBox1.Visible = true;
                        pictureBox3.Visible = true;
                        button1.Visible = true;
                        button2.Visible = true;
                        button3.Visible = true;
                        keyClassic -= 1;
                        Classic.Enabled = false;
                        label2.Visible = false;
                        label3.Visible = false;

                    }
                }
                if (keySpeedrun == 1)
                {
                    progressBar1.Value += 1;
                    resSpeedrun += 1;

                    if (resSpeedrun == progSpeedrun)
                    {
                        SpeedRun.Enabled = false;
                        resGlobalSpeedrun += 1;
                        MessageBox.Show($"ВЫ победили за {time2} сек до поражения");
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        pictureBox2.Visible = false;
                        label4.Visible = true;
                        pictureBox5.Visible = true;
                        pictureBox6.Visible = true;
                        button6.Visible = true;
                        button7.Visible = true;
                        if (resGlobalSpeedrun == 3)
                        {
                            label4.Text = "Ты прошёл второй \n уровень!!Не хочешь \n пройти третий?";
                            label2.Text = 00.ToString();
                            progressBar1.Maximum = 30;
                            resSpeedrun = 0;
                            progressBar1.Value = 0;
                            time2 = 20;
                            progSpeedrun = 0;
                            progSpeedrun = 30;

                        }
                        if (resGlobalSpeedrun == 2)
                        {
                            label2.Text = 00.ToString();
                            progressBar1.Maximum = 25;
                            resSpeedrun = 0;
                            progressBar1.Value = 0;
                            time2 = 20;
                            progSpeedrun = 0;
                            progSpeedrun = 25;
                        }

                    }
                }
            }

            if (keyUltra == 1)
            {
                label3.Text = resUltra.ToString();
                resUltra += 1;
                if (resUltra >= 5)
                {

                    Random k = new Random();
                    TOP1 = k.Next(-6, 6);
                    Random u = new Random();
                    LEFT1 = u.Next(-6, 6);
                }
                if (resUltra >= 9)
                {
                    Random q = new Random();
                    T = q.Next(0, 300);
                    Random q1 = new Random();
                    L = q1.Next(0, 640);
                    pictureBox7.Visible = true;
                    pictureBox7.Top = T;
                    pictureBox7.Top = L;
                    Random y = new Random();
                    TOP2 = y.Next(-6, 6);
                    Random y1 = new Random();
                    LEFT2 = y1.Next(-6, 6);
                }
                if (resUltra >= 12)
                {
                    Random q2 = new Random();
                    T1 = q2.Next(0, 300);
                    Random q3 = new Random();
                    L1 = q3.Next(0, 640);
                    pictureBox8.Visible = true;
                    pictureBox8.Top = T1;
                    pictureBox8.Top = L1;
                    Random y2 = new Random();
                    TOP3 = y2.Next(-6, 6);
                    Random y3 = new Random();
                    LEFT3 = y3.Next(-6, 6);
                }
                if (resUltra >= 15)
                {
                    Random q4 = new Random();
                    T2 = q4.Next(0, 300);
                    Random q5 = new Random();
                    L2 = q5.Next(0, 640);
                    pictureBox9.Visible = true;
                    pictureBox9.Top = T2;
                    pictureBox9.Top = L2;
                    Random y4 = new Random();
                    TOP4 = y4.Next(-6, 6);
                    Random y5 = new Random();
                    LEFT4 = y5.Next(-6, 6);
                }
                if (resUltra >= 18)
                {
                    Random q6 = new Random();
                    T3 = q6.Next(0, 300);
                    Random q7 = new Random();
                    L3 = q7.Next(0, 640);
                    pictureBox10.Visible = true;
                    pictureBox10.Top = T3;
                    pictureBox10.Top = L3;
                    Random y6 = new Random();
                    TOP5 = y6.Next(-6, 6);
                    Random y7 = new Random();
                    LEFT5 = y7.Next(-6, 6);
                }
                if (resUltra >= 23)
                {
                    Random q8 = new Random();
                    T4 = q8.Next(0, 300);
                    Random q9 = new Random();
                    L4 = q9.Next(0, 640);
                    pictureBox11.Visible = true;
                    pictureBox11.Top = T4;
                    pictureBox11.Top = L4;
                    Random y8 = new Random();
                    TOP6 = y8.Next(-6, 6);
                    Random y9 = new Random();
                    LEFT6 = y9.Next(-6, 6);
                }
                if (resUltra >= 25)
                {
                    Random q10 = new Random();
                    T5 = q10.Next(0, 300);
                    Random q11 = new Random();
                    L5 = q11.Next(0, 640);
                    pictureBox12.Visible = true;
                    pictureBox12.Top = T5;
                    pictureBox12.Top = L5;
                    Random y10 = new Random();
                    TOP7 = y10.Next(-6, 6);
                    Random y11 = new Random();
                    LEFT7 = y11.Next(-6, 6);
                }
                if (resUltra == 28)
                {
                    timer7.Enabled = true;
                    pictureBox13.Visible = true;                    
                }
                
                
            }
        }
        private void допТаймер_Tick(object sender, EventArgs e)
        {
                if (stopShuk == true)
                {
                    timer8.Enabled = true;
                    pictureBox14.Visible = true;
                    допТаймер.Enabled = false;
                }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            pictureBox3.Visible = true;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            Жук1.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            keyClassic += 1;
            Classic.Enabled = true;
            label2.Visible = true;
            label3.Visible = true;
            label1.Visible = false;
            pictureBox4.Visible = true;


        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            time1 += 1;
            label2.Text = time1.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox15.Visible = false;
            pictureBox2.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox10.Enabled = true;
            pictureBox11.Enabled = true;
            pictureBox12.Enabled = true;
            button4.Visible = false;
            button5.Visible = false;
            if (resGlobalSpeedrun > 0)
            {
                SpeedRun.Enabled = true;
            }
            if (resGlobalSpeedrun > 0)
            {
                Classic.Enabled = true;
            }
            if (resUltra > 0)
            {
                UltraMod.Enabled = true;
                ТаймерДляБлох.Enabled = true;
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox2.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
            pictureBox10.Enabled = false;
            pictureBox11.Enabled = false;
            pictureBox12.Enabled = false;            
            pictureBox15.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            Classic.Enabled = false;
            SpeedRun.Enabled = false;
            timer7.Enabled = false;
            timer8.Enabled = false;            
            ТаймерДляБлох.Enabled = false;
            UltraMod.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox15.Visible = false;
            pictureBox2.Top = 350;
            pictureBox2.Left = 350;
            pictureBox7.Top = 350;
            pictureBox7.Left = 350;
            pictureBox8.Top = 350;
            pictureBox8.Left = 350;
            pictureBox9.Top = 350;
            pictureBox9.Left = 350;
            pictureBox10.Top = 350;
            pictureBox10.Left = 350;
            pictureBox11.Top = 350;
            pictureBox11.Left = 350;
            pictureBox12.Top = 350;
            pictureBox12.Left = 350;
            pictureBox13.Top = 220;
            pictureBox13.Left = -24;
            pictureBox14.Top = 146;
            pictureBox14.Left = 780;
            resUltra = 0;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            time1 = 0;
            label3.Text = 0.ToString();
            resClassic = 0;
            label2.Text = 00.ToString();
            Classic.Enabled = false;
            label1.Visible = true;
            pictureBox2.Visible = false;
            Жук1.Enabled = true;
            //timer2.Enabled = true;
            pictureBox1.Visible = true;
            pictureBox3.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            keyClassic = 0;
            keySpeedrun = 0;
            keyUltra = 0;
            progressBar1.Value = 0;
            resGlobalSpeedrun = 0;
            resSpeedrun = 0;
            Classic.Enabled = false;
            label2.Visible = false;
            pictureBox4.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            label3.Visible = false;
            SpeedRun.Enabled = false;
            pictureBox2.Visible = false;
            label4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            progressBar1.Visible = false;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            progSpeedrun = 0;
            resGlobalSpeedrun += 1;
            progSpeedrun = 20;
            progressBar1.Maximum = 20;
            pictureBox2.Visible = true;
            Жук1.Enabled = false;
            //timer2.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            keySpeedrun += 1;
            label2.Visible = true;
            label1.Visible = false;
            SpeedRun.Enabled = true;
            pictureBox4.Visible = true;
            progressBar1.Visible = true;
            time2 = 20;





        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            time2 -= 1;
            label2.Text = time2.ToString();
            if (time2 == 0)
            {
                SpeedRun.Enabled = false;
                MessageBox.Show("ВЫ проиграли(");
                time1 = 0;
                label3.Text = 0.ToString();
                resClassic = 0;
                label2.Text = 00.ToString();
                Classic.Enabled = false;
                label1.Visible = true;
                pictureBox2.Visible = false;
                Жук1.Enabled = true;
                //timer2.Enabled = true;
                pictureBox1.Visible = true;
                pictureBox3.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                keyClassic = 0;
                keySpeedrun = 0;
                keyUltra = 0;
                progressBar1.Value = 0;
                resGlobalSpeedrun = 0;
                Classic.Enabled = false;
                label2.Visible = false;
                pictureBox4.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                label3.Visible = false;
                SpeedRun.Enabled = true;
                pictureBox2.Visible = false;
                label4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                progressBar1.Visible = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            SpeedRun.Enabled = true;
            pictureBox2.Visible = true;
            label4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            button6.Visible = false;
            button7.Visible = false;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            time1 = 0;
            label3.Text = 0.ToString();
            resClassic = 0;
            label2.Text = 00.ToString();
            Classic.Enabled = false;
            label1.Visible = true;
            pictureBox2.Visible = false;
            Жук1.Enabled = true;
            //timer2.Enabled = true;
            pictureBox1.Visible = true;
            pictureBox3.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            keyClassic = 0;
            keySpeedrun = 0;
            keyUltra = 0;
            progressBar1.Value = 0;
            resGlobalSpeedrun = 0;
            Classic.Enabled = false;
            label2.Visible = false;
            pictureBox4.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            label3.Visible = false;
            SpeedRun.Enabled = true;
            pictureBox2.Visible = false;
            label4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            progressBar1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            Жук1.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            keyUltra += 1;
            Classic.Enabled = true;
            label2.Visible = true;
            label3.Visible = true;
            label1.Visible = false;
            pictureBox4.Visible = true;
            ТаймерДляБлох.Enabled = true;
            pictureBox2.Top = 350;
            pictureBox2.Top = 350;
            pictureBox7.Top = 350;
            pictureBox7.Top = 350;
            pictureBox8.Top = 350;
            pictureBox8.Top = 350;
            pictureBox9.Top = 350;
            pictureBox9.Top = 350;
            pictureBox10.Top = 350;
            pictureBox10.Top = 350;
            pictureBox11.Top = 350;
            pictureBox11.Top = 350;
            pictureBox12.Top = 350;
            pictureBox12.Top = 350;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            time3 += 1;
            label2.Text = time3.ToString();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (resUltra >= 5)
            {
                pictureBox2.Top += TOP1;
                pictureBox2.Left += LEFT1;
                pictureBox7.Top += TOP2;
                pictureBox7.Left += LEFT2;
                pictureBox8.Top += TOP3;
                pictureBox8.Left += LEFT3;
                pictureBox9.Top += TOP4;
                pictureBox9.Left += LEFT4;
                pictureBox10.Top += TOP5;
                pictureBox10.Left += LEFT5;
                pictureBox11.Top += TOP6;
                pictureBox11.Left += LEFT6;
                pictureBox12.Top += TOP7;
                pictureBox12.Left += LEFT7;
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            pictureBox13.Left += 35;
            if (pictureBox13.Left >= 780)
            {
                pictureBox13.Visible = false;
                timer7.Enabled = false;
                pictureBox2.Top = 350;
                pictureBox2.Left = 350;
                pictureBox7.Top = 350;
                pictureBox7.Left = 350;
                pictureBox8.Top = 350;
                pictureBox8.Left = 350;
                pictureBox9.Top = 350;
                pictureBox9.Left = 350;
                pictureBox10.Top = 350;
                pictureBox10.Left = 350;
                pictureBox11.Top = 350;
                pictureBox11.Left = 350;
                pictureBox12.Top = 350;
                pictureBox12.Left = 350;
                pictureBox13.Top = -24;
                pictureBox13.Left = 220;
                UltraMod.Enabled = false;
                ТаймерДляБлох.Enabled = false;
                MessageBox.Show("Вы проиграли!(");
                time1 = 0;
                label3.Text = 0.ToString();
                resClassic = 0;
                label2.Text = 00.ToString();
                Classic.Enabled = false;
                label1.Visible = true;
                pictureBox2.Visible = false;
                Жук1.Enabled = true;
                //timer2.Enabled = true;
                pictureBox1.Visible = true;
                pictureBox3.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                keyClassic = 0;
                keySpeedrun = 0;
                keyUltra = 0;
                progressBar1.Value = 0;
                resGlobalSpeedrun = 0;
                resSpeedrun = 0;
                Classic.Enabled = false;
                label2.Visible = false;
                pictureBox4.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                label3.Visible = false;
                SpeedRun.Enabled = false;
                pictureBox2.Visible = false;
                label4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                progressBar1.Visible = false;
                resUltra = 0;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.Visible = false;
            timer7.Enabled = false;
            resUltra += 1;
            stopShuk = true;

            
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox2.Top = 350;
            pictureBox2.Left = 350;
            pictureBox7.Top = 350;
            pictureBox7.Left = 350;
            pictureBox8.Top = 350;
            pictureBox8.Left = 350;
            pictureBox9.Top = 350;
            pictureBox9.Left = 350;
            pictureBox10.Top = 350;
            pictureBox10.Top = 350;
            pictureBox11.Top = 350;
            pictureBox11.Top = 350;
            pictureBox12.Left = 350;
            pictureBox12.Left = 350;
            pictureBox13.Left = 350;
            pictureBox13.Left = 350;
            UltraMod.Enabled = false;
            ТаймерДляБлох.Enabled = false;
            MessageBox.Show("Вы проиграли!(");
            time1 = 0;
            label3.Text = 0.ToString();
            resClassic = 0;
            label2.Text = 00.ToString();
            Classic.Enabled = false;
            label1.Visible = true;
            pictureBox2.Visible = false;
            Жук1.Enabled = true;
            //timer2.Enabled = true;
            pictureBox1.Visible = true;
            pictureBox3.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            keyClassic = 0;
            keySpeedrun = 0;
            keyUltra = 0;
            progressBar1.Value = 0;
            resGlobalSpeedrun = 0;
            resSpeedrun = 0;
            Classic.Enabled = false;
            label2.Visible = false;
            pictureBox4.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            label3.Visible = false;
            SpeedRun.Enabled = false;
            pictureBox2.Visible = false;
            label4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            progressBar1.Visible = false;
            resUltra = 0;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox2.Top = 350;
            pictureBox2.Left = 350;
            pictureBox7.Top = 350;
            pictureBox7.Left = 350;
            pictureBox8.Top = 350;
            pictureBox8.Left = 350;
            pictureBox9.Top = 350;
            pictureBox9.Left = 350;
            pictureBox10.Top = 350;
            pictureBox10.Top = 350;
            pictureBox11.Top = 350;
            pictureBox11.Top = 350;
            pictureBox12.Left = 350;
            pictureBox12.Left = 350;
            pictureBox13.Left = 350;
            pictureBox13.Left = 350;
            UltraMod.Enabled = false;
            ТаймерДляБлох.Enabled = false;
            MessageBox.Show("Вы проиграли!(");
            time1 = 0;
            label3.Text = 0.ToString();
            resClassic = 0;
            label2.Text = 00.ToString();
            Classic.Enabled = false;
            label1.Visible = true;
            pictureBox2.Visible = false;
            Жук1.Enabled = true;
            //timer2.Enabled = true;
            pictureBox1.Visible = true;
            pictureBox3.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            keyClassic = 0;
            keySpeedrun = 0;
            keyUltra = 0;
            progressBar1.Value = 0;
            resGlobalSpeedrun = 0;
            resSpeedrun = 0;
            Classic.Enabled = false;
            label2.Visible = false;
            pictureBox4.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            label3.Visible = false;
            SpeedRun.Enabled = false;
            pictureBox2.Visible = false;
            label4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            progressBar1.Visible = false;
            resUltra = 0;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox2.Top = 350;
            pictureBox2.Left = 350;
            pictureBox7.Top = 350;
            pictureBox7.Left = 350;
            pictureBox8.Top = 350;
            pictureBox8.Left = 350;
            pictureBox9.Top = 350;
            pictureBox9.Left = 350;
            pictureBox10.Top = 350;
            pictureBox10.Top = 350;
            pictureBox11.Top = 350;
            pictureBox11.Top = 350;
            pictureBox12.Left = 350;
            pictureBox12.Left = 350;
            pictureBox13.Left = 350;
            pictureBox13.Left = 350;
            UltraMod.Enabled = false;
            ТаймерДляБлох.Enabled = false;
            MessageBox.Show("Вы проиграли!(");
            time1 = 0;
            label3.Text = 0.ToString();
            resClassic = 0;
            label2.Text = 00.ToString();
            Classic.Enabled = false;
            label1.Visible = true;
            pictureBox2.Visible = false;
            Жук1.Enabled = true;
            //timer2.Enabled = true;
            pictureBox1.Visible = true;
            pictureBox3.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            keyClassic = 0;
            keySpeedrun = 0;
            keyUltra = 0;
            progressBar1.Value = 0;
            resGlobalSpeedrun = 0;
            resSpeedrun = 0;
            Classic.Enabled = false;
            label2.Visible = false;
            pictureBox4.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            label3.Visible = false;
            SpeedRun.Enabled = false;
            pictureBox2.Visible = false;
            label4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            progressBar1.Visible = false;
            resUltra = 0;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox2.Top = 350;
            pictureBox2.Left = 350;
            pictureBox7.Top = 350;
            pictureBox7.Left = 350;
            pictureBox8.Top = 350;
            pictureBox8.Left = 350;
            pictureBox9.Top = 350;
            pictureBox9.Left = 350;
            pictureBox10.Top = 350;
            pictureBox10.Top = 350;
            pictureBox11.Top = 350;
            pictureBox11.Top = 350;
            pictureBox12.Left = 350;
            pictureBox12.Left = 350;
            pictureBox13.Left = 350;
            pictureBox13.Left = 350;
            UltraMod.Enabled = false;
            ТаймерДляБлох.Enabled = false;
            MessageBox.Show("Вы проиграли!(");
            time1 = 0;
            label3.Text = 0.ToString();
            resClassic = 0;
            label2.Text = 00.ToString();
            Classic.Enabled = false;
            label1.Visible = true;
            pictureBox2.Visible = false;
            Жук1.Enabled = true;
            //timer2.Enabled = true;
            pictureBox1.Visible = true;
            pictureBox3.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            keyClassic = 0;
            keySpeedrun = 0;
            keyUltra = 0;
            progressBar1.Value = 0;
            resGlobalSpeedrun = 0;
            resSpeedrun = 0;
            Classic.Enabled = false;
            label2.Visible = false;
            pictureBox4.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            label3.Visible = false;
            SpeedRun.Enabled = false;
            pictureBox2.Visible = false;
            label4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            progressBar1.Visible = false;
            resUltra = 0;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox2.Top = 350;
            pictureBox2.Left = 350;
            pictureBox7.Top = 350;
            pictureBox7.Left = 350;
            pictureBox8.Top = 350;
            pictureBox8.Left = 350;
            pictureBox9.Top = 350;
            pictureBox9.Left = 350;
            pictureBox10.Top = 350;
            pictureBox10.Top = 350;
            pictureBox11.Top = 350;
            pictureBox11.Top = 350;
            pictureBox12.Left = 350;
            pictureBox12.Left = 350;
            pictureBox13.Left = 350;
            pictureBox13.Left = 350;
            UltraMod.Enabled = false;
            ТаймерДляБлох.Enabled = false;
            MessageBox.Show("Вы проиграли!(");
            time1 = 0;
            label3.Text = 0.ToString();
            resClassic = 0;
            label2.Text = 00.ToString();
            Classic.Enabled = false;
            label1.Visible = true;
            pictureBox2.Visible = false;
            Жук1.Enabled = true;
            //timer2.Enabled = true;
            pictureBox1.Visible = true;
            pictureBox3.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            keyClassic = 0;
            keySpeedrun = 0;
            keyUltra = 0;
            progressBar1.Value = 0;
            resGlobalSpeedrun = 0;
            resSpeedrun = 0;
            Classic.Enabled = false;
            label2.Visible = false;
            pictureBox4.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            label3.Visible = false;
            SpeedRun.Enabled = false;
            pictureBox2.Visible = false;
            label4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            progressBar1.Visible = false;
            resUltra = 0;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

            pictureBox2.Top = 350;
            pictureBox2.Left = 350;
            pictureBox7.Top = 350;
            pictureBox7.Left = 350;
            pictureBox8.Top = 350;
            pictureBox8.Left = 350;
            pictureBox9.Top = 350;
            pictureBox9.Left = 350;
            pictureBox10.Top = 350;
            pictureBox10.Top = 350;
            pictureBox11.Top = 350;
            pictureBox11.Top = 350;
            pictureBox12.Left = 350;
            pictureBox12.Left = 350;
            pictureBox13.Left = 350;
            pictureBox13.Left = 350;
            UltraMod.Enabled = false;
            ТаймерДляБлох.Enabled = false;
            MessageBox.Show("Вы проиграли!(");
            time1 = 0;
            label3.Text = 0.ToString();
            resClassic = 0;
            label2.Text = 00.ToString();
            Classic.Enabled = false;
            label1.Visible = true;
            pictureBox2.Visible = false;
            Жук1.Enabled = true;
            //timer2.Enabled = true;
            pictureBox1.Visible = true;
            pictureBox3.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            keyClassic = 0;
            keySpeedrun = 0;
            keyUltra = 0;
            progressBar1.Value = 0;
            resGlobalSpeedrun = 0;
            resSpeedrun = 0;
            Classic.Enabled = false;
            label2.Visible = false;
            pictureBox4.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            label3.Visible = false;
            SpeedRun.Enabled = false;
            pictureBox2.Visible = false;
            label4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            progressBar1.Visible = false;
            resUltra = 0;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer8_Tick(object sender, EventArgs e)
        {                        
            pictureBox14.Left -= 70;
            if (pictureBox14.Left <= -40)
            {
                pictureBox14.Visible = false;
                timer8.Enabled = false;
                pictureBox2.Top = 350;
                pictureBox2.Left = 350;
                pictureBox7.Top = 350;
                pictureBox7.Left = 350;
                pictureBox8.Top = 350;
                pictureBox8.Left = 350;
                pictureBox9.Top = 350;
                pictureBox9.Left = 350;
                pictureBox10.Top = 350;
                pictureBox10.Top = 350;
                pictureBox11.Top = 350;
                pictureBox11.Top = 350;
                pictureBox12.Left = 350;
                pictureBox12.Left = 350;
                pictureBox13.Left = 350;
                pictureBox13.Left = 350;
                UltraMod.Enabled = false;
                ТаймерДляБлох.Enabled = false;
                MessageBox.Show("Вы проиграли!(");
                time1 = 0;
                label3.Text = 0.ToString();
                resClassic = 0;
                label2.Text = 00.ToString();
                Classic.Enabled = false;
                label1.Visible = true;
                pictureBox2.Visible = false;
                Жук1.Enabled = true;
                //timer2.Enabled = true;
                pictureBox1.Visible = true;
                pictureBox3.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                keyClassic = 0;
                keySpeedrun = 0;
                keyUltra = 0;
                progressBar1.Value = 0;
                resGlobalSpeedrun = 0;
                resSpeedrun = 0;
                Classic.Enabled = false;
                label2.Visible = false;
                pictureBox4.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                label3.Visible = false;
                SpeedRun.Enabled = false;
                pictureBox2.Visible = false;
                label4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                progressBar1.Visible = false;
                resUltra = 0;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
            }
        }

        

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            timer8.Enabled = false;
            pictureBox14.Visible = false;
            resUltra += 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}