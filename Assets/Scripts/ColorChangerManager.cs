using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ColorChangerManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Dropdown dropdown;

    [SerializeField]
    private Material objectMaterial;
    void Start()
    {
        OptionChanged();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OptionChanged()
    {
        int value = dropdown.value;
        if(value == 0)
        {
            objectMaterial.color = Color.red;
        }
        else if(value == 1)
        {
            objectMaterial.color = Color.blue;
        }
        else if(value == 2)
        {
            objectMaterial.color = Color.yellow;
        }
        else if(value == 3)
        {
            objectMaterial.color = Color.green;
        }
    }
}
