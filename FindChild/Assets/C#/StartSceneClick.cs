using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSceneClick : MonoBehaviour
{
    public void OnClick()
    {
        SceneChange.Instance.ChangeScene(0f);
    }
}
