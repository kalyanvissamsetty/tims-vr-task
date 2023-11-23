using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CounterManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private TextMeshProUGUI cubeCount, sphereCount, cylinderCount;

    private int cubeCountvalue, sphereCountValue, cylinderCountValue;
    void Start()
    {
        cubeCountvalue = 0;
        sphereCountValue = 0;
        cylinderCountValue = 0;
        cubeCount.text = cubeCountvalue.ToString();
        sphereCount.text = sphereCountValue.ToString();
        cylinderCount.text = cylinderCountValue.ToString();
    }

    public void GrabObject(string name)
    {
        if(name == "Cube")
        {
            cubeCountvalue++;
            cubeCount.text = cubeCountvalue.ToString();
        }
        else if(name == "Sphere")
        {
            sphereCountValue++;
            sphereCount.text = sphereCountValue.ToString();
        }
        else if(name == "Cylinder")
        {
            cylinderCountValue++;
            cylinderCount.text = cylinderCountValue.ToString();
        }
    }
}
