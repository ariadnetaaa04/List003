using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex2 : MonoBehaviour
{
    public int x;
    // Start is called before the first frame update
    void Start()
    {
        IsEven(x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private bool IsEven(int x)
    {
        if (x % 2 == 0)
        {
            Debug.Log("The number it's even");
            return true;
        }
        Debug.Log("The number it's odd");
        return false;
    }
}
