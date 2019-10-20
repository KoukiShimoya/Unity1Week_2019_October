using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Constants;

public class CheckButtonClick : MonoBehaviour
{
    public void OnClick()
    {
        GameObject[] childPanels = SerializeObject.Instance.GetChildPanelsRoot.GetOnlyOwnChildren();
        bool allPanelsAttributeSame = true;
        
        foreach (var childPanel in childPanels)
        {
            GameObject childInParentSprite = childPanel.transform.GetChild(3).gameObject;
            GameObject parentObj = childInParentSprite.GetComponent<ChildInParentOwnParentObject>().parentObj;
            if (parentObj == null)
            {
                Debug.Log("全てのパネルが埋まっていません");
                allPanelsAttributeSame = false;
                break;
            }

            if (!Useful.isSameChildAttributeValue(parentObj.GetComponent<OneChildAttribute>().childAttribute,
                childPanel.GetComponent<OneChildAttribute>().childAttribute))
            {
                allPanelsAttributeSame = false;
                break;
            }
        }

        if (allPanelsAttributeSame)
        {
            Debug.Log("Clear!");
            for (int i = 0; i < 3; i++)
            {
                GameObject callout = Instantiate(SerializeObject.Instance.GetCalloutSprite);
                callout.transform.SetParent(SerializeObject.Instance.GetMainCanvasRoot.transform);
                callout.GetComponent<RectTransform>().anchoredPosition = new Vector2(UnityEngine.Random.Range(0, 1920 - 300), UnityEngine.Random.Range(0, 300));
                Text text = callout.transform.GetChild(0).GetComponent<Text>();
                if (i == 0)
                {
                    text.text = "やった～～";
                }
                else if (i == 1)
                {
                    text.text = "ごめんなさい～";
                }
                else
                {
                    text.text = "怖かったよ～";
                }
            }
            SceneChange.Instance.ChangeScene(1.0f);
        }
        else
        {
            Debug.Log("Wrong!");
            for (int i = 0; i < 3; i++)
            {
                GameObject callout = Instantiate(SerializeObject.Instance.GetCalloutSprite);
                callout.transform.SetParent(SerializeObject.Instance.GetMainCanvasRoot.transform);
                callout.GetComponent<RectTransform>().anchoredPosition = new Vector2(UnityEngine.Random.Range(0, 1920 - 300), UnityEngine.Random.Range(0, 300));
                Text text = callout.transform.GetChild(0).GetComponent<Text>();
                if (i == 0)
                {
                    text.text = "違うよ～～";
                }
                else if (i == 1)
                {
                    text.text = "お母さんどこ～";
                }
                else
                {
                    text.text = "ママじゃない～";
                }
            }
        }
    }
}
