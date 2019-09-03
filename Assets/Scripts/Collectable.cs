using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{

    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
        print("Collided");
            AudioSource.PlayClipAtPoint(clip, gameObject.transform.position);
            Text counterText = GameObject.Find("Counter").GetComponent<Text>();
            int counter = int.Parse(counterText.text);
            counter++;
            counterText.text = "" + counter;
            Destroy(gameObject);

        }
    }

}
