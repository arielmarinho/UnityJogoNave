using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour {
	public GameObject explosaoPrefab;
	public float velocidade;
	public float tempoVida;
	// Use this for initialization
	void Start () {
		Destroy (gameObject,tempoVida);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.up * velocidade * Time.deltaTime);
		
	}
	void OnCollisionEnter2D(Collision2D c){
		if(c.gameObject.tag == "Inimigo"){
			Instantiate (explosaoPrefab, transform.position, transform.rotation);
			Destroy (c.gameObject);
			Destroy (gameObject);

			
		}
	}
}
