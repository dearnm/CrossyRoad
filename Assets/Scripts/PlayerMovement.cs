using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveDistance = 1f;  // 플레이어가 한 번에 이동할 거리

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            MovePlayer(Vector3.forward);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            MovePlayer(Vector3.back);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow))
        {
            MovePlayer(Vector3.left);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && !Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow))
        {
            MovePlayer(Vector3.right);
        }
    }

    void MovePlayer(Vector3 direction)
    {
        transform.position += direction * moveDistance;
    }
}
