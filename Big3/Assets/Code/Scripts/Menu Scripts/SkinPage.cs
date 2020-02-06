using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinPage : MonoBehaviour
{
    public enum DIRECTION
    {
        FORWARD,
        BACKWARDS
    }

    public GameObject activeSkinHolder;

    private CircularBuffer<GameObject> skinsDB;
    private GameObject globalManager;

    private int i = 0;
    private int cnt = 1;

    private Transform activeSkinHolderTransform;

    [SerializeField]
    private GameObject[] activeSkinList;

    private void Awake()
    {
        activeSkinHolderTransform = activeSkinHolder.transform;
        activeSkinList = new GameObject[activeSkinHolderTransform.childCount];

        foreach (Transform child in activeSkinHolderTransform)
        {
            Debug.Log(child.gameObject.name);
            activeSkinList[i] = child.gameObject;
            i++;
        }

        skinsDB = GenerateDB();
    }

    public void ChangeActiveSkins(DIRECTION direction)
    {
        switch (direction)
        {
            case DIRECTION.FORWARD:
                for (int i = 0; i < activeSkinList.Length; i++)
                {
                    activeSkinList[i].GetComponent<Image>().color = skinsDB[(i + Mathf.Abs(cnt)) % skinsDB.Count].GetComponent<SpriteRenderer>().color;
                }
                cnt++;

                break;
            case DIRECTION.BACKWARDS:
                for (int i = activeSkinList.Length - 1; i > -1; i--)
                {
                    if ( (i - cnt)  > 0)
                    {
                        activeSkinList[i].GetComponent<Image>().color = skinsDB[(i - cnt) % skinsDB.Count].GetComponent<SpriteRenderer>().color;
                    }
                    else
                    {
                        activeSkinList[i].GetComponent<Image>().color = skinsDB[(cnt - i) % skinsDB.Count].GetComponent<SpriteRenderer>().color;
                    }
                }
                cnt--;

                break;
            default:
                throw new System.ArgumentOutOfRangeException("direction");
        }
    }

    private CircularBuffer<GameObject> GenerateDB()
    {
        globalManager = GlobalManager.Instance.gameObject;

        List<GameObject> db = globalManager.GetComponent<SkinDB>().getSkins();
        CircularBuffer<GameObject> cB = new CircularBuffer<GameObject>(db.Count);

        for (int i = 0; i < db.Count; i++)
        {
            cB.Enqueue(db[i]);
        }

        return cB;
    }
}
