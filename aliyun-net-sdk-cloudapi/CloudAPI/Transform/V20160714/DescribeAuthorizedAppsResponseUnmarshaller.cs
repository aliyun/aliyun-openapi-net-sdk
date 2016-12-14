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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CloudAPI.Model.V20160714;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribeAuthorizedAppsResponseUnmarshaller
    {
        public static DescribeAuthorizedAppsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAuthorizedAppsResponse describeAuthorizedAppsResponse = new DescribeAuthorizedAppsResponse();

			describeAuthorizedAppsResponse.HttpResponse = context.HttpResponse;
			describeAuthorizedAppsResponse.RequestId = context.StringValue("DescribeAuthorizedApps.RequestId");
			describeAuthorizedAppsResponse.TotalCount = context.IntegerValue("DescribeAuthorizedApps.TotalCount");
			describeAuthorizedAppsResponse.PageSize = context.IntegerValue("DescribeAuthorizedApps.PageSize");
			describeAuthorizedAppsResponse.PageNumber = context.IntegerValue("DescribeAuthorizedApps.PageNumber");

			List<DescribeAuthorizedAppsResponse.AuthorizedApp> authorizedApps = new List<DescribeAuthorizedAppsResponse.AuthorizedApp>();
			for (int i = 0; i < context.Length("DescribeAuthorizedApps.AuthorizedApps.Length"); i++) {
				DescribeAuthorizedAppsResponse.AuthorizedApp authorizedApp = new DescribeAuthorizedAppsResponse.AuthorizedApp();
				authorizedApp.StageName = context.StringValue("DescribeAuthorizedApps.AuthorizedApps["+ i +"].StageName");
				authorizedApp.AppId = context.LongValue("DescribeAuthorizedApps.AuthorizedApps["+ i +"].AppId");
				authorizedApp.AppName = context.StringValue("DescribeAuthorizedApps.AuthorizedApps["+ i +"].AppName");
				authorizedApp.Operator = context.StringValue("DescribeAuthorizedApps.AuthorizedApps["+ i +"].Operator");
				authorizedApp.AuthorizationSource = context.StringValue("DescribeAuthorizedApps.AuthorizedApps["+ i +"].AuthorizationSource");
				authorizedApp.Description = context.StringValue("DescribeAuthorizedApps.AuthorizedApps["+ i +"].Description");
				authorizedApp.AuthorizedTime = context.StringValue("DescribeAuthorizedApps.AuthorizedApps["+ i +"].AuthorizedTime");

				authorizedApps.Add(authorizedApp);
			}
			describeAuthorizedAppsResponse.AuthorizedApps = authorizedApps;
        
			return describeAuthorizedAppsResponse;
        }
    }
}