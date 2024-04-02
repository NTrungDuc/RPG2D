using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    void OnEnter(EnemyController bot);
    void OnExecute(EnemyController bot);
    void OnExit(EnemyController bot);
}
