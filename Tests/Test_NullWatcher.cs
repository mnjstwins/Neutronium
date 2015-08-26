﻿using MVVM.Cef.Glue.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentAssertions;
using NSubstitute;
using Xunit;
using MVVM.HTML.Core;
using MVVM.HTML.Core.Navigation;

namespace MVVM.Cef.Glue.Test
{
    public class Test_NullWatcher
    {
        private IWebSessionWatcher _NullWatcher = new NullWatcher();
       
        [Fact]
        public void Test_LogCritical()
        {
            _NullWatcher.LogCritical(string.Empty);
        }

        [Fact]
        public void Test_LogBrowser()
        {
            _NullWatcher.LogBrowser(string.Empty);
        }


        [Fact]
        public void Test_OnSessionError()
        {
            _NullWatcher.OnSessionError(new Exception(), () => { });
        }
    }
}
