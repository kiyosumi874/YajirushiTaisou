using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Play : MonoBehaviour
{
    [SerializeField] Screen screen;

    GameInputs gameInputs;

    /// <summary>
    /// Œˆ’èƒ{ƒ^ƒ“‚ª‰Ÿ‚³‚ê‚½‚Æ‚«
    /// </summary>
    void OnSelected(InputAction.CallbackContext context)
    {
        //SceneChanger.Instance.LoadSceneFaded("Thankyou");
        screen.StartScreen();
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
