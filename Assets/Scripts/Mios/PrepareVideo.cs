using UnityEngine;
using UnityEngine.Video;

public class PreparadorVideo : MonoBehaviour
{
    void Start()
    {
        // Obliga al motor a decodificar el video en RAM al iniciar el nivel sin reproducirlo
        GetComponent<VideoPlayer>().Prepare();
    }
}