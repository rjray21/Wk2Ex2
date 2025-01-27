// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the length of the rectangle:");
//prompt length of rectangle
string lengthInput = Console.ReadLine();
//change length string into an integer
int lengthAmount = Convert.ToInt32(lengthInput);
Console.WriteLine("Enter the width of the rectangle:");
//prompt width of rectangle
string widthInput = Console.ReadLine();
//change width string into an integer 
int widthAmount = Convert.ToInt32(widthInput);
//setting area calculation
double resultOne = (lengthAmount * widthAmount);
//setting perimeter calculation
double resultTwo = (lengthAmount + lengthAmount + widthAmount + widthAmount);
//giving the answers
Console.WriteLine("Area of the rectangle is:" + resultOne);
Console.WriteLine("Perimeter of the rectangle is:" + resultTwo);




