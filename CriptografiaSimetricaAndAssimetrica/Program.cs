﻿using System;

namespace CriptografiaSimetricaAndAssimetrica
{
    class Program
    {
        static void Main(string[] args)
        {
            Simetrica sim = new Simetrica();
            
            Console.WriteLine("============================================");
            Console.WriteLine("===============SIMÉTRICAS===============");
            Console.WriteLine("============================================");
            Console.WriteLine("AES");
            sim.EncryptAesManaged("Fabrício");
            Console.WriteLine("============================================");

            Console.WriteLine("Rijndael");
            string dadoCriptado = sim.EncryptData("Fabrício", "UFN2021ATOS");
            Console.WriteLine(dadoCriptado);
            string dadoResgatado = sim.DecryptData(dadoCriptado, "UFN2021ATOS");
            Console.WriteLine(dadoResgatado);
            Console.WriteLine("============================================");

            Console.WriteLine("");

            Console.WriteLine("============================================");
            Console.WriteLine("===============ASSIMÉTRICAS===================");
            Console.WriteLine("============================================");

        }
    }
}
