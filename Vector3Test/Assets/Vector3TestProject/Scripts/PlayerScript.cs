using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{


    private Rigidbody playerRigid = default;



    // 1-1.계산식 만들고 여기서 움직이게 만들거임
    // 1-2.상대 오브젝트 만들어서 상대가 나를 정면으로 돌격하게 하면서 공격할거임
    // 1-3.이제 내가 원하는곳에 상대를 둘것이고 Debug.Log로 계산식대로 **에서 때림 이런식으로 출력하게 만들거임

    // 2-1.내가 원하는 대로 된다면 상대한테 무기를 쥐어줄것이고 앞으로 때렸는지 뒤로 때렸는지 해볼거임
    // 2.2. 이것도 되었다면 내가 상대를 공격할수 있게 만들것이고 그뒤에 상대가 어디맞았는지 나타낼거임

    // 3-1. 위에 오브젝트에대한 방향을을 구할수 있게된다면 건물을 짓고 오브젝트가 건물 안에있는지 밖에 있는지 테스트



    // Start is called before the first frame update
    void Start()
    {
        //컴포넌트로 넣은 오브젝트에서 Rigidbody 가 있으면 가져오도록 하기
        playerRigid = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {




    }
}
