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
        public static QueryTransferOutInfoResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTransferOutInfoResponse queryTransferOutInfoResponse = new QueryTransferOutInfoResponse();

			queryTransferOutInfoResponse.HttpResponse = context.HttpResponse;
			queryTransferOutInfoResponse.RequestId = context.StringValue("QueryTransferOutInfo.RequestId");
			queryTransferOutInfoResponse.Status = context.IntegerValue("QueryTransferOutInfo.Status");
			queryTransferOutInfoResponse.Email = context.StringValue("QueryTransferOutInfo.Email");
			queryTransferOutInfoResponse.TransferAuthorizationCodeSendDate = context.StringValue("QueryTransferOutInfo.TransferAuthorizationCodeSendDate");
			queryTransferOutInfoResponse.ExpirationDate = context.StringValue("QueryTransferOutInfo.ExpirationDate");
			queryTransferOutInfoResponse.PendingRequestDate = context.StringValue("QueryTransferOutInfo.PendingRequestDate");
			queryTransferOutInfoResponse.ResultCode = context.StringValue("QueryTransferOutInfo.ResultCode");
			queryTransferOutInfoResponse.ResultMsg = context.StringValue("QueryTransferOutInfo.ResultMsg");
        
			return queryTransferOutInfoResponse;
        }
    }
}
