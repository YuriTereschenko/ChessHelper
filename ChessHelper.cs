/*Программа для определения наличия угрозы в шахматах по отношению к твоей фигуре */
bool status = true;
Console.Clear();
int xa, xb, ya, yb;

void MoveBishop(int x, int y)
{
     int xM = 1;
     int yM = 1;
     if (x>xb) xM=-1;
     if (y>yb) yM=-1;
     while (x<=8 & y<=8 & x >=1 & y>=1)
     {
          if (x == xb & y == yb)
          {
               Console.WriteLine("Фигура в опасности, миллорд");
               status =false;
               break; 
          }     
     x=x+xM;
     y=y+yM;
     }
}


void MoveRook(int x, int y)
{
     if (x == xb || y == yb) 
     {
          Console.WriteLine("Фигура в опасности, миллорд");
          status = false;
     }
                                                                   
}


void MoveKnight(int x, int y)
{
     int xM=1;
     int yM=1;
     if (x>xb) xM=-1;
     if (y>yb) yM=-1;
     if (x+(2*xM) == xb & y+yM == yb || x+xM == xb & y+(2*yM) == yb)
     {
          Console.WriteLine("Фигура в опасности, миллорд");
          status = false;
     }     
}


void MoveKing(int x, int y)
{
     if (x>xb) x--;
     if (x<xb) x++;
     if (y>yb) y--;
     if (y<yb) y++;
     if (x==xb & y==yb)
     {
          Console.WriteLine("Фигура в опасности, миллорд");
          status = false;
     }
}


void MoveQueen(int x, int y)
{
     int xM = 0;
     int yM = 0;
     if (x > xb) xM=-1;
     if (x < xb) xM=1;
     if (y > yb) yM=-1;
     if (y < yb) yM=1;
     while (x<=8 & y<=8 & x >=1 & y>=1)
     {
          if (x == xb & y == yb)
          {
               Console.WriteLine("Фигура в опасности, миллорд");
               status = false;
               break;
          }
          y +=yM;
          x +=xM;
     }
}


void MovePawn(int x, int y)
{
     Console.WriteLine("Какого цвета пешка соперника 1 - белая, 0 - черная");
     int ColorChoice = Convert.ToInt32(Console.ReadLine());
     if (ColorChoice == 1)     
          if ((x+1 == xb & y+1 == yb) || (x-1 == xb & y+1 == yb)) 
          {
               Console.WriteLine("Ваша фигура в опасности, миллорд");
               status = false;
          }   
     else if (ColorChoice == 2)
          if ((x+1 == xb & y-1 == yb) || (x-1 == xb & y-1 == yb)) 
          {
               Console.WriteLine("Ваша фигура в опасности, миллорд");
               status = false;
          }
}



Console.WriteLine("Привет, любитель шахмат! Данная программа подскажет, угрожает ли тебе в ближайший ход фигура оппонента");
int repeat = 1;
while (repeat == 1)
{
     Console.WriteLine("Угрозу от какой фигуры ты хочешь проверить? 1 - Конь, 2 - Слон, 3 - Ладья, 4 - Король, 5 - Королева, 6 - Пешка");
     int ChessPiece = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Введите х координату фигуры оппонента");
     xa= Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Введите y координату фигуры оппонента");
     ya= Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Введите х координату вашей фигуры");
     xb= Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Введите y координату вашей фигуры");
     yb= Convert.ToInt32(Console.ReadLine());

     switch (ChessPiece)
     {
          case 1:
               MoveKnight(xa,ya);
               break;
          case 2: 
               MoveBishop(xa,ya);
               break;
          case 3: 
               MoveRook(xa,ya);
               break;
          case 4:
               MoveKing(xa,ya);
               break;
          case 5:
               MoveQueen(xa,ya);
               break;
          case 6:
               MovePawn(xa,ya);
               break;
     }
     if (status == true) Console.WriteLine("В этот ход нечего опасаться, миллорд");
     status = true;
     Console.WriteLine("Нужно проверить еще 1 фигуру? 1 - да, 2 - нет");
     repeat = Convert.ToInt32(Console.ReadLine());
     Console.Clear();
}
