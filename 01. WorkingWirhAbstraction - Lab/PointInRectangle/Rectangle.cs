using System;
using System.Collections.Generic;
using System.Text;

namespace PointInRectangle
{
    public class Rectangle
    {
        public Rectangle(Point topLeftPoint, Point bottomRightPoint)
        {
            this.TopLeftCoordinates = topLeftPoint;
            this.BottomRightCoordinates = bottomRightPoint;

        }
        public Point TopLeftCoordinates { get; set; }
        public Point BottomRightCoordinates { get; set; }

        public bool Contains(Point point)
        {
            if (point.X >= TopLeftCoordinates.X && point.X <= BottomRightCoordinates.X &&
                point.Y >= TopLeftCoordinates.Y && point.Y <= BottomRightCoordinates.Y)
            {
                return true;
            }
            return false;
        }
    }
}
