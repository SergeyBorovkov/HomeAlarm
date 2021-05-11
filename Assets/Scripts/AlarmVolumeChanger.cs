using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


[RequireComponent (typeof (AudioSource))]

public class AlarmVolumeChanger : MonoBehaviour
{
    private AudioSource _audioSource;    

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();           
    }   

    private void Update()
    {
        if (_audioSource.volume == 0 && _audioSource.isPlaying)        
            _audioSource.DOFade(1, 1);                    
        else if (_audioSource.volume == 1 && _audioSource.isPlaying)        
            _audioSource.DOFade(0, 1);        
    } 
}
