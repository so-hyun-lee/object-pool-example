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
            this.gameObject.SetActive(false); //�ð������� ��Ȱ
        }
    }

    public void Shoot()
    {
        rb.AddForce(transform.forward * force); //�ܺο��� ȣ��ÿ� �߻�
    }

    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.SetActive(false);    
    }
    private void OnEnable()
    {
        this.transform.position = Vector3.zero; //0�� ��ġ�� �ڽ��� ��ġ�ϱ�
    }
    private void OnDisable() 
    {
        this.time = 0; //��Ȱ��ȭ �� �� 0���� �ʱ�ȭ
        rb.velocity = Vector3.zero;

        bulletPool.AddBullet(this);
    }
}
