using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Base class for all animals
public abstract class Animal : MonoBehaviour
{
    protected Rigidbody animalRb;
    protected float jumpForce;
    protected bool spinning;

    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        animalRb = GetComponent<Rigidbody>();
        spinning = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (spinning)
        {
            // I'll try spinning, that's a good trick!
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }

    protected abstract void Speak();

    protected void Spin()
    {
        // Spin animal on y-axis
        spinning = true;
    }
}
