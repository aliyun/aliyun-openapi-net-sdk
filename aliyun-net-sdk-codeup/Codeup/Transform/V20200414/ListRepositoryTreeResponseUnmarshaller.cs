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
        public static ListRepositoryTreeResponse Unmarshall(UnmarshallerContext context)
        {
			ListRepositoryTreeResponse listRepositoryTreeResponse = new ListRepositoryTreeResponse();

			listRepositoryTreeResponse.HttpResponse = context.HttpResponse;
			listRepositoryTreeResponse.RequestId = context.StringValue("ListRepositoryTree.RequestId");
			listRepositoryTreeResponse.ErrorCode = context.StringValue("ListRepositoryTree.ErrorCode");
			listRepositoryTreeResponse.Success = context.BooleanValue("ListRepositoryTree.Success");
			listRepositoryTreeResponse.ErrorMessage = context.StringValue("ListRepositoryTree.ErrorMessage");

			List<ListRepositoryTreeResponse.ListRepositoryTree_ResultItem> listRepositoryTreeResponse_result = new List<ListRepositoryTreeResponse.ListRepositoryTree_ResultItem>();
			for (int i = 0; i < context.Length("ListRepositoryTree.Result.Length"); i++) {
				ListRepositoryTreeResponse.ListRepositoryTree_ResultItem resultItem = new ListRepositoryTreeResponse.ListRepositoryTree_ResultItem();
				resultItem.Path = context.StringValue("ListRepositoryTree.Result["+ i +"].Path");
				resultItem.Id = context.StringValue("ListRepositoryTree.Result["+ i +"].Id");
				resultItem.Name = context.StringValue("ListRepositoryTree.Result["+ i +"].Name");
				resultItem.Mode = context.StringValue("ListRepositoryTree.Result["+ i +"].Mode");
				resultItem.Type = context.StringValue("ListRepositoryTree.Result["+ i +"].Type");

				listRepositoryTreeResponse_result.Add(resultItem);
			}
			listRepositoryTreeResponse.Result = listRepositoryTreeResponse_result;
        
			return listRepositoryTreeResponse;
        }
    }
}
