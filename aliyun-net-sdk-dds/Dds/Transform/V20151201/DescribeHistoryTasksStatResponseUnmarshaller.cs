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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeHistoryTasksStatResponseUnmarshaller
    {
        public static DescribeHistoryTasksStatResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeHistoryTasksStatResponse describeHistoryTasksStatResponse = new DescribeHistoryTasksStatResponse();

			describeHistoryTasksStatResponse.HttpResponse = _ctx.HttpResponse;
			describeHistoryTasksStatResponse.RequestId = _ctx.StringValue("DescribeHistoryTasksStat.RequestId");

			List<DescribeHistoryTasksStatResponse.DescribeHistoryTasksStat_ItemsItem> describeHistoryTasksStatResponse_items = new List<DescribeHistoryTasksStatResponse.DescribeHistoryTasksStat_ItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeHistoryTasksStat.Items.Length"); i++) {
				DescribeHistoryTasksStatResponse.DescribeHistoryTasksStat_ItemsItem itemsItem = new DescribeHistoryTasksStatResponse.DescribeHistoryTasksStat_ItemsItem();
				itemsItem.Status = _ctx.StringValue("DescribeHistoryTasksStat.Items["+ i +"].Status");
				itemsItem.TotalCount = _ctx.IntegerValue("DescribeHistoryTasksStat.Items["+ i +"].TotalCount");

				describeHistoryTasksStatResponse_items.Add(itemsItem);
			}
			describeHistoryTasksStatResponse.Items = describeHistoryTasksStatResponse_items;
        
			return describeHistoryTasksStatResponse;
        }
    }
}
