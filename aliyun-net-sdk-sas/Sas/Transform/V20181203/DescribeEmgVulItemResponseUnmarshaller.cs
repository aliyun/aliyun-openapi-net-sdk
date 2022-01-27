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
    public class DescribeEmgVulItemResponseUnmarshaller
    {
        public static DescribeEmgVulItemResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEmgVulItemResponse describeEmgVulItemResponse = new DescribeEmgVulItemResponse();

			describeEmgVulItemResponse.HttpResponse = _ctx.HttpResponse;
			describeEmgVulItemResponse.RequestId = _ctx.StringValue("DescribeEmgVulItem.RequestId");
			describeEmgVulItemResponse.PageSize = _ctx.IntegerValue("DescribeEmgVulItem.PageSize");
			describeEmgVulItemResponse.CurrentPage = _ctx.IntegerValue("DescribeEmgVulItem.CurrentPage");
			describeEmgVulItemResponse.TotalCount = _ctx.IntegerValue("DescribeEmgVulItem.TotalCount");

			List<DescribeEmgVulItemResponse.DescribeEmgVulItem_GroupedVulItem> describeEmgVulItemResponse_groupedVulItems = new List<DescribeEmgVulItemResponse.DescribeEmgVulItem_GroupedVulItem>();
			for (int i = 0; i < _ctx.Length("DescribeEmgVulItem.GroupedVulItems.Length"); i++) {
				DescribeEmgVulItemResponse.DescribeEmgVulItem_GroupedVulItem groupedVulItem = new DescribeEmgVulItemResponse.DescribeEmgVulItem_GroupedVulItem();
				groupedVulItem.AliasName = _ctx.StringValue("DescribeEmgVulItem.GroupedVulItems["+ i +"].AliasName");
				groupedVulItem.PendingCount = _ctx.IntegerValue("DescribeEmgVulItem.GroupedVulItems["+ i +"].PendingCount");
				groupedVulItem.Name = _ctx.StringValue("DescribeEmgVulItem.GroupedVulItems["+ i +"].Name");
				groupedVulItem.GmtPublish = _ctx.LongValue("DescribeEmgVulItem.GroupedVulItems["+ i +"].GmtPublish");
				groupedVulItem.Description = _ctx.StringValue("DescribeEmgVulItem.GroupedVulItems["+ i +"].Description");
				groupedVulItem.Type = _ctx.StringValue("DescribeEmgVulItem.GroupedVulItems["+ i +"].Type");
				groupedVulItem.Status = _ctx.IntegerValue("DescribeEmgVulItem.GroupedVulItems["+ i +"].Status");
				groupedVulItem.Progress = _ctx.IntegerValue("DescribeEmgVulItem.GroupedVulItems["+ i +"].Progress");
				groupedVulItem.GmtLastCheck = _ctx.LongValue("DescribeEmgVulItem.GroupedVulItems["+ i +"].GmtLastCheck");

				describeEmgVulItemResponse_groupedVulItems.Add(groupedVulItem);
			}
			describeEmgVulItemResponse.GroupedVulItems = describeEmgVulItemResponse_groupedVulItems;
        
			return describeEmgVulItemResponse;
        }
    }
}
