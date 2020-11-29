using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    // array of game cameras
    public GameObject[] gameCameras;

    // Camera selection
    private int gameCameraIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Controller Started");
        FocusOnCamera(gameCameraIndex);
    }

    // Update is called once per frame
    void Update()
    {

        // Keyboard directional input
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("Jump has been pressed");
        }

        if (Input.GetKey("left"))
        {
            Debug.Log("Moving Left");
        }

        if (Input.GetKey("right"))
        {
            Debug.Log("Moving Right");
        }

        // Camera change input
        if (Input.GetMouseButtonDown(0))
        {
            ChangeCamera(1);
        } else if (Input.GetMouseButtonDown(1))
        {
            ChangeCamera(-1);
        }
    }

    void FocusOnCamera(int index)
    {
        for (int i = 0; i < gameCameras.Length; i++)
        {
            gameCameras[i].SetActive(i == index);
        }
    }

    void ChangeCamera(int direction)
    {
        gameCameraIndex += direction;

        if (gameCameraIndex >= gameCameras.Length)
        {
            gameCameraIndex = 0;
        }

        if (gameCameraIndex < 0)
        {
            gameCameraIndex = gameCameras.Length - 1;
        }

        FocusOnCamera (gameCameraIndex);

    }
}
