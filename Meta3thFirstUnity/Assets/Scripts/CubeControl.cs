using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    private float rotationSpeed = 200.0f; //퍼블릭을 달아주면 인스펙터 창에 보인다.
    private Vector3 cubeRotation = Vector3.zero; //Vector3.zero 0으로 준 ㅓㄳ?
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("이게 Unity의 Hello World!");

        transform.Rotate(0f, 0f, 0f);
        //gameObject 
        // transform 안에는 게임 오브젝트가 있어   즉 모든 트랜스 폼은 게임 오브젝트를 들고 있다. 서로 동일한 것이다.
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log("이것도 어디선가 부르고 있다.");
        cubeRotation.y = (rotationSpeed * Time.deltaTime);
        transform.Rotate(cubeRotation);
    }
}
