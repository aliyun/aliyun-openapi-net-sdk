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
    public class DescribeDiagnosisTasksResponseUnmarshaller
    {
        public static DescribeDiagnosisTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDiagnosisTasksResponse describeDiagnosisTasksResponse = new DescribeDiagnosisTasksResponse();

			describeDiagnosisTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeDiagnosisTasksResponse.RequestId = _ctx.StringValue("DescribeDiagnosisTasks.RequestId");
			describeDiagnosisTasksResponse.TotalCount = _ctx.IntegerValue("DescribeDiagnosisTasks.TotalCount");

			List<DescribeDiagnosisTasksResponse.DescribeDiagnosisTasks_SqlTasks> describeDiagnosisTasksResponse_taskList = new List<DescribeDiagnosisTasksResponse.DescribeDiagnosisTasks_SqlTasks>();
			for (int i = 0; i < _ctx.Length("DescribeDiagnosisTasks.TaskList.Length"); i++) {
				DescribeDiagnosisTasksResponse.DescribeDiagnosisTasks_SqlTasks sqlTasks = new DescribeDiagnosisTasksResponse.DescribeDiagnosisTasks_SqlTasks();
				sqlTasks.ScanCost = _ctx.LongValue("DescribeDiagnosisTasks.TaskList["+ i +"].ScanCost");
				sqlTasks.OutputDataSize = _ctx.LongValue("DescribeDiagnosisTasks.TaskList["+ i +"].OutputDataSize");
				sqlTasks.InputDataSize = _ctx.LongValue("DescribeDiagnosisTasks.TaskList["+ i +"].InputDataSize");
				sqlTasks.State = _ctx.StringValue("DescribeDiagnosisTasks.TaskList["+ i +"].State");
				sqlTasks.OperatorCost = _ctx.LongValue("DescribeDiagnosisTasks.TaskList["+ i +"].OperatorCost");
				sqlTasks.OutputRows = _ctx.LongValue("DescribeDiagnosisTasks.TaskList["+ i +"].OutputRows");
				sqlTasks.ScanDataSize = _ctx.LongValue("DescribeDiagnosisTasks.TaskList["+ i +"].ScanDataSize");
				sqlTasks.ElapsedTime = _ctx.LongValue("DescribeDiagnosisTasks.TaskList["+ i +"].ElapsedTime");
				sqlTasks.ScanRows = _ctx.LongValue("DescribeDiagnosisTasks.TaskList["+ i +"].ScanRows");
				sqlTasks.PeakMemory = _ctx.LongValue("DescribeDiagnosisTasks.TaskList["+ i +"].PeakMemory");
				sqlTasks.TaskId = _ctx.StringValue("DescribeDiagnosisTasks.TaskList["+ i +"].TaskId");
				sqlTasks.InputRows = _ctx.LongValue("DescribeDiagnosisTasks.TaskList["+ i +"].InputRows");
				sqlTasks.TaskCreateTime = _ctx.LongValue("DescribeDiagnosisTasks.TaskList["+ i +"].TaskCreateTime");
				sqlTasks.TaskEndTime = _ctx.LongValue("DescribeDiagnosisTasks.TaskList["+ i +"].TaskEndTime");
				sqlTasks.TaskHost = _ctx.StringValue("DescribeDiagnosisTasks.TaskList["+ i +"].TaskHost");
				sqlTasks.Drivers = _ctx.StringValue("DescribeDiagnosisTasks.TaskList["+ i +"].Drivers");
				sqlTasks.QueuedTime = _ctx.StringValue("DescribeDiagnosisTasks.TaskList["+ i +"].QueuedTime");
				sqlTasks.ComputeTimeRatio = _ctx.StringValue("DescribeDiagnosisTasks.TaskList["+ i +"].ComputeTimeRatio");

				describeDiagnosisTasksResponse_taskList.Add(sqlTasks);
			}
			describeDiagnosisTasksResponse.TaskList = describeDiagnosisTasksResponse_taskList;
        
			return describeDiagnosisTasksResponse;
        }
    }
}
