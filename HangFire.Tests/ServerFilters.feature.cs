﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18052
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace HangFire.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class ServerFiltersFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ServerFilters.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Server filters", "", ProgrammingLanguage.CSharp, new string[] {
                        "redis"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Server filters")))
            {
                HangFire.Tests.ServerFiltersFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Server filters should be executed when the worker performs the job")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Server filters")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void ServerFiltersShouldBeExecutedWhenTheWorkerPerformsTheJob()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Server filters should be executed when the worker performs the job", ((string[])(null)));
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
    testRunner.Given("an enqueued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
      testRunner.And("a server filter \'test\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
     testRunner.When("the manager processes the next job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Method"});
            table1.AddRow(new string[] {
                        "test::OnPerforming"});
            table1.AddRow(new string[] {
                        "test::OnPerformed"});
#line 8
     testRunner.Then("the server filter methods should be executed in the following order:", ((string)(null)), table1, "Then ");
#line 12
      testRunner.And("the job should be performed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Multiple server filters should be executed depending on their order")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Server filters")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void MultipleServerFiltersShouldBeExecutedDependingOnTheirOrder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multiple server filters should be executed depending on their order", ((string[])(null)));
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
    testRunner.Given("an enqueued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
      testRunner.And("a server filter \'first\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
      testRunner.And("a server filter \'second\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
     testRunner.When("the manager processes the next job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Method"});
            table2.AddRow(new string[] {
                        "first::OnPerforming"});
            table2.AddRow(new string[] {
                        "second::OnPerforming"});
            table2.AddRow(new string[] {
                        "second::OnPerformed"});
            table2.AddRow(new string[] {
                        "first::OnPerformed"});
#line 19
     testRunner.Then("the server filter methods should be executed in the following order:", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("I should be able to set a job parameter in the server filter")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Server filters")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void IShouldBeAbleToSetAJobParameterInTheServerFilter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I should be able to set a job parameter in the server filter", ((string[])(null)));
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
    testRunner.Given("an enqueued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table3.AddRow(new string[] {
                        "Culture",
                        "en-US"});
            table3.AddRow(new string[] {
                        "UICulture",
                        "ru-RU"});
#line 28
      testRunner.And("the server filter \'first\' that sets the following parameters:", ((string)(null)), table3, "And ");
#line 32
     testRunner.When("the manager processes the next job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
     testRunner.Then("the job should have all of the above parameters encoded as JSON string", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 34
      testRunner.And("the job should be performed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("When I specify an empty or null parameter name, an exception should be thrown")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Server filters")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void WhenISpecifyAnEmptyOrNullParameterNameAnExceptionShouldBeThrown()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When I specify an empty or null parameter name, an exception should be thrown", ((string[])(null)));
#line 36
this.ScenarioSetup(scenarioInfo);
#line 37
    testRunner.Given("an enqueued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table4.AddRow(new string[] {
                        "",
                        "en-US"});
#line 38
      testRunner.And("the server filter \'first\' that sets the following parameters:", ((string)(null)), table4, "And ");
#line 41
     testRunner.When("the manager processes the next job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
     testRunner.Then("the job should be performed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Server filter should be able to read the job parameters")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Server filters")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void ServerFilterShouldBeAbleToReadTheJobParameters()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Server filter should be able to read the job parameters", ((string[])(null)));
#line 44
this.ScenarioSetup(scenarioInfo);
#line 45
    testRunner.Given("an enqueued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table5.AddRow(new string[] {
                        "Culture",
                        "en-GB"});
#line 46
      testRunner.And("the server filter \'first\' that sets the following parameters:", ((string)(null)), table5, "And ");
#line 49
      testRunner.And("the server filter \'second\' that reads all of the above parameters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
     testRunner.When("the manager processes the next job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
     testRunner.Then("the \'second\' server filter got the actual values of the parameters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
      testRunner.And("the job should be performed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("When I specify an empty or null parameter name in the GetParameter method call, a" +
            "n exception should be thrown")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Server filters")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void WhenISpecifyAnEmptyOrNullParameterNameInTheGetParameterMethodCallAnExceptionShouldBeThrown()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When I specify an empty or null parameter name in the GetParameter method call, a" +
                    "n exception should be thrown", ((string[])(null)));
#line 54
this.ScenarioSetup(scenarioInfo);
#line 55
    testRunner.Given("an enqueued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table6.AddRow(new string[] {
                        "",
                        "en-GB"});
#line 56
      testRunner.And("the server filter \'first\' that gets the following parameters:", ((string)(null)), table6, "And ");
#line 59
     testRunner.When("the manager processes the next job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
     testRunner.Then("the job should not be performed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Server filter should be able to cancel the performing of a job")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Server filters")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void ServerFilterShouldBeAbleToCancelThePerformingOfAJob()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Server filter should be able to cancel the performing of a job", ((string[])(null)));
#line 62
this.ScenarioSetup(scenarioInfo);
#line 63
    testRunner.Given("an enqueued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 64
      testRunner.And("a server filter \'first\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
      testRunner.And("a server filter \'second\' that cancels the performing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
      testRunner.And("a server filter \'third\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
     testRunner.When("the manager processes the next job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
     testRunner.Then("the job should not be performed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Method"});
            table7.AddRow(new string[] {
                        "first::OnPerforming"});
            table7.AddRow(new string[] {
                        "second::OnPerforming"});
            table7.AddRow(new string[] {
                        "first::OnPerformed (with the canceled flag set)"});
#line 69
      testRunner.And("only the following server filter methods should be executed:", ((string)(null)), table7, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Server filter\'s OnPerformed could be skipped if there was an exception")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Server filters")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void ServerFilterSOnPerformedCouldBeSkippedIfThereWasAnException()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Server filter\'s OnPerformed could be skipped if there was an exception", ((string[])(null)));
#line 75
this.ScenarioSetup(scenarioInfo);
#line 76
    testRunner.Given("an enqueued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 77
      testRunner.And("a server filter \'first\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
      testRunner.And("a server filter \'second\' that throws an exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
     testRunner.When("the manager processes the next job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Method"});
            table8.AddRow(new string[] {
                        "first::OnPerforming"});
            table8.AddRow(new string[] {
                        "second::OnPerforming"});
            table8.AddRow(new string[] {
                        "first::OnPerformed"});
#line 80
     testRunner.Then("only the following server filter methods should be executed:", ((string)(null)), table8, "Then ");
#line 85
      testRunner.And("the state of the job should be Failed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Server filter can handle the exception")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Server filters")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void ServerFilterCanHandleTheException()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Server filter can handle the exception", ((string[])(null)));
#line 87
this.ScenarioSetup(scenarioInfo);
#line 88
    testRunner.Given("an enqueued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 89
      testRunner.And("a server filter \'first\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
      testRunner.And("a server filter \'second\' that handles an exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
      testRunner.And("a server filter \'third\' that throws an exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
     testRunner.When("the manager processes the next job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Method"});
            table9.AddRow(new string[] {
                        "first::OnPerforming"});
            table9.AddRow(new string[] {
                        "second::OnPerforming"});
            table9.AddRow(new string[] {
                        "third::OnPerforming"});
            table9.AddRow(new string[] {
                        "second::OnPerformed"});
            table9.AddRow(new string[] {
                        "first::OnPerformed"});
#line 93
     testRunner.Then("the server filter methods should be executed in the following order:", ((string)(null)), table9, "Then ");
#line 100
      testRunner.And("the state of the job should be Succeeded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Server exception filters are executed when there was an exception while performin" +
            "g a job")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Server filters")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void ServerExceptionFiltersAreExecutedWhenThereWasAnExceptionWhilePerformingAJob()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Server exception filters are executed when there was an exception while performin" +
                    "g a job", ((string[])(null)));
#line 102
this.ScenarioSetup(scenarioInfo);
#line 103
    testRunner.Given("an enqueued broken job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 104
      testRunner.And("a server exception filter \'test\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
     testRunner.When("the manager processes the next job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 106
     testRunner.Then("the server exception filter should be executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 107
      testRunner.And("the state of the job should be Failed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Multiple server exception filters are executed depending on their order")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Server filters")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void MultipleServerExceptionFiltersAreExecutedDependingOnTheirOrder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multiple server exception filters are executed depending on their order", ((string[])(null)));
#line 109
this.ScenarioSetup(scenarioInfo);
#line 110
    testRunner.Given("an enqueued broken job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 111
      testRunner.And("a server exception filter \'first\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
      testRunner.And("a server exception filter \'second\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
     testRunner.When("the manager processes the next job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Filter"});
            table10.AddRow(new string[] {
                        "first"});
            table10.AddRow(new string[] {
                        "second"});
#line 114
     testRunner.Then("the server exception filters should be executed in the following order:", ((string)(null)), table10, "Then ");
#line 118
      testRunner.And("the state of the job should be Failed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Server exception filter can handle the exception")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Server filters")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void ServerExceptionFilterCanHandleTheException()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Server exception filter can handle the exception", ((string[])(null)));
#line 120
this.ScenarioSetup(scenarioInfo);
#line 121
    testRunner.Given("an enqueued broken job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 122
      testRunner.And("a server exception filter \'first\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
      testRunner.And("a server exception filter \'second\' that handles an exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
      testRunner.And("a server exception filter \'third\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
     testRunner.When("the manager processes the next job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Filter"});
            table11.AddRow(new string[] {
                        "first"});
            table11.AddRow(new string[] {
                        "second"});
            table11.AddRow(new string[] {
                        "third"});
#line 126
     testRunner.Then("the following server exception filters should be executed:", ((string)(null)), table11, "Then ");
#line 131
      testRunner.And("the state of the job should be Succeeded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
