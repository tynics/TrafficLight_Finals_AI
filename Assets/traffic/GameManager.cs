using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Lights
{
    Red,
    Green
}
public class GameManager : MonoBehaviour
{
    public Lights eLight;
    public GameObject cars;
    public Transform[] SpawnPoints;
    public GameObject[] stopLights;
    public int randomSpawner;

    // Update is called once per frame
    void Update()
    {
        switch (eLight)
        {
            case Lights.Red:
                break;
            case Lights.Green:
                break;
            default:
                break;
        }

        randomSpawner = Random.Range(0, SpawnPoints.Length);
    }

    public void RedLight()
    {
        stopLights[0].SetActive(true);
        stopLights[1].SetActive(true);
        stopLights[2].SetActive(false);
        stopLights[3].SetActive(false);
        eLight = Lights.Red;
    } 
    public void GreenLight()
    {
        stopLights[0].SetActive(false);
        stopLights[1].SetActive(false);
        stopLights[2].SetActive(true);
        stopLights[3].SetActive(true);
        eLight = Lights.Green;
    }
    public void SpawnCars()
    {
        Instantiate(cars, SpawnPoints[randomSpawner].transform.position, Quaternion.identity);
    }
}
