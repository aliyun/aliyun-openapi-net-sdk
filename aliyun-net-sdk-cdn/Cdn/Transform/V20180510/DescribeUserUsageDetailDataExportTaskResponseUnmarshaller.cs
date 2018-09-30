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
using Aliyun.Acs.Cdn.Model.V20180510;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeUserUsageDetailDataExportTaskResponseUnmarshaller
    {
        public static DescribeUserUsageDetailDataExportTaskResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeUserUsageDetailDataExportTaskResponse describeUserUsageDetailDataExportTaskResponse = new DescribeUserUsageDetailDataExportTaskResponse();

			describeUserUsageDetailDataExportTaskResponse.HttpResponse = context.HttpResponse;
			describeUserUsageDetailDataExportTaskResponse.RequestId = context.StringValue("DescribeUserUsageDetailDataExportTask.RequestId");

			DescribeUserUsageDetailDataExportTaskResponse.DescribeUserUsageDetailDataExportTask_UsageDataPerPage usageDataPerPage = new DescribeUserUsageDetailDataExportTaskResponse.DescribeUserUsageDetailDataExportTask_UsageDataPerPage();
			usageDataPerPage.TotalCount = context.IntegerValue("DescribeUserUsageDetailDataExportTask.UsageDataPerPage.TotalCount");
			usageDataPerPage.PageSize = context.IntegerValue("DescribeUserUsageDetailDataExportTask.UsageDataPerPage.PageSize");
			usageDataPerPage.PageNumber = context.IntegerValue("DescribeUserUsageDetailDataExportTask.UsageDataPerPage.PageNumber");

			List<DescribeUserUsageDetailDataExportTaskResponse.DescribeUserUsageDetailDataExportTask_UsageDataPerPage.DescribeUserUsageDetailDataExportTask_DataItem> usageDataPerPage_data = new List<DescribeUserUsageDetailDataExportTaskResponse.DescribeUserUsageDetailDataExportTask_UsageDataPerPage.DescribeUserUsageDetailDataExportTask_DataItem>();
			for (int i = 0; i < context.Length("DescribeUserUsageDetailDataExportTask.UsageDataPerPage.Data.Length"); i++) {
				DescribeUserUsageDetailDataExportTaskResponse.DescribeUserUsageDetailDataExportTask_UsageDataPerPage.DescribeUserUsageDetailDataExportTask_DataItem dataItem = new DescribeUserUsageDetailDataExportTaskResponse.DescribeUserUsageDetailDataExportTask_UsageDataPerPage.DescribeUserUsageDetailDataExportTask_DataItem();
				dataItem.TaskName = context.StringValue("DescribeUserUsageDetailDataExportTask.UsageDataPerPage.Data["+ i +"].TaskName");
				dataItem.TaskId = context.StringValue("DescribeUserUsageDetailDataExportTask.UsageDataPerPage.Data["+ i +"].TaskId");
				dataItem.CreateTime = context.StringValue("DescribeUserUsageDetailDataExportTask.UsageDataPerPage.Data["+ i +"].CreateTime");
				dataItem.UpdateTime = context.StringValue("DescribeUserUsageDetailDataExportTask.UsageDataPerPage.Data["+ i +"].UpdateTime");
				dataItem.Status = context.StringValue("DescribeUserUsageDetailDataExportTask.UsageDataPerPage.Data["+ i +"].Status");
				dataItem.DownloadUrl = context.StringValue("DescribeUserUsageDetailDataExportTask.UsageDataPerPage.Data["+ i +"].DownloadUrl");

				DescribeUserUsageDetailDataExportTaskResponse.DescribeUserUsageDetailDataExportTask_UsageDataPerPage.DescribeUserUsageDetailDataExportTask_DataItem.DescribeUserUsageDetailDataExportTask_TaskConfig taskConfig = new DescribeUserUsageDetailDataExportTaskResponse.DescribeUserUsageDetailDataExportTask_UsageDataPerPage.DescribeUserUsageDetailDataExportTask_DataItem.DescribeUserUsageDetailDataExportTask_TaskConfig();
				taskConfig.StartTime = context.StringValue("DescribeUserUsageDetailDataExportTask.UsageDataPerPage.Data["+ i +"].TaskConfig.StartTime");
				taskConfig.EndTime = context.StringValue("DescribeUserUsageDetailDataExportTask.UsageDataPerPage.Data["+ i +"].TaskConfig.EndTime");
				dataItem.TaskConfig = taskConfig;

				usageDataPerPage_data.Add(dataItem);
			}
			usageDataPerPage.Data = usageDataPerPage_data;
			describeUserUsageDetailDataExportTaskResponse.UsageDataPerPage = usageDataPerPage;
        
			return describeUserUsageDetailDataExportTaskResponse;
        }
    }
}