using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Bullet bulletPrefab;
    [SerializeField] private BulletPool bulletPool;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Bullet bullet = bulletPool.GetBullet();
            if(bullet != null)
            {
                bullet.Shoot();
            }
            else
            {
                Bullet newBullet = Instantiate(bulletPrefab, Vector3.zero, Quaternion.identity);
                newBullet.bulletPool = bulletPool;
                newBullet.Shoot();
            }


        }
    }
}
