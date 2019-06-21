using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour {
	
   [SerializeField] Transform puntoDisparo;
   [SerializeField] Transform padreBalas;
   [SerializeField] GameObject bala;

	// Update is called once per frame
	void Update () {
        
  
        if (Input.GetMouseButtonDown(0)){
            Debug.Log("Disparando");
            GameObject nuevaBala = Instantiate(bala, padreBalas);
            nuevaBala.transform.position = puntoDisparo.transform.position;
        }
	}
}
