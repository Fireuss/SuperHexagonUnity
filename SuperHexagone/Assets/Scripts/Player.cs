using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    //Velocidad del jugador y movement = ( 0 quieto, 1 hacia la derecha, -1 izquierda)
    public float moveSpeed = 600f;
	public float movement = 0f;

	// Update is called once per frame
	void Update () {
        //Recogemos el input de los botones. (Raw porque no queremos hacerlo smooth, queremos que sea responsive)
       movement = Input.GetAxisRaw("Horizontal");
	}

    private void FixedUpdate()
    {
        //Hacemos que el jugador se mueva alrededor  del punto especificado.
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Cuando chocamos con algo se reinicia la scene.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
