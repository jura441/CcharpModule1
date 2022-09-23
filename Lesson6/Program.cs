// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



ManyFigure mf = new ManyFigure(3);
mf.DrawFigureSide();
abstract class GeometryFigure
{
    protected int FigureSquare;
    protected int FigurePerimetr;
}
    class Triangle : GeometryFigure
    {
        public int Base { get; set; }
        public int BaseSideAngel { get; set; }
        public int SideLength { get; set; }
        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
        public int Perimetr { get { return FigurePerimetr; } set { FigurePerimetr = value; } }
    }
    class Quadro: GeometryFigure
    {
        public int Base { get; set; }
        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
        public int Perimetr { get { return FigurePerimetr; } set { FigurePerimetr = value; } }
    }
    class Romb: GeometryFigure
    {
        public int Base { get; set; }
        public int BaseSideAngel { get; set; }
        public int SideLength { get; set; }
        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
        public int Perimetr { get { return FigurePerimetr; } set { FigurePerimetr = value; } }
    }
    class Rectangle: GeometryFigure
    {
        public int Height { get; set; }
        public int Base { get; set; }
        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
        public int Perimetr { get { return FigurePerimetr; } set { FigurePerimetr = value; } }
    }
    class ParalleloGram: GeometryFigure
    {
        public int Height { get; set; }
        public int Base { get; set; }
        public int BaseSideAngel { get; set; }
       public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
        public int Perimetr { get { return FigurePerimetr; } set { FigurePerimetr = value; } }
    }
    class Trapecia: GeometryFigure
    {
        public int Height { get; set; }
        public int Base { get; set; }
        public int BaseSideAngel { get; set; }
        public int SideLength { get; set; }
        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
        public int Perimetr { get { return FigurePerimetr; } set { FigurePerimetr = value; } }
    }
    class Circle: GeometryFigure
    {
        public int Radius { get; set; }
         public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
        public int Perimetr { get { return FigurePerimetr; } set { FigurePerimetr = value; } }
    }
    class Ellipse: GeometryFigure
    {
        public int Height { get; set; }
        public int Base { get; set; }
      
        public int Area { get { return FigureSquare; } set { FigureSquare = value; } }
        public int Perimetr { get { return FigurePerimetr; } set { FigurePerimetr = value; } }
    }
    interface ISimpleNAngel
    {
        int Height { get; set; }
        int Base { get; set; }
        int BaseSideAngel { get; set; }
        int NumberSide { get; set; }
        int SideLeight { get; set; }
        int Area { get; set; }
        int Perimetr { get; set; }


    }
    class ManyFigure: ISimpleNAngel
    {
        char[] drawChars = new char[11] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
        public int Height { get; set; }
        public int Base { get; set; }
        public int BaseSideAngel { get; set; }
        public int NumberSide { get; set; }
        public int SideLeight { get; set; }
        public int Area { get; set; }
        public int Perimetr { get; set; }

        public ManyFigure(int numberSide)

        {
            NumberSide = numberSide;
        BaseSideAngel = 360 / NumberSide;
        }
        public void DrawFigureSide()
        {
            for (int i = 1; i <= drawChars.Length; i+= 2)
            {
                int temp = (int)Math.Floor((double)(drawChars.Length / 2) - (int)Math.Floor((double)i / 2));
                for (int j = 0; j < i; j++)
                {
                    drawChars[temp + j] = '*';
                }
                    Console.WriteLine(drawChars);
            }
        }
         double FindArea()
        {
            return Area;
        }
    }

