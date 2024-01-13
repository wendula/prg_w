using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class bank_account
    {
        int account_number;
        string holder_name;
        string currency;
        int balance;
        public void Deposit (int money_give)
        {
            balance += money_give;
        }
        public void Withdraw (int money_take)
        {
            balance -= money_take;
        }
        public void Transfer(int money_transfer, bank_account bank_accountInstance)
        {
            balance -= money_transfer;
            bank_accountInstance.balance += money_transfer; 
        }
        public bank_account(string holder_name, string currency)
        {
            Random rnd = new Random();
            account_number = rnd.Next(100000000, 10000000000);
            balance = 0;
        }
    }
/*2) Vytvoř třídu BankAccount, kterou budeme reprezentovat bankovní účet
 *    Přidej třídě BankAccount čtyři proměnné - accountNumber jako číslo účtu
 *                                            - holderName jako jméno osoby, které účet patří
 *                                            - currency jako měna, ve které je účet vedený
 *                                            - balance jako zůstatek na účtu
 *    Přidej třídě BankAccount čtyři funkce - Deposit, která jako vstupní parametr přijme množství peněz a vloží je na účet
 *                                          - Withdraw, která jako vstupní parametr přijme množství peněz a z účtu "vybere" peníze, tedy sníží zůstatek a navrátí požadované množství
 *                                                      Pokud na účtu není dostatek peněz, uživatele upozorní a vrátí nulu.
 *                                          - Transfer, která jako vstupní parametry přijme množství peněz a číslo účtu, na které se budou peníze posílat, a převede peníze
 *                                                      z jednoho účtu na druhý (opět pouze pokud je na účtu, ze kterého převod jde, dostatek peněz)
 *Přidej třídě BankAccount konstruktor, který bude přijímat dva parametry - jméno majitele účtu a měnu, ve které bude účet vedený
 *                                                                            - Při jeho zavolání nastav jméno a měnu podle vstupních parametrů, accountNumber nastav jako náhodně
 *                                                                              vygenerované číslo velké alespoň 100 000 000 a menší, než 10 000 000 000 a balance nastav na nulu
 * 
