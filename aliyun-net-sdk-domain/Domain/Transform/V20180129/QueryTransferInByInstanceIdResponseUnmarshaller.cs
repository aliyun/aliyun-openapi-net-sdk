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
        public static QueryTransferInByInstanceIdResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTransferInByInstanceIdResponse queryTransferInByInstanceIdResponse = new QueryTransferInByInstanceIdResponse();

			queryTransferInByInstanceIdResponse.HttpResponse = context.HttpResponse;
			queryTransferInByInstanceIdResponse.RequestId = context.StringValue("QueryTransferInByInstanceId.RequestId");
			queryTransferInByInstanceIdResponse.SubmissionDate = context.StringValue("QueryTransferInByInstanceId.SubmissionDate");
			queryTransferInByInstanceIdResponse.ModificationDate = context.StringValue("QueryTransferInByInstanceId.ModificationDate");
			queryTransferInByInstanceIdResponse.UserId = context.StringValue("QueryTransferInByInstanceId.UserId");
			queryTransferInByInstanceIdResponse.InstanceId = context.StringValue("QueryTransferInByInstanceId.InstanceId");
			queryTransferInByInstanceIdResponse.DomainName = context.StringValue("QueryTransferInByInstanceId.DomainName");
			queryTransferInByInstanceIdResponse.Status = context.IntegerValue("QueryTransferInByInstanceId.Status");
			queryTransferInByInstanceIdResponse.SimpleTransferInStatus = context.StringValue("QueryTransferInByInstanceId.SimpleTransferInStatus");
			queryTransferInByInstanceIdResponse.ResultCode = context.StringValue("QueryTransferInByInstanceId.ResultCode");
			queryTransferInByInstanceIdResponse.ResultDate = context.StringValue("QueryTransferInByInstanceId.ResultDate");
			queryTransferInByInstanceIdResponse.ResultMsg = context.StringValue("QueryTransferInByInstanceId.ResultMsg");
			queryTransferInByInstanceIdResponse.TransferAuthorizationCodeSubmissionDate = context.StringValue("QueryTransferInByInstanceId.TransferAuthorizationCodeSubmissionDate");
			queryTransferInByInstanceIdResponse.NeedMailCheck = context.BooleanValue("QueryTransferInByInstanceId.NeedMailCheck");
			queryTransferInByInstanceIdResponse.Email = context.StringValue("QueryTransferInByInstanceId.Email");
			queryTransferInByInstanceIdResponse.WhoisMailStatus = context.BooleanValue("QueryTransferInByInstanceId.WhoisMailStatus");
			queryTransferInByInstanceIdResponse.ExpirationDate = context.StringValue("QueryTransferInByInstanceId.ExpirationDate");
			queryTransferInByInstanceIdResponse.ProgressBarType = context.IntegerValue("QueryTransferInByInstanceId.ProgressBarType");
			queryTransferInByInstanceIdResponse.SubmissionDateLong = context.LongValue("QueryTransferInByInstanceId.SubmissionDateLong");
			queryTransferInByInstanceIdResponse.ModificationDateLong = context.LongValue("QueryTransferInByInstanceId.ModificationDateLong");
			queryTransferInByInstanceIdResponse.ResultDateLong = context.LongValue("QueryTransferInByInstanceId.ResultDateLong");
			queryTransferInByInstanceIdResponse.ExpirationDateLong = context.LongValue("QueryTransferInByInstanceId.ExpirationDateLong");
			queryTransferInByInstanceIdResponse.TransferAuthorizationCodeSubmissionDateLong = context.LongValue("QueryTransferInByInstanceId.TransferAuthorizationCodeSubmissionDateLong");
        
			return queryTransferInByInstanceIdResponse;
        }
    }
}
