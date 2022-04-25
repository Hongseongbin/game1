using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    //ź�˻�����
public class BulletSpawner : MonoBehaviour
{
    //ź��
    public GameObject bulletPrefab;
    //ź�˻����ֱ�(�ּ�-�ִ�)
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 3f;
     
    //ź���� ���� ���(�� ��ġ)
    private Transform target;
    //ź�˻����ֱ�(�ּ�-�ִ� ������ ������)
    private float spawnRate;
    //�ֱٻ����������� ���� �ð� (����üũ�� Ÿ�̸�)
    private float timeAfterSpawn;

    private void Start()
    {
        timeAfterSpawn = 0;
        spawnRate = Random.Range(spawnRateMin, spawnRateMax); 
        //target =  FindObjectOfType<PlayerController>().transform;
        target = FindObjectOfType<PlayerController>().transform;
    }

    private void Update()
    {

        timeAfterSpawn = 0f;

        GameObject bullet = Instantiate(bulletPrefab,transform.position, transform.rotation);

        bullet.transform.LookAt(target);

        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
    }
}
