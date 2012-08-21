﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.239
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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Users")]
    public partial class UsersFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Users.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Users", "  In order to prevent users module regressions\r\n  As a site owner\r\n  I want to cr" +
                    "eate, search and modify user accounts", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("There is only one user by default")]
        [NUnit.Framework.CategoryAttribute("management")]
        public virtual void ThereIsOnlyOneUserByDefault()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("There is only one user by default", new string[] {
                        "management"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
    testRunner.Given("I have installed Orchard");
#line 9
    testRunner.When("I go to \"admin/users\"");
#line 10
    testRunner.Then("I should see \"Users\"");
#line 11
        testRunner.And("I should see \"<a[^>]*>admin</a>\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can create a new user")]
        [NUnit.Framework.CategoryAttribute("management")]
        public virtual void ICanCreateANewUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can create a new user", new string[] {
                        "management"});
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
    testRunner.Given("I have installed Orchard");
#line 16
    testRunner.When("I go to \"admin/users\"");
#line 17
    testRunner.Then("I should see \"Users\"");
#line 18
    testRunner.When("I follow \"Add a new user\"");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table1.AddRow(new string[] {
                        "UserName",
                        "user1"});
            table1.AddRow(new string[] {
                        "Email",
                        "user1@domain.com"});
            table1.AddRow(new string[] {
                        "Password",
                        "a12345!"});
            table1.AddRow(new string[] {
                        "ConfirmPassword",
                        "a12345!"});
#line 19
        testRunner.And("I fill in", ((string)(null)), table1);
#line 25
        testRunner.And("I hit \"Save\"");
#line 26
        testRunner.And("I am redirected");
#line 27
    testRunner.Then("I should see \"User created\"");
#line 28
    testRunner.When("I follow \"Add a new user\"");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table2.AddRow(new string[] {
                        "UserName",
                        "user2"});
            table2.AddRow(new string[] {
                        "Email",
                        "user2@domain.com"});
            table2.AddRow(new string[] {
                        "Password",
                        "a12345!"});
            table2.AddRow(new string[] {
                        "ConfirmPassword",
                        "a12345!"});
            table2.AddRow(new string[] {
                        "UserRoles.Roles[0].Granted",
                        "true"});
#line 29
        testRunner.And("I fill in", ((string)(null)), table2);
#line 36
        testRunner.And("I hit \"Save\"");
#line 37
        testRunner.And("I am redirected");
#line 38
    testRunner.Then("I should see \"User created\"");
#line 39
        testRunner.And("I should see \"Adding role Administrator to user user2\"");
#line 40
    testRunner.When("I follow \"Add a new user\"");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table3.AddRow(new string[] {
                        "UserName",
                        "user3"});
            table3.AddRow(new string[] {
                        "Email",
                        "user3@domain.com"});
            table3.AddRow(new string[] {
                        "Password",
                        "a12345!"});
            table3.AddRow(new string[] {
                        "ConfirmPassword",
                        "a12345!"});
            table3.AddRow(new string[] {
                        "UserRoles.Roles[0].Granted",
                        "true"});
            table3.AddRow(new string[] {
                        "UserRoles.Roles[1].Granted",
                        "true"});
            table3.AddRow(new string[] {
                        "UserRoles.Roles[2].Granted",
                        "true"});
            table3.AddRow(new string[] {
                        "UserRoles.Roles[3].Granted",
                        "true"});
            table3.AddRow(new string[] {
                        "UserRoles.Roles[4].Granted",
                        "true"});
#line 41
        testRunner.And("I fill in", ((string)(null)), table3);
#line 52
        testRunner.And("I hit \"Save\"");
#line 53
        testRunner.And("I am redirected");
#line 54
    testRunner.Then("I should see \"User created\"");
#line 55
        testRunner.And("I should see \"Adding role Administrator to user user3\"");
#line 56
        testRunner.And("I should see \"Adding role Editor to user user3\"");
#line 57
        testRunner.And("I should see \"Adding role Moderator to user user3\"");
#line 58
        testRunner.And("I should see \"Adding role Author to user user3\"");
#line 59
        testRunner.And("I should see \"Adding role Contributor to user user3\"");
#line 60
    testRunner.When("I follow \"Add a new user\"");
#line 61
        testRunner.And("I hit \"Save\"");
#line 62
    testRunner.Then("I should see \"The UserName field is required.\"");
#line 63
    testRunner.Then("I should see \"The Email field is required.\"");
#line 64
    testRunner.Then("I should see \"The Password field is required.\"");
#line 65
    testRunner.Then("I should see \"The ConfirmPassword field is required.\"");
#line 66
    testRunner.When("I go to \"admin/users\"");
#line 67
        testRunner.And("I follow \"Add a new user\"");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table4.AddRow(new string[] {
                        "UserName",
                        "user4"});
            table4.AddRow(new string[] {
                        "Email",
                        "user4@domain.com"});
            table4.AddRow(new string[] {
                        "Password",
                        "a12345!"});
            table4.AddRow(new string[] {
                        "ConfirmPassword",
                        "a123456!"});
#line 68
        testRunner.And("I fill in", ((string)(null)), table4);
#line 74
        testRunner.And("I hit \"Save\"");
#line 75
    testRunner.Then("I should see \"Password confirmation must match\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can edit an existing user")]
        [NUnit.Framework.CategoryAttribute("management")]
        public virtual void ICanEditAnExistingUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can edit an existing user", new string[] {
                        "management"});
#line 78
this.ScenarioSetup(scenarioInfo);
#line 79
    testRunner.Given("I have installed Orchard");
#line 80
    testRunner.When("I go to \"admin/users\"");
#line 81
        testRunner.And("I follow \"Add a new user\"");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table5.AddRow(new string[] {
                        "UserName",
                        "user1"});
            table5.AddRow(new string[] {
                        "Email",
                        "user1@domain.com"});
            table5.AddRow(new string[] {
                        "Password",
                        "a12345!"});
            table5.AddRow(new string[] {
                        "ConfirmPassword",
                        "a12345!"});
#line 82
        testRunner.And("I fill in", ((string)(null)), table5);
#line 88
        testRunner.And("I hit \"Save\"");
#line 89
        testRunner.And("I am redirected");
#line 90
    testRunner.Then("I should see \"User created\"");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table6.AddRow(new string[] {
                        "Options.Search",
                        "user1"});
#line 91
    testRunner.When("I fill in", ((string)(null)), table6);
#line 94
        testRunner.And("I hit \"Filter\"");
#line 95
    testRunner.Then("I should see \"<a[^>]*>user1</a>\"");
#line 96
    testRunner.When("I follow \"Edit\"");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table7.AddRow(new string[] {
                        "UserName",
                        "user2"});
            table7.AddRow(new string[] {
                        "Email",
                        "user2@domain.com"});
#line 97
        testRunner.And("I fill in", ((string)(null)), table7);
#line 101
        testRunner.And("I hit \"Save\"");
#line 102
        testRunner.And("I am redirected");
#line 103
    testRunner.Then("I should see \"User information updated\"");
#line 104
        testRunner.And("I should see \"<a[^>]*>user2</a>\"");
#line 105
        testRunner.And("I should see \"user2@domain.com\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I should not be able to reuse an existing username or email")]
        [NUnit.Framework.CategoryAttribute("management")]
        public virtual void IShouldNotBeAbleToReuseAnExistingUsernameOrEmail()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I should not be able to reuse an existing username or email", new string[] {
                        "management"});
#line 108
this.ScenarioSetup(scenarioInfo);
#line 109
    testRunner.Given("I have installed Orchard");
#line 110
    testRunner.When("I go to \"admin/users\"");
#line 112
        testRunner.And("I follow \"Add a new user\"");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table8.AddRow(new string[] {
                        "UserName",
                        "user1"});
            table8.AddRow(new string[] {
                        "Email",
                        "user1@domain.com"});
            table8.AddRow(new string[] {
                        "Password",
                        "a12345!"});
            table8.AddRow(new string[] {
                        "ConfirmPassword",
                        "a12345!"});
#line 113
        testRunner.And("I fill in", ((string)(null)), table8);
#line 119
        testRunner.And("I hit \"Save\"");
#line 120
        testRunner.And("I am redirected");
#line 122
        testRunner.And("I follow \"Add a new user\"");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table9.AddRow(new string[] {
                        "UserName",
                        "user2"});
            table9.AddRow(new string[] {
                        "Email",
                        "user2@domain.com"});
            table9.AddRow(new string[] {
                        "Password",
                        "a12345!"});
            table9.AddRow(new string[] {
                        "ConfirmPassword",
                        "a12345!"});
#line 123
        testRunner.And("I fill in", ((string)(null)), table9);
#line 129
        testRunner.And("I hit \"Save\"");
#line 130
        testRunner.And("I am redirected");
#line 131
    testRunner.Then("I should see \"<a[^>]*>user1</a>\"");
#line 132
        testRunner.And("I should see \"<a[^>]*>user2</a>\"");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table10.AddRow(new string[] {
                        "Options.Search",
                        "user1"});
#line 134
    testRunner.When("I fill in", ((string)(null)), table10);
#line 137
        testRunner.And("I hit \"Filter\"");
#line 138
    testRunner.Then("I should see \"<a[^>]*>user1</a>\"");
#line 139
    testRunner.When("I follow \"Edit\"");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table11.AddRow(new string[] {
                        "UserName",
                        "user2"});
            table11.AddRow(new string[] {
                        "Email",
                        "user1@domain.com"});
#line 140
        testRunner.And("I fill in", ((string)(null)), table11);
#line 144
        testRunner.And("I hit \"Save\"");
#line 145
    testRunner.Then("I should see \"User with that username and/or email already exists.\"");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table12.AddRow(new string[] {
                        "UserName",
                        "user1"});
            table12.AddRow(new string[] {
                        "Email",
                        "user2@domain.com"});
#line 146
    testRunner.When("I fill in", ((string)(null)), table12);
#line 150
        testRunner.And("I hit \"Save\"");
#line 151
    testRunner.Then("I should see \"User with that username and/or email already exists.\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I should be able to remove an existing user")]
        [NUnit.Framework.CategoryAttribute("management")]
        [NUnit.Framework.IgnoreAttribute()]
        public virtual void IShouldBeAbleToRemoveAnExistingUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I should be able to remove an existing user", new string[] {
                        "management",
                        "ignore"});
#line 155
this.ScenarioSetup(scenarioInfo);
#line 156
    testRunner.Given("I have installed Orchard");
#line 157
    testRunner.When("I go to \"admin/users\"");
#line 159
        testRunner.And("I follow \"Add a new user\"");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table13.AddRow(new string[] {
                        "UserName",
                        "user1"});
            table13.AddRow(new string[] {
                        "Email",
                        "user1@domain.com"});
            table13.AddRow(new string[] {
                        "Password",
                        "a12345!"});
            table13.AddRow(new string[] {
                        "ConfirmPassword",
                        "a12345!"});
#line 160
        testRunner.And("I fill in", ((string)(null)), table13);
#line 166
        testRunner.And("I hit \"Save\"");
#line 167
        testRunner.And("I am redirected");
#line 168
    testRunner.Then("I should see \"<a[^>]*>user1</a>\"");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table14.AddRow(new string[] {
                        "Options.Search",
                        "user1"});
#line 170
    testRunner.When("I fill in", ((string)(null)), table14);
#line 173
        testRunner.And("I hit \"Filter\"");
#line 174
    testRunner.Then("I should see \"<a[^>]*>user1</a>\"");
#line 175
    testRunner.When("I follow \"Delete\"");
#line 176
        testRunner.And("I am redirected");
#line 177
    testRunner.Then("I should see \"User user1 deleted\"");
#line 178
        testRunner.And("I should not see \"<a[^>]*>user1</a>\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I should not be able to filter users by name")]
        [NUnit.Framework.CategoryAttribute("filtering")]
        public virtual void IShouldNotBeAbleToFilterUsersByName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I should not be able to filter users by name", new string[] {
                        "filtering"});
#line 181
this.ScenarioSetup(scenarioInfo);
#line 182
    testRunner.Given("I have installed Orchard");
#line 183
    testRunner.When("I go to \"admin/users\"");
#line 185
        testRunner.And("I follow \"Add a new user\"");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table15.AddRow(new string[] {
                        "UserName",
                        "user1"});
            table15.AddRow(new string[] {
                        "Email",
                        "user1@domain.com"});
            table15.AddRow(new string[] {
                        "Password",
                        "a12345!"});
            table15.AddRow(new string[] {
                        "ConfirmPassword",
                        "a12345!"});
#line 186
        testRunner.And("I fill in", ((string)(null)), table15);
#line 192
        testRunner.And("I hit \"Save\"");
#line 193
        testRunner.And("I am redirected");
#line 195
        testRunner.And("I follow \"Add a new user\"");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table16.AddRow(new string[] {
                        "UserName",
                        "user2"});
            table16.AddRow(new string[] {
                        "Email",
                        "user2@domain.com"});
            table16.AddRow(new string[] {
                        "Password",
                        "a12345!"});
            table16.AddRow(new string[] {
                        "ConfirmPassword",
                        "a12345!"});
#line 196
        testRunner.And("I fill in", ((string)(null)), table16);
#line 202
        testRunner.And("I hit \"Save\"");
#line 203
        testRunner.And("I am redirected");
#line 204
    testRunner.Then("I should see \"<a[^>]*>user1</a>\"");
#line 205
        testRunner.And("I should see \"<a[^>]*>user2</a>\"");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table17.AddRow(new string[] {
                        "Options.Search",
                        "user1"});
#line 206
    testRunner.When("I fill in", ((string)(null)), table17);
#line 209
        testRunner.And("I hit \"Filter\"");
#line 210
    testRunner.Then("I should see \"<a[^>]*>user1</a>\"");
#line 211
        testRunner.And("I should not see \"<a[^>]*>admin</a>\"");
#line 212
        testRunner.And("I should not see \"<a[^>]*>user2</a>\"");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table18.AddRow(new string[] {
                        "Options.Search",
                        "user1@domain.com"});
#line 213
    testRunner.When("I fill in", ((string)(null)), table18);
#line 216
        testRunner.And("I hit \"Filter\"");
#line 217
    testRunner.Then("I should see \"<a[^>]*>user1</a>\"");
#line 218
        testRunner.And("I should not see \"<a[^>]*>admin</a>\"");
#line 219
        testRunner.And("I should not see \"<a[^>]*>user2</a>\"");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table19.AddRow(new string[] {
                        "Options.Search",
                        "@domain.com"});
#line 220
    testRunner.When("I fill in", ((string)(null)), table19);
#line 223
        testRunner.And("I hit \"Filter\"");
#line 224
    testRunner.Then("I should see \"<a[^>]*>user1</a>\"");
#line 225
        testRunner.And("I should see \"<a[^>]*>user2</a>\"");
#line 226
        testRunner.And("I should not see \"<a[^>]*>admin</a>\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I should be able to filter users by status")]
        [NUnit.Framework.CategoryAttribute("filtering")]
        public virtual void IShouldBeAbleToFilterUsersByStatus()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I should be able to filter users by status", new string[] {
                        "filtering"});
#line 229
this.ScenarioSetup(scenarioInfo);
#line 230
    testRunner.Given("I have installed Orchard");
#line 231
    testRunner.When("I go to \"admin/users\"");
#line 233
        testRunner.And("I follow \"Add a new user\"");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table20.AddRow(new string[] {
                        "UserName",
                        "user1"});
            table20.AddRow(new string[] {
                        "Email",
                        "user1@domain.com"});
            table20.AddRow(new string[] {
                        "Password",
                        "a12345!"});
            table20.AddRow(new string[] {
                        "ConfirmPassword",
                        "a12345!"});
#line 234
        testRunner.And("I fill in", ((string)(null)), table20);
#line 240
        testRunner.And("I hit \"Save\"");
#line 241
        testRunner.And("I am redirected");
#line 243
        testRunner.And("I follow \"Add a new user\"");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table21.AddRow(new string[] {
                        "UserName",
                        "user2"});
            table21.AddRow(new string[] {
                        "Email",
                        "user2@domain.com"});
            table21.AddRow(new string[] {
                        "Password",
                        "a12345!"});
            table21.AddRow(new string[] {
                        "ConfirmPassword",
                        "a12345!"});
#line 244
        testRunner.And("I fill in", ((string)(null)), table21);
#line 250
        testRunner.And("I hit \"Save\"");
#line 251
        testRunner.And("I am redirected");
#line 252
    testRunner.Then("I should see \"<a[^>]*>user1</a>\"");
#line 253
        testRunner.And("I should see \"<a[^>]*>user2</a>\"");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table22.AddRow(new string[] {
                        "Options.Search",
                        "user1"});
#line 254
    testRunner.When("I fill in", ((string)(null)), table22);
#line 257
        testRunner.And("I hit \"Filter\"");
#line 258
    testRunner.Then("I should see \"<a[^>]*>user1</a>\"");
#line 259
    testRunner.When("I follow \"Disable\"");
#line 260
        testRunner.And("I am redirected");
#line 261
    testRunner.Then("I should see \"User user1 disabled\"");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table23.AddRow(new string[] {
                        "Options.Filter",
                        "Pending"});
#line 262
    testRunner.When("I fill in", ((string)(null)), table23);
#line 265
        testRunner.And("I hit \"Filter\"");
#line 266
    testRunner.Then("I should see \"<a[^>]*>user1</a>\"");
#line 267
        testRunner.And("I should not see \"<a[^>]*>user2</a>\"");
#line 268
        testRunner.And("I should not see \"<a[^>]*>admin</a>\"");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table24.AddRow(new string[] {
                        "Options.Filter",
                        "EmailPending"});
#line 269
    testRunner.When("I fill in", ((string)(null)), table24);
#line 272
        testRunner.And("I hit \"Filter\"");
#line 273
    testRunner.Then("I should not see \"<a[^>]*>user1</a>\"");
#line 274
        testRunner.And("I should not see \"<a[^>]*>user2</a>\"");
#line 275
        testRunner.And("I should not see \"<a[^>]*>admin</a>\"");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table25.AddRow(new string[] {
                        "Options.Filter",
                        "Approved"});
#line 276
    testRunner.When("I fill in", ((string)(null)), table25);
#line 279
        testRunner.And("I hit \"Filter\"");
#line 280
    testRunner.Then("I should not see \"<a[^>]*>user1</a>\"");
#line 281
        testRunner.And("I should see \"<a[^>]*>user2</a>\"");
#line 282
        testRunner.And("I should see \"<a[^>]*>admin</a>\"");
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table26.AddRow(new string[] {
                        "Options.Filter",
                        "All"});
#line 283
    testRunner.When("I fill in", ((string)(null)), table26);
#line 286
        testRunner.And("I hit \"Filter\"");
#line 287
    testRunner.Then("I should see \"<a[^>]*>user1</a>\"");
#line 288
        testRunner.And("I should see \"<a[^>]*>user2</a>\"");
#line 289
        testRunner.And("I should see \"<a[^>]*>admin</a>\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I should not be able to add users with invalid email addresses")]
        [NUnit.Framework.CategoryAttribute("email")]
        public virtual void IShouldNotBeAbleToAddUsersWithInvalidEmailAddresses()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I should not be able to add users with invalid email addresses", new string[] {
                        "email"});
#line 291
this.ScenarioSetup(scenarioInfo);
#line 292
    testRunner.Given("I have installed Orchard");
#line 293
    testRunner.When("I go to \"admin/users\"");
#line 294
        testRunner.And("I follow \"Add a new user\"");
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table27.AddRow(new string[] {
                        "UserName",
                        "user1"});
            table27.AddRow(new string[] {
                        "Email",
                        "NotAnEmail"});
            table27.AddRow(new string[] {
                        "Password",
                        "a12345!"});
            table27.AddRow(new string[] {
                        "ConfirmPassword",
                        "a12345!"});
#line 295
        testRunner.And("I fill in", ((string)(null)), table27);
#line 301
        testRunner.And("I hit \"Save\"");
#line 302
    testRunner.Then("I should see \"You must specify a valid email address.\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I should be able to add users with valid email addresses")]
        [NUnit.Framework.CategoryAttribute("email")]
        public virtual void IShouldBeAbleToAddUsersWithValidEmailAddresses()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I should be able to add users with valid email addresses", new string[] {
                        "email"});
#line 304
this.ScenarioSetup(scenarioInfo);
#line 305
    testRunner.Given("I have installed Orchard");
#line 306
    testRunner.When("I go to \"admin/users\"");
#line 307
        testRunner.And("I follow \"Add a new user\"");
#line hidden
            TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table28.AddRow(new string[] {
                        "UserName",
                        "user1"});
            table28.AddRow(new string[] {
                        "Email",
                        "user1@domain.com"});
            table28.AddRow(new string[] {
                        "Password",
                        "a12345!"});
            table28.AddRow(new string[] {
                        "ConfirmPassword",
                        "a12345!"});
#line 308
        testRunner.And("I fill in", ((string)(null)), table28);
#line 314
        testRunner.And("I hit \"Save\"");
#line 315
        testRunner.And("I am redirected");
#line 316
    testRunner.Then("I should see \"User created\"");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
