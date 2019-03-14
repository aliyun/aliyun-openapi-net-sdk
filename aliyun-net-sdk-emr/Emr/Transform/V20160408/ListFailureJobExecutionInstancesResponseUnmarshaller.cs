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
    public class ListFailureJobExecutionInstancesResponseUnmarshaller
    {
        public static ListFailureJobExecutionInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			ListFailureJobExecutionInstancesResponse listFailureJobExecutionInstancesResponse = new ListFailureJobExecutionInstancesResponse();

			listFailureJobExecutionInstancesResponse.HttpResponse = context.HttpResponse;
			listFailureJobExecutionInstancesResponse.RequestId = context.StringValue("ListFailureJobExecutionInstances.RequestId");

			List<ListFailureJobExecutionInstancesResponse.ListFailureJobExecutionInstances_JobInstance> listFailureJobExecutionInstancesResponse_jobInstances = new List<ListFailureJobExecutionInstancesResponse.ListFailureJobExecutionInstances_JobInstance>();
			for (int i = 0; i < context.Length("ListFailureJobExecutionInstances.JobInstances.Length"); i++) {
				ListFailureJobExecutionInstancesResponse.ListFailureJobExecutionInstances_JobInstance jobInstance = new ListFailureJobExecutionInstancesResponse.ListFailureJobExecutionInstances_JobInstance();
				jobInstance.Id = context.StringValue("ListFailureJobExecutionInstances.JobInstances["+ i +"].Id");
				jobInstance.JobName = context.StringValue("ListFailureJobExecutionInstances.JobInstances["+ i +"].JobName");
				jobInstance.StartTime = context.LongValue("ListFailureJobExecutionInstances.JobInstances["+ i +"].StartTime");
				jobInstance.RunTime = context.IntegerValue("ListFailureJobExecutionInstances.JobInstances["+ i +"].RunTime");
				jobInstance.JobType = context.StringValue("ListFailureJobExecutionInstances.JobInstances["+ i +"].JobType");
				jobInstance.JobId = context.StringValue("ListFailureJobExecutionInstances.JobInstances["+ i +"].JobId");
				jobInstance.ClusterId = context.StringValue("ListFailureJobExecutionInstances.JobInstances["+ i +"].ClusterId");
				jobInstance.Status = context.StringValue("ListFailureJobExecutionInstances.JobInstances["+ i +"].Status");
				jobInstance.RetryInfo = context.StringValue("ListFailureJobExecutionInstances.JobInstances["+ i +"].RetryInfo");

				listFailureJobExecutionInstancesResponse_jobInstances.Add(jobInstance);
			}
			listFailureJobExecutionInstancesResponse.JobInstances = listFailureJobExecutionInstancesResponse_jobInstances;
        
			return listFailureJobExecutionInstancesResponse;
        }
    }
}
