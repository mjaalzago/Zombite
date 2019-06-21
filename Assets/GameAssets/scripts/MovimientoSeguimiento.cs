using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoSeguimiento : MonoBehaviour {


    [SerializeField] Transform jugador;
    [SerializeField] float velocidadMovimiento = 5;
    CharacterController miCC;

    private void Awake()
    {
        miCC = GetComponent<CharacterController>();
    }

    void Update()
    {
        this.transform.LookAt(jugador);
        miCC.SimpleMove(this.transform.forward * velocidadMovimiento);
    }

}
