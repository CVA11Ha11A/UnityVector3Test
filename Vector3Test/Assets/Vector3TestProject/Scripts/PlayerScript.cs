using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{


    private Rigidbody playerRigid = default;



    // 1-1.���� ����� ���⼭ �����̰� �������
    // 1-2.��� ������Ʈ ���� ��밡 ���� �������� �����ϰ� �ϸ鼭 �����Ұ���
    // 1-3.���� ���� ���ϴ°��� ��븦 �Ѱ��̰� Debug.Log�� ���Ĵ�� **���� ���� �̷������� ����ϰ� �������

    // 2-1.���� ���ϴ� ��� �ȴٸ� ������� ���⸦ ����ٰ��̰� ������ ���ȴ��� �ڷ� ���ȴ��� �غ�����
    // 2.2. �̰͵� �Ǿ��ٸ� ���� ��븦 �����Ҽ� �ְ� ������̰� �׵ڿ� ��밡 ���¾Ҵ��� ��Ÿ������

    // 3-1. ���� ������Ʈ������ �������� ���Ҽ� �ְԵȴٸ� �ǹ��� ���� ������Ʈ�� �ǹ� �ȿ��ִ��� �ۿ� �ִ��� �׽�Ʈ



    // Start is called before the first frame update
    void Start()
    {
        //������Ʈ�� ���� ������Ʈ���� Rigidbody �� ������ ���������� �ϱ�
        playerRigid = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {




    }
}
