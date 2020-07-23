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
        public static QuerySubscriptionDetailResponse Unmarshall(UnmarshallerContext context)
        {
			QuerySubscriptionDetailResponse querySubscriptionDetailResponse = new QuerySubscriptionDetailResponse();

			querySubscriptionDetailResponse.HttpResponse = context.HttpResponse;
			querySubscriptionDetailResponse.RequestId = context.StringValue("QuerySubscriptionDetail.RequestId");
			querySubscriptionDetailResponse.Code = context.StringValue("QuerySubscriptionDetail.Code");
			querySubscriptionDetailResponse.Message = context.StringValue("QuerySubscriptionDetail.Message");

			QuerySubscriptionDetailResponse.QuerySubscriptionDetail_SecretBindDetailDTO secretBindDetailDTO = new QuerySubscriptionDetailResponse.QuerySubscriptionDetail_SecretBindDetailDTO();
			secretBindDetailDTO.SubsId = context.StringValue("QuerySubscriptionDetail.SecretBindDetailDTO.SubsId");
			secretBindDetailDTO.PhoneNoA = context.StringValue("QuerySubscriptionDetail.SecretBindDetailDTO.PhoneNoA");
			secretBindDetailDTO.PhoneNoX = context.StringValue("QuerySubscriptionDetail.SecretBindDetailDTO.PhoneNoX");
			secretBindDetailDTO.PhoneNoB = context.StringValue("QuerySubscriptionDetail.SecretBindDetailDTO.PhoneNoB");
			secretBindDetailDTO.Extension = context.StringValue("QuerySubscriptionDetail.SecretBindDetailDTO.Extension");
			secretBindDetailDTO.GroupId = context.LongValue("QuerySubscriptionDetail.SecretBindDetailDTO.GroupId");
			secretBindDetailDTO.GmtCreate = context.StringValue("QuerySubscriptionDetail.SecretBindDetailDTO.GmtCreate");
			secretBindDetailDTO.ExpireDate = context.StringValue("QuerySubscriptionDetail.SecretBindDetailDTO.ExpireDate");
			secretBindDetailDTO.NeedRecord = context.BooleanValue("QuerySubscriptionDetail.SecretBindDetailDTO.NeedRecord");
			secretBindDetailDTO.CallRestrict = context.StringValue("QuerySubscriptionDetail.SecretBindDetailDTO.CallRestrict");
			secretBindDetailDTO.Status = context.LongValue("QuerySubscriptionDetail.SecretBindDetailDTO.Status");
			secretBindDetailDTO.ASRStatus = context.BooleanValue("QuerySubscriptionDetail.SecretBindDetailDTO.ASRStatus");
			secretBindDetailDTO.ASRModelId = context.StringValue("QuerySubscriptionDetail.SecretBindDetailDTO.ASRModelId");
			querySubscriptionDetailResponse.SecretBindDetailDTO = secretBindDetailDTO;
        
			return querySubscriptionDetailResponse;
        }
    }
}
