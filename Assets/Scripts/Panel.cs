using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    [SerializeField] private TMP_Text indexText;
    [SerializeField] private Image image; //�г�Ŭ�������� �̹����� ����� 

    
    public PanelManager manager;
    public int index;

    public int IndexText 
    { 
        get //�о�� ��
        {
            return index;
        }
        set //�Ҵ��� ��
        {
            index = value;
            indexText.text = index.ToString();
        } 
    }


    /// <summary>
    /// Open ��ư Ŭ���ÿ� ȣ���
    /// </summary>
    public void Open()
    {
        manager.Open();
    }
    /// <summary>
    /// previous Ŭ���ÿ� ȣ���
    /// </summary>
    public void Close() 
    {
        manager.Close();
    } 

    /// <summary>
    /// �г��� ���� ����
    /// </summary>
    /// <param name="color">������ ����</param>
    public void ChangeColor(Color color) 
    {
        image.color = color;
    }
}
