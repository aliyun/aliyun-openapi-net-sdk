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
    public class DescribeApisResponseUnmarshaller
    {
        public static DescribeApisResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeApisResponse describeApisResponse = new DescribeApisResponse();

			describeApisResponse.HttpResponse = context.HttpResponse;
			describeApisResponse.RequestId = context.StringValue("DescribeApis.RequestId");
			describeApisResponse.TotalCount = context.IntegerValue("DescribeApis.TotalCount");
			describeApisResponse.PageSize = context.IntegerValue("DescribeApis.PageSize");
			describeApisResponse.PageNumber = context.IntegerValue("DescribeApis.PageNumber");

			List<DescribeApisResponse.ApiSummary> apiSummarys = new List<DescribeApisResponse.ApiSummary>();
			for (int i = 0; i < context.Length("DescribeApis.ApiSummarys.Length"); i++) {
				DescribeApisResponse.ApiSummary apiSummary = new DescribeApisResponse.ApiSummary();
				apiSummary.RegionId = context.StringValue("DescribeApis.ApiSummarys["+ i +"].RegionId");
				apiSummary.GroupId = context.StringValue("DescribeApis.ApiSummarys["+ i +"].GroupId");
				apiSummary.GroupName = context.StringValue("DescribeApis.ApiSummarys["+ i +"].GroupName");
				apiSummary.ApiId = context.StringValue("DescribeApis.ApiSummarys["+ i +"].ApiId");
				apiSummary.ApiName = context.StringValue("DescribeApis.ApiSummarys["+ i +"].ApiName");
				apiSummary.Visibility = context.StringValue("DescribeApis.ApiSummarys["+ i +"].Visibility");
				apiSummary.Description = context.StringValue("DescribeApis.ApiSummarys["+ i +"].Description");
				apiSummary.CreatedTime = context.StringValue("DescribeApis.ApiSummarys["+ i +"].CreatedTime");
				apiSummary.ModifiedTime = context.StringValue("DescribeApis.ApiSummarys["+ i +"].ModifiedTime");

				apiSummarys.Add(apiSummary);
			}
			describeApisResponse.ApiSummarys = apiSummarys;
        
			return describeApisResponse;
        }
    }
}