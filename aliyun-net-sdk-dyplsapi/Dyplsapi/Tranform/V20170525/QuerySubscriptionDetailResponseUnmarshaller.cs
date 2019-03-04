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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Dyplsapi.Model.V20170525;
using System;
using System.Collections.Generic;

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
            querySubscriptionDetailResponse.SubsId = context.StringValue("QuerySubscriptionDetail.SubsId");
            querySubscriptionDetailResponse.PhoneNoA = context.StringValue("QuerySubscriptionDetail.PhoneNoA");
            querySubscriptionDetailResponse.PhoneNoX = context.StringValue("QuerySubscriptionDetail.PhoneNoX");
            querySubscriptionDetailResponse.PhoneNoB = context.StringValue("QuerySubscriptionDetail.PhoneNoB");
            querySubscriptionDetailResponse.GmtCreate = context.StringValue("QuerySubscriptionDetail.GmtCreate");
            querySubscriptionDetailResponse.ExpireDate = context.StringValue("QuerySubscriptionDetail.ExpireDate");
            querySubscriptionDetailResponse.NeedRecord = context.BooleanValue("QuerySubscriptionDetail.NeedRecord");
            querySubscriptionDetailResponse.Status = context.LongValue("QuerySubscriptionDetail.Status");

            return querySubscriptionDetailResponse;
        }
    }
}