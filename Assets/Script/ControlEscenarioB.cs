using UnityEngine;
using DG.Tweening;

public class ControlEscenarioB : MonoBehaviour
{
    public Transform cuboB1;
    public Transform cuboB2;

    private Vector3 posInicialB1, posInicialB2;
    private Quaternion rotInicialB1, rotInicialB2;
    private Vector3 escalaInicialB1, escalaInicialB2;
    private Color colorInicialB1, colorInicialB2;

    private Renderer renderB1, renderB2;
    private Sequence secuencia;

    void Awake()
    {
        posInicialB1 = cuboB1.position;
        posInicialB2 = cuboB2.position;

        rotInicialB1 = cuboB1.rotation;
        rotInicialB2 = cuboB2.rotation;

        escalaInicialB1 = cuboB1.localScale;
        escalaInicialB2 = cuboB2.localScale;

        renderB1 = cuboB1.GetComponent<Renderer>();
        renderB2 = cuboB2.GetComponent<Renderer>();

        colorInicialB1 = renderB1.material.color;
        colorInicialB2 = renderB2.material.color;
    }

    public void ReproducirEscenarioB()
    {
        ReiniciarEscenarioB();

        secuencia = DOTween.Sequence();
        secuencia.SetAutoKill(false);

        secuencia.Append(cuboB1.DOMove(posInicialB1 + new Vector3(0.7f, 0, 0), 0.6f).SetEase(Ease.InOutSine));

        secuencia.Join(cuboB2.DORotate(new Vector3(0, 180, 0), 0.6f, RotateMode.FastBeyond360));

        secuencia.Append(cuboB1.DOScale(escalaInicialB1 * 1.3f, 0.4f).SetEase(Ease.OutBack));

        secuencia.Append(cuboB2.DOMove(posInicialB1 + new Vector3(0.3f, 0, 0), 0.5f));

        secuencia.Join(cuboB1.DOJump(cuboB1.position + new Vector3(0, 0, 0), 0.6f, 1, 0.5f));
        secuencia.Join(renderB1.material.DOColor(Color.red, 0.5f));

        secuencia.Append(cuboB1.DOScale(escalaInicialB1, 0.3f));
        secuencia.Append(cuboB2.DORotate(rotInicialB2.eulerAngles, 0.4f));
        secuencia.Append(cuboB2.DOMove(posInicialB2, 0.4f));
        secuencia.Append(renderB1.material.DOColor(colorInicialB1, 0.3f));

        secuencia.Play();
    }

    public void ReiniciarEscenarioB()
    {
        if (secuencia != null && secuencia.IsActive())
            secuencia.Kill();

        cuboB1.position = posInicialB1;
        cuboB2.position = posInicialB2;

        cuboB1.rotation = rotInicialB1;
        cuboB2.rotation = rotInicialB2;

        cuboB1.localScale = escalaInicialB1;
        cuboB2.localScale = escalaInicialB2;

        renderB1.material.color = colorInicialB1;
        renderB2.material.color = colorInicialB2;
    }
}
