using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonScript : MonoBehaviour {

    public Rigidbody2D rb;

    //Velocidad a la que los hexagonos se hacen pequeños
    public float shrinkSpeed = 3f;

	// Use this for initialization
	void Start () {
        //Hacemos que empiecen rotados de una forma random
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
	}
	
	// Update is called once per frame
	void Update () {
        //Modificamos el hexagono cada frame
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;

        if(transform.localScale.x <= 0.05f)
        {
            Destroy(gameObject);
        }
	}
}
