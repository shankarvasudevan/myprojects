#include <iostream>
#include <vector>

using namespace std;

void print_numbers(std::vector<int>);
void add_number(std::vector<int>&);
double get_mean(std::vector<int>);
int get_smallest_num(std::vector<int>);
int get_largest_num(std::vector<int>);

int main() 
{
    
    cout << "P - Print numbers" << endl;
    cout << "A - Add a number" << endl;
    cout << "M - Display mean of the numbers" << endl;
    cout << "S - Display the smallest number" << endl;
    cout << "L - Display the largest number" << endl;
    cout << "Q - Quit" << endl;
    
    cout << "\nEnter your choice:" << endl;
    
    vector<int> vec;
    char choice = '\0';
    
    while (cin >> choice) 
    {
        switch (choice) 
        {
            case 'p':
            case 'P': 
                print_numbers(vec);
                break;
            case 'a':
            case 'A': 
                add_number(vec);
                break;
            case 'm':
            case 'M': 
                double mean;
                mean = get_mean(vec);
                cout << "The average is " << mean << endl;
                break;
            case 's':
            case 'S': 
                if (vec.size() == 0) 
                {
                    cout << "[] - The list is empty" << endl;
                } 
                else
                {
                    int smallest;
                    smallest = get_smallest_num(vec);
                    cout << "The smallest number is " << smallest << endl;
                }
                break;
            case 'l':
            case 'L': 
                if (vec.size() == 0) 
                {
                    cout << "[] - The list is empty" << endl;
                } 
                else
                {
                    int largest;
                    largest = get_largest_num(vec);
                    cout << "The largest number is " << largest << endl;
                }
                
                break;
            case 'q':
            case 'Q': 
                return 0;
            default: 
                cout << "Unknown selection, please try again" << endl;
                break;
        }
    }
    
	return 0;
}

void print_numbers(std::vector<int> numbers)
{
    if (numbers.size() == 0) 
    {
        cout << "[] - The list is empty" << endl;
    } 
    else 
    {
        cout << "[";
        
        for (int i=0; i < numbers.size(); ++i)
        {
            cout << numbers[i] << " ";
        }
        
        cout << "]" << endl;
    }
}

void add_number(std::vector<int> &numbers)
{
    int numToAdd;
    cout << "Please enter the number you wish to add:" << endl;
    cin >> numToAdd;
    if (find(numbers.begin(), numbers.end(), numToAdd) != numbers.end()) 
    {
        cout << "The list already contains " << numToAdd << endl;
    } 
    else 
    {
        numbers.push_back(numToAdd);
    }
}

double get_mean(std::vector<int> numbers)
{
    int sum = 0;
    int count = numbers.size();
    
    for (int i=0; i < count; ++i) 
    {
        sum += numbers.at(i);
    }
    
    double mean = (double)sum / count;
    return mean;
}

int get_smallest_num(std::vector<int> numbers)
{
    int smallest;
    smallest = numbers.at(0);
    for (int i=1; i < numbers.size(); ++i) 
    {
        if (numbers.at(i) < smallest) 
        {
            smallest = numbers.at(i);
        }
    }
    
    return smallest;
}

int get_largest_num(std::vector<int> numbers)
{
    int largest;

    largest = numbers.at(0);
    for (int i=1; i < numbers.size(); i++) 
    {
        if (numbers.at(i) > largest) 
        {
            largest = numbers.at(i);
        }
    }
    
    return largest;
}