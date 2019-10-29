using UnityEngine;

public class ObjectComponent <T> {
  public T comp;

  public ObjectComponent(GameObject target) {
    comp = target.GetComponent<T>();
  }
}
