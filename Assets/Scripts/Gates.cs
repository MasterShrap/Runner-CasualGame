using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum DeformationType 
{
    Width,
    Height
}

public class Gates : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMeshPro;
    [SerializeField] private Image _topImage;
    [SerializeField] private Image _glassImage;
    [SerializeField] private Image _deformationWidth;
    [SerializeField] private Image _deformationHeight;

    private Color _color;

    public void UpdateVisual(DeformationType type, int value)
    {
        _color = value >= 0? Color.green : Color.red;
        
        _topImage.color = _color;
        _glassImage.color = new Color(_color.r, _color.g, _color.b, 0.2f);
        
        _textMeshPro.text = value.ToString();

        if(type == DeformationType.Width)
        {
            SetActive( _deformationHeight,false);
            SetActive(_deformationWidth, true);
        }
        else
        {
            SetActive( _deformationHeight,true);
            SetActive(_deformationWidth, false);
        }
    }

    private void SetActive(Image img, bool value)
    {
        img.gameObject.SetActive(value);
    }

}
