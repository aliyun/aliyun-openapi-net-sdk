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
    public class GetUserInputStatisticInfoResponseUnmarshaller
    {
        public static GetUserInputStatisticInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUserInputStatisticInfoResponse getUserInputStatisticInfoResponse = new GetUserInputStatisticInfoResponse();

			getUserInputStatisticInfoResponse.HttpResponse = _ctx.HttpResponse;
			getUserInputStatisticInfoResponse.RequestId = _ctx.StringValue("GetUserInputStatisticInfo.RequestId");

			List<GetUserInputStatisticInfoResponse.GetUserInputStatisticInfo_ClusterStatUserInput> getUserInputStatisticInfoResponse_userInputList = new List<GetUserInputStatisticInfoResponse.GetUserInputStatisticInfo_ClusterStatUserInput>();
			for (int i = 0; i < _ctx.Length("GetUserInputStatisticInfo.UserInputList.Length"); i++) {
				GetUserInputStatisticInfoResponse.GetUserInputStatisticInfo_ClusterStatUserInput clusterStatUserInput = new GetUserInputStatisticInfoResponse.GetUserInputStatisticInfo_ClusterStatUserInput();
				clusterStatUserInput.User = _ctx.StringValue("GetUserInputStatisticInfo.UserInputList["+ i +"].User");
				clusterStatUserInput.BytesInput = _ctx.LongValue("GetUserInputStatisticInfo.UserInputList["+ i +"].BytesInput");

				getUserInputStatisticInfoResponse_userInputList.Add(clusterStatUserInput);
			}
			getUserInputStatisticInfoResponse.UserInputList = getUserInputStatisticInfoResponse_userInputList;
        
			return getUserInputStatisticInfoResponse;
        }
    }
}
