﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Test
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class FeatureWithIgnoredScenariosFeature : Xunit.IClassFixture<FeatureWithIgnoredScenariosFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FeatureWithIgnoredScenarios.feature"
#line hidden
        
        public FeatureWithIgnoredScenariosFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FeatureWithIgnoredScenarios", "\tA feature with some ignored scenarios", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
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
        
        public virtual void SetFixture(FeatureWithIgnoredScenariosFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.TraitAttribute("FeatureTitle", "FeatureWithIgnoredScenarios")]
        [Xunit.TraitAttribute("Description", "Some ignored scenario")]
        [Xunit.FactAttribute(Skip="Ignored")]
        public virtual void SomeIgnoredScenario()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Some ignored scenario", new string[] {
                        "ignore"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given("I will fail", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TraitAttribute("FeatureTitle", "FeatureWithIgnoredScenarios")]
        [Xunit.TraitAttribute("Description", "Some ignored scenario with retries")]
        [Xunit.TraitAttribute("Category", "retry")]
        [Xunit.RetryAttribute(3, Skip="Ignored")]
        public virtual void SomeIgnoredScenarioWithRetries()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Some ignored scenario with retries", new string[] {
                        "ignore",
                        "retry"});
#line 10
this.ScenarioSetup(scenarioInfo);
#line 11
 testRunner.Given("I will fail", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                FeatureWithIgnoredScenariosFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                FeatureWithIgnoredScenariosFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
