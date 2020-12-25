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
        public static ListJobExecutionInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListJobExecutionInstancesResponse listJobExecutionInstancesResponse = new ListJobExecutionInstancesResponse();

			listJobExecutionInstancesResponse.HttpResponse = _ctx.HttpResponse;
			listJobExecutionInstancesResponse.RequestId = _ctx.StringValue("ListJobExecutionInstances.RequestId");
			listJobExecutionInstancesResponse.TotalCount = _ctx.IntegerValue("ListJobExecutionInstances.TotalCount");
			listJobExecutionInstancesResponse.PageNumber = _ctx.IntegerValue("ListJobExecutionInstances.PageNumber");
			listJobExecutionInstancesResponse.PageSize = _ctx.IntegerValue("ListJobExecutionInstances.PageSize");

			List<ListJobExecutionInstancesResponse.ListJobExecutionInstances_JobInstance> listJobExecutionInstancesResponse_jobInstances = new List<ListJobExecutionInstancesResponse.ListJobExecutionInstances_JobInstance>();
			for (int i = 0; i < _ctx.Length("ListJobExecutionInstances.JobInstances.Length"); i++) {
				ListJobExecutionInstancesResponse.ListJobExecutionInstances_JobInstance jobInstance = new ListJobExecutionInstancesResponse.ListJobExecutionInstances_JobInstance();
				jobInstance.Id = _ctx.StringValue("ListJobExecutionInstances.JobInstances["+ i +"].Id");
				jobInstance.JobName = _ctx.StringValue("ListJobExecutionInstances.JobInstances["+ i +"].JobName");
				jobInstance.StartTime = _ctx.LongValue("ListJobExecutionInstances.JobInstances["+ i +"].StartTime");
				jobInstance.RunTime = _ctx.IntegerValue("ListJobExecutionInstances.JobInstances["+ i +"].RunTime");
				jobInstance.JobType = _ctx.StringValue("ListJobExecutionInstances.JobInstances["+ i +"].JobType");
				jobInstance.JobId = _ctx.StringValue("ListJobExecutionInstances.JobInstances["+ i +"].JobId");
				jobInstance.ClusterId = _ctx.StringValue("ListJobExecutionInstances.JobInstances["+ i +"].ClusterId");
				jobInstance.Status = _ctx.StringValue("ListJobExecutionInstances.JobInstances["+ i +"].Status");
				jobInstance.RetryInfo = _ctx.StringValue("ListJobExecutionInstances.JobInstances["+ i +"].RetryInfo");

				listJobExecutionInstancesResponse_jobInstances.Add(jobInstance);
			}
			listJobExecutionInstancesResponse.JobInstances = listJobExecutionInstancesResponse_jobInstances;
        
			return listJobExecutionInstancesResponse;
        }
    }
}
