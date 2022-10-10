using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    public Timer timer;
    public Counter counter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Lighting")
        {
            timer.cdRemainingTime += 1;
            counter.counter++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Canister")
        {
            timer.cdRemainingTime += 5;
            counter.counter++;
            Destroy(collision.gameObject);
        }

    }
}
