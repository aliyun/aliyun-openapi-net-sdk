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
        public static GetJobOutputStatisticInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetJobOutputStatisticInfoResponse getJobOutputStatisticInfoResponse = new GetJobOutputStatisticInfoResponse();

			getJobOutputStatisticInfoResponse.HttpResponse = _ctx.HttpResponse;
			getJobOutputStatisticInfoResponse.RequestId = _ctx.StringValue("GetJobOutputStatisticInfo.RequestId");
			getJobOutputStatisticInfoResponse.Total = _ctx.IntegerValue("GetJobOutputStatisticInfo.Total");
			getJobOutputStatisticInfoResponse.PageNumber = _ctx.IntegerValue("GetJobOutputStatisticInfo.PageNumber");
			getJobOutputStatisticInfoResponse.PageSize = _ctx.IntegerValue("GetJobOutputStatisticInfo.PageSize");

			List<GetJobOutputStatisticInfoResponse.GetJobOutputStatisticInfo_ClusterStatJobOutput> getJobOutputStatisticInfoResponse_jobOutputList = new List<GetJobOutputStatisticInfoResponse.GetJobOutputStatisticInfo_ClusterStatJobOutput>();
			for (int i = 0; i < _ctx.Length("GetJobOutputStatisticInfo.JobOutputList.Length"); i++) {
				GetJobOutputStatisticInfoResponse.GetJobOutputStatisticInfo_ClusterStatJobOutput clusterStatJobOutput = new GetJobOutputStatisticInfoResponse.GetJobOutputStatisticInfo_ClusterStatJobOutput();
				clusterStatJobOutput.ApplicationId = _ctx.StringValue("GetJobOutputStatisticInfo.JobOutputList["+ i +"].ApplicationId");
				clusterStatJobOutput.JobId = _ctx.StringValue("GetJobOutputStatisticInfo.JobOutputList["+ i +"].JobId");
				clusterStatJobOutput.StartTime = _ctx.LongValue("GetJobOutputStatisticInfo.JobOutputList["+ i +"].StartTime");
				clusterStatJobOutput.FinishTime = _ctx.LongValue("GetJobOutputStatisticInfo.JobOutputList["+ i +"].FinishTime");
				clusterStatJobOutput.Name = _ctx.StringValue("GetJobOutputStatisticInfo.JobOutputList["+ i +"].Name");
				clusterStatJobOutput.Queue = _ctx.StringValue("GetJobOutputStatisticInfo.JobOutputList["+ i +"].Queue");
				clusterStatJobOutput.User = _ctx.StringValue("GetJobOutputStatisticInfo.JobOutputList["+ i +"].User");
				clusterStatJobOutput.State = _ctx.StringValue("GetJobOutputStatisticInfo.JobOutputList["+ i +"].State");
				clusterStatJobOutput.BytesOutput = _ctx.LongValue("GetJobOutputStatisticInfo.JobOutputList["+ i +"].BytesOutput");

				getJobOutputStatisticInfoResponse_jobOutputList.Add(clusterStatJobOutput);
			}
			getJobOutputStatisticInfoResponse.JobOutputList = getJobOutputStatisticInfoResponse_jobOutputList;
        
			return getJobOutputStatisticInfoResponse;
        }
    }
}
