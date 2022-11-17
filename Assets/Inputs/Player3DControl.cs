//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Inputs/Player3DControl.inputactions
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

public partial class @Player3DControl : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player3DControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player3DControl"",
    ""maps"": [
        {
            ""name"": ""WASD"",
            ""id"": ""cf636e5f-d1a5-445f-9bfa-32a1ede61f48"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""c902669b-acaa-4ac2-9609-d4b386b81230"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shooting"",
                    ""type"": ""Button"",
                    ""id"": ""ff3a174b-ae9b-4067-929a-6e9f4b88e382"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9a951f7d-a3bd-476f-815f-17ba4e4d254b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""3D Vector"",
                    ""id"": ""e477f1cb-b331-4416-9562-4a9d2db57709"",
                    ""path"": ""3DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""forward"",
                    ""id"": ""db3d8c06-6481-486e-a7b7-7818feba9bf1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""backward"",
                    ""id"": ""29120e3f-c264-4a59-ae03-2dce65b7e962"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""894d50cd-3043-4ae1-9998-31ae565dfe61"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""6d6a07bb-8977-4059-85e8-a007624e6f4c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Forward"",
                    ""id"": ""9901b7de-72b2-4ff6-b648-4a54e2f3b4d5"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Backward"",
                    ""id"": ""0518fcf5-d666-41ed-b3b7-8aa633140875"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f30f5021-9f40-4f3c-b3e1-41312e746307"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""298ab132-21e7-4b5c-a7fb-2880ed4ed1cf"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb03a0f9-7f72-4264-9da7-7539bebddcba"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9af14521-ab6d-4dd6-975d-6417b7d65c73"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""446b12af-aed1-4d6c-a803-d1395073b679"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // WASD
        m_WASD = asset.FindActionMap("WASD", throwIfNotFound: true);
        m_WASD_Movement = m_WASD.FindAction("Movement", throwIfNotFound: true);
        m_WASD_Shooting = m_WASD.FindAction("Shooting", throwIfNotFound: true);
        m_WASD_Jump = m_WASD.FindAction("Jump", throwIfNotFound: true);
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

    // WASD
    private readonly InputActionMap m_WASD;
    private IWASDActions m_WASDActionsCallbackInterface;
    private readonly InputAction m_WASD_Movement;
    private readonly InputAction m_WASD_Shooting;
    private readonly InputAction m_WASD_Jump;
    public struct WASDActions
    {
        private @Player3DControl m_Wrapper;
        public WASDActions(@Player3DControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_WASD_Movement;
        public InputAction @Shooting => m_Wrapper.m_WASD_Shooting;
        public InputAction @Jump => m_Wrapper.m_WASD_Jump;
        public InputActionMap Get() { return m_Wrapper.m_WASD; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WASDActions set) { return set.Get(); }
        public void SetCallbacks(IWASDActions instance)
        {
            if (m_Wrapper.m_WASDActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_WASDActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_WASDActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_WASDActionsCallbackInterface.OnMovement;
                @Shooting.started -= m_Wrapper.m_WASDActionsCallbackInterface.OnShooting;
                @Shooting.performed -= m_Wrapper.m_WASDActionsCallbackInterface.OnShooting;
                @Shooting.canceled -= m_Wrapper.m_WASDActionsCallbackInterface.OnShooting;
                @Jump.started -= m_Wrapper.m_WASDActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_WASDActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_WASDActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_WASDActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Shooting.started += instance.OnShooting;
                @Shooting.performed += instance.OnShooting;
                @Shooting.canceled += instance.OnShooting;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public WASDActions @WASD => new WASDActions(this);
    public interface IWASDActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnShooting(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
