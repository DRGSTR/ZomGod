using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodEffectPS : MonoBehaviour
{
    public GameObject Blood;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        BloodEffect(collision);
    }

    public void BloodEffect(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Instantiate(Blood, transform.position, Quaternion.identity);
        }
    }
} // class
