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
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeTasksResponseUnmarshaller
    {
        public static DescribeTasksResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeTasksResponse describeTasksResponse = new DescribeTasksResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeTasks.RequestId"),
                TotalRecordCount = context.IntegerValue("DescribeTasks.TotalRecordCount"),
                PageNumber = context.IntegerValue("DescribeTasks.PageNumber"),
                PageRecordCount = context.IntegerValue("DescribeTasks.PageRecordCount")
            };
            List<DescribeTasksResponse.TaskProgressInfo> items = new List<DescribeTasksResponse.TaskProgressInfo>();
			for (int i = 0; i < context.Length("DescribeTasks.Items.Length"); i++) {
                DescribeTasksResponse.TaskProgressInfo taskProgressInfo = new DescribeTasksResponse.TaskProgressInfo()
                {
                    DBName = context.StringValue($"DescribeTasks.Items[{i}].DBName"),
                    BeginTime = context.StringValue($"DescribeTasks.Items[{i}].BeginTime"),
                    ProgressInfo = context.StringValue($"DescribeTasks.Items[{i}].ProgressInfo"),
                    FinishTime = context.StringValue($"DescribeTasks.Items[{i}].FinishTime"),
                    TaskAction = context.StringValue($"DescribeTasks.Items[{i}].TaskAction"),
                    TaskId = context.StringValue($"DescribeTasks.Items[{i}].TaskId"),
                    Progress = context.StringValue($"DescribeTasks.Items[{i}].Progress"),
                    ExpectedFinishTime = context.StringValue($"DescribeTasks.Items[{i}].ExpectedFinishTime"),
                    Status = context.EnumValue<DescribeTasksResponse.TaskProgressInfo.StatusEnum>($"DescribeTasks.Items[{i}].Status"),
                    TaskErrorCode = context.StringValue($"DescribeTasks.Items[{i}].TaskErrorCode"),
                    TaskErrorMessage = context.StringValue($"DescribeTasks.Items[{i}].TaskErrorMessage")
                };
                items.Add(taskProgressInfo);
			}
			describeTasksResponse.Items = items;
        
			return describeTasksResponse;
        }
    }
}