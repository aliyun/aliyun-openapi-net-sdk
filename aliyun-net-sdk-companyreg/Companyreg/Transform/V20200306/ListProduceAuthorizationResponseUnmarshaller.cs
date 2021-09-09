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
    public class ListProduceAuthorizationResponseUnmarshaller
    {
        public static ListProduceAuthorizationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListProduceAuthorizationResponse listProduceAuthorizationResponse = new ListProduceAuthorizationResponse();

			listProduceAuthorizationResponse.HttpResponse = _ctx.HttpResponse;
			listProduceAuthorizationResponse.CurrentPageNum = _ctx.IntegerValue("ListProduceAuthorization.CurrentPageNum");
			listProduceAuthorizationResponse.PageSize = _ctx.IntegerValue("ListProduceAuthorization.PageSize");
			listProduceAuthorizationResponse.RequestId = _ctx.StringValue("ListProduceAuthorization.RequestId");
			listProduceAuthorizationResponse.TotalItemNum = _ctx.IntegerValue("ListProduceAuthorization.TotalItemNum");
			listProduceAuthorizationResponse.TotalPageNum = _ctx.IntegerValue("ListProduceAuthorization.TotalPageNum");
			listProduceAuthorizationResponse.Success = _ctx.BooleanValue("ListProduceAuthorization.Success");

			List<ListProduceAuthorizationResponse.ListProduceAuthorization_ProduceAuthorizations> listProduceAuthorizationResponse_data = new List<ListProduceAuthorizationResponse.ListProduceAuthorization_ProduceAuthorizations>();
			for (int i = 0; i < _ctx.Length("ListProduceAuthorization.Data.Length"); i++) {
				ListProduceAuthorizationResponse.ListProduceAuthorization_ProduceAuthorizations produceAuthorizations = new ListProduceAuthorizationResponse.ListProduceAuthorization_ProduceAuthorizations();
				produceAuthorizations.AuthorizedUserId = _ctx.StringValue("ListProduceAuthorization.Data["+ i +"].AuthorizedUserId");
				produceAuthorizations.AuthorizedUserName = _ctx.StringValue("ListProduceAuthorization.Data["+ i +"].AuthorizedUserName");

				listProduceAuthorizationResponse_data.Add(produceAuthorizations);
			}
			listProduceAuthorizationResponse.Data = listProduceAuthorizationResponse_data;
        
			return listProduceAuthorizationResponse;
        }
    }
}
