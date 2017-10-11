﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace BambooTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("c3510294-3278-43a8-938f-f7428a50afaa", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BambooTestRepository repository.
        /// </summary>
        public static BambooTestRepository repo = BambooTestRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://orf.at' with browser 'IE' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("https://orf.at", "IE", "", false, false, false, false, false);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Src='http://orf.at/mojo/1_3/storyserver//news/news/images/flags/flag.wahl17.svg') on item 'NewsORFAt.Wahl17'.", repo.NewsORFAt.Wahl17Info, new RecordItemIndex(1));
            Validate.Attribute(repo.NewsORFAt.Wahl17Info, "Src", "http://orf.at/mojo/1_3/storyserver//news/news/images/flags/flag.wahl17.svg");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Title='Wahl 17') on item 'NewsORFAt.Wahl17'.", repo.NewsORFAt.Wahl17Info, new RecordItemIndex(2));
            Validate.Attribute(repo.NewsORFAt.Wahl17Info, "Title", "Wahl 17");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewsORFAt.DropdownToggle' at 5;12.", repo.NewsORFAt.DropdownToggleInfo, new RecordItemIndex(3));
            repo.NewsORFAt.DropdownToggle.Click("5;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewsORFAt.Steiermark' at 12;6.", repo.NewsORFAt.SteiermarkInfo, new RecordItemIndex(4));
            repo.NewsORFAt.Steiermark.Click("12;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewsORFAt.TVthek' at 22;2.", repo.NewsORFAt.TVthekInfo, new RecordItemIndex(5));
            repo.NewsORFAt.TVthek.Click("22;2");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
