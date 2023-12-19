using System;

namespace Bankomatas
{
    public class Program // pasidaryti githubo accounta ir ideti bankomata
    {
        static int pasirinktaKalba = 1;

        static decimal saskaitosLikutis = 1000;

        static string teisingasPin = "1234";


        //israsas galetu buti objektas

        // yra klausimu


        #region Texts
        //METODE KalbosPasirinkimas();
        static List<string> PasirinKalba = new List<string>
            {
                "Pasirinkite kalbą",
                "Choose language",
                "Выберите язык:"
            };

        //METODE BankomatoBody()
        static List<string> IvestiPin = new List<string>
            {
               "Prašome įvesti PIN kodą:",
               "Please enter your PIN",
               "Пожалуйста, введите свой PIN-код"
            };

        static List<string> Uzblokuota = new List<string>
            {
               "Kortelė užblokuota. Kreipkitės į banką.",
               "The card is blocked. Contact the bank.",
               "Карта заблокирована. Свяжитесь с банком."
            };

        static List<string> NeteisingasPin = new List<string>
            {
               "Neteisingas PIN kodas. Likę bandymai:",
               "Invalid PIN code. Remaining attempts:",
               "Неверный PIN-код. Оставшиеся испытания:"
            };

        //METODE KeistiPin
        static List<string> ArTikraiPin = new List<string>
            {
            "Ar tikrai norite keisti PIN? 1 - taip, 0 - ne",
            "Are you sure you want to change the PIN? 1 - yes, 0 - no ",
            "Вы уверены, что хотите изменить свой PIN-код? 1 – да, 0 – нет"
            };

        static List<string> NekeistiPin = new List<string>
            {
            "Nusprendėte nekeisti PIN",
            "You decided not to change the PIN",
            "Вы решили не менять свой PIN-код."
            };


        static List<string> NeteisingasPasi = new List<string>
            {
            "Neteisingas pasirinkimas",
            "Incorrect choice",
            "Неправильный выбор"
            };

        static List<string> IveskNaujaPin = new List<string>
            {
            "Iveskite nauja PIN",
            "Please enter new PIN",
            "Пожалуйста, введите новый PIN-код"
            };

        static List<string> IveskNaujaPin2 = new List<string>
            {
            "Iveskite nauja PIN antra karta",
            "Please enter new PIN once again",
            "Пожалуйста, введите новый PIN-код еще раз"
            };

        static List<string> PinPakeistas = new List<string>
            {
            "PIN pakeistas sekmingai!",
            "PIN was changed successfully!",
            "PIN-код успешно изменен!"
            };

        static List<string> KeistKalba = new List<string>
            {
                "1.Keisti kalbą",
                "1.Change language",
                "1.Изменить язык"
            };
        static List<string> KeistPin = new List<string>
            {
                "2.Keisti PIN kodą",
                "2.Change PIN",
                "2.Изменить PIN-код"
            };
        static List<string> SasLik = new List<string>
            {
                "3.Sąskaitos likutis",
                "3.Account balance",
                "3.Баланс счета"
            };
        static List<string> SasIsr = new List<string>
            {
                "4.Sąskaitos išrašas",
                "4.Account statement",
                "4.Выписка со счета"
            };
        static List<string> InPini = new List<string>
            {
                "5.Įnešti pinigus",
                "5.Deposit money",
                "5.Внести деньги"
            };
        static List<string> PasPini = new List<string>
            {
                "6.Pasiimti pinigus",
                "6.Withdraw money",
                "6.Снять деньги"
            };
        static List<string> Baigt = new List<string>
            {
                "7.Baigti darbą",
                "7.Exit",
                "7.Выход"
            };

        static List<string> Aciu = new List<string>
            {
                "Aciu, kad naudojates musu paslaugomis",
                "Thank you for using our service",
                "Спасибо за использование нашего сервиса"
            };

        static List<string> ArTest = new List<string>
            {
                "Ar norite testi? 1 - taip; 0 - ne.",
                "Do you want to continue? 1 - yes; 0 - no.",
                "Хотите протестировать? 1 – да; 0 – нет."
            };

        static List<string> NeteisingasNaujasPin = new List<string>
            {
                "Neteisingas naujas PIN.",
                "Invalid new PIN.",
                "Неверный новый PIN-код."
            };

        #endregion


        static void Main()
        {


            /* PVZ
            atm.DepositMoney(500);
            atm.WithdrawFunds(200);
            atm.PrintBankStatement();*/


            /*Transakcija Inesimas = new Transakcija(10, DateTime.Now, "EUR", "Pavedimas");
            Transakcija Nusiemimas = new Transakcija(100, DateTime.Now, "EUR", "Nusiemimas");
            Israsas.Add(Nusiemimas);*/


            KalbosPasirinkimas();
            Thread.Sleep(3000);
            BankomatoBody();
            Console.ReadLine();
        }






        // Bankomatas

        static void BankomatoBody()
        {
            Console.Clear();

            Console.WriteLine(IvestiPin[pasirinktaKalba]);

            int bandymas = 0;
            bool arBlokuota = false;

            while (bandymas < 3)
            {
                string IvestasPin = Console.ReadLine();

                if (IvestasPin == teisingasPin)
                {
                    Meniu();
                    break;
                }
                else
                {
                    bandymas++;

                    if (bandymas == 3)
                    {
                        arBlokuota = true;
                        Console.WriteLine(Uzblokuota[pasirinktaKalba]);
                        break;
                    }

                    Console.Clear();
                    Console.WriteLine(NeteisingasPin[pasirinktaKalba] + (3 - bandymas));
                }
            }

            if (!arBlokuota)
            {
                Console.WriteLine(Aciu[pasirinktaKalba]);
            }
        }


        static void KalbosPasirinkimas()
        {
            Console.WriteLine("Pasirinkite kalbą / Choose language / Выберите язык:");
            Console.WriteLine("1. LT");
            Console.WriteLine("2. EN");
            Console.WriteLine("3. RUS");

            bool ArTeisingasPasirinkimas = int.TryParse(Console.ReadLine(), out pasirinktaKalba);

            if (ArTeisingasPasirinkimas)
            {
                switch (pasirinktaKalba)
                {
                    case 1:
                        Console.WriteLine("Sveiki atvykę!");
                        break;
                    case 2:
                        Console.WriteLine("Welcome!");
                        break;
                    case 3:
                        Console.WriteLine("Добро пожаловать!");
                        break;
                    default:
                        Console.WriteLine("Pasirinkimas neteisingas.");
                        break;
                }
                pasirinktaKalba = pasirinktaKalba - 1;
            }
            else
            {
                Console.WriteLine("Neteisingas pasirinkimas.");
            }
        }


        static void Meniu()
        {
            Console.WriteLine("\nMeniu:");
            Console.WriteLine(KeistKalba[pasirinktaKalba]);
            Console.WriteLine(KeistPin[pasirinktaKalba]);
            Console.WriteLine(SasLik[pasirinktaKalba]);
            Console.WriteLine(SasIsr[pasirinktaKalba]);
            Console.WriteLine(InPini[pasirinktaKalba]);
            Console.WriteLine(PasPini[pasirinktaKalba]);
            Console.WriteLine(Baigt[pasirinktaKalba]);
            //Console.WriteLine($"1.{KeistiKalba[pasirinktaKalba]}");

            int pasirinktasMeniu = Convert.ToInt16(Console.ReadLine());

            switch (pasirinktasMeniu)
            {
                case 1:
                    KeistiKalba();
                    break;
                case 2:
                    KeistiPin();
                    break;
                case 3:
                    SaskaitosLikutis();
                    break;
                case 4:
                    Israsas.SkaitytiIsrasa();
                    ArTesti();
                    break;
                case 5:
                    InestiPinigu();
                    break;
                case 6:
                    PasiimtiPinigu();
                    break;
                case 7:
                    Baigti();
                    break;
                default:
                    Meniu();
                    break;
            }

        }


        static void ArTesti()
        {
            Console.WriteLine(ArTest[pasirinktaKalba]);
            int arTesti = Convert.ToInt16(Console.ReadLine());

            if (arTesti == 1)
            {
                Meniu();
            }
            else
            {
                Environment.Exit(0);
            }
        }


        static void KeistiKalba()
        {
            Console.WriteLine(PasirinKalba[pasirinktaKalba]);
            Console.WriteLine("1. LT");
            Console.WriteLine("2. EN");
            Console.WriteLine("3. RUS");

            bool ArTeisingasPasirinkimas = int.TryParse(Console.ReadLine(), out pasirinktaKalba);

            if (ArTeisingasPasirinkimas)
            {
                switch (pasirinktaKalba)
                {
                    case 1:
                        Console.WriteLine("Sveiki atvykę!");
                        break;
                    case 2:
                        Console.WriteLine("Welcome!");
                        break;
                    case 3:
                        Console.WriteLine("Добро пожаловать!");
                        break;
                    default:
                        Console.WriteLine("Pasirinkimas neteisingas.");
                        break;
                }
                pasirinktaKalba = pasirinktaKalba - 1;
            }
            else
            {
                Console.WriteLine("Neteisingas pasirinkimas / Wrong choice / Неправильный выбор");
            }
            Thread.Sleep(2000);

            Meniu();
        }


        static void KeistiPin()
        {
            Console.WriteLine(ArTikraiPin[pasirinktaKalba]);
            int ArTaip = Convert.ToInt16(Console.ReadLine());

            if (ArTaip == 1)
            {
                Console.WriteLine(IveskNaujaPin[pasirinktaKalba]);
                teisingasPin = Console.ReadLine();

                Console.WriteLine(IveskNaujaPin2[pasirinktaKalba]);
                string teisingasPin2 = Console.ReadLine();

                if (teisingasPin == teisingasPin2)
                {
                    Console.WriteLine(PinPakeistas[pasirinktaKalba]);

                    ArTesti();
                }
                else
                {
                    Console.WriteLine(NeteisingasNaujasPin[pasirinktaKalba]);

                    ArTesti();
                }

            }
            else if (ArTaip == 0)
            {
                Console.WriteLine(NekeistiPin[pasirinktaKalba]);
                Thread.Sleep(2000);

                Meniu();
            }
            else
            {
                Console.WriteLine(NeteisingasPasi[pasirinktaKalba]);
                KeistiPin();
            }

        }

        static void SaskaitosLikutis()
        {
            Console.WriteLine($"Jusu saskaitos likutis yra {saskaitosLikutis} EUR");

            ArTesti();
        }


        static void PasiimtiPinigu() // padaryti pagal InestiPinigu
        {
            Console.WriteLine("Iveskite norima nusiimti pinigu suma:");
            decimal piniguSuma = Convert.ToDecimal(Console.ReadLine());

            if (piniguSuma > saskaitosLikutis)
            {
                Console.WriteLine("Nepakankamas likutis");//parasyti lista
            }

            saskaitosLikutis = saskaitosLikutis - piniguSuma;

            Israsas.PridetiNaujaTransakcija(-piniguSuma, DateTime.Now, "EUR", "Nusiemimas");

            Console.WriteLine($"Nusiimta: {piniguSuma} EUR. Saskaitos likutis po operacijos: {saskaitosLikutis} EUR");

            ArTesti();
        }

        static void InestiPinigu()
        {
            Console.WriteLine("Kiek norite inesti pinigu?");
            decimal piniguSuma = Convert.ToDecimal(Console.ReadLine());

            Israsas.PridetiNaujaTransakcija(piniguSuma, DateTime.Now, "EUR", "Inesimas");

            saskaitosLikutis = saskaitosLikutis + piniguSuma;

            Console.WriteLine($"Inesta: {piniguSuma} EUR. Saskaitos likutis po operacijos: {saskaitosLikutis} EUR");

            ArTesti();

        }


        static void Baigti()
        {
            Console.WriteLine(Aciu[pasirinktaKalba]);
            Thread.Sleep(2000);

            Environment.Exit(0);
        }

    }
}