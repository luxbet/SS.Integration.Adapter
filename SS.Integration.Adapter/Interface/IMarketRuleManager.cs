﻿//Copyright 2014 Spin Services Limited

//Licensed under the Apache License, Version 2.0 (the "License");
//you may not use this file except in compliance with the License.
//You may obtain a copy of the License at

//    http://www.apache.org/licenses/LICENSE-2.0

//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS,
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//See the License for the specific language governing permissions and
//limitations under the License.

using SS.Integration.Adapter.Model;
using SS.Integration.Adapter.Model.Interfaces;

namespace SS.Integration.Adapter.Interface
{
    public interface IMarketRulesManager
    {

        /// <summary>
        /// Allows to apply the registered rules to the given fixture.
        /// 
        /// A rule can edit/remove/add markets as it wishes 
        /// (through intents, see IMarketRule)
        /// 
        /// However, as there might be multiple rules, conflicts usually
        /// arise. When there is a conflict, the IMarketRuleManager
        /// always takes a conservative approach.
        /// 
        /// </summary>
        /// <param name="fixture"></param>
        void ApplyRules(Fixture fixture);

        void RollbackChanges();

        void CommitChanges();

        IMarketStateCollection CurrentState { get; }

        void OnFixtureUnPublished();
    }
}
