using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManger : MonoBehaviour
{
    public float leftLimit = 0.0f;      // 왼쪽 스크롤 제한
    public float rightLimit = 0.0f;     // 오른쪽 스크롤 제한 
    public float topLimit = 0.0f;       // 위 스크롤 제한 
    public float bottomLimit = 0.0f;    // 아래 스크롤 제한

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player"); // 플레이어 찾기
        if (player != null)
        {
            // 카메라의 좌표 갱신
            float x = player.transform.position.x;
            float y = player.transform.position.y;
            float z = transform.position.z;

            // 양 끝에 이동 제한 적용
            if (x < leftLimit)
            {
                x = leftLimit;
            }
            else if (x > rightLimit)
            {
                x = rightLimit;
            }

            // 위 아래에 이동 제한 적용
            if (y < bottomLimit)
            {
                y = bottomLimit;
            }
            else if (y > topLimit)
            {
                y = topLimit;
            }
            Vector3 v = new Vector3(x, y, z);
            transform.position = v;
        }
    }
}
