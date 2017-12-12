using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JogadorScript : MonoBehaviour {
	public int vida;
	public float velocidade;
 	float move_x;
	float move_y;
	public float limiteEsquerdo, limiteDireito;
	public GameObject explosaoPrefab;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Mover ();
		
	}
	void Mover(){
		move_x = Input.GetAxisRaw("Horizontal") * velocidade * Time.deltaTime;
		move_y = Input.GetAxisRaw("Vertical") * velocidade * Time.deltaTime;
		transform.Translate (move_x , move_y , 0.0f);

		//wrap
		if(transform.position.x < limiteEsquerdo || transform.position.x > limiteDireito ){
			transform.position = new Vector2 (transform.position.x * -1, transform.position.y );
			
		}

	}
	void OnCollisionEnter2D(Collision2D c){
		if (c.gameObject.tag == "Inimigo") {
			vida--;
			Instantiate (explosaoPrefab,transform.position,transform.rotation);
			Destroy (c.gameObject);
			if (vida <= 0) {
				Destroy (gameObject);
			}
		}
	}
}
