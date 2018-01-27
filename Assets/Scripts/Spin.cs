using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour
{
    public float speed = 10f;
    public Vector3 RotateAmount;

    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
        transform.Rotate(RotateAmount * Time.deltaTime);
    }
}