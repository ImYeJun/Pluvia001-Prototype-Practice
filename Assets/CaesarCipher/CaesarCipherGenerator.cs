using System.Text;
using UnityEngine;

public class CaesarCipherGenerator : MonoBehaviour
{
    private string originalWord;
    private StringBuilder decodedWord;
    private int n = 3;

    private void Awake() {
        Encode();
    }

    public void Encode(string originalWord = "Ether"){
        this.originalWord = originalWord;
        decodedWord = new StringBuilder(originalWord.Length);

        foreach(char c in originalWord){
            if (char.IsUpper(c)){
                decodedWord.Append((char)('A' + (c - 'A' + n) % 26));
            }
            else if (char.IsLower(c)){
                decodedWord.Append((char)('a' + (c - 'a' + n) % 26));
            }
            else{
                decodedWord.Append(c);
            }
        }
        
        Debug.Log(originalWord);
        Debug.Log(decodedWord);
    }
}   
