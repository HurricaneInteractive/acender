using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour {
    public GameObject terrain;
    public float moveSpeed = 10.0f;
    public float rotateSpeed = 10.0f;

    // Update is called once per frame
    void Update() {
        float h = Input.GetAxis("Horizontal") * moveSpeed;
        transform.RotateAround(terrain.transform.position, Vector3.up, rotateSpeed * (h * -1) * Time.fixedDeltaTime);
    }
}
