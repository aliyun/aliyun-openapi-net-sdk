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
    public class ListRootStacksResponseUnmarshaller
    {
        public static ListRootStacksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRootStacksResponse listRootStacksResponse = new ListRootStacksResponse();

			listRootStacksResponse.HttpResponse = _ctx.HttpResponse;
			listRootStacksResponse.RequestId = _ctx.StringValue("ListRootStacks.RequestId");
			listRootStacksResponse.Message = _ctx.StringValue("ListRootStacks.Message");
			listRootStacksResponse.Code = _ctx.IntegerValue("ListRootStacks.Code");

			ListRootStacksResponse.ListRootStacks_Data data = new ListRootStacksResponse.ListRootStacks_Data();
			data.CurrentPage = _ctx.IntegerValue("ListRootStacks.Data.CurrentPage");
			data.PageSize = _ctx.IntegerValue("ListRootStacks.Data.PageSize");
			data.TotalSize = _ctx.IntegerValue("ListRootStacks.Data.TotalSize");

			List<ListRootStacksResponse.ListRootStacks_Data.ListRootStacks_RootStack> data_result = new List<ListRootStacksResponse.ListRootStacks_Data.ListRootStacks_RootStack>();
			for (int i = 0; i < _ctx.Length("ListRootStacks.Data.Result.Length"); i++) {
				ListRootStacksResponse.ListRootStacks_Data.ListRootStacks_RootStack rootStack = new ListRootStacksResponse.ListRootStacks_Data.ListRootStacks_RootStack();

				ListRootStacksResponse.ListRootStacks_Data.ListRootStacks_RootStack.ListRootStacks_Root root = new ListRootStacksResponse.ListRootStacks_Data.ListRootStacks_RootStack.ListRootStacks_Root();
				root.Id = _ctx.LongValue("ListRootStacks.Data.Result["+ i +"].Root.Id");
				root.Name = _ctx.StringValue("ListRootStacks.Data.Result["+ i +"].Root.Name");
				rootStack.Root = root;

				List<ListRootStacksResponse.ListRootStacks_Data.ListRootStacks_RootStack.ListRootStacks_ChildStack> rootStack_children = new List<ListRootStacksResponse.ListRootStacks_Data.ListRootStacks_RootStack.ListRootStacks_ChildStack>();
				for (int j = 0; j < _ctx.Length("ListRootStacks.Data.Result["+ i +"].Children.Length"); j++) {
					ListRootStacksResponse.ListRootStacks_Data.ListRootStacks_RootStack.ListRootStacks_ChildStack childStack = new ListRootStacksResponse.ListRootStacks_Data.ListRootStacks_RootStack.ListRootStacks_ChildStack();
					childStack.Id = _ctx.LongValue("ListRootStacks.Data.Result["+ i +"].Children["+ j +"].Id");
					childStack.Name = _ctx.StringValue("ListRootStacks.Data.Result["+ i +"].Children["+ j +"].Name");
					childStack.Icon = _ctx.StringValue("ListRootStacks.Data.Result["+ i +"].Children["+ j +"].Icon");
					childStack.Comment = _ctx.StringValue("ListRootStacks.Data.Result["+ i +"].Children["+ j +"].Comment");

					rootStack_children.Add(childStack);
				}
				rootStack.Children = rootStack_children;

				data_result.Add(rootStack);
			}
			data.Result = data_result;
			listRootStacksResponse.Data = data;
        
			return listRootStacksResponse;
        }
    }
}
