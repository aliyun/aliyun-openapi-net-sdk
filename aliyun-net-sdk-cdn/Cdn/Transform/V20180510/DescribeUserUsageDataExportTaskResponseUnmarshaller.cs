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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeUserUsageDataExportTaskResponseUnmarshaller
    {
        public static DescribeUserUsageDataExportTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeUserUsageDataExportTaskResponse describeUserUsageDataExportTaskResponse = new DescribeUserUsageDataExportTaskResponse();

			describeUserUsageDataExportTaskResponse.HttpResponse = _ctx.HttpResponse;
			describeUserUsageDataExportTaskResponse.RequestId = _ctx.StringValue("DescribeUserUsageDataExportTask.RequestId");

			DescribeUserUsageDataExportTaskResponse.DescribeUserUsageDataExportTask_UsageDataPerPage usageDataPerPage = new DescribeUserUsageDataExportTaskResponse.DescribeUserUsageDataExportTask_UsageDataPerPage();
			usageDataPerPage.TotalCount = _ctx.IntegerValue("DescribeUserUsageDataExportTask.UsageDataPerPage.TotalCount");
			usageDataPerPage.PageSize = _ctx.IntegerValue("DescribeUserUsageDataExportTask.UsageDataPerPage.PageSize");
			usageDataPerPage.PageNumber = _ctx.IntegerValue("DescribeUserUsageDataExportTask.UsageDataPerPage.PageNumber");

			List<DescribeUserUsageDataExportTaskResponse.DescribeUserUsageDataExportTask_UsageDataPerPage.DescribeUserUsageDataExportTask_DataItem> usageDataPerPage_data = new List<DescribeUserUsageDataExportTaskResponse.DescribeUserUsageDataExportTask_UsageDataPerPage.DescribeUserUsageDataExportTask_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeUserUsageDataExportTask.UsageDataPerPage.Data.Length"); i++) {
				DescribeUserUsageDataExportTaskResponse.DescribeUserUsageDataExportTask_UsageDataPerPage.DescribeUserUsageDataExportTask_DataItem dataItem = new DescribeUserUsageDataExportTaskResponse.DescribeUserUsageDataExportTask_UsageDataPerPage.DescribeUserUsageDataExportTask_DataItem();
				dataItem.TaskName = _ctx.StringValue("DescribeUserUsageDataExportTask.UsageDataPerPage.Data["+ i +"].TaskName");
				dataItem.TaskId = _ctx.StringValue("DescribeUserUsageDataExportTask.UsageDataPerPage.Data["+ i +"].TaskId");
				dataItem.CreateTime = _ctx.StringValue("DescribeUserUsageDataExportTask.UsageDataPerPage.Data["+ i +"].CreateTime");
				dataItem.UpdateTime = _ctx.StringValue("DescribeUserUsageDataExportTask.UsageDataPerPage.Data["+ i +"].UpdateTime");
				dataItem.Status = _ctx.StringValue("DescribeUserUsageDataExportTask.UsageDataPerPage.Data["+ i +"].Status");
				dataItem.DownloadUrl = _ctx.StringValue("DescribeUserUsageDataExportTask.UsageDataPerPage.Data["+ i +"].DownloadUrl");

				DescribeUserUsageDataExportTaskResponse.DescribeUserUsageDataExportTask_UsageDataPerPage.DescribeUserUsageDataExportTask_DataItem.DescribeUserUsageDataExportTask_TaskConfig taskConfig = new DescribeUserUsageDataExportTaskResponse.DescribeUserUsageDataExportTask_UsageDataPerPage.DescribeUserUsageDataExportTask_DataItem.DescribeUserUsageDataExportTask_TaskConfig();
				taskConfig.StartTime = _ctx.StringValue("DescribeUserUsageDataExportTask.UsageDataPerPage.Data["+ i +"].TaskConfig.StartTime");
				taskConfig.EndTime = _ctx.StringValue("DescribeUserUsageDataExportTask.UsageDataPerPage.Data["+ i +"].TaskConfig.EndTime");
				dataItem.TaskConfig = taskConfig;

				usageDataPerPage_data.Add(dataItem);
			}
			usageDataPerPage.Data = usageDataPerPage_data;
			describeUserUsageDataExportTaskResponse.UsageDataPerPage = usageDataPerPage;
        
			return describeUserUsageDataExportTaskResponse;
        }
    }
}
