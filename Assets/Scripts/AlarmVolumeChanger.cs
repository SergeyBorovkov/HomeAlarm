using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent (typeof (AudioSource))]

public class AlarmVolumeChanger : MonoBehaviour
{
    private AudioSource _audioSource;

    private float _targetVolume = 0;
    private float _volumeStep = 0.8f;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();           
    }   

    private void Update()
    {
        if (_audioSource.volume == 0)        
            _targetVolume = 1;        

        if (_audioSource.volume == 1)        
            _targetVolume = 0;        

        if (_audioSource.isPlaying)        
            _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, _targetVolume, _volumeStep*Time.deltaTime);                    
    } 
}
