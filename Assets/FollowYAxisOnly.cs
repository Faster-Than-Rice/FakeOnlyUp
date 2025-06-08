using UnityEngine;

public class FollowYAxisOnly : MonoBehaviour
{
    public Transform target;  // 追従する対象
    public float smoothSpeed = 0.125f;  // スムーズに追従するための速度

    private void LateUpdate()
    {
        if (target == null) return;

        Vector3 currentPosition = transform.position;
        float targetY = target.position.y;

        // Y軸だけターゲットに追従し、XとZは現在のまま
        Vector3 desiredPosition = new Vector3(currentPosition.x, targetY, currentPosition.z);

        // スムーズに追従（必要に応じて）
        transform.position = Vector3.Lerp(currentPosition, desiredPosition, smoothSpeed);
    }
}

