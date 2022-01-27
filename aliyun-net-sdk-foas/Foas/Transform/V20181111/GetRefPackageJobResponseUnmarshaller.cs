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
    public class GetRefPackageJobResponseUnmarshaller
    {
        public static GetRefPackageJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetRefPackageJobResponse getRefPackageJobResponse = new GetRefPackageJobResponse();

			getRefPackageJobResponse.HttpResponse = _ctx.HttpResponse;
			getRefPackageJobResponse.RequestId = _ctx.StringValue("GetRefPackageJob.RequestId");
			getRefPackageJobResponse.PageIndex = _ctx.IntegerValue("GetRefPackageJob.PageIndex");
			getRefPackageJobResponse.PageSize = _ctx.IntegerValue("GetRefPackageJob.PageSize");
			getRefPackageJobResponse.TotalCount = _ctx.LongValue("GetRefPackageJob.TotalCount");
			getRefPackageJobResponse.TotalPage = _ctx.IntegerValue("GetRefPackageJob.TotalPage");

			List<GetRefPackageJobResponse.GetRefPackageJob_Job> getRefPackageJobResponse_jobs = new List<GetRefPackageJobResponse.GetRefPackageJob_Job>();
			for (int i = 0; i < _ctx.Length("GetRefPackageJob.Jobs.Length"); i++) {
				GetRefPackageJobResponse.GetRefPackageJob_Job job = new GetRefPackageJobResponse.GetRefPackageJob_Job();
				job.JobName = _ctx.StringValue("GetRefPackageJob.Jobs["+ i +"].JobName");
				job.ProjectName = _ctx.StringValue("GetRefPackageJob.Jobs["+ i +"].ProjectName");
				job.JobType = _ctx.StringValue("GetRefPackageJob.Jobs["+ i +"].JobType");
				job.ApiType = _ctx.StringValue("GetRefPackageJob.Jobs["+ i +"].ApiType");
				job.Code = _ctx.StringValue("GetRefPackageJob.Jobs["+ i +"].Code");
				job.PlanJson = _ctx.StringValue("GetRefPackageJob.Jobs["+ i +"].PlanJson");
				job.Properties = _ctx.StringValue("GetRefPackageJob.Jobs["+ i +"].Properties");
				job.Packages = _ctx.StringValue("GetRefPackageJob.Jobs["+ i +"].Packages");
				job.IsCommitted = _ctx.BooleanValue("GetRefPackageJob.Jobs["+ i +"].IsCommitted");
				job.Creator = _ctx.StringValue("GetRefPackageJob.Jobs["+ i +"].Creator");
				job.CreateTime = _ctx.LongValue("GetRefPackageJob.Jobs["+ i +"].CreateTime");
				job.Modifier = _ctx.StringValue("GetRefPackageJob.Jobs["+ i +"].Modifier");
				job.ModifyTime = _ctx.LongValue("GetRefPackageJob.Jobs["+ i +"].ModifyTime");
				job.Description = _ctx.StringValue("GetRefPackageJob.Jobs["+ i +"].Description");
				job.EngineVersion = _ctx.StringValue("GetRefPackageJob.Jobs["+ i +"].EngineVersion");
				job.ClusterId = _ctx.StringValue("GetRefPackageJob.Jobs["+ i +"].ClusterId");
				job.QueueName = _ctx.StringValue("GetRefPackageJob.Jobs["+ i +"].QueueName");
				job.FolderId = _ctx.LongValue("GetRefPackageJob.Jobs["+ i +"].FolderId");
				job.JobId = _ctx.StringValue("GetRefPackageJob.Jobs["+ i +"].JobId");

				getRefPackageJobResponse_jobs.Add(job);
			}
			getRefPackageJobResponse.Jobs = getRefPackageJobResponse_jobs;
        
			return getRefPackageJobResponse;
        }
    }
}
