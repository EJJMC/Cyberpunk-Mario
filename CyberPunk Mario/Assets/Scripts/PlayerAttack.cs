using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public Collider2D Collider2D;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.gameObject.tag == "Enemy" && Collider2D.IsTouching(Collision))
        {
            Destroy(Collision.gameObject);
        }


    }
}
