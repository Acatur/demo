
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.WSA;

public class Random : MonoBehaviour
{
    static public string isCoursor;




    public float reapitRate = 3f;
    public GameObject[] mass;
    private int rans;
    [SerializeField] Transform TypePainParent;
    [Tooltip("Максимальное количество элементов на сцене")][SerializeField] int maxCoutn;
    private int alreadyCount;

    fastInventoryClick fastInventoryClick;

    private string[] tags = { "yellowPoint", "bluePoint", "greenPoint", "redPoint" };

    void Start()
    {
        InstantiateObjects();


    }

    public void InstantiateObjects()
    {
        for (int i = 0; i < maxCoutn; i++)
        {
            GameObject go = Instantiate(mass[rans], new Vector2(UnityEngine.Random.Range(-Screen.width / 45, Screen.width / 45), UnityEngine.Random.Range(-Screen.height / 20, Screen.height / 20)), Quaternion.identity);
            go.transform.SetParent(TypePainParent, false);
            go.tag = tags[rans];


        }
    }

    public void DestroyObject(GameObject obj)
    {

        if (obj.tag == isCoursor)
        {
            Destroy(obj);
            rans = UnityEngine.Random.Range(0, mass.Length);
            InstantiateObjects();
        }




    }
} 

