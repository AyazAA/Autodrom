using Assets.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

    // 1 - �������� ��� ������ � ����, 2 - �������� ��� ��������, 3 - ���� �������� ������
public class CarCheck : MonoBehaviour
{
    [SerializeField] private List<MistakeControl> _mistakeControls;
    [SerializeField] private BoxCollider _garageCollider;
    [SerializeField] private BoxCollider _finishCollider;
    [SerializeField] private TMP_Text _resultTMP;
    private bool _droveInto = false;
    private int _penaltyPoints = 0;
    private int _maxPenaltyPoints = 4;

    private void Awake()
    {
        foreach (var mistakeControl in _mistakeControls)
        {
            mistakeControl.MistakeOccurredEvent += CarGetPenaltyInfo;
        }
    }

    private void OnDestroy()
    {
        foreach (var mistakeControl in _mistakeControls)
        {
            mistakeControl.MistakeOccurredEvent -= CarGetPenaltyInfo;
        }
    }

    private void CarGetPenaltyInfo(int penaltyPoints, string mistakeMessage)
    {
        _penaltyPoints += penaltyPoints;
        if (_penaltyPoints <= _maxPenaltyPoints)
        {
            StartCoroutine(StopErrorMessage());
        }
        _resultTMP.text = mistakeMessage;
        _resultTMP.gameObject.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        // �������� ������ �� � �����
        if (_garageCollider.bounds.Contains(other.bounds.min) && _garageCollider.bounds.Contains(other.bounds.max) && !_droveInto)
        {
            _droveInto = true;
        }
        // �������� ������
        else if (_finishCollider.bounds.Contains(other.bounds.min) && _finishCollider.bounds.Contains(other.bounds.max))
        {
            if (_droveInto && _penaltyPoints <= _maxPenaltyPoints)
            {
                _resultTMP.text = $"��������� ������� ����� � {_penaltyPoints} ��������� �������";
            }
            else
            {
                _resultTMP.text = $"��������� �� ����� � {_penaltyPoints} ��������� �������";
            }
            _resultTMP.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    private IEnumerator StopErrorMessage()
    {
        yield return new WaitForSeconds(4f);
        _resultTMP.gameObject.SetActive(false);
    }
}
