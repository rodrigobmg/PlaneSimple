using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour {

    public float firingSpeed = 0f; // The speed the bullet moves at once fired
    public float TTL = 5f; // Lifetime of the bullet once fired in seconds

    private Rigidbody rb;
    private bool firing = false;

    public void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    public void Fire()
    {
        Debug.Log("Firing!~~~");
        if (!firing)
        {
            firing = true;
            rb.velocity = (transform.forward * firingSpeed);
            Destroy(gameObject, TTL);
        }
    }
}
