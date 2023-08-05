using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Play : MonoBehaviour
{
    GameInputs gameInputs;

    /// <summary>
    /// ����{�^���������ꂽ�Ƃ�
    /// </summary>
    void OnSelected(InputAction.CallbackContext context)
    {
        SceneChanger.Instance.LoadSceneFaded("Thankyou");
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
