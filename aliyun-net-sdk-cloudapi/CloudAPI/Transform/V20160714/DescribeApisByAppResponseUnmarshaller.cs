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
    public class DescribeApisByAppResponseUnmarshaller
    {
        public static DescribeApisByAppResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeApisByAppResponse describeApisByAppResponse = new DescribeApisByAppResponse();

			describeApisByAppResponse.HttpResponse = context.HttpResponse;
			describeApisByAppResponse.RequestId = context.StringValue("DescribeApisByApp.RequestId");
			describeApisByAppResponse.TotalCount = context.IntegerValue("DescribeApisByApp.TotalCount");
			describeApisByAppResponse.PageSize = context.IntegerValue("DescribeApisByApp.PageSize");
			describeApisByAppResponse.PageNumber = context.IntegerValue("DescribeApisByApp.PageNumber");

			List<DescribeApisByAppResponse.AppApiRelationInfo> appApiRelationInfos = new List<DescribeApisByAppResponse.AppApiRelationInfo>();
			for (int i = 0; i < context.Length("DescribeApisByApp.AppApiRelationInfos.Length"); i++) {
				DescribeApisByAppResponse.AppApiRelationInfo appApiRelationInfo = new DescribeApisByAppResponse.AppApiRelationInfo();
				appApiRelationInfo.RegionId = context.StringValue("DescribeApisByApp.AppApiRelationInfos["+ i +"].RegionId");
				appApiRelationInfo.GroupId = context.StringValue("DescribeApisByApp.AppApiRelationInfos["+ i +"].GroupId");
				appApiRelationInfo.GroupName = context.StringValue("DescribeApisByApp.AppApiRelationInfos["+ i +"].GroupName");
				appApiRelationInfo.StageName = context.StringValue("DescribeApisByApp.AppApiRelationInfos["+ i +"].StageName");
				appApiRelationInfo.Operator = context.StringValue("DescribeApisByApp.AppApiRelationInfos["+ i +"].Operator");
				appApiRelationInfo.ApiId = context.StringValue("DescribeApisByApp.AppApiRelationInfos["+ i +"].ApiId");
				appApiRelationInfo.ApiName = context.StringValue("DescribeApisByApp.AppApiRelationInfos["+ i +"].ApiName");
				appApiRelationInfo.AuthorizationSource = context.StringValue("DescribeApisByApp.AppApiRelationInfos["+ i +"].AuthorizationSource");
				appApiRelationInfo.Description = context.StringValue("DescribeApisByApp.AppApiRelationInfos["+ i +"].Description");
				appApiRelationInfo.CreatedTime = context.StringValue("DescribeApisByApp.AppApiRelationInfos["+ i +"].CreatedTime");

				appApiRelationInfos.Add(appApiRelationInfo);
			}
			describeApisByAppResponse.AppApiRelationInfos = appApiRelationInfos;
        
			return describeApisByAppResponse;
        }
    }
}