using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex8 : MonoBehaviour
{
    public int year;
    // Start is called before the first frame update
    void Start()
    {
        IsLeapYear(year);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool IsLeapYear(int y)
    {
        if((y % 4 == 0 && y % 100 != 0 || y % 400 == 0))
        {
            Debug.Log($"{y} is a leap year");
            return true;
        }
        Debug.Log($"{y} is not a leap year");
        return false;

    }
}
