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
using Aliyun.Acs.jarvis.Model.V20180206;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.jarvis.Transform.V20180206
{
    public class DescribeAccessWhiteListGroupResponseUnmarshaller
    {
        public static DescribeAccessWhiteListGroupResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAccessWhiteListGroupResponse describeAccessWhiteListGroupResponse = new DescribeAccessWhiteListGroupResponse();

			describeAccessWhiteListGroupResponse.HttpResponse = context.HttpResponse;
			describeAccessWhiteListGroupResponse.RequestId = context.StringValue("DescribeAccessWhiteListGroup.RequestId");
			describeAccessWhiteListGroupResponse.Module = context.StringValue("DescribeAccessWhiteListGroup.Module");

			DescribeAccessWhiteListGroupResponse.DescribeAccessWhiteListGroup_PageInfo pageInfo = new DescribeAccessWhiteListGroupResponse.DescribeAccessWhiteListGroup_PageInfo();
			pageInfo.Total = context.IntegerValue("DescribeAccessWhiteListGroup.PageInfo.Total");
			pageInfo.PageSize = context.IntegerValue("DescribeAccessWhiteListGroup.PageInfo.PageSize");
			pageInfo.CurrentPage = context.IntegerValue("DescribeAccessWhiteListGroup.PageInfo.CurrentPage");
			describeAccessWhiteListGroupResponse.PageInfo = pageInfo;

			List<DescribeAccessWhiteListGroupResponse.DescribeAccessWhiteListGroup_Data> describeAccessWhiteListGroupResponse_dataList = new List<DescribeAccessWhiteListGroupResponse.DescribeAccessWhiteListGroup_Data>();
			for (int i = 0; i < context.Length("DescribeAccessWhiteListGroup.DataList.Length"); i++) {
				DescribeAccessWhiteListGroupResponse.DescribeAccessWhiteListGroup_Data data = new DescribeAccessWhiteListGroupResponse.DescribeAccessWhiteListGroup_Data();
				data.Status = context.StringValue("DescribeAccessWhiteListGroup.DataList["+ i +"].Status");
				data.GmtCreate = context.StringValue("DescribeAccessWhiteListGroup.DataList["+ i +"].GmtCreate");
				data.GmtRealExpire = context.StringValue("DescribeAccessWhiteListGroup.DataList["+ i +"].GmtRealExpire");
				data.SrcIP = context.StringValue("DescribeAccessWhiteListGroup.DataList["+ i +"].SrcIP");
				data.AutoConfig = context.IntegerValue("DescribeAccessWhiteListGroup.DataList["+ i +"].AutoConfig");
				data.GroupId = context.IntegerValue("DescribeAccessWhiteListGroup.DataList["+ i +"].GroupId");

				List<DescribeAccessWhiteListGroupResponse.DescribeAccessWhiteListGroup_Data.DescribeAccessWhiteListGroup_Item> data_items = new List<DescribeAccessWhiteListGroupResponse.DescribeAccessWhiteListGroup_Data.DescribeAccessWhiteListGroup_Item>();
				for (int j = 0; j < context.Length("DescribeAccessWhiteListGroup.DataList["+ i +"].Items.Length"); j++) {
					DescribeAccessWhiteListGroupResponse.DescribeAccessWhiteListGroup_Data.DescribeAccessWhiteListGroup_Item item = new DescribeAccessWhiteListGroupResponse.DescribeAccessWhiteListGroup_Data.DescribeAccessWhiteListGroup_Item();
					item.IP = context.StringValue("DescribeAccessWhiteListGroup.DataList["+ i +"].Items["+ j +"].IP");
					item.RegionId = context.StringValue("DescribeAccessWhiteListGroup.DataList["+ i +"].Items["+ j +"].RegionId");

					data_items.Add(item);
				}
				data.Items = data_items;

				describeAccessWhiteListGroupResponse_dataList.Add(data);
			}
			describeAccessWhiteListGroupResponse.DataList = describeAccessWhiteListGroupResponse_dataList;
        
			return describeAccessWhiteListGroupResponse;
        }
    }
}