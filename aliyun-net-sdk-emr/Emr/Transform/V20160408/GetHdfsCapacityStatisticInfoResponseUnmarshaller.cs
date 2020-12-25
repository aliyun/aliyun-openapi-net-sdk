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
    public class GetHdfsCapacityStatisticInfoResponseUnmarshaller
    {
        public static GetHdfsCapacityStatisticInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetHdfsCapacityStatisticInfoResponse getHdfsCapacityStatisticInfoResponse = new GetHdfsCapacityStatisticInfoResponse();

			getHdfsCapacityStatisticInfoResponse.HttpResponse = _ctx.HttpResponse;
			getHdfsCapacityStatisticInfoResponse.RequestId = _ctx.StringValue("GetHdfsCapacityStatisticInfo.RequestId");

			List<GetHdfsCapacityStatisticInfoResponse.GetHdfsCapacityStatisticInfo_ClusterStatHdfsCapacity> getHdfsCapacityStatisticInfoResponse_hdfsCapacityList = new List<GetHdfsCapacityStatisticInfoResponse.GetHdfsCapacityStatisticInfo_ClusterStatHdfsCapacity>();
			for (int i = 0; i < _ctx.Length("GetHdfsCapacityStatisticInfo.HdfsCapacityList.Length"); i++) {
				GetHdfsCapacityStatisticInfoResponse.GetHdfsCapacityStatisticInfo_ClusterStatHdfsCapacity clusterStatHdfsCapacity = new GetHdfsCapacityStatisticInfoResponse.GetHdfsCapacityStatisticInfo_ClusterStatHdfsCapacity();
				clusterStatHdfsCapacity.CapacityTotal = _ctx.LongValue("GetHdfsCapacityStatisticInfo.HdfsCapacityList["+ i +"].CapacityTotal");
				clusterStatHdfsCapacity.CapacityTotalGB = _ctx.LongValue("GetHdfsCapacityStatisticInfo.HdfsCapacityList["+ i +"].CapacityTotalGB");
				clusterStatHdfsCapacity.CapacityUsed = _ctx.LongValue("GetHdfsCapacityStatisticInfo.HdfsCapacityList["+ i +"].CapacityUsed");
				clusterStatHdfsCapacity.CapacityUsedGB = _ctx.LongValue("GetHdfsCapacityStatisticInfo.HdfsCapacityList["+ i +"].CapacityUsedGB");
				clusterStatHdfsCapacity.CapacityRemaining = _ctx.LongValue("GetHdfsCapacityStatisticInfo.HdfsCapacityList["+ i +"].CapacityRemaining");
				clusterStatHdfsCapacity.CapacityRemainingGB = _ctx.LongValue("GetHdfsCapacityStatisticInfo.HdfsCapacityList["+ i +"].CapacityRemainingGB");
				clusterStatHdfsCapacity.CapacityUsedNonDfs = _ctx.LongValue("GetHdfsCapacityStatisticInfo.HdfsCapacityList["+ i +"].CapacityUsedNonDfs");
				clusterStatHdfsCapacity.ClusterBizId = _ctx.StringValue("GetHdfsCapacityStatisticInfo.HdfsCapacityList["+ i +"].ClusterBizId");
				clusterStatHdfsCapacity.DateTime = _ctx.StringValue("GetHdfsCapacityStatisticInfo.HdfsCapacityList["+ i +"].DateTime");

				getHdfsCapacityStatisticInfoResponse_hdfsCapacityList.Add(clusterStatHdfsCapacity);
			}
			getHdfsCapacityStatisticInfoResponse.HdfsCapacityList = getHdfsCapacityStatisticInfoResponse_hdfsCapacityList;
        
			return getHdfsCapacityStatisticInfoResponse;
        }
    }
}
