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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeMonitorItemsResponseUnmarshaller
    {
        public static DescribeMonitorItemsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMonitorItemsResponse describeMonitorItemsResponse = new DescribeMonitorItemsResponse();

			describeMonitorItemsResponse.HttpResponse = _ctx.HttpResponse;
			describeMonitorItemsResponse.RequestId = _ctx.StringValue("DescribeMonitorItems.RequestId");

			List<DescribeMonitorItemsResponse.DescribeMonitorItems_KVStoreMonitorItem> describeMonitorItemsResponse_monitorItems = new List<DescribeMonitorItemsResponse.DescribeMonitorItems_KVStoreMonitorItem>();
			for (int i = 0; i < _ctx.Length("DescribeMonitorItems.MonitorItems.Length"); i++) {
				DescribeMonitorItemsResponse.DescribeMonitorItems_KVStoreMonitorItem kVStoreMonitorItem = new DescribeMonitorItemsResponse.DescribeMonitorItems_KVStoreMonitorItem();
				kVStoreMonitorItem.MonitorKey = _ctx.StringValue("DescribeMonitorItems.MonitorItems["+ i +"].MonitorKey");
				kVStoreMonitorItem.Unit = _ctx.StringValue("DescribeMonitorItems.MonitorItems["+ i +"].Unit");

				describeMonitorItemsResponse_monitorItems.Add(kVStoreMonitorItem);
			}
			describeMonitorItemsResponse.MonitorItems = describeMonitorItemsResponse_monitorItems;
        
			return describeMonitorItemsResponse;
        }
    }
}
