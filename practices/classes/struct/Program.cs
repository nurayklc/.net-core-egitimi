// Class
Rectangle classRectangle = new Rectangle();
classRectangle.LongEdge = 8;
classRectangle.ShortEdge = 4; 
Console.WriteLine("Class Rectangle Area: {0}" , classRectangle.Area());

// Struct
//RectangleStruct structRectangle = new RectangleStruct();
// RectangleStruct structRectangle;
RectangleStruct structRectangle = new RectangleStruct(8,4);
Console.WriteLine("Struct Rectangle Area: {0}" , structRectangle.Area());


class Rectangle {
    public int LongEdge;
    public int ShortEdge;

    public Rectangle(){
        LongEdge = 4;
        ShortEdge = 3;
    }

    public long Area(){
        return this.LongEdge * this.ShortEdge;
    }
}

// Create struct
struct RectangleStruct
{
    public int LongEdge;
    public int ShortEdge;

    public RectangleStruct(int LongEdge, int ShortEdge){
        this.LongEdge = LongEdge;
        this.ShortEdge = ShortEdge;
        LongEdge = 4;
        ShortEdge = 3;
    }

    public long Area(){
        return this.LongEdge * this.ShortEdge;
    }
}