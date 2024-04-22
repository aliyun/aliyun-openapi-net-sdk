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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class ListJobsResponseUnmarshaller
    {
        public static ListJobsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListJobsResponse listJobsResponse = new ListJobsResponse();

			listJobsResponse.HttpResponse = _ctx.HttpResponse;
			listJobsResponse.Message = _ctx.StringValue("ListJobs.Message");
			listJobsResponse.RequestId = _ctx.StringValue("ListJobs.RequestId");
			listJobsResponse.ErrorCode = _ctx.StringValue("ListJobs.ErrorCode");
			listJobsResponse.Code = _ctx.StringValue("ListJobs.Code");
			listJobsResponse.Success = _ctx.BooleanValue("ListJobs.Success");
			listJobsResponse.CurrentPage = _ctx.IntegerValue("ListJobs.CurrentPage");
			listJobsResponse.TotalSize = _ctx.IntegerValue("ListJobs.TotalSize");
			listJobsResponse.PageSize = _ctx.IntegerValue("ListJobs.PageSize");

			ListJobsResponse.ListJobs_Data data = new ListJobsResponse.ListJobs_Data();
			data.CurrentPage = _ctx.IntegerValue("ListJobs.Data.CurrentPage");
			data.TotalSize = _ctx.IntegerValue("ListJobs.Data.TotalSize");
			data.PageSize = _ctx.IntegerValue("ListJobs.Data.PageSize");

			List<ListJobsResponse.ListJobs_Data.ListJobs_Application> data_applications = new List<ListJobsResponse.ListJobs_Data.ListJobs_Application>();
			for (int i = 0; i < _ctx.Length("ListJobs.Data.Applications.Length"); i++) {
				ListJobsResponse.ListJobs_Data.ListJobs_Application application = new ListJobsResponse.ListJobs_Data.ListJobs_Application();
				application.AppName = _ctx.StringValue("ListJobs.Data.Applications["+ i +"].AppName");
				application.NamespaceId = _ctx.StringValue("ListJobs.Data.Applications["+ i +"].NamespaceId");
				application.AppDeletingStatus = _ctx.BooleanValue("ListJobs.Data.Applications["+ i +"].AppDeletingStatus");
				application.AppId = _ctx.StringValue("ListJobs.Data.Applications["+ i +"].AppId");
				application.ScaleRuleEnabled = _ctx.BooleanValue("ListJobs.Data.Applications["+ i +"].ScaleRuleEnabled");
				application.ScaleRuleType = _ctx.StringValue("ListJobs.Data.Applications["+ i +"].ScaleRuleType");
				application.RunningInstances = _ctx.IntegerValue("ListJobs.Data.Applications["+ i +"].RunningInstances");
				application.Instances = _ctx.IntegerValue("ListJobs.Data.Applications["+ i +"].Instances");
				application.RegionId = _ctx.StringValue("ListJobs.Data.Applications["+ i +"].RegionId");
				application.AppDescription = _ctx.StringValue("ListJobs.Data.Applications["+ i +"].AppDescription");
				application.TriggerConfig = _ctx.StringValue("ListJobs.Data.Applications["+ i +"].TriggerConfig");
				application.Suspend = _ctx.BooleanValue("ListJobs.Data.Applications["+ i +"].Suspend");
				application.Active = _ctx.LongValue("ListJobs.Data.Applications["+ i +"].Active");
				application.Succeeded = _ctx.LongValue("ListJobs.Data.Applications["+ i +"].Succeeded");
				application.Failed = _ctx.LongValue("ListJobs.Data.Applications["+ i +"].Failed");
				application.LastStartTime = _ctx.LongValue("ListJobs.Data.Applications["+ i +"].LastStartTime");
				application.CompletionTime = _ctx.LongValue("ListJobs.Data.Applications["+ i +"].CompletionTime");
				application.LastChangeorderState = _ctx.StringValue("ListJobs.Data.Applications["+ i +"].LastChangeorderState");
				application.LastJobState = _ctx.StringValue("ListJobs.Data.Applications["+ i +"].LastJobState");
				application.Cpu = _ctx.IntegerValue("ListJobs.Data.Applications["+ i +"].Cpu");
				application.Mem = _ctx.IntegerValue("ListJobs.Data.Applications["+ i +"].Mem");
				application.Message = _ctx.StringValue("ListJobs.Data.Applications["+ i +"].Message");

				List<ListJobsResponse.ListJobs_Data.ListJobs_Application.ListJobs_TagsItem> application_tags = new List<ListJobsResponse.ListJobs_Data.ListJobs_Application.ListJobs_TagsItem>();
				for (int j = 0; j < _ctx.Length("ListJobs.Data.Applications["+ i +"].Tags.Length"); j++) {
					ListJobsResponse.ListJobs_Data.ListJobs_Application.ListJobs_TagsItem tagsItem = new ListJobsResponse.ListJobs_Data.ListJobs_Application.ListJobs_TagsItem();
					tagsItem.Key = _ctx.StringValue("ListJobs.Data.Applications["+ i +"].Tags["+ j +"].Key");
					tagsItem._Value = _ctx.StringValue("ListJobs.Data.Applications["+ i +"].Tags["+ j +"].Value");

					application_tags.Add(tagsItem);
				}
				application.Tags = application_tags;

				data_applications.Add(application);
			}
			data.Applications = data_applications;
			listJobsResponse.Data = data;
        
			return listJobsResponse;
        }
    }
}
