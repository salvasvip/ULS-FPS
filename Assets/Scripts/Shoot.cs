using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    [SerializeField] Transform bullet;

    [SerializeField] GameObject startBullet;
    [SerializeField] ParticleSystem flashDisparo;
    public int municion;
    [SerializeField] Text mensaje;
    [SerializeField] Text mensajeCantidadMunicion;

    bool change;

    private void Start()
    {
        mensajeCantidadMunicion.text = municion.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mensajeCantidadMunicion.text = municion.ToString();
            if (municion > 0)
            {
                Instantiate(bullet, startBullet.transform.position, startBullet.transform.rotation);
                flashDisparo.Play();
                municion--;
            }
            else
            {
                mensaje.text = "Sin Municion";
                
            }
        }
    }

    public IEnumerator TiempoMensaje()
    {
        yield return new WaitForSeconds(2);
        mensaje.text = "";
        
    }
}