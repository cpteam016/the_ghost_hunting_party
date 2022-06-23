using System;
using UnityEngine;

namespace Andi_Scripts.Audio
{
    public class PlaySoundOnStart : MonoBehaviour
    {
        [SerializeField] private AudioClip _clip;

        private void Start()
        {
            SoundManager.instance.PlaySound(_clip);
        }
    }
}