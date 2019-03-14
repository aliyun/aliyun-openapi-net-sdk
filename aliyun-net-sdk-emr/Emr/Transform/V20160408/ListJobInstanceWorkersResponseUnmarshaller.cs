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
    public class ListJobInstanceWorkersResponseUnmarshaller
    {
        public static ListJobInstanceWorkersResponse Unmarshall(UnmarshallerContext context)
        {
			ListJobInstanceWorkersResponse listJobInstanceWorkersResponse = new ListJobInstanceWorkersResponse();

			listJobInstanceWorkersResponse.HttpResponse = context.HttpResponse;
			listJobInstanceWorkersResponse.RequestId = context.StringValue("ListJobInstanceWorkers.RequestId");

			List<ListJobInstanceWorkersResponse.ListJobInstanceWorkers_JobInstanceWorkerInfo> listJobInstanceWorkersResponse_jobInstanceWorkers = new List<ListJobInstanceWorkersResponse.ListJobInstanceWorkers_JobInstanceWorkerInfo>();
			for (int i = 0; i < context.Length("ListJobInstanceWorkers.JobInstanceWorkers.Length"); i++) {
				ListJobInstanceWorkersResponse.ListJobInstanceWorkers_JobInstanceWorkerInfo jobInstanceWorkerInfo = new ListJobInstanceWorkersResponse.ListJobInstanceWorkers_JobInstanceWorkerInfo();
				jobInstanceWorkerInfo.ApplicationId = context.StringValue("ListJobInstanceWorkers.JobInstanceWorkers["+ i +"].ApplicationId");
				jobInstanceWorkerInfo.InstanceInfo = context.StringValue("ListJobInstanceWorkers.JobInstanceWorkers["+ i +"].InstanceInfo");
				jobInstanceWorkerInfo.ContainerInfo = context.StringValue("ListJobInstanceWorkers.JobInstanceWorkers["+ i +"].ContainerInfo");

				listJobInstanceWorkersResponse_jobInstanceWorkers.Add(jobInstanceWorkerInfo);
			}
			listJobInstanceWorkersResponse.JobInstanceWorkers = listJobInstanceWorkersResponse_jobInstanceWorkers;
        
			return listJobInstanceWorkersResponse;
        }
    }
}
