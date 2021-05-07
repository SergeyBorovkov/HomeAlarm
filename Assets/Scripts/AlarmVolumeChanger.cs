using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AlarmVolumeChanger : MonoBehaviour
{
    private AudioSource _audioSource;    

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();           
    }   

    private void FixedUpdate()
    {
        if (_audioSource.volume == 0)        
            _audioSource.DOFade(1, 1);                    
        else if (_audioSource.volume == 1)        
            _audioSource.DOFade(0, 1);        
    } 
}
