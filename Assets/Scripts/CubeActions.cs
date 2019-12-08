using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeActions : MonoBehaviour
{
    public GameObject terrianObject;
    private Renderer terrianObjRenderer;
    private Shader outlineShader;
    private Shader defaultShader;

    // Start is called before the first frame update
    void Start()
    {
        terrianObjRenderer = terrianObject.GetComponent<Renderer>();
        outlineShader = Shader.Find("Custom/OutlineShader");
        defaultShader = terrianObjRenderer.material.shader;
    }

    private void OnMouseOver() {
        setCustomOutlineShader();
    }

    private void OnMouseExit() {
        resetToDefaultShader();
    }

    public void setCustomOutlineShader() {
        terrianObjRenderer.material.shader = outlineShader;
    }

    public void resetToDefaultShader() {
        terrianObjRenderer.material.shader = defaultShader;
    }
}
