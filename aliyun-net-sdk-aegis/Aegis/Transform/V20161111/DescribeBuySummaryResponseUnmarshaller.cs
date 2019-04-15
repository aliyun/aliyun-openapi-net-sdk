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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeBuySummaryResponseUnmarshaller
    {
        public static DescribeBuySummaryResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBuySummaryResponse describeBuySummaryResponse = new DescribeBuySummaryResponse();

			describeBuySummaryResponse.HttpResponse = context.HttpResponse;
			describeBuySummaryResponse.RequestId = context.StringValue("DescribeBuySummary.RequestId");

			DescribeBuySummaryResponse.DescribeBuySummary_BuySummary buySummary = new DescribeBuySummaryResponse.DescribeBuySummary_BuySummary();
			buySummary.ExpireDateTimestamp = context.LongValue("DescribeBuySummary.BuySummary.ExpireDateTimestamp");
			buySummary.PurchaseDate = context.LongValue("DescribeBuySummary.BuySummary.PurchaseDate");
			buySummary.BuyVersion = context.StringValue("DescribeBuySummary.BuySummary.BuyVersion");
			buySummary.SafePointSurplusDays = context.IntegerValue("DescribeBuySummary.BuySummary.SafePointSurplusDays");
			buySummary.SafePointdailyCost = context.IntegerValue("DescribeBuySummary.BuySummary.SafePointdailyCost");
			buySummary.Capacity = context.IntegerValue("DescribeBuySummary.BuySummary.Capacity");
			buySummary.TotalMachineNum = context.IntegerValue("DescribeBuySummary.BuySummary.TotalMachineNum");
			buySummary.CanApplyTrial = context.BooleanValue("DescribeBuySummary.BuySummary.CanApplyTrial");
			buySummary.InstanceId = context.StringValue("DescribeBuySummary.BuySummary.InstanceId");
			buySummary.UseCapacity = context.IntegerValue("DescribeBuySummary.BuySummary.UseCapacity");
			buySummary.CanAccessHidden = context.BooleanValue("DescribeBuySummary.BuySummary.CanAccessHidden");
			buySummary.BuyStatus = context.BooleanValue("DescribeBuySummary.BuySummary.BuyStatus");
			buySummary.BuyType = context.StringValue("DescribeBuySummary.BuySummary.BuyType");
			buySummary.ExpireDate = context.LongValue("DescribeBuySummary.BuySummary.ExpireDate");
			buySummary.SafePointCapacity = context.IntegerValue("DescribeBuySummary.BuySummary.SafePointCapacity");
			buySummary.NeedFeedBack = context.BooleanValue("DescribeBuySummary.BuySummary.NeedFeedBack");
			buySummary.SafePointBuyVersion = context.StringValue("DescribeBuySummary.BuySummary.SafePointBuyVersion");
			buySummary.OriginalVersion = context.StringValue("DescribeBuySummary.BuySummary.OriginalVersion");
			buySummary.OriginalBuyType = context.StringValue("DescribeBuySummary.BuySummary.OriginalBuyType");
			buySummary.SafePointExpireDate = context.LongValue("DescribeBuySummary.BuySummary.SafePointExpireDate");
			buySummary.SpecialCount = context.IntegerValue("DescribeBuySummary.BuySummary.SpecialCount");
			describeBuySummaryResponse.BuySummary = buySummary;
        
			return describeBuySummaryResponse;
        }
    }
}
