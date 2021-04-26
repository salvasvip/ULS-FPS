using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllAnimator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Animator slime;
    void Start()
    {
        slime.SetBool("Camina", false);
        slime.SetBool("Espera", false);
        slime.SetBool("Ataca", false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            slime.SetBool("Camina", true);
            slime.SetBool("Espera", false);
        }
        if (Input.GetKeyDown("e"))
        {
            slime.SetBool("Ataca", true);
            slime.SetBool("Camina", false);
        }
        if (Input.GetKeyDown("r"))
        {
            slime.SetBool("Ataca", false);
            slime.SetBool("Camina", false);
            slime.SetBool("Espera", true);
            slime.SetBool("Camina", true);
        }
        
    }
}
