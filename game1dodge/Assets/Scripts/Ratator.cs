using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ratator : MonoBehaviour
{
    public float rotationSpeed = 30f;

    void Update()
    {
        /* 그냥 값(rotationSpeed)만 설정하면 굉장히 빠른 속도로 회전함
         이것은 초당 프레임이 60이라고 가정했을 때, 
        60번 실행되는 Update()마다 60도씩 회전하기 때문임. 
        
         따라서 1초에 60도로 회전시키기를 원한다면 
        값에 초당프레임에 역수를 취한 값인 Time.deltaTime을 곱해주면 됨. 
        이는 초당 프레임이 각각 다른 pc에 적용할 수 있어서 유용 */

        transform.Rotate(0,rotationSpeed * Time.deltaTime,0);
    }
}
