using UnityEngine;
using TMPro;

public class AltitudeDisplay : MonoBehaviour
{
    [Header("�ΏۂƂȂ�I�u�W�F�N�g")]
    public Transform target; // �����𑪂�Ώ�

    [Header("��n�_")]
    public Transform referencePoint; // �����̊�ƂȂ�n�_

    [Header("�\���p�e�L�X�g")]
    public TextMeshProUGUI altitudeText; // �\���p�� TextMeshPro UGUI

    void Update()
    {
        if (target == null || referencePoint == null || altitudeText == null)
            return;

        float altitude = Mathf.Clamp(target.position.y - referencePoint.position.y, 0, float.PositiveInfinity);
        altitudeText.text = $" {altitude:F1} m";
    }
}