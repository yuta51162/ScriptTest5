using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // �v�f��5�̔z�������������
        int[] points = new int[5];

        // �z��̊e�v�f�ɍD���Ȓl��������
        points[0] = 10;
        points[1] = 20;
        points[2] = 30;
        points[3] = 40;
        points[4] = 50;

        // �z��̗v�f�����ׂĕ\������
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}