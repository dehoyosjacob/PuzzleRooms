using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level01Controller : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public CameraMovement camera;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!pauseMenu.activeSelf)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            camera.isPaused = false;
        }

        if ((Input.GetKeyUp(KeyCode.Escape)) && !pauseMenu.activeSelf)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            pauseMenu.SetActive(true);
            camera.isPaused = true;
        }
    }
}
