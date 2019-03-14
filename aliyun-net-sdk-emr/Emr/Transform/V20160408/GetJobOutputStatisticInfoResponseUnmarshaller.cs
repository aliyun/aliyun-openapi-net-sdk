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
    public class GetJobOutputStatisticInfoResponseUnmarshaller
    {
        public static GetJobOutputStatisticInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetJobOutputStatisticInfoResponse getJobOutputStatisticInfoResponse = new GetJobOutputStatisticInfoResponse();

			getJobOutputStatisticInfoResponse.HttpResponse = context.HttpResponse;
			getJobOutputStatisticInfoResponse.RequestId = context.StringValue("GetJobOutputStatisticInfo.RequestId");
			getJobOutputStatisticInfoResponse.Total = context.IntegerValue("GetJobOutputStatisticInfo.Total");
			getJobOutputStatisticInfoResponse.PageNumber = context.IntegerValue("GetJobOutputStatisticInfo.PageNumber");
			getJobOutputStatisticInfoResponse.PageSize = context.IntegerValue("GetJobOutputStatisticInfo.PageSize");

			List<GetJobOutputStatisticInfoResponse.GetJobOutputStatisticInfo_ClusterStatJobOutput> getJobOutputStatisticInfoResponse_jobOutputList = new List<GetJobOutputStatisticInfoResponse.GetJobOutputStatisticInfo_ClusterStatJobOutput>();
			for (int i = 0; i < context.Length("GetJobOutputStatisticInfo.JobOutputList.Length"); i++) {
				GetJobOutputStatisticInfoResponse.GetJobOutputStatisticInfo_ClusterStatJobOutput clusterStatJobOutput = new GetJobOutputStatisticInfoResponse.GetJobOutputStatisticInfo_ClusterStatJobOutput();
				clusterStatJobOutput.ApplicationId = context.StringValue("GetJobOutputStatisticInfo.JobOutputList["+ i +"].ApplicationId");
				clusterStatJobOutput.JobId = context.StringValue("GetJobOutputStatisticInfo.JobOutputList["+ i +"].JobId");
				clusterStatJobOutput.StartTime = context.LongValue("GetJobOutputStatisticInfo.JobOutputList["+ i +"].StartTime");
				clusterStatJobOutput.FinishTime = context.LongValue("GetJobOutputStatisticInfo.JobOutputList["+ i +"].FinishTime");
				clusterStatJobOutput.Name = context.StringValue("GetJobOutputStatisticInfo.JobOutputList["+ i +"].Name");
				clusterStatJobOutput.Queue = context.StringValue("GetJobOutputStatisticInfo.JobOutputList["+ i +"].Queue");
				clusterStatJobOutput.User = context.StringValue("GetJobOutputStatisticInfo.JobOutputList["+ i +"].User");
				clusterStatJobOutput.State = context.StringValue("GetJobOutputStatisticInfo.JobOutputList["+ i +"].State");
				clusterStatJobOutput.BytesOutput = context.LongValue("GetJobOutputStatisticInfo.JobOutputList["+ i +"].BytesOutput");

				getJobOutputStatisticInfoResponse_jobOutputList.Add(clusterStatJobOutput);
			}
			getJobOutputStatisticInfoResponse.JobOutputList = getJobOutputStatisticInfoResponse_jobOutputList;
        
			return getJobOutputStatisticInfoResponse;
        }
    }
}
