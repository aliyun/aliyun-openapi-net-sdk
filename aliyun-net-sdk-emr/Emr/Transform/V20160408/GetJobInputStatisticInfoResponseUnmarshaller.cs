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
    public class GetJobInputStatisticInfoResponseUnmarshaller
    {
        public static GetJobInputStatisticInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetJobInputStatisticInfoResponse getJobInputStatisticInfoResponse = new GetJobInputStatisticInfoResponse();

			getJobInputStatisticInfoResponse.HttpResponse = _ctx.HttpResponse;
			getJobInputStatisticInfoResponse.RequestId = _ctx.StringValue("GetJobInputStatisticInfo.RequestId");
			getJobInputStatisticInfoResponse.Total = _ctx.IntegerValue("GetJobInputStatisticInfo.Total");
			getJobInputStatisticInfoResponse.PageNumber = _ctx.IntegerValue("GetJobInputStatisticInfo.PageNumber");
			getJobInputStatisticInfoResponse.PageSize = _ctx.IntegerValue("GetJobInputStatisticInfo.PageSize");

			List<GetJobInputStatisticInfoResponse.GetJobInputStatisticInfo_ClusterStatJobInput> getJobInputStatisticInfoResponse_jobInputList = new List<GetJobInputStatisticInfoResponse.GetJobInputStatisticInfo_ClusterStatJobInput>();
			for (int i = 0; i < _ctx.Length("GetJobInputStatisticInfo.JobInputList.Length"); i++) {
				GetJobInputStatisticInfoResponse.GetJobInputStatisticInfo_ClusterStatJobInput clusterStatJobInput = new GetJobInputStatisticInfoResponse.GetJobInputStatisticInfo_ClusterStatJobInput();
				clusterStatJobInput.ApplicationId = _ctx.StringValue("GetJobInputStatisticInfo.JobInputList["+ i +"].ApplicationId");
				clusterStatJobInput.JobId = _ctx.StringValue("GetJobInputStatisticInfo.JobInputList["+ i +"].JobId");
				clusterStatJobInput.StartTime = _ctx.LongValue("GetJobInputStatisticInfo.JobInputList["+ i +"].StartTime");
				clusterStatJobInput.FinishTime = _ctx.LongValue("GetJobInputStatisticInfo.JobInputList["+ i +"].FinishTime");
				clusterStatJobInput.Name = _ctx.StringValue("GetJobInputStatisticInfo.JobInputList["+ i +"].Name");
				clusterStatJobInput.Queue = _ctx.StringValue("GetJobInputStatisticInfo.JobInputList["+ i +"].Queue");
				clusterStatJobInput.User = _ctx.StringValue("GetJobInputStatisticInfo.JobInputList["+ i +"].User");
				clusterStatJobInput.State = _ctx.StringValue("GetJobInputStatisticInfo.JobInputList["+ i +"].State");
				clusterStatJobInput.BytesInput = _ctx.LongValue("GetJobInputStatisticInfo.JobInputList["+ i +"].BytesInput");

				getJobInputStatisticInfoResponse_jobInputList.Add(clusterStatJobInput);
			}
			getJobInputStatisticInfoResponse.JobInputList = getJobInputStatisticInfoResponse_jobInputList;
        
			return getJobInputStatisticInfoResponse;
        }
    }
}
