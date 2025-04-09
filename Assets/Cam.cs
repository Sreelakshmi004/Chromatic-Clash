using UnityEngine;

public class Cam : MonoBehaviour
{
    public float offset;
    public Transform playertransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 campos=transform.position;
        campos.z = playertransform.position.z + offset;
        transform.position = campos;
    }
}
