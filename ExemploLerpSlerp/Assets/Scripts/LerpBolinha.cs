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

    public Scrollbar buttonTypeInterpol;

    private bool on = false;
    private int direcao = 1;
    public string typeInterpol = "LERP";

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
            on = !on;
        }

        if (typeInterpol.Equals("LERP")) {
            transform.position = Vector3.Lerp(inicio.position, fim.position, porcent);
        } else {
            transform.position = Vector3.Slerp(inicio.position, fim.position, porcent);
        }
    }

    public void changeLerpSlerp(){
        if (buttonTypeInterpol.value < 0.6f) {
            typeInterpol = "LERP";
        } else {
            typeInterpol = "SLERP";
        }
    }
}