using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // shoot, click mouse
        if (Input.GetMouseButtonDown(0))
        {
            // instantiate bullet
            GameObject bulletObject = Instantiate(bulletPrefab);
            Bullet bullet = bulletObject.GetComponent<Bullet>();

            // determine shooting direction
            Vector3 shootingDirection = new Vector3
                (
                Random.Range(-.15f, .15f),
                Random.Range(-.15f, .15f),
                1f
                );

            // apply shooting direction unit vector
            bullet.shootingDirection = shootingDirection.normalized;
        }
    }
}
