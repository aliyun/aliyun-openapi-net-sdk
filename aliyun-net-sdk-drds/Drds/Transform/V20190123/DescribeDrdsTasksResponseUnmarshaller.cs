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
    public class DescribeDrdsTasksResponseUnmarshaller
    {
        public static DescribeDrdsTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDrdsTasksResponse describeDrdsTasksResponse = new DescribeDrdsTasksResponse();

			describeDrdsTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeDrdsTasksResponse.RequestId = _ctx.StringValue("DescribeDrdsTasks.RequestId");
			describeDrdsTasksResponse.Success = _ctx.BooleanValue("DescribeDrdsTasks.Success");

			List<DescribeDrdsTasksResponse.DescribeDrdsTasks_Task> describeDrdsTasksResponse_tasks = new List<DescribeDrdsTasksResponse.DescribeDrdsTasks_Task>();
			for (int i = 0; i < _ctx.Length("DescribeDrdsTasks.Tasks.Length"); i++) {
				DescribeDrdsTasksResponse.DescribeDrdsTasks_Task task = new DescribeDrdsTasksResponse.DescribeDrdsTasks_Task();
				task.Id = _ctx.LongValue("DescribeDrdsTasks.Tasks["+ i +"].Id");
				task.State = _ctx.StringValue("DescribeDrdsTasks.Tasks["+ i +"].State");
				task.Content = _ctx.StringValue("DescribeDrdsTasks.Tasks["+ i +"].Content");

				describeDrdsTasksResponse_tasks.Add(task);
			}
			describeDrdsTasksResponse.Tasks = describeDrdsTasksResponse_tasks;
        
			return describeDrdsTasksResponse;
        }
    }
}
