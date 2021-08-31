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
    public class ListChildrenStacksResponseUnmarshaller
    {
        public static ListChildrenStacksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListChildrenStacksResponse listChildrenStacksResponse = new ListChildrenStacksResponse();

			listChildrenStacksResponse.HttpResponse = _ctx.HttpResponse;
			listChildrenStacksResponse.RequestId = _ctx.StringValue("ListChildrenStacks.RequestId");
			listChildrenStacksResponse.Code = _ctx.IntegerValue("ListChildrenStacks.Code");
			listChildrenStacksResponse.Message = _ctx.StringValue("ListChildrenStacks.Message");

			ListChildrenStacksResponse.ListChildrenStacks_Data data = new ListChildrenStacksResponse.ListChildrenStacks_Data();
			data.PageSize = _ctx.IntegerValue("ListChildrenStacks.Data.PageSize");
			data.TotalSize = _ctx.IntegerValue("ListChildrenStacks.Data.TotalSize");
			data.CurrentPage = _ctx.IntegerValue("ListChildrenStacks.Data.CurrentPage");

			List<ListChildrenStacksResponse.ListChildrenStacks_Data.ListChildrenStacks_Stack> data_result = new List<ListChildrenStacksResponse.ListChildrenStacks_Data.ListChildrenStacks_Stack>();
			for (int i = 0; i < _ctx.Length("ListChildrenStacks.Data.Result.Length"); i++) {
				ListChildrenStacksResponse.ListChildrenStacks_Data.ListChildrenStacks_Stack stack = new ListChildrenStacksResponse.ListChildrenStacks_Data.ListChildrenStacks_Stack();
				stack.Id = _ctx.LongValue("ListChildrenStacks.Data.Result["+ i +"].Id");
				stack.Name = _ctx.StringValue("ListChildrenStacks.Data.Result["+ i +"].Name");
				stack.Comment = _ctx.StringValue("ListChildrenStacks.Data.Result["+ i +"].Comment");
				stack.Preferred = _ctx.BooleanValue("ListChildrenStacks.Data.Result["+ i +"].Preferred");
				stack.Latest = _ctx.BooleanValue("ListChildrenStacks.Data.Result["+ i +"].Latest");

				List<string> stack_buildTypes = new List<string>();
				for (int j = 0; j < _ctx.Length("ListChildrenStacks.Data.Result["+ i +"].BuildTypes.Length"); j++) {
					stack_buildTypes.Add(_ctx.StringValue("ListChildrenStacks.Data.Result["+ i +"].BuildTypes["+ j +"]"));
				}
				stack.BuildTypes = stack_buildTypes;

				data_result.Add(stack);
			}
			data.Result = data_result;
			listChildrenStacksResponse.Data = data;
        
			return listChildrenStacksResponse;
        }
    }
}
