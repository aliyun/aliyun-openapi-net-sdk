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
    public class GetJobRunningTimeStatisticInfoResponseUnmarshaller
    {
        public static GetJobRunningTimeStatisticInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetJobRunningTimeStatisticInfoResponse getJobRunningTimeStatisticInfoResponse = new GetJobRunningTimeStatisticInfoResponse();

			getJobRunningTimeStatisticInfoResponse.HttpResponse = _ctx.HttpResponse;
			getJobRunningTimeStatisticInfoResponse.RequestId = _ctx.StringValue("GetJobRunningTimeStatisticInfo.RequestId");
			getJobRunningTimeStatisticInfoResponse.Total = _ctx.IntegerValue("GetJobRunningTimeStatisticInfo.Total");
			getJobRunningTimeStatisticInfoResponse.PageNumber = _ctx.IntegerValue("GetJobRunningTimeStatisticInfo.PageNumber");
			getJobRunningTimeStatisticInfoResponse.PageSize = _ctx.IntegerValue("GetJobRunningTimeStatisticInfo.PageSize");

			List<GetJobRunningTimeStatisticInfoResponse.GetJobRunningTimeStatisticInfo_ClusterStatJobRunningTime> getJobRunningTimeStatisticInfoResponse_runningTimeList = new List<GetJobRunningTimeStatisticInfoResponse.GetJobRunningTimeStatisticInfo_ClusterStatJobRunningTime>();
			for (int i = 0; i < _ctx.Length("GetJobRunningTimeStatisticInfo.RunningTimeList.Length"); i++) {
				GetJobRunningTimeStatisticInfoResponse.GetJobRunningTimeStatisticInfo_ClusterStatJobRunningTime clusterStatJobRunningTime = new GetJobRunningTimeStatisticInfoResponse.GetJobRunningTimeStatisticInfo_ClusterStatJobRunningTime();
				clusterStatJobRunningTime.ApplicationId = _ctx.StringValue("GetJobRunningTimeStatisticInfo.RunningTimeList["+ i +"].ApplicationId");
				clusterStatJobRunningTime.JobId = _ctx.StringValue("GetJobRunningTimeStatisticInfo.RunningTimeList["+ i +"].JobId");
				clusterStatJobRunningTime.StartTime = _ctx.LongValue("GetJobRunningTimeStatisticInfo.RunningTimeList["+ i +"].StartTime");
				clusterStatJobRunningTime.FinishTime = _ctx.LongValue("GetJobRunningTimeStatisticInfo.RunningTimeList["+ i +"].FinishTime");
				clusterStatJobRunningTime.Name = _ctx.StringValue("GetJobRunningTimeStatisticInfo.RunningTimeList["+ i +"].Name");
				clusterStatJobRunningTime.Queue = _ctx.StringValue("GetJobRunningTimeStatisticInfo.RunningTimeList["+ i +"].Queue");
				clusterStatJobRunningTime.User = _ctx.StringValue("GetJobRunningTimeStatisticInfo.RunningTimeList["+ i +"].User");
				clusterStatJobRunningTime.State = _ctx.StringValue("GetJobRunningTimeStatisticInfo.RunningTimeList["+ i +"].State");
				clusterStatJobRunningTime.RunningTime = _ctx.LongValue("GetJobRunningTimeStatisticInfo.RunningTimeList["+ i +"].RunningTime");

				getJobRunningTimeStatisticInfoResponse_runningTimeList.Add(clusterStatJobRunningTime);
			}
			getJobRunningTimeStatisticInfoResponse.RunningTimeList = getJobRunningTimeStatisticInfoResponse_runningTimeList;
        
			return getJobRunningTimeStatisticInfoResponse;
        }
    }
}
