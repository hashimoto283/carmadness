using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createScript : MonoBehaviour
{
    public GameObject Ground1;
    public GameObject Ground2;
    int border = 1000;
  

    void Update()
    {
        if (transform.position.z > border)
        {
            CreateMap();
        }
    }
    void CreateMap()
    {
        if (Ground1.transform.position.z < border)
        {
            Debug.Log("Ground1");
            border += 2000;
            Vector3 temp = new Vector3(0, 0.05f, border);
            Ground1.transform.position = temp;
        }
        else if (Ground2.transform.position.z < border)
        {
            Debug.Log("Ground2");
            border += 2000;
            Vector3 temp = new Vector3(0, 0.05f, border);
            Ground2.transform.position = temp;
        }
    }
}
