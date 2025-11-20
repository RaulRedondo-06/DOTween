using UnityEngine;

public class GestorGeneral : MonoBehaviour
{
    public ControlEscenarioA escenarioA;
    public ControlEscenarioB escenarioB;

    public void ReproducirTodo()
    {
        escenarioA.ReproducirEscenarioA();
        escenarioB.ReproducirEscenarioB();
    }

    public void ReiniciarTodo()
    {
        escenarioA.ReiniciarEscenarioA();
        escenarioB.ReiniciarEscenarioB();
    }
}

