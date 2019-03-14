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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class MetastoreDescribeTaskResponseUnmarshaller
    {
        public static MetastoreDescribeTaskResponse Unmarshall(UnmarshallerContext context)
        {
			MetastoreDescribeTaskResponse metastoreDescribeTaskResponse = new MetastoreDescribeTaskResponse();

			metastoreDescribeTaskResponse.HttpResponse = context.HttpResponse;
			metastoreDescribeTaskResponse.RequestId = context.StringValue("MetastoreDescribeTask.RequestId");

			MetastoreDescribeTaskResponse.MetastoreDescribeTask_Task task = new MetastoreDescribeTaskResponse.MetastoreDescribeTask_Task();
			task.BizId = context.StringValue("MetastoreDescribeTask.Task.BizId");
			task.DataSourceId = context.StringValue("MetastoreDescribeTask.Task.DataSourceId");
			task.TaskType = context.StringValue("MetastoreDescribeTask.Task.TaskType");
			task.TaskStatus = context.StringValue("MetastoreDescribeTask.Task.TaskStatus");
			task.StartTime = context.LongValue("MetastoreDescribeTask.Task.StartTime");
			task.EndTime = context.LongValue("MetastoreDescribeTask.Task.EndTime");
			task.TaskDetail = context.StringValue("MetastoreDescribeTask.Task.TaskDetail");
			task.TaskObject = context.StringValue("MetastoreDescribeTask.Task.TaskObject");
			task.TaskResultDetail = context.StringValue("MetastoreDescribeTask.Task.TaskResultDetail");
			task.TaskProcess = context.IntegerValue("MetastoreDescribeTask.Task.TaskProcess");
			task.TriggerUser = context.StringValue("MetastoreDescribeTask.Task.TriggerUser");
			task.TriggerType = context.StringValue("MetastoreDescribeTask.Task.TriggerType");
			task.GmtCreate = context.LongValue("MetastoreDescribeTask.Task.GmtCreate");
			task.GmtModified = context.LongValue("MetastoreDescribeTask.Task.GmtModified");
			task.ExecuteTime = context.LongValue("MetastoreDescribeTask.Task.ExecuteTime");
			metastoreDescribeTaskResponse.Task = task;
        
			return metastoreDescribeTaskResponse;
        }
    }
}
