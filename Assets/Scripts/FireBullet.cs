using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour {

    public float firingSpeed; // The speed the bullet moves at once fired
    public float TTL = 5f; // Lifetime of the bullet once fired in seconds

    private Rigidbody rb;
    private MeshRenderer rend;
    private bool firing = false;

    public void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rend = gameObject.GetComponentInChildren<MeshRenderer>();
    }

    public void Fire()
    {
        Debug.Log("Firing!~~~");
        if (!firing)
        {
            firing = true;
            rb.AddForce(transform.forward * firingSpeed);
            rend.enabled = true;
            Destroy(gameObject, TTL);
        }
    }
}
