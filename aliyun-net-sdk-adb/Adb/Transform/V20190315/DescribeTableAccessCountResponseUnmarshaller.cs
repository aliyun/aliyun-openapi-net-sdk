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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeTableAccessCountResponseUnmarshaller
    {
        public static DescribeTableAccessCountResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTableAccessCountResponse describeTableAccessCountResponse = new DescribeTableAccessCountResponse();

			describeTableAccessCountResponse.HttpResponse = _ctx.HttpResponse;
			describeTableAccessCountResponse.RequestId = _ctx.StringValue("DescribeTableAccessCount.RequestId");
			describeTableAccessCountResponse.PageNumber = _ctx.IntegerValue("DescribeTableAccessCount.PageNumber");
			describeTableAccessCountResponse.PageSize = _ctx.IntegerValue("DescribeTableAccessCount.PageSize");
			describeTableAccessCountResponse.TotalCount = _ctx.IntegerValue("DescribeTableAccessCount.TotalCount");

			List<DescribeTableAccessCountResponse.DescribeTableAccessCount_ItemsItem> describeTableAccessCountResponse_items = new List<DescribeTableAccessCountResponse.DescribeTableAccessCount_ItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeTableAccessCount.Items.Length"); i++) {
				DescribeTableAccessCountResponse.DescribeTableAccessCount_ItemsItem itemsItem = new DescribeTableAccessCountResponse.DescribeTableAccessCount_ItemsItem();
				itemsItem.ReportDate = _ctx.StringValue("DescribeTableAccessCount.Items["+ i +"].ReportDate");
				itemsItem.TableSchema = _ctx.StringValue("DescribeTableAccessCount.Items["+ i +"].TableSchema");
				itemsItem.AccessCount = _ctx.StringValue("DescribeTableAccessCount.Items["+ i +"].AccessCount");
				itemsItem.TableName = _ctx.StringValue("DescribeTableAccessCount.Items["+ i +"].TableName");
				itemsItem.InstanceName = _ctx.StringValue("DescribeTableAccessCount.Items["+ i +"].InstanceName");

				describeTableAccessCountResponse_items.Add(itemsItem);
			}
			describeTableAccessCountResponse.Items = describeTableAccessCountResponse_items;
        
			return describeTableAccessCountResponse;
        }
    }
}
