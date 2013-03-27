﻿using System;

namespace TfsCreateBuild
{
    public class Configuration
    {
        public string Collection { get; set; }

        public string Project { get; set; }

        public string BuildDefinition { get; set; }

        public string BuildNumber { get; set; }

        public string BuildStatus { get; set; }

        public string BuildFlavor { get; set; }

        public string BuildPlatform { get; set; }

        public string BuildTarget { get; set; }

        public string LocalPath { get; set; }

        public string ServerPath { get; set; }

        public string DropPath { get; set; }

        public string TestResults { get; set; }

        public string BuildLog { get; set; }

        public bool CreateBuildDefinitionIfNotExists { get; set; }

        public string BuildController { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? FinishTime { get; set; }

        public bool PublishTestRun1 { get; set; }

        public int? TestSuiteId { get; set; }

        public int? TestConfigId { get; set; }

        public string TestRunTitle { get; set; }

        public string TestRunResultOwner { get; set; }

        public bool FixTestIds { get; set; }

        public string TeamcityBuildId { get; set; }
    }
}