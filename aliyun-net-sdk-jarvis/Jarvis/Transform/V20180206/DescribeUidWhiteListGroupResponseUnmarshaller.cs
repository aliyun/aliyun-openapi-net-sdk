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
using Aliyun.Acs.jarvis.Model.V20180206;

namespace Aliyun.Acs.jarvis.Transform.V20180206
{
    public class DescribeUidWhiteListGroupResponseUnmarshaller
    {
        public static DescribeUidWhiteListGroupResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeUidWhiteListGroupResponse describeUidWhiteListGroupResponse = new DescribeUidWhiteListGroupResponse();

			describeUidWhiteListGroupResponse.HttpResponse = context.HttpResponse;
			describeUidWhiteListGroupResponse.RequestId = context.StringValue("DescribeUidWhiteListGroup.RequestId");
			describeUidWhiteListGroupResponse.Module = context.StringValue("DescribeUidWhiteListGroup.Module");

			List<string> describeUidWhiteListGroupResponse_productList = new List<string>();
			for (int i = 0; i < context.Length("DescribeUidWhiteListGroup.ProductList.Length"); i++) {
				describeUidWhiteListGroupResponse_productList.Add(context.StringValue("DescribeUidWhiteListGroup.ProductList["+ i +"]"));
			}
			describeUidWhiteListGroupResponse.ProductList = describeUidWhiteListGroupResponse_productList;

			DescribeUidWhiteListGroupResponse.DescribeUidWhiteListGroup_PageInfo pageInfo = new DescribeUidWhiteListGroupResponse.DescribeUidWhiteListGroup_PageInfo();
			pageInfo.Total = context.IntegerValue("DescribeUidWhiteListGroup.PageInfo.Total");
			pageInfo.PageSize = context.IntegerValue("DescribeUidWhiteListGroup.PageInfo.PageSize");
			pageInfo.CurrentPage = context.IntegerValue("DescribeUidWhiteListGroup.PageInfo.CurrentPage");
			describeUidWhiteListGroupResponse.PageInfo = pageInfo;

			List<DescribeUidWhiteListGroupResponse.DescribeUidWhiteListGroup_Data> describeUidWhiteListGroupResponse_dataList = new List<DescribeUidWhiteListGroupResponse.DescribeUidWhiteListGroup_Data>();
			for (int i = 0; i < context.Length("DescribeUidWhiteListGroup.DataList.Length"); i++) {
				DescribeUidWhiteListGroupResponse.DescribeUidWhiteListGroup_Data data = new DescribeUidWhiteListGroupResponse.DescribeUidWhiteListGroup_Data();
				data.Status = context.StringValue("DescribeUidWhiteListGroup.DataList["+ i +"].Status");
				data.GmtCreate = context.StringValue("DescribeUidWhiteListGroup.DataList["+ i +"].GmtCreate");
				data.GmtRealExpire = context.StringValue("DescribeUidWhiteListGroup.DataList["+ i +"].GmtRealExpire");
				data.SrcUid = context.StringValue("DescribeUidWhiteListGroup.DataList["+ i +"].SrcUid");
				data.AutoConfig = context.IntegerValue("DescribeUidWhiteListGroup.DataList["+ i +"].AutoConfig");
				data.GroupId = context.IntegerValue("DescribeUidWhiteListGroup.DataList["+ i +"].GroupId");

				List<DescribeUidWhiteListGroupResponse.DescribeUidWhiteListGroup_Data.DescribeUidWhiteListGroup_Item> data_items = new List<DescribeUidWhiteListGroupResponse.DescribeUidWhiteListGroup_Data.DescribeUidWhiteListGroup_Item>();
				for (int j = 0; j < context.Length("DescribeUidWhiteListGroup.DataList["+ i +"].Items.Length"); j++) {
					DescribeUidWhiteListGroupResponse.DescribeUidWhiteListGroup_Data.DescribeUidWhiteListGroup_Item item = new DescribeUidWhiteListGroupResponse.DescribeUidWhiteListGroup_Data.DescribeUidWhiteListGroup_Item();
					item.IP = context.StringValue("DescribeUidWhiteListGroup.DataList["+ i +"].Items["+ j +"].IP");
					item.RegionId = context.StringValue("DescribeUidWhiteListGroup.DataList["+ i +"].Items["+ j +"].RegionId");

					data_items.Add(item);
				}
				data.Items = data_items;

				describeUidWhiteListGroupResponse_dataList.Add(data);
			}
			describeUidWhiteListGroupResponse.DataList = describeUidWhiteListGroupResponse_dataList;
        
			return describeUidWhiteListGroupResponse;
        }
    }
}
