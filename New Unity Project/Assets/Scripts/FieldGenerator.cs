using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldGenerator : MonoBehaviour
{
    [System.Serializable]
    private struct FieldSize
    {
        public int X;
        public int Y;

    }

    [SerializeField] private GameObject cellPrefab;
    [SerializeField] private FieldSize fieldSize;

    [ContextMenu("Generate Field")]
    public void GenrateField()
    {
        var parent = new GameObject("GameField");
        for(int i = 0; i < fieldSize.X; i++)
        {
            for(int j = 0; j < fieldSize.Y; j++)
            {
                var position = new Vector3(i, 0, j);
                var cellClone = Instantiate(cellPrefab, position, Quaternion.identity);
                cellClone.transform.SetParent(parent.transform);

                var name = $"Cell X:{i} Y:{j}";
                cellClone.name = name;
            }
        }
    }
}
