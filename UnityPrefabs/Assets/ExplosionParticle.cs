using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionParticle : MonoBehaviour
{

    public float explosionForce = 300f;
    public float lifetime = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        // Create random directions for particle post explosion
        Vector3 randomDirection = new Vector3(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f)
        );

        float randomForce = Random.Range(0f, explosionForce);

        // Explode the force using randomDirection unit vectors and explosionForce magnitude
        GetComponent<Rigidbody>().AddForce(randomDirection.normalized * randomForce);

        

    }

    // Update is called once per frame
    void Update()
    {
        lifetime -= Time.deltaTime;
        if (lifetime <= 0)
        {
            Destroy (gameObject);
        }
    }
}
