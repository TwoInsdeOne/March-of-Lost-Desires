//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Input Actions/Player Controls.inputactions
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

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Controls"",
    ""maps"": [
        {
            ""name"": ""Movements"",
            ""id"": ""09d078b3-5dc9-40a7-930c-ff1077cc59f7"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""4575ff62-0859-49ac-afb0-6a9f6f24d9fc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f8473df3-e352-45dc-88d5-85f8b2e00bd3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""252ef5ba-ddf1-4ced-98ef-d37a40f4f378"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7065308b-808a-4c42-b355-167e87909233"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""06acddc3-27ad-4085-8856-7d5728711888"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""40e95b7a-9247-47f5-a060-28e09064601a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""1c7eef4a-b7e9-4343-b15b-7f9a942bf9b3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""11968ecd-6a41-40f0-bddd-18c2a5d4d140"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5bc29b6e-0e17-49e7-9299-c65aa2c4833d"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""41b57ce1-e280-45a3-811b-ba0e4a7e6e70"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f9bdcbea-0c4a-4d9c-a424-ac1d0bcbfd83"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Actions"",
            ""id"": ""787765ac-e817-4a2e-92bd-e5f6ca4fd0aa"",
            ""actions"": [
                {
                    ""name"": ""Blast"",
                    ""type"": ""Button"",
                    ""id"": ""8a5b0814-f7d7-4a14-b357-59f57d6d45cf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shield"",
                    ""type"": ""Button"",
                    ""id"": ""3f3ee819-bd97-49af-b23c-0569fed90011"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d2702adb-bc03-4a5b-9dfb-febfdf356075"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Blast"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""585836e3-641e-457d-ad5f-9c5822731445"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Blast"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30d5f012-2a6a-4f08-a5d2-088645d5555a"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shield"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03e43eb6-ccf2-44dc-8af7-b1457eae6b44"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shield"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movements
        m_Movements = asset.FindActionMap("Movements", throwIfNotFound: true);
        m_Movements_Move = m_Movements.FindAction("Move", throwIfNotFound: true);
        // Actions
        m_Actions = asset.FindActionMap("Actions", throwIfNotFound: true);
        m_Actions_Blast = m_Actions.FindAction("Blast", throwIfNotFound: true);
        m_Actions_Shield = m_Actions.FindAction("Shield", throwIfNotFound: true);
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

    // Movements
    private readonly InputActionMap m_Movements;
    private List<IMovementsActions> m_MovementsActionsCallbackInterfaces = new List<IMovementsActions>();
    private readonly InputAction m_Movements_Move;
    public struct MovementsActions
    {
        private @PlayerControls m_Wrapper;
        public MovementsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Movements_Move;
        public InputActionMap Get() { return m_Wrapper.m_Movements; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementsActions set) { return set.Get(); }
        public void AddCallbacks(IMovementsActions instance)
        {
            if (instance == null || m_Wrapper.m_MovementsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MovementsActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(IMovementsActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(IMovementsActions instance)
        {
            if (m_Wrapper.m_MovementsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMovementsActions instance)
        {
            foreach (var item in m_Wrapper.m_MovementsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MovementsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MovementsActions @Movements => new MovementsActions(this);

    // Actions
    private readonly InputActionMap m_Actions;
    private List<IActionsActions> m_ActionsActionsCallbackInterfaces = new List<IActionsActions>();
    private readonly InputAction m_Actions_Blast;
    private readonly InputAction m_Actions_Shield;
    public struct ActionsActions
    {
        private @PlayerControls m_Wrapper;
        public ActionsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Blast => m_Wrapper.m_Actions_Blast;
        public InputAction @Shield => m_Wrapper.m_Actions_Shield;
        public InputActionMap Get() { return m_Wrapper.m_Actions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionsActions set) { return set.Get(); }
        public void AddCallbacks(IActionsActions instance)
        {
            if (instance == null || m_Wrapper.m_ActionsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ActionsActionsCallbackInterfaces.Add(instance);
            @Blast.started += instance.OnBlast;
            @Blast.performed += instance.OnBlast;
            @Blast.canceled += instance.OnBlast;
            @Shield.started += instance.OnShield;
            @Shield.performed += instance.OnShield;
            @Shield.canceled += instance.OnShield;
        }

        private void UnregisterCallbacks(IActionsActions instance)
        {
            @Blast.started -= instance.OnBlast;
            @Blast.performed -= instance.OnBlast;
            @Blast.canceled -= instance.OnBlast;
            @Shield.started -= instance.OnShield;
            @Shield.performed -= instance.OnShield;
            @Shield.canceled -= instance.OnShield;
        }

        public void RemoveCallbacks(IActionsActions instance)
        {
            if (m_Wrapper.m_ActionsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IActionsActions instance)
        {
            foreach (var item in m_Wrapper.m_ActionsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ActionsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ActionsActions @Actions => new ActionsActions(this);
    public interface IMovementsActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IActionsActions
    {
        void OnBlast(InputAction.CallbackContext context);
        void OnShield(InputAction.CallbackContext context);
    }
}
