using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenestart : MonoBehaviour
{
    // Start is called before the first frame update

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    static void OnAfterSceneLoad()
    {
        Debug.Log("First scene loaded: After Awake is called.");
    }
}
