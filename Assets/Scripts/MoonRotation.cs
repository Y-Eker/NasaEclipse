using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonRotation : MonoBehaviour
{
    [Header("Referances")]
    [SerializeField] Transform earthTransform;
    [Header("Attributes")]
    [SerializeField] float rotationSpeed;
    private float verticalInput;
    private float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(earthTransform.position, Vector3.right, rotationSpeed * Time.deltaTime);
    }
}
