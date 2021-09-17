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
    public class QuerySubscriptionDetailResponseUnmarshaller
    {
        public static QuerySubscriptionDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySubscriptionDetailResponse querySubscriptionDetailResponse = new QuerySubscriptionDetailResponse();

			querySubscriptionDetailResponse.HttpResponse = _ctx.HttpResponse;
			querySubscriptionDetailResponse.Code = _ctx.StringValue("QuerySubscriptionDetail.Code");
			querySubscriptionDetailResponse.Message = _ctx.StringValue("QuerySubscriptionDetail.Message");
			querySubscriptionDetailResponse.RequestId = _ctx.StringValue("QuerySubscriptionDetail.RequestId");

			QuerySubscriptionDetailResponse.QuerySubscriptionDetail_SecretBindDetailDTO secretBindDetailDTO = new QuerySubscriptionDetailResponse.QuerySubscriptionDetail_SecretBindDetailDTO();
			secretBindDetailDTO.Status = _ctx.LongValue("QuerySubscriptionDetail.SecretBindDetailDTO.Status");
			secretBindDetailDTO.Extension = _ctx.StringValue("QuerySubscriptionDetail.SecretBindDetailDTO.Extension");
			secretBindDetailDTO.PhoneNoB = _ctx.StringValue("QuerySubscriptionDetail.SecretBindDetailDTO.PhoneNoB");
			secretBindDetailDTO.GroupId = _ctx.LongValue("QuerySubscriptionDetail.SecretBindDetailDTO.GroupId");
			secretBindDetailDTO.NeedRecord = _ctx.BooleanValue("QuerySubscriptionDetail.SecretBindDetailDTO.NeedRecord");
			secretBindDetailDTO.ASRStatus = _ctx.BooleanValue("QuerySubscriptionDetail.SecretBindDetailDTO.ASRStatus");
			secretBindDetailDTO.GmtCreate = _ctx.StringValue("QuerySubscriptionDetail.SecretBindDetailDTO.GmtCreate");
			secretBindDetailDTO.ExpireDate = _ctx.StringValue("QuerySubscriptionDetail.SecretBindDetailDTO.ExpireDate");
			secretBindDetailDTO.SubsId = _ctx.StringValue("QuerySubscriptionDetail.SecretBindDetailDTO.SubsId");
			secretBindDetailDTO.PhoneNoX = _ctx.StringValue("QuerySubscriptionDetail.SecretBindDetailDTO.PhoneNoX");
			secretBindDetailDTO.CallRestrict = _ctx.StringValue("QuerySubscriptionDetail.SecretBindDetailDTO.CallRestrict");
			secretBindDetailDTO.ASRModelId = _ctx.StringValue("QuerySubscriptionDetail.SecretBindDetailDTO.ASRModelId");
			secretBindDetailDTO.PhoneNoA = _ctx.StringValue("QuerySubscriptionDetail.SecretBindDetailDTO.PhoneNoA");
			querySubscriptionDetailResponse.SecretBindDetailDTO = secretBindDetailDTO;
        
			return querySubscriptionDetailResponse;
        }
    }
}
