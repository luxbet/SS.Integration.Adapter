//Copyright 2014 Spin Services Limited

//Licensed under the Apache License, Version 2.0 (the "License");
//you may not use this file except in compliance with the License.
//You may obtain a copy of the License at

//    http://www.apache.org/licenses/LICENSE-2.0

//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS,
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//See the License for the specific language governing permissions and
//limitations under the License.

using FluentAssertions;
using NUnit.Framework;
using SS.Integration.Adapter.Diagnostics.Model;

namespace SS.Integration.Adapter.Diagnostics.Testing
{
    [TestFixture]
    public class SportOverviewTest
    {
        [Test]
        public void EqualityTest()
        {
            //objects should be equal

            var sport = new SportOverview()
            {
                InErrorState = 3,
                InPlay = 4,
                InPreMatch = 5,
                InSetup = 7,
                Name = "Tennis",
                Total = 3 + 4 + 5
            };

            var secondSport = new SportOverview()
            {
                InErrorState = 3,
                InPlay = 4,
                InPreMatch = 5,
                InSetup = 7,
                Name = "Tennis",
                Total = 3 + 4 + 5
            };

            sport.Equals(secondSport).Should().BeTrue();
        }

        [Test]
        public void EqualityTestOnNonEqualObjectsTest()
        {
            //objects should be equal

            var sport = new SportOverview()
            {
                InErrorState = 30,
                InPlay = 4,
                InPreMatch = 5,
                InSetup = 7,
                Name = "Tennis",
                Total = 3 + 4 + 5
            };

            var secondSport = new SportOverview()
            {
                InErrorState = 3,
                InPlay = 4,
                InPreMatch = 5,
                Name = "Tennis",
                Total = 3 + 4 + 5
            };

            sport.Equals(secondSport).Should().BeFalse();
        }
    }
}

