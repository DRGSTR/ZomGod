using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Key : MonoBehaviour
{
    public GameObject door;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.CompareTag("Player"))
        {
            Debug.Log("Key Picked");
            this.gameObject.SetActive(false);

            door.GetComponent<Collider2D>().enabled = false;

            SceneManager.LoadScene("l2");
        }
    }
}
