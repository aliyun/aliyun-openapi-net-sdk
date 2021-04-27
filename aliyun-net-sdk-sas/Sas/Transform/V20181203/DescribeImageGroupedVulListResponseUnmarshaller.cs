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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeImageGroupedVulListResponseUnmarshaller
    {
        public static DescribeImageGroupedVulListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeImageGroupedVulListResponse describeImageGroupedVulListResponse = new DescribeImageGroupedVulListResponse();

			describeImageGroupedVulListResponse.HttpResponse = _ctx.HttpResponse;
			describeImageGroupedVulListResponse.RequestId = _ctx.StringValue("DescribeImageGroupedVulList.RequestId");
			describeImageGroupedVulListResponse.PageSize = _ctx.IntegerValue("DescribeImageGroupedVulList.PageSize");
			describeImageGroupedVulListResponse.CurrentPage = _ctx.IntegerValue("DescribeImageGroupedVulList.CurrentPage");
			describeImageGroupedVulListResponse.TotalCount = _ctx.IntegerValue("DescribeImageGroupedVulList.TotalCount");

			List<DescribeImageGroupedVulListResponse.DescribeImageGroupedVulList_GroupedVulItem> describeImageGroupedVulListResponse_groupedVulItems = new List<DescribeImageGroupedVulListResponse.DescribeImageGroupedVulList_GroupedVulItem>();
			for (int i = 0; i < _ctx.Length("DescribeImageGroupedVulList.GroupedVulItems.Length"); i++) {
				DescribeImageGroupedVulListResponse.DescribeImageGroupedVulList_GroupedVulItem groupedVulItem = new DescribeImageGroupedVulListResponse.DescribeImageGroupedVulList_GroupedVulItem();
				groupedVulItem.Name = _ctx.StringValue("DescribeImageGroupedVulList.GroupedVulItems["+ i +"].Name");
				groupedVulItem.AliasName = _ctx.StringValue("DescribeImageGroupedVulList.GroupedVulItems["+ i +"].AliasName");
				groupedVulItem.Type = _ctx.StringValue("DescribeImageGroupedVulList.GroupedVulItems["+ i +"].Type");
				groupedVulItem.Status = _ctx.IntegerValue("DescribeImageGroupedVulList.GroupedVulItems["+ i +"].Status");
				groupedVulItem.LastScanTime = _ctx.LongValue("DescribeImageGroupedVulList.GroupedVulItems["+ i +"].LastScanTime");
				groupedVulItem.GmtLast = _ctx.LongValue("DescribeImageGroupedVulList.GroupedVulItems["+ i +"].GmtLast");
				groupedVulItem.AsapCount = _ctx.IntegerValue("DescribeImageGroupedVulList.GroupedVulItems["+ i +"].AsapCount");
				groupedVulItem.LaterCount = _ctx.IntegerValue("DescribeImageGroupedVulList.GroupedVulItems["+ i +"].LaterCount");
				groupedVulItem.NntfCount = _ctx.IntegerValue("DescribeImageGroupedVulList.GroupedVulItems["+ i +"].NntfCount");
				groupedVulItem.Tags = _ctx.StringValue("DescribeImageGroupedVulList.GroupedVulItems["+ i +"].Tags");

				describeImageGroupedVulListResponse_groupedVulItems.Add(groupedVulItem);
			}
			describeImageGroupedVulListResponse.GroupedVulItems = describeImageGroupedVulListResponse_groupedVulItems;
        
			return describeImageGroupedVulListResponse;
        }
    }
}
