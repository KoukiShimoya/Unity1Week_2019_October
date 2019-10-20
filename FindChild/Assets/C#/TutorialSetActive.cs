using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialSetActive : MonoBehaviour
{
    public void OnClick()
    {
        this.gameObject.SetActive(false);
    }
}
