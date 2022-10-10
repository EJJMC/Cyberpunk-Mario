using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    //public Collider Collider;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider Collision)
    {
        if (Collision.gameObject.tag == "Enemy" )
        {
            Destroy(Collision.gameObject);
        }


    }
}
