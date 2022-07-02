using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupTrigger : MonoBehaviour
{
    public string _myMsg;

    public void OnClickTrigger()
    {
        PopupManager.Instance.Open(_myMsg, 
            onClickOkay:()=> 
            {
                Debug.Log("onclikcOkay");
            }, 
            onClickClose:()=> 
            {
                Debug.Log("onclickClose");
            });
    }
}
