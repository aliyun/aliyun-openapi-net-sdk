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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnRefreshTaskByIdResponseUnmarshaller
    {
        public static DescribeDcdnRefreshTaskByIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnRefreshTaskByIdResponse describeDcdnRefreshTaskByIdResponse = new DescribeDcdnRefreshTaskByIdResponse();

			describeDcdnRefreshTaskByIdResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnRefreshTaskByIdResponse.RequestId = _ctx.StringValue("DescribeDcdnRefreshTaskById.RequestId");
			describeDcdnRefreshTaskByIdResponse.TotalCount = _ctx.LongValue("DescribeDcdnRefreshTaskById.TotalCount");

			List<DescribeDcdnRefreshTaskByIdResponse.DescribeDcdnRefreshTaskById_CDNTask> describeDcdnRefreshTaskByIdResponse_tasks = new List<DescribeDcdnRefreshTaskByIdResponse.DescribeDcdnRefreshTaskById_CDNTask>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnRefreshTaskById.Tasks.Length"); i++) {
				DescribeDcdnRefreshTaskByIdResponse.DescribeDcdnRefreshTaskById_CDNTask cDNTask = new DescribeDcdnRefreshTaskByIdResponse.DescribeDcdnRefreshTaskById_CDNTask();
				cDNTask.TaskId = _ctx.StringValue("DescribeDcdnRefreshTaskById.Tasks["+ i +"].TaskId");
				cDNTask.ObjectPath = _ctx.StringValue("DescribeDcdnRefreshTaskById.Tasks["+ i +"].ObjectPath");
				cDNTask.Process = _ctx.StringValue("DescribeDcdnRefreshTaskById.Tasks["+ i +"].Process");
				cDNTask.Status = _ctx.StringValue("DescribeDcdnRefreshTaskById.Tasks["+ i +"].Status");
				cDNTask.CreationTime = _ctx.StringValue("DescribeDcdnRefreshTaskById.Tasks["+ i +"].CreationTime");
				cDNTask.Description = _ctx.StringValue("DescribeDcdnRefreshTaskById.Tasks["+ i +"].Description");
				cDNTask.ObjectType = _ctx.StringValue("DescribeDcdnRefreshTaskById.Tasks["+ i +"].ObjectType");

				describeDcdnRefreshTaskByIdResponse_tasks.Add(cDNTask);
			}
			describeDcdnRefreshTaskByIdResponse.Tasks = describeDcdnRefreshTaskByIdResponse_tasks;
        
			return describeDcdnRefreshTaskByIdResponse;
        }
    }
}
