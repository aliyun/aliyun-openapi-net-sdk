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
        public static QueryTransferInListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTransferInListResponse queryTransferInListResponse = new QueryTransferInListResponse();

			queryTransferInListResponse.HttpResponse = context.HttpResponse;
			queryTransferInListResponse.RequestId = context.StringValue("QueryTransferInList.RequestId");
			queryTransferInListResponse.TotalItemNum = context.IntegerValue("QueryTransferInList.TotalItemNum");
			queryTransferInListResponse.CurrentPageNum = context.IntegerValue("QueryTransferInList.CurrentPageNum");
			queryTransferInListResponse.TotalPageNum = context.IntegerValue("QueryTransferInList.TotalPageNum");
			queryTransferInListResponse.PageSize = context.IntegerValue("QueryTransferInList.PageSize");
			queryTransferInListResponse.PrePage = context.BooleanValue("QueryTransferInList.PrePage");
			queryTransferInListResponse.NextPage = context.BooleanValue("QueryTransferInList.NextPage");

			List<QueryTransferInListResponse.QueryTransferInList_TransferInInfo> queryTransferInListResponse_data = new List<QueryTransferInListResponse.QueryTransferInList_TransferInInfo>();
			for (int i = 0; i < context.Length("QueryTransferInList.Data.Length"); i++) {
				QueryTransferInListResponse.QueryTransferInList_TransferInInfo transferInInfo = new QueryTransferInListResponse.QueryTransferInList_TransferInInfo();
				transferInInfo.SubmissionDate = context.StringValue("QueryTransferInList.Data["+ i +"].SubmissionDate");
				transferInInfo.ModificationDate = context.StringValue("QueryTransferInList.Data["+ i +"].ModificationDate");
				transferInInfo.UserId = context.StringValue("QueryTransferInList.Data["+ i +"].UserId");
				transferInInfo.InstanceId = context.StringValue("QueryTransferInList.Data["+ i +"].InstanceId");
				transferInInfo.DomainName = context.StringValue("QueryTransferInList.Data["+ i +"].DomainName");
				transferInInfo.Status = context.IntegerValue("QueryTransferInList.Data["+ i +"].Status");
				transferInInfo.SimpleTransferInStatus = context.StringValue("QueryTransferInList.Data["+ i +"].SimpleTransferInStatus");
				transferInInfo.ResultCode = context.StringValue("QueryTransferInList.Data["+ i +"].ResultCode");
				transferInInfo.ResultDate = context.StringValue("QueryTransferInList.Data["+ i +"].ResultDate");
				transferInInfo.ResultMsg = context.StringValue("QueryTransferInList.Data["+ i +"].ResultMsg");
				transferInInfo.TransferAuthorizationCodeSubmissionDate = context.StringValue("QueryTransferInList.Data["+ i +"].TransferAuthorizationCodeSubmissionDate");
				transferInInfo.NeedMailCheck = context.BooleanValue("QueryTransferInList.Data["+ i +"].NeedMailCheck");
				transferInInfo.Email = context.StringValue("QueryTransferInList.Data["+ i +"].Email");
				transferInInfo.WhoisMailStatus = context.BooleanValue("QueryTransferInList.Data["+ i +"].WhoisMailStatus");
				transferInInfo.ExpirationDate = context.StringValue("QueryTransferInList.Data["+ i +"].ExpirationDate");
				transferInInfo.ProgressBarType = context.IntegerValue("QueryTransferInList.Data["+ i +"].ProgressBarType");
				transferInInfo.SubmissionDateLong = context.LongValue("QueryTransferInList.Data["+ i +"].SubmissionDateLong");
				transferInInfo.ModificationDateLong = context.LongValue("QueryTransferInList.Data["+ i +"].ModificationDateLong");
				transferInInfo.ResultDateLong = context.LongValue("QueryTransferInList.Data["+ i +"].ResultDateLong");
				transferInInfo.ExpirationDateLong = context.LongValue("QueryTransferInList.Data["+ i +"].ExpirationDateLong");
				transferInInfo.TransferAuthorizationCodeSubmissionDateLong = context.LongValue("QueryTransferInList.Data["+ i +"].TransferAuthorizationCodeSubmissionDateLong");

				queryTransferInListResponse_data.Add(transferInInfo);
			}
			queryTransferInListResponse.Data = queryTransferInListResponse_data;
        
			return queryTransferInListResponse;
        }
    }
}
