using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab241225_Game
{
    internal class Program
    {
        static void game()
        {
            int score = 0;
        Start:
            Console.WriteLine("==========�׷��K�X �̲רM�w��==========");
            Random x = new Random();
            int anw = x.Next(1, 100);
            //���øѵ�
            //Console.WriteLine($"���׬�:{anw}");
            Console.WriteLine("�Ш̴��ܲq�Ʀr�A�q�W�L10���D�ԧY����");
            Console.WriteLine("�C���}�l�A�п�J1~100�������ƭ�");
            Console.WriteLine($"�z�����Ƭ�:{score}");
            Console.WriteLine("---------------------------------------");

            int times = 0;
            int maxnum = 100;
            int minnum = 1;

            int result;
            while (true)
            {
                Console.Write("�п�J�ƭȡG");
                string input = Console.ReadLine();

                if (int.TryParse(input, out result))
                {
                    int guest = result;
                    if (times >= 9)
                    {
                        x = new Random();
                        anw = x.Next(1, 100);
                        Console.WriteLine("�q�W�L10���A�D�ԥ��ѡA����-1");
                        score--;
                    AskAgain:
                        Console.WriteLine("�O�_�n�A���@��?( Y / N )");
                        string ask = Console.ReadLine().ToUpper();
                        if (ask == "Y")
                        {
                            Console.Clear();
                            goto Start;
                        }
                        else if (ask == "N")
                        {
                            Console.Clear();
                            Console.WriteLine("�P�±z���C��!");
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("�п�JY�άON!");
                            goto AskAgain;
                        }
                    }
                    else if (guest < minnum || guest > maxnum)
                    {
                        Console.WriteLine($"�W�X�d��A�п�J{minnum}~{maxnum}�������ƭ�");
                        times++;
                    }
                    else if (guest < anw)
                    {
                        minnum = guest;
                        Console.WriteLine($"�п�J����{guest}~{maxnum}�������ƭ�");
                        times++;
                    }
                    else if (guest > anw)
                    {
                        maxnum = guest;
                        Console.WriteLine($"�п�J����{minnum}~{guest}�������ƭ�");
                        times++;
                    }
                    else
                    {
                        times++;
                        Console.WriteLine($"���׬�{anw}�A���ߵ���!����+1�A �z�@�@�q�F{times}��");
                        score++;
                    AskAgain:
                        Console.WriteLine("�O�_�n�A���@��?( Y / N )");
                        string ask = Console.ReadLine().ToUpper();
                        if (ask == "Y")
                        {
                            Console.Clear();
                            goto Start;
                        }
                        else if (ask == "N")
                        {
                            Console.Clear();
                            Console.WriteLine("�P�±z���C��!");
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("�п�JY�άON!");
                            goto AskAgain;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("��J�F�L�ļƭȡI�п�J�@�Ӧ��Ī����");
                }
            }



        }
        static void Main(string[] args)
        {
            game();
        }
    }
}
