﻿using System;
using DPWorkout.Creational.Factory;
using DPWorkout.Creational.AbstractFactory;
using DPWorkout.Creational.Singleton;
using DPWorkout.Creational.Prototype;
using DPWorkout.Creational.Builder;
using DPWorkout.Creational.Structural;

namespace DPWorkout
{
    public class Program
    {
        private static IPatternClient patternClient;

        static void Main(string[] args)
        {
            #region Creational Pattern Clients
            //patternClient = new AbstractFactoryClient();
            //patternClient = new FactoryClient();
            //patternClient = new SingletonClient();
            //patternClient = new PrototypeClient();
            //patternClient = new BuilderClient();
            #endregion

            #region Structural Pattern Clients
            patternClient = new AdapterClient();
            patternClient.Run();
            #endregion

            Console.ReadLine();
        }
    }
}
