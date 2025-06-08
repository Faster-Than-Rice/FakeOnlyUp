using UnityEngine;

public class FollowYAxisOnly : MonoBehaviour
{
    public Transform target;  // �Ǐ]����Ώ�
    public float smoothSpeed = 0.125f;  // �X���[�Y�ɒǏ]���邽�߂̑��x

    private void LateUpdate()
    {
        if (target == null) return;

        Vector3 currentPosition = transform.position;
        float targetY = target.position.y;

        // Y�������^�[�Q�b�g�ɒǏ]���AX��Z�͌��݂̂܂�
        Vector3 desiredPosition = new Vector3(currentPosition.x, targetY, currentPosition.z);

        // �X���[�Y�ɒǏ]�i�K�v�ɉ����āj
        transform.position = Vector3.Lerp(currentPosition, desiredPosition, smoothSpeed);
    }
}

