using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Rule : MonoBehaviour
{
    GameInputs gameInputs;

    /// <summary>
    /// 決定ボタンが押されたとき
    /// </summary>
    void OnSelected(InputAction.CallbackContext context)
    {
        SceneChanger.Instance.LoadSceneFaded("Play");
    }

    void Start()
    {
        gameInputs = new GameInputs();
        gameInputs.UI.Select.started += OnSelected;

        gameInputs.Enable();
    }

    void OnDestroy()
    {
        gameInputs.Dispose();
    }
}
