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
    public class DescribeGroupedVulResponseUnmarshaller
    {
        public static DescribeGroupedVulResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGroupedVulResponse describeGroupedVulResponse = new DescribeGroupedVulResponse();

			describeGroupedVulResponse.HttpResponse = _ctx.HttpResponse;
			describeGroupedVulResponse.RequestId = _ctx.StringValue("DescribeGroupedVul.RequestId");
			describeGroupedVulResponse.PageSize = _ctx.IntegerValue("DescribeGroupedVul.PageSize");
			describeGroupedVulResponse.CurrentPage = _ctx.IntegerValue("DescribeGroupedVul.CurrentPage");
			describeGroupedVulResponse.TotalCount = _ctx.IntegerValue("DescribeGroupedVul.TotalCount");

			List<DescribeGroupedVulResponse.DescribeGroupedVul_GroupedVulItem> describeGroupedVulResponse_groupedVulItems = new List<DescribeGroupedVulResponse.DescribeGroupedVul_GroupedVulItem>();
			for (int i = 0; i < _ctx.Length("DescribeGroupedVul.GroupedVulItems.Length"); i++) {
				DescribeGroupedVulResponse.DescribeGroupedVul_GroupedVulItem groupedVulItem = new DescribeGroupedVulResponse.DescribeGroupedVul_GroupedVulItem();
				groupedVulItem.Name = _ctx.StringValue("DescribeGroupedVul.GroupedVulItems["+ i +"].Name");
				groupedVulItem.AliasName = _ctx.StringValue("DescribeGroupedVul.GroupedVulItems["+ i +"].AliasName");
				groupedVulItem.Type = _ctx.StringValue("DescribeGroupedVul.GroupedVulItems["+ i +"].Type");
				groupedVulItem.GmtLast = _ctx.LongValue("DescribeGroupedVul.GroupedVulItems["+ i +"].GmtLast");
				groupedVulItem.AsapCount = _ctx.IntegerValue("DescribeGroupedVul.GroupedVulItems["+ i +"].AsapCount");
				groupedVulItem.LaterCount = _ctx.IntegerValue("DescribeGroupedVul.GroupedVulItems["+ i +"].LaterCount");
				groupedVulItem.NntfCount = _ctx.IntegerValue("DescribeGroupedVul.GroupedVulItems["+ i +"].NntfCount");
				groupedVulItem.HandledCount = _ctx.IntegerValue("DescribeGroupedVul.GroupedVulItems["+ i +"].HandledCount");
				groupedVulItem.Tags = _ctx.StringValue("DescribeGroupedVul.GroupedVulItems["+ i +"].Tags");
				groupedVulItem.TotalFixCount = _ctx.LongValue("DescribeGroupedVul.GroupedVulItems["+ i +"].TotalFixCount");

				describeGroupedVulResponse_groupedVulItems.Add(groupedVulItem);
			}
			describeGroupedVulResponse.GroupedVulItems = describeGroupedVulResponse_groupedVulItems;
        
			return describeGroupedVulResponse;
        }
    }
}
