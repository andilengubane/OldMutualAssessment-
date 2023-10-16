using Xunit;
using System;
using NSubstitute;
using OldMutual.Service.Interface;

namespace OldMutual.Test
{
    public class TestDestination
    {
        [Fact]
        public static void Destination()
        {
            var destination = Substitute.For<IDestination>();
        }
    }
}
