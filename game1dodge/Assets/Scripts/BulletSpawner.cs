using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    //탄알생성기
public class BulletSpawner : MonoBehaviour
{
    //탄알
    public GameObject bulletPrefab;
    //탄알생성주기(최소-최대)
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 3f;
     
    //탄알을 맞출 대상(의 위치)
    private Transform target;
    //탄알생성주기(최소-최대 사이의 랜덤값)
    private float spawnRate;
    //최근생성시점에서 지난 시간 (점수체크용 타이머)
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
