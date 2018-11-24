using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    //Velocidad a la que se crean los hexagonos
    public float spawnRate = 1f;

    public GameObject hexagonPrefab;

    //Velocidad a la que se crea el siguiente hexagono.
    private float nextTimeToSpawn = 0f;
	
	// Update is called once per frame
	void Update () {
		if(Time.time >= nextTimeToSpawn)
        {
            //Instanciamos un hexagono y el tiempo.
            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1 / spawnRate;
        }
	}
}
