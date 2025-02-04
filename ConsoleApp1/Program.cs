using System.Reflection.Metadata;
using System.Threading;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Xml.Linq;
using System.Collections;


namespace ConsoleApp1
{
    internal class Program
    {


        static Human yourclass = new Human();
        static Item youritem = new Item(false, "아이템 이름", "능력치", "설명", 0, false);

        static List<Item> yourinventory = new List<Item>();
        static List<Item> itemShop = new List<Item>();



        public class Human
        {
            public int level;
            public int health;
            public string? className;
            public int power;
            public int defence;
            public int gold;
        }


        public class Item
        {
            public bool IsWearing { get; set; }
            public string Name { get; set; }
            public string State { get; set; }
            public string Description { get; set; }
            public int Price { get; set; }
            public bool IsSoldOut { get; set; }

            public Item(bool isWearing, string name, string state, string description, int price, bool isSoldOut)
            {
                IsWearing = isWearing;
                Name = name;
                State = state;
                Description = description;
                Price = price;
                IsSoldOut = isSoldOut;
            }

            public override string ToString() //클래스에 오버라이드 안하면 객체의 타입 정보만 출력된다.
            {
                return $"{IsWearing} {Name} {State} {Description} 가격: {Price} {IsSoldOut}";
            }
        }


        static void ItemShop()
        {
            itemShop.Add(new Item( false, "- 수련자 갑옷   |", "방어력 +5   |", "수련에 도움을 주는 갑옷입니다.          |", 1000, false));
            itemShop.Add(new Item( false, "- 무쇠 갑옷   |", "방어력 +9   |", "무쇠로 만들어져 튼튼한 갑옷입니다.          |", 2000, false));
            itemShop.Add(new Item( false, "- 스파르타의 갑옷   |", "방어력 +15   |", "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.          |", 3500, false));
        }

        static void YourInventory()
        {
            
        }

        //Add 리스트 값 받아오기....


        static void Main(string[] args)
        {
            Start();
        }


        static void Start()
        {
            string userName;
            string yourJob;

            ItemShop();

            //값을 먼저 하나의 변수에 설정하고 밑에서 그거 띄우는 편이 낫다

            Thread.Sleep(1000);
            Console.WriteLine("당신은 눈을 떴다.");
            Thread.Sleep(2500);
            Console.WriteLine("아주 긴 잠에서 깨어난 듯 하다.");
            Thread.Sleep(2500);
            Console.Write("당신의 성함을 입력해 주십시오: ");
            userName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"그래. 당신의 이름은 {userName}(이)다.");
            Thread.Sleep(2500);
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("당신은 이전부터 어떤 일을 해왔지?");
                Thread.Sleep(2000);
                Console.WriteLine();
                Console.WriteLine("1. 전사");
                Console.WriteLine("2. 마법사");
                Console.WriteLine("3. 도적");
                Console.WriteLine();
                Console.Write(">>");
                yourJob = Console.ReadLine();

                //if문 yourJob이 n일때 상태창은 n1

                if (yourJob == "1")
                {
                    yourclass.level = 1;
                    yourclass.className = "전사";
                    yourclass.power = 10;
                    yourclass.defence = 5;
                    yourclass.health = 100;
                    yourclass.gold = 5000;
                }

                else if (yourJob == "2")
                {
                    yourclass.level = 1;
                    yourclass.className = "마법사";
                    yourclass.power = 5;
                    yourclass.defence = 10;
                    yourclass.health = 100;
                    yourclass.gold = 5000;
                }

                else if (yourJob == "3")
                {
                    yourclass.level = 1;
                    yourclass.className = "도적";
                    yourclass.power = 7;
                    yourclass.defence = 8;
                    yourclass.health = 100;
                    yourclass.gold = 7500;
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("자신이 했을만한 직업은 저 세가지 이외엔 없다는 확신이 든다.");
                    continue;
                }
                break;
            }

            Console.WriteLine($"당신의 직업은 {yourclass.className}이다.");
            Thread.Sleep(2500);
            Console.WriteLine();
            Console.WriteLine("자신의 이름과 직업을 기억해내자 마치 전구 하나하나에 불이 들어오듯, 당신의 오감이 살아나기 시작한다.");
            Thread.Sleep(2500);
            Console.WriteLine("불현듯 당신은 가까운 곳에 작은 마을이 보인다는 것을 알아차렸다.");
            Thread.Sleep(2500);
            Console.WriteLine("무엇을 할까?");
            Thread.Sleep(2500);

            string whatDoYouDo1;

            while (true)
            {
                Console.Clear();
                Console.WriteLine(new string('=', 20));  //new string = char * int
                Console.WriteLine("1. 상태 보기");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점");
                Console.WriteLine(new string('=', 20));
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("원하시는 행동(숫자)을 입력해주세요.");
                Console.Write(">>");
                whatDoYouDo1 = Console.ReadLine();

                switch (whatDoYouDo1)
                {

                    case ("1"):

                        Console.Clear();
                        Console.WriteLine("캐릭터의 정보가 표시됩니다.");
                        Console.WriteLine();

                        Console.WriteLine($"Lv. {yourclass.level}");
                        Console.WriteLine($"{userName} ({yourclass.className})");
                        Console.WriteLine($"공격력: {yourclass.power}");
                        Console.WriteLine($"방어력: {yourclass.defence}");
                        Console.WriteLine($"체력: {yourclass.health}");
                        Console.WriteLine($"Gold: {yourclass.gold}");

                        Console.WriteLine();
                        Console.WriteLine("0. 나가기");
                        Console.WriteLine();
                        Console.WriteLine("원하시는 행동을 입력해주세요.");
                        Console.Write(">>");

                        string back;
                        back = Console.ReadLine();

                        if (back == "0")
                        {
                            Console.Clear();
                            break;
                        }

                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("당신은 선택지에 없는 다른 행동을 취하려했지만 몸이 생각대로 움직이지 않아 이내 그만두었다.");
                            Thread.Sleep(1500);
                            goto case ("1");
                        }


                    case ("2"):  //당신의 인벤토리

                        Inventory();
                        break;

                    case ("3"):  //상점

                        ItemStore();
                        break;

                    default:
                        Console.WriteLine("당신은 선택지에 없는 다른 행동을 취하려했지만 몸이 생각대로 움직이지 않아 이내 그만두었다.");
                        Thread.Sleep(1500);
                        break;
                }
            }
        }


        static void Inventory()
        {
            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            //아이템이 있을 시 팝업

            Console.WriteLine();
            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">>");

            string back2;
            back2 = Console.ReadLine();

            if (back2 == "0") //while문으로 나가야됨
            {
                Console.Clear();
                return;  //Inventory 메서드를 종료하고 호출했던 쪽으로 돌아간다!!
            }

            if (back2 == "1") //장착 관리
            {
                Console.WriteLine("인벤토리 - 장착 관리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                Console.WriteLine();
                Console.WriteLine("[아이템 목록]");

                yourinventory.Add(itemShop[0]);

                for (int i = 0; i < yourinventory.Count(); i++)
                {
                    Item item = yourinventory[i];
                    string equipStatus = item.IsWearing? "[E]" : "";
                }
            }
        }

        static void ItemStore()
        {
            Console.Clear ();
            Console.WriteLine("상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");

            Console.WriteLine("[보유 골드]");
            Console.WriteLine($"Gold: {yourclass.gold}");

            Console.WriteLine("[아이템 목록]");

            for (int i = 0; i < itemShop.Count; i++)
            {
                Console.WriteLine($"{itemShop[i]}");
            }

            Console.WriteLine("1.아이템 구매");
            Console.WriteLine("0.나가기");

            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">>");

            string buyItem;
            buyItem = Console.ReadLine();

            switch (buyItem)
            {

                //아이템을 산다는 행위를 어떻게 구현하지
                //아이템을 장착한다는 (이하 동문)

                case ("1"):

                    Console.WriteLine("상점 - 아이템 구매");
                    Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");

                    Console.WriteLine("[보유 골드]");
                    Console.WriteLine($"{yourclass.gold}");

                    Console.WriteLine("[아이템 목록]");

                        for (int i = 0; i < itemShop.Count; i++)
                        {
                            Console.WriteLine($"{itemShop[i]}");
                        }


                    Console.WriteLine("0.나가기");

                    Console.WriteLine("원하시는 행동을 입력해주세요.");
                    Console.Write(">>");

                    string back;
                    back = Console.ReadLine();

                    if (back == "0");
                    {
                        return;
                    }  
            }
        }
    }
}