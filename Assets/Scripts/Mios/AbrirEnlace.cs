using UnityEngine;

public class AbrirEnlace : MonoBehaviour
{
    public void IrAWeb(string url)
    {
        Application.OpenURL(url);
    }
}