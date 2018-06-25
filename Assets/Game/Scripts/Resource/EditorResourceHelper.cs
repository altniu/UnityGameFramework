﻿//-----------------------------------------------------------------------
// <copyright>
//     Copyright (c) 2018 Zhang Yang. All rights reserved.
// </copyright>
// <describe> #编辑器资源加载类# </describe>
// <email> yeozhang@qq.com </email>
// <time> #2018年6月25日 12点06分# </time>
//-----------------------------------------------------------------------

#if UNITY_EDITOR

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;

namespace GameFramework.Taurus
{
    public class EditorResourceHelper : IResourceHelper
    {
        public void SetResourcePath(PathType pathType, string rootAssetBundle = "AssetBundles/AssetBundles")
        {
        }

        /// <summary>
        /// 加载资源
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="assetName"></param>
        /// <returns></returns>
        public T LoadAsset<T>(string assetName) where T : Object
        {
            return AssetDatabase.LoadAssetAtPath<T>(assetName);
        }

        /// <summary>
        /// 异步加载场景
        /// </summary>
        /// <param name="sceneName"></param>
        public AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode = LoadSceneMode.Additive)
        {
            return UnitySceneManager.LoadSceneAsync(sceneName, mode);
        }

        /// <summary>
        /// 卸载场景
        /// </summary>
        /// <param name="sceneName"></param>
        public void UnloadScene(string sceneName)
        {
            UnitySceneManager.UnloadScene(sceneName);
        }

        /// <summary>
        /// 清理资源
        /// </summary>
        public void Clear()
        {
        }
    }
}

#endif