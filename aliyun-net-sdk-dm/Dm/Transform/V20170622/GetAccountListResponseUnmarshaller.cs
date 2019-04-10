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
    public class GetAccountListResponseUnmarshaller
    {
        public static GetAccountListResponse Unmarshall(UnmarshallerContext context)
        {
			GetAccountListResponse getAccountListResponse = new GetAccountListResponse();

			getAccountListResponse.HttpResponse = context.HttpResponse;
			getAccountListResponse.RequestId = context.StringValue("GetAccountList.RequestId");
			getAccountListResponse.Total = context.IntegerValue("GetAccountList.Total");
			getAccountListResponse.PageNo = context.IntegerValue("GetAccountList.PageNo");
			getAccountListResponse.PageSize = context.IntegerValue("GetAccountList.PageSize");

			List<GetAccountListResponse.GetAccountList_AccountNotificationInfo> getAccountListResponse_data = new List<GetAccountListResponse.GetAccountList_AccountNotificationInfo>();
			for (int i = 0; i < context.Length("GetAccountList.Data.Length"); i++) {
				GetAccountListResponse.GetAccountList_AccountNotificationInfo accountNotificationInfo = new GetAccountListResponse.GetAccountList_AccountNotificationInfo();
				accountNotificationInfo.Region = context.StringValue("GetAccountList.Data["+ i +"].Region");
				accountNotificationInfo.UpdateTime = context.StringValue("GetAccountList.Data["+ i +"].UpdateTime");
				accountNotificationInfo.Status = context.StringValue("GetAccountList.Data["+ i +"].Status");

				getAccountListResponse_data.Add(accountNotificationInfo);
			}
			getAccountListResponse.Data = getAccountListResponse_data;
        
			return getAccountListResponse;
        }
    }
}
