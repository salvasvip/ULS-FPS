using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] Transform bullet;

    [SerializeField] GameObject startBullet;

    bool change;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (change)
        // {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(bullet, startBullet.transform.position, startBullet.transform.rotation);

            }
        //
        //
        // }
        // else
        // {
        //     
        // }
        //
        // if (Input.GetKey('c'))
        // {
        //     change = 
        // }
        
    }
}
