using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject _container;
    [SerializeField] private int _capacity;

    private List<GameObject> _pool = new List<GameObject>();

    private const float xAbroadScreen = -2.5f;

    protected void Initialize(GameObject prefab)
    {
        for (int i = 0; i < _capacity; i++)
        {
            GameObject spawned = Instantiate(prefab, _container.transform);
            spawned.SetActive(false);

            _pool.Add(spawned);
        }
    }

    protected bool TryGetObject(out GameObject result)
    {
        result = _pool.FirstOrDefault(p => p.activeSelf == false);
        return result != null;
    }

    protected void DisableObjectAbroadScreen()
    {
        foreach (var item in _pool)
        {
            if(item.activeSelf == true)
            {
                if (item.transform.position.x < xAbroadScreen)
                {
                    item.SetActive(false);
                }
            }
        }
    }

    public void ResetPool()
    {
        for (int i = 0; i < _pool.Count; i++)
        {
            _pool[i].SetActive(false);
        }
    }
}
