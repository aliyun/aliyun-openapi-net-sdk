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
        public static ListGroupRepositoriesResponse Unmarshall(UnmarshallerContext context)
        {
			ListGroupRepositoriesResponse listGroupRepositoriesResponse = new ListGroupRepositoriesResponse();

			listGroupRepositoriesResponse.HttpResponse = context.HttpResponse;
			listGroupRepositoriesResponse.RequestId = context.StringValue("ListGroupRepositories.RequestId");
			listGroupRepositoriesResponse.ErrorCode = context.StringValue("ListGroupRepositories.ErrorCode");
			listGroupRepositoriesResponse.Success = context.BooleanValue("ListGroupRepositories.Success");
			listGroupRepositoriesResponse.ErrorMessage = context.StringValue("ListGroupRepositories.ErrorMessage");
			listGroupRepositoriesResponse.Total = context.LongValue("ListGroupRepositories.Total");

			List<ListGroupRepositoriesResponse.ListGroupRepositories_ResultItem> listGroupRepositoriesResponse_result = new List<ListGroupRepositoriesResponse.ListGroupRepositories_ResultItem>();
			for (int i = 0; i < context.Length("ListGroupRepositories.Result.Length"); i++) {
				ListGroupRepositoriesResponse.ListGroupRepositories_ResultItem resultItem = new ListGroupRepositoriesResponse.ListGroupRepositories_ResultItem();
				resultItem.Archive = context.BooleanValue("ListGroupRepositories.Result["+ i +"].Archive");
				resultItem.CreatedAt = context.StringValue("ListGroupRepositories.Result["+ i +"].CreatedAt");
				resultItem.UpdatedAt = context.StringValue("ListGroupRepositories.Result["+ i +"].UpdatedAt");
				resultItem.LastActivityAt = context.StringValue("ListGroupRepositories.Result["+ i +"].LastActivityAt");
				resultItem.Id = context.LongValue("ListGroupRepositories.Result["+ i +"].Id");
				resultItem.CreatorId = context.LongValue("ListGroupRepositories.Result["+ i +"].CreatorId");
				resultItem.Name = context.StringValue("ListGroupRepositories.Result["+ i +"].Name");
				resultItem.NameWithNamespace = context.StringValue("ListGroupRepositories.Result["+ i +"].NameWithNamespace");
				resultItem.Path = context.StringValue("ListGroupRepositories.Result["+ i +"].Path");
				resultItem.PathWithNamespace = context.StringValue("ListGroupRepositories.Result["+ i +"].PathWithNamespace");
				resultItem.NamespaceId = context.LongValue("ListGroupRepositories.Result["+ i +"].NamespaceId");
				resultItem.HttpCloneUrl = context.StringValue("ListGroupRepositories.Result["+ i +"].HttpCloneUrl");
				resultItem.SshCloneUrl = context.StringValue("ListGroupRepositories.Result["+ i +"].SshCloneUrl");
				resultItem.VisibilityLevel = context.IntegerValue("ListGroupRepositories.Result["+ i +"].VisibilityLevel");
				resultItem.WebUrl = context.StringValue("ListGroupRepositories.Result["+ i +"].WebUrl");
				resultItem.ImportStatus = context.StringValue("ListGroupRepositories.Result["+ i +"].ImportStatus");

				listGroupRepositoriesResponse_result.Add(resultItem);
			}
			listGroupRepositoriesResponse.Result = listGroupRepositoriesResponse_result;
        
			return listGroupRepositoriesResponse;
        }
    }
}
