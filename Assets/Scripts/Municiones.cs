using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Municiones : MonoBehaviour
{
    public Shoot muni;
    [SerializeField] Text mensaje;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            muni.municion += 5;
            mensaje.text = "!Municion recargada!";
            StartCoroutine("TImeToMessage");
            muni.TiempoMensaje();
            Destroy(gameObject, 1);
            
        }
    }

    IEnumerator TImeToMessage()
    {
        yield return new WaitForSeconds(2);
        mensaje.text = " ";
    }
}
