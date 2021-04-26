using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float velocity = 10;/*velocidad de la bala*/
    [SerializeField] int bulletTime = 5; /*tiempo de vida de la bala*/
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * velocity * Time.deltaTime);
        Destroy(gameObject,bulletTime);
    }
}
