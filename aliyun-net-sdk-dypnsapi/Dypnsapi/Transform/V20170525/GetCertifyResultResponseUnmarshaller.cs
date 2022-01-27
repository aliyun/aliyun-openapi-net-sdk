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
using Aliyun.Acs.Dypnsapi.Model.V20170525;

namespace Aliyun.Acs.Dypnsapi.Transform.V20170525
{
    public class GetCertifyResultResponseUnmarshaller
    {
        public static GetCertifyResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetCertifyResultResponse getCertifyResultResponse = new GetCertifyResultResponse();

			getCertifyResultResponse.HttpResponse = _ctx.HttpResponse;
			getCertifyResultResponse.Code = _ctx.StringValue("GetCertifyResult.Code");
			getCertifyResultResponse.Message = _ctx.StringValue("GetCertifyResult.Message");
			getCertifyResultResponse.RequestId = _ctx.StringValue("GetCertifyResult.RequestId");

			List<GetCertifyResultResponse.GetCertifyResult_DataItem> getCertifyResultResponse_data = new List<GetCertifyResultResponse.GetCertifyResult_DataItem>();
			for (int i = 0; i < _ctx.Length("GetCertifyResult.Data.Length"); i++) {
				GetCertifyResultResponse.GetCertifyResult_DataItem dataItem = new GetCertifyResultResponse.GetCertifyResult_DataItem();
				dataItem.MaterialInfo = _ctx.StringValue("GetCertifyResult.Data["+ i +"].MaterialInfo");
				dataItem.IdentityInfo = _ctx.StringValue("GetCertifyResult.Data["+ i +"].IdentityInfo");
				dataItem.VerifyDesc = _ctx.StringValue("GetCertifyResult.Data["+ i +"].VerifyDesc");
				dataItem.VerifyResult = _ctx.StringValue("GetCertifyResult.Data["+ i +"].VerifyResult");
				dataItem.DeviceToken = _ctx.StringValue("GetCertifyResult.Data["+ i +"].DeviceToken");

				getCertifyResultResponse_data.Add(dataItem);
			}
			getCertifyResultResponse.Data = getCertifyResultResponse_data;
        
			return getCertifyResultResponse;
        }
    }
}
