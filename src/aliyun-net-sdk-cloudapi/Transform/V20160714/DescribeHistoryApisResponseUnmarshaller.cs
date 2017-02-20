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
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribeHistoryApisResponseUnmarshaller
    {
        public static DescribeHistoryApisResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeHistoryApisResponse describeHistoryApisResponse = new DescribeHistoryApisResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeHistoryApis.RequestId"),
                TotalCount = context.IntegerValue("DescribeHistoryApis.TotalCount"),
                PageSize = context.IntegerValue("DescribeHistoryApis.PageSize"),
                PageNumber = context.IntegerValue("DescribeHistoryApis.PageNumber")
            };
            List<DescribeHistoryApisResponse.ApiHisItem> apiHisItems = new List<DescribeHistoryApisResponse.ApiHisItem>();
			for (int i = 0; i < context.Length("DescribeHistoryApis.ApiHisItems.Length"); i++) {
                DescribeHistoryApisResponse.ApiHisItem apiHisItem = new DescribeHistoryApisResponse.ApiHisItem()
                {
                    RegionId = context.StringValue($"DescribeHistoryApis.ApiHisItems[{i}].RegionId"),
                    ApiId = context.StringValue($"DescribeHistoryApis.ApiHisItems[{i}].ApiId"),
                    ApiName = context.StringValue($"DescribeHistoryApis.ApiHisItems[{i}].ApiName"),
                    GroupId = context.StringValue($"DescribeHistoryApis.ApiHisItems[{i}].GroupId"),
                    GroupName = context.StringValue($"DescribeHistoryApis.ApiHisItems[{i}].GroupName"),
                    StageName = context.StringValue($"DescribeHistoryApis.ApiHisItems[{i}].StageName"),
                    HistoryVersion = context.StringValue($"DescribeHistoryApis.ApiHisItems[{i}].HistoryVersion"),
                    Status = context.EnumValue<DescribeHistoryApisResponse.ApiHisItem.StatusEnum>($"DescribeHistoryApis.ApiHisItems[{i}].Status"),
                    Description = context.StringValue($"DescribeHistoryApis.ApiHisItems[{i}].Description"),
                    DeployedTime = context.StringValue($"DescribeHistoryApis.ApiHisItems[{i}].DeployedTime")
                };
                apiHisItems.Add(apiHisItem);
			}
			describeHistoryApisResponse.ApiHisItems = apiHisItems;
        
			return describeHistoryApisResponse;
        }
    }
}