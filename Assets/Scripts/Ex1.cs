using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    public string letter;

    // Start is called before the first frame update
    void Start()
    {
        IsVowel(letter);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   private bool IsVowel(string l)
    {
        if (l=="a"||l=="e"|| l == "i"|| l == "o"|| l == "u" )
        {
            Debug.Log($"The letter is a vowel");
          return true;
        }
        Debug.Log($"The letter is not a vowel");
        return false;
    }
}
