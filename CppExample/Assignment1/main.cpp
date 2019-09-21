#include <iostream>
#include <string>

using namespace std;

    
    /*
     * Example:
     * input = ABCD
     * 
     * output:
     * _ _ _ A _ _ _
     * _ _ A B A _ _ 
     * _ A B C B A _
     * A B C D C B A
     */
    

int main()
{
    cout << "Please enter a word:" << endl;
    
    string input;
    cin >> input;

    int height = input.length();
    
    string pyramid [height];
    
    for (int row = 0; row < height; row++) {
        string current = "";
        
        // add leading spaces
        for (int i=0; i < height-row-1; i++) {
            current.append(" ");
        }
        
        // add leading characters
        for (int i=0; i < row; i++) {
            current += input[i];
        }
        
        // add central character
        current += input[row];
        
        // add trailing characters       
        for (int i=row-1; i >= 0; i--) {
            current += input[i];
        }
        
        // add trailing spaces
        for (int i=0; i < height-row-1; i++) {
            current.append(" ");
        }
        
        // add row to pyramid
        pyramid[row] = current;
    }
    
    // print the pyramid
    cout << endl;
    cout << "Pyramid:" << endl;
    for (int i=0; i < height; i++) {
        cout << pyramid[i] << endl;
    }
    
    return 0;
}