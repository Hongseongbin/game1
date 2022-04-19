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

}
