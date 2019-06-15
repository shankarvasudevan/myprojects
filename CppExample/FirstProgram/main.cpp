#include <iostream>

using namespace std;

int main() 
{
    const double cost_of_small_rooms = 25.0;
    const double cost_of_large_rooms = 35.0;
    const double sales_tax_percentage = 0.06;

    int number_of_small_rooms = 0;
    cout << "How many small rooms would you like cleaned?: ";
    cin >> number_of_small_rooms;
    
    int number_of_large_rooms = 0;
    cout << "How many large rooms would you like cleaned?: ";
    cin >> number_of_large_rooms;
    
    double cost_without_tax = 0;
    cost_without_tax = number_of_small_rooms * cost_of_small_rooms + number_of_large_rooms * cost_of_large_rooms;
    
    double tax_amount = 0;
    tax_amount = sales_tax_percentage * cost_without_tax;
    
    double total_cost = 0;
    total_cost = cost_without_tax + tax_amount;
    
    cout << "Cost of cleaning rooms: " << cost_without_tax << endl;
    cout << "Total tax: " << tax_amount << endl;
    cout << "Total cost including tax: " << total_cost << endl;
    
}