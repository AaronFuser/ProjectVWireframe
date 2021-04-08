using UnityEngine;
[CreateAssetMenu(fileName = "NewTransfer", menuName = "ScriptableObject/Transfer")]
public class ScriptableTransfer : ScriptableObject
{
    public ScriptableItem _value;

    private void OnEnable()
    {
        _value = null;
    }
}