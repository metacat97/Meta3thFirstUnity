using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    private float rotationSpeed = 200.0f; //�ۺ��� �޾��ָ� �ν����� â�� ���δ�.
    private Vector3 cubeRotation = Vector3.zero; //Vector3.zero 0���� �� �ä�?
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("�̰� Unity�� Hello World!");

        transform.Rotate(0f, 0f, 0f);
        //gameObject 
        // transform �ȿ��� ���� ������Ʈ�� �־�   �� ��� Ʈ���� ���� ���� ������Ʈ�� ��� �ִ�. ���� ������ ���̴�.
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log("�̰͵� ��𼱰� �θ��� �ִ�.");
        cubeRotation.y = (rotationSpeed * Time.deltaTime);
        transform.Rotate(cubeRotation);
    }
}
