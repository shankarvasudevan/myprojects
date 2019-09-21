#include <iostream>

using namespace std;

int main()
{
    int dollar = 100;
    int quarter = 25;
    int dime = 10;
    int nickel = 5;
    int penny = 1;
    
    cout << "Enter an amount in cents: ";
    
    int amount_in_cents = 0;
    cin >> amount_in_cents;
    
    cout << "\nYou can provide the change as follows" << endl;

    int num_dollars = amount_in_cents / dollar;
    amount_in_cents = amount_in_cents % dollar;
    int num_quarters = amount_in_cents / quarter;
    amount_in_cents = amount_in_cents % quarter;
    int num_dimes = amount_in_cents / dime;
    amount_in_cents = amount_in_cents % dime;
    int num_nickels = amount_in_cents / nickel;
    amount_in_cents = amount_in_cents % nickel;
    int num_pennies = amount_in_cents / penny;
    
    cout << "dollars: " << num_dollars << endl;
    cout << "quarters: " << num_quarters << endl;
    cout << "dimes: " << num_dimes << endl;
    cout << "nickels: " << num_nickels << endl;
    cout << "pennies: " << num_pennies << endl;
    
    return 0;
}