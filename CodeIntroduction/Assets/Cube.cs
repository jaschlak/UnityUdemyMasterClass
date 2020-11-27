using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float sizeModifier = 2.5f;
    public string newName = "Cubey42";
    public bool isRotated = false;

    // Used for initialization
    void Start()
    {
        Debug.Log ("This program started!");

        // Modify size of cube to sizeModifier identified
        transform.name = ImproveName(newName);
        transform.localScale *= sizeModifier;
    }

    // Called once per frame.
    private void Update()
    {
        Debug.Log("Updated stuff");
        transform.localScale = Vector3.one * sizeModifier;

        if (isRotated)
            {
            transform.localEulerAngles = Vector3.one * 45f;
            } else
        {
            transform.localEulerAngles = Vector3.one * 0f;
        }

    }

    string ImproveName (string originalString)
    {
        return "-[" + originalString + "]-";
    }
}
