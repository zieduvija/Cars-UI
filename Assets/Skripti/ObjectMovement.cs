using UnityEngine;
using UnityEngine.UI;

public class ObjectMovement : MonoBehaviour
{
    public float speed = 2f; 
    public RectTransform startPoint; 
    public Texture2D[] carTextures;
    private Image carImage;
    private int currentTextureIndex = 0;
    private bool textureChanged = false;
    private Vector2 initialPosition;

    private void Start()
    {
        carImage = GetComponent<Image>();
        carImage.sprite = Sprite.Create(carTextures[currentTextureIndex], new Rect(0, 0, carTextures[currentTextureIndex].width, carTextures[currentTextureIndex].height), Vector2.one * 0.5f);
        initialPosition = startPoint.anchoredPosition;
    }

    private void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        
        if (!IsVisibleOnScreen() && !textureChanged)
        {
            startPoint.anchoredPosition = initialPosition;
            
            currentTextureIndex = (currentTextureIndex + 1) % carTextures.Length;
            carImage.sprite = Sprite.Create(carTextures[currentTextureIndex], new Rect(0, 0, carTextures[currentTextureIndex].width, carTextures[currentTextureIndex].height), Vector2.one * 0.5f);

            textureChanged = true;
        }
        
        if (IsVisibleOnScreen() && textureChanged)
        {
            textureChanged = false;
        }
    }

    private bool IsVisibleOnScreen()
    {
        var canvasRect = GetComponentInParent<Canvas>().GetComponent<RectTransform>();
        var carRect = GetComponent<RectTransform>();

        Vector3[] carCorners = new Vector3[4];
        carRect.GetWorldCorners(carCorners);

        Vector3[] canvasCorners = new Vector3[4];
        canvasRect.GetWorldCorners(canvasCorners);

        for (int i = 0; i < 4; i++)
        {
            if (RectTransformUtility.RectangleContainsScreenPoint(canvasRect, carCorners[i]))
            {
                return true;
            }
        }

        return false;
    }
}
