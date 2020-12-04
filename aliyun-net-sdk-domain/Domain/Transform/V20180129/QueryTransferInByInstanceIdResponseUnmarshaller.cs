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
using Aliyun.Acs.Domain.Model.V20180129;

namespace Aliyun.Acs.Domain.Transform.V20180129
{
    public class QueryTransferInByInstanceIdResponseUnmarshaller
    {
        public static QueryTransferInByInstanceIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryTransferInByInstanceIdResponse queryTransferInByInstanceIdResponse = new QueryTransferInByInstanceIdResponse();

			queryTransferInByInstanceIdResponse.HttpResponse = _ctx.HttpResponse;
			queryTransferInByInstanceIdResponse.RequestId = _ctx.StringValue("QueryTransferInByInstanceId.RequestId");
			queryTransferInByInstanceIdResponse.SubmissionDate = _ctx.StringValue("QueryTransferInByInstanceId.SubmissionDate");
			queryTransferInByInstanceIdResponse.ModificationDate = _ctx.StringValue("QueryTransferInByInstanceId.ModificationDate");
			queryTransferInByInstanceIdResponse.UserId = _ctx.StringValue("QueryTransferInByInstanceId.UserId");
			queryTransferInByInstanceIdResponse.InstanceId = _ctx.StringValue("QueryTransferInByInstanceId.InstanceId");
			queryTransferInByInstanceIdResponse.DomainName = _ctx.StringValue("QueryTransferInByInstanceId.DomainName");
			queryTransferInByInstanceIdResponse.Status = _ctx.IntegerValue("QueryTransferInByInstanceId.Status");
			queryTransferInByInstanceIdResponse.SimpleTransferInStatus = _ctx.StringValue("QueryTransferInByInstanceId.SimpleTransferInStatus");
			queryTransferInByInstanceIdResponse.ResultCode = _ctx.StringValue("QueryTransferInByInstanceId.ResultCode");
			queryTransferInByInstanceIdResponse.ResultDate = _ctx.StringValue("QueryTransferInByInstanceId.ResultDate");
			queryTransferInByInstanceIdResponse.ResultMsg = _ctx.StringValue("QueryTransferInByInstanceId.ResultMsg");
			queryTransferInByInstanceIdResponse.TransferAuthorizationCodeSubmissionDate = _ctx.StringValue("QueryTransferInByInstanceId.TransferAuthorizationCodeSubmissionDate");
			queryTransferInByInstanceIdResponse.NeedMailCheck = _ctx.BooleanValue("QueryTransferInByInstanceId.NeedMailCheck");
			queryTransferInByInstanceIdResponse.Email = _ctx.StringValue("QueryTransferInByInstanceId.Email");
			queryTransferInByInstanceIdResponse.WhoisMailStatus = _ctx.BooleanValue("QueryTransferInByInstanceId.WhoisMailStatus");
			queryTransferInByInstanceIdResponse.ExpirationDate = _ctx.StringValue("QueryTransferInByInstanceId.ExpirationDate");
			queryTransferInByInstanceIdResponse.ProgressBarType = _ctx.IntegerValue("QueryTransferInByInstanceId.ProgressBarType");
			queryTransferInByInstanceIdResponse.SubmissionDateLong = _ctx.LongValue("QueryTransferInByInstanceId.SubmissionDateLong");
			queryTransferInByInstanceIdResponse.ModificationDateLong = _ctx.LongValue("QueryTransferInByInstanceId.ModificationDateLong");
			queryTransferInByInstanceIdResponse.ResultDateLong = _ctx.LongValue("QueryTransferInByInstanceId.ResultDateLong");
			queryTransferInByInstanceIdResponse.ExpirationDateLong = _ctx.LongValue("QueryTransferInByInstanceId.ExpirationDateLong");
			queryTransferInByInstanceIdResponse.TransferAuthorizationCodeSubmissionDateLong = _ctx.LongValue("QueryTransferInByInstanceId.TransferAuthorizationCodeSubmissionDateLong");
        
			return queryTransferInByInstanceIdResponse;
        }
    }
}
