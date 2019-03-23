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
using Aliyun.Acs.Cdn.Model.V20141111;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeCdnServiceResponseUnmarshaller
    {
        public static DescribeCdnServiceResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeCdnServiceResponse describeCdnServiceResponse = new DescribeCdnServiceResponse();

            describeCdnServiceResponse.HttpResponse = context.HttpResponse;
            describeCdnServiceResponse.RequestId = context.StringValue("DescribeCdnService.RequestId");
            describeCdnServiceResponse.InstanceId = context.StringValue("DescribeCdnService.InstanceId");
            describeCdnServiceResponse.InternetChargeType = context.StringValue("DescribeCdnService.InternetChargeType");
            describeCdnServiceResponse.OpeningTime = context.StringValue("DescribeCdnService.OpeningTime");
            describeCdnServiceResponse.ChangingChargeType = context.StringValue("DescribeCdnService.ChangingChargeType");
            describeCdnServiceResponse.ChangingAffectTime = context.StringValue("DescribeCdnService.ChangingAffectTime");

            List<DescribeCdnServiceResponse.DescribeCdnService_LockReason> describeCdnServiceResponse_operationLocks = new List<DescribeCdnServiceResponse.DescribeCdnService_LockReason>();
            for (int i = 0; i < context.Length("DescribeCdnService.OperationLocks.Length"); i++)
            {
                DescribeCdnServiceResponse.DescribeCdnService_LockReason lockReason = new DescribeCdnServiceResponse.DescribeCdnService_LockReason();
                lockReason.LockReason = context.StringValue("DescribeCdnService.OperationLocks[" + i + "].LockReason");

                describeCdnServiceResponse_operationLocks.Add(lockReason);
            }
            describeCdnServiceResponse.OperationLocks = describeCdnServiceResponse_operationLocks;

            return describeCdnServiceResponse;
        }
    }
}
