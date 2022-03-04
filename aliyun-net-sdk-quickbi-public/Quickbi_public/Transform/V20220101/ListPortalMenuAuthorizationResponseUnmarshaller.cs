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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class ListPortalMenuAuthorizationResponseUnmarshaller
    {
        public static ListPortalMenuAuthorizationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPortalMenuAuthorizationResponse listPortalMenuAuthorizationResponse = new ListPortalMenuAuthorizationResponse();

			listPortalMenuAuthorizationResponse.HttpResponse = _ctx.HttpResponse;
			listPortalMenuAuthorizationResponse.Success = _ctx.BooleanValue("ListPortalMenuAuthorization.Success");
			listPortalMenuAuthorizationResponse.RequestId = _ctx.StringValue("ListPortalMenuAuthorization.RequestId");

			List<ListPortalMenuAuthorizationResponse.ListPortalMenuAuthorization_Data> listPortalMenuAuthorizationResponse_result = new List<ListPortalMenuAuthorizationResponse.ListPortalMenuAuthorization_Data>();
			for (int i = 0; i < _ctx.Length("ListPortalMenuAuthorization.Result.Length"); i++) {
				ListPortalMenuAuthorizationResponse.ListPortalMenuAuthorization_Data data = new ListPortalMenuAuthorizationResponse.ListPortalMenuAuthorization_Data();
				data.ShowOnlyWithAccess = _ctx.BooleanValue("ListPortalMenuAuthorization.Result["+ i +"].ShowOnlyWithAccess");
				data.MenuId = _ctx.StringValue("ListPortalMenuAuthorization.Result["+ i +"].MenuId");

				List<ListPortalMenuAuthorizationResponse.ListPortalMenuAuthorization_Data.ListPortalMenuAuthorization_ReceiversItem> data_receivers = new List<ListPortalMenuAuthorizationResponse.ListPortalMenuAuthorization_Data.ListPortalMenuAuthorization_ReceiversItem>();
				for (int j = 0; j < _ctx.Length("ListPortalMenuAuthorization.Result["+ i +"].Receivers.Length"); j++) {
					ListPortalMenuAuthorizationResponse.ListPortalMenuAuthorization_Data.ListPortalMenuAuthorization_ReceiversItem receiversItem = new ListPortalMenuAuthorizationResponse.ListPortalMenuAuthorization_Data.ListPortalMenuAuthorization_ReceiversItem();
					receiversItem.ReceiverId = _ctx.StringValue("ListPortalMenuAuthorization.Result["+ i +"].Receivers["+ j +"].ReceiverId");
					receiversItem.ReceiverType = _ctx.IntegerValue("ListPortalMenuAuthorization.Result["+ i +"].Receivers["+ j +"].ReceiverType");

					data_receivers.Add(receiversItem);
				}
				data.Receivers = data_receivers;

				listPortalMenuAuthorizationResponse_result.Add(data);
			}
			listPortalMenuAuthorizationResponse.Result = listPortalMenuAuthorizationResponse_result;
        
			return listPortalMenuAuthorizationResponse;
        }
    }
}
