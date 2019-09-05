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
using Aliyun.Acs.foas.Model.V20181111;

namespace Aliyun.Acs.foas.Transform.V20181111
{
    public class ListJobResponseUnmarshaller
    {
        public static ListJobResponse Unmarshall(UnmarshallerContext context)
        {
			ListJobResponse listJobResponse = new ListJobResponse();

			listJobResponse.HttpResponse = context.HttpResponse;
			listJobResponse.RequestId = context.StringValue("ListJob.RequestId");
			listJobResponse.PageIndex = context.IntegerValue("ListJob.PageIndex");
			listJobResponse.PageSize = context.IntegerValue("ListJob.PageSize");
			listJobResponse.TotalPage = context.IntegerValue("ListJob.TotalPage");
			listJobResponse.TotalCount = context.LongValue("ListJob.TotalCount");

			List<ListJobResponse.ListJob_Job> listJobResponse_jobs = new List<ListJobResponse.ListJob_Job>();
			for (int i = 0; i < context.Length("ListJob.Jobs.Length"); i++) {
				ListJobResponse.ListJob_Job job = new ListJobResponse.ListJob_Job();
				job.JobName = context.StringValue("ListJob.Jobs["+ i +"].JobName");
				job.ProjectName = context.StringValue("ListJob.Jobs["+ i +"].ProjectName");
				job.JobType = context.StringValue("ListJob.Jobs["+ i +"].JobType");
				job.ApiType = context.StringValue("ListJob.Jobs["+ i +"].ApiType");
				job.Code = context.StringValue("ListJob.Jobs["+ i +"].Code");
				job.PlanJson = context.StringValue("ListJob.Jobs["+ i +"].PlanJson");
				job.Properties = context.StringValue("ListJob.Jobs["+ i +"].Properties");
				job.Packages = context.StringValue("ListJob.Jobs["+ i +"].Packages");
				job.IsCommitted = context.BooleanValue("ListJob.Jobs["+ i +"].IsCommitted");
				job.Creator = context.StringValue("ListJob.Jobs["+ i +"].Creator");
				job.CreateTime = context.LongValue("ListJob.Jobs["+ i +"].CreateTime");
				job.Modifier = context.StringValue("ListJob.Jobs["+ i +"].Modifier");
				job.ModifyTime = context.LongValue("ListJob.Jobs["+ i +"].ModifyTime");
				job.Description = context.StringValue("ListJob.Jobs["+ i +"].Description");
				job.EngineVersion = context.StringValue("ListJob.Jobs["+ i +"].EngineVersion");
				job.ClusterId = context.StringValue("ListJob.Jobs["+ i +"].ClusterId");
				job.QueueName = context.StringValue("ListJob.Jobs["+ i +"].QueueName");
				job.FolderId = context.LongValue("ListJob.Jobs["+ i +"].FolderId");
				job.JobId = context.StringValue("ListJob.Jobs["+ i +"].JobId");

				listJobResponse_jobs.Add(job);
			}
			listJobResponse.Jobs = listJobResponse_jobs;
        
			return listJobResponse;
        }
    }
}
