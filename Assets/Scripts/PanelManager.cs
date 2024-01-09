using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using DG.Tweening;

public class PanelManager : MonoBehaviour
{
    [SerializeField] GameObject panelPrefab;
    [SerializeField] Transform parent;

    Stack<GameObject> panelStack = new Stack<GameObject>();  

    int panelCount = 0;
    Color[] colors = new Color[4] { Color.black, Color.blue, Color.yellow, Color.green };

    public void Open()
    {
        GameObject panelObject = Instantiate(panelPrefab, parent);//���ο� â ����
        panelStack.Push(panelObject); //�г� ���ÿ� �г� ������Ʈ�� Ǫ��

        panelObject.transform.localScale = Vector3.zero;
        panelObject.transform.DOScale(1, 0.2f); //Ŀ�� ũ��, Ŀ���� �ð�

        Panel panel = panelObject.GetComponent<Panel>(); //�гκ����� ���� �г� ������Ʈ ������Ʈ �Ҵ�
        panel.IndexText = panelStack.Count; //�г� ������ ī��Ʈ�� ��� ***�г� ���ÿ� Ǫ���� ���Ŀ� ����ؾ���***
        panel.manager = this; //�Ŵ��� �Ҵ�
        panel.ChangeColor(colors[Random.Range(0,3)]);   //���� �Ҵ�

    }

    public void Close()
    {
        GameObject lastPanelObject = panelStack.Pop(); //���ÿ��� �����鼭 ���ÿ��� ����
        lastPanelObject.transform.DOScale(0, 0.2f).OnComplete(() =>   //���ٽ�: �Լ��� �Ű������� ���޹���
        {
            Destroy(lastPanelObject); //���°� ����
        });
        
    }
}
