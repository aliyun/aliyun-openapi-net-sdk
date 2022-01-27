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
using Aliyun.Acs.Dyplsapi.Model.V20170525;

namespace Aliyun.Acs.Dyplsapi.Transform.V20170525
{
    public class GetSubscriptionDetailResponseUnmarshaller
    {
        public static GetSubscriptionDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSubscriptionDetailResponse getSubscriptionDetailResponse = new GetSubscriptionDetailResponse();

			getSubscriptionDetailResponse.HttpResponse = _ctx.HttpResponse;
			getSubscriptionDetailResponse.Code = _ctx.StringValue("GetSubscriptionDetail.Code");
			getSubscriptionDetailResponse.Message = _ctx.StringValue("GetSubscriptionDetail.Message");
			getSubscriptionDetailResponse.RequestId = _ctx.StringValue("GetSubscriptionDetail.RequestId");

			GetSubscriptionDetailResponse.GetSubscriptionDetail_Data data = new GetSubscriptionDetailResponse.GetSubscriptionDetail_Data();
			data.PhoneNo = _ctx.StringValue("GetSubscriptionDetail.Data.PhoneNo");
			data.City = _ctx.StringValue("GetSubscriptionDetail.Data.City");
			data.SwitchStatus = _ctx.IntegerValue("GetSubscriptionDetail.Data.SwitchStatus");
			data.SubsId = _ctx.LongValue("GetSubscriptionDetail.Data.SubsId");
			data.SecretNo = _ctx.StringValue("GetSubscriptionDetail.Data.SecretNo");
			data.Vendor = _ctx.StringValue("GetSubscriptionDetail.Data.Vendor");
			data.Province = _ctx.StringValue("GetSubscriptionDetail.Data.Province");
			getSubscriptionDetailResponse.Data = data;
        
			return getSubscriptionDetailResponse;
        }
    }
}
