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
        public static GetJobInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetJobInfoResponse getJobInfoResponse = new GetJobInfoResponse();

			getJobInfoResponse.HttpResponse = _ctx.HttpResponse;
			getJobInfoResponse.Code = _ctx.IntegerValue("GetJobInfo.Code");
			getJobInfoResponse.Message = _ctx.StringValue("GetJobInfo.Message");
			getJobInfoResponse.RequestId = _ctx.StringValue("GetJobInfo.RequestId");
			getJobInfoResponse.Success = _ctx.BooleanValue("GetJobInfo.Success");

			GetJobInfoResponse.GetJobInfo_Data data = new GetJobInfoResponse.GetJobInfo_Data();

			GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo jobConfigInfo = new GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo();
			jobConfigInfo.Status = _ctx.IntegerValue("GetJobInfo.Data.JobConfigInfo.Status");
			jobConfigInfo.Parameters = _ctx.StringValue("GetJobInfo.Data.JobConfigInfo.Parameters");
			jobConfigInfo.Description = _ctx.StringValue("GetJobInfo.Data.JobConfigInfo.Description");
			jobConfigInfo.ExecuteMode = _ctx.StringValue("GetJobInfo.Data.JobConfigInfo.ExecuteMode");
			jobConfigInfo.MaxConcurrency = _ctx.StringValue("GetJobInfo.Data.JobConfigInfo.MaxConcurrency");
			jobConfigInfo.Name = _ctx.StringValue("GetJobInfo.Data.JobConfigInfo.Name");
			jobConfigInfo.MaxAttempt = _ctx.IntegerValue("GetJobInfo.Data.JobConfigInfo.MaxAttempt");
			jobConfigInfo.Content = _ctx.StringValue("GetJobInfo.Data.JobConfigInfo.Content");
			jobConfigInfo.JarUrl = _ctx.StringValue("GetJobInfo.Data.JobConfigInfo.JarUrl");
			jobConfigInfo.ClassName = _ctx.StringValue("GetJobInfo.Data.JobConfigInfo.ClassName");
			jobConfigInfo.AttemptInterval = _ctx.IntegerValue("GetJobInfo.Data.JobConfigInfo.AttemptInterval");

			GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo.GetJobInfo_MapTaskXAttrs mapTaskXAttrs = new GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo.GetJobInfo_MapTaskXAttrs();
			mapTaskXAttrs.TaskMaxAttempt = _ctx.IntegerValue("GetJobInfo.Data.JobConfigInfo.MapTaskXAttrs.TaskMaxAttempt");
			mapTaskXAttrs.TaskAttemptInterval = _ctx.IntegerValue("GetJobInfo.Data.JobConfigInfo.MapTaskXAttrs.TaskAttemptInterval");
			mapTaskXAttrs.ConsumerSize = _ctx.IntegerValue("GetJobInfo.Data.JobConfigInfo.MapTaskXAttrs.ConsumerSize");
			mapTaskXAttrs.QueueSize = _ctx.IntegerValue("GetJobInfo.Data.JobConfigInfo.MapTaskXAttrs.QueueSize");
			mapTaskXAttrs.DispatcherSize = _ctx.IntegerValue("GetJobInfo.Data.JobConfigInfo.MapTaskXAttrs.DispatcherSize");
			mapTaskXAttrs.PageSize = _ctx.IntegerValue("GetJobInfo.Data.JobConfigInfo.MapTaskXAttrs.PageSize");
			jobConfigInfo.MapTaskXAttrs = mapTaskXAttrs;

			GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo.GetJobInfo_TimeConfig timeConfig = new GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo.GetJobInfo_TimeConfig();
			timeConfig.Calendar = _ctx.StringValue("GetJobInfo.Data.JobConfigInfo.TimeConfig.Calendar");
			timeConfig.TimeType = _ctx.IntegerValue("GetJobInfo.Data.JobConfigInfo.TimeConfig.TimeType");
			timeConfig.DataOffset = _ctx.IntegerValue("GetJobInfo.Data.JobConfigInfo.TimeConfig.DataOffset");
			timeConfig.TimeExpression = _ctx.StringValue("GetJobInfo.Data.JobConfigInfo.TimeConfig.TimeExpression");
			jobConfigInfo.TimeConfig = timeConfig;

			GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo.GetJobInfo_JobMonitorInfo jobMonitorInfo = new GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo.GetJobInfo_JobMonitorInfo();

			GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo.GetJobInfo_JobMonitorInfo.GetJobInfo_MonitorConfig monitorConfig = new GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo.GetJobInfo_JobMonitorInfo.GetJobInfo_MonitorConfig();
			monitorConfig.Timeout = _ctx.LongValue("GetJobInfo.Data.JobConfigInfo.JobMonitorInfo.MonitorConfig.Timeout");
			monitorConfig.SendChannel = _ctx.StringValue("GetJobInfo.Data.JobConfigInfo.JobMonitorInfo.MonitorConfig.SendChannel");
			monitorConfig.TimeoutKillEnable = _ctx.BooleanValue("GetJobInfo.Data.JobConfigInfo.JobMonitorInfo.MonitorConfig.TimeoutKillEnable");
			monitorConfig.TimeoutEnable = _ctx.BooleanValue("GetJobInfo.Data.JobConfigInfo.JobMonitorInfo.MonitorConfig.TimeoutEnable");
			monitorConfig.FailEnable = _ctx.BooleanValue("GetJobInfo.Data.JobConfigInfo.JobMonitorInfo.MonitorConfig.FailEnable");
			monitorConfig.MissWorkerEnable = _ctx.BooleanValue("GetJobInfo.Data.JobConfigInfo.JobMonitorInfo.MonitorConfig.MissWorkerEnable");
			jobMonitorInfo.MonitorConfig = monitorConfig;

			List<GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo.GetJobInfo_JobMonitorInfo.GetJobInfo_ContactInfoItem> jobMonitorInfo_contactInfo = new List<GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo.GetJobInfo_JobMonitorInfo.GetJobInfo_ContactInfoItem>();
			for (int i = 0; i < _ctx.Length("GetJobInfo.Data.JobConfigInfo.JobMonitorInfo.ContactInfo.Length"); i++) {
				GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo.GetJobInfo_JobMonitorInfo.GetJobInfo_ContactInfoItem contactInfoItem = new GetJobInfoResponse.GetJobInfo_Data.GetJobInfo_JobConfigInfo.GetJobInfo_JobMonitorInfo.GetJobInfo_ContactInfoItem();
				contactInfoItem.UserPhone = _ctx.StringValue("GetJobInfo.Data.JobConfigInfo.JobMonitorInfo.ContactInfo["+ i +"].UserPhone");
				contactInfoItem.UserName = _ctx.StringValue("GetJobInfo.Data.JobConfigInfo.JobMonitorInfo.ContactInfo["+ i +"].UserName");
				contactInfoItem.UserMail = _ctx.StringValue("GetJobInfo.Data.JobConfigInfo.JobMonitorInfo.ContactInfo["+ i +"].UserMail");
				contactInfoItem.Ding = _ctx.StringValue("GetJobInfo.Data.JobConfigInfo.JobMonitorInfo.ContactInfo["+ i +"].Ding");

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
