using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class SuccesSeneManager : MonoBehaviour
{
    public static int sceneCount=3;

    public void NextVoid()
    {
        sceneCount++;
        SceneManager.LoadScene(sceneCount);
    }
}
