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
    public class DescribeRealtimeDiagnosesResponseUnmarshaller
    {
        public static DescribeRealtimeDiagnosesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRealtimeDiagnosesResponse describeRealtimeDiagnosesResponse = new DescribeRealtimeDiagnosesResponse();

			describeRealtimeDiagnosesResponse.HttpResponse = context.HttpResponse;
			describeRealtimeDiagnosesResponse.RequestId = context.StringValue("DescribeRealtimeDiagnoses.RequestId");
			describeRealtimeDiagnosesResponse.Engine = context.StringValue("DescribeRealtimeDiagnoses.Engine");
			describeRealtimeDiagnosesResponse.TotalRecordCount = context.IntegerValue("DescribeRealtimeDiagnoses.TotalRecordCount");
			describeRealtimeDiagnosesResponse.PageNumber = context.IntegerValue("DescribeRealtimeDiagnoses.PageNumber");
			describeRealtimeDiagnosesResponse.PageRecordCount = context.IntegerValue("DescribeRealtimeDiagnoses.PageRecordCount");

			List<DescribeRealtimeDiagnosesResponse.RealtimeDiagnoseTasks> tasks = new List<DescribeRealtimeDiagnosesResponse.RealtimeDiagnoseTasks>();
			for (int i = 0; i < context.Length("DescribeRealtimeDiagnoses.Tasks.Length"); i++) {
				DescribeRealtimeDiagnosesResponse.RealtimeDiagnoseTasks realtimeDiagnoseTasks = new DescribeRealtimeDiagnosesResponse.RealtimeDiagnoseTasks();
				realtimeDiagnoseTasks.CreateTime = context.StringValue("DescribeRealtimeDiagnoses.Tasks["+ i +"].CreateTime");
				realtimeDiagnoseTasks.TaskId = context.StringValue("DescribeRealtimeDiagnoses.Tasks["+ i +"].TaskId");
				realtimeDiagnoseTasks.HealthScore = context.StringValue("DescribeRealtimeDiagnoses.Tasks["+ i +"].HealthScore");
				realtimeDiagnoseTasks.Status = context.EnumValue<DescribeRealtimeDiagnosesResponse.RealtimeDiagnoseTasks.StatusEnum>("DescribeRealtimeDiagnoses.Tasks["+ i +"].Status");

				tasks.Add(realtimeDiagnoseTasks);
			}
			describeRealtimeDiagnosesResponse.Tasks = tasks;
        
			return describeRealtimeDiagnosesResponse;
        }
    }
}