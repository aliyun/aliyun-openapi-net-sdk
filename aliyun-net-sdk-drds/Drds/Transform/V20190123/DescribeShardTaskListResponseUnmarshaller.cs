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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class DescribeShardTaskListResponseUnmarshaller
    {
        public static DescribeShardTaskListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeShardTaskListResponse describeShardTaskListResponse = new DescribeShardTaskListResponse();

			describeShardTaskListResponse.HttpResponse = _ctx.HttpResponse;
			describeShardTaskListResponse.RequestId = _ctx.StringValue("DescribeShardTaskList.RequestId");
			describeShardTaskListResponse.Success = _ctx.BooleanValue("DescribeShardTaskList.Success");
			describeShardTaskListResponse.PageNumber = _ctx.IntegerValue("DescribeShardTaskList.PageNumber");
			describeShardTaskListResponse.PageSize = _ctx.IntegerValue("DescribeShardTaskList.PageSize");
			describeShardTaskListResponse.Total = _ctx.IntegerValue("DescribeShardTaskList.Total");

			List<DescribeShardTaskListResponse.DescribeShardTaskList_ListItem> describeShardTaskListResponse_list = new List<DescribeShardTaskListResponse.DescribeShardTaskList_ListItem>();
			for (int i = 0; i < _ctx.Length("DescribeShardTaskList.List.Length"); i++) {
				DescribeShardTaskListResponse.DescribeShardTaskList_ListItem listItem = new DescribeShardTaskListResponse.DescribeShardTaskList_ListItem();
				listItem.SourceTableName = _ctx.StringValue("DescribeShardTaskList.List["+ i +"].SourceTableName");
				listItem.TargetTableName = _ctx.StringValue("DescribeShardTaskList.List["+ i +"].TargetTableName");
				listItem.Expired = _ctx.StringValue("DescribeShardTaskList.List["+ i +"].Expired");
				listItem.Expired1 = _ctx.LongValue("DescribeShardTaskList.List["+ i +"].Expired");
				listItem.Stage = _ctx.IntegerValue("DescribeShardTaskList.List["+ i +"].Stage");
				listItem.Progress = _ctx.IntegerValue("DescribeShardTaskList.List["+ i +"].Progress");
				listItem.Delay = _ctx.IntegerValue("DescribeShardTaskList.List["+ i +"].Delay");

				describeShardTaskListResponse_list.Add(listItem);
			}
			describeShardTaskListResponse.List = describeShardTaskListResponse_list;
        
			return describeShardTaskListResponse;
        }
    }
}
