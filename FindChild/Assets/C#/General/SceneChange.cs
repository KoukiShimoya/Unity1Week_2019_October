using System;
using System.Collections;
using System.Collections.Generic;
using Constants;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : SingletonMonoBehaviour<SceneChange>
{
    public void ChangeScene(float time)
    {
        string sceneName = Word.empty;
        string nowSceneName = SceneManager.GetActiveScene().name;
        if (nowSceneName == Word.gameScene1)
        {
            sceneName = Word.gameScene2;
        }
        else if (nowSceneName == Word.gameScene2)
        {
            sceneName = Word.gameScene3;
        }
        else if (nowSceneName == Word.gameScene3)
        {
            GameObject clearImage = SerializeObject.Instance.GetMainCanvasRoot.transform.GetChild(3).gameObject;
            clearImage.SetActive(true);
            time *= 4;
            sceneName = Word.startScene;
        }
        else if (nowSceneName == Word.startScene)
        {
            sceneName = Word.gameScene1;
        }
        StartCoroutine(WaitSceneChange(sceneName, time));
    }

    private IEnumerator WaitSceneChange(string sceneName, float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(sceneName);
        yield break;
    }
}