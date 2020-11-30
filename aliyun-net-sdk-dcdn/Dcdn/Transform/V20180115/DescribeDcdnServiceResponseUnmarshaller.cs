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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnServiceResponseUnmarshaller
    {
        public static DescribeDcdnServiceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnServiceResponse describeDcdnServiceResponse = new DescribeDcdnServiceResponse();

			describeDcdnServiceResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnServiceResponse.RequestId = _ctx.StringValue("DescribeDcdnService.RequestId");
			describeDcdnServiceResponse.InstanceId = _ctx.StringValue("DescribeDcdnService.InstanceId");
			describeDcdnServiceResponse.InternetChargeType = _ctx.StringValue("DescribeDcdnService.InternetChargeType");
			describeDcdnServiceResponse.OpeningTime = _ctx.StringValue("DescribeDcdnService.OpeningTime");
			describeDcdnServiceResponse.ChangingChargeType = _ctx.StringValue("DescribeDcdnService.ChangingChargeType");
			describeDcdnServiceResponse.ChangingAffectTime = _ctx.StringValue("DescribeDcdnService.ChangingAffectTime");
			describeDcdnServiceResponse.WebsocketChangingType = _ctx.StringValue("DescribeDcdnService.WebsocketChangingType");
			describeDcdnServiceResponse.WebsocketType = _ctx.StringValue("DescribeDcdnService.WebsocketType");
			describeDcdnServiceResponse.WebsocketChangingTime = _ctx.StringValue("DescribeDcdnService.WebsocketChangingTime");

			List<DescribeDcdnServiceResponse.DescribeDcdnService_LockReason> describeDcdnServiceResponse_operationLocks = new List<DescribeDcdnServiceResponse.DescribeDcdnService_LockReason>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnService.OperationLocks.Length"); i++) {
				DescribeDcdnServiceResponse.DescribeDcdnService_LockReason lockReason = new DescribeDcdnServiceResponse.DescribeDcdnService_LockReason();
				lockReason.LockReason = _ctx.StringValue("DescribeDcdnService.OperationLocks["+ i +"].LockReason");

				describeDcdnServiceResponse_operationLocks.Add(lockReason);
			}
			describeDcdnServiceResponse.OperationLocks = describeDcdnServiceResponse_operationLocks;
        
			return describeDcdnServiceResponse;
        }
    }
}
