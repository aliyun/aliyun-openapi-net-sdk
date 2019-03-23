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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeTaskInfoResponseUnmarshaller
    {
        public static DescribeTaskInfoResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeTaskInfoResponse describeTaskInfoResponse = new DescribeTaskInfoResponse();

            describeTaskInfoResponse.HttpResponse = context.HttpResponse;
            describeTaskInfoResponse.RequestId = context.StringValue("DescribeTaskInfo.RequestId");
            describeTaskInfoResponse.TaskId = context.StringValue("DescribeTaskInfo.TaskId");
            describeTaskInfoResponse.BeginTime = context.StringValue("DescribeTaskInfo.BeginTime");
            describeTaskInfoResponse.FinishTime = context.StringValue("DescribeTaskInfo.FinishTime");
            describeTaskInfoResponse.CreateTime = context.StringValue("DescribeTaskInfo.CreateTime");
            describeTaskInfoResponse.TaskAction = context.StringValue("DescribeTaskInfo.TaskAction");
            describeTaskInfoResponse.DBName = context.StringValue("DescribeTaskInfo.DBName");
            describeTaskInfoResponse.TaskErrorCode = context.StringValue("DescribeTaskInfo.TaskErrorCode");
            describeTaskInfoResponse.Progress = context.StringValue("DescribeTaskInfo.Progress");
            describeTaskInfoResponse.ExpectedFinishTime = context.StringValue("DescribeTaskInfo.ExpectedFinishTime");
            describeTaskInfoResponse.TaskErrorMessage = context.StringValue("DescribeTaskInfo.TaskErrorMessage");
            describeTaskInfoResponse.ProgressInfo = context.StringValue("DescribeTaskInfo.ProgressInfo");
            describeTaskInfoResponse.Status = context.StringValue("DescribeTaskInfo.Status");

            return describeTaskInfoResponse;
        }
    }
}