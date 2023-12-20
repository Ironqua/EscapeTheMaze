using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInputReader
{ 
  Vector3 Direction { get; }
    Vector2 Rotation { get; }
    bool ýsAttackButtonPress { get; }
}
