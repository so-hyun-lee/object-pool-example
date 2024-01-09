using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    List<Bullet> bullets = new List<Bullet>();
    Queue<Bullet> bulletsQueue = new Queue<Bullet>();
    Stack<Bullet> bulletsStack = new Stack<Bullet>();

    //Bullet Pool에서 사용할 수 있는 총알을 반환하는 메서드
    public Bullet GetBullet()
    {
        if (bullets.Count > 0)
        {
            //Bullet bullet = bullets[0];
            //bullets.RemoveAt(0); //인덱스의 0번을 지운것 bullet을 지운것 x

            Bullet bullet= bulletsQueue.Dequeue(); //queue불러오는법

            bullet.gameObject.SetActive(true);
            return bullet;  //값을 할당한 변수를 리턴해야함
        }
        return null;
    }

    //더이상 사용되지 않는 총알을 Bullet Pool에 추가하는 메서드
    public void AddBullet(Bullet bullet)
    {
        bullets.Add(bullet);
    }
}
