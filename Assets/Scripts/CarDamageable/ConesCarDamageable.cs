using UnityEngine;

public class ConesCarDamageable : MonoBehaviour, ICarDamageable
{
    private int _penaltyPoints = 5;
    private string _penaltyMessage = "Задели конус, начните заново";

    public string GetMistakeMessage() => _penaltyMessage;

    public int GetPenaltyPoints() => _penaltyPoints;
}