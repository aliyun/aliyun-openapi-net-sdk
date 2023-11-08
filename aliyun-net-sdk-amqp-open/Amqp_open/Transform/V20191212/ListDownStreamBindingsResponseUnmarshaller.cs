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
using Aliyun.Acs.amqp_open.Model.V20191212;

namespace Aliyun.Acs.amqp_open.Transform.V20191212
{
    public class ListDownStreamBindingsResponseUnmarshaller
    {
        public static ListDownStreamBindingsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDownStreamBindingsResponse listDownStreamBindingsResponse = new ListDownStreamBindingsResponse();

			listDownStreamBindingsResponse.HttpResponse = _ctx.HttpResponse;
			listDownStreamBindingsResponse.Code = _ctx.IntegerValue("ListDownStreamBindings.Code");
			listDownStreamBindingsResponse.Message = _ctx.StringValue("ListDownStreamBindings.Message");
			listDownStreamBindingsResponse.RequestId = _ctx.StringValue("ListDownStreamBindings.RequestId");
			listDownStreamBindingsResponse.Success = _ctx.BooleanValue("ListDownStreamBindings.Success");

			ListDownStreamBindingsResponse.ListDownStreamBindings_Data data = new ListDownStreamBindingsResponse.ListDownStreamBindings_Data();
			data.MaxResults = _ctx.IntegerValue("ListDownStreamBindings.Data.MaxResults");
			data.NextToken = _ctx.StringValue("ListDownStreamBindings.Data.NextToken");

			List<ListDownStreamBindingsResponse.ListDownStreamBindings_Data.ListDownStreamBindings_BindingVO> data_bindings = new List<ListDownStreamBindingsResponse.ListDownStreamBindings_Data.ListDownStreamBindings_BindingVO>();
			for (int i = 0; i < _ctx.Length("ListDownStreamBindings.Data.Bindings.Length"); i++) {
				ListDownStreamBindingsResponse.ListDownStreamBindings_Data.ListDownStreamBindings_BindingVO bindingVO = new ListDownStreamBindingsResponse.ListDownStreamBindings_Data.ListDownStreamBindings_BindingVO();
				bindingVO.SourceExchange = _ctx.StringValue("ListDownStreamBindings.Data.Bindings["+ i +"].SourceExchange");
				bindingVO.Argument = _ctx.StringValue("ListDownStreamBindings.Data.Bindings["+ i +"].Argument");
				bindingVO.BindingKey = _ctx.StringValue("ListDownStreamBindings.Data.Bindings["+ i +"].BindingKey");
				bindingVO.BindingType = _ctx.StringValue("ListDownStreamBindings.Data.Bindings["+ i +"].BindingType");
				bindingVO.DestinationName = _ctx.StringValue("ListDownStreamBindings.Data.Bindings["+ i +"].DestinationName");

				data_bindings.Add(bindingVO);
			}
			data.Bindings = data_bindings;
			listDownStreamBindingsResponse.Data = data;
        
			return listDownStreamBindingsResponse;
        }
    }
}
