using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RedLightBehaviour : MonoBehaviour
{
    public NavMeshAgent carAgent;
    public GameObject stopLight;

    public bool itsStoppedAlready;
    private void Start()
    {
        stopLight = GameObject.FindGameObjectWithTag("Red_Light");
        itsStoppedAlready = false;
    }

    private void Update()
    {
        if(!stopLight.activeSelf && itsStoppedAlready == true)
        {
            carAgent.speed = 3.5f;
        }
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Red_Light")
        {
            Debug.Log("Red Light");
            carAgent.speed = 0;
        }
        else
        {
            carAgent.speed = 3.5f;
        }
    }*/


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Red_Light" && itsStoppedAlready == false)
        {
            stopLight = collision.gameObject;
            itsStoppedAlready = true;
            Debug.Log("Red Light");
            carAgent.speed = 0;
        }


        if (collision.gameObject.tag == "CarA")
        {
            Debug.Log("Car Infront");
            carAgent.speed = 0;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "CarA")
        {
            Debug.Log("Car Infront");
            carAgent.speed = 3.5f;
        }
    }

}
