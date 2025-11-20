using UnityEngine;
using DG.Tweening;

public class ControlEscenarioA : MonoBehaviour
{
    public Transform cuboA;

    private Vector3 posicionInicial;
    [SerializeField] private Transform posicionSalto;

    private Tween animacionSalto;

    public float potenciaSalto = 2f;
    public int cantidadSaltos = 1;
    public float duracionSalto = 1.2f;

    void Awake()
    {
        posicionInicial = cuboA.position;
    }

    public void ReproducirEscenarioA()
    {
        ReiniciarEscenarioA();

        animacionSalto = cuboA.DOJump(posicionSalto.position, potenciaSalto, cantidadSaltos, duracionSalto).SetEase(Ease.OutQuad);
    }

    public void ReiniciarEscenarioA()
    {
        if (animacionSalto != null && animacionSalto.IsActive())
            animacionSalto.Kill();

        cuboA.position = posicionInicial;
    }
}
