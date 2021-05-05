using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCars : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] cars;
    private float[] pos = {-3f, -1f, 1f, 3f};
    public float secondsBetweenCarSpawn;
    void Start()
    {
        SpawnCar();
    }

    private void SpawnCar(){
        Instantiate(cars[Random.Range(0, cars.Length)],
            new Vector3(pos[Random.Range(0, pos.Length)], 8f, 0),
                Quaternion.Euler(new Vector3(90, 90, -90)));

        Invoke("SpawnCar", secondsBetweenCarSpawn);
    }
}
