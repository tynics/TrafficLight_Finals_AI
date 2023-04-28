using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehaviour : MonoBehaviour
{
    public GameObject carsPrefab;
    public int cooldownTime = 1;
    // Start is called before the first frame update

    private void Start()
    {
        StartCoroutine(SpawnCars(cooldownTime));
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnCars(int waitTime)
    {
        while(true)
        {
            Vector3 locationSpawner = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Instantiate(carsPrefab, locationSpawner, Quaternion.identity);
            yield return new WaitForSeconds(waitTime);
        }
    }
}
