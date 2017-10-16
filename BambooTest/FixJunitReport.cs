/*
 * Created by Ranorex
 * User: sknopper
 * Date: 8/25/2017
 * Time: 10:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

using WinForms = System.Windows.Forms;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Reporting;
using Ranorex.Core.Testing;

namespace ReportToPDF
{
    /// <summary>
    /// Description of FixJunitReport.
    /// </summary>
    [TestModule("F82F7249-7693-46BD-9BDA-0C8DB5CFC8DE", ModuleType.UserCode, 1)]
    public class FixJunitReport : ITestModule
    {
    	
    	static bool registered = false;
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FixJunitReport()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
        	if (!registered)
        	{
        		TestSuite.TestSuiteCompleted += delegate {	
            
			var reportFileDirectory = TestReport.ReportEnvironment.ReportFileDirectory;
			var name = TestReport.ReportEnvironment.ReportName;
			
			TestReport.EndTestModule();
			
			string input = String.Format(@"{0}\{1}.rxlog.junit.xml", reportFileDirectory, name);
			if (!File.Exists(input))
			{
				Report.Log(ReportLevel.Error, "Unable to find file: " + input);
			}
			
			string text = File.ReadAllText(input);
			Report.Log(ReportLevel.Success, text.Length.ToString());
//			text = text.Replace("<error", "<failure");
//			text = text.Replace("</error", "</failure");
			File.WriteAllText(input.Replace(".rxlog.junit.xml", "_fixed.rxlog.junit_1.xml"), text);
			Report.Log(ReportLevel.Success, "Junit test fixed");
        		};
        		
        		registered = true;
        	}
        	
        }
    }
}
