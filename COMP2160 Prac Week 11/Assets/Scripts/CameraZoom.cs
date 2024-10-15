using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraZoom : MonoBehaviour
{
    #region Actions
        private Actions actions;
        private InputAction zoomAction;
    #endregion

    private Camera cam;
    [SerializeField] private float sensitivity = 10.0f;

    void Awake()
    {
        actions = new Actions();
        zoomAction = actions.camera.zoom;

        cam = Camera.main;
    }

    void OnEnable()
    {
        zoomAction.Enable();
    }

    void OnDisable()
    {
        zoomAction.Disable();
    }

    void Update()
    {
        float zoom = zoomAction.ReadValue<float>();
        if(cam.orthographic)
        {
            cam.orthographicSize += zoom/sensitivity;
        }
        else
        {
            cam.fieldOfView += zoom/sensitivity;
        }
    }
}
