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
using Aliyun.Acs.Smartag.Model.V20180313;

namespace Aliyun.Acs.Smartag.Transform.V20180313
{
    public class DescribePolicyBasedRoutingsResponseUnmarshaller
    {
        public static DescribePolicyBasedRoutingsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePolicyBasedRoutingsResponse describePolicyBasedRoutingsResponse = new DescribePolicyBasedRoutingsResponse();

			describePolicyBasedRoutingsResponse.HttpResponse = context.HttpResponse;
			describePolicyBasedRoutingsResponse.RequestId = context.StringValue("DescribePolicyBasedRoutings.RequestId");
			describePolicyBasedRoutingsResponse.TotalCount = context.IntegerValue("DescribePolicyBasedRoutings.TotalCount");
			describePolicyBasedRoutingsResponse.PageNumber = context.IntegerValue("DescribePolicyBasedRoutings.PageNumber");
			describePolicyBasedRoutingsResponse.PageSize = context.IntegerValue("DescribePolicyBasedRoutings.PageSize");

			List<DescribePolicyBasedRoutingsResponse.DescribePolicyBasedRoutings_PolicyBasedRouting> describePolicyBasedRoutingsResponse_policyBasedRoutings = new List<DescribePolicyBasedRoutingsResponse.DescribePolicyBasedRoutings_PolicyBasedRouting>();
			for (int i = 0; i < context.Length("DescribePolicyBasedRoutings.PolicyBasedRoutings.Length"); i++) {
				DescribePolicyBasedRoutingsResponse.DescribePolicyBasedRoutings_PolicyBasedRouting policyBasedRouting = new DescribePolicyBasedRoutingsResponse.DescribePolicyBasedRoutings_PolicyBasedRouting();
				policyBasedRouting.PbrInstanceId = context.StringValue("DescribePolicyBasedRoutings.PolicyBasedRoutings["+ i +"].PbrInstanceId");
				policyBasedRouting.Priority = context.IntegerValue("DescribePolicyBasedRoutings.PolicyBasedRoutings["+ i +"].Priority");
				policyBasedRouting.Name = context.StringValue("DescribePolicyBasedRoutings.PolicyBasedRoutings["+ i +"].Name");
				policyBasedRouting.Description = context.StringValue("DescribePolicyBasedRoutings.PolicyBasedRoutings["+ i +"].Description");

				describePolicyBasedRoutingsResponse_policyBasedRoutings.Add(policyBasedRouting);
			}
			describePolicyBasedRoutingsResponse.PolicyBasedRoutings = describePolicyBasedRoutingsResponse_policyBasedRoutings;
        
			return describePolicyBasedRoutingsResponse;
        }
    }
}
