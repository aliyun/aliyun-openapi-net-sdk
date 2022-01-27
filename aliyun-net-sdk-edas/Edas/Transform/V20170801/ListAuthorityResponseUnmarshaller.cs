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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class ListAuthorityResponseUnmarshaller
    {
        public static ListAuthorityResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAuthorityResponse listAuthorityResponse = new ListAuthorityResponse();

			listAuthorityResponse.HttpResponse = _ctx.HttpResponse;
			listAuthorityResponse.Code = _ctx.IntegerValue("ListAuthority.Code");
			listAuthorityResponse.Message = _ctx.StringValue("ListAuthority.Message");
			listAuthorityResponse.RequestId = _ctx.StringValue("ListAuthority.RequestId");

			List<ListAuthorityResponse.ListAuthority_Authority> listAuthorityResponse_authorityList = new List<ListAuthorityResponse.ListAuthority_Authority>();
			for (int i = 0; i < _ctx.Length("ListAuthority.AuthorityList.Length"); i++) {
				ListAuthorityResponse.ListAuthority_Authority authority = new ListAuthorityResponse.ListAuthority_Authority();
				authority.GroupId = _ctx.StringValue("ListAuthority.AuthorityList["+ i +"].GroupId");
				authority.Name = _ctx.StringValue("ListAuthority.AuthorityList["+ i +"].Name");
				authority.Description = _ctx.StringValue("ListAuthority.AuthorityList["+ i +"].Description");

				List<ListAuthorityResponse.ListAuthority_Authority.ListAuthority_Action> authority_actionList = new List<ListAuthorityResponse.ListAuthority_Authority.ListAuthority_Action>();
				for (int j = 0; j < _ctx.Length("ListAuthority.AuthorityList["+ i +"].ActionList.Length"); j++) {
					ListAuthorityResponse.ListAuthority_Authority.ListAuthority_Action action = new ListAuthorityResponse.ListAuthority_Authority.ListAuthority_Action();
					action.GroupId = _ctx.StringValue("ListAuthority.AuthorityList["+ i +"].ActionList["+ j +"].GroupId");
					action.Code = _ctx.StringValue("ListAuthority.AuthorityList["+ i +"].ActionList["+ j +"].Code");
					action.Name = _ctx.StringValue("ListAuthority.AuthorityList["+ i +"].ActionList["+ j +"].Name");
					action.Description = _ctx.StringValue("ListAuthority.AuthorityList["+ i +"].ActionList["+ j +"].Description");

					authority_actionList.Add(action);
				}
				authority.ActionList = authority_actionList;

				listAuthorityResponse_authorityList.Add(authority);
			}
			listAuthorityResponse.AuthorityList = listAuthorityResponse_authorityList;
        
			return listAuthorityResponse;
        }
    }
}
