using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public Rigidbody bulletRigid;
    void Start()
    {
        bulletRigid = GetComponent<Rigidbody>();
        speed = 8f;
        //���ӿ�����Ʈ�� ���ʹ���
        bulletRigid.velocity = transform.forward * speed;

        //~��~(�ð�)�Ŀ�
        Destroy(gameObject, 3f);
    }


    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PlayerController playerController = GetComponent<PlayerController>();

            //�Ǽ�������� �ڵ带 �߰��ϰ� ����(�浹��뿡 PlayerController�� ������� ����)
            if(playerController != null)
            {
                playerController.Die();
            }

        }
    }
}
