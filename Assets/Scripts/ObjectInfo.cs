using UnityEngine;

public class ObjectInfo : MonoBehaviour
{
    public int objectHealth;
    bool typeWood;
    bool typeMetal;

    void Start()
    {
        ObjectMaterial();
    }

    void Update()
    {
        healthSystem();
    }

    void healthSystem()
    {
        if (objectHealth <= 0)
        {

        }
    }

    void ObjectMaterial()
    {
        if (tag.Contains("wood"))
        {
            objectHealth = 5;
        }

        if (tag.Contains("metal"))
        {
            objectHealth = 1000;
        }
    }
}
