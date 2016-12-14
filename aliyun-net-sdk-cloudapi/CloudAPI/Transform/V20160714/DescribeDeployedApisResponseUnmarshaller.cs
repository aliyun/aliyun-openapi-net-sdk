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
    public class DescribeDeployedApisResponseUnmarshaller
    {
        public static DescribeDeployedApisResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDeployedApisResponse describeDeployedApisResponse = new DescribeDeployedApisResponse();

			describeDeployedApisResponse.HttpResponse = context.HttpResponse;
			describeDeployedApisResponse.RequestId = context.StringValue("DescribeDeployedApis.RequestId");
			describeDeployedApisResponse.TotalCount = context.IntegerValue("DescribeDeployedApis.TotalCount");
			describeDeployedApisResponse.PageSize = context.IntegerValue("DescribeDeployedApis.PageSize");
			describeDeployedApisResponse.PageNumber = context.IntegerValue("DescribeDeployedApis.PageNumber");

			List<DescribeDeployedApisResponse.DeployedApiItem> deployedApis = new List<DescribeDeployedApisResponse.DeployedApiItem>();
			for (int i = 0; i < context.Length("DescribeDeployedApis.DeployedApis.Length"); i++) {
				DescribeDeployedApisResponse.DeployedApiItem deployedApiItem = new DescribeDeployedApisResponse.DeployedApiItem();
				deployedApiItem.RegionId = context.StringValue("DescribeDeployedApis.DeployedApis["+ i +"].RegionId");
				deployedApiItem.ApiId = context.StringValue("DescribeDeployedApis.DeployedApis["+ i +"].ApiId");
				deployedApiItem.ApiName = context.StringValue("DescribeDeployedApis.DeployedApis["+ i +"].ApiName");
				deployedApiItem.GroupId = context.StringValue("DescribeDeployedApis.DeployedApis["+ i +"].GroupId");
				deployedApiItem.GroupName = context.StringValue("DescribeDeployedApis.DeployedApis["+ i +"].GroupName");
				deployedApiItem.StageName = context.StringValue("DescribeDeployedApis.DeployedApis["+ i +"].StageName");
				deployedApiItem.Visibility = context.StringValue("DescribeDeployedApis.DeployedApis["+ i +"].Visibility");
				deployedApiItem.Description = context.StringValue("DescribeDeployedApis.DeployedApis["+ i +"].Description");
				deployedApiItem.DeployedTime = context.StringValue("DescribeDeployedApis.DeployedApis["+ i +"].DeployedTime");

				deployedApis.Add(deployedApiItem);
			}
			describeDeployedApisResponse.DeployedApis = deployedApis;
        
			return describeDeployedApisResponse;
        }
    }
}