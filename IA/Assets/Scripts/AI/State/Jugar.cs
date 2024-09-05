using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugar : StateMove
{


    // Start is called before the first frame update
    void Start()
    {
        this.LoadComponent();
    }
    public override void LoadComponent()
    {
        stateType = StateType.Jugar;
        base.LoadComponent();

    }
    public override void Enter()
    {
        Debug.Log("Jugar Enter ");
    }
    public override void Execute()
    {

        // Calcula la fuerza de direcci�n
        Vector3 steeringForce = _SteeringBehavior.Arrive(place);

        // Aplica la fuerza a la velocidad
        _SteeringBehavior.ClampMagnitude(steeringForce);

        // Actualiza la posici�n del objeto
        _SteeringBehavior.UpdatePosition();

        float distancia = (transform.position - place.position).magnitude;
        if (distancia < 1)
        {
            _MachineState.ActiveState(StateType.Jugando);
            return;
        }
    }
    public override void Exit()
    {
        Debug.Log("Jugar Exit ");
    }
    // Update is called once per frame

}