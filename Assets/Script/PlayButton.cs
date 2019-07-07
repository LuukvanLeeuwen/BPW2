using UnityEngine;
 using UnityEngine;
 using System.Collections;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene(1);
    }
}