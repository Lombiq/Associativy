﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Orchard.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("DateTime Field")]
    public partial class DateTimeFieldFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DateTime.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "DateTime Field", "  In order to add Date content to my types\r\n  As an administrator\r\n  I want to cr" +
                    "eate, edit and publish DateTime fields", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Creating and using Date fields")]
        public virtual void CreatingAndUsingDateFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Creating and using Date fields", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 9
    testRunner.Given("I have installed Orchard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
        testRunner.And("I have installed \"Orchard.Fields\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
    testRunner.When("I go to \"Admin/ContentTypes\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
    testRunner.Then("I should see \"<a[^>]*>.*?Create new type</a>\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
    testRunner.When("I go to \"Admin/ContentTypes/Create\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table1.AddRow(new string[] {
                        "DisplayName",
                        "Event"});
            table1.AddRow(new string[] {
                        "Name",
                        "Event"});
#line 14
        testRunner.And("I fill in", ((string)(null)), table1, "And ");
#line 18
        testRunner.And("I hit \"Create\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
        testRunner.And("I go to \"Admin/ContentTypes/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
    testRunner.Then("I should see \"Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
        testRunner.And("I follow \"Add Field\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table2.AddRow(new string[] {
                        "DisplayName",
                        "Date of the event"});
            table2.AddRow(new string[] {
                        "Name",
                        "EventDate"});
            table2.AddRow(new string[] {
                        "FieldTypeName",
                        "DateTimeField"});
#line 25
        testRunner.And("I fill in", ((string)(null)), table2, "And ");
#line 30
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
    testRunner.Then("I should see \"The \\\"Date of the event\\\" field has been added.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
    testRunner.When("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
    testRunner.Then("I should see \"Date of the event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table3.AddRow(new string[] {
                        "Event.EventDate.Editor.Date",
                        "31/01/2012"});
            table3.AddRow(new string[] {
                        "Event.EventDate.Editor.Time",
                        "12:00 AM"});
#line 37
    testRunner.When("I fill in", ((string)(null)), table3, "When ");
#line 41
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
    testRunner.Then("I should see \"Date of the event could not be parsed as a valid date and time\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 45
    testRunner.When("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
    testRunner.Then("I should see \"Date of the event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table4.AddRow(new string[] {
                        "Event.EventDate.Editor.Date",
                        "01/31/2012"});
#line 47
    testRunner.When("I fill in", ((string)(null)), table4, "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table5.AddRow(new string[] {
                        "Event.EventDate.Editor.Time",
                        "12:00 AM"});
#line 50
        testRunner.And("I fill in", ((string)(null)), table5, "And ");
#line 53
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
    testRunner.Then("I should see \"Your Event has been created.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 56
    testRunner.When("I go to \"Admin/Contents/List\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
    testRunner.Then("I should see \"Date of the event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 58
        testRunner.And("I should see \"1/31/2012 12:00\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table6.AddRow(new string[] {
                        "Fields[0].DateTimeFieldSettings.Hint",
                        "Enter the date of the event"});
#line 62
        testRunner.And("I fill in", ((string)(null)), table6, "And ");
#line 65
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
        testRunner.And("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
    testRunner.Then("I should see \"Enter the date of the event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 70
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table7.AddRow(new string[] {
                        "Fields[0].DateTimeFieldSettings.Display",
                        "DateOnly"});
#line 71
        testRunner.And("I fill in", ((string)(null)), table7, "And ");
#line 74
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
        testRunner.And("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
    testRunner.Then("I should see \"Event.EventDate.Editor.Date\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 77
        testRunner.And("I should not see \"Event.EventDate.Editor.Time\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table8.AddRow(new string[] {
                        "Fields[0].DateTimeFieldSettings.Display",
                        "TimeOnly"});
#line 81
        testRunner.And("I fill in", ((string)(null)), table8, "And ");
#line 84
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
        testRunner.And("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
    testRunner.Then("I should see \"Event.EventDate.Editor.Time\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 87
        testRunner.And("I should not see \"Event.EventDate.Editor.Date\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table9.AddRow(new string[] {
                        "Fields[0].DateTimeFieldSettings.Display",
                        "DateAndTime"});
            table9.AddRow(new string[] {
                        "Fields[0].DateTimeFieldSettings.Required",
                        "true"});
#line 91
        testRunner.And("I fill in", ((string)(null)), table9, "And ");
#line 95
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
        testRunner.And("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
    testRunner.Then("I should see \"Event.EventDate.Editor.Date\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table10.AddRow(new string[] {
                        "Event.EventDate.Editor.Date",
                        "01/31/2012"});
            table10.AddRow(new string[] {
                        "Event.EventDate.Editor.Time",
                        "12:00 AM"});
#line 98
    testRunner.When("I fill in", ((string)(null)), table10, "When ");
#line 102
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
    testRunner.Then("I should see \"Your Event has been created.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 105
    testRunner.When("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table11.AddRow(new string[] {
                        "Event.EventDate.Editor.Date",
                        "01/31/2012"});
#line 106
     testRunner.And("I fill in", ((string)(null)), table11, "And ");
#line 109
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
    testRunner.Then("I should see \"Date of the event is required.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 111
    testRunner.When("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table12.AddRow(new string[] {
                        "Event.EventDate.Editor.Time",
                        "12:00 AM"});
#line 112
     testRunner.And("I fill in", ((string)(null)), table12, "And ");
#line 115
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
    testRunner.Then("I should see \"Date of the event is required.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 119
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table13.AddRow(new string[] {
                        "Fields[0].DateTimeFieldSettings.Display",
                        "DateOnly"});
            table13.AddRow(new string[] {
                        "Fields[0].DateTimeFieldSettings.Required",
                        "true"});
#line 120
        testRunner.And("I fill in", ((string)(null)), table13, "And ");
#line 124
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
        testRunner.And("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
    testRunner.Then("I should see \"Event.EventDate.Editor.Date\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 127
    testRunner.When("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 128
    testRunner.Then("I should see \"Date of the event is required.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 131
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table14.AddRow(new string[] {
                        "Fields[0].DateTimeFieldSettings.Display",
                        "TimeOnly"});
            table14.AddRow(new string[] {
                        "Fields[0].DateTimeFieldSettings.Required",
                        "true"});
#line 132
        testRunner.And("I fill in", ((string)(null)), table14, "And ");
#line 136
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
        testRunner.And("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
    testRunner.Then("I should see \"Event.EventDate.Editor.Date\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 139
    testRunner.When("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 140
    testRunner.Then("I should see \"Date of the event is required.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Creating and using date time fields in another culture")]
        public virtual void CreatingAndUsingDateTimeFieldsInAnotherCulture()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Creating and using date time fields in another culture", ((string[])(null)));
#line 142
this.ScenarioSetup(scenarioInfo);
#line 145
    testRunner.Given("I have installed Orchard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 146
        testRunner.And("I have installed \"Orchard.Fields\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 147
        testRunner.And("I have the file \"Content\\orchard.core.po\" in \"Core\\App_Data\\Localization\\fr-FR\\or" +
                    "chard.core.po\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 148
    testRunner.When("I go to \"Admin/ContentTypes\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 149
    testRunner.Then("I should see \"<a[^>]*>.*?Create new type</a>\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 150
    testRunner.When("I go to \"Admin/ContentTypes/Create\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table15.AddRow(new string[] {
                        "DisplayName",
                        "Event"});
            table15.AddRow(new string[] {
                        "Name",
                        "Event"});
#line 151
        testRunner.And("I fill in", ((string)(null)), table15, "And ");
#line 155
        testRunner.And("I hit \"Create\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 156
        testRunner.And("I go to \"Admin/ContentTypes/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 157
    testRunner.Then("I should see \"Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 160
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 161
        testRunner.And("I follow \"Add Field\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table16.AddRow(new string[] {
                        "DisplayName",
                        "Date of the event"});
            table16.AddRow(new string[] {
                        "Name",
                        "EventDate"});
            table16.AddRow(new string[] {
                        "FieldTypeName",
                        "DateTimeField"});
#line 162
        testRunner.And("I fill in", ((string)(null)), table16, "And ");
#line 167
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 168
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 169
    testRunner.Then("I should see \"The \\\"Date of the event\\\" field has been added.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 172
    testRunner.When("I have \"fr-FR\" as the default culture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 173
        testRunner.And("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table17.AddRow(new string[] {
                        "Fields[0].DateTimeFieldSettings.Display",
                        "DateAndTime"});
            table17.AddRow(new string[] {
                        "Fields[0].DateTimeFieldSettings.Required",
                        "true"});
#line 174
        testRunner.And("I fill in", ((string)(null)), table17, "And ");
#line 178
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 179
    testRunner.When("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table18.AddRow(new string[] {
                        "Event.EventDate.Editor.Date",
                        "01/31/2012"});
            table18.AddRow(new string[] {
                        "Event.EventDate.Editor.Time",
                        "12:00 AM"});
#line 180
        testRunner.And("I fill in", ((string)(null)), table18, "And ");
#line 184
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 185
    testRunner.Then("I should see \"Date of the event could not be parsed as a valid date and time\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 186
    testRunner.When("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table19.AddRow(new string[] {
                        "Event.EventDate.Editor.Date",
                        "31/01/2012"});
            table19.AddRow(new string[] {
                        "Event.EventDate.Editor.Time",
                        "18:00"});
#line 187
        testRunner.And("I fill in", ((string)(null)), table19, "And ");
#line 191
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 192
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 193
    testRunner.Then("I should see \"Your Event has been created.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
