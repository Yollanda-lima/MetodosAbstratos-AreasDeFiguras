using MetodosAbstratos_AreasDeFiguras.Entities.Enums;

namespace MetodosAbstratos_AreasDeFiguras.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
