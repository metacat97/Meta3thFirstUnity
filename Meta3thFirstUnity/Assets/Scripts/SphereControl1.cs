using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl1 : MonoBehaviour
{
    public GameObject targetCube = default;

    private float sphereSpeed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(targetCube.transform.position, Vector3.right, sphereSpeed * Time.deltaTime);
    }
}
