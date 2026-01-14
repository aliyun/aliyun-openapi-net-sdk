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
    public class ListWhitePortalMenuResponseUnmarshaller
    {
        public static ListWhitePortalMenuResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListWhitePortalMenuResponse listWhitePortalMenuResponse = new ListWhitePortalMenuResponse();

			listWhitePortalMenuResponse.HttpResponse = _ctx.HttpResponse;
			listWhitePortalMenuResponse.RequestId = _ctx.StringValue("ListWhitePortalMenu.RequestId");
			listWhitePortalMenuResponse.Success = _ctx.BooleanValue("ListWhitePortalMenu.Success");

			List<ListWhitePortalMenuResponse.ListWhitePortalMenu_Data> listWhitePortalMenuResponse_result = new List<ListWhitePortalMenuResponse.ListWhitePortalMenu_Data>();
			for (int i = 0; i < _ctx.Length("ListWhitePortalMenu.Result.Length"); i++) {
				ListWhitePortalMenuResponse.ListWhitePortalMenu_Data data = new ListWhitePortalMenuResponse.ListWhitePortalMenu_Data();
				data.ReceiverId = _ctx.StringValue("ListWhitePortalMenu.Result["+ i +"].ReceiverId");
				data.ReceiverType = _ctx.IntegerValue("ListWhitePortalMenu.Result["+ i +"].ReceiverType");
				data.AuthPointsValue = _ctx.IntegerValue("ListWhitePortalMenu.Result["+ i +"].AuthPointsValue");

				listWhitePortalMenuResponse_result.Add(data);
			}
			listWhitePortalMenuResponse.Result = listWhitePortalMenuResponse_result;
        
			return listWhitePortalMenuResponse;
        }
    }
}
