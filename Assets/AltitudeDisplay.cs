using UnityEngine;
using TMPro;

public class AltitudeDisplay : MonoBehaviour
{
    [Header("対象となるオブジェクト")]
    public Transform target; // 高さを測る対象

    [Header("基準地点")]
    public Transform referencePoint; // 高さの基準となる地点

    [Header("表示用テキスト")]
    public TextMeshProUGUI altitudeText; // 表示用の TextMeshPro UGUI

    void Update()
    {
        if (target == null || referencePoint == null || altitudeText == null)
            return;

        float altitude = Mathf.Clamp(target.position.y - referencePoint.position.y, 0, float.PositiveInfinity);
        altitudeText.text = $" {altitude:F1} m";
    }
}