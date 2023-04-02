using Unity.Profiling;
using UnityEngine;
using UnityEngine.UI;

public class Drink : MonoBehaviour
{
    [SerializeField] private DrinkInfo drink;

    [SerializeField] private AnimationCurve drinkFullness;

    [SerializeField] private Image blackspace;

    public bool isDrinking = false;

    private float amountLeft = 10.0f;
    private float speedMultiplier = 1.0f;

    void Start()
    {
        Initialize();
    }

    public void Initialize()
    {
         switch (drink.par)
         {
            case <= 1:
                speedMultiplier = 6;
                break;
            case 2:
                speedMultiplier = 2.5f;
                break;
            case 3:
                speedMultiplier = 0.4f;
                break;
            case 4:
                speedMultiplier = 0.2f;
                break;
            case >= 5:
                speedMultiplier = 0.1f;
                break;
         }
    }

    void FixedUpdate()
    {
        if (isDrinking)
        {
            blackspace.fillAmount = drinkFullness.Evaluate(amountLeft);

            amountLeft -= Time.deltaTime * speedMultiplier;
        }
    }
}
