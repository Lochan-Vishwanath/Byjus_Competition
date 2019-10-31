using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAtoB : MonoBehaviour
{
    [SerializeField] GameObject A, B;
    Vector3 target,rotationSpeed;
    [SerializeField] float speed = 1f,rotateSpeed=-3f;

    private void Start()
    {
        transform.position = A.transform.position;
        target = B.transform.position;
        rotationSpeed = new Vector3(0,0,rotateSpeed);
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        transform.Rotate(rotationSpeed);

        if (transform.position == B.transform.position) target = A.transform.position;
        else if (transform.position == A.transform.position) target = B.transform.position;
    }
}
