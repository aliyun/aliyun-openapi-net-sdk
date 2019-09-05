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
using Aliyun.Acs.CloudAPI.Model.V20160714;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribeApisByIpControlResponseUnmarshaller
    {
        public static DescribeApisByIpControlResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeApisByIpControlResponse describeApisByIpControlResponse = new DescribeApisByIpControlResponse();

			describeApisByIpControlResponse.HttpResponse = context.HttpResponse;
			describeApisByIpControlResponse.RequestId = context.StringValue("DescribeApisByIpControl.RequestId");
			describeApisByIpControlResponse.TotalCount = context.IntegerValue("DescribeApisByIpControl.TotalCount");
			describeApisByIpControlResponse.PageSize = context.IntegerValue("DescribeApisByIpControl.PageSize");
			describeApisByIpControlResponse.PageNumber = context.IntegerValue("DescribeApisByIpControl.PageNumber");

			List<DescribeApisByIpControlResponse.DescribeApisByIpControl_ApiInfo> describeApisByIpControlResponse_apiInfos = new List<DescribeApisByIpControlResponse.DescribeApisByIpControl_ApiInfo>();
			for (int i = 0; i < context.Length("DescribeApisByIpControl.ApiInfos.Length"); i++) {
				DescribeApisByIpControlResponse.DescribeApisByIpControl_ApiInfo apiInfo = new DescribeApisByIpControlResponse.DescribeApisByIpControl_ApiInfo();
				apiInfo.RegionId = context.StringValue("DescribeApisByIpControl.ApiInfos["+ i +"].RegionId");
				apiInfo.GroupId = context.StringValue("DescribeApisByIpControl.ApiInfos["+ i +"].GroupId");
				apiInfo.GroupName = context.StringValue("DescribeApisByIpControl.ApiInfos["+ i +"].GroupName");
				apiInfo.StageName = context.StringValue("DescribeApisByIpControl.ApiInfos["+ i +"].StageName");
				apiInfo.ApiId = context.StringValue("DescribeApisByIpControl.ApiInfos["+ i +"].ApiId");
				apiInfo.ApiName = context.StringValue("DescribeApisByIpControl.ApiInfos["+ i +"].ApiName");
				apiInfo.Description = context.StringValue("DescribeApisByIpControl.ApiInfos["+ i +"].Description");
				apiInfo.Visibility = context.StringValue("DescribeApisByIpControl.ApiInfos["+ i +"].Visibility");
				apiInfo.BoundTime = context.StringValue("DescribeApisByIpControl.ApiInfos["+ i +"].BoundTime");

				describeApisByIpControlResponse_apiInfos.Add(apiInfo);
			}
			describeApisByIpControlResponse.ApiInfos = describeApisByIpControlResponse_apiInfos;
        
			return describeApisByIpControlResponse;
        }
    }
}
