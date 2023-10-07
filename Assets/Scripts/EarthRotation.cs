using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotation : MonoBehaviour
{
    public bool interactingSimulation;
    [Header("Referances")]
    [SerializeField] Transform sunTransform;
    [Header("Attributes")]
    [SerializeField] float idleRotationSpeed;
    [SerializeField] float rotationSpeed;
    [SerializeField] float orbitDistance;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = sunTransform.position + (transform.position - sunTransform.position).normalized * orbitDistance;
        if (interactingSimulation)
        {
            if (verticalInput == 0)
            {
                transform.RotateAround(sunTransform.position, Vector3.right, idleRotationSpeed * Time.deltaTime);
            }
            else
            {
                transform.RotateAround(sunTransform.position, Vector3.right, verticalInput * rotationSpeed * Time.deltaTime);
            }
        }
    }
}
