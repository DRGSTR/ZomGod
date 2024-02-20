using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : KeyScript
{
    private KeyScript key;

    private void Start()
    {
        key = new KeyScript();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Reached door");
            if(key.key_collected == 1)
            {
                Debug.Log("Door open");
            }
        }
    }
}
