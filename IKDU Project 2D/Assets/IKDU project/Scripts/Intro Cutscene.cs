using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroCutscene : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void Gamemecanics()
    {
        SceneManager.LoadSceneAsync(1);
    }

}


// Another way of writing the code :) - but the other works perfectly fine
    //SceneManager.LoadScene(SceneManager.GetActiveScene(1));
