using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Bullet : MonoBehaviour
{
    public BulletPool bulletPool;
   

    float force = 1000.0f;
    Rigidbody rb;
    float killTime = 3;
    float time = 0;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        time += Time.deltaTime;
        if (time > killTime)
        {
            this.gameObject.SetActive(false); //시간지나면 비활
        }
    }

    public void Shoot()
    {
        rb.AddForce(transform.forward * force); //외부에서 호출시에 발사
    }

    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.SetActive(false);    
    }
    private void OnEnable()
    {
        this.transform.position = Vector3.zero; //0의 위치에 자신을 위치하기
    }
    private void OnDisable() 
    {
        this.time = 0; //비활성화 될 때 0으로 초기화
        rb.velocity = Vector3.zero;

        bulletPool.AddBullet(this);
    }
}
