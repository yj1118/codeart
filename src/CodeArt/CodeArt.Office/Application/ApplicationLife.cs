﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodeArt.AppSetting;

[assembly: PreApplicationStartAttribute(typeof(CodeArt.Office.ApplicationLife),"Init")]
[assembly: PreApplicationEndAttribute(typeof(CodeArt.Office.ApplicationLife), "Clear")]

namespace CodeArt.Office
{
    public static class ApplicationLife
    {
        public static void Init()
        {
        }

        public static void Clear()
        {
        }

    }
}
