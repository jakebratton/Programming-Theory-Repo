using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Base class for all animals - INHERITANCE
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
            // I'll try spinning, that's a good trick! ----- NOT WORKING RIGHT NOW
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }

    protected abstract void Speak();

    protected void Spin()
    {
        // Spin animal on y-axis
        Debug.Log("I'll try spinning, that's a good trick!");
        Debug.Log("Rotation speed: " + rotationSpeed);
        spinning = true;
        StartCoroutine(ForSpinning());
    }

    private void OnMouseDown()
    {
        Speak();
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Abstraction
            Speak();
        } else if (Input.GetMouseButtonDown(1))
        {
            // Abstraction
            Spin();
        }
    }

    private IEnumerator ForSpinning()
    {
        yield return new WaitForSeconds(2);
        spinning = false;
    }
}
