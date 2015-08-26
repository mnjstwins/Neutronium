﻿using MVVM.HTML.Core.JavascriptEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xilium.CefGlue;

namespace MVVM.Cef.Glue.Test.CefWindowless
{
    public class TestCefGlueHTMLWindowProvider : IHTMLWindowProvider
    {
        public TestCefGlueHTMLWindowProvider(CefFrame iFrame)
        {
            HTMLWindow = new TestCefGlueWindow(iFrame);
        }
        public HTML.Core.Window.IHTMLWindow HTMLWindow
        {
            get;
            private set;
        }

        public HTML.Core.Window.IDispatcher UIDispatcher
        {
            get { return new TestIUIDispatcher(); }
        }

        public void Show()
        {
        }

        public void Hide()
        {
        }

        public void Dispose()
        {
        }
    }
}
