using UnityEngine;
using UnityEngine.UI;

public class SwapImage : MonoBehaviour
{
    [SerializeField] private Sprite _pic1;
    [SerializeField] private Sprite _pic2;
    private Image _image;

    private void Start()
    {
        _image = GetComponent<Image>();
        _image.sprite = _pic1;
    }

    public void SwapImages()
    {
        if (_image.sprite == _pic1)
        {
            _image.sprite = _pic2;
        }
        else if (_image.sprite == _pic2)
        {
            _image.sprite = _pic1;
        }
    }
}
