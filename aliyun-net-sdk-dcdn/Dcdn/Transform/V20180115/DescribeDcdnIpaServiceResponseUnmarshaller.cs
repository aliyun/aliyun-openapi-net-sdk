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
    public class DescribeDcdnIpaServiceResponseUnmarshaller
    {
        public static DescribeDcdnIpaServiceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnIpaServiceResponse describeDcdnIpaServiceResponse = new DescribeDcdnIpaServiceResponse();

			describeDcdnIpaServiceResponse.HttpResponse = context.HttpResponse;
			describeDcdnIpaServiceResponse.RequestId = context.StringValue("DescribeDcdnIpaService.RequestId");
			describeDcdnIpaServiceResponse.InstanceId = context.StringValue("DescribeDcdnIpaService.InstanceId");
			describeDcdnIpaServiceResponse.InternetChargeType = context.StringValue("DescribeDcdnIpaService.InternetChargeType");
			describeDcdnIpaServiceResponse.OpeningTime = context.StringValue("DescribeDcdnIpaService.OpeningTime");
			describeDcdnIpaServiceResponse.ChangingChargeType = context.StringValue("DescribeDcdnIpaService.ChangingChargeType");
			describeDcdnIpaServiceResponse.ChangingAffectTime = context.StringValue("DescribeDcdnIpaService.ChangingAffectTime");

			List<DescribeDcdnIpaServiceResponse.DescribeDcdnIpaService_LockReason> describeDcdnIpaServiceResponse_operationLocks = new List<DescribeDcdnIpaServiceResponse.DescribeDcdnIpaService_LockReason>();
			for (int i = 0; i < context.Length("DescribeDcdnIpaService.OperationLocks.Length"); i++) {
				DescribeDcdnIpaServiceResponse.DescribeDcdnIpaService_LockReason lockReason = new DescribeDcdnIpaServiceResponse.DescribeDcdnIpaService_LockReason();
				lockReason.LockReason = context.StringValue("DescribeDcdnIpaService.OperationLocks["+ i +"].LockReason");

				describeDcdnIpaServiceResponse_operationLocks.Add(lockReason);
			}
			describeDcdnIpaServiceResponse.OperationLocks = describeDcdnIpaServiceResponse_operationLocks;
        
			return describeDcdnIpaServiceResponse;
        }
    }
}
