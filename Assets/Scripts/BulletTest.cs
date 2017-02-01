using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTest : MonoBehaviour {

    public Transform BulletPosition;
    public GameObject bullets;
    public float fireDelay = 0f;
    private GameObject currBullet;
    private float delay = 0f;
	// Use this for initialization
	void Start () {
        if (BulletPosition == null)
        {
            Debug.LogWarning("The BulletPosition transform has not been assigned in the editor!");
            return;
        }
        if (bullets == null)
        {
            Debug.LogWarning("The bullets object has not been assigned in the editor!");
            return;
        }
        if (fireDelay == 0f)
        {
            fireDelay = 0.25f;
        }
        currBullet = CreateBullets();
    }

	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1") && delay <= 0)
        {
            Debug.Log("Fire~~~");
            Fire();
        }
        if (delay >= 0f) //Always remove the delay to fire per frame
        {
            delay -= Time.deltaTime;
        }
	}

    void Fire() { 
        currBullet.GetComponent<FireBullet>().Fire();
        delay = fireDelay; //Reset the delay to next bullet firing
        currBullet = CreateBullets();
    }

    GameObject CreateBullets()
    {
        GameObject bullet = Instantiate(bullets, BulletPosition.position, Quaternion.identity, BulletPosition);
        return bullet;
    }
}
