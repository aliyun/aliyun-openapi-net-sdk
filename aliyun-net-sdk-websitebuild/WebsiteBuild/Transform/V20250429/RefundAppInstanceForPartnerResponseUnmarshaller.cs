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
using Aliyun.Acs.WebsiteBuild.Model.V20250429;

namespace Aliyun.Acs.WebsiteBuild.Transform.V20250429
{
    public class RefundAppInstanceForPartnerResponseUnmarshaller
    {
        public static RefundAppInstanceForPartnerResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RefundAppInstanceForPartnerResponse refundAppInstanceForPartnerResponse = new RefundAppInstanceForPartnerResponse();

			refundAppInstanceForPartnerResponse.HttpResponse = _ctx.HttpResponse;
			refundAppInstanceForPartnerResponse.RequestId = _ctx.StringValue("RefundAppInstanceForPartner.RequestId");
			refundAppInstanceForPartnerResponse.DynamicCode = _ctx.StringValue("RefundAppInstanceForPartner.DynamicCode");
			refundAppInstanceForPartnerResponse.DynamicMessage = _ctx.StringValue("RefundAppInstanceForPartner.DynamicMessage");
			refundAppInstanceForPartnerResponse.Synchro = _ctx.BooleanValue("RefundAppInstanceForPartner.Synchro");
			refundAppInstanceForPartnerResponse.AccessDeniedDetail = _ctx.StringValue("RefundAppInstanceForPartner.AccessDeniedDetail");
			refundAppInstanceForPartnerResponse.RootErrorMsg = _ctx.StringValue("RefundAppInstanceForPartner.RootErrorMsg");
			refundAppInstanceForPartnerResponse.RootErrorCode = _ctx.StringValue("RefundAppInstanceForPartner.RootErrorCode");
			refundAppInstanceForPartnerResponse.AllowRetry = _ctx.BooleanValue("RefundAppInstanceForPartner.AllowRetry");
			refundAppInstanceForPartnerResponse.AppName = _ctx.StringValue("RefundAppInstanceForPartner.AppName");

			List<string> refundAppInstanceForPartnerResponse_errorArgs = new List<string>();
			for (int i = 0; i < _ctx.Length("RefundAppInstanceForPartner.ErrorArgs.Length"); i++) {
				refundAppInstanceForPartnerResponse_errorArgs.Add(_ctx.StringValue("RefundAppInstanceForPartner.ErrorArgs["+ i +"]"));
			}
			refundAppInstanceForPartnerResponse.ErrorArgs = refundAppInstanceForPartnerResponse_errorArgs;

			RefundAppInstanceForPartnerResponse.RefundAppInstanceForPartner_Module module = new RefundAppInstanceForPartnerResponse.RefundAppInstanceForPartner_Module();
			module.OrderId = _ctx.StringValue("RefundAppInstanceForPartner.Module.OrderId");
			refundAppInstanceForPartnerResponse.Module = module;
        
			return refundAppInstanceForPartnerResponse;
        }
    }
}
