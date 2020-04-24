﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsteroidGame
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Form game_form = new Form();
            //Screen.PrimaryScreen.WorkingArea.Height

            const int game_form_width = 800;
            const int game_form_height = 600;

            game_form.Width = game_form_width;
            game_form.Height = game_form_height;

            game_form.Show();

            Game.Initialize(game_form);
            Game.Load();
            Game.Draw();

            Application.Run(game_form);

            //System.Threading.Thread.Sleep(10000);
            //Application.Run();
        }
    }
}
