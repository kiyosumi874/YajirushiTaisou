//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/InputSystem/GameInputs.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @GameInputs : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInputs"",
    ""maps"": [
        {
            ""name"": ""UI"",
            ""id"": ""c7e6fcf7-3490-4f10-93f1-5b4a09a1b702"",
            ""actions"": [
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""3600cd99-854e-421c-8b9e-9c725631ac9e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""a701051e-d03e-4828-9c35-00144aa8d9b7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""NavigateUpDebug"",
                    ""type"": ""Button"",
                    ""id"": ""c022668f-f2db-49b9-96a0-1039162b3189"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""NavigateDownDebug"",
                    ""type"": ""Button"",
                    ""id"": ""0386efd7-b80c-41e0-a5f0-ae11e32fd456"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PlayerLeftHand"",
                    ""type"": ""Value"",
                    ""id"": ""12d54c2b-1443-4e2a-b629-2b9b7ca5d573"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""PlayerRightHand"",
                    ""type"": ""Value"",
                    ""id"": ""46e63520-5293-47ed-98d8-c371ef207c47"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""PlayerLeftHandUpDebug"",
                    ""type"": ""Button"",
                    ""id"": ""1c8f94c2-ef6b-459a-88bc-3bc6cee89655"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PlayerLeftHandSideDebug"",
                    ""type"": ""Button"",
                    ""id"": ""2318a80d-8837-4d03-9f83-2b5a3be68a4c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PlayerLeftHandDownDebug"",
                    ""type"": ""Button"",
                    ""id"": ""19e48e43-7ec5-4f54-a071-7f49a1a281f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PlayerRightHandUpDebug"",
                    ""type"": ""Button"",
                    ""id"": ""fe5f90cf-67f6-46c4-b120-59cc0c2708d3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PlayerRightHandSideDebug"",
                    ""type"": ""Button"",
                    ""id"": ""ac7321ba-63f6-4e65-a3de-c5f5ed658a9c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PlayerRightHandDownDebug"",
                    ""type"": ""Button"",
                    ""id"": ""93562730-6f12-4420-8459-350f822b8939"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7b6049cf-3189-4312-b82f-739f90d51262"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""643c5071-5d67-4698-9d07-5c2a7d67a027"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1765b61e-f396-4402-8e39-385ce9c152e2"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""7ead1c12-4048-4015-bdff-734c6fa67f9c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c0fa254c-4445-4131-95a8-7fbbfe73408d"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""97230636-c693-42e2-bb7a-7ac82b6cec29"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e410eff6-7398-4410-92a6-61323d4bfefd"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ebc9d61d-56e5-4e8a-be1d-c4d9f4eb057a"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""45bfa738-7795-45c7-b9a7-bae4afc97940"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerLeftHand"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""53e00b8c-78ba-416e-88e3-bccfaa37cb71"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerLeftHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""13bee854-0d49-4e9b-9da5-b6a68a00ff2b"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerLeftHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""de367a05-a5eb-4406-9ffa-6076e48b03c5"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerLeftHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""832a91a5-f71b-4255-955a-6ed240bb4866"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerLeftHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""01036fd4-05e0-4043-bfc0-81de62e23ce3"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateUpDebug"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""87134841-f5fa-45d4-9915-ae8d41ba5e43"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateDownDebug"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""763f9cf5-585a-4619-b9bd-1a45129479d5"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerRightHand"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""bdfde7c7-7c33-47d9-bc58-9ea3eb22ba86"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerRightHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9b294a91-2439-4e20-8915-aa0b8888db48"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerRightHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""91236e25-2995-4989-a2d1-65a7bd73feaa"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerRightHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""45000ea2-603c-40e1-813f-41091dca4c48"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerRightHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""21e72607-a164-4a82-982e-9eae348ef724"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerLeftHandUpDebug"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e6c9e06-d0e4-46da-9e9a-d65846fe8c02"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerLeftHandSideDebug"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ba7e471-a489-4cf2-923c-e2a8644c0da9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerLeftHandDownDebug"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1e37ee9c-4075-47f5-8c1d-0507612f8270"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerRightHandUpDebug"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""05a6725a-318a-47b6-9963-003a60cf10df"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerRightHandSideDebug"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a46a3ab4-45e7-4d76-a103-29059c273368"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerRightHandDownDebug"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Select = m_UI.FindAction("Select", throwIfNotFound: true);
        m_UI_Navigate = m_UI.FindAction("Navigate", throwIfNotFound: true);
        m_UI_NavigateUpDebug = m_UI.FindAction("NavigateUpDebug", throwIfNotFound: true);
        m_UI_NavigateDownDebug = m_UI.FindAction("NavigateDownDebug", throwIfNotFound: true);
        m_UI_PlayerLeftHand = m_UI.FindAction("PlayerLeftHand", throwIfNotFound: true);
        m_UI_PlayerRightHand = m_UI.FindAction("PlayerRightHand", throwIfNotFound: true);
        m_UI_PlayerLeftHandUpDebug = m_UI.FindAction("PlayerLeftHandUpDebug", throwIfNotFound: true);
        m_UI_PlayerLeftHandSideDebug = m_UI.FindAction("PlayerLeftHandSideDebug", throwIfNotFound: true);
        m_UI_PlayerLeftHandDownDebug = m_UI.FindAction("PlayerLeftHandDownDebug", throwIfNotFound: true);
        m_UI_PlayerRightHandUpDebug = m_UI.FindAction("PlayerRightHandUpDebug", throwIfNotFound: true);
        m_UI_PlayerRightHandSideDebug = m_UI.FindAction("PlayerRightHandSideDebug", throwIfNotFound: true);
        m_UI_PlayerRightHandDownDebug = m_UI.FindAction("PlayerRightHandDownDebug", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Select;
    private readonly InputAction m_UI_Navigate;
    private readonly InputAction m_UI_NavigateUpDebug;
    private readonly InputAction m_UI_NavigateDownDebug;
    private readonly InputAction m_UI_PlayerLeftHand;
    private readonly InputAction m_UI_PlayerRightHand;
    private readonly InputAction m_UI_PlayerLeftHandUpDebug;
    private readonly InputAction m_UI_PlayerLeftHandSideDebug;
    private readonly InputAction m_UI_PlayerLeftHandDownDebug;
    private readonly InputAction m_UI_PlayerRightHandUpDebug;
    private readonly InputAction m_UI_PlayerRightHandSideDebug;
    private readonly InputAction m_UI_PlayerRightHandDownDebug;
    public struct UIActions
    {
        private @GameInputs m_Wrapper;
        public UIActions(@GameInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Select => m_Wrapper.m_UI_Select;
        public InputAction @Navigate => m_Wrapper.m_UI_Navigate;
        public InputAction @NavigateUpDebug => m_Wrapper.m_UI_NavigateUpDebug;
        public InputAction @NavigateDownDebug => m_Wrapper.m_UI_NavigateDownDebug;
        public InputAction @PlayerLeftHand => m_Wrapper.m_UI_PlayerLeftHand;
        public InputAction @PlayerRightHand => m_Wrapper.m_UI_PlayerRightHand;
        public InputAction @PlayerLeftHandUpDebug => m_Wrapper.m_UI_PlayerLeftHandUpDebug;
        public InputAction @PlayerLeftHandSideDebug => m_Wrapper.m_UI_PlayerLeftHandSideDebug;
        public InputAction @PlayerLeftHandDownDebug => m_Wrapper.m_UI_PlayerLeftHandDownDebug;
        public InputAction @PlayerRightHandUpDebug => m_Wrapper.m_UI_PlayerRightHandUpDebug;
        public InputAction @PlayerRightHandSideDebug => m_Wrapper.m_UI_PlayerRightHandSideDebug;
        public InputAction @PlayerRightHandDownDebug => m_Wrapper.m_UI_PlayerRightHandDownDebug;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Select.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSelect;
                @Navigate.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @NavigateUpDebug.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigateUpDebug;
                @NavigateUpDebug.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigateUpDebug;
                @NavigateUpDebug.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigateUpDebug;
                @NavigateDownDebug.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigateDownDebug;
                @NavigateDownDebug.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigateDownDebug;
                @NavigateDownDebug.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigateDownDebug;
                @PlayerLeftHand.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPlayerLeftHand;
                @PlayerLeftHand.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPlayerLeftHand;
                @PlayerLeftHand.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPlayerLeftHand;
                @PlayerRightHand.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPlayerRightHand;
                @PlayerRightHand.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPlayerRightHand;
                @PlayerRightHand.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPlayerRightHand;
                @PlayerLeftHandUpDebug.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPlayerLeftHandUpDebug;
                @PlayerLeftHandUpDebug.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPlayerLeftHandUpDebug;
                @PlayerLeftHandUpDebug.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPlayerLeftHandUpDebug;
                @PlayerLeftHandSideDebug.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPlayerLeftHandSideDebug;
                @PlayerLeftHandSideDebug.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPlayerLeftHandSideDebug;
                @PlayerLeftHandSideDebug.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPlayerLeftHandSideDebug;
                @PlayerLeftHandDownDebug.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPlayerLeftHandDownDebug;
                @PlayerLeftHandDownDebug.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPlayerLeftHandDownDebug;
                @PlayerLeftHandDownDebug.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPlayerLeftHandDownDebug;
                @PlayerRightHandUpDebug.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPlayerRightHandUpDebug;
                @PlayerRightHandUpDebug.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPlayerRightHandUpDebug;
                @PlayerRightHandUpDebug.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPlayerRightHandUpDebug;
                @PlayerRightHandSideDebug.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPlayerRightHandSideDebug;
                @PlayerRightHandSideDebug.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPlayerRightHandSideDebug;
                @PlayerRightHandSideDebug.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPlayerRightHandSideDebug;
                @PlayerRightHandDownDebug.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPlayerRightHandDownDebug;
                @PlayerRightHandDownDebug.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPlayerRightHandDownDebug;
                @PlayerRightHandDownDebug.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPlayerRightHandDownDebug;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @NavigateUpDebug.started += instance.OnNavigateUpDebug;
                @NavigateUpDebug.performed += instance.OnNavigateUpDebug;
                @NavigateUpDebug.canceled += instance.OnNavigateUpDebug;
                @NavigateDownDebug.started += instance.OnNavigateDownDebug;
                @NavigateDownDebug.performed += instance.OnNavigateDownDebug;
                @NavigateDownDebug.canceled += instance.OnNavigateDownDebug;
                @PlayerLeftHand.started += instance.OnPlayerLeftHand;
                @PlayerLeftHand.performed += instance.OnPlayerLeftHand;
                @PlayerLeftHand.canceled += instance.OnPlayerLeftHand;
                @PlayerRightHand.started += instance.OnPlayerRightHand;
                @PlayerRightHand.performed += instance.OnPlayerRightHand;
                @PlayerRightHand.canceled += instance.OnPlayerRightHand;
                @PlayerLeftHandUpDebug.started += instance.OnPlayerLeftHandUpDebug;
                @PlayerLeftHandUpDebug.performed += instance.OnPlayerLeftHandUpDebug;
                @PlayerLeftHandUpDebug.canceled += instance.OnPlayerLeftHandUpDebug;
                @PlayerLeftHandSideDebug.started += instance.OnPlayerLeftHandSideDebug;
                @PlayerLeftHandSideDebug.performed += instance.OnPlayerLeftHandSideDebug;
                @PlayerLeftHandSideDebug.canceled += instance.OnPlayerLeftHandSideDebug;
                @PlayerLeftHandDownDebug.started += instance.OnPlayerLeftHandDownDebug;
                @PlayerLeftHandDownDebug.performed += instance.OnPlayerLeftHandDownDebug;
                @PlayerLeftHandDownDebug.canceled += instance.OnPlayerLeftHandDownDebug;
                @PlayerRightHandUpDebug.started += instance.OnPlayerRightHandUpDebug;
                @PlayerRightHandUpDebug.performed += instance.OnPlayerRightHandUpDebug;
                @PlayerRightHandUpDebug.canceled += instance.OnPlayerRightHandUpDebug;
                @PlayerRightHandSideDebug.started += instance.OnPlayerRightHandSideDebug;
                @PlayerRightHandSideDebug.performed += instance.OnPlayerRightHandSideDebug;
                @PlayerRightHandSideDebug.canceled += instance.OnPlayerRightHandSideDebug;
                @PlayerRightHandDownDebug.started += instance.OnPlayerRightHandDownDebug;
                @PlayerRightHandDownDebug.performed += instance.OnPlayerRightHandDownDebug;
                @PlayerRightHandDownDebug.canceled += instance.OnPlayerRightHandDownDebug;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IUIActions
    {
        void OnSelect(InputAction.CallbackContext context);
        void OnNavigate(InputAction.CallbackContext context);
        void OnNavigateUpDebug(InputAction.CallbackContext context);
        void OnNavigateDownDebug(InputAction.CallbackContext context);
        void OnPlayerLeftHand(InputAction.CallbackContext context);
        void OnPlayerRightHand(InputAction.CallbackContext context);
        void OnPlayerLeftHandUpDebug(InputAction.CallbackContext context);
        void OnPlayerLeftHandSideDebug(InputAction.CallbackContext context);
        void OnPlayerLeftHandDownDebug(InputAction.CallbackContext context);
        void OnPlayerRightHandUpDebug(InputAction.CallbackContext context);
        void OnPlayerRightHandSideDebug(InputAction.CallbackContext context);
        void OnPlayerRightHandDownDebug(InputAction.CallbackContext context);
    }
}
