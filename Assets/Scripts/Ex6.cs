using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex6 : MonoBehaviour
{
    public int num1;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {
        IsLarger(num1, num2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private int IsLarger(int x,int y)
    {
        if (x > y)
        {
            Debug.Log($"{x} is larger than {y}");
            return x;
        }
        Debug.Log($"{y} is larger than {x}");
        return y;
    }
}
