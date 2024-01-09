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
        GameObject panelObject = Instantiate(panelPrefab, parent);//새로운 창 정보
        panelStack.Push(panelObject); //패널 스택에 패널 오브젝트를 푸쉬

        panelObject.transform.localScale = Vector3.zero;
        panelObject.transform.DOScale(1, 0.2f); //커질 크기, 커지는 시간

        Panel panel = panelObject.GetComponent<Panel>(); //패널변수를 만들어서 패널 오브젝트 컴포넌트 할당
        panel.IndexText = panelStack.Count; //패널 스택의 카운트를 사용 ***패널 스택에 푸쉬한 이후에 사용해야함***
        panel.manager = this; //매니저 할당
        panel.ChangeColor(colors[Random.Range(0,3)]);   //색상 할당

    }

    public void Close()
    {
        GameObject lastPanelObject = panelStack.Pop(); //스택에서 나오면서 스택에서 삭제
        lastPanelObject.transform.DOScale(0, 0.2f).OnComplete(() =>   //람다식: 함수를 매개변수로 전달받음
        {
            Destroy(lastPanelObject); //나온걸 삭제
        });
        
    }
}
