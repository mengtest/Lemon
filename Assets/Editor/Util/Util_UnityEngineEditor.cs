﻿using UnityEngine;
using UnityEditor;

namespace Lemon
{
    public static partial class UtilEditor
    {
        public static T ExtensionComponentWhenCreate<T>(string name) where T : Component
        {
            GameObject go = new GameObject(name);
            if (Selection.gameObjects.Length != 0)
            {
                GameObject parent = Selection.gameObjects[0];
                //设置父节点
                go.transform.SetParent(parent.transform, false);
                //设置和父节点一样的层级
                go.layer = parent.layer;
            }
            //设置选中
            Selection.activeObject = go;
            return go.AddComponent<T>();
        }
    }
}
