using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class LerpBolinha : MonoBehaviour
{
    [SerializeField]
    public Transform inicio;

    [SerializeField]
    public Transform fim;

    [SerializeField]
    [Range(0f,1f)]
    public float porcent = 0.5f;

    private bool on = false;
    private int direcao = 1;

    void Update() {
        if (on) {
            switch(direcao){
                case 1: 
                    porcent += 0.005f;
                    break;
                case 2:
                    porcent -= 0.005f;
                    break;
            }

            if (porcent > 1f)
                direcao = 2;
            else if (porcent < (0f))
                direcao = 1;
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            mudarMoveBola();
        }
        
        transform.position = Vector3.Lerp(inicio.position, fim.position, porcent);
        
    }

    public void mudarMoveBola(){
        on = !on;
    }
}