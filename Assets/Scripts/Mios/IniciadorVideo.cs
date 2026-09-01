using UnityEngine;
using UnityEngine.Video;

public class IniciadorVideo : MonoBehaviour
{
    void Start()
    {
        // Pausa el video automáticamente en cuanto arranca el nivel
        GetComponent<VideoPlayer>().Stop();
    }
}