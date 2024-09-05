using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WCing : StateMove
{


    // Start is called before the first frame update
    void Awake()
    {
        this.LoadComponent();
    }
    public override void LoadComponent()
    {
        stateType = StateType.WCing;
        base.LoadComponent();
         
    }
    public override void Enter()
    {
        Debug.Log("WCing Enter ");
    }
    public override void Execute()
    {
        // Calcula la fuerza de dirección
        Vector3 steeringForce = _SteeringBehavior.Arrive(place);

        // Aplica la fuerza a la velocidad
        _SteeringBehavior.ClampMagnitude(steeringForce);

        // Actualiza la posición del objeto
        _SteeringBehavior.UpdatePosition();

        float distancia = (transform.position - place.position).magnitude;
        if (distancia < 1)
        {
            _MachineState.ActiveState(StateType.WCingg);
            return;
        }
    }
    public override void Exit()
    {
        Debug.Log("WCing Exit ");
    }
     
}
