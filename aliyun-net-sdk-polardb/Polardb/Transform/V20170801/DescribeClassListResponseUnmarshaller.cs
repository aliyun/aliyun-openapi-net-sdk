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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeClassListResponseUnmarshaller
    {
        public static DescribeClassListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeClassListResponse describeClassListResponse = new DescribeClassListResponse();

			describeClassListResponse.HttpResponse = _ctx.HttpResponse;
			describeClassListResponse.RequestId = _ctx.StringValue("DescribeClassList.RequestId");
			describeClassListResponse.RegionId = _ctx.StringValue("DescribeClassList.RegionId");

			List<DescribeClassListResponse.DescribeClassList_ItemsItem> describeClassListResponse_items = new List<DescribeClassListResponse.DescribeClassList_ItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeClassList.Items.Length"); i++) {
				DescribeClassListResponse.DescribeClassList_ItemsItem itemsItem = new DescribeClassListResponse.DescribeClassList_ItemsItem();
				itemsItem.Psl4MaxIOPS = _ctx.StringValue("DescribeClassList.Items["+ i +"].Psl4MaxIOPS");
				itemsItem.ClassTypeLevel = _ctx.StringValue("DescribeClassList.Items["+ i +"].ClassTypeLevel");
				itemsItem.Cpu = _ctx.StringValue("DescribeClassList.Items["+ i +"].Cpu");
				itemsItem.ReferencePrice = _ctx.StringValue("DescribeClassList.Items["+ i +"].ReferencePrice");
				itemsItem.ReferenceExtPrice = _ctx.StringValue("DescribeClassList.Items["+ i +"].ReferenceExtPrice");
				itemsItem.MaxConnections = _ctx.StringValue("DescribeClassList.Items["+ i +"].MaxConnections");
				itemsItem.MemoryClass = _ctx.StringValue("DescribeClassList.Items["+ i +"].MemoryClass");
				itemsItem.ClassCode = _ctx.StringValue("DescribeClassList.Items["+ i +"].ClassCode");
				itemsItem.ClassGroup = _ctx.StringValue("DescribeClassList.Items["+ i +"].ClassGroup");
				itemsItem.Psl5MaxIOPS = _ctx.StringValue("DescribeClassList.Items["+ i +"].Psl5MaxIOPS");
				itemsItem.MaxIOPS = _ctx.StringValue("DescribeClassList.Items["+ i +"].MaxIOPS");
				itemsItem.MaxStorageCapacity = _ctx.StringValue("DescribeClassList.Items["+ i +"].MaxStorageCapacity");
				itemsItem.Pl1MaxIOPS = _ctx.StringValue("DescribeClassList.Items["+ i +"].Pl1MaxIOPS");
				itemsItem.Pl2MaxIOPS = _ctx.StringValue("DescribeClassList.Items["+ i +"].Pl2MaxIOPS");
				itemsItem.Pl3MaxIOPS = _ctx.StringValue("DescribeClassList.Items["+ i +"].Pl3MaxIOPS");

				describeClassListResponse_items.Add(itemsItem);
			}
			describeClassListResponse.Items = describeClassListResponse_items;
        
			return describeClassListResponse;
        }
    }
}
