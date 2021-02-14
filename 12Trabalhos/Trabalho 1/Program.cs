using System;

namespace Trabalho_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que produza a seguinte resultado no Console:
            //*
            //**
            //***
            //****
            //***
            //**
            //* 

            for (int i = 0; i <= 4; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            for(int i = 0; i <= 3; i++)
            {
                for(int j = 3 ; j > i;j --)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
