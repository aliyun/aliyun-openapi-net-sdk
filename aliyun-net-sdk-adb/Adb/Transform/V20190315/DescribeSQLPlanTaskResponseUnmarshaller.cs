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
    public class DescribeSQLPlanTaskResponseUnmarshaller
    {
        public static DescribeSQLPlanTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSQLPlanTaskResponse describeSQLPlanTaskResponse = new DescribeSQLPlanTaskResponse();

			describeSQLPlanTaskResponse.HttpResponse = _ctx.HttpResponse;
			describeSQLPlanTaskResponse.RequestId = _ctx.StringValue("DescribeSQLPlanTask.RequestId");

			List<DescribeSQLPlanTaskResponse.DescribeSQLPlanTask_SqlPlanTask> describeSQLPlanTaskResponse_taskList = new List<DescribeSQLPlanTaskResponse.DescribeSQLPlanTask_SqlPlanTask>();
			for (int i = 0; i < _ctx.Length("DescribeSQLPlanTask.TaskList.Length"); i++) {
				DescribeSQLPlanTaskResponse.DescribeSQLPlanTask_SqlPlanTask sqlPlanTask = new DescribeSQLPlanTaskResponse.DescribeSQLPlanTask_SqlPlanTask();
				sqlPlanTask.TaskId = _ctx.IntegerValue("DescribeSQLPlanTask.TaskList["+ i +"].TaskId");
				sqlPlanTask.State = _ctx.StringValue("DescribeSQLPlanTask.TaskList["+ i +"].State");
				sqlPlanTask.ElapsedTime = _ctx.LongValue("DescribeSQLPlanTask.TaskList["+ i +"].ElapsedTime");
				sqlPlanTask.PeakMemory = _ctx.LongValue("DescribeSQLPlanTask.TaskList["+ i +"].PeakMemory");
				sqlPlanTask.OperatorCost = _ctx.LongValue("DescribeSQLPlanTask.TaskList["+ i +"].OperatorCost");
				sqlPlanTask.InputRows = _ctx.LongValue("DescribeSQLPlanTask.TaskList["+ i +"].InputRows");
				sqlPlanTask.InputSize = _ctx.LongValue("DescribeSQLPlanTask.TaskList["+ i +"].InputSize");
				sqlPlanTask.OutputRows = _ctx.LongValue("DescribeSQLPlanTask.TaskList["+ i +"].OutputRows");
				sqlPlanTask.OutputSize = _ctx.LongValue("DescribeSQLPlanTask.TaskList["+ i +"].OutputSize");
				sqlPlanTask.ScanRows = _ctx.LongValue("DescribeSQLPlanTask.TaskList["+ i +"].ScanRows");
				sqlPlanTask.ScanSize = _ctx.LongValue("DescribeSQLPlanTask.TaskList["+ i +"].ScanSize");
				sqlPlanTask.ScanCost = _ctx.LongValue("DescribeSQLPlanTask.TaskList["+ i +"].ScanCost");

				describeSQLPlanTaskResponse_taskList.Add(sqlPlanTask);
			}
			describeSQLPlanTaskResponse.TaskList = describeSQLPlanTaskResponse_taskList;
        
			return describeSQLPlanTaskResponse;
        }
    }
}
