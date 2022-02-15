using Assets.Scripts;
using TMPro;
using UnityEngine;

public class CarCheck : MonoBehaviour
{
    [SerializeField] private PlayerSettings _playerSettings;
    [SerializeField] private CarCollisions _carCollisions;
    [SerializeField] private BoxCollider _garageCollider;
    [SerializeField] private BoxCollider _finishCollider;
    [SerializeField] private TMP_Text _resultTMP;
    private bool _droveInto = false;
    private bool _reverseGear = false;
    private bool _touchedCone = false;
    private int _reverseCanCount = 1;

    private void Awake()
    {
        _carCollisions.CarCollidedConeEvent += OnCarCollidedCone;
    }


    private void Update()
    {
        if (_playerSettings.PlayerInput.GetVerticalInput < 0 && _reverseCanCount > 0)
        {
            _reverseGear = true;
        }
        else if (_playerSettings.PlayerInput.GetVerticalInput < 0 && _reverseCanCount <= 0)
        {
            _reverseGear = true;
            _resultTMP.text = "Нельзя больше одного раза переключаться на заднюю передачу";
            _resultTMP.gameObject.SetActive(true);
        }
        else if (_playerSettings.PlayerInput.GetVerticalInput > 0)
        {
            if (_reverseGear)
            {
                _reverseCanCount--;
                _reverseGear = false;
                if (!_droveInto)
                {
                    _resultTMP.text = "Вы не заехали в гараж, за одно включение задней передачи";
                    _resultTMP.gameObject.SetActive(true);
                }
            }
        }
    }

    private void OnCarCollidedCone()
    {
        _touchedCone = true;
        _resultTMP.text = "Задели конус, начните заново";
        _resultTMP.gameObject.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        if (_garageCollider.bounds.Contains(other.bounds.min) && _garageCollider.bounds.Contains(other.bounds.max) && !_droveInto)
        {
            _droveInto = true;
        }
        else if (_finishCollider.bounds.Contains(other.bounds.min) && _finishCollider.bounds.Contains(other.bounds.max))
        {
            if (_droveInto && _reverseCanCount >= 0 && !_touchedCone)
            {
                _resultTMP.text = "Вы заехали в гараж";
                _resultTMP.gameObject.SetActive(true);
            }
        }
    }
}
