#include <iostream>
#include <vector>

using namespace std;

int main() {
    
    cout << "P - Print numbers" << endl;
    cout << "A - Add a number" << endl;
    cout << "M - Display mean of the numbers" << endl;
    cout << "S - Display the smallest number" << endl;
    cout << "L - Display the largest number" << endl;
    cout << "Q - Quit" << endl;
    
    cout << "\nEnter your choice:" << endl;
    
    vector<int> vec;
    char choice = '\0';
    
    int numToAdd;
    int sum;
    int count;
    double average;
    int smallest;
    int largest;
    
    while (cin >> choice) {
        switch (choice) {
            case 'p':
            case 'P': 
                if (vec.size() == 0) {
                    cout << "[] - The list is empty" << endl;
                } else {
                    cout << "[";
                    for (int v : vec) {
                        cout << v << " ";
                    }
                    cout << "]" << endl;
                }
                break;
            case 'a':
            case 'A': 
                cout << "Please enter the number you wish to add:" << endl;
                cin >> numToAdd;
                if (find(vec.begin(), vec.end(), numToAdd) != vec.end()) {
                    cout << "The list already contains " << numToAdd << endl;
                } else {
                    vec.push_back(numToAdd);
                }
                break;
            case 'm':
            case 'M': 
                sum = 0;
                count = vec.size();
                for (int i=0; i < count; i++) {
                    sum += vec.at(i);
                }
                
                average = (double)sum / count;
                cout << "The average is " << average << endl;
                break;
            case 's':
            case 'S': 
                if (vec.size() == 0) {
                    cout << "[] - The list is empty" << endl;
                } else {
                    smallest = vec.at(0);
                    for (int i=1; i < vec.size(); i++) {
                        if (vec.at(i) < smallest) {
                            smallest = vec.at(i);
                        }
                    }
                }
                cout << "The smallest number is " << smallest << endl;
                break;
            case 'l':
            case 'L': 
                if (vec.size() == 0) {
                    cout << "[] - The list is empty" << endl;
                } else {
                    largest = vec.at(0);
                    for (int i=1; i < vec.size(); i++) {
                        if (vec.at(i) > largest) {
                            largest = vec.at(i);
                        }
                    }
                }
                cout << "The largest number is " << largest << endl;
                break;
            case 'q':
            case 'Q': 
                return 0;
            default: 
                cout << "Unknown selection, please try again" << endl;
        }
    }
    
	return 0;
}
