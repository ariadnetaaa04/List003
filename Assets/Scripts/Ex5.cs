using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex5 : MonoBehaviour
{
    public int mult;
    private int i;
    private int result;
    // Start is called before the first frame update
    void Start()
    {
        Calculate(mult);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Calculate(int x)
    {
        
        for (int i = 0; i <= 10; i++)
        {
            result = x * i;
            Debug.Log($"{x} * {i} = {result}");
        }
    }
}
