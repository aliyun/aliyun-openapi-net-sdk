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
using Aliyun.Acs.scdn.Model.V20171115;

namespace Aliyun.Acs.scdn.Transform.V20171115
{
    public class DescribeScdnServiceResponseUnmarshaller
    {
        public static DescribeScdnServiceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnServiceResponse describeScdnServiceResponse = new DescribeScdnServiceResponse();

			describeScdnServiceResponse.HttpResponse = context.HttpResponse;
			describeScdnServiceResponse.RequestId = context.StringValue("DescribeScdnService.RequestId");
			describeScdnServiceResponse.ChangingAffectTime = context.StringValue("DescribeScdnService.ChangingAffectTime");
			describeScdnServiceResponse.InternetChargeType = context.StringValue("DescribeScdnService.InternetChargeType");
			describeScdnServiceResponse.ChangingChargeType = context.StringValue("DescribeScdnService.ChangingChargeType");
			describeScdnServiceResponse.InstanceId = context.StringValue("DescribeScdnService.InstanceId");
			describeScdnServiceResponse.OpenTime = context.StringValue("DescribeScdnService.OpenTime");
			describeScdnServiceResponse.EndTime = context.StringValue("DescribeScdnService.EndTime");
			describeScdnServiceResponse.ProtectType = context.StringValue("DescribeScdnService.ProtectType");
			describeScdnServiceResponse.ProtectTypeValue = context.StringValue("DescribeScdnService.ProtectTypeValue");
			describeScdnServiceResponse.Bandwidth = context.StringValue("DescribeScdnService.Bandwidth");
			describeScdnServiceResponse.CcProtection = context.StringValue("DescribeScdnService.CcProtection");
			describeScdnServiceResponse.DDoSBasic = context.StringValue("DescribeScdnService.DDoSBasic");
			describeScdnServiceResponse.DomainCount = context.StringValue("DescribeScdnService.DomainCount");
			describeScdnServiceResponse.ElasticProtection = context.StringValue("DescribeScdnService.ElasticProtection");
			describeScdnServiceResponse.BandwidthValue = context.StringValue("DescribeScdnService.BandwidthValue");
			describeScdnServiceResponse.CcProtectionValue = context.StringValue("DescribeScdnService.CcProtectionValue");
			describeScdnServiceResponse.DDoSBasicValue = context.StringValue("DescribeScdnService.DDoSBasicValue");
			describeScdnServiceResponse.DomainCountValue = context.StringValue("DescribeScdnService.DomainCountValue");
			describeScdnServiceResponse.ElasticProtectionValue = context.StringValue("DescribeScdnService.ElasticProtectionValue");
			describeScdnServiceResponse.CurrentProtectType = context.StringValue("DescribeScdnService.CurrentProtectType");
			describeScdnServiceResponse.CurrentProtectTypeValue = context.StringValue("DescribeScdnService.CurrentProtectTypeValue");
			describeScdnServiceResponse.CurrentBandwidth = context.StringValue("DescribeScdnService.CurrentBandwidth");
			describeScdnServiceResponse.CurrentCcProtection = context.StringValue("DescribeScdnService.CurrentCcProtection");
			describeScdnServiceResponse.CurrentDDoSBasic = context.StringValue("DescribeScdnService.CurrentDDoSBasic");
			describeScdnServiceResponse.CurrentDomainCount = context.StringValue("DescribeScdnService.CurrentDomainCount");
			describeScdnServiceResponse.CurrentElasticProtection = context.StringValue("DescribeScdnService.CurrentElasticProtection");
			describeScdnServiceResponse.CurrentBandwidthValue = context.StringValue("DescribeScdnService.CurrentBandwidthValue");
			describeScdnServiceResponse.CurrentCcProtectionValue = context.StringValue("DescribeScdnService.CurrentCcProtectionValue");
			describeScdnServiceResponse.CurrentDDoSBasicValue = context.StringValue("DescribeScdnService.CurrentDDoSBasicValue");
			describeScdnServiceResponse.CurrentDomainCountValue = context.StringValue("DescribeScdnService.CurrentDomainCountValue");
			describeScdnServiceResponse.CurrentElasticProtectionValue = context.StringValue("DescribeScdnService.CurrentElasticProtectionValue");
			describeScdnServiceResponse.PriceType = context.StringValue("DescribeScdnService.PriceType");
			describeScdnServiceResponse.PricingCycle = context.StringValue("DescribeScdnService.PricingCycle");

			List<DescribeScdnServiceResponse.DescribeScdnService_LockReason> describeScdnServiceResponse_operationLocks = new List<DescribeScdnServiceResponse.DescribeScdnService_LockReason>();
			for (int i = 0; i < context.Length("DescribeScdnService.OperationLocks.Length"); i++) {
				DescribeScdnServiceResponse.DescribeScdnService_LockReason lockReason = new DescribeScdnServiceResponse.DescribeScdnService_LockReason();
				lockReason.LockReason = context.StringValue("DescribeScdnService.OperationLocks["+ i +"].LockReason");

				describeScdnServiceResponse_operationLocks.Add(lockReason);
			}
			describeScdnServiceResponse.OperationLocks = describeScdnServiceResponse_operationLocks;
        
			return describeScdnServiceResponse;
        }
    }
}
