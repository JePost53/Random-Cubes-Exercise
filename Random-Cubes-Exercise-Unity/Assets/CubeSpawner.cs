using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public float minSize;
    public float maxSize;
    public float lifeTime;
    public float forceMax;
    public Color cubeColor;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject cubeClone = Instantiate(cubePrefab);
        cubeClone.transform.position = transform.position;
        cubeClone.GetComponent<Renderer>().material.color = cubeColor; //Random.ColorHSV(0, 1, 0.5f, 1, 0.75f, 1);
        float randomSize = Random.Range(minSize, maxSize);
        cubeClone.transform.localScale = new Vector3(randomSize, randomSize, randomSize);
        cubeClone.GetComponent<Rigidbody>().AddForce(transform.up * forceMax, ForceMode.Impulse);
        Object.Destroy(cubeClone, lifeTime);
    }
}
