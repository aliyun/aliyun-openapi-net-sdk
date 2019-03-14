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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListJobExecutionInstancesResponseUnmarshaller
    {
        public static ListJobExecutionInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			ListJobExecutionInstancesResponse listJobExecutionInstancesResponse = new ListJobExecutionInstancesResponse();

			listJobExecutionInstancesResponse.HttpResponse = context.HttpResponse;
			listJobExecutionInstancesResponse.RequestId = context.StringValue("ListJobExecutionInstances.RequestId");
			listJobExecutionInstancesResponse.TotalCount = context.IntegerValue("ListJobExecutionInstances.TotalCount");
			listJobExecutionInstancesResponse.PageNumber = context.IntegerValue("ListJobExecutionInstances.PageNumber");
			listJobExecutionInstancesResponse.PageSize = context.IntegerValue("ListJobExecutionInstances.PageSize");

			List<ListJobExecutionInstancesResponse.ListJobExecutionInstances_JobInstance> listJobExecutionInstancesResponse_jobInstances = new List<ListJobExecutionInstancesResponse.ListJobExecutionInstances_JobInstance>();
			for (int i = 0; i < context.Length("ListJobExecutionInstances.JobInstances.Length"); i++) {
				ListJobExecutionInstancesResponse.ListJobExecutionInstances_JobInstance jobInstance = new ListJobExecutionInstancesResponse.ListJobExecutionInstances_JobInstance();
				jobInstance.Id = context.StringValue("ListJobExecutionInstances.JobInstances["+ i +"].Id");
				jobInstance.JobName = context.StringValue("ListJobExecutionInstances.JobInstances["+ i +"].JobName");
				jobInstance.StartTime = context.LongValue("ListJobExecutionInstances.JobInstances["+ i +"].StartTime");
				jobInstance.RunTime = context.IntegerValue("ListJobExecutionInstances.JobInstances["+ i +"].RunTime");
				jobInstance.JobType = context.StringValue("ListJobExecutionInstances.JobInstances["+ i +"].JobType");
				jobInstance.JobId = context.StringValue("ListJobExecutionInstances.JobInstances["+ i +"].JobId");
				jobInstance.ClusterId = context.StringValue("ListJobExecutionInstances.JobInstances["+ i +"].ClusterId");
				jobInstance.Status = context.StringValue("ListJobExecutionInstances.JobInstances["+ i +"].Status");
				jobInstance.RetryInfo = context.StringValue("ListJobExecutionInstances.JobInstances["+ i +"].RetryInfo");

				listJobExecutionInstancesResponse_jobInstances.Add(jobInstance);
			}
			listJobExecutionInstancesResponse.JobInstances = listJobExecutionInstancesResponse_jobInstances;
        
			return listJobExecutionInstancesResponse;
        }
    }
}
