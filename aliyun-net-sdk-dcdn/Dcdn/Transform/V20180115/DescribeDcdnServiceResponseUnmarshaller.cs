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
        public static DescribeDcdnServiceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnServiceResponse describeDcdnServiceResponse = new DescribeDcdnServiceResponse();

			describeDcdnServiceResponse.HttpResponse = context.HttpResponse;
			describeDcdnServiceResponse.RequestId = context.StringValue("DescribeDcdnService.RequestId");
			describeDcdnServiceResponse.InstanceId = context.StringValue("DescribeDcdnService.InstanceId");
			describeDcdnServiceResponse.InternetChargeType = context.StringValue("DescribeDcdnService.InternetChargeType");
			describeDcdnServiceResponse.OpeningTime = context.StringValue("DescribeDcdnService.OpeningTime");
			describeDcdnServiceResponse.ChangingChargeType = context.StringValue("DescribeDcdnService.ChangingChargeType");
			describeDcdnServiceResponse.ChangingAffectTime = context.StringValue("DescribeDcdnService.ChangingAffectTime");
			describeDcdnServiceResponse.WebsocketChangingType = context.StringValue("DescribeDcdnService.WebsocketChangingType");
			describeDcdnServiceResponse.WebsocketType = context.StringValue("DescribeDcdnService.WebsocketType");
			describeDcdnServiceResponse.WebsocketChangingTime = context.StringValue("DescribeDcdnService.WebsocketChangingTime");

			List<DescribeDcdnServiceResponse.DescribeDcdnService_LockReason> describeDcdnServiceResponse_operationLocks = new List<DescribeDcdnServiceResponse.DescribeDcdnService_LockReason>();
			for (int i = 0; i < context.Length("DescribeDcdnService.OperationLocks.Length"); i++) {
				DescribeDcdnServiceResponse.DescribeDcdnService_LockReason lockReason = new DescribeDcdnServiceResponse.DescribeDcdnService_LockReason();
				lockReason.LockReason = context.StringValue("DescribeDcdnService.OperationLocks["+ i +"].LockReason");

				describeDcdnServiceResponse_operationLocks.Add(lockReason);
			}
			describeDcdnServiceResponse.OperationLocks = describeDcdnServiceResponse_operationLocks;
        
			return describeDcdnServiceResponse;
        }
    }
}
