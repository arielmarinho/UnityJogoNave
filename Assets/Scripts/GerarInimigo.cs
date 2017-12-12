using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerarInimigo : MonoBehaviour {
	public GameObject inimigo;
	public float limiteEsquerdo, limiteDireito;
	public float tempoInicial, tempoFinal;
	// Use this for initialization
	IEnumerator Start(){
		yield return new WaitForSeconds (Random.Range (tempoInicial,tempoFinal));

		Vector2 posicao = new Vector2 (Random.Range (limiteEsquerdo, limiteDireito),transform.position.y);
		Instantiate (inimigo, posicao, transform.rotation);

		StartCoroutine (Start ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
