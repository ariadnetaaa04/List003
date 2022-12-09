 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex4 : MonoBehaviour
{
    public Vector3 position;
  
    // Start is called before the first frame update
    void Start()
    {
        Movement(position);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void Movement(Vector3 p)
    {
        transform.position = p;
    }

}
 
