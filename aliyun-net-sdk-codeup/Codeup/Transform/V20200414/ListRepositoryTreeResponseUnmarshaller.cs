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
    public class ListRepositoryTreeResponseUnmarshaller
    {
        public static ListRepositoryTreeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRepositoryTreeResponse listRepositoryTreeResponse = new ListRepositoryTreeResponse();

			listRepositoryTreeResponse.HttpResponse = _ctx.HttpResponse;
			listRepositoryTreeResponse.RequestId = _ctx.StringValue("ListRepositoryTree.RequestId");
			listRepositoryTreeResponse.ErrorCode = _ctx.StringValue("ListRepositoryTree.ErrorCode");
			listRepositoryTreeResponse.Success = _ctx.BooleanValue("ListRepositoryTree.Success");
			listRepositoryTreeResponse.ErrorMessage = _ctx.StringValue("ListRepositoryTree.ErrorMessage");

			List<ListRepositoryTreeResponse.ListRepositoryTree_ResultItem> listRepositoryTreeResponse_result = new List<ListRepositoryTreeResponse.ListRepositoryTree_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListRepositoryTree.Result.Length"); i++) {
				ListRepositoryTreeResponse.ListRepositoryTree_ResultItem resultItem = new ListRepositoryTreeResponse.ListRepositoryTree_ResultItem();
				resultItem.Path = _ctx.StringValue("ListRepositoryTree.Result["+ i +"].Path");
				resultItem.Id = _ctx.StringValue("ListRepositoryTree.Result["+ i +"].Id");
				resultItem.Name = _ctx.StringValue("ListRepositoryTree.Result["+ i +"].Name");
				resultItem.Mode = _ctx.StringValue("ListRepositoryTree.Result["+ i +"].Mode");
				resultItem.Type = _ctx.StringValue("ListRepositoryTree.Result["+ i +"].Type");

				listRepositoryTreeResponse_result.Add(resultItem);
			}
			listRepositoryTreeResponse.Result = listRepositoryTreeResponse_result;
        
			return listRepositoryTreeResponse;
        }
    }
}
