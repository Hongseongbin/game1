using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ratator : MonoBehaviour
{
    public float rotationSpeed = 30f;

    void Update()
    {
        /* �׳� ��(rotationSpeed)�� �����ϸ� ������ ���� �ӵ��� ȸ����
         �̰��� �ʴ� �������� 60�̶�� �������� ��, 
        60�� ����Ǵ� Update()���� 60���� ȸ���ϱ� ������. 
        
         ���� 1�ʿ� 60���� ȸ����Ű�⸦ ���Ѵٸ� 
        ���� �ʴ������ӿ� ������ ���� ���� Time.deltaTime�� �����ָ� ��. 
        �̴� �ʴ� �������� ���� �ٸ� pc�� ������ �� �־ ���� */

        transform.Rotate(0,rotationSpeed * Time.deltaTime,0);
    }
}
