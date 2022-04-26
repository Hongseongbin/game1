using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    //�����ѽð��ֱ⸶�� �Ѿ� �ڵ�����
    public GameObject bulletPrefab;
    public float bulletRateMin = 0.5f;
    public float bulletRateMax = 3f;

    private Transform target;
    private float bulletRate;
    private float timeAfterRate;

    private void Start()
    {
        timeAfterRate = 0;
        target = FindObjectOfType<PlayerController>().transform;
        bulletRate = Random.Range(bulletRateMin, bulletRateMax);
    
    }

    private void Update()
    {
        timeAfterRate += Time.deltaTime;

        if (timeAfterRate >= bulletRate)
        {
            timeAfterRate = 0;

            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            //transform > ������� ��ġ, ������� ȸ��
            bullet.transform.LookAt(target);

            
            bulletRate = Random.Range(bulletRateMin, bulletRateMax);
        }
    }
}
