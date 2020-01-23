using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    private static int count;
    private string[] __sceneList;

    private void Awake()
    {
        count = SceneManager.sceneCountInBuildSettings;
        __sceneList = new string[count];

        StoreAllScenes();
        loadScene(SceneManager.GetActiveScene().buildIndex + 1); // Loads the first real scene when the game is initialized
    }

    private void StoreAllScenes()
    {
        for (int i = 0; i < count; i++)
        {
            __sceneList[i] = SceneManager.GetSceneByBuildIndex(i).name;
            //Debug.Log(__sceneList[i] + " " + count);
        }
    }

    public EngineStatus.Engine_Status loadScene(int sceneIndex)
    {
        EngineStatus.Engine_Status retStatus = EngineStatus.Engine_Status.ENGINE_INDEX_OUT_OF_RANGE;

        Debug.Log(sceneIndex);

        if (sceneIndex > 0 && sceneIndex <= __sceneList.Length)
        {
            retStatus = EngineStatus.Engine_Status.ENGINE_OPERATION_SUCCESS;
        }

        return retStatus;
    }

}
