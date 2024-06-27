using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private float horizontal;
    private float vertical;
    public Rigidbody rb;
    public float force = 10;
    

    // Update is called once per frame
    void Update()
    {
        
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * Time.deltaTime * vertical, Space.Self );
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontal, Space.Self );
        transform.Rotate(Vector3.up * speed * Time.deltaTime * horizontal);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb = GetComponent<Rigidbody>();
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
        

    }
}
