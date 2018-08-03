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
using Aliyun.Acs.imm.Model.V20170906;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class ListFaceJobsResponseUnmarshaller
    {
        public static ListFaceJobsResponse Unmarshall(UnmarshallerContext context)
        {
			ListFaceJobsResponse listFaceJobsResponse = new ListFaceJobsResponse();

			listFaceJobsResponse.HttpResponse = context.HttpResponse;
			listFaceJobsResponse.RequestId = context.StringValue("ListFaceJobs.RequestId");
			listFaceJobsResponse.NextMarker = context.StringValue("ListFaceJobs.NextMarker");

			List<ListFaceJobsResponse.ListFaceJobs_JobsItem> listFaceJobsResponse_jobs = new List<ListFaceJobsResponse.ListFaceJobs_JobsItem>();
			for (int i = 0; i < context.Length("ListFaceJobs.Jobs.Length"); i++) {
				ListFaceJobsResponse.ListFaceJobs_JobsItem jobsItem = new ListFaceJobsResponse.ListFaceJobs_JobsItem();
				jobsItem.JobId = context.StringValue("ListFaceJobs.Jobs["+ i +"].JobId");
				jobsItem.SetId = context.StringValue("ListFaceJobs.Jobs["+ i +"].SetId");
				jobsItem.SrcUri = context.StringValue("ListFaceJobs.Jobs["+ i +"].SrcUri");
				jobsItem.Status = context.StringValue("ListFaceJobs.Jobs["+ i +"].Status");
				jobsItem.Percent = context.IntegerValue("ListFaceJobs.Jobs["+ i +"].Percent");
				jobsItem.CreateTime = context.StringValue("ListFaceJobs.Jobs["+ i +"].CreateTime");
				jobsItem.FinishTime = context.StringValue("ListFaceJobs.Jobs["+ i +"].FinishTime");

				listFaceJobsResponse_jobs.Add(jobsItem);
			}
			listFaceJobsResponse.Jobs = listFaceJobsResponse_jobs;
        
			return listFaceJobsResponse;
        }
    }
}