using System;
using UnityEngine;

[Serializable]
public class FreezeSettings : MonoBehaviour
{
    public void SetTimeScale(bool value)
    {
        Time.timeScale = value ? 1f : 0f;
    }
}