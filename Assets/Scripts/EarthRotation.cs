using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotation : MonoBehaviour
{
    [Header("Referances")]
    [SerializeField] Transform sunTransform;
    [Header("Attributes")]
    [SerializeField] float idleRotationSpeed;
    [SerializeField] float rotationSpeed;
    [SerializeField] float orbitDistance;
    private float movementInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = sunTransform.position + (transform.position - sunTransform.position).normalized * orbitDistance;
        if (Input.GetKey(KeyCode.K))
        {
            movementInput = 1;
        }
        else if (Input.GetKey(KeyCode.L))
        {
            movementInput = -1;
        }
        else { movementInput = 0; }
        if (movementInput == 0)
        {
            transform.RotateAround(sunTransform.position, Vector3.right, idleRotationSpeed * Time.deltaTime);
        }
        else
        {
            transform.RotateAround(sunTransform.position, Vector3.right, movementInput * rotationSpeed * Time.deltaTime);
        }
    }
}
