﻿using System;

namespace PP
{
    internal class Ubicacion
    {
        private int x;
        private int y;
        public double X
        {
            get { return x; }
        }
        public double Y
        {
            get { return y; }
        }
        public Ubicacion(int x, int y) { this.x = x;this.y = y; }
        public override string ToString()
        {
            return "Eje X: " + this.X + " Eje Y: " + this.Y;
        }
    }
}
