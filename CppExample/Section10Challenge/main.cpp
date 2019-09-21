#include <iostream>
#include <string>

using namespace std;

int main() {
    
    string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string key = "ZYXWVUTSRQPONMLKJIHGFEDCBAzyxwvutsrqponmlkjihgfedcba";
    
    string sentence;
    
    getline(cin, sentence);
    
    cout << "The original sentence is " << sentence << endl;
    
    string encrypted_sentence = sentence;
    for (size_t i=0; i < encrypted_sentence.length(); i++) {
        size_t original_character = alphabet.find(encrypted_sentence[i]);
        if (original_character == string::npos) continue;
        size_t replacement_character = key[original_character];
        encrypted_sentence[i] = replacement_character;
    }
    
    cout << "The encrypted sentence is " << encrypted_sentence << endl;
    
    string decrypted_sentence = encrypted_sentence;
    for (size_t i=0; i < decrypted_sentence.length(); i++) {
        size_t encrypted_character = alphabet.find(decrypted_sentence[i]);
        if (encrypted_character == string::npos) continue;
        size_t decrypted_character = key[encrypted_character];
        decrypted_sentence[i] = decrypted_character;
    }
    
    cout << "The decrypted sentence is " << decrypted_sentence << endl;
    
    return 0;
}