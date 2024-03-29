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
    public class DescribeTaskInfoResponseUnmarshaller
    {
        public static DescribeTaskInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTaskInfoResponse describeTaskInfoResponse = new DescribeTaskInfoResponse();

			describeTaskInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeTaskInfoResponse.RequestId = _ctx.StringValue("DescribeTaskInfo.RequestId");

			DescribeTaskInfoResponse.DescribeTaskInfo_TaskInfo taskInfo = new DescribeTaskInfoResponse.DescribeTaskInfo_TaskInfo();
			taskInfo.Status = _ctx.StringValue("DescribeTaskInfo.TaskInfo.Status");
			taskInfo.FinishTime = _ctx.StringValue("DescribeTaskInfo.TaskInfo.FinishTime");
			taskInfo.Progress = _ctx.StringValue("DescribeTaskInfo.TaskInfo.Progress");
			taskInfo.BeginTime = _ctx.StringValue("DescribeTaskInfo.TaskInfo.BeginTime");
			taskInfo.TaskId = _ctx.IntegerValue("DescribeTaskInfo.TaskInfo.TaskId");
			describeTaskInfoResponse.TaskInfo = taskInfo;
        
			return describeTaskInfoResponse;
        }
    }
}
