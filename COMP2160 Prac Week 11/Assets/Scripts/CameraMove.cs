using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform targetOne;
    [SerializeField] private Transform targetTwo;

    // Update is called once per frame
    void Update()
    {
        transform.position = targetOne.position + (targetTwo.position - targetOne.position)/2;
    }
}
