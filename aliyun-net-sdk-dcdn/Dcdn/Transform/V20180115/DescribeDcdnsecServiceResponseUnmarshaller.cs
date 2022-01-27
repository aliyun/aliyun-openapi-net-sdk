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
    public class DescribeDcdnsecServiceResponseUnmarshaller
    {
        public static DescribeDcdnsecServiceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnsecServiceResponse describeDcdnsecServiceResponse = new DescribeDcdnsecServiceResponse();

			describeDcdnsecServiceResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnsecServiceResponse.RequestId = _ctx.StringValue("DescribeDcdnsecService.RequestId");
			describeDcdnsecServiceResponse.InstanceId = _ctx.StringValue("DescribeDcdnsecService.InstanceId");
			describeDcdnsecServiceResponse.InternetChargeType = _ctx.StringValue("DescribeDcdnsecService.InternetChargeType");
			describeDcdnsecServiceResponse.StartTime = _ctx.StringValue("DescribeDcdnsecService.StartTime");
			describeDcdnsecServiceResponse.EndTime = _ctx.StringValue("DescribeDcdnsecService.EndTime");
			describeDcdnsecServiceResponse.ChangingChargeType = _ctx.StringValue("DescribeDcdnsecService.ChangingChargeType");
			describeDcdnsecServiceResponse.ChangingAffectTime = _ctx.StringValue("DescribeDcdnsecService.ChangingAffectTime");
			describeDcdnsecServiceResponse.Version = _ctx.StringValue("DescribeDcdnsecService.Version");
			describeDcdnsecServiceResponse.FlowType = _ctx.StringValue("DescribeDcdnsecService.FlowType");
			describeDcdnsecServiceResponse.RequestType = _ctx.StringValue("DescribeDcdnsecService.RequestType");
			describeDcdnsecServiceResponse.DomainNum = _ctx.StringValue("DescribeDcdnsecService.DomainNum");

			List<DescribeDcdnsecServiceResponse.DescribeDcdnsecService_LockReason> describeDcdnsecServiceResponse_operationLocks = new List<DescribeDcdnsecServiceResponse.DescribeDcdnsecService_LockReason>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnsecService.OperationLocks.Length"); i++) {
				DescribeDcdnsecServiceResponse.DescribeDcdnsecService_LockReason lockReason = new DescribeDcdnsecServiceResponse.DescribeDcdnsecService_LockReason();
				lockReason.LockReason = _ctx.StringValue("DescribeDcdnsecService.OperationLocks["+ i +"].LockReason");

				describeDcdnsecServiceResponse_operationLocks.Add(lockReason);
			}
			describeDcdnsecServiceResponse.OperationLocks = describeDcdnsecServiceResponse_operationLocks;
        
			return describeDcdnsecServiceResponse;
        }
    }
}
