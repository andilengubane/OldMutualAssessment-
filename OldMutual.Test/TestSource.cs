using Xunit;
using System;
using NSubstitute;
using OldMutual.Service.Interface;

namespace OldMutual.Test
{
    public class TestSource
    {
        [Fact]
        public static void Source()
        {
            var source = Substitute.For<ISource>();
        }
    }
}
