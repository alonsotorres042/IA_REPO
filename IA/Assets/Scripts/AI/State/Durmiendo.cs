using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Durmiendo : StateWait
{
    // Start is called before the first frame update
    void Start()
    {
        this.LoadComponent();
    }
    public override void LoadComponent()
    {

        base.LoadComponent();
    }
    public override void Enter()
    {
        base.Enter();
        Debug.Log("Durmiendo Enter ");
    }
    public override void Execute()
    {
        base.Execute();
        if (!WaitTime)
        {
            _MachineState.ActiveState(GetRandomStateType());
        }

    }
    public override void Exit()
    {
        base.Exit();
        Debug.Log("Durmiendo Exit ");
    }
}
