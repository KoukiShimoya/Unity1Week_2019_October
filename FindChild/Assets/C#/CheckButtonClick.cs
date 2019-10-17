using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        }
        else
        {
            Debug.Log("Wrong!");
        }
    }
}
