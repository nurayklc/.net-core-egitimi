
Console.WriteLine(Days.Monday); 
// Numeric karşılığına erişme
Console.WriteLine((int)Days.Sunday); 

int temperature = 32;

if(temperature <= (int)Weather.Normal){
    Console.WriteLine("Wait");
}
else if( temperature >= (int)Weather.Hot){
    Console.WriteLine("Very Hot");
}
else if( temperature >= (int)Weather.Normal){
    Console.WriteLine("Lets go outside");
}


enum Days {
    //Monday = 1, 
    Monday,
    Tuesday,
    Wednesday,
    Thursday, 
    Friday,
    Saturday,
    Sunday
}

enum Weather {
    Cold = 5,
    Normal = 24,
    Hot = 30,
    VeryHot = 35,
}