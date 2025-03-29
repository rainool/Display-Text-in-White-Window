using SplashKitSDK;
using static SplashKitSDK.SplashKit;

string userInput;
const string fontPath = @"C:\Users\rainool\anaconda3\Lib\site-packages\panel\dist\bundled\reveal.js@4.5.0\dist\theme\fonts\league-gothic\league-gothic.ttf";

//Ask for text
WriteLine("Enter your text:");
userInput = ReadLine();

//Create a window to display user input
OpenWindow("Programming Experiement rainool",800,600);
ClearScreen(ColorWhite());

Font font1 = LoadFont("LeagueGothic", fontPath);

//Calculate dimensions of text
int textWidth = TextWidth(userInput, font1, 24);
int textHeight = TextHeight(userInput, font1, 24);

//Calculate the centre position for any given size text
int x = (800 - textWidth) / 2;
int y = (600 - textHeight) / 2;

//Write text into window
DrawText(userInput, ColorBlack(), x, y);

RefreshScreen();
Delay(20*1000);

