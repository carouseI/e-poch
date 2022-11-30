using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChatBubble : MonoBehaviour
{
    #region old
    //private SpriteRenderer backgroundSpriteRenderer;
    //private SpriteRenderer iconSpriteRenderer;
    //private TextMeshPro textMeshPro;

    //[SerializeField] private Sprite happyIconSprite;
    //[SerializeField] private Sprite neutralIconSprite;
    //[SerializeField] private Sprite angryIconSprite;
    //[SerializeField] private Sprite sadIconSprite;

    //public Transform ChatBubblePrefab;

    //public static void Create(Transform parent, Vector3 localPosition)
    //{
    //    Transform chatBubbleTransform = Instantiate(GameAssets.i.ChatBubblePrefab, parent);
    //    chatBubbleTransform.localPosition = localPosition;

    //    chatBubbleTransform.GetComponent<ChatBubble>();

    //    Destroy(chatBubbleTransform.gameObject, 2f); //destroy after 4sec
    //}

    #region icon types
    //public enum IconType
    //{
    //    Happy,
    //    Neutral,
    //    Angry,
    //    Sad,
    //}
    #endregion

    //private void Awake()
    //{
    //    backgroundSpriteRenderer = transform.Find("Background").GetComponent<SpriteRenderer>();
    //    iconSpriteRenderer = transform.Find("Icon").GetComponent<SpriteRenderer>();
    //    textMeshPro = transform.Find("Text").GetComponent<TextMeshPro>();
    //}

    //private void Start()
    //{
    //    Setup("hello world");
    //}

    #region text -- match/fit bubble to text
    //private void Setup(string text)
    //{
    //textMeshPro.SetText(text);
    //textMeshPro.ForceMeshUpdate(); //call forceMesh to avoid text not rendering immediately
    //Vector2 textSize = textMeshPro.GetRenderedValues(false); //get visible render balance, match background to text -- return vector2 with size

    //Vector2 padding = new Vector2(4f, 2f);
    //backgroundSpriteRenderer.size = textSize + padding;

    //iconSpriteRenderer.sprite = GetIconSprite(iconType);
    //}
    #endregion

    #region icon
    //private Sprite GetIconSprite(IconType iconType)
    //{
    //    switch (iconType)
    //    {
    //        default:
    //        case IconType.Happy:
    //            return happyIconSprite;
    //            break;
    //        case IconType.Neutral:
    //            return neutralIconSprite;
    //            break;
    //        case IconType.Angry:
    //            return angryIconSprite;
    //            break;
    //        case IconType.Sad:
    //            return sadIconSprite;
    //            break;
    //    }
    //}
    #endregion
    #endregion
}
