using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex3 : MonoBehaviour
{
    public int x;
    public int y;

    // Start is called before the first frame update
    void Start()
    {
        IsExact(x, y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void IsExact(int x, int y)
    {
        if (x % y == 0)
        {
            Debug.Log($"The division is exact");
        }
        Debug.Log($"The division is not exact");
    }
}
