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
    public class QueryTransferInListResponseUnmarshaller
    {
        public static QueryTransferInListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryTransferInListResponse queryTransferInListResponse = new QueryTransferInListResponse();

			queryTransferInListResponse.HttpResponse = _ctx.HttpResponse;
			queryTransferInListResponse.PrePage = _ctx.BooleanValue("QueryTransferInList.PrePage");
			queryTransferInListResponse.CurrentPageNum = _ctx.IntegerValue("QueryTransferInList.CurrentPageNum");
			queryTransferInListResponse.RequestId = _ctx.StringValue("QueryTransferInList.RequestId");
			queryTransferInListResponse.PageSize = _ctx.IntegerValue("QueryTransferInList.PageSize");
			queryTransferInListResponse.TotalPageNum = _ctx.IntegerValue("QueryTransferInList.TotalPageNum");
			queryTransferInListResponse.TotalItemNum = _ctx.IntegerValue("QueryTransferInList.TotalItemNum");
			queryTransferInListResponse.NextPage = _ctx.BooleanValue("QueryTransferInList.NextPage");

			List<QueryTransferInListResponse.QueryTransferInList_TransferInInfo> queryTransferInListResponse_data = new List<QueryTransferInListResponse.QueryTransferInList_TransferInInfo>();
			for (int i = 0; i < _ctx.Length("QueryTransferInList.Data.Length"); i++) {
				QueryTransferInListResponse.QueryTransferInList_TransferInInfo transferInInfo = new QueryTransferInListResponse.QueryTransferInList_TransferInInfo();
				transferInInfo.Status = _ctx.IntegerValue("QueryTransferInList.Data["+ i +"].Status");
				transferInInfo.UserId = _ctx.StringValue("QueryTransferInList.Data["+ i +"].UserId");
				transferInInfo.ModificationDate = _ctx.StringValue("QueryTransferInList.Data["+ i +"].ModificationDate");
				transferInInfo.TransferAuthorizationCodeSubmissionDateLong = _ctx.LongValue("QueryTransferInList.Data["+ i +"].TransferAuthorizationCodeSubmissionDateLong");
				transferInInfo.SubmissionDateLong = _ctx.LongValue("QueryTransferInList.Data["+ i +"].SubmissionDateLong");
				transferInInfo.ResultCode = _ctx.StringValue("QueryTransferInList.Data["+ i +"].ResultCode");
				transferInInfo.NeedMailCheck = _ctx.BooleanValue("QueryTransferInList.Data["+ i +"].NeedMailCheck");
				transferInInfo.ModificationDateLong = _ctx.LongValue("QueryTransferInList.Data["+ i +"].ModificationDateLong");
				transferInInfo.InstanceId = _ctx.StringValue("QueryTransferInList.Data["+ i +"].InstanceId");
				transferInInfo.DomainName = _ctx.StringValue("QueryTransferInList.Data["+ i +"].DomainName");
				transferInInfo.ProgressBarType = _ctx.IntegerValue("QueryTransferInList.Data["+ i +"].ProgressBarType");
				transferInInfo.ResultMsg = _ctx.StringValue("QueryTransferInList.Data["+ i +"].ResultMsg");
				transferInInfo.ResultDateLong = _ctx.LongValue("QueryTransferInList.Data["+ i +"].ResultDateLong");
				transferInInfo.ExpirationDate = _ctx.StringValue("QueryTransferInList.Data["+ i +"].ExpirationDate");
				transferInInfo.Email = _ctx.StringValue("QueryTransferInList.Data["+ i +"].Email");
				transferInInfo.WhoisMailStatus = _ctx.BooleanValue("QueryTransferInList.Data["+ i +"].WhoisMailStatus");
				transferInInfo.TransferAuthorizationCodeSubmissionDate = _ctx.StringValue("QueryTransferInList.Data["+ i +"].TransferAuthorizationCodeSubmissionDate");
				transferInInfo.SubmissionDate = _ctx.StringValue("QueryTransferInList.Data["+ i +"].SubmissionDate");
				transferInInfo.ExpirationDateLong = _ctx.LongValue("QueryTransferInList.Data["+ i +"].ExpirationDateLong");
				transferInInfo.SimpleTransferInStatus = _ctx.StringValue("QueryTransferInList.Data["+ i +"].SimpleTransferInStatus");
				transferInInfo.ResultDate = _ctx.StringValue("QueryTransferInList.Data["+ i +"].ResultDate");

				queryTransferInListResponse_data.Add(transferInInfo);
			}
			queryTransferInListResponse.Data = queryTransferInListResponse_data;
        
			return queryTransferInListResponse;
        }
    }
}
