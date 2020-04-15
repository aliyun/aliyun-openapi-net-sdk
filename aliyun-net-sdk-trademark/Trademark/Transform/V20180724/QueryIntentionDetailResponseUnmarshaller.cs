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
using Aliyun.Acs.Trademark.Model.V20180724;

namespace Aliyun.Acs.Trademark.Transform.V20180724
{
    public class QueryIntentionDetailResponseUnmarshaller
    {
        public static QueryIntentionDetailResponse Unmarshall(UnmarshallerContext context)
        {
			QueryIntentionDetailResponse queryIntentionDetailResponse = new QueryIntentionDetailResponse();

			queryIntentionDetailResponse.HttpResponse = context.HttpResponse;
			queryIntentionDetailResponse.RequestId = context.StringValue("QueryIntentionDetail.RequestId");
			queryIntentionDetailResponse.UserId = context.StringValue("QueryIntentionDetail.UserId");
			queryIntentionDetailResponse.RegisterNumber = context.StringValue("QueryIntentionDetail.RegisterNumber");
			queryIntentionDetailResponse.Classification = context.StringValue("QueryIntentionDetail.Classification");
			queryIntentionDetailResponse.Type = context.IntegerValue("QueryIntentionDetail.Type");
			queryIntentionDetailResponse.BizId = context.StringValue("QueryIntentionDetail.BizId");
			queryIntentionDetailResponse.Description = context.StringValue("QueryIntentionDetail.Description");
			queryIntentionDetailResponse.Status = context.IntegerValue("QueryIntentionDetail.Status");
			queryIntentionDetailResponse.UpdateTime = context.LongValue("QueryIntentionDetail.UpdateTime");
			queryIntentionDetailResponse.CreateTime = context.LongValue("QueryIntentionDetail.CreateTime");
			queryIntentionDetailResponse.Mobile = context.StringValue("QueryIntentionDetail.Mobile");
			queryIntentionDetailResponse.UserName = context.StringValue("QueryIntentionDetail.UserName");
			queryIntentionDetailResponse.RelationBizId = context.StringValue("QueryIntentionDetail.RelationBizId");
			queryIntentionDetailResponse.PartnerMobile = context.StringValue("QueryIntentionDetail.PartnerMobile");
        
			return queryIntentionDetailResponse;
        }
    }
}
