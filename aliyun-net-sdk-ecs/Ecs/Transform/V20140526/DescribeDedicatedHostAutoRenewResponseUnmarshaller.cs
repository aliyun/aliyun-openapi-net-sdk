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
        public static DescribeDedicatedHostAutoRenewResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDedicatedHostAutoRenewResponse describeDedicatedHostAutoRenewResponse = new DescribeDedicatedHostAutoRenewResponse();

			describeDedicatedHostAutoRenewResponse.HttpResponse = context.HttpResponse;
			describeDedicatedHostAutoRenewResponse.RequestId = context.StringValue("DescribeDedicatedHostAutoRenew.RequestId");

			List<DescribeDedicatedHostAutoRenewResponse.DescribeDedicatedHostAutoRenew_DedicatedHostRenewAttribute> describeDedicatedHostAutoRenewResponse_dedicatedHostRenewAttributes = new List<DescribeDedicatedHostAutoRenewResponse.DescribeDedicatedHostAutoRenew_DedicatedHostRenewAttribute>();
			for (int i = 0; i < context.Length("DescribeDedicatedHostAutoRenew.DedicatedHostRenewAttributes.Length"); i++) {
				DescribeDedicatedHostAutoRenewResponse.DescribeDedicatedHostAutoRenew_DedicatedHostRenewAttribute dedicatedHostRenewAttribute = new DescribeDedicatedHostAutoRenewResponse.DescribeDedicatedHostAutoRenew_DedicatedHostRenewAttribute();
				dedicatedHostRenewAttribute.DedicatedHostId = context.StringValue("DescribeDedicatedHostAutoRenew.DedicatedHostRenewAttributes["+ i +"].DedicatedHostId");
				dedicatedHostRenewAttribute.AutoRenewEnabled = context.BooleanValue("DescribeDedicatedHostAutoRenew.DedicatedHostRenewAttributes["+ i +"].AutoRenewEnabled");
				dedicatedHostRenewAttribute.Duration = context.IntegerValue("DescribeDedicatedHostAutoRenew.DedicatedHostRenewAttributes["+ i +"].Duration");
				dedicatedHostRenewAttribute.PeriodUnit = context.StringValue("DescribeDedicatedHostAutoRenew.DedicatedHostRenewAttributes["+ i +"].PeriodUnit");
				dedicatedHostRenewAttribute.RenewalStatus = context.StringValue("DescribeDedicatedHostAutoRenew.DedicatedHostRenewAttributes["+ i +"].RenewalStatus");

				describeDedicatedHostAutoRenewResponse_dedicatedHostRenewAttributes.Add(dedicatedHostRenewAttribute);
			}
			describeDedicatedHostAutoRenewResponse.DedicatedHostRenewAttributes = describeDedicatedHostAutoRenewResponse_dedicatedHostRenewAttributes;
        
			return describeDedicatedHostAutoRenewResponse;
        }
    }
}
