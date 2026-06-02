using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection;
using System.Text;

namespace EpicTextQuest2D
{
    public class GameElements
    {
        public static void EventDie(ref int die)
        {
            die = Random.Shared.Next(1, 10);
        }
        public static void AttackDie(ref int die, int adv)
        {
            die = Random.Shared.Next(1, 20) + adv;
        }
        public static void BlockDie(ref double health, ref int enemydie, ref int die)
        {
            die = Random.Shared.Next(1, 4);
            enemydie = Random.Shared.Next(1, 20);
            health = (health * die - enemydie) / die;


        }
        public static void Block(ref double fhealth, ref int ame)
        {
            int dmgenemy = 0;
            int fblock = 0;
            BlockDie(ref fhealth, ref dmgenemy, ref fblock);
            if (fblock == 1)
            {
                if (dmgenemy == 1)
                {
                    Console.WriteLine($"Враг нанес тебе 1 единицу урона, но даже пробило твою защиту. Слабак.");
                }
                else if ((dmgenemy > 1) && (dmgenemy < 5))
                {
                    Console.WriteLine(@$"Враг нанес тебе {dmgenemy} единицы урона, и этого хватило, чтобы пробить твой блок. 
Ты вообще пытался?");
                }
                else if (dmgenemy >= 5)
                {
                    Console.WriteLine(@$"Враг нанес тебе {dmgenemy} единиц урона, и это оказалось достаточно сокрушительно, чтобы пробить твой блок насквозь. 
А ты точно хочешь выйти живым?");
                }
            }
            else
            {
                if (dmgenemy == 1)
                {
                    Console.WriteLine($"Враг нанес тебе 1 единицу урона, но ты этого даже не почуствовал.");
                }
                else if ((dmgenemy > 1) && (dmgenemy < 5))
                {
                    Console.WriteLine($"Враг нанес тебе {dmgenemy} единицы урона, но ты почусвовал всего часть его удара.");
                }
                else if (dmgenemy >= 5)
                {
                    Console.WriteLine($"Враг нанес тебе {dmgenemy} единиц урона, но ты почусвовал всего часть его удара.");
                }
            }
            ame -= 1;
            Console.WriteLine("Нажмите для продолжения");
            Console.ReadKey();
        }
        public static void Attack(int prog, int adv, ref double ehealth, ref double fhealth, ref int estamina, ref int fstamina, ref int ame, ref int amf, int turn)
        {
            int dmgfelix = 0;
            int dmgenemy = 0;
            GameElements.AttackDie(ref dmgfelix, adv);
            if ((prog < 17) && (prog > 10))
            {
                dmgenemy = 21;
            }
            else
            {
                GameElements.AttackDie(ref dmgenemy, 0);
            }
            if (dmgfelix > dmgenemy)
            {
                if ((dmgfelix > 1) && (dmgfelix < 5))
                {
                    Console.WriteLine($"Успешно! Ты нанес противнику {dmgfelix} единицы урона!\nТы чувствуешь себя менее напряженным.");
                }
                else if ((dmgfelix >= 5) && (dmgfelix <= 10))
                {
                    Console.WriteLine($"Успешно! Ты нанес противнику {dmgfelix} единиц урона!\nТы чувствуешь как часть сил вернулась к тебе.");
                }
                else if ((dmgfelix > 10) && (dmgfelix <= 19))
                {
                    Console.WriteLine($"Успешно! Ты нанес противнику {dmgfelix} единиц урона!\nТвоя кровь начинает бегать по телу гораздо активнее,\nбудто заранее подготавливая твое тело к атаке гораздо сильнее этой.");
                }
                else
                {
                    Console.WriteLine($"Успешно! Ты нанес противнику зубодробительные {dmgfelix} единиц урона!!\nТы ощущаешь великий прилив сил.\nМожет ты способен нанести разрушительную атаку?");
                }
                ehealth -= dmgfelix;
                fstamina += dmgfelix;
            }
            else if (dmgfelix < dmgenemy)
            {
                if ((dmgenemy > 1) && (dmgenemy < 5))
                {
                    Console.WriteLine($"Ух... Твоя атака не смогла сравниться с легким шлепком от противника.\nУ него получилось нанести {dmgenemy} единицы урона.\nНа его лице появилась легкая гримаса улыбки.");
                }
                else if ((dmgenemy >= 5) && (dmgenemy <= 10))
                {
                    Console.WriteLine($"Ой... Противник успел увидеть твою атаку и, увернувшись, нанес ответный удар.\nУ него получилось нанести {dmgenemy} единиц урона.\nЕго кулак покрылся твоей кровью и ты видишь как он довольствуется собой.");
                }
                else if ((dmgenemy > 10) && (dmgenemy <= 19))
                {
                    Console.WriteLine($"Ай-ай-ай... Твоя атака не смогла превзойти мощь противника.\nУ него получилось нанести {dmgenemy} единиц урона.\nТвоя кровь хлестнула на пол, а спокойное выражение лица противника пропало, оно сменилось маниакальной улыбкой.\nТы думаешь что с этой битвой надо покончить как можно быстрее, пока все силы не покинули тебя.");
                }
                else
                {
                    Console.WriteLine("ХРУСТ......");
                    Console.ReadKey();
                    Console.WriteLine($"В твоих глазах потемнело на пару секунд, но противник не решил этим воспользоваться.\nОн нанес уничтожающие {dmgenemy} единиц урона!!!\nТы удивлен как ты все еще стоишь на ногах, но не решаешь тратить время на раздумия.\n«Сначала надо покончить с битвой и только потом заботиться о переломах» подумал ты про себя");
                }
                if ((prog > 10) && (prog < 17))
                {
                    if (turn == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("«Значит ты встал до объединения.»");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (turn == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("«Меня много чего в тебе заинтересовало, твоя Арете, твой... Взгляд на мир.»");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (turn == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("«Я просто верну тебя в колею, где ты зацветёшь так, как тебе бы стоило.»");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (turn == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("'Ты бесхребетный, Феликс. Ты забудешь всё, но тот, кто спит в тебе - нет.'");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (turn == 5)
                    {
                        Console.Clear();
                        Console.WriteLine(@"'Я посажу цветок этой мысли в тебя, мы увидимся снова, обещаю, и надеюсь тогда ты дашь мне Своё имя.'");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                
                    fhealth -= dmgenemy;
                estamina += dmgenemy;
            }
            else
            {
                if (prog == 129)
                {
                    Console.WriteLine($"'КЛАЦ! Наши мечи сцепились, моё белоснежное перо с твоим... Куском металла.\n{dmgfelix}. Никто не попал, но мы оба почувствовали собственные удары, и удары друг друга.'");
                    estamina -= dmgenemy / 2;
                    fstamina -= dmgfelix / 2;
                }
                else 
                {
                    Console.WriteLine($"'КЛАЦ! Наши мечи сцепились.\n{dmgfelix}. Никто не попал, но мы оба почувствовали собственные удары, и удары друг друга.'");
                    estamina -= dmgenemy / 2;
                    fstamina -= dmgfelix / 2;
                }
            }
            Console.ReadKey();
            Console.Clear();
            ame -= 1;
            amf -= 1;
        }
        public static void TurnEnd(ref double fhealth, int maxfhealth)
        {
            double HPOverflow;
            if (fhealth > maxfhealth)
            {
                HPOverflow = fhealth - maxfhealth;

                fhealth -= (int)HPOverflow / 2;
                //В случае если пытается разделить 1 на 2, то будет сохраняться 1 лишнее хп, поэтому вычитается 1 лишнее хп
                if (HPOverflow == 1)
                {
                    fhealth -= 1;
                }
            }
            Console.Clear();
        }
        
        public static void FakeLoad(int prog)
        {
            
            Console.WriteLine("З..");
            System.Threading.Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine("За..");
            System.Threading.Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine("Заг...");
            System.Threading.Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine("Загр...");
            System.Threading.Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine("Загру...");
            System.Threading.Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine("Загруз...");
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("Загруз....");
            System.Threading.Thread.Sleep(400);
            Console.Clear();
            Console.WriteLine("Загруз.....");
            System.Threading.Thread.Sleep(400);
            Console.Clear();
            Console.WriteLine("Загруз......");
            System.Threading.Thread.Sleep(400);
            Console.Clear();
            Console.WriteLine("Загруз.......");
            System.Threading.Thread.Sleep(400);
            Console.Clear();
            Console.WriteLine("Загруз........");
            System.Threading.Thread.Sleep(400);
            Console.Clear();
            Console.WriteLine("Загруз.........");
            System.Threading.Thread.Sleep(400);
            Console.Clear();
            if (prog < 18)
            {
                Console.WriteLine("^$г!у?.#.@*.!...?$%@./(");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                var glitchy = new RandomLetter();
                string glitch = "";
                for (int i = 0; i < 20; i++)
                {
                    glitchy.RandomString(10000, ref glitch);
                    Console.WriteLine(glitch);
                    System.Threading.Thread.Sleep(50);
                    Console.Clear();
                }
            }
            else if (prog == 18)
            {
                Console.WriteLine("Загрузк...");
                System.Threading.Thread.Sleep(400);
                Console.Clear();
                Console.WriteLine("'Спокойной ночи.'");
                System.Threading.Thread.Sleep(2067);
                Console.Clear();
                Console.WriteLine("Загруз.........");
                System.Threading.Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("Загруз........");
                System.Threading.Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("Загруз.......");
                System.Threading.Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("Загруз......");
                System.Threading.Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("Загруз.....");
                System.Threading.Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("Загруз....");
                System.Threading.Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("Загруз...");
                System.Threading.Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("Загру...");
                System.Threading.Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("Загр...");
                System.Threading.Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("Заг...");
                System.Threading.Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("За..");
                System.Threading.Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("З..");
                System.Threading.Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("З.");
                System.Threading.Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine(".");
                System.Threading.Thread.Sleep(200);
                Console.Clear();
            }
           
        }
        public static void CDeath()
        {
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t###>");
            System.Threading.Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t#########>");
            System.Threading.Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t###############>");
            System.Threading.Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t###############################>");
            System.Threading.Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t######################>");
            System.Threading.Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t################>");
            System.Threading.Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t##########>");
            System.Threading.Thread.Sleep(200);
            Console.Clear();
        }

    }
}

//я вернул количество атак противника, почему бы не применить это в геймплее? ну напрмиер чтобы противник мог просто так атаковать в конце хода и наоборот. 
//добавь количество ходов