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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class ListPornBatchDetectJobsResponseUnmarshaller
    {
        public static ListPornBatchDetectJobsResponse Unmarshall(UnmarshallerContext context)
        {
			ListPornBatchDetectJobsResponse listPornBatchDetectJobsResponse = new ListPornBatchDetectJobsResponse();

			listPornBatchDetectJobsResponse.HttpResponse = context.HttpResponse;
			listPornBatchDetectJobsResponse.RequestId = context.StringValue("ListPornBatchDetectJobs.RequestId");
			listPornBatchDetectJobsResponse.NextMarker = context.StringValue("ListPornBatchDetectJobs.NextMarker");

			List<ListPornBatchDetectJobsResponse.ListPornBatchDetectJobs_JobsItem> listPornBatchDetectJobsResponse_jobs = new List<ListPornBatchDetectJobsResponse.ListPornBatchDetectJobs_JobsItem>();
			for (int i = 0; i < context.Length("ListPornBatchDetectJobs.Jobs.Length"); i++) {
				ListPornBatchDetectJobsResponse.ListPornBatchDetectJobs_JobsItem jobsItem = new ListPornBatchDetectJobsResponse.ListPornBatchDetectJobs_JobsItem();
				jobsItem.JobId = context.StringValue("ListPornBatchDetectJobs.Jobs["+ i +"].JobId");
				jobsItem.SrcUri = context.StringValue("ListPornBatchDetectJobs.Jobs["+ i +"].SrcUri");
				jobsItem.Status = context.StringValue("ListPornBatchDetectJobs.Jobs["+ i +"].Status");
				jobsItem.TgtUri = context.StringValue("ListPornBatchDetectJobs.Jobs["+ i +"].TgtUri");
				jobsItem.NotifyTopicName = context.IntegerValue("ListPornBatchDetectJobs.Jobs["+ i +"].NotifyTopicName");
				jobsItem.NotifyEndpoint = context.StringValue("ListPornBatchDetectJobs.Jobs["+ i +"].NotifyEndpoint");
				jobsItem.ExternalID = context.StringValue("ListPornBatchDetectJobs.Jobs["+ i +"].ExternalID");
				jobsItem.CreateTime = context.StringValue("ListPornBatchDetectJobs.Jobs["+ i +"].CreateTime");
				jobsItem.FinishTime = context.StringValue("ListPornBatchDetectJobs.Jobs["+ i +"].FinishTime");
				jobsItem.Percent = context.IntegerValue("ListPornBatchDetectJobs.Jobs["+ i +"].Percent");

				listPornBatchDetectJobsResponse_jobs.Add(jobsItem);
			}
			listPornBatchDetectJobsResponse.Jobs = listPornBatchDetectJobsResponse_jobs;
        
			return listPornBatchDetectJobsResponse;
        }
    }
}
