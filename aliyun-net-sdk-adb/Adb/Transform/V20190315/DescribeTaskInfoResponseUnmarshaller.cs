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
        public static DescribeTaskInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTaskInfoResponse describeTaskInfoResponse = new DescribeTaskInfoResponse();

			describeTaskInfoResponse.HttpResponse = context.HttpResponse;
			describeTaskInfoResponse.RequestId = context.StringValue("DescribeTaskInfo.RequestId");

			DescribeTaskInfoResponse.DescribeTaskInfo_TaskInfo taskInfo = new DescribeTaskInfoResponse.DescribeTaskInfo_TaskInfo();
			taskInfo.TaskId = context.IntegerValue("DescribeTaskInfo.TaskInfo.TaskId");
			taskInfo.BeginTime = context.StringValue("DescribeTaskInfo.TaskInfo.BeginTime");
			taskInfo.FinishTime = context.StringValue("DescribeTaskInfo.TaskInfo.FinishTime");
			taskInfo.Progress = context.StringValue("DescribeTaskInfo.TaskInfo.Progress");
			taskInfo.Status = context.StringValue("DescribeTaskInfo.TaskInfo.Status");
			describeTaskInfoResponse.TaskInfo = taskInfo;
        
			return describeTaskInfoResponse;
        }
    }
}
