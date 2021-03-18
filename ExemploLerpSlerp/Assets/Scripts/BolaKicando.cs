using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaKicando : MonoBehaviour
{
    [SerializeField]
    public Transform inicio;

    [SerializeField]
    public Transform fim;

    [SerializeField]
    [Range(0f,1f)]
    public float porcent = 0f;
    private int direcao = 1;
    void Update(){
        switch(direcao){
            case 1: 
                porcent += 0.05f;
                break;
            case 2:
                porcent -= 0.05f;
                break;
        }

        if ( porcent > 1 ){
            direcao = 2;
        } else if (porcent < (0f)){
            direcao = 1;
        }
    }

    void FixedUpdate()
    {        
        transform.position = Vector3.Lerp(fim.position, inicio.position, porcent);
    }

}
