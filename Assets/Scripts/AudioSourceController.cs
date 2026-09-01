using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceController : MonoBehaviour
{
    public GameObject planoAudio;
    public AudioSource audioSource; // Asegúrate de agregar un AudioSource
    public AudioClip audioClip; // Asigna el clip de audio en el inspector

    private void Start()
    {
        // Asegúrate de que el clip de audio esté asignado
        if (audioClip == null)
        {
            Debug.LogError("AudioClip no asignado en el inspector.");
            return;
        }

        // Pausa el video y configura el clip de audio al inicio
        audioSource.clip = audioClip;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Comprueba si el objeto de interacción ha entrado en contacto
        if (other.gameObject.CompareTag("Player"))
        {
            // Reproduce el video y el audio cuando el objeto de interacción toca
            audioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Comprueba si el objeto de interacción ha salido de contacto
        if (other.gameObject.CompareTag("Player"))
        {
            // Detiene el video y el audio cuando el objeto de interacción deja e
            audioSource.Stop();
        }
    }
}