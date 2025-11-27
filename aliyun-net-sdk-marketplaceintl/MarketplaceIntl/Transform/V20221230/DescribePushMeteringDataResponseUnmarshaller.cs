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
using Aliyun.Acs.marketplaceIntl.Model.V20221230;

namespace Aliyun.Acs.marketplaceIntl.Transform.V20221230
{
    public class DescribePushMeteringDataResponseUnmarshaller
    {
        public static DescribePushMeteringDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePushMeteringDataResponse describePushMeteringDataResponse = new DescribePushMeteringDataResponse();

			describePushMeteringDataResponse.HttpResponse = _ctx.HttpResponse;
			describePushMeteringDataResponse.RequestId = _ctx.StringValue("DescribePushMeteringData.RequestId");
			describePushMeteringDataResponse.Message = _ctx.StringValue("DescribePushMeteringData.Message");
			describePushMeteringDataResponse.ForceFatal = _ctx.BooleanValue("DescribePushMeteringData.ForceFatal");
			describePushMeteringDataResponse.DynamicMessage = _ctx.StringValue("DescribePushMeteringData.DynamicMessage");
			describePushMeteringDataResponse.Code = _ctx.StringValue("DescribePushMeteringData.Code");
			describePushMeteringDataResponse.Success = _ctx.BooleanValue("DescribePushMeteringData.Success");

			DescribePushMeteringDataResponse.DescribePushMeteringData_Result result = new DescribePushMeteringDataResponse.DescribePushMeteringData_Result();
			result.EndTime = _ctx.LongValue("DescribePushMeteringData.Result.EndTime");
			result.InstanceId = _ctx.StringValue("DescribePushMeteringData.Result.InstanceId");
			result.IsPushBilling = _ctx.BooleanValue("DescribePushMeteringData.Result.IsPushBilling");
			result.MeteringAssist = _ctx.StringValue("DescribePushMeteringData.Result.MeteringAssist");
			result.MeteringEntity = _ctx.StringValue("DescribePushMeteringData.Result.MeteringEntity");
			result.PushOrderBizId = _ctx.StringValue("DescribePushMeteringData.Result.PushOrderBizId");
			result.StartTime = _ctx.LongValue("DescribePushMeteringData.Result.StartTime");
			describePushMeteringDataResponse.Result = result;
        
			return describePushMeteringDataResponse;
        }
    }
}
