using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopLightButtons : MonoBehaviour
{
    public GameObject cars;
    public Transform[] SpawnPoints;
    public GameObject[] stopLights;
    public int randomSpawner;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        randomSpawner = Random.Range(0, SpawnPoints.Length);
    }

    public void SpawnCars()
    {
        Instantiate(cars, SpawnPoints[randomSpawner].transform.position, Quaternion.identity);
    }

    public void GreenLightDown()
    {
        stopLights[0].SetActive(false);
    }
    public void GreenLightRight()
    {
        stopLights[1].SetActive(false);
    }
    public void GreenLightUp()
    {
        stopLights[2].SetActive(false);
    }
    public void GreenLightLeft()
    {
        stopLights[3].SetActive(false);
    }

    public void RedLightDown()
    {
        stopLights[0].SetActive(true);
    }
    public void RedLightRight()
    {
        stopLights[1].SetActive(true);
    }
    public void RedLightUp()
    {
        stopLights[2].SetActive(true);
    }
    public void RedLightLeft()
    {
        stopLights[3].SetActive(true);
    }

    public void AllRed()
    {
        stopLights[0].SetActive(true);
        stopLights[1].SetActive(true);
        stopLights[2].SetActive(true);
        stopLights[3].SetActive(true);
    }
    public void AllGreen()
    {
        stopLights[0].SetActive(false);
        stopLights[1].SetActive(false);
        stopLights[2].SetActive(false);
        stopLights[3].SetActive(false);
    }
}
