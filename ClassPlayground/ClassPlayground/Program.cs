using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2024-2025.
 * Extended by students.
 */

/*
 * TODO:
 *2) Vytvoř třídu BankAccount, kterou budeme reprezentovat bankovní účet
 *    Přidej třídě BankAccount čtyři proměnné - accountNumber jako číslo účtu
 *                                            - holderName jako jméno osoby, které účet patří
 *                                            - currency jako měna, ve které je účet vedený
 *                                            - balance jako zůstatek na účtu
 *    Přidej třídě BankAccount čtyři funkce - Deposit, která jako vstupní parametr přijme množství peněz a vloží je na účet
 *                                          - Withdraw, která jako vstupní parametr přijme množství peněz a z účtu "vybere" peníze, tedy sníží zůstatek a navrátí požadované množství
 *                                                      Pokud na účtu není dostatek peněz, uživatele upozorní a vrátí nulu.
 *                                          - Transfer, která jako vstupní parametry přijme množství peněz, účet ze kterého půjdou peníze, a účet na který peníze přijdou
 *                                                      Opět kontroluj, jestli je na účtu, ze kterého převod jde, dostatek peněz
 *                                                      (Můžeš do funkce přidat i to, že uživateli vypíše obě čísla účtu a uživatel musí třeba mezerníkem potvrdit, že jsou čísla účtu správná.)
 *    Přidej třídě BankAccount konstruktor, který bude přijímat dva parametry - jméno majitele účtu a měnu, ve které bude účet vedený
 *                                                                            - Při jeho zavolání nastav jméno a měnu podle vstupních parametrů, accountNumber nastav jako náhodně
 *                                                                              vygenerované číslo velké alespoň 100 000 000 a menší, než 10 000 000 000 a balance nastav na nulu
 * 3) Vytvoř třídu Student, kterou budeme reprezentovat studenta
 *    Přidej třídě Student proměnné - year pro aktuální ročník studenta
 *                                  - id pro identifikační číslo studenta
 *                                  - subjects pro seznam předmětů studenta (bude to slovník (https://www.geeksforgeeks.org/c-sharp-dictionary-with-examples/),
 *                                    který bude mít jako klíč string a jako hodnotu List (https://www.geeksforgeeks.org/c-sharp-list-class/) známek)
 *                                  - name pro jméno studenta
 *    Přidej třídě Student čtyři funkce - AddSubject, která jako vstupní parametr přijme název předmětu a přidá nový klíč do subjects
 *                                      - AddGrade, která jako vstupní parametr přijme název předmětu a známku a přidá podle názvu předmětu další známku danému předmětu
 *                                      - CalculateSubjectGrade, která jako stupní parametr přijme název předmětu a spočítá průměrnou známku na vysvědčení z daného předmětu
 *                                      - CaculateTotalGrade, která spočítá studijní průměr (průměr všech známek)
 *    Přidej třídě Student konstruktor, který bude přijímat dva parametry - jméno a ročník studenta
 *                                                                        - Při jeho zavolání nastav jméno a ročník podle vstupních parametrů, id vygeneruj podobně jako accountNumber
 *                                                                          ve tříde BankAccount, a subjects nastav na nový prázdný List
 * 
 * 3) BONUS - Až vytvoříš Student, přidej možnost mít u známek váhy. Způsob nechám na tobě, možností je víc. Můžeš celou třídu překopat na známky pouze s váhou, a nebo můžeš zachovat
 *            možnost přidávat známky bez váhy s tím, že ty budou mít nějakou výchozí váhu automaticky, a přidáš varianty funkcí na přidávání známek s váhou
 * 
 * V mainu využívej tebou naprogramované třídy a funkce, vypisuj výsledky do konzole, hraj si s tím a sleduj, co se kdy děje a co kdy jaká třída dělá.
 * Když si s něčím nebudeš vědět rady, zvedni ruku nebo na mě zavolej, já přijdu a poradím :)
 * Uděláš, co stihneš. Budeme na tom pracovat i nadále, takže se nestresuj časem a v klidu si všechno postupně rozmýšlej a piš takovým tempem, jaké je ti příjemné.
 */

namespace ClassPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Rectangle rectangle = new Rectangle(10, 5);
            Shape2D shape = new Rectangle(2,3);
            Console.WriteLine("reactangle area:" + rectangle.CalculateArea());
            Console.WriteLine("shape area:" + shape.CalculateArea());

            Circle circle = new Circle(5);
            Console.WriteLine("Area kruhu: " +circle.CalculateArea());
            Console.WriteLine("Aspect ratio: "+circle.CalculateAspectRatio());
            Console.WriteLine("Is this point in the circle?: "+circle.ContainsPoint(5,5));*/
            
            Console.WriteLine("Obdélníku");
            Console.WriteLine("Zdravím dobrodruhu prosím zadej výšku tvého obdélníku");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("tak a teď zadej šířku");
            double width = Convert.ToDouble(Console.ReadLine());
            Rectangle reactangle = new Rectangle(height, width);
            Console.WriteLine("Tak a teď mi napiš souřadnice bodu, který budeme kontrolovat. X:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a teď ještě výšku:");
            int y = Convert.ToInt32(Console.ReadLine());
            reactangle.WriteData(reactangle.ContainsPoint(x,y), reactangle.CalculateArea(), reactangle.CalculateAspectRatio());
            Console.WriteLine("Bank Account");
            Console.WriteLine("Vážený zákazníku, naše servery jsou na píču a tak si nepamatujeme vaše jméno prosím pomoz nám opravit tento nedostatek:");
            string name = Console.ReadLine();
            Console.WriteLine("a v jaké měně byl váš účet? (V zájumu zachování duševního zdraví našeho it oddělení pište všechno správně (EUR/USD/CZK/RMB)");
            string currency = Console.ReadLine();
            Bank_account account1 = new Bank_account(name,currency);
            account1.WriteData();
            Console.WriteLine("Kolik chcete na účet vložit");
            int amount = Convert.ToInt32(Console.ReadLine());
            account1.Deposit(amount);
            Console.WriteLine("A kolikpak si chcete vybrat?");
            int amount2 = Convert.ToInt32(Console.ReadLine());
            account1.Withdraw(amount2);
            Console.WriteLine("Převod: jaké číslo účtu má ten magický nigerijský princ: ");
            int accountNumber2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A kolik pak mu pošleme?");
            int amount3 = Convert.ToInt32(Console.ReadLine());
            Bank_account scammer = new Bank_account("Nigerisjký princ",currency);
            account1.Transfer(accountNumber2,amount3, account1, scammer);
            account1.WriteData();           
            Console.ReadKey();
        }
    }
}
