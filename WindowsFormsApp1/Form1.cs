﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;


namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int resolution = 0;
        private int density;
        private bool[,] field;
        private int rows;
        private int cols;
        private int currentGenerations;
        private SoundPlayer Player = new SoundPlayer();
        public Form1()
        {
            PlayMusic();
            InitializeComponent();
        }
        

    public void ConvertMp3ToWav(string mp3FilePath, string wavFilePath)
    {
        using (Mp3FileReader mp3 = new Mp3FileReader(mp3FilePath))
        {
            using (WaveStream pcmStream = WaveFormatConversionStream.CreatePcmStream(mp3))
            {
                WaveFileWriter.CreateWaveFile(wavFilePath, pcmStream);
            }
        }
    }
    private void PlayMusic() {
            try
            {
                ConvertMp3ToWav(@"C:\Users\user\Downloads\Leaving Home.mp3", @"C:\Users\user\Downloads\Leaving Home.wav");
                this.Player.SoundLocation = @"C:\Users\user\Downloads\Leaving Home.wav";
                this.Player.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error playing sound");
            }
        }

        private void StartGame()
        {
            if (timer1.Enabled) {
                return;
            }
            currentGenerations = 0;
            mutations.Text = $"Мутация {currentGenerations}";
            ResolutionNud.Enabled = false;
            DensityNud.Enabled = false;
            resolution = (int)ResolutionNud.Value;
            density = (int)DensityNud.Value;
            rows = pictureBox1.Height / resolution;
            cols = pictureBox1.Width / resolution;
            field = new bool[cols, rows];

            Random rand = new Random();
            for(int x = 0; x < cols; x++)
            {
                for(int y = 0; y < rows; y++)
                {
                    field[x, y] = rand.Next((int)density) == 0;
                }

            }

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            timer1.Start();
        }

        private void NextGeneration()
        {
            graphics.Clear(Color.Black);

            bool[,] newField = new bool[cols, rows];

            for(int x = 0; x < cols; x++)
            {
                for(int y = 0; y < rows; y++)
                {
                    var NeighboursCount = CountNeighbours(x,y);
                    var hasLife = field[x, y];

                    if(!hasLife && NeighboursCount == 3)
                    {
                        newField[x, y] = true;
                    }
                    else if(hasLife && (NeighboursCount < 2 || NeighboursCount > 3))
                    {
                        newField[x, y] = false;

                    }
                    else
                    {
                        newField[x, y] = field[x, y];
                    }
                    if (hasLife)
                    {
                        graphics.FillRectangle(Brushes.DarkMagenta, x * resolution, y * resolution, resolution, resolution);
                    }
                }
            }
            field = newField;
            mutations.Text = $"Мутация {++currentGenerations}";
            pictureBox1.Refresh();

        }
        private int CountNeighbours(int x, int y)
        {
            int cnt = 0;
            for(int i = -1; i < 2; i++)
            {
                for(int j = -1; j < 2; j++)
                {
                    
                    if (i != 0 || j != 0) {
                        if (field[(x + i + cols) % cols, (y + j + rows) % rows])
                        {
                            cnt++;
                        }
                    }
                }
            }
            return cnt;
        }

        private void StopGame()
        {
            timer1.Stop();
            ResolutionNud.Enabled = true;
            DensityNud.Enabled = true;
        }
        private void ContinueGame()
        {
            timer1.Start();
            DensityNud.Value = density;
            ResolutionNud.Value = resolution;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            StartGame();
            bPause.Text = "стоп";

        }

        private void bPause_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                StopGame();
                bPause.Text = "продолжить";
            }
            else
            {
                ContinueGame();
                bPause.Text = "стоп";
            }
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(resolution == 0)
            {
                return;
            }
            if(e.Button == MouseButtons.Left)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                bool ValidationPassed = ValidateMousePosition(x,y);
                if (ValidationPassed)
                {
                    field[x, y] = true;
                    if (!timer1.Enabled)
                    {
                        graphics.FillRectangle(Brushes.DarkMagenta, x * resolution, y * resolution, resolution, resolution);
                        pictureBox1.Refresh();
                    }

                }
            }
            if (e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                bool ValidationPassed = ValidateMousePosition(x, y);
                if (ValidationPassed)
                {
                    field[x, y] = false;
                    if (!timer1.Enabled) {
                        graphics.FillRectangle(Brushes.Black, x * resolution, y * resolution, resolution, resolution);
                        pictureBox1.Refresh();
                    }
                    
                }
          
            }
        }
        private bool ValidateMousePosition(int x, int y)
        {
            return x >= 0 && y >= 0 && x < cols && y < rows;
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
