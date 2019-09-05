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
    public class DescribeApiHistoriesResponseUnmarshaller
    {
        public static DescribeApiHistoriesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeApiHistoriesResponse describeApiHistoriesResponse = new DescribeApiHistoriesResponse();

			describeApiHistoriesResponse.HttpResponse = context.HttpResponse;
			describeApiHistoriesResponse.RequestId = context.StringValue("DescribeApiHistories.RequestId");
			describeApiHistoriesResponse.TotalCount = context.IntegerValue("DescribeApiHistories.TotalCount");
			describeApiHistoriesResponse.PageSize = context.IntegerValue("DescribeApiHistories.PageSize");
			describeApiHistoriesResponse.PageNumber = context.IntegerValue("DescribeApiHistories.PageNumber");

			List<DescribeApiHistoriesResponse.DescribeApiHistories_ApiHisItem> describeApiHistoriesResponse_apiHisItems = new List<DescribeApiHistoriesResponse.DescribeApiHistories_ApiHisItem>();
			for (int i = 0; i < context.Length("DescribeApiHistories.ApiHisItems.Length"); i++) {
				DescribeApiHistoriesResponse.DescribeApiHistories_ApiHisItem apiHisItem = new DescribeApiHistoriesResponse.DescribeApiHistories_ApiHisItem();
				apiHisItem.RegionId = context.StringValue("DescribeApiHistories.ApiHisItems["+ i +"].RegionId");
				apiHisItem.ApiId = context.StringValue("DescribeApiHistories.ApiHisItems["+ i +"].ApiId");
				apiHisItem.ApiName = context.StringValue("DescribeApiHistories.ApiHisItems["+ i +"].ApiName");
				apiHisItem.GroupId = context.StringValue("DescribeApiHistories.ApiHisItems["+ i +"].GroupId");
				apiHisItem.GroupName = context.StringValue("DescribeApiHistories.ApiHisItems["+ i +"].GroupName");
				apiHisItem.StageName = context.StringValue("DescribeApiHistories.ApiHisItems["+ i +"].StageName");
				apiHisItem.HistoryVersion = context.StringValue("DescribeApiHistories.ApiHisItems["+ i +"].HistoryVersion");
				apiHisItem.Status = context.StringValue("DescribeApiHistories.ApiHisItems["+ i +"].Status");
				apiHisItem.Description = context.StringValue("DescribeApiHistories.ApiHisItems["+ i +"].Description");
				apiHisItem.DeployedTime = context.StringValue("DescribeApiHistories.ApiHisItems["+ i +"].DeployedTime");

				describeApiHistoriesResponse_apiHisItems.Add(apiHisItem);
			}
			describeApiHistoriesResponse.ApiHisItems = describeApiHistoriesResponse_apiHisItems;
        
			return describeApiHistoriesResponse;
        }
    }
}
