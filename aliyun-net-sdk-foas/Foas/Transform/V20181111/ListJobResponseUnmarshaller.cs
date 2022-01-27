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
        public static ListJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListJobResponse listJobResponse = new ListJobResponse();

			listJobResponse.HttpResponse = _ctx.HttpResponse;
			listJobResponse.RequestId = _ctx.StringValue("ListJob.RequestId");
			listJobResponse.PageIndex = _ctx.IntegerValue("ListJob.PageIndex");
			listJobResponse.PageSize = _ctx.IntegerValue("ListJob.PageSize");
			listJobResponse.TotalPage = _ctx.IntegerValue("ListJob.TotalPage");
			listJobResponse.TotalCount = _ctx.LongValue("ListJob.TotalCount");

			List<ListJobResponse.ListJob_Job> listJobResponse_jobs = new List<ListJobResponse.ListJob_Job>();
			for (int i = 0; i < _ctx.Length("ListJob.Jobs.Length"); i++) {
				ListJobResponse.ListJob_Job job = new ListJobResponse.ListJob_Job();
				job.JobName = _ctx.StringValue("ListJob.Jobs["+ i +"].JobName");
				job.ProjectName = _ctx.StringValue("ListJob.Jobs["+ i +"].ProjectName");
				job.JobType = _ctx.StringValue("ListJob.Jobs["+ i +"].JobType");
				job.ApiType = _ctx.StringValue("ListJob.Jobs["+ i +"].ApiType");
				job.Code = _ctx.StringValue("ListJob.Jobs["+ i +"].Code");
				job.PlanJson = _ctx.StringValue("ListJob.Jobs["+ i +"].PlanJson");
				job.Properties = _ctx.StringValue("ListJob.Jobs["+ i +"].Properties");
				job.Packages = _ctx.StringValue("ListJob.Jobs["+ i +"].Packages");
				job.IsCommitted = _ctx.BooleanValue("ListJob.Jobs["+ i +"].IsCommitted");
				job.Creator = _ctx.StringValue("ListJob.Jobs["+ i +"].Creator");
				job.CreateTime = _ctx.LongValue("ListJob.Jobs["+ i +"].CreateTime");
				job.Modifier = _ctx.StringValue("ListJob.Jobs["+ i +"].Modifier");
				job.ModifyTime = _ctx.LongValue("ListJob.Jobs["+ i +"].ModifyTime");
				job.Description = _ctx.StringValue("ListJob.Jobs["+ i +"].Description");
				job.EngineVersion = _ctx.StringValue("ListJob.Jobs["+ i +"].EngineVersion");
				job.ClusterId = _ctx.StringValue("ListJob.Jobs["+ i +"].ClusterId");
				job.QueueName = _ctx.StringValue("ListJob.Jobs["+ i +"].QueueName");
				job.FolderId = _ctx.LongValue("ListJob.Jobs["+ i +"].FolderId");
				job.JobId = _ctx.StringValue("ListJob.Jobs["+ i +"].JobId");

				listJobResponse_jobs.Add(job);
			}
			listJobResponse.Jobs = listJobResponse_jobs;
        
			return listJobResponse;
        }
    }
}
