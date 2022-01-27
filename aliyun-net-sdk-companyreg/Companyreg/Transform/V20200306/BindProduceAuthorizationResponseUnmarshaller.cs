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
using Aliyun.Acs.companyreg.Model.V20200306;

namespace Aliyun.Acs.companyreg.Transform.V20200306
{
    public class BindProduceAuthorizationResponseUnmarshaller
    {
        public static BindProduceAuthorizationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BindProduceAuthorizationResponse bindProduceAuthorizationResponse = new BindProduceAuthorizationResponse();

			bindProduceAuthorizationResponse.HttpResponse = _ctx.HttpResponse;
			bindProduceAuthorizationResponse.RequestId = _ctx.StringValue("BindProduceAuthorization.RequestId");
			bindProduceAuthorizationResponse.ErrorMsg = _ctx.StringValue("BindProduceAuthorization.ErrorMsg");
			bindProduceAuthorizationResponse.ErrorCode = _ctx.StringValue("BindProduceAuthorization.ErrorCode");

			BindProduceAuthorizationResponse.BindProduceAuthorization_Data data = new BindProduceAuthorizationResponse.BindProduceAuthorization_Data();
			data.Success = _ctx.BooleanValue("BindProduceAuthorization.Data.Success");
			data.Message = _ctx.StringValue("BindProduceAuthorization.Data.Message");

			List<BindProduceAuthorizationResponse.BindProduceAuthorization_Data.BindProduceAuthorization_AuthorizedUserListItem> data_authorizedUserList = new List<BindProduceAuthorizationResponse.BindProduceAuthorization_Data.BindProduceAuthorization_AuthorizedUserListItem>();
			for (int i = 0; i < _ctx.Length("BindProduceAuthorization.Data.AuthorizedUserList.Length"); i++) {
				BindProduceAuthorizationResponse.BindProduceAuthorization_Data.BindProduceAuthorization_AuthorizedUserListItem authorizedUserListItem = new BindProduceAuthorizationResponse.BindProduceAuthorization_Data.BindProduceAuthorization_AuthorizedUserListItem();
				authorizedUserListItem.UserId = _ctx.StringValue("BindProduceAuthorization.Data.AuthorizedUserList["+ i +"].UserId");
				authorizedUserListItem.UserName = _ctx.StringValue("BindProduceAuthorization.Data.AuthorizedUserList["+ i +"].UserName");
				authorizedUserListItem.AccountValidType = _ctx.IntegerValue("BindProduceAuthorization.Data.AuthorizedUserList["+ i +"].AccountValidType");

				data_authorizedUserList.Add(authorizedUserListItem);
			}
			data.AuthorizedUserList = data_authorizedUserList;
			bindProduceAuthorizationResponse.Data = data;
        
			return bindProduceAuthorizationResponse;
        }
    }
}
