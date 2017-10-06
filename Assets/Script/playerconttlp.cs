using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerconttlp : MonoBehaviour
{

    [SerializeField]
    private float movement = 3f;
    [SerializeField]
    private float rotateSpeed = 2f;
    float moveX = 0f, moveZ = 0f;
    Rigidbody rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * Time.deltaTime * movement;
        moveZ = Input.GetAxis("Vertical") * Time.deltaTime * movement;
        Vector3 direction = new Vector3(moveX, 0, moveZ);
        if (direction.magnitude > 0.01f)
        {
            float step = rotateSpeed * Time.deltaTime;
            Quaternion myQ = Quaternion.LookRotation(direction);
            this.transform.rotation = Quaternion.Lerp(transform.rotation, myQ, step);
        }
    }
}
