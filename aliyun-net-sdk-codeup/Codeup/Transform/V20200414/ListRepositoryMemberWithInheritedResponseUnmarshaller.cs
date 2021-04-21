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
using Aliyun.Acs.codeup.Model.V20200414;

namespace Aliyun.Acs.codeup.Transform.V20200414
{
    public class ListRepositoryMemberWithInheritedResponseUnmarshaller
    {
        public static ListRepositoryMemberWithInheritedResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRepositoryMemberWithInheritedResponse listRepositoryMemberWithInheritedResponse = new ListRepositoryMemberWithInheritedResponse();

			listRepositoryMemberWithInheritedResponse.HttpResponse = _ctx.HttpResponse;
			listRepositoryMemberWithInheritedResponse.RequestId = _ctx.StringValue("ListRepositoryMemberWithInherited.RequestId");
			listRepositoryMemberWithInheritedResponse.ErrorCode = _ctx.StringValue("ListRepositoryMemberWithInherited.ErrorCode");
			listRepositoryMemberWithInheritedResponse.Success = _ctx.BooleanValue("ListRepositoryMemberWithInherited.Success");
			listRepositoryMemberWithInheritedResponse.ErrorMessage = _ctx.StringValue("ListRepositoryMemberWithInherited.ErrorMessage");

			List<ListRepositoryMemberWithInheritedResponse.ListRepositoryMemberWithInherited_ResultItem> listRepositoryMemberWithInheritedResponse_result = new List<ListRepositoryMemberWithInheritedResponse.ListRepositoryMemberWithInherited_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListRepositoryMemberWithInherited.Result.Length"); i++) {
				ListRepositoryMemberWithInheritedResponse.ListRepositoryMemberWithInherited_ResultItem resultItem = new ListRepositoryMemberWithInheritedResponse.ListRepositoryMemberWithInherited_ResultItem();
				resultItem.AccessLevel = _ctx.IntegerValue("ListRepositoryMemberWithInherited.Result["+ i +"].AccessLevel");
				resultItem.ExternUserId = _ctx.StringValue("ListRepositoryMemberWithInherited.Result["+ i +"].ExternUserId");
				resultItem.Id = _ctx.LongValue("ListRepositoryMemberWithInherited.Result["+ i +"].Id");
				resultItem.State = _ctx.StringValue("ListRepositoryMemberWithInherited.Result["+ i +"].State");
				resultItem.AvatarUrl = _ctx.StringValue("ListRepositoryMemberWithInherited.Result["+ i +"].AvatarUrl");
				resultItem.Email = _ctx.StringValue("ListRepositoryMemberWithInherited.Result["+ i +"].Email");
				resultItem.Name = _ctx.StringValue("ListRepositoryMemberWithInherited.Result["+ i +"].Name");
				resultItem.Username = _ctx.StringValue("ListRepositoryMemberWithInherited.Result["+ i +"].Username");

				ListRepositoryMemberWithInheritedResponse.ListRepositoryMemberWithInherited_ResultItem.ListRepositoryMemberWithInherited_Inherited inherited = new ListRepositoryMemberWithInheritedResponse.ListRepositoryMemberWithInherited_ResultItem.ListRepositoryMemberWithInherited_Inherited();
				inherited.Id = _ctx.LongValue("ListRepositoryMemberWithInherited.Result["+ i +"].Inherited.Id");
				inherited.Name = _ctx.StringValue("ListRepositoryMemberWithInherited.Result["+ i +"].Inherited.Name");
				inherited.Path = _ctx.StringValue("ListRepositoryMemberWithInherited.Result["+ i +"].Inherited.Path");
				inherited.NameWithNamespace = _ctx.StringValue("ListRepositoryMemberWithInherited.Result["+ i +"].Inherited.NameWithNamespace");
				inherited.PathWithNamespace = _ctx.StringValue("ListRepositoryMemberWithInherited.Result["+ i +"].Inherited.PathWithNamespace");
				inherited.Type = _ctx.StringValue("ListRepositoryMemberWithInherited.Result["+ i +"].Inherited.Type");
				inherited.VisibilityLevel = _ctx.StringValue("ListRepositoryMemberWithInherited.Result["+ i +"].Inherited.VisibilityLevel");
				resultItem.Inherited = inherited;

				listRepositoryMemberWithInheritedResponse_result.Add(resultItem);
			}
			listRepositoryMemberWithInheritedResponse.Result = listRepositoryMemberWithInheritedResponse_result;
        
			return listRepositoryMemberWithInheritedResponse;
        }
    }
}
