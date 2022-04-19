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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeImageFixTaskResponseUnmarshaller
    {
        public static DescribeImageFixTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeImageFixTaskResponse describeImageFixTaskResponse = new DescribeImageFixTaskResponse();

			describeImageFixTaskResponse.HttpResponse = _ctx.HttpResponse;
			describeImageFixTaskResponse.RequestId = _ctx.StringValue("DescribeImageFixTask.RequestId");

			DescribeImageFixTaskResponse.DescribeImageFixTask_PageInfo pageInfo = new DescribeImageFixTaskResponse.DescribeImageFixTask_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeImageFixTask.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeImageFixTask.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribeImageFixTask.PageInfo.TotalCount");
			pageInfo.Count = _ctx.IntegerValue("DescribeImageFixTask.PageInfo.Count");
			describeImageFixTaskResponse.PageInfo = pageInfo;

			List<DescribeImageFixTaskResponse.DescribeImageFixTask_BuildTask> describeImageFixTaskResponse_buildTasks = new List<DescribeImageFixTaskResponse.DescribeImageFixTask_BuildTask>();
			for (int i = 0; i < _ctx.Length("DescribeImageFixTask.BuildTasks.Length"); i++) {
				DescribeImageFixTaskResponse.DescribeImageFixTask_BuildTask buildTask = new DescribeImageFixTaskResponse.DescribeImageFixTask_BuildTask();
				buildTask.BuildTaskId = _ctx.StringValue("DescribeImageFixTask.BuildTasks["+ i +"].BuildTaskId");
				buildTask.TaskType = _ctx.StringValue("DescribeImageFixTask.BuildTasks["+ i +"].TaskType");
				buildTask.RepoNamespace = _ctx.StringValue("DescribeImageFixTask.BuildTasks["+ i +"].RepoNamespace");
				buildTask.RepoName = _ctx.StringValue("DescribeImageFixTask.BuildTasks["+ i +"].RepoName");
				buildTask.RegionId = _ctx.StringValue("DescribeImageFixTask.BuildTasks["+ i +"].RegionId");
				buildTask.OldTag = _ctx.StringValue("DescribeImageFixTask.BuildTasks["+ i +"].OldTag");
				buildTask.OldUuid = _ctx.StringValue("DescribeImageFixTask.BuildTasks["+ i +"].OldUuid");
				buildTask.NewTag = _ctx.StringValue("DescribeImageFixTask.BuildTasks["+ i +"].NewTag");
				buildTask.NewUuid = _ctx.StringValue("DescribeImageFixTask.BuildTasks["+ i +"].NewUuid");
				buildTask.FixTime = _ctx.StringValue("DescribeImageFixTask.BuildTasks["+ i +"].FixTime");
				buildTask.FinishTime = _ctx.StringValue("DescribeImageFixTask.BuildTasks["+ i +"].FinishTime");
				buildTask.Status = _ctx.IntegerValue("DescribeImageFixTask.BuildTasks["+ i +"].Status");

				describeImageFixTaskResponse_buildTasks.Add(buildTask);
			}
			describeImageFixTaskResponse.BuildTasks = describeImageFixTaskResponse_buildTasks;
        
			return describeImageFixTaskResponse;
        }
    }
}
