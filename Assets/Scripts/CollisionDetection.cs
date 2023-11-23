using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private ParticleSystem fireOne, firesTwo;

    [SerializeField]
    private Transform cube, sphere;
    private bool isGrabbed;
    void Start()
    {
        isGrabbed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Collider-1" && isGrabbed == false)
        {
            fireOne.Play();
            transform.position = this.gameObject.name == "Cube" ? cube.position : sphere.position;
        }

        if(other.gameObject.name == "Collider-2" && isGrabbed == false)
        {
            firesTwo.Play();
            transform.position = this.gameObject.name == "Cube" ? cube.position : sphere.position;
        }
        
    }

    public void IsGrabbedObject(bool k)
    {
        isGrabbed = k;
    }
}
