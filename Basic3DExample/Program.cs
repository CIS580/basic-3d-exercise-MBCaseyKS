﻿using System;

namespace Basic3DExample
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new ThreeDGame())
                game.Run();
        }
    }
}
