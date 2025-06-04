using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFollowCamera : MonoBehaviour
{
    public Transform cameraTransform;       // VRカメラ
    public float distanceFromCamera = 1.0f; // カメラからの距離

    void LateUpdate()
    {
        if (cameraTransform == null) return;

        // カメラの前方に位置をセット
        Vector3 targetPosition = cameraTransform.position + cameraTransform.forward * distanceFromCamera;
        transform.position = targetPosition;

        // LookAt：UIをカメラの方向に向ける
        transform.LookAt(cameraTransform);
        
        // UIが裏向きに見える場合は180度回転させる
        transform.Rotate(0, 180f, 0);
    }
}

