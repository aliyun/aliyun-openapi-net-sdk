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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class ListTableGranteesResponseUnmarshaller
    {
        public static ListTableGranteesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTableGranteesResponse listTableGranteesResponse = new ListTableGranteesResponse();

			listTableGranteesResponse.HttpResponse = _ctx.HttpResponse;
			listTableGranteesResponse.RequestId = _ctx.StringValue("ListTableGrantees.RequestId");

			List<ListTableGranteesResponse.ListTableGrantees_GranteeItem> listTableGranteesResponse_grantee = new List<ListTableGranteesResponse.ListTableGrantees_GranteeItem>();
			for (int i = 0; i < _ctx.Length("ListTableGrantees.Grantee.Length"); i++) {
				ListTableGranteesResponse.ListTableGrantees_GranteeItem granteeItem = new ListTableGranteesResponse.ListTableGrantees_GranteeItem();
				granteeItem.GranteeTypeDescription = _ctx.StringValue("ListTableGrantees.Grantee["+ i +"].GranteeTypeDescription");
				granteeItem.GranteeName = _ctx.StringValue("ListTableGrantees.Grantee["+ i +"].GranteeName");
				granteeItem.GranteeId = _ctx.StringValue("ListTableGrantees.Grantee["+ i +"].GranteeId");

				List<string> granteeItem_actions = new List<string>();
				for (int j = 0; j < _ctx.Length("ListTableGrantees.Grantee["+ i +"].Actions.Length"); j++) {
					granteeItem_actions.Add(_ctx.StringValue("ListTableGrantees.Grantee["+ i +"].Actions["+ j +"]"));
				}
				granteeItem.Actions = granteeItem_actions;

				listTableGranteesResponse_grantee.Add(granteeItem);
			}
			listTableGranteesResponse.Grantee = listTableGranteesResponse_grantee;
        
			return listTableGranteesResponse;
        }
    }
}
