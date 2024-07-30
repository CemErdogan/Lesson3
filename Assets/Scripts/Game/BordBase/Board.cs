using UnityEngine;
using Zenject;

public class Board : MonoBehaviour
{
    [SerializeField] private Transform cellParent;
    
    [Inject] private Cell.CellFactory _cellFactory;
    
    public int Rows { get; private set; }
    public int Cols { get; private set; }
    public Cell[,] Cells { get; private set; }
}
