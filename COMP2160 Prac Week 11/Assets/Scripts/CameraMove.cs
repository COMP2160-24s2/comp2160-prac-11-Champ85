using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float spped;

    // Update is called once per frame
    void Update()
    {
        if(target.position != transform.position)
        {
            transform.position = target.position;
        }
    }
}
