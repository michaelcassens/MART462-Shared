using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    //Rotate Variables
    public GameObject target;
    public float spinSpeed = 20.0f;
    public float rotateSpeed = 10.0f * Time.deltaTime;

    //Color Variables
    public float colorDelay = 2.0f;

    //Scale Variables
    public float growDelay = 2.0f;
    public float originalSize = 1.3f;

    void Start()
    {
        transform.position = new Vector3(3, 4, 1);

        InvokeRepeating("GoChamaleon", colorDelay, colorDelay);

        InvokeRepeating("GrowingShrinking", growDelay, growDelay);
    }
    
    void Update()
    {
        transform.Rotate(rotateSpeed * Time.deltaTime, rotateSpeed, rotateSpeed);

        //Rotates cube around rotatePoint game object
        transform.RotateAround(target.transform.position, Vector3.up, spinSpeed * Time.deltaTime);
    }
    void GoChamaleon()
    {
        Material material = Renderer.material;
        material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

    void GrowingShrinking()
    {
        originalSize = Random.Range(1, 5);
        transform.localScale = Vector3.one * originalSize;
    }
}
