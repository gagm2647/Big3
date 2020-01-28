using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        Debug.Log(count);
        __sceneList = new string[count];

        LoadScene(1);
    }

    private void StoreAllScenes()
    {
        __sceneList = (from scene in EditorBuildSettings.scenes where scene.enabled select scene.path).ToArray();
    }

    public EngineStatus.Engine_Status LoadScene(int sceneIndex)
    {
        EngineStatus.Engine_Status retStatus = EngineStatus.Engine_Status.ENGINE_INDEX_OUT_OF_RANGE;

        StoreAllScenes();

        //Debug.Log(sceneIndex);

        if (sceneIndex > 0 && sceneIndex <= __sceneList.Length)
        {
            SceneManager.LoadScene(__sceneList[sceneIndex]);
            retStatus = EngineStatus.Engine_Status.ENGINE_OPERATION_SUCCESS;
        }

        return retStatus;
    }

}
