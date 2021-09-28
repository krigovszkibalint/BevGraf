﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafikaDLL
{
    public static class ExtensionGraphics
    {
        #region DrawLineDDA
        public static void DrawLineDDA(this Graphics g,
            Pen pen, float x1, float y1, float x2, float y2)
        {
            float dx = x2 - x1;
            float dy = y2 - y1;
            float length = Math.Abs(dx) > Math.Abs(dy) ? Math.Abs(dx) : Math.Abs(dy);
            float incX = dx / length;
            float incY = dy / length;
            float x = x1, y = y1;
            g.DrawRectangle(pen, x, y, 0.5f, 0.5f);
            for (int i = 0; i < length; i++)
            {
                x += incX;
                y += incY;
                g.DrawRectangle(pen, x, y, 0.5f, 0.5f);
            }
        }
        public static void DrawLineDDA(this Graphics g,
            Pen pen, int x1, int y1, int x2, int y2)
        {
            g.DrawLineDDA(pen, (float)x1, (float)y1, (float)x2, (float)y2);
        }
        public static void DrawLineDDA(this Graphics g,
            Pen pen, PointF p1, PointF p2)
        {
            g.DrawLineDDA(pen, p1.X, p1.Y, p2.X, p2.Y);
        }
        public static void DrawLineDDA(this Graphics g,
            Pen pen, Point p1, Point p2)
        {
            g.DrawLineDDA(pen, p1.X, p1.Y, p2.X, p2.Y);
        }

        public static void DrawLineDDA(this Graphics g,
            Color c1, Color c2, float x1, float y1, float x2, float y2)
        {
            float dx = x2 - x1;
            float dy = y2 - y1;
            float length = Math.Abs(dx) > Math.Abs(dy) ? Math.Abs(dx) : Math.Abs(dy);
            float incX = dx / length;
            float incY = dy / length;
            float incR = (c2.R - c1.R) / length;
            float incG = (c2.G - c1.G) / length;
            float incB = (c2.B - c1.B) / length;  
            float x = x1, y = y1;
            float R = c1.R, G = c1.G, B = c1.B;
            g.DrawRectangle(new Pen(Color.FromArgb((int)R, (int)G, (int)B)), x, y, 0.5f, 0.5f);
            for (int i = 0; i < length; i++)
            {
                x += incX; y += incY;
                R += incR; G += incG; B += incB;
                g.DrawRectangle(new Pen(Color.FromArgb((int)R, (int)G, (int)B)), x, y, 0.5f, 0.5f);
            }
        }
        public static void DrawLineDDA(this Graphics g,
            Color c1, Color c2, PointF p1, PointF p2)
        {
            g.DrawLineDDA(c1, c2, p1.X, p1.Y, p2.X, p2.Y);
        }
        #endregion

        #region DrawLineDDA
        public static void DrawLineMidPoint(this Graphics g,
            Pen pen, float x1, float y1, float x2, float y2)
        {
            throw new NotImplementedException();
        }
        public static void DrawLineMidPoint(this Graphics g,
            Pen pen, PointF p1, PointF p2)
        {
            g.DrawLineMidPoint(pen, p1.X, p1.Y, p2.X, p2.Y);
        }
        public static void DrawLineMidPoint(this Graphics g,
            Color c1, Color c2, float x1, float y1, float x2, float y2)
        {
            throw new NotImplementedException();
        }
        public static void DrawLineMidPoint(this Graphics g,
            Color c1, Color c2, PointF p1, PointF p2)
        {
            g.DrawLineMidPoint(c1, c2, p1.X, p1.Y, p2.X, p2.Y);
        }
        #endregion

        #region DrawPolygon
        public static void DrawPolygonDDA(this Graphics g, Pen pen, PointF[] points, bool closed = false)
        {
            if (points.Length < 2)
                throw new Exception();

            for (int i = 0; i < points.Length - 1; i++)
                g.DrawLineDDA(pen, points[i], points[i + 1]);
            if (closed)
                g.DrawLineDDA(pen, points[points.Length - 1], points[0]);
        }
        public static void DrawPolygon(this Graphics g, Color[] colors, PointF[] points, bool closed = false)
        {
            if (points.Length < 2)
                throw new Exception();

            for (int i = 0; i < points.Length - 1; i++)
                g.DrawLineDDA(colors[i], colors[i + 1], points[i], points[i + 1]);
            if (closed)
                g.DrawLineDDA(colors[colors.Length - 1], colors[0], points[points.Length - 1], points[0]);
        }
        #endregion

        #region DrawCircle
        public static void DrawCircle(this Graphics g, Pen pen, PointF C, float r)
        {

        }
        public static void DrawCircle(this Graphics g, Color c1, Color c2, PointF C, float r)
        {

        }
        #endregion
    }
}
