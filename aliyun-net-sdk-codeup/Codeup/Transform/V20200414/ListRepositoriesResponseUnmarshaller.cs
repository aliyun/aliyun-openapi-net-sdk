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
    public class ListRepositoriesResponseUnmarshaller
    {
        public static ListRepositoriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRepositoriesResponse listRepositoriesResponse = new ListRepositoriesResponse();

			listRepositoriesResponse.HttpResponse = _ctx.HttpResponse;
			listRepositoriesResponse.ErrorCode = _ctx.IntegerValue("ListRepositories.ErrorCode");
			listRepositoriesResponse.ErrorMessage = _ctx.StringValue("ListRepositories.ErrorMessage");
			listRepositoriesResponse.RequestId = _ctx.StringValue("ListRepositories.RequestId");
			listRepositoriesResponse.Success = _ctx.BooleanValue("ListRepositories.Success");
			listRepositoriesResponse.Total = _ctx.LongValue("ListRepositories.Total");

			List<ListRepositoriesResponse.ListRepositories_ResultItem> listRepositoriesResponse_result = new List<ListRepositoriesResponse.ListRepositories_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListRepositories.Result.Length"); i++) {
				ListRepositoriesResponse.ListRepositories_ResultItem resultItem = new ListRepositoriesResponse.ListRepositories_ResultItem();
				resultItem.Id = _ctx.LongValue("ListRepositories.Result["+ i +"].Id");
				resultItem.Description = _ctx.StringValue("ListRepositories.Result["+ i +"].Description");
				resultItem.VisibilityLevel = _ctx.StringValue("ListRepositories.Result["+ i +"].VisibilityLevel");
				resultItem.WebUrl = _ctx.StringValue("ListRepositories.Result["+ i +"].WebUrl");
				resultItem.Name = _ctx.StringValue("ListRepositories.Result["+ i +"].Name");
				resultItem.NameWithNamespace = _ctx.StringValue("ListRepositories.Result["+ i +"].NameWithNamespace");
				resultItem.Path = _ctx.StringValue("ListRepositories.Result["+ i +"].Path");
				resultItem.PathWithNamespace = _ctx.StringValue("ListRepositories.Result["+ i +"].PathWithNamespace");
				resultItem.CreatedAt = _ctx.StringValue("ListRepositories.Result["+ i +"].CreatedAt");
				resultItem.LastActivityAt = _ctx.StringValue("ListRepositories.Result["+ i +"].LastActivityAt");
				resultItem.Archive = _ctx.BooleanValue("ListRepositories.Result["+ i +"].Archive");
				resultItem.AvatarUrl = _ctx.StringValue("ListRepositories.Result["+ i +"].AvatarUrl");
				resultItem.DemoProjectStatus = _ctx.BooleanValue("ListRepositories.Result["+ i +"].DemoProjectStatus");
				resultItem.AccessLevel = _ctx.IntegerValue("ListRepositories.Result["+ i +"].AccessLevel");
				resultItem.ImportStatus = _ctx.StringValue("ListRepositories.Result["+ i +"].ImportStatus");
				resultItem.NamespaceId = _ctx.LongValue("ListRepositories.Result["+ i +"].NamespaceId");
				resultItem.UpdatedAt = _ctx.StringValue("ListRepositories.Result["+ i +"].UpdatedAt");
				resultItem.StarCount = _ctx.LongValue("ListRepositories.Result["+ i +"].StarCount");
				resultItem.Star = _ctx.BooleanValue("ListRepositories.Result["+ i +"].Star");

				listRepositoriesResponse_result.Add(resultItem);
			}
			listRepositoriesResponse.Result = listRepositoriesResponse_result;
        
			return listRepositoriesResponse;
        }
    }
}
