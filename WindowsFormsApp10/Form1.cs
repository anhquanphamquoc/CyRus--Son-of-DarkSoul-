using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            point2 = Properties.Settings.Default.hscore;

        }
        #region Declaring
        List<PictureBox> items = new List<PictureBox>();
        List<PictureBox> items2 = new List<PictureBox>();
        List<PictureBox> items3 = new List<PictureBox>();
        List<PictureBox> items5 = new List<PictureBox>();
        List<ProgressBar> items4 = new List<ProgressBar>();
        Random rand = new Random();

        int temp=0;
        int range3, range2;
        int way;
        int count,count2;
        int manaP = 100;
        int maP = 100;
        int[] a = { -1700,  -1400,  -1300,  -1200, 1200,  1300,  1400,  1700};
        int eHP = 4;
        Color[] newColor = { Color.Turquoise, Color.Black, Color.DarkCyan, Color.LightGoldenrodYellow, Color.LawnGreen, Color.OrangeRed };
        int playerSpeed = 4;
        int m = 0;
        bool goUp, goDown, goLeft, goRight;
        int point, p,point2;
        int x, y;
        #endregion
        #region CreateObjects
        private void MakeItems()//create items 
        {
            Random rnd = new Random();
            int p = rnd.Next(30, 50);
            PictureBox new_pic = new PictureBox();
            new_pic.Height = p;
            new_pic.Width = p;
            new_pic.BackColor = newColor[rand.Next(0, newColor.Length)];
            if (new_pic.BackColor == Color.Turquoise)
            {
                new_pic.Image = global::WindowsFormsApp10.Properties.Resources.manacong;
                new_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                foreach (PictureBox item in items.ToList())
                {
                    if (new_pic.Bounds.IntersectsWith(item.Bounds))
                    {
                        this.Controls.Remove(item);
                       
                    }
                }
                new_pic.Height = 60;
                new_pic.Width = 60;
            }
            else if (new_pic.BackColor == Color.DarkCyan)
            {
                new_pic.Image = global::WindowsFormsApp10.Properties.Resources.manaspeed;
                new_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                foreach (PictureBox item in items.ToList())
                {
                    if (new_pic.Bounds.IntersectsWith(item.Bounds))
                    {
                        this.Controls.Remove(item);
                    }
                }
                new_pic.Height = 60;
                new_pic.Width = 60;
            }
            else if (new_pic.BackColor == Color.Black)
            {
                new_pic.Image = global::WindowsFormsApp10.Properties.Resources.BlackHole;
                new_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                foreach (PictureBox item in items.ToList())
                {
                    if (new_pic.Bounds.IntersectsWith(item.Bounds))
                    {
                        this.Controls.Remove(item);
                    }
                }
            }
            else if (new_pic.BackColor == Color.LightGoldenrodYellow)
            {
                new_pic.Image = global::WindowsFormsApp10.Properties.Resources.diem_cam;
                new_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                foreach (PictureBox item in items.ToList())
                {
                    if (new_pic.Bounds.IntersectsWith(item.Bounds))
                    {
                        this.Controls.Remove(item);
                    }
                }
            }
            else if (new_pic.BackColor == Color.LawnGreen)
            {
                new_pic.Image = global::WindowsFormsApp10.Properties.Resources.diem_la;
                new_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                foreach (PictureBox item in items.ToList())
                {
                    if (new_pic.Bounds.IntersectsWith(item.Bounds))
                    {
                        this.Controls.Remove(item);
                    }
                }
            }
            else if (new_pic.BackColor == Color.Orange)
            {
                new_pic.Image = global::WindowsFormsApp10.Properties.Resources.diem_xanh;
                new_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                foreach (PictureBox item in items.ToList())
                {
                    if (new_pic.Bounds.IntersectsWith(item.Bounds))
                    {
                        this.Controls.Remove(item);
                    }
                }
            }
            else
            {
                new_pic.Image = global::WindowsFormsApp10.Properties.Resources.diem_xanh;
                new_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                foreach (PictureBox item in items.ToList())
                {
                    if (new_pic.Bounds.IntersectsWith(item.Bounds))
                    {
                        this.Controls.Remove(item);
                    }
                }
            }
            x = rand.Next(50, this.ClientSize.Width - new_pic.Width);
            y = rand.Next(50, this.ClientSize.Height - new_pic.Height);
            if (new Point(x, y) != player.Location)
                new_pic.Location = new Point(x, y);
            items.Add(new_pic); 
            this.Controls.Add(new_pic); 
            
        }
        private void MakeEnemy()//spawn enemy 
        {
            Random rnd = new Random();
            int p = rnd.Next(20, 40);
            PictureBox em = new PictureBox();
            em.Height = 40;
            em.Width = 40;
            em.BackColor = Color.DarkSlateGray;
            em.Image = global::WindowsFormsApp10.Properties.Resources.enemytruoc;
            em.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            if (em.BackColor == Color.Black)
            {

                foreach (PictureBox item in items.ToList())
                {
                    if (em.Bounds.IntersectsWith(item.Bounds))
                    {
                        this.Controls.Remove(item);
                    }
                }
            }
            x = player.Location.X + a[rand.Next(0, a.Length)];
            y = player.Location.Y + a[rand.Next(0, a.Length)];
            if (new Point(x, y) != player.Location)
                em.Location = new Point(x, y);
            items3.Add(em); 
            this.Controls.Add(em); 
            em.BringToFront();
            
        }

        private void MakeCbullet() //create bullets-E
        {
            PictureBox bullet = new PictureBox();
            bullet.Height = 15;
            bullet.Width = 15;
            bullet.BackColor = Color.WhiteSmoke;
            bullet.Image = global::WindowsFormsApp10.Properties.Resources.danbth;
            bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom; 
            x = player.Location.X;
            y = player.Location.Y + 15;
            bullet.Location = new Point(x, y);
            items2.Add(bullet);
            this.Controls.Add(bullet);
            soundshot();
        }
        private void MakeMissile() //create bullets-Q
        {
            PictureBox bullet = new PictureBox();
            bullet.Height = 30;
            bullet.Width = 30;
            bullet.BackColor = Color.DarkOrange;
            bullet.Image = global::WindowsFormsApp10.Properties.Resources.quacau;
            bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            x = player.Location.X;
            y = player.Location.Y;
            bullet.Location = new Point(x, y);
            items2.Add(bullet);
            this.Controls.Add(bullet);
            soundshotmiss();
        }
        
        private void MakeLazer() //create bullets-W
        {
            PictureBox bullet = new PictureBox();
            bullet.Height = 10;
            bullet.Width = 1300;
            bullet.BackColor = Color.Red;
            bullet.Image = global::WindowsFormsApp10.Properties.Resources.laze;
            bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            bullet.Location = new Point(x, -100);
            items2.Add(bullet);
            this.Controls.Add(bullet);
            soundlaze();
        }
        private void MakeSlime() //crate Slime-S
        {
            PictureBox slime = new PictureBox();
            slime.Height = 80;
            slime.Width = 80;
            slime.BackColor = Color.PaleGreen;
            slime.Image = global::WindowsFormsApp10.Properties.Resources.slime;
            slime.SizeMode = PictureBoxSizeMode.Zoom;
            x = player.Location.X-21;
            y = player.Location.Y-18;
            slime.Location = new Point(x, y);
            items2.Add(slime);
            this.Controls.Add(slime);
            soundMakeSlime();
        }

        private void HealthBar() //enemy healbar
        {
            ProgressBar heal = new ProgressBar();
            foreach (PictureBox item in items3.ToList())
            {
                x = item.Location.X;
                y = item.Location.Y - 60;
                heal.Location = new Point(x, y);
            }

            heal.Height = 10;
            heal.Width = 40;
            items4.Add(heal); // add to the list
            this.Controls.Add(heal);
            heal.Value = 100;
        }
        #endregion
        #region KeyBoard
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                this.player.Image = global::WindowsFormsApp10.Properties.Resources.trai;
                this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                goLeft = true;
                way = 1;
            }
            if (e.KeyCode == Keys.Right)
            {
                this.player.Image = global::WindowsFormsApp10.Properties.Resources.phai;
                this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                goRight = true;
                way = 0;
            }
            if (e.KeyCode == Keys.Up)
            {
                this.player.Image = global::WindowsFormsApp10.Properties.Resources.sau;
                this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                goUp = true;
                way = 2;
            }
            if (e.KeyCode == Keys.Down)
            {
                this.player.Image = global::WindowsFormsApp10.Properties.Resources.truoc;
                this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                goDown = true;
                way = 3;
            }
            if (e.KeyCode == Keys.Space && manaP > 0)
            {
                playerSpeed = 25;
                soundSpeed();
                

            }
            if (e.KeyCode == Keys.D && manaP > 0)
            {
                if (way == 0)
                {
                    player.Location = new Point(player.Location.X + 300, player.Location.Y);
                    manaP -= 10;
                    if (player.Left + player.Width > this.ClientSize.Width - 3)
                    {
                        player.Location = new Point(player.Location.X - 300, player.Location.Y);
                        manaP += 10;
                    }
                }
                if (way == 1)
                {
                    player.Location = new Point(player.Location.X - 300, player.Location.Y);
                    manaP -= 10;
                    if (player.Left < 0 + 3)
                    {
                        player.Location = new Point(player.Location.X + 300, player.Location.Y);
                        manaP += 10;
                    }
                }
                if (way == 2)
                {
                    player.Location = new Point(player.Location.X, player.Location.Y - 100);
                    manaP -= 10;
                    if (player.Top < 0)
                    {
                        player.Location = new Point(player.Location.X, player.Location.Y + 100);
                        manaP += 10;
                    }
                }
                if (way == 3)
                {
                    player.Location = new Point(player.Location.X, player.Location.Y + 100);
                    manaP -= 10;
                    if (player.Top + player.Height > this.ClientSize.Height)
                    {
                        player.Location = new Point(player.Location.X, player.Location.Y - 100);
                        manaP += 10;
                    }
                }
                temp = 0;
                soundTeleport();
                //StopsoundGetBlack();
            }

            if (e.KeyCode == Keys.A && manaP > 0)
            {
                foreach (PictureBox item in items3.ToList())
                {
                    int h, w;
                    h = player.Location.X;
                    w = player.Location.Y;
                    manaP -= 20;
                    player.Location = new Point(item.Location.X, item.Location.Y);
                    item.Location = new Point(h, w);
                
                if (player.Left + player.Width > this.ClientSize.Width - 3 || player.Top + player.Height > this.ClientSize.Height || player.Top < 0 || player.Left + player.Width > this.ClientSize.Width - 3)
                {
                    h = player.Location.X;
                    w = player.Location.Y;

                    player.Location = new Point(item.Location.X, item.Location.Y);
                    item.Location = new Point(h, w);
                    manaP += 20;
                    
                    //StopsoundGetBlack();
                }
                    temp = 0;
                    soundSwap();

                }
            }
            if (e.KeyCode == Keys.Q && manaP > 0)
            {
                MakeMissile();
                manaP -= maP * 30 / 100;
            }
            if (e.KeyCode == Keys.E && manaP > 0)
            {
                MakeCbullet();
                manaP -= maP * 20 / 100;
            }
            if (e.KeyCode == Keys.W && manaP > 0)
            {
                MakeLazer();
                manaP -= maP * 40 / 100;
                temp = 0;
                
            }
            if (e.KeyCode == Keys.S && manaP > 0)
            {
                MakeSlime();
                manaP -= maP * 20 / 100;
            }
            e.SuppressKeyPress = (e.KeyCode == e.KeyCode); //turn off beep sounds

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
                this.player.Image = global::WindowsFormsApp10.Properties.Resources.truoc;
                this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
                this.player.Image = global::WindowsFormsApp10.Properties.Resources.truoc;
                this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
                this.player.Image = global::WindowsFormsApp10.Properties.Resources.truoc;
                this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
                this.player.Image = global::WindowsFormsApp10.Properties.Resources.truoc;
                this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            }
            if (e.KeyCode == Keys.Space)
            {
                playerSpeed = 4;
                manaP -= 5;
            }
            if (e.KeyCode == Keys.Escape)
            {

                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                timer5.Stop();
                timer6.Stop();
                timer7.Stop();
                timer8.Stop();
             
                panelPauseGame.Visible = true;
                panelPauseGame.Enabled = true;
                panelPauseGame.BringToFront();
                ScoreLabel.Text = "Highest Score: " + point2;
                Cursor.Show();
            }
        }
        #endregion
        #region Events
        private void TimerEvent(object sender, EventArgs e)
        {
            MakeItems();
           
            if ((1000 + items.Count() * 250) > point * 100)
            {
                timer1.Interval = (1000 + items.Count() * 250) - point * 100;
            }
            int b = point2;
            if (point > b)
            {
                point2 = point;
                Properties.Settings.Default.hscore = point2;
                
            }
        }
        private void TimerEvent2(object sender, EventArgs e)
        {

            if (manaP < maP)
            {
                manaP++;
            }

        }
        private void TimerEvent3(object sender, EventArgs e)
        {
            // do the player movement below

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true && player.Left + player.Width < this.ClientSize.Width - 3)
            {
                player.Left += playerSpeed;
            }
            if (goUp == true && player.Top > 0)
            {
                player.Top -= playerSpeed;
            }
            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += playerSpeed;
            }
        }

        private void TimerEvent4(object sender, EventArgs e)
        {
            mana.Text = "Mana: " + manaP;

            foreach (PictureBox item in items3.ToList())
            {
                if (item.Location.X < player.Location.X )
                {
                    item.Location = new Point(item.Location.X + 4, item.Location.Y);
                }
                if (item.Location.X > player.Location.X)
                {
                    item.Location = new Point(item.Location.X - 4, item.Location.Y);
                }
                if (item.Location.Y < player.Location.Y)
                {
                    item.Location = new Point(item.Location.X, item.Location.Y + 4);
                }
                if (item.Location.Y > player.Location.Y)
                {
                    item.Location = new Point(item.Location.X, item.Location.Y - 4);
                }
                foreach (ProgressBar item3 in items4.ToList())
                {
                    x = item.Location.X;
                    y = item.Location.Y - 20;
                    item3.Location = new Point(x, y);
                }
                foreach (PictureBox item2 in items.ToList())
                {
                    if (item.Bounds.IntersectsWith(item2.Bounds))
                    {
                        if (item2.BackColor != Color.Black)
                        {
                            items.Remove(item2);
                            this.Controls.Remove(item2);
                            
                        }
                    }
                }
            }
        }

        private void TimerEvent5(object sender, EventArgs e)
        {
            foreach (PictureBox item in items3.ToList())
            {
                if (player.Bounds.IntersectsWith(item.Bounds))
                {   
                    soundEndGame();
                    playerSpeed = 0;
                    player.Hide();
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Stop();
                    timer4.Stop();
                    timer5.Stop();
                    timer6.Stop();
                    timer7.Stop();
                    timer8.Stop();
                    
                    panelPauseGame.Visible = true;
                    panelPauseGame.Enabled = true;
                    panelPauseGame.BringToFront();
                    ScoreLabel.Text = "Highest Score: " + point2;

                    buttonContinue.Enabled = false;
                    Cursor.Show();
                    Properties.Settings.Default.Save();
                }
            }
            // collision between the player the items picturebox

            foreach (PictureBox item in items.ToList())
            {
                if (player.Bounds.IntersectsWith(item.Bounds))
                {
                    
                    if (item.BackColor == Color.Black)
                    {
                        if (temp == 0)
                        {
                            soundGetBlack();
                            temp = 1;
                        }
                        if (item.Location.X < player.Location.X)
                        {
                            player.Left -= playerSpeed;
                        }
                        if (item.Location.X > player.Location.X)
                        {
                            player.Left += playerSpeed;
                        }
                        if (item.Location.Y < player.Location.Y)
                        {
                            player.Top -= playerSpeed;
                        }
                        if (item.Location.Y > player.Location.Y)
                        {
                            player.Top += playerSpeed;
                        }
                    }
                    else
                    {
                        
                        if (item.BackColor != Color.DarkCyan && item.BackColor != Color.Turquoise)
                        {
                            soundGetBlock();
                            point++;
                        }
                            
                        items.Remove(item);
                        this.Controls.Remove(item);
                        
                        
                        p++;
                        Box.Text = "Score: " + point;
                        if (p == 3)
                        {
                            if (timer4.Interval >= 15)
                            {

                                timer4.Interval = timer4.Interval - (p / 3);
                                p -= 3;
                            }
                        }
                        if (item.BackColor == Color.DarkCyan)
                        {
                            soundGetMana();
                            if (timer2.Interval > 20)
                            {
                                
                                timer2.Interval -= 30;
                            }
                        }
                        if (item.BackColor == Color.Turquoise)
                        {
                            soundGetMana();
                            if (maP < 500)
                            {
                                
                                maP += 5;
                                manaP += 20+maP*20/100;
                            }
                        }
                    } 
                }
                foreach (PictureBox item2 in items3.ToList())
                {
                    if (item2.Bounds.IntersectsWith(item.Bounds))
                    {
                        
                        if (item.BackColor == Color.Black)
                        {
                            if (count >= 30 + point / 2)
                            {
                                item.Location = new Point(-100, -100);
                                items.Remove(item);
                                this.Controls.Remove(item);
                                item2.Size = new System.Drawing.Size(50 + m * (5 + point / 20), 50 + m * (4 + point / 20));
                                m+=3;
                                foreach (ProgressBar item4 in items4.ToList())
                                {
                                    item4.Width = 45 + m * (5 + point / 20) - m;
                                    item4.Value = 100;
                                    eHP = 4;
                                }
                                count++;
                                count = 0;
                            }
                            count++;

                        }
                    }
                }
            }
        }

        private void TimerEvent6(object sender, EventArgs e)
        {
            foreach (ProgressBar item4 in items4.ToList())
            {
                foreach (PictureBox item in items2.ToList())
                {
                    foreach (PictureBox item3 in items3.ToList())
                    {
                        
                        if (item.BackColor == Color.DarkOrange)
                        {

                            if (item.Location.X < item3.Location.X)
                            {
                                item.Location = new Point(item.Location.X + 1, item.Location.Y);
                            }
                            if (item.Location.X > item3.Location.X)
                            {
                                item.Location = new Point(item.Location.X - 1, item.Location.Y);
                            }
                            if (item.Location.Y < item3.Location.Y)
                            {
                                item.Location = new Point(item.Location.X, item.Location.Y + 1);
                            }
                            if (item.Location.Y > item3.Location.Y)
                            {
                                item.Location = new Point(item.Location.X, item.Location.Y - 1);
                            }
                            if (item3.Bounds.IntersectsWith(item.Bounds))
                            {

                                if (eHP <= 0)
                                {
                                    items3.Remove(item3);
                                    this.Controls.Remove(item3);
                                    items4.Remove(item4);
                                    this.Controls.Remove(item4);
                                    soundBossDie();
                                    eHP = 4;
                                    point += 5;
                                    
                                }
                                timer8.Stop();
                                item4.Value -= 20;

                                eHP--;
                                Box.Text = "Score: " + point.ToString();
                                items2.Remove(item);
                                this.Controls.Remove(item);
                                if (timer4.Interval < 20)
                                {
                                    timer4.Interval++;
                                    p -= 3;
                                }
                            }
                            if (item3.Bounds.IntersectsWith(item.Bounds))
                            {
                                if (item3.Location.X < player.Location.X)
                                {
                                    item3.Location = new Point(item3.Location.X - 40, item3.Location.Y);
                                }
                                if (item3.Location.X > player.Location.X)
                                {
                                    item3.Location = new Point(item3.Location.X + 40, item3.Location.Y);
                                }
                                if (item3.Location.Y < player.Location.Y)
                                {
                                    item3.Location = new Point(item3.Location.X, item3.Location.Y - 40);
                                }
                                if (item3.Location.Y > player.Location.Y)
                                {
                                    item3.Location = new Point(item3.Location.X, item3.Location.Y + 40);
                                }

                            }
                        }
                        if (item.BackColor == Color.WhiteSmoke)
                        {
                            if (way == 0)
                            {
                                item.Location = new Point(item.Location.X + 5, item.Location.Y);
                                range3++;
                            }
                            else
                            {
                                item.Location = new Point(item.Location.X - 5, item.Location.Y);
                                range3++;
                            }
                            if (item3.Bounds.IntersectsWith(item.Bounds) || range3 >= 250)
                            {
                                items2.Remove(item);
                                this.Controls.Remove(item);
                                if (item3.Bounds.IntersectsWith(item.Bounds))
                                {

                                    if (eHP <= 0)
                                    {
                                        items3.Remove(item3);
                                        this.Controls.Remove(item3);
                                        items4.Remove(item4);
                                        this.Controls.Remove(item4);
                                        soundBossDie();
                                        eHP = 4;
                                        point += 5;
                                        if (timer4.Interval < 20)
                                        {
                                            timer4.Interval++;
                                            p -= 3;
                                        }
                                    }
                                    timer8.Stop();
                                    item4.Value -= 20;

                                    eHP--;
                                    Box.Text = "Score: " + point.ToString();

                                }
                                range3 = 0;
                            }
                            if (item3.Bounds.IntersectsWith(item.Bounds))
                            {
                                if (item3.Location.X < player.Location.X)
                                {
                                    item3.Location = new Point(item3.Location.X - 10, item3.Location.Y);
                                }
                                if (item3.Location.X > player.Location.X)
                                {
                                    item3.Location = new Point(item3.Location.X + 10, item3.Location.Y);
                                }
                                if (item3.Location.Y < player.Location.Y)
                                {
                                    item3.Location = new Point(item3.Location.X, item3.Location.Y - 10);
                                }
                                if (item3.Location.Y > player.Location.Y)
                                {
                                    item3.Location = new Point(item3.Location.X, item3.Location.Y + 10);
                                }
                            }
                        }
                        if (item.BackColor == Color.Red)
                        {
                            if (way == 0)
                            {
                                x = player.Location.X;
                                y = player.Location.Y + 15;
                                item.Location = new Point(x, y);
                                range2++;
                            }
                            else
                            {
                                x = player.Location.X - item.Width;
                                y = player.Location.Y + 15;
                                item.Location = new Point(x, y);
                                range2++;
                            }
                            if ((item3.Bounds.IntersectsWith(item.Bounds) && range2 >= 3) || range2 >= 10)
                            {
                                items2.Remove(item);
                                this.Controls.Remove(item);

                                range2 = 0;
                            }
                            if (item3.Bounds.IntersectsWith(item.Bounds))
                            {

                                if (eHP <= 0)
                                {
                                    items3.Remove(item3);
                                    this.Controls.Remove(item3);
                                    items4.Remove(item4);
                                    this.Controls.Remove(item4);
                                    soundBossDie();
                                    eHP = 4;
                                    point += 5;
                                }
                                timer8.Stop();
                                item4.Value -= 20;

                                eHP--;
                                
                                Box.Text = "Score: " + point.ToString();
                                if (timer4.Interval < 20)
                                {
                                    timer4.Interval++;
                                    p -= 3;
                                }
                            }
                            foreach (PictureBox item2 in items.ToList())
                            {
                                if (item.Bounds.IntersectsWith(item2.Bounds))
                                {
                                    if (item2.BackColor == Color.Black)
                                    {
                                        items.Remove(item2);
                                        this.Controls.Remove(item2);
                                    }
                                }
                            }
                            if (item3.Bounds.IntersectsWith(item.Bounds))
                            {
                                if (item3.Location.X < player.Location.X)
                                {
                                    item3.Location = new Point(item3.Location.X - 60, item3.Location.Y);
                                }
                                if (item3.Location.X > player.Location.X)
                                {
                                    item3.Location = new Point(item3.Location.X + 60, item3.Location.Y);
                                }
                                if (item3.Location.Y < player.Location.Y)
                                {
                                    item3.Location = new Point(item3.Location.X, item3.Location.Y - 60);
                                }
                                if (item3.Location.Y > player.Location.Y)
                                {
                                    item3.Location = new Point(item3.Location.X, item3.Location.Y + 60);
                                }
                            }
                        }
                        if (item.BackColor == Color.PaleGreen)
                        {
                            if (item3.Bounds.IntersectsWith(item.Bounds))
                            {   if (item.Height > 1)
                                {
                                    if (item3.Location.X < player.Location.X)
                                    {
                                        item3.Location = new Point(item3.Location.X - 80, item3.Location.Y);
                                        count2++;
                                        item.Height -= 8;
                                        item.Width -= 8;
                                    }
                                    if (item3.Location.X > player.Location.X)
                                    {
                                        item3.Location = new Point(item3.Location.X + 80, item3.Location.Y);
                                        count2++;
                                        item.Height -= 8;
                                        item.Width -= 8;
                                    }
                                    if (item3.Location.Y < player.Location.Y)
                                    {
                                        item3.Location = new Point(item3.Location.X, item3.Location.Y - 80);
                                        count2++;
                                        item.Height -= 8;
                                        item.Width -= 8;
                                    }
                                    if (item3.Location.Y > player.Location.Y)
                                    {
                                        item3.Location = new Point(item3.Location.X, item3.Location.Y + 80);
                                        count2++;
                                        item.Height -= 8;
                                        item.Width -= 8;
                                    }
                                }
                            }
                            if (count2 >= 6||item.Height<1)
                            {
                                items2.Remove(item);
                                this.Controls.Remove(item);
                                
                                count2 = 0;
                            }
                        }
                    }
                }
            }
        }
        
        private void TimerEvent7(object sender, EventArgs e)
        {
            if (items3.Count() <= 0)
            {
                MakeEnemy();
                
                HealthBar();
                timer8.Start();
              
              
            }
            foreach (PictureBox charac in items5.ToList())
            {
                x = player.Location.X - 5;
                y = player.Location.Y - 5;
                charac.Location = new Point(x, y);
            }
            
        }
        private void TimerEvent8(object sender, EventArgs e)
        {
            foreach (ProgressBar item in items4.ToList())
            {
                item.Value = 100;
            }
        }
        #endregion
        #region Interaction 
        private void buttonExitGame_Click_1(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Exit the game now ?", "Exit Game ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Close();
            }

        }
    

        private void buttonNewGameClick(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            timer1 = new Timer();
            timer1.Tick += new EventHandler(TimerEvent);
            timer1.Interval = 1; timer1.Start();

            timer2 = new Timer();
            timer2.Tick += new EventHandler(TimerEvent2);
            timer2.Interval = 800; timer2.Start();

            timer3 = new Timer();
            timer3.Tick += new EventHandler(TimerEvent3);
            timer3.Interval = 1; timer3.Start();

            timer4 = new Timer();
            timer4.Tick += new EventHandler(TimerEvent4);
            timer4.Interval = 40; timer4.Start();

            timer5 = new Timer();
            timer5.Tick += new EventHandler(TimerEvent5);
            timer5.Interval = 1; timer5.Start();

            timer6 = new Timer();
            timer6.Tick += new EventHandler(TimerEvent6);
            timer6.Interval = 10; timer6.Start();

            timer7 = new Timer();
            timer7.Tick += new EventHandler(TimerEvent7);
            timer7.Interval = 1; timer7.Start();
                
            Box.Visible = true;
            mana.Visible = true;
            this.Controls.Remove(button1);

            Cursor.Hide();
        }
        
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            
            player.Left = int.Parse(this.ClientSize.Width.ToString()) / 2 - player.Width / 2;
            player.Top = int.Parse(this.ClientSize.Height.ToString()) / 2 - player.Height / 2;
            button1.Left = int.Parse(this.ClientSize.Width.ToString()) / 2 - button1.Width / 2;
            button1.Top = player.Bottom + 30;
            panelPauseGame.Left = int.Parse(this.ClientSize.Width.ToString()) / 2 - panelPauseGame.Width / 2-15;
            panelPauseGame.Top = int.Parse(this.ClientSize.Width.ToString()) / 2 - panelPauseGame.Height / 2;
            

        }

        private void RestartGame()
        {

            panelPauseGame.Enabled = false;
            panelPauseGame.Visible = false;
            
            range3 = 0; range2 = 0;
            way = 0;
            count = 0;
            manaP = 100;
            maP = 100;
            eHP = 4;
            playerSpeed = 4;
            m = 0;
            goUp = false; goDown = false; goLeft = false; goRight = false;
            point = 0; p = 0;
            x = 0; y = 0;
            this.Controls.Add(button1);

            foreach (var item in items) { this.Controls.Remove(item); }
            foreach (var item in items2) { this.Controls.Remove(item); }
            foreach (var item in items3) { this.Controls.Remove(item); }
            foreach (var item in items4) { this.Controls.Remove(item); }
            foreach (var item in items5) { this.Controls.Remove(item); }


            items.Clear();
            items2.Clear();
            items3.Clear();
            items4.Clear();
            items5.Clear();

            timer1.Stop(); timer1.Dispose();
            timer2.Stop(); timer2.Dispose();
            timer3.Stop(); timer3.Dispose();
            timer4.Stop(); timer4.Dispose();
            timer5.Stop(); timer5.Dispose();
            timer6.Stop(); timer6.Dispose();
            timer7.Stop(); timer7.Dispose();
            timer8.Stop(); timer8.Dispose();
            ScoreLabel.Text = "Highest Score: " + point2;


            mana.Visible = false;
            Box.Visible = false;

            player.Show();
            player.Left = int.Parse(this.ClientSize.Width.ToString()) / 2 - player.Width / 2;
            player.Top = int.Parse(this.ClientSize.Height.ToString()) / 2 - player.Height / 2;
            button1.Left = int.Parse(this.ClientSize.Width.ToString()) / 2 - button1.Width / 2;
            button1.Top = player.Bottom + 30;
            buttonContinue.Enabled = true;
          
        }
        private void buttonContinueGameClick(object sender, EventArgs e)
        {
            panelPauseGame.Enabled = false;
            panelPauseGame.Visible = false;
            timer1.Start();
            timer4.Start();
            timer2.Start();
            timer3.Start();
            timer5.Start();
            timer6.Start();
            Cursor.Hide();

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            player.Left = int.Parse(this.ClientSize.Width.ToString()) / 2 - player.Width / 2;
            player.Top = int.Parse(this.ClientSize.Height.ToString()) / 2 - player.Height / 2;
            button1.Left = int.Parse(this.ClientSize.Width.ToString()) / 2 - button1.Width / 2;
            button1.Top = player.Bottom + 30;
            panelPauseGame.Visible = false;
            panelPauseGame.Enabled = false;
        }
        #endregion
        #region SoundEffect

        private void soundGetMana()
        {
            SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + @"\mus\getmana.wav");
            simpleSound.Play();
        }
        private void soundGetBlack()
        {
            SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + @"\mus\fire.wav");
            simpleSound.Play();
        }
        private void StopsoundGetBlack()
        {
            SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + @"\mus\getblack.wav");
            simpleSound.Stop();
        }
        private void soundGetBlock()
        {
            SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + @"\mus\getblock.wav");
            simpleSound.Play();
        }
        private void soundshot()
        {
            SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + @"\mus\shot.wav");
            simpleSound.Play();
        }
        private void soundshotmiss()
        {
            SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + @"\mus\shotmiss.wav");
            simpleSound.Play();
        }
        private void soundlaze()
        {
            SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + @"\mus\laze.wav");
            simpleSound.Play();
        }

        private void soundSwap()
        {
            // SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + @"\mus\sasukeswap.wav");
            SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + @"\mus\rinnegan.wav");
            simpleSound.Play();
        }
        private void soundTeleport()
        {
            SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + @"\mus\teleportDBZ (mp3cut.net).wav");
            simpleSound.Play();
        }
        private void soundSpeed()
        {
            //SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + @"\mus\mixkit-extra-bonus-in-a-video-game-2045.wav");

            SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + @"\mus\fly.wav");
            simpleSound.Play();
            
        }
        private void soundMakeSlime()
        {
            SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + @"\mus\makeslime.wav");
            simpleSound.Play();
        }
        private void soundBossDie()
        {
            SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + @"\mus\bossdie.wav");
            simpleSound.Play();
        }
        private void soundBoss()
        {
            SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + @"\mus\boss.wav");
            simpleSound.Play();
        }
        private void soundEndGame()
        {
            SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + @"\mus\gameover.wav");
            simpleSound.Play();
        }
        #endregion
    }


}
