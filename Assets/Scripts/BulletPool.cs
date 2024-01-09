using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    List<Bullet> bullets = new List<Bullet>();
    Queue<Bullet> bulletsQueue = new Queue<Bullet>();
    Stack<Bullet> bulletsStack = new Stack<Bullet>();

    //Bullet Pool���� ����� �� �ִ� �Ѿ��� ��ȯ�ϴ� �޼���
    public Bullet GetBullet()
    {
        if (bullets.Count > 0)
        {
            //Bullet bullet = bullets[0];
            //bullets.RemoveAt(0); //�ε����� 0���� ����� bullet�� ����� x

            Bullet bullet= bulletsQueue.Dequeue(); //queue�ҷ����¹�

            bullet.gameObject.SetActive(true);
            return bullet;  //���� �Ҵ��� ������ �����ؾ���
        }
        return null;
    }

    //���̻� ������ �ʴ� �Ѿ��� Bullet Pool�� �߰��ϴ� �޼���
    public void AddBullet(Bullet bullet)
    {
        bullets.Add(bullet);
    }
}
