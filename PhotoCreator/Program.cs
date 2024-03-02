using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace PhotoCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] pixels = CreatePixelArray();
            Console.WriteLine("here it is:");
            printArray(pixels);
            
        }

        public static int[,] CreatePixelArray(){
            int[,] pixels = new int[5,5];
            for(int i =0; i<5;i++)
            {
                for(int j =0; j<5;j++)
                {
                    int value = new Random().Next(0,8);
                    pixels[i,j] = value;
                }                
            }
            return pixels;
        }
        public static void printArray(int[,] array){
            for(int i=0; i<array.GetLength(0);i++){
                for(int j=0; j<array.GetLength(1);j++){
                    Console.Write(array[i,j]+", ");                    
                }
                Console.WriteLine();
            }
        }
    }
}
