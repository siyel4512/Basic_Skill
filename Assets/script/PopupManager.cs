using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupManager : MonoBehaviour
{
    private static PopupManager _instance; // 싱글톤
    public GameObject _popup;

    public Text _txtPopupMsg;

    System.Action _onClickOkay, _onClickClose; // 델리케이트
                                               // https://luv-n-interest.tistory.com/811
                                               // https://luv-n-interest.tistory.com/1331

    // 프로퍼티 : 변수처럼 보이지만 사실 내부적으로는 함수가 구현할 수 있는....
    // https://velog.io/@marintelli/%EC%9C%A0%EB%8B%88%ED%8B%B0-%ED%94%84%EB%A1%9C%ED%8D%BC%ED%8B%B0
    public static PopupManager Instance
    {
        get
        {
            return _instance;
        }
    }

    private void Awake()
    {
        _popup.SetActive(false);
        DontDestroyOnLoad(this);

        _instance = this;
    }

    public void Open(string text, System.Action onClickOkay, System.Action onClickClose)
    {
        _popup.SetActive(true);
        _txtPopupMsg.text = text;
        _onClickOkay = onClickOkay;
        _onClickClose = onClickClose;
    }

    public void Close()
    {
        _popup.SetActive(false);
    }

    public void OnClickOkayButton()
    {
        Debug.Log("on click okay");

        if (_onClickOkay != null)
        {
            _onClickOkay();
        }

        Close();
    } 

    public void OnClickCloseButton()
    {
        Debug.Log("on click close");

        if (_onClickClose != null)
        {
            _onClickClose();
        }

        Close();
    }
}
