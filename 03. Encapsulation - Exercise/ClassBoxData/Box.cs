﻿using System;

namespace ClassBoxData
{
    public class Box
    {
        private decimal length;
        private decimal width;
        private decimal height;

        public Box(decimal length, decimal width, decimal height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public decimal Length
        {
            get => this.length;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                this.length = value;
            }
        }

        public decimal Width
        {
            get => this.width;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                this.width = value;
            }
        }

        public decimal Height
        {
            get => this.height;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

                this.height = value;
            }
        }

        public decimal SurfaceArea()
        {
            decimal area =
                2 * this.Length * this.Width +
                2 * this.Length * this.Height +
                2 * this.Height * this.Width;

            return area;
        }

        public decimal LateralSurfaceArea()
        {
            decimal area =
                2 * this.Length * this.Height +
                2 * this.Width * this.Height;

            return area;
        }

        public decimal Volume()
        {
            decimal volume = this.Height * this.Length * this.Width;

            return volume;
        }

    }
}
