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
    public class DescribePluginApisResponseUnmarshaller
    {
        public static DescribePluginApisResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePluginApisResponse describePluginApisResponse = new DescribePluginApisResponse();

			describePluginApisResponse.HttpResponse = context.HttpResponse;
			describePluginApisResponse.RequestId = context.StringValue("DescribePluginApis.RequestId");
			describePluginApisResponse.TotalCount = context.IntegerValue("DescribePluginApis.TotalCount");
			describePluginApisResponse.PageSize = context.IntegerValue("DescribePluginApis.PageSize");
			describePluginApisResponse.PageNumber = context.IntegerValue("DescribePluginApis.PageNumber");

			List<DescribePluginApisResponse.DescribePluginApis_ApiPluginSummary> describePluginApisResponse_apiSummarys = new List<DescribePluginApisResponse.DescribePluginApis_ApiPluginSummary>();
			for (int i = 0; i < context.Length("DescribePluginApis.ApiSummarys.Length"); i++) {
				DescribePluginApisResponse.DescribePluginApis_ApiPluginSummary apiPluginSummary = new DescribePluginApisResponse.DescribePluginApis_ApiPluginSummary();
				apiPluginSummary.RegionId = context.StringValue("DescribePluginApis.ApiSummarys["+ i +"].RegionId");
				apiPluginSummary.GroupId = context.StringValue("DescribePluginApis.ApiSummarys["+ i +"].GroupId");
				apiPluginSummary.GroupName = context.StringValue("DescribePluginApis.ApiSummarys["+ i +"].GroupName");
				apiPluginSummary.StageName = context.StringValue("DescribePluginApis.ApiSummarys["+ i +"].StageName");
				apiPluginSummary.ApiId = context.StringValue("DescribePluginApis.ApiSummarys["+ i +"].ApiId");
				apiPluginSummary.ApiName = context.StringValue("DescribePluginApis.ApiSummarys["+ i +"].ApiName");
				apiPluginSummary.Description = context.StringValue("DescribePluginApis.ApiSummarys["+ i +"].Description");
				apiPluginSummary.Path = context.StringValue("DescribePluginApis.ApiSummarys["+ i +"].Path");
				apiPluginSummary.Method = context.StringValue("DescribePluginApis.ApiSummarys["+ i +"].Method");

				describePluginApisResponse_apiSummarys.Add(apiPluginSummary);
			}
			describePluginApisResponse.ApiSummarys = describePluginApisResponse_apiSummarys;
        
			return describePluginApisResponse;
        }
    }
}