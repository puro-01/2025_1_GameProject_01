using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VasicVariables : UnityEngine.MonoBehaviour
{
    private readonly object it;
    public int gold = 0;                       //������
    public float Hp = 100.0f;                  //�Ǽ��� (�Ҽ����� �ִ� ����, ���� 'f' �ʼ�)
    public string playerName = "ȫ�浿";       //���ڿ� (������ ����)
    public bool isAlive = true;                //���� (��/������ ��Ÿ��)
    private object iterator;


    // Start is called before the first frame update
    void Start()
    {
        // == �� ���� ���� �� true
        // != �� ���� �ٸ��� true
        // > ���� ���� �� ũ�� true
        // < ������ ���� ũ�ų� ������ true
        // >= ���� ���� ũ�ų� ������ true
        // <= ������ ���� ũ�ų� ������ true
        if (gold > 50)
        {
            Debug.Log("�������� ������ �� �ֽ��ϴ�.");
        }
        else if (gold == 40) //if�ȿ� ������ ���� �ƴ� �� �� ������ ���̶�� 
        {
            Debug.Log("��尡 40�� ���� �� �Դϴ�. 10��� �� ������ �� �� �־��!");
        }
        //else //if ���� ������ ���� �ƴ� ��
        //{
        //     Debug.Log("��尡 �����մϴ�.");
        //}
    }

}