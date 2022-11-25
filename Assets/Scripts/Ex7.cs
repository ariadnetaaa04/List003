using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex7 : MonoBehaviour
{
    public int num;
    // Start is called before the first frame update
    void Start()
    {
        IsAbsolut(num);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private int IsAbsolut(int n)
    {
        int absolute;
        if (n >= 0)
        {

            absolute = n;
            Debug.Log($"The absolute value of {n} it's {n} ");
            return n;
        }
        absolute = n * -1;
        {
            Debug.Log($"The absolute value of {n} it's {absolute}");
            return absolute;
        }
        
    }
}
