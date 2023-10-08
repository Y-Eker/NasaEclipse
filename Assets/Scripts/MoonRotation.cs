using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonRotation : MonoBehaviour
{
    [Header("Referances")]
    [SerializeField] Transform earthTransform;
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
        // transform.position = earthTransform.position + (transform.position - earthTransform.position).normalized * orbitDistance;
        if (Input.GetKey(KeyCode.P))
        {
            movementInput = 1;
        }
        else if (Input.GetKey(KeyCode.O)) 
        {
            movementInput = -1;
        }
        else { movementInput = 0; }
        if (movementInput == 0)
        {
            transform.RotateAround(earthTransform.position, Vector3.right, idleRotationSpeed * Time.deltaTime);
        }
        else
        {
            transform.RotateAround(earthTransform.position, Vector3.right, movementInput * rotationSpeed * Time.deltaTime);
        }
    }
}
