using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinemachineShake : MonoBehaviour
{
    public static CinemachineShake Instance { get; private set; }


    private CinemachineVirtualCamera cinemachineVirtualCamera;
    private  CinemachineFreeLook cinemachineFreelookCamera;
    private float shakeTimer;
    private float shakeTimerTotal;
    private float startingIntensity;
    public bool isFreelook;
    

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
        if(isFreelook)
        {
            cinemachineFreelookCamera = GetComponent<CinemachineFreeLook>();
        }
        else
        {
            cinemachineVirtualCamera = GetComponent<CinemachineVirtualCamera>();
        }
        
    }

    public void ShakeCamera(float intensity, float time)
    {
        if(isFreelook)
        {
            CinemachineBasicMultiChannelPerlin perlinFreeLook =
                        cinemachineFreelookCamera.GetRig(1).GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

            perlinFreeLook.m_AmplitudeGain = intensity;
        }
        else
        {
            CinemachineBasicMultiChannelPerlin perlin =
                        cinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

            perlin.m_AmplitudeGain = intensity;
        }

        startingIntensity = intensity;
        shakeTimerTotal = time;
        shakeTimer = time;

    }

    private void Update()
    {

        if (shakeTimer > 0f)
        {
            shakeTimer -= Time.deltaTime;
            if (shakeTimer <= 0f)
            {
                if (isFreelook)
                {
                    CinemachineBasicMultiChannelPerlin erli =
                                cinemachineFreelookCamera.GetRig(1).GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

                    erli.m_AmplitudeGain = 0f;
                }
                else
                {
                    CinemachineBasicMultiChannelPerlin erli =
                                cinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

                    erli.m_AmplitudeGain = 0f;
                }
                
            }
        }


    }
}
