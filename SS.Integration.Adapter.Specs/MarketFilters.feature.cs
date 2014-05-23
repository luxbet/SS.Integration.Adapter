﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18063
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SS.Integration.Adapter.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("MarketFilters")]
    public partial class MarketFiltersFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MarketFilters.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "MarketFilters", "In order to avoid redundant updates\t\r\nI want to be able to filter updates that ha" +
                    "ven\'t change a market state", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Market has 3 active selections")]
        public virtual void MarketHas3ActiveSelections()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Market has 3 active selections", ((string[])(null)));
#line 5
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Status",
                        "Tradable"});
            table1.AddRow(new string[] {
                        "1",
                        "Home",
                        "1",
                        "true"});
            table1.AddRow(new string[] {
                        "2",
                        "Away",
                        "1",
                        "true"});
            table1.AddRow(new string[] {
                        "3",
                        "Draw",
                        "1",
                        "true"});
#line 6
 testRunner.Given("Market with the following selections", ((string)(null)), table1, "Given ");
#line 11
 testRunner.When("Market filters are initiated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("Market IsSuspended is false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Market has 3 suspended selections")]
        public virtual void MarketHas3SuspendedSelections()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Market has 3 suspended selections", ((string[])(null)));
#line 14
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Status",
                        "Tradable"});
            table2.AddRow(new string[] {
                        "1",
                        "Home",
                        "1",
                        "false"});
            table2.AddRow(new string[] {
                        "2",
                        "Away",
                        "1",
                        "false"});
            table2.AddRow(new string[] {
                        "3",
                        "Draw",
                        "1",
                        "false"});
#line 15
 testRunner.Given("Market with the following selections", ((string)(null)), table2, "Given ");
#line 20
 testRunner.When("Market filters are initiated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.And("Market filters are applied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.Then("Market IsSuspended is true", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Market update was rolled back")]
        public virtual void MarketUpdateWasRolledBack()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Market update was rolled back", ((string[])(null)));
#line 24
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Status",
                        "Tradable"});
            table3.AddRow(new string[] {
                        "1",
                        "Home",
                        "1",
                        "false"});
            table3.AddRow(new string[] {
                        "2",
                        "Away",
                        "1",
                        "false"});
            table3.AddRow(new string[] {
                        "3",
                        "Draw",
                        "1",
                        "false"});
#line 25
 testRunner.Given("Market with the following selections", ((string)(null)), table3, "Given ");
#line 30
 testRunner.When("Market filters are initiated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.And("Market filters are applied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Status",
                        "Tradable"});
            table4.AddRow(new string[] {
                        "1",
                        "Home",
                        "0",
                        "false"});
            table4.AddRow(new string[] {
                        "2",
                        "Away",
                        "0",
                        "false"});
            table4.AddRow(new string[] {
                        "3",
                        "Draw",
                        "0",
                        "false"});
#line 32
 testRunner.And("Update Arrives", ((string)(null)), table4, "And ");
#line 37
 testRunner.And("Market filters are applied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("Rollback change", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Status",
                        "Tradable"});
            table5.AddRow(new string[] {
                        "1",
                        "Home",
                        "0",
                        "false"});
            table5.AddRow(new string[] {
                        "2",
                        "Away",
                        "0",
                        "false"});
            table5.AddRow(new string[] {
                        "3",
                        "Draw",
                        "0",
                        "false"});
#line 39
 testRunner.And("Update Arrives", ((string)(null)), table5, "And ");
#line 44
 testRunner.And("Market filters are applied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.And("Commit change", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.Then("Market with id=TestId is not removed from snapshot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 47
 testRunner.And("Market IsSuspended is true", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Market receives duplicated update after the first update was commited")]
        public virtual void MarketReceivesDuplicatedUpdateAfterTheFirstUpdateWasCommited()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Market receives duplicated update after the first update was commited", ((string[])(null)));
#line 49
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Status",
                        "Tradable"});
            table6.AddRow(new string[] {
                        "1",
                        "Home",
                        "0",
                        "false"});
            table6.AddRow(new string[] {
                        "2",
                        "Away",
                        "0",
                        "false"});
            table6.AddRow(new string[] {
                        "3",
                        "Draw",
                        "0",
                        "false"});
#line 50
 testRunner.Given("Market with the following selections", ((string)(null)), table6, "Given ");
#line 55
 testRunner.When("Market filters are initiated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.And("Market filters are applied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.And("Commit change", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Status",
                        "Tradable"});
            table7.AddRow(new string[] {
                        "1",
                        "Home",
                        "0",
                        "false"});
            table7.AddRow(new string[] {
                        "2",
                        "Away",
                        "0",
                        "false"});
            table7.AddRow(new string[] {
                        "3",
                        "Draw",
                        "0",
                        "false"});
#line 58
 testRunner.And("Update Arrives", ((string)(null)), table7, "And ");
#line 63
 testRunner.And("Market filters are applied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.Then("Market with id=TestId is removed from snapshot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Market initially has all selections active and later recieved an update with susp" +
            "ended selection")]
        public virtual void MarketInitiallyHasAllSelectionsActiveAndLaterRecievedAnUpdateWithSuspendedSelection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Market initially has all selections active and later recieved an update with susp" +
                    "ended selection", ((string[])(null)));
#line 67
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Status",
                        "Tradable"});
            table8.AddRow(new string[] {
                        "1",
                        "Home",
                        "1",
                        "true"});
            table8.AddRow(new string[] {
                        "2",
                        "Away",
                        "1",
                        "true"});
            table8.AddRow(new string[] {
                        "3",
                        "Draw",
                        "1",
                        "true"});
#line 68
 testRunner.Given("Market with the following selections", ((string)(null)), table8, "Given ");
#line 73
 testRunner.When("Market filters are initiated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
 testRunner.And("Market filters are applied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.And("Commit change", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Status",
                        "Tradable"});
            table9.AddRow(new string[] {
                        "2",
                        "Away",
                        "1",
                        "false"});
#line 76
 testRunner.And("Update Arrives", ((string)(null)), table9, "And ");
#line 79
 testRunner.And("Market filters are applied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.Then("Market IsSuspended is false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Market initially has all selections active and later receives update making it al" +
            "l suspended")]
        public virtual void MarketInitiallyHasAllSelectionsActiveAndLaterReceivesUpdateMakingItAllSuspended()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Market initially has all selections active and later receives update making it al" +
                    "l suspended", ((string[])(null)));
#line 82
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Status",
                        "Tradable"});
            table10.AddRow(new string[] {
                        "1",
                        "Home",
                        "1",
                        "true"});
            table10.AddRow(new string[] {
                        "2",
                        "Away",
                        "1",
                        "true"});
            table10.AddRow(new string[] {
                        "3",
                        "Draw",
                        "1",
                        "true"});
#line 83
 testRunner.Given("Market with the following selections", ((string)(null)), table10, "Given ");
#line 88
 testRunner.When("Market filters are initiated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 89
 testRunner.And("Market filters are applied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.And("Commit change", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Status",
                        "Tradable"});
            table11.AddRow(new string[] {
                        "1",
                        "Home",
                        "1",
                        "false"});
            table11.AddRow(new string[] {
                        "2",
                        "Away",
                        "1",
                        "false"});
            table11.AddRow(new string[] {
                        "3",
                        "Draw",
                        "1",
                        "false"});
#line 91
 testRunner.And("Update Arrives", ((string)(null)), table11, "And ");
#line 96
 testRunner.And("Market filters are applied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.Then("Market IsSuspended is true", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Market becomes partially void")]
        public virtual void MarketBecomesPartiallyVoid()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Market becomes partially void", ((string[])(null)));
#line 99
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Status",
                        "Tradable"});
            table12.AddRow(new string[] {
                        "1",
                        "Home",
                        "1",
                        "true"});
            table12.AddRow(new string[] {
                        "2",
                        "Away",
                        "1",
                        "true"});
            table12.AddRow(new string[] {
                        "3",
                        "Draw",
                        "1",
                        "true"});
#line 100
 testRunner.Given("Market with the following selections", ((string)(null)), table12, "Given ");
#line 105
 testRunner.When("Market filters are initiated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Status",
                        "Tradable"});
            table13.AddRow(new string[] {
                        "1",
                        "Home",
                        "3",
                        "false"});
            table13.AddRow(new string[] {
                        "2",
                        "Away",
                        "1",
                        "true"});
            table13.AddRow(new string[] {
                        "3",
                        "Draw",
                        "3",
                        "false"});
#line 106
 testRunner.And("Update Arrives", ((string)(null)), table13, "And ");
#line 111
 testRunner.Then("Market IsSuspended is false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Market becomes partially void and is suspended")]
        public virtual void MarketBecomesPartiallyVoidAndIsSuspended()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Market becomes partially void and is suspended", ((string[])(null)));
#line 113
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Status",
                        "Tradable"});
            table14.AddRow(new string[] {
                        "1",
                        "Home",
                        "1",
                        "true"});
            table14.AddRow(new string[] {
                        "2",
                        "Away",
                        "1",
                        "true"});
            table14.AddRow(new string[] {
                        "3",
                        "Draw",
                        "1",
                        "true"});
#line 114
 testRunner.Given("Market with the following selections", ((string)(null)), table14, "Given ");
#line 119
 testRunner.When("Market filters are initiated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 120
 testRunner.And("Market filters are applied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
 testRunner.And("Commit change", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Status",
                        "Tradable"});
            table15.AddRow(new string[] {
                        "1",
                        "Home",
                        "3",
                        "false"});
            table15.AddRow(new string[] {
                        "2",
                        "Away",
                        "1",
                        "false"});
            table15.AddRow(new string[] {
                        "3",
                        "Draw",
                        "3",
                        "false"});
#line 122
 testRunner.And("Update Arrives", ((string)(null)), table15, "And ");
#line 127
 testRunner.And("Market filters are applied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 128
 testRunner.Then("Market IsSuspended is true", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Market is partially settled")]
        public virtual void MarketIsPartiallySettled()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Market is partially settled", ((string[])(null)));
#line 130
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Status",
                        "Tradable"});
            table16.AddRow(new string[] {
                        "1",
                        "Home",
                        "1",
                        "true"});
            table16.AddRow(new string[] {
                        "2",
                        "Away",
                        "1",
                        "true"});
            table16.AddRow(new string[] {
                        "3",
                        "Draw",
                        "0",
                        "false"});
#line 131
 testRunner.Given("Market with the following selections", ((string)(null)), table16, "Given ");
#line 136
 testRunner.When("Market filters are initiated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 137
 testRunner.And("Market filters are applied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
 testRunner.And("Commit change", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Status",
                        "Tradable",
                        "Price"});
            table17.AddRow(new string[] {
                        "1",
                        "Home",
                        "2",
                        "false",
                        "1.0"});
            table17.AddRow(new string[] {
                        "2",
                        "Away",
                        "2",
                        "false",
                        "0"});
#line 139
 testRunner.And("Update Arrives", ((string)(null)), table17, "And ");
#line 143
 testRunner.And("Market filters are applied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 144
 testRunner.And("Commit change", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Status",
                        "Tradable",
                        "Price"});
            table18.AddRow(new string[] {
                        "1",
                        "Home",
                        "2",
                        "false",
                        "1.0"});
            table18.AddRow(new string[] {
                        "2",
                        "Away",
                        "2",
                        "false",
                        "0"});
            table18.AddRow(new string[] {
                        "3",
                        "Draw",
                        "2",
                        "false",
                        "0"});
#line 145
 testRunner.And("Update Arrives", ((string)(null)), table18, "And ");
#line 150
 testRunner.And("Market filters are applied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 151
 testRunner.And("Commit change", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 152
 testRunner.Then("Market with id=TestId is not removed from snapshot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Voiding markets should not be applied markets that were previously active")]
        public virtual void VoidingMarketsShouldNotBeAppliedMarketsThatWerePreviouslyActive()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Voiding markets should not be applied markets that were previously active", ((string[])(null)));
#line 154
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Status",
                        "Tradable"});
            table19.AddRow(new string[] {
                        "1",
                        "Home",
                        "1",
                        "true"});
            table19.AddRow(new string[] {
                        "2",
                        "Away",
                        "1",
                        "true"});
            table19.AddRow(new string[] {
                        "3",
                        "Draw",
                        "1",
                        "true"});
#line 155
 testRunner.Given("Market with the following selections", ((string)(null)), table19, "Given ");
#line 160
 testRunner.When("Market filters are initiated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 161
 testRunner.And("Market filters are applied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 162
 testRunner.And("Fixture is over", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 163
 testRunner.And("Request voiding", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 164
 testRunner.Then("Market Voided=false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Voiding markets should be applied to markets which have never been active")]
        public virtual void VoidingMarketsShouldBeAppliedToMarketsWhichHaveNeverBeenActive()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Voiding markets should be applied to markets which have never been active", ((string[])(null)));
#line 166
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Status",
                        "Tradable"});
            table20.AddRow(new string[] {
                        "1",
                        "Home",
                        "0",
                        "false"});
            table20.AddRow(new string[] {
                        "2",
                        "Away",
                        "0",
                        "false"});
            table20.AddRow(new string[] {
                        "3",
                        "Draw",
                        "0",
                        "false"});
#line 167
 testRunner.Given("Market with the following selections", ((string)(null)), table20, "Given ");
#line 172
 testRunner.When("Market filters are initiated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 173
 testRunner.And("Market filters are applied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 174
 testRunner.And("Commit change", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 175
 testRunner.And("Fixture is over", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 176
 testRunner.And("Request voiding", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 177
 testRunner.Then("Market Voided=true", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
