using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonMaterial : MonoBehaviour
{
    [SerializeField] Material moonLit;
    private Renderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<Renderer>();
        meshRenderer.material = moonLit;
        moonLit.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.rotation.z < 50f && transform.rotation.z > 45f)
        {
            Debug.Log("Black");
            float color = Mathf.Lerp(0, 255, (transform.localRotation.z - 45) / 5);
            moonLit.color = new Color(color, color, color, 255);
        }    
        if (transform.rotation.z <= 35f && transform.rotation.z > 31f)
        {
            Debug.Log("getting whiter");
            float color = Mathf.Lerp(255, 0, (transform.localRotation.z - 31) / 4);
            moonLit.color = new Color(color, color, color, 255);
        }
    }
}
