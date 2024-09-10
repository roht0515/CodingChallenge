using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.IO;
using CodingChallenge.Logger;

namespace UnitTests
{
    internal class LoggerTests
    {

        [Test]
        public void TestLogMessageCreatesFileAndWritesLog()
        {
             string testFile = "test_application.log";
             if (File.Exists(testFile))
             {
                 File.Delete(testFile);
             }
             Logger.log_message(testFile, "Test log entry", Severity.INFO);
             Assert.That(File.Exists(testFile), "Log file was not created.");
             string[] logContent = File.ReadAllLines(testFile);
             Assert.That(logContent[0].Contains("[INFO] Test log entry"));
             File.Delete(testFile);
             
        }

        [Test]
        public void TestLogInfoContent()
        {
            string testFile = "test_application.log";
            if (File.Exists(testFile))
            {
                File.Delete(testFile);
            }
            Logger.log_message(testFile, "Test log entry", Severity.INFO);
            string[] logContent = File.ReadAllLines(testFile);
            Assert.That(logContent[0].Contains("[INFO] Test log entry"));
            File.Delete(testFile);
        }

        [Test]
        public void TestLogWarningContent()
        {
            string testFile = "test_application.log";
            if (File.Exists(testFile))
            {
                File.Delete(testFile);
            }
            Logger.log_message(testFile, "Test log entry", Severity.WARNING);
            string[] logContent = File.ReadAllLines(testFile);
            Assert.That(logContent[0].Contains("[WARNING] Test log entry"));
            File.Delete(testFile);
        }

        [Test]
        public void TestLogCriticalContent()
        {
            string testFile = "test_application.log";
            if (File.Exists(testFile))
            {
                File.Delete(testFile);
            }
            Logger.log_message(testFile, "Test log entry", Severity.CRITICAL);
            string[] logContent = File.ReadAllLines(testFile);
            Assert.That(logContent[0].Contains("[CRITICAL] Test log entry"));
            File.Delete(testFile);
        }
    }
}
