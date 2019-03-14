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
    public class GetQueueSubmissionStatisticInfoResponseUnmarshaller
    {
        public static GetQueueSubmissionStatisticInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetQueueSubmissionStatisticInfoResponse getQueueSubmissionStatisticInfoResponse = new GetQueueSubmissionStatisticInfoResponse();

			getQueueSubmissionStatisticInfoResponse.HttpResponse = context.HttpResponse;
			getQueueSubmissionStatisticInfoResponse.RequestId = context.StringValue("GetQueueSubmissionStatisticInfo.RequestId");

			List<GetQueueSubmissionStatisticInfoResponse.GetQueueSubmissionStatisticInfo_ClusterStatQueueSubmission> getQueueSubmissionStatisticInfoResponse_queueSubmissionList = new List<GetQueueSubmissionStatisticInfoResponse.GetQueueSubmissionStatisticInfo_ClusterStatQueueSubmission>();
			for (int i = 0; i < context.Length("GetQueueSubmissionStatisticInfo.QueueSubmissionList.Length"); i++) {
				GetQueueSubmissionStatisticInfoResponse.GetQueueSubmissionStatisticInfo_ClusterStatQueueSubmission clusterStatQueueSubmission = new GetQueueSubmissionStatisticInfoResponse.GetQueueSubmissionStatisticInfo_ClusterStatQueueSubmission();
				clusterStatQueueSubmission.Queue = context.StringValue("GetQueueSubmissionStatisticInfo.QueueSubmissionList["+ i +"].Queue");
				clusterStatQueueSubmission.Submission = context.LongValue("GetQueueSubmissionStatisticInfo.QueueSubmissionList["+ i +"].Submission");

				getQueueSubmissionStatisticInfoResponse_queueSubmissionList.Add(clusterStatQueueSubmission);
			}
			getQueueSubmissionStatisticInfoResponse.QueueSubmissionList = getQueueSubmissionStatisticInfoResponse_queueSubmissionList;
        
			return getQueueSubmissionStatisticInfoResponse;
        }
    }
}
