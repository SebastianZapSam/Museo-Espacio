using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TelepuertoEscena : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update


    // Update is called once per frame
    void OnTriggerEnter(Collider Other)
    {
        if (Other.tag == "Player"){
            SceneManager.LoadScene (sceneName);
        }

    }
}
