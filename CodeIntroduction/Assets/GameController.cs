using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject cubePrefab;
    public int cubeAmount = 20;
    public float randomArea = 5f;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < cubeAmount; i++)
        {
            GameObject cubeObject = Instantiate(cubePrefab);
            cubeObject.transform.position = new Vector3(
                Random.Range(-randomArea, randomArea),
                Random.Range(-randomArea, randomArea),
                Random.Range(-randomArea, randomArea));
        }
        Instantiate (cubePrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
