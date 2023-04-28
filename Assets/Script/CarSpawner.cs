using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CarSpawner : MonoBehaviour
{
    public NavMeshAgent carAgent;
    public Transform[] carDestination;
    public int DestinPoints;
    public float remDistance = 0.5f;

    RedLightBehaviour redlight;

    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0,90,0));
        carAgent = GetComponent<NavMeshAgent>();
        DestinPoints = Random.Range(0, carDestination.Length);
        carAgent.destination = carDestination[DestinPoints].position;
    }

    private void Update()
    {
        if(carAgent.remainingDistance < remDistance)
        {
            Destroy(gameObject);
        }
    }

}
