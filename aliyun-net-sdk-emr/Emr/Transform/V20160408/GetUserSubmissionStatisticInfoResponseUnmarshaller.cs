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
    public class GetUserSubmissionStatisticInfoResponseUnmarshaller
    {
        public static GetUserSubmissionStatisticInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUserSubmissionStatisticInfoResponse getUserSubmissionStatisticInfoResponse = new GetUserSubmissionStatisticInfoResponse();

			getUserSubmissionStatisticInfoResponse.HttpResponse = _ctx.HttpResponse;
			getUserSubmissionStatisticInfoResponse.RequestId = _ctx.StringValue("GetUserSubmissionStatisticInfo.RequestId");

			List<GetUserSubmissionStatisticInfoResponse.GetUserSubmissionStatisticInfo_ClusterStatUserSubmission> getUserSubmissionStatisticInfoResponse_userSubmissionList = new List<GetUserSubmissionStatisticInfoResponse.GetUserSubmissionStatisticInfo_ClusterStatUserSubmission>();
			for (int i = 0; i < _ctx.Length("GetUserSubmissionStatisticInfo.UserSubmissionList.Length"); i++) {
				GetUserSubmissionStatisticInfoResponse.GetUserSubmissionStatisticInfo_ClusterStatUserSubmission clusterStatUserSubmission = new GetUserSubmissionStatisticInfoResponse.GetUserSubmissionStatisticInfo_ClusterStatUserSubmission();
				clusterStatUserSubmission.User = _ctx.StringValue("GetUserSubmissionStatisticInfo.UserSubmissionList["+ i +"].User");
				clusterStatUserSubmission.Submission = _ctx.LongValue("GetUserSubmissionStatisticInfo.UserSubmissionList["+ i +"].Submission");

				getUserSubmissionStatisticInfoResponse_userSubmissionList.Add(clusterStatUserSubmission);
			}
			getUserSubmissionStatisticInfoResponse.UserSubmissionList = getUserSubmissionStatisticInfoResponse_userSubmissionList;
        
			return getUserSubmissionStatisticInfoResponse;
        }
    }
}
