using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour {
    private bool canRotate = true;
    private Quaternion startingRotation;
    private ControlManager controlManager;

    public float rotateSpeed = 10.0f;
    public GameObject controlManagerObject;

    void Start() {
        startingRotation = transform.rotation;
        controlManager = new ObjectComponent<ControlManager>(controlManagerObject).comp;
    }

    // Update is called once per frame
    void Update() {
        if (controlManager.currentControl == Controls.MoveCamera) {
            float h = Input.GetAxisRaw("Horizontal");

            if (h != 0 && canRotate) {
                canRotate = false;
                StopAllCoroutines();
                StartCoroutine(Rotate(h));
            }
        }
    }

    IEnumerator Rotate(float direction) {
        float rotateBy = direction > 0 ? -90 : 90;
        Quaternion finalRotation = Quaternion.Euler(0, rotateBy, 0) * startingRotation;

        while (transform.rotation != finalRotation) {
            transform.rotation = Quaternion.Lerp(transform.rotation, finalRotation, Time.deltaTime * rotateSpeed);
            yield return null;
        }

        transform.rotation = finalRotation;
        startingRotation = finalRotation;
        canRotate = true;
        StopAllCoroutines();
    }
}
