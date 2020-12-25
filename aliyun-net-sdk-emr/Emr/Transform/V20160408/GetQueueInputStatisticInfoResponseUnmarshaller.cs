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
    public class GetQueueInputStatisticInfoResponseUnmarshaller
    {
        public static GetQueueInputStatisticInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetQueueInputStatisticInfoResponse getQueueInputStatisticInfoResponse = new GetQueueInputStatisticInfoResponse();

			getQueueInputStatisticInfoResponse.HttpResponse = _ctx.HttpResponse;
			getQueueInputStatisticInfoResponse.RequestId = _ctx.StringValue("GetQueueInputStatisticInfo.RequestId");

			List<GetQueueInputStatisticInfoResponse.GetQueueInputStatisticInfo_ClusterStatQueueInput> getQueueInputStatisticInfoResponse_queueInputList = new List<GetQueueInputStatisticInfoResponse.GetQueueInputStatisticInfo_ClusterStatQueueInput>();
			for (int i = 0; i < _ctx.Length("GetQueueInputStatisticInfo.QueueInputList.Length"); i++) {
				GetQueueInputStatisticInfoResponse.GetQueueInputStatisticInfo_ClusterStatQueueInput clusterStatQueueInput = new GetQueueInputStatisticInfoResponse.GetQueueInputStatisticInfo_ClusterStatQueueInput();
				clusterStatQueueInput.Queue = _ctx.StringValue("GetQueueInputStatisticInfo.QueueInputList["+ i +"].Queue");
				clusterStatQueueInput.BytesInput = _ctx.LongValue("GetQueueInputStatisticInfo.QueueInputList["+ i +"].BytesInput");

				getQueueInputStatisticInfoResponse_queueInputList.Add(clusterStatQueueInput);
			}
			getQueueInputStatisticInfoResponse.QueueInputList = getQueueInputStatisticInfoResponse_queueInputList;
        
			return getQueueInputStatisticInfoResponse;
        }
    }
}
