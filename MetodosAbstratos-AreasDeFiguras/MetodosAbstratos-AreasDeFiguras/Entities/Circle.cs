using MetodosAbstratos_AreasDeFiguras.Entities.Enums;

namespace MetodosAbstratos_AreasDeFiguras.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
           return Math.PI * Radius * Radius;
        }
    }
}
