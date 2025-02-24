using System;
using System.Drawing;

namespace Draw
{
	/// <summary>
	/// Класът правоъгълник е основен примитив, който е наследник на базовия Shape.
	/// </summary>
	public class Elipsa : Shape
	{
	#region Constructor
		
		public Elipsa(RectangleF rect) : base(rect)
		{
		}
		
		public Elipsa(RectangleShape rectangle) : base(rectangle)
		{
		}
		
		#endregion

		/// <summary>
		/// Проверка за принадлежност на точка point към правоъгълника.
		/// В случая на правоъгълник този метод може да не бъде пренаписван, защото
		/// Реализацията съвпада с тази на абстрактния клас Shape, който проверява
		/// дали точката е в обхващащия правоъгълник на елемента (а той съвпада с
		/// елемента в този случай).
		/// </summary>
		public override bool Contains(PointF point)
		{
			float X = point.X;
			float Y = point.Y;
			double k = (Location.X + Width / 2);
            double h = (Location.Y + Height / 2);
			double r1=Width / 2;
			double r2=Height / 2;	

            if (  ((X - k)*(X - k)) / (r1*r1) + ((Y - h )* (Y - h)) / (r2*r2) <= 1)
            {
				return true;
            }
			

            return false;
		}

        
        /// <summary>
        /// Частта, визуализираща конкретния примитив.
        /// </summary>
        public override void DrawSelf(Graphics grfx)
		{
			base.DrawSelf(grfx);
			
			grfx.FillEllipse(new SolidBrush(FillColor),Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			grfx.DrawEllipse(new Pen(BorderColor, BorderSize), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			
		}
	}
}
