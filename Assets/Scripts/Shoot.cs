using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject bulletPrefab;
    public float speed = 0.0000000000000000000000000000000000001f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            GameObject bullet = Instantiate(bulletPrefab);
            //Physics.IgnoreCollision(bullet.GetComponent<Collider>(),
            //    this.transform.parent.GetComponent<Collider>());

            bullet.transform.position = this.transform.position;

            Vector3 rotation = bullet.transform.rotation.eulerAngles;
            bullet.transform.rotation = Quaternion.Euler(rotation.x, transform.eulerAngles.y, rotation.z);

            bullet.GetComponent<Rigidbody>().AddForce(this.transform.forward * speed, ForceMode.Impulse);
        }
    }
}
