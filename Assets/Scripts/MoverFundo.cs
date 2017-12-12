using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverFundo : MonoBehaviour {
	public float limite_y;
	public float velocidade;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.down * velocidade * Time.deltaTime);

		if (transform.position.y <= limite_y) {
			transform.position = new Vector2 (0.0f, limite_y * -1);
		}
	}
}
