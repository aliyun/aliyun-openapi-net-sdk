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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeRefreshTaskByIdResponseUnmarshaller
    {
        public static DescribeRefreshTaskByIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRefreshTaskByIdResponse describeRefreshTaskByIdResponse = new DescribeRefreshTaskByIdResponse();

			describeRefreshTaskByIdResponse.HttpResponse = _ctx.HttpResponse;
			describeRefreshTaskByIdResponse.RequestId = _ctx.StringValue("DescribeRefreshTaskById.RequestId");
			describeRefreshTaskByIdResponse.TotalCount = _ctx.LongValue("DescribeRefreshTaskById.TotalCount");

			List<DescribeRefreshTaskByIdResponse.DescribeRefreshTaskById_CDNTask> describeRefreshTaskByIdResponse_tasks = new List<DescribeRefreshTaskByIdResponse.DescribeRefreshTaskById_CDNTask>();
			for (int i = 0; i < _ctx.Length("DescribeRefreshTaskById.Tasks.Length"); i++) {
				DescribeRefreshTaskByIdResponse.DescribeRefreshTaskById_CDNTask cDNTask = new DescribeRefreshTaskByIdResponse.DescribeRefreshTaskById_CDNTask();
				cDNTask.TaskId = _ctx.StringValue("DescribeRefreshTaskById.Tasks["+ i +"].TaskId");
				cDNTask.ObjectPath = _ctx.StringValue("DescribeRefreshTaskById.Tasks["+ i +"].ObjectPath");
				cDNTask.Process = _ctx.StringValue("DescribeRefreshTaskById.Tasks["+ i +"].Process");
				cDNTask.Status = _ctx.StringValue("DescribeRefreshTaskById.Tasks["+ i +"].Status");
				cDNTask.CreationTime = _ctx.StringValue("DescribeRefreshTaskById.Tasks["+ i +"].CreationTime");
				cDNTask.Description = _ctx.StringValue("DescribeRefreshTaskById.Tasks["+ i +"].Description");
				cDNTask.ObjectType = _ctx.StringValue("DescribeRefreshTaskById.Tasks["+ i +"].ObjectType");

				describeRefreshTaskByIdResponse_tasks.Add(cDNTask);
			}
			describeRefreshTaskByIdResponse.Tasks = describeRefreshTaskByIdResponse_tasks;
        
			return describeRefreshTaskByIdResponse;
        }
    }
}
