/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribePostgresExtensionsResponseUnmarshaller
    {
        public static DescribePostgresExtensionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePostgresExtensionsResponse describePostgresExtensionsResponse = new DescribePostgresExtensionsResponse();

			describePostgresExtensionsResponse.HttpResponse = _ctx.HttpResponse;
			describePostgresExtensionsResponse.RequestId = _ctx.StringValue("DescribePostgresExtensions.RequestId");
			describePostgresExtensionsResponse.Overview = _ctx.StringValue("DescribePostgresExtensions.Overview");

			List<DescribePostgresExtensionsResponse.DescribePostgresExtensions_Extension> describePostgresExtensionsResponse_uninstalledExtensions = new List<DescribePostgresExtensionsResponse.DescribePostgresExtensions_Extension>();
			for (int i = 0; i < _ctx.Length("DescribePostgresExtensions.UninstalledExtensions.Length"); i++) {
				DescribePostgresExtensionsResponse.DescribePostgresExtensions_Extension extension = new DescribePostgresExtensionsResponse.DescribePostgresExtensions_Extension();
				extension.Name = _ctx.StringValue("DescribePostgresExtensions.UninstalledExtensions["+ i +"].Name");
				extension.DefaultVersion = _ctx.StringValue("DescribePostgresExtensions.UninstalledExtensions["+ i +"].DefaultVersion");
				extension.InstalledVersion = _ctx.StringValue("DescribePostgresExtensions.UninstalledExtensions["+ i +"].InstalledVersion");
				extension.Comment = _ctx.StringValue("DescribePostgresExtensions.UninstalledExtensions["+ i +"].Comment");
				extension.Owner = _ctx.StringValue("DescribePostgresExtensions.UninstalledExtensions["+ i +"].Owner");
				extension.Priority = _ctx.StringValue("DescribePostgresExtensions.UninstalledExtensions["+ i +"].Priority");
				extension.Requires = _ctx.StringValue("DescribePostgresExtensions.UninstalledExtensions["+ i +"].Requires");
				extension.Category = _ctx.StringValue("DescribePostgresExtensions.UninstalledExtensions["+ i +"].Category");

				describePostgresExtensionsResponse_uninstalledExtensions.Add(extension);
			}
			describePostgresExtensionsResponse.UninstalledExtensions = describePostgresExtensionsResponse_uninstalledExtensions;

			List<DescribePostgresExtensionsResponse.DescribePostgresExtensions_Extension> describePostgresExtensionsResponse_installedExtensions = new List<DescribePostgresExtensionsResponse.DescribePostgresExtensions_Extension>();
			for (int i = 0; i < _ctx.Length("DescribePostgresExtensions.InstalledExtensions.Length"); i++) {
				DescribePostgresExtensionsResponse.DescribePostgresExtensions_Extension extension = new DescribePostgresExtensionsResponse.DescribePostgresExtensions_Extension();
				extension.Name = _ctx.StringValue("DescribePostgresExtensions.InstalledExtensions["+ i +"].Name");
				extension.DefaultVersion = _ctx.StringValue("DescribePostgresExtensions.InstalledExtensions["+ i +"].DefaultVersion");
				extension.InstalledVersion = _ctx.StringValue("DescribePostgresExtensions.InstalledExtensions["+ i +"].InstalledVersion");
				extension.Comment = _ctx.StringValue("DescribePostgresExtensions.InstalledExtensions["+ i +"].Comment");
				extension.Owner = _ctx.StringValue("DescribePostgresExtensions.InstalledExtensions["+ i +"].Owner");
				extension.Priority = _ctx.StringValue("DescribePostgresExtensions.InstalledExtensions["+ i +"].Priority");
				extension.Requires = _ctx.StringValue("DescribePostgresExtensions.InstalledExtensions["+ i +"].Requires");
				extension.Category = _ctx.StringValue("DescribePostgresExtensions.InstalledExtensions["+ i +"].Category");

				describePostgresExtensionsResponse_installedExtensions.Add(extension);
			}
			describePostgresExtensionsResponse.InstalledExtensions = describePostgresExtensionsResponse_installedExtensions;
        
			return describePostgresExtensionsResponse;
        }
    }
}
