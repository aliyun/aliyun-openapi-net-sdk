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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListStackResponseUnmarshaller
    {
        public static ListStackResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListStackResponse listStackResponse = new ListStackResponse();

			listStackResponse.HttpResponse = _ctx.HttpResponse;
			listStackResponse.RequestId = _ctx.StringValue("ListStack.RequestId");
			listStackResponse.PageNumber = _ctx.IntegerValue("ListStack.PageNumber");
			listStackResponse.PageSize = _ctx.IntegerValue("ListStack.PageSize");
			listStackResponse.TotalCount = _ctx.IntegerValue("ListStack.TotalCount");

			List<ListStackResponse.ListStack_Stack> listStackResponse_stackList = new List<ListStackResponse.ListStack_Stack>();
			for (int i = 0; i < _ctx.Length("ListStack.StackList.Length"); i++) {
				ListStackResponse.ListStack_Stack stack = new ListStackResponse.ListStack_Stack();
				stack.Name = _ctx.StringValue("ListStack.StackList["+ i +"].Name");
				stack.Version = _ctx.StringValue("ListStack.StackList["+ i +"].Version");
				stack.Status = _ctx.StringValue("ListStack.StackList["+ i +"].Status");

				listStackResponse_stackList.Add(stack);
			}
			listStackResponse.StackList = listStackResponse_stackList;
        
			return listStackResponse;
        }
    }
}
