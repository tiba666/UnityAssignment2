using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public GameObject explosionPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("bullet")){
            print("explode");
            gameObject.SetActive(false);

            GameObject explosion = Instantiate(explosionPrefab);

            explosion.transform.position = this.transform.position;


        }
    }
}
