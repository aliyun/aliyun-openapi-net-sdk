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
using Aliyun.Acs.schedulerx2.Model.V20190430;

namespace Aliyun.Acs.schedulerx2.Transform.V20190430
{
    public class GetJobInfoResponseUnmarshaller
    {
        public static GetJobInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetJobInfoResponse getJobInfoResponse = new GetJobInfoResponse();

			getJobInfoResponse.HttpResponse = context.HttpResponse;
			getJobInfoResponse.RequestId = context.StringValue("GetJobInfo.RequestId");
			getJobInfoResponse.Code = context.IntegerValue("GetJobInfo.Code");
			getJobInfoResponse.Message = context.StringValue("GetJobInfo.Message");
			getJobInfoResponse.Success = context.BooleanValue("GetJobInfo.Success");

			GetJobInfoResponse.GetJobInfo_Data data = new GetJobInfoResponse.GetJobInfo_Data();

			GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo jobConfigInfo = new GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo();
			jobConfigInfo.ClassName = context.StringValue("GetJobInfo.Data.JobConfigInfo.ClassName");
			jobConfigInfo.JarUrl = context.StringValue("GetJobInfo.Data.JobConfigInfo.JarUrl");
			jobConfigInfo.Content = context.StringValue("GetJobInfo.Data.JobConfigInfo.Content");
			jobConfigInfo.Name = context.StringValue("GetJobInfo.Data.JobConfigInfo.Name");
			jobConfigInfo.Description = context.StringValue("GetJobInfo.Data.JobConfigInfo.Description");
			jobConfigInfo.Status = context.IntegerValue("GetJobInfo.Data.JobConfigInfo.Status");
			jobConfigInfo.ExecuteMode = context.StringValue("GetJobInfo.Data.JobConfigInfo.ExecuteMode");
			jobConfigInfo.Parameters = context.StringValue("GetJobInfo.Data.JobConfigInfo.Parameters");
			jobConfigInfo.MaxConcurrency = context.StringValue("GetJobInfo.Data.JobConfigInfo.MaxConcurrency");
			jobConfigInfo.MaxAttempt = context.IntegerValue("GetJobInfo.Data.JobConfigInfo.MaxAttempt");
			jobConfigInfo.AttemptInterval = context.IntegerValue("GetJobInfo.Data.JobConfigInfo.AttemptInterval");

			GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo.GetJobInfo_MapTaskXAttrs mapTaskXAttrs = new GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo.GetJobInfo_MapTaskXAttrs();
			mapTaskXAttrs.PageSize = context.IntegerValue("GetJobInfo.Data.JobConfigInfo.MapTaskXAttrs.PageSize");
			mapTaskXAttrs.ConsumerSize = context.IntegerValue("GetJobInfo.Data.JobConfigInfo.MapTaskXAttrs.ConsumerSize");
			mapTaskXAttrs.QueueSize = context.IntegerValue("GetJobInfo.Data.JobConfigInfo.MapTaskXAttrs.QueueSize");
			mapTaskXAttrs.DispatcherSize = context.IntegerValue("GetJobInfo.Data.JobConfigInfo.MapTaskXAttrs.DispatcherSize");
			mapTaskXAttrs.TaskMaxAttempt = context.IntegerValue("GetJobInfo.Data.JobConfigInfo.MapTaskXAttrs.TaskMaxAttempt");
			mapTaskXAttrs.TaskAttemptInterval = context.IntegerValue("GetJobInfo.Data.JobConfigInfo.MapTaskXAttrs.TaskAttemptInterval");
			jobConfigInfo.MapTaskXAttrs = mapTaskXAttrs;

			GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo.GetJobInfo_TimeConfig timeConfig = new GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo.GetJobInfo_TimeConfig();
			timeConfig.TimeType = context.IntegerValue("GetJobInfo.Data.JobConfigInfo.TimeConfig.TimeType");
			timeConfig.TimeExpression = context.StringValue("GetJobInfo.Data.JobConfigInfo.TimeConfig.TimeExpression");
			timeConfig.Calendar = context.StringValue("GetJobInfo.Data.JobConfigInfo.TimeConfig.Calendar");
			timeConfig.DataOffset = context.IntegerValue("GetJobInfo.Data.JobConfigInfo.TimeConfig.DataOffset");
			jobConfigInfo.TimeConfig = timeConfig;

			GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo.GetJobInfo_JobMonitorInfo jobMonitorInfo = new GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo.GetJobInfo_JobMonitorInfo();

			GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo.GetJobInfo_JobMonitorInfo.GetJobInfo_MonitorConfig monitorConfig = new GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo.GetJobInfo_JobMonitorInfo.GetJobInfo_MonitorConfig();
			monitorConfig.TimeoutEnable = context.BooleanValue("GetJobInfo.Data.JobConfigInfo.JobMonitorInfo.MonitorConfig.TimeoutEnable");
			monitorConfig.Timeout = context.LongValue("GetJobInfo.Data.JobConfigInfo.JobMonitorInfo.MonitorConfig.Timeout");
			monitorConfig.TimeoutKillEnable = context.BooleanValue("GetJobInfo.Data.JobConfigInfo.JobMonitorInfo.MonitorConfig.TimeoutKillEnable");
			monitorConfig.FailEnable = context.BooleanValue("GetJobInfo.Data.JobConfigInfo.JobMonitorInfo.MonitorConfig.FailEnable");
			monitorConfig.SendChannel = context.StringValue("GetJobInfo.Data.JobConfigInfo.JobMonitorInfo.MonitorConfig.SendChannel");
			jobMonitorInfo.MonitorConfig = monitorConfig;

			List<GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo.GetJobInfo_JobMonitorInfo.GetJobInfo_ContactInfoItem> jobMonitorInfo_contactInfo = new List<GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo.GetJobInfo_JobMonitorInfo.GetJobInfo_ContactInfoItem>();
			for (int i = 0; i < context.Length("GetJobInfo.Data.JobConfigInfo.JobMonitorInfo.ContactInfo.Length"); i++) {
				GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo.GetJobInfo_JobMonitorInfo.GetJobInfo_ContactInfoItem contactInfoItem = new GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo.GetJobInfo_JobMonitorInfo.GetJobInfo_ContactInfoItem();
				contactInfoItem.UserName = context.StringValue("GetJobInfo.Data.JobConfigInfo.JobMonitorInfo.ContactInfo["+ i +"].UserName");
				contactInfoItem.UserPhone = context.StringValue("GetJobInfo.Data.JobConfigInfo.JobMonitorInfo.ContactInfo["+ i +"].UserPhone");

				jobMonitorInfo_contactInfo.Add(contactInfoItem);
			}
			jobMonitorInfo.ContactInfo = jobMonitorInfo_contactInfo;
			jobConfigInfo.JobMonitorInfo = jobMonitorInfo;
			data.JobConfigInfo = jobConfigInfo;
			getJobInfoResponse.Data = data;
        
			return getJobInfoResponse;
        }
    }
}
