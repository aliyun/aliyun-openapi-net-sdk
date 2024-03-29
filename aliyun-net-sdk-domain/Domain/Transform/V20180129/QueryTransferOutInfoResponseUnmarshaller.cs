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
    public class QueryTransferOutInfoResponseUnmarshaller
    {
        public static QueryTransferOutInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryTransferOutInfoResponse queryTransferOutInfoResponse = new QueryTransferOutInfoResponse();

			queryTransferOutInfoResponse.HttpResponse = _ctx.HttpResponse;
			queryTransferOutInfoResponse.Status = _ctx.IntegerValue("QueryTransferOutInfo.Status");
			queryTransferOutInfoResponse.Email = _ctx.StringValue("QueryTransferOutInfo.Email");
			queryTransferOutInfoResponse.ExpirationDate = _ctx.StringValue("QueryTransferOutInfo.ExpirationDate");
			queryTransferOutInfoResponse.RequestId = _ctx.StringValue("QueryTransferOutInfo.RequestId");
			queryTransferOutInfoResponse.ResultMsg = _ctx.StringValue("QueryTransferOutInfo.ResultMsg");
			queryTransferOutInfoResponse.PendingRequestDate = _ctx.StringValue("QueryTransferOutInfo.PendingRequestDate");
			queryTransferOutInfoResponse.ResultCode = _ctx.StringValue("QueryTransferOutInfo.ResultCode");
			queryTransferOutInfoResponse.TransferAuthorizationCodeSendDate = _ctx.StringValue("QueryTransferOutInfo.TransferAuthorizationCodeSendDate");
        
			return queryTransferOutInfoResponse;
        }
    }
}
