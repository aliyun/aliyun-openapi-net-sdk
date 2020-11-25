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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeDedicatedHostAutoRenewResponseUnmarshaller
    {
        public static DescribeDedicatedHostAutoRenewResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDedicatedHostAutoRenewResponse describeDedicatedHostAutoRenewResponse = new DescribeDedicatedHostAutoRenewResponse();

			describeDedicatedHostAutoRenewResponse.HttpResponse = _ctx.HttpResponse;
			describeDedicatedHostAutoRenewResponse.RequestId = _ctx.StringValue("DescribeDedicatedHostAutoRenew.RequestId");

			List<DescribeDedicatedHostAutoRenewResponse.DescribeDedicatedHostAutoRenew_DedicatedHostRenewAttribute> describeDedicatedHostAutoRenewResponse_dedicatedHostRenewAttributes = new List<DescribeDedicatedHostAutoRenewResponse.DescribeDedicatedHostAutoRenew_DedicatedHostRenewAttribute>();
			for (int i = 0; i < _ctx.Length("DescribeDedicatedHostAutoRenew.DedicatedHostRenewAttributes.Length"); i++) {
				DescribeDedicatedHostAutoRenewResponse.DescribeDedicatedHostAutoRenew_DedicatedHostRenewAttribute dedicatedHostRenewAttribute = new DescribeDedicatedHostAutoRenewResponse.DescribeDedicatedHostAutoRenew_DedicatedHostRenewAttribute();
				dedicatedHostRenewAttribute.DedicatedHostId = _ctx.StringValue("DescribeDedicatedHostAutoRenew.DedicatedHostRenewAttributes["+ i +"].DedicatedHostId");
				dedicatedHostRenewAttribute.AutoRenewEnabled = _ctx.BooleanValue("DescribeDedicatedHostAutoRenew.DedicatedHostRenewAttributes["+ i +"].AutoRenewEnabled");
				dedicatedHostRenewAttribute.Duration = _ctx.IntegerValue("DescribeDedicatedHostAutoRenew.DedicatedHostRenewAttributes["+ i +"].Duration");
				dedicatedHostRenewAttribute.PeriodUnit = _ctx.StringValue("DescribeDedicatedHostAutoRenew.DedicatedHostRenewAttributes["+ i +"].PeriodUnit");
				dedicatedHostRenewAttribute.RenewalStatus = _ctx.StringValue("DescribeDedicatedHostAutoRenew.DedicatedHostRenewAttributes["+ i +"].RenewalStatus");

				describeDedicatedHostAutoRenewResponse_dedicatedHostRenewAttributes.Add(dedicatedHostRenewAttribute);
			}
			describeDedicatedHostAutoRenewResponse.DedicatedHostRenewAttributes = describeDedicatedHostAutoRenewResponse_dedicatedHostRenewAttributes;
        
			return describeDedicatedHostAutoRenewResponse;
        }
    }
}
