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
        //게임오브젝트의 앞쪽방향
        bulletRigid.velocity = transform.forward * speed;

        //~를~(시간)후에
        Destroy(gameObject, 3f);
    }


    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PlayerController playerController = GetComponent<PlayerController>();

            //실수를대비해 코드를 견고하게 만듦(충돌상대에 PlayerController가 없을경우 에러)
            if(playerController != null)
            {
                playerController.Die();
            }

        }
    }
}
