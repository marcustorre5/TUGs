using System;
using calc;
using System.Threading;

namespace tugs
{
  public class Tugs
  {
    static void Main(string[] args)
    {
      while (true){

        tugs();

        Console.WriteLine("\nReiniciando..\n");
        Console.WriteLine("Ou aperte ctrl c para sair\n");
        //sleep
        Thread.Sleep(2000);
        
      }

    }

    public static void tugs()
    {
      Console.WriteLine("TUGs\n");
      
      Console.WriteLine("SELECIONE A COMODO QUE SERÁ DIMENSIONADO AS TOMADAS:\n[1] DORMITORIOS\n[2] SALA\n[3] COZINHA\n[4] ÁREA EXTERNAS E OUTROS\n");
      String quest = Console.ReadLine();

      if (quest == "1"){

        Console.WriteLine("DORMITORIOS");

        Calctugs calctomadas = new Calctugs();
        calctomadas.calctugs();

      }

      if (quest == "2"){

        Console.WriteLine("SALA");

        Calctugs calctomadas = new Calctugs();
        calctomadas.calctugs();

      }

      if (quest == "3"){

        Console.WriteLine("COZINHA");

        Calctugs calctomadas = new Calctugs();
        calctomadas.calcxtugs();

      }

      if (quest == "4"){

        Console.WriteLine("ÁREA EXTERNAS E OUTROS");

        Calctugs calctomadas = new Calctugs();
        calctomadas.calctugs();

      }

      if (quest != "1" && quest != "2" && quest != "3" && quest != "4"){

        Console.WriteLine("\nERRO! Digite uma opção válida!\n");

      }
    }
  }
  
}