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
using Aliyun.Acs.Dm.Model.V20170622;

namespace Aliyun.Acs.Dm.Transform.V20170622
{
    public class QueryMailAddressByParamResponseUnmarshaller
    {
        public static QueryMailAddressByParamResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMailAddressByParamResponse queryMailAddressByParamResponse = new QueryMailAddressByParamResponse();

			queryMailAddressByParamResponse.HttpResponse = context.HttpResponse;
			queryMailAddressByParamResponse.RequestId = context.StringValue("QueryMailAddressByParam.RequestId");
			queryMailAddressByParamResponse.TotalCount = context.IntegerValue("QueryMailAddressByParam.TotalCount");
			queryMailAddressByParamResponse.PageNumber = context.IntegerValue("QueryMailAddressByParam.PageNumber");
			queryMailAddressByParamResponse.PageSize = context.IntegerValue("QueryMailAddressByParam.PageSize");

			List<QueryMailAddressByParamResponse.QueryMailAddressByParam_MailAddress> queryMailAddressByParamResponse_data = new List<QueryMailAddressByParamResponse.QueryMailAddressByParam_MailAddress>();
			for (int i = 0; i < context.Length("QueryMailAddressByParam.Data.Length"); i++) {
				QueryMailAddressByParamResponse.QueryMailAddressByParam_MailAddress mailAddress = new QueryMailAddressByParamResponse.QueryMailAddressByParam_MailAddress();
				mailAddress.MailAddressId = context.StringValue("QueryMailAddressByParam.Data["+ i +"].MailAddressId");
				mailAddress.AccountName = context.StringValue("QueryMailAddressByParam.Data["+ i +"].AccountName");
				mailAddress.ReplyAddress = context.StringValue("QueryMailAddressByParam.Data["+ i +"].ReplyAddress");
				mailAddress.Sendtype = context.StringValue("QueryMailAddressByParam.Data["+ i +"].Sendtype");
				mailAddress.AccountStatus = context.StringValue("QueryMailAddressByParam.Data["+ i +"].AccountStatus");
				mailAddress.ReplyStatus = context.StringValue("QueryMailAddressByParam.Data["+ i +"].ReplyStatus");
				mailAddress.CreateTime = context.StringValue("QueryMailAddressByParam.Data["+ i +"].CreateTime");
				mailAddress.DailyCount = context.StringValue("QueryMailAddressByParam.Data["+ i +"].DailyCount");
				mailAddress.MonthCount = context.StringValue("QueryMailAddressByParam.Data["+ i +"].MonthCount");
				mailAddress.DailyReqCount = context.StringValue("QueryMailAddressByParam.Data["+ i +"].DailyReqCount");
				mailAddress.MonthReqCount = context.StringValue("QueryMailAddressByParam.Data["+ i +"].MonthReqCount");
				mailAddress.CreateTime1 = context.StringValue("QueryMailAddressByParam.Data["+ i +"].CreateTime");
				mailAddress.DomainStatus = context.StringValue("QueryMailAddressByParam.Data["+ i +"].DomainStatus");

				queryMailAddressByParamResponse_data.Add(mailAddress);
			}
			queryMailAddressByParamResponse.Data = queryMailAddressByParamResponse_data;
        
			return queryMailAddressByParamResponse;
        }
    }
}
