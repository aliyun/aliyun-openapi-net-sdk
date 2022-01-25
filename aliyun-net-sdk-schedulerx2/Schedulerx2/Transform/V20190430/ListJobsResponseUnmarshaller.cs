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
    public class ListJobsResponseUnmarshaller
    {
        public static ListJobsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListJobsResponse listJobsResponse = new ListJobsResponse();

			listJobsResponse.HttpResponse = _ctx.HttpResponse;
			listJobsResponse.Code = _ctx.IntegerValue("ListJobs.Code");
			listJobsResponse.Message = _ctx.StringValue("ListJobs.Message");
			listJobsResponse.RequestId = _ctx.StringValue("ListJobs.RequestId");
			listJobsResponse.Success = _ctx.BooleanValue("ListJobs.Success");

			ListJobsResponse.ListJobs_Data data = new ListJobsResponse.ListJobs_Data();

			List<ListJobsResponse.ListJobs_Data.ListJobs_Job> data_jobs = new List<ListJobsResponse.ListJobs_Data.ListJobs_Job>();
			for (int i = 0; i < _ctx.Length("ListJobs.Data.Jobs.Length"); i++) {
				ListJobsResponse.ListJobs_Data.ListJobs_Job job = new ListJobsResponse.ListJobs_Data.ListJobs_Job();
				job.Status = _ctx.IntegerValue("ListJobs.Data.Jobs["+ i +"].Status");
				job.JarUrl = _ctx.StringValue("ListJobs.Data.Jobs["+ i +"].JarUrl");
				job.MaxAttempt = _ctx.IntegerValue("ListJobs.Data.Jobs["+ i +"].MaxAttempt");
				job.Parameters = _ctx.StringValue("ListJobs.Data.Jobs["+ i +"].Parameters");
				job.Description = _ctx.StringValue("ListJobs.Data.Jobs["+ i +"].Description");
				job.JobId = _ctx.LongValue("ListJobs.Data.Jobs["+ i +"].JobId");
				job.ExecuteMode = _ctx.StringValue("ListJobs.Data.Jobs["+ i +"].ExecuteMode");
				job.MaxConcurrency = _ctx.StringValue("ListJobs.Data.Jobs["+ i +"].MaxConcurrency");
				job.Name = _ctx.StringValue("ListJobs.Data.Jobs["+ i +"].Name");
				job.ClassName = _ctx.StringValue("ListJobs.Data.Jobs["+ i +"].ClassName");
				job.Content = _ctx.StringValue("ListJobs.Data.Jobs["+ i +"].Content");
				job.AttemptInterval = _ctx.IntegerValue("ListJobs.Data.Jobs["+ i +"].AttemptInterval");

				ListJobsResponse.ListJobs_Data.ListJobs_Job.ListJobs_MapTaskXAttrs mapTaskXAttrs = new ListJobsResponse.ListJobs_Data.ListJobs_Job.ListJobs_MapTaskXAttrs();
				mapTaskXAttrs.TaskMaxAttempt = _ctx.IntegerValue("ListJobs.Data.Jobs["+ i +"].MapTaskXAttrs.TaskMaxAttempt");
				mapTaskXAttrs.TaskAttemptInterval = _ctx.IntegerValue("ListJobs.Data.Jobs["+ i +"].MapTaskXAttrs.TaskAttemptInterval");
				mapTaskXAttrs.ConsumerSize = _ctx.IntegerValue("ListJobs.Data.Jobs["+ i +"].MapTaskXAttrs.ConsumerSize");
				mapTaskXAttrs.QueueSize = _ctx.IntegerValue("ListJobs.Data.Jobs["+ i +"].MapTaskXAttrs.QueueSize");
				mapTaskXAttrs.DispatcherSize = _ctx.IntegerValue("ListJobs.Data.Jobs["+ i +"].MapTaskXAttrs.DispatcherSize");
				mapTaskXAttrs.PageSize = _ctx.IntegerValue("ListJobs.Data.Jobs["+ i +"].MapTaskXAttrs.PageSize");
				job.MapTaskXAttrs = mapTaskXAttrs;

				ListJobsResponse.ListJobs_Data.ListJobs_Job.ListJobs_TimeConfig timeConfig = new ListJobsResponse.ListJobs_Data.ListJobs_Job.ListJobs_TimeConfig();
				timeConfig.Calendar = _ctx.StringValue("ListJobs.Data.Jobs["+ i +"].TimeConfig.Calendar");
				timeConfig.TimeType = _ctx.IntegerValue("ListJobs.Data.Jobs["+ i +"].TimeConfig.TimeType");
				timeConfig.DataOffset = _ctx.IntegerValue("ListJobs.Data.Jobs["+ i +"].TimeConfig.DataOffset");
				timeConfig.TimeExpression = _ctx.StringValue("ListJobs.Data.Jobs["+ i +"].TimeConfig.TimeExpression");
				job.TimeConfig = timeConfig;

				ListJobsResponse.ListJobs_Data.ListJobs_Job.ListJobs_JobMonitorInfo jobMonitorInfo = new ListJobsResponse.ListJobs_Data.ListJobs_Job.ListJobs_JobMonitorInfo();

				ListJobsResponse.ListJobs_Data.ListJobs_Job.ListJobs_JobMonitorInfo.ListJobs_MonitorConfig monitorConfig = new ListJobsResponse.ListJobs_Data.ListJobs_Job.ListJobs_JobMonitorInfo.ListJobs_MonitorConfig();
				monitorConfig.Timeout = _ctx.LongValue("ListJobs.Data.Jobs["+ i +"].JobMonitorInfo.MonitorConfig.Timeout");
				monitorConfig.SendChannel = _ctx.StringValue("ListJobs.Data.Jobs["+ i +"].JobMonitorInfo.MonitorConfig.SendChannel");
				monitorConfig.TimeoutKillEnable = _ctx.BooleanValue("ListJobs.Data.Jobs["+ i +"].JobMonitorInfo.MonitorConfig.TimeoutKillEnable");
				monitorConfig.TimeoutEnable = _ctx.BooleanValue("ListJobs.Data.Jobs["+ i +"].JobMonitorInfo.MonitorConfig.TimeoutEnable");
				monitorConfig.FailEnable = _ctx.BooleanValue("ListJobs.Data.Jobs["+ i +"].JobMonitorInfo.MonitorConfig.FailEnable");
				monitorConfig.MissWorkerEnable = _ctx.BooleanValue("ListJobs.Data.Jobs["+ i +"].JobMonitorInfo.MonitorConfig.MissWorkerEnable");
				jobMonitorInfo.MonitorConfig = monitorConfig;

				List<ListJobsResponse.ListJobs_Data.ListJobs_Job.ListJobs_JobMonitorInfo.ListJobs_ContactInfoItem> jobMonitorInfo_contactInfo = new List<ListJobsResponse.ListJobs_Data.ListJobs_Job.ListJobs_JobMonitorInfo.ListJobs_ContactInfoItem>();
				for (int j = 0; j < _ctx.Length("ListJobs.Data.Jobs["+ i +"].JobMonitorInfo.ContactInfo.Length"); j++) {
					ListJobsResponse.ListJobs_Data.ListJobs_Job.ListJobs_JobMonitorInfo.ListJobs_ContactInfoItem contactInfoItem = new ListJobsResponse.ListJobs_Data.ListJobs_Job.ListJobs_JobMonitorInfo.ListJobs_ContactInfoItem();
					contactInfoItem.UserPhone = _ctx.StringValue("ListJobs.Data.Jobs["+ i +"].JobMonitorInfo.ContactInfo["+ j +"].UserPhone");
					contactInfoItem.UserName = _ctx.StringValue("ListJobs.Data.Jobs["+ i +"].JobMonitorInfo.ContactInfo["+ j +"].UserName");
					contactInfoItem.Ding = _ctx.StringValue("ListJobs.Data.Jobs["+ i +"].JobMonitorInfo.ContactInfo["+ j +"].Ding");
					contactInfoItem.UserMail = _ctx.StringValue("ListJobs.Data.Jobs["+ i +"].JobMonitorInfo.ContactInfo["+ j +"].UserMail");

					jobMonitorInfo_contactInfo.Add(contactInfoItem);
				}
				jobMonitorInfo.ContactInfo = jobMonitorInfo_contactInfo;
				job.JobMonitorInfo = jobMonitorInfo;

				data_jobs.Add(job);
			}
			data.Jobs = data_jobs;
			listJobsResponse.Data = data;
        
			return listJobsResponse;
        }
    }
}
