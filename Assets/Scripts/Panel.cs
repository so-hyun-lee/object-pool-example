using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    [SerializeField] private TMP_Text indexText;
    [SerializeField] private Image image; //패널클래스에서 이미지를 사용함 

    
    public PanelManager manager;
    public int index;

    public int IndexText 
    { 
        get //읽어올 때
        {
            return index;
        }
        set //할당할 떄
        {
            index = value;
            indexText.text = index.ToString();
        } 
    }


    /// <summary>
    /// Open 버튼 클릭시에 호출됨
    /// </summary>
    public void Open()
    {
        manager.Open();
    }
    /// <summary>
    /// previous 클릭시에 호출됨
    /// </summary>
    public void Close() 
    {
        manager.Close();
    } 

    /// <summary>
    /// 패널의 색상 변경
    /// </summary>
    /// <param name="color">변경할 색상</param>
    public void ChangeColor(Color color) 
    {
        image.color = color;
    }
}
