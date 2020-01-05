﻿using Lemon.UI;
using System.Collections.Generic;

namespace Lemon.UI.Sample
{
    public sealed class UISample1 : UIBase
    {
        private void Start()
        {
            List<int> _waitNodes = ListPool<int>.Get();
            for (int i = 0; i < 1; i++)
            {
                _waitNodes.Add(i);
            }

            List<int> tmp = new List<int>();
            tmp.AddRange(_waitNodes);
            ListPool<int>.Release(_waitNodes);
        }
    }
}