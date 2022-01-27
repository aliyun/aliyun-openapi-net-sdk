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
        public static DescribeScdnServiceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScdnServiceResponse describeScdnServiceResponse = new DescribeScdnServiceResponse();

			describeScdnServiceResponse.HttpResponse = _ctx.HttpResponse;
			describeScdnServiceResponse.RequestId = _ctx.StringValue("DescribeScdnService.RequestId");
			describeScdnServiceResponse.ChangingAffectTime = _ctx.StringValue("DescribeScdnService.ChangingAffectTime");
			describeScdnServiceResponse.InternetChargeType = _ctx.StringValue("DescribeScdnService.InternetChargeType");
			describeScdnServiceResponse.ChangingChargeType = _ctx.StringValue("DescribeScdnService.ChangingChargeType");
			describeScdnServiceResponse.InstanceId = _ctx.StringValue("DescribeScdnService.InstanceId");
			describeScdnServiceResponse.OpenTime = _ctx.StringValue("DescribeScdnService.OpenTime");
			describeScdnServiceResponse.EndTime = _ctx.StringValue("DescribeScdnService.EndTime");
			describeScdnServiceResponse.ProtectType = _ctx.StringValue("DescribeScdnService.ProtectType");
			describeScdnServiceResponse.ProtectTypeValue = _ctx.StringValue("DescribeScdnService.ProtectTypeValue");
			describeScdnServiceResponse.Bandwidth = _ctx.StringValue("DescribeScdnService.Bandwidth");
			describeScdnServiceResponse.CcProtection = _ctx.StringValue("DescribeScdnService.CcProtection");
			describeScdnServiceResponse.DDoSBasic = _ctx.StringValue("DescribeScdnService.DDoSBasic");
			describeScdnServiceResponse.DomainCount = _ctx.StringValue("DescribeScdnService.DomainCount");
			describeScdnServiceResponse.ElasticProtection = _ctx.StringValue("DescribeScdnService.ElasticProtection");
			describeScdnServiceResponse.BandwidthValue = _ctx.StringValue("DescribeScdnService.BandwidthValue");
			describeScdnServiceResponse.CcProtectionValue = _ctx.StringValue("DescribeScdnService.CcProtectionValue");
			describeScdnServiceResponse.DDoSBasicValue = _ctx.StringValue("DescribeScdnService.DDoSBasicValue");
			describeScdnServiceResponse.DomainCountValue = _ctx.StringValue("DescribeScdnService.DomainCountValue");
			describeScdnServiceResponse.ElasticProtectionValue = _ctx.StringValue("DescribeScdnService.ElasticProtectionValue");
			describeScdnServiceResponse.CurrentProtectType = _ctx.StringValue("DescribeScdnService.CurrentProtectType");
			describeScdnServiceResponse.CurrentProtectTypeValue = _ctx.StringValue("DescribeScdnService.CurrentProtectTypeValue");
			describeScdnServiceResponse.CurrentBandwidth = _ctx.StringValue("DescribeScdnService.CurrentBandwidth");
			describeScdnServiceResponse.CurrentCcProtection = _ctx.StringValue("DescribeScdnService.CurrentCcProtection");
			describeScdnServiceResponse.CurrentDDoSBasic = _ctx.StringValue("DescribeScdnService.CurrentDDoSBasic");
			describeScdnServiceResponse.CurrentDomainCount = _ctx.StringValue("DescribeScdnService.CurrentDomainCount");
			describeScdnServiceResponse.CurrentElasticProtection = _ctx.StringValue("DescribeScdnService.CurrentElasticProtection");
			describeScdnServiceResponse.CurrentBandwidthValue = _ctx.StringValue("DescribeScdnService.CurrentBandwidthValue");
			describeScdnServiceResponse.CurrentCcProtectionValue = _ctx.StringValue("DescribeScdnService.CurrentCcProtectionValue");
			describeScdnServiceResponse.CurrentDDoSBasicValue = _ctx.StringValue("DescribeScdnService.CurrentDDoSBasicValue");
			describeScdnServiceResponse.CurrentDomainCountValue = _ctx.StringValue("DescribeScdnService.CurrentDomainCountValue");
			describeScdnServiceResponse.CurrentElasticProtectionValue = _ctx.StringValue("DescribeScdnService.CurrentElasticProtectionValue");
			describeScdnServiceResponse.PriceType = _ctx.StringValue("DescribeScdnService.PriceType");
			describeScdnServiceResponse.PricingCycle = _ctx.StringValue("DescribeScdnService.PricingCycle");

			List<DescribeScdnServiceResponse.DescribeScdnService_LockReason> describeScdnServiceResponse_operationLocks = new List<DescribeScdnServiceResponse.DescribeScdnService_LockReason>();
			for (int i = 0; i < _ctx.Length("DescribeScdnService.OperationLocks.Length"); i++) {
				DescribeScdnServiceResponse.DescribeScdnService_LockReason lockReason = new DescribeScdnServiceResponse.DescribeScdnService_LockReason();
				lockReason.LockReason = _ctx.StringValue("DescribeScdnService.OperationLocks["+ i +"].LockReason");

				describeScdnServiceResponse_operationLocks.Add(lockReason);
			}
			describeScdnServiceResponse.OperationLocks = describeScdnServiceResponse_operationLocks;
        
			return describeScdnServiceResponse;
        }
    }
}
