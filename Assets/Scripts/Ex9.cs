using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex9 : MonoBehaviour
{
    public float base1;
    public float height1;
    // Start is called before the first frame update
    void Start()
    {
        Area(base1, height1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Area(float b, float h)
    {
        float area;
        if (b > 0 && h > 0)
        {
            area = b * h / 2;
            Debug.Log($"The area of the triangle is {area}");  
        }
        Debug.Log($"The area cannot be calculated");
    }

}
