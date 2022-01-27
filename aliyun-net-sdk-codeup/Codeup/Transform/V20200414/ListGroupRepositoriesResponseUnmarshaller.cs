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
    public class ListGroupRepositoriesResponseUnmarshaller
    {
        public static ListGroupRepositoriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListGroupRepositoriesResponse listGroupRepositoriesResponse = new ListGroupRepositoriesResponse();

			listGroupRepositoriesResponse.HttpResponse = _ctx.HttpResponse;
			listGroupRepositoriesResponse.RequestId = _ctx.StringValue("ListGroupRepositories.RequestId");
			listGroupRepositoriesResponse.ErrorCode = _ctx.StringValue("ListGroupRepositories.ErrorCode");
			listGroupRepositoriesResponse.Success = _ctx.BooleanValue("ListGroupRepositories.Success");
			listGroupRepositoriesResponse.ErrorMessage = _ctx.StringValue("ListGroupRepositories.ErrorMessage");
			listGroupRepositoriesResponse.Total = _ctx.LongValue("ListGroupRepositories.Total");

			List<ListGroupRepositoriesResponse.ListGroupRepositories_ResultItem> listGroupRepositoriesResponse_result = new List<ListGroupRepositoriesResponse.ListGroupRepositories_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListGroupRepositories.Result.Length"); i++) {
				ListGroupRepositoriesResponse.ListGroupRepositories_ResultItem resultItem = new ListGroupRepositoriesResponse.ListGroupRepositories_ResultItem();
				resultItem.Archive = _ctx.BooleanValue("ListGroupRepositories.Result["+ i +"].Archive");
				resultItem.CreatedAt = _ctx.StringValue("ListGroupRepositories.Result["+ i +"].CreatedAt");
				resultItem.UpdatedAt = _ctx.StringValue("ListGroupRepositories.Result["+ i +"].UpdatedAt");
				resultItem.LastActivityAt = _ctx.StringValue("ListGroupRepositories.Result["+ i +"].LastActivityAt");
				resultItem.Id = _ctx.LongValue("ListGroupRepositories.Result["+ i +"].Id");
				resultItem.CreatorId = _ctx.LongValue("ListGroupRepositories.Result["+ i +"].CreatorId");
				resultItem.Name = _ctx.StringValue("ListGroupRepositories.Result["+ i +"].Name");
				resultItem.NameWithNamespace = _ctx.StringValue("ListGroupRepositories.Result["+ i +"].NameWithNamespace");
				resultItem.Path = _ctx.StringValue("ListGroupRepositories.Result["+ i +"].Path");
				resultItem.PathWithNamespace = _ctx.StringValue("ListGroupRepositories.Result["+ i +"].PathWithNamespace");
				resultItem.NamespaceId = _ctx.LongValue("ListGroupRepositories.Result["+ i +"].NamespaceId");
				resultItem.HttpCloneUrl = _ctx.StringValue("ListGroupRepositories.Result["+ i +"].HttpCloneUrl");
				resultItem.SshCloneUrl = _ctx.StringValue("ListGroupRepositories.Result["+ i +"].SshCloneUrl");
				resultItem.VisibilityLevel = _ctx.IntegerValue("ListGroupRepositories.Result["+ i +"].VisibilityLevel");
				resultItem.WebUrl = _ctx.StringValue("ListGroupRepositories.Result["+ i +"].WebUrl");
				resultItem.ImportStatus = _ctx.StringValue("ListGroupRepositories.Result["+ i +"].ImportStatus");

				listGroupRepositoriesResponse_result.Add(resultItem);
			}
			listGroupRepositoriesResponse.Result = listGroupRepositoriesResponse_result;
        
			return listGroupRepositoriesResponse;
        }
    }
}
