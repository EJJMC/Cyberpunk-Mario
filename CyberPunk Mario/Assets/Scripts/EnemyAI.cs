using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float enemyMoveSpeed = 3f;
    
    // Start is called before the first frame update
    void Start()
    {


    }

    private void Update()
    {
        transform.Translate(Vector2.right * enemyMoveSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "NPCTurnRight")
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (other.gameObject.tag == "NPCTurnLeft")
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
    }
}
