﻿// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Compute.v1.Data;
using GoogleCloudExtension.DataSources;
using System.ComponentModel;

namespace GoogleCloudExtension.CloudExplorerSources.Gce
{
    /// <summary>
    /// This class represents a GCE instance that is running the ASP.NET image in the
    /// Properties window.
    /// </summary>
    public class AspNetInstanceItem : GceInstanceItem
    {
        private const string AspNetCategory = "ASP.NET Properties";

        public AspNetInstanceItem(Instance instance) : base(instance)
        { }

        [Category(AspNetCategory)]
        [Description("The password for the sa user in the SQL Server installed in the instance.")]
        [DisplayName("SQL Server Password")]
        public string SqlServerPassword => Instance.GetSqlServerPassword();
    }
}
