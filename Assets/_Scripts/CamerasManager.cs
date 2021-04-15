using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerasManager : MonoBehaviour
{
    public static CamerasManager S;

    public CinemachineFreeLook OrbitalCam;
    public CinemachineFreeLook SelectionCam;

    [HideInInspector] public bool IsFollowing;

    private void Awake()
    {
        S = this;
    }

    private void Update()
    {
        bool isPlayerPressingCameraButton = Input.GetMouseButton(1);

        int horizontalSpeed = isPlayerPressingCameraButton ? 100 : 0;
        int verticalSpeed = isPlayerPressingCameraButton ? 1 : 0;

        OrbitalCam.m_XAxis.m_MaxSpeed = SelectionCam.m_XAxis.m_MaxSpeed = horizontalSpeed;
        OrbitalCam.m_YAxis.m_MaxSpeed = SelectionCam.m_YAxis.m_MaxSpeed = verticalSpeed;
    }

    public void FollowTarget(Transform target)
    {
        SelectionCam.Follow = SelectionCam.LookAt = target;
        SelectionCam.Priority = 10;
        Invoke(nameof(SetIsFollow), .1f * Time.timeScale);
    }

    private void SetIsFollow()
    {
        IsFollowing = true;
    }

    public void UnfollowTarget()
    {
        //Debug.Log("UnfollowTarget");
        SelectionCam.Priority = 0;
        IsFollowing = false;
    }
}
