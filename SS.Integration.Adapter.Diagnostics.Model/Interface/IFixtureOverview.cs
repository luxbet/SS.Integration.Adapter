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

using System;
using System.Collections.Generic;
using SS.Integration.Adapter.Model.Enums;

namespace SS.Integration.Adapter.Diagnostics.Model.Interface
{
    public interface IFixtureOverview : IFixtureOverviewDelta
    {
        string Name { get; set; }
        string Sport { get; }

        string CompetitionId { get; }
        string CompetitionName { get; }
        
        MatchStatus? MatchStatus { get; set; }
        DateTime TimeStamp { get; }
        
        IEnumerable<ErrorOverview> GetErrorsAudit(int limit = 0);
        IEnumerable<FeedUpdateOverview> GetFeedAudit(int limit = 0);
    }
}
