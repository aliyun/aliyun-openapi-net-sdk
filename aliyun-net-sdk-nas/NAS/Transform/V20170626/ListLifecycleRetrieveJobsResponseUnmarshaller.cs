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
using Aliyun.Acs.NAS.Model.V20170626;

namespace Aliyun.Acs.NAS.Transform.V20170626
{
    public class ListLifecycleRetrieveJobsResponseUnmarshaller
    {
        public static ListLifecycleRetrieveJobsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLifecycleRetrieveJobsResponse listLifecycleRetrieveJobsResponse = new ListLifecycleRetrieveJobsResponse();

			listLifecycleRetrieveJobsResponse.HttpResponse = _ctx.HttpResponse;
			listLifecycleRetrieveJobsResponse.TotalCount = _ctx.IntegerValue("ListLifecycleRetrieveJobs.TotalCount");
			listLifecycleRetrieveJobsResponse.RequestId = _ctx.StringValue("ListLifecycleRetrieveJobs.RequestId");
			listLifecycleRetrieveJobsResponse.PageSize = _ctx.IntegerValue("ListLifecycleRetrieveJobs.PageSize");
			listLifecycleRetrieveJobsResponse.PageNumber = _ctx.IntegerValue("ListLifecycleRetrieveJobs.PageNumber");

			List<ListLifecycleRetrieveJobsResponse.ListLifecycleRetrieveJobs_LifecycleRetrieveJob> listLifecycleRetrieveJobsResponse_lifecycleRetrieveJobs = new List<ListLifecycleRetrieveJobsResponse.ListLifecycleRetrieveJobs_LifecycleRetrieveJob>();
			for (int i = 0; i < _ctx.Length("ListLifecycleRetrieveJobs.LifecycleRetrieveJobs.Length"); i++) {
				ListLifecycleRetrieveJobsResponse.ListLifecycleRetrieveJobs_LifecycleRetrieveJob lifecycleRetrieveJob = new ListLifecycleRetrieveJobsResponse.ListLifecycleRetrieveJobs_LifecycleRetrieveJob();
				lifecycleRetrieveJob.FileSystemId = _ctx.StringValue("ListLifecycleRetrieveJobs.LifecycleRetrieveJobs["+ i +"].FileSystemId");
				lifecycleRetrieveJob.Status = _ctx.StringValue("ListLifecycleRetrieveJobs.LifecycleRetrieveJobs["+ i +"].Status");
				lifecycleRetrieveJob.DiscoveredFileCount = _ctx.LongValue("ListLifecycleRetrieveJobs.LifecycleRetrieveJobs["+ i +"].DiscoveredFileCount");
				lifecycleRetrieveJob.UpdateTime = _ctx.StringValue("ListLifecycleRetrieveJobs.LifecycleRetrieveJobs["+ i +"].UpdateTime");
				lifecycleRetrieveJob.RetrievedFileCount = _ctx.LongValue("ListLifecycleRetrieveJobs.LifecycleRetrieveJobs["+ i +"].RetrievedFileCount");
				lifecycleRetrieveJob.JobId = _ctx.StringValue("ListLifecycleRetrieveJobs.LifecycleRetrieveJobs["+ i +"].JobId");
				lifecycleRetrieveJob.CreateTime = _ctx.StringValue("ListLifecycleRetrieveJobs.LifecycleRetrieveJobs["+ i +"].CreateTime");
				lifecycleRetrieveJob.StorageType = _ctx.StringValue("ListLifecycleRetrieveJobs.LifecycleRetrieveJobs["+ i +"].StorageType");

				List<string> lifecycleRetrieveJob_paths = new List<string>();
				for (int j = 0; j < _ctx.Length("ListLifecycleRetrieveJobs.LifecycleRetrieveJobs["+ i +"].Paths.Length"); j++) {
					lifecycleRetrieveJob_paths.Add(_ctx.StringValue("ListLifecycleRetrieveJobs.LifecycleRetrieveJobs["+ i +"].Paths["+ j +"]"));
				}
				lifecycleRetrieveJob.Paths = lifecycleRetrieveJob_paths;

				listLifecycleRetrieveJobsResponse_lifecycleRetrieveJobs.Add(lifecycleRetrieveJob);
			}
			listLifecycleRetrieveJobsResponse.LifecycleRetrieveJobs = listLifecycleRetrieveJobsResponse_lifecycleRetrieveJobs;
        
			return listLifecycleRetrieveJobsResponse;
        }
    }
}
