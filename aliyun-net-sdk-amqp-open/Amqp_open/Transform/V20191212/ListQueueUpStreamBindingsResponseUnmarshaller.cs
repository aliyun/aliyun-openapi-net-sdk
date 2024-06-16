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
    public class ListQueueUpStreamBindingsResponseUnmarshaller
    {
        public static ListQueueUpStreamBindingsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListQueueUpStreamBindingsResponse listQueueUpStreamBindingsResponse = new ListQueueUpStreamBindingsResponse();

			listQueueUpStreamBindingsResponse.HttpResponse = _ctx.HttpResponse;
			listQueueUpStreamBindingsResponse.RequestId = _ctx.StringValue("ListQueueUpStreamBindings.RequestId");

			ListQueueUpStreamBindingsResponse.ListQueueUpStreamBindings_Data data = new ListQueueUpStreamBindingsResponse.ListQueueUpStreamBindings_Data();
			data.MaxResults = _ctx.StringValue("ListQueueUpStreamBindings.Data.MaxResults");
			data.NextToken = _ctx.StringValue("ListQueueUpStreamBindings.Data.NextToken");

			List<ListQueueUpStreamBindingsResponse.ListQueueUpStreamBindings_Data.ListQueueUpStreamBindings_BindingVO> data_bindings = new List<ListQueueUpStreamBindingsResponse.ListQueueUpStreamBindings_Data.ListQueueUpStreamBindings_BindingVO>();
			for (int i = 0; i < _ctx.Length("ListQueueUpStreamBindings.Data.Bindings.Length"); i++) {
				ListQueueUpStreamBindingsResponse.ListQueueUpStreamBindings_Data.ListQueueUpStreamBindings_BindingVO bindingVO = new ListQueueUpStreamBindingsResponse.ListQueueUpStreamBindings_Data.ListQueueUpStreamBindings_BindingVO();
				bindingVO.SourceExchange = _ctx.StringValue("ListQueueUpStreamBindings.Data.Bindings["+ i +"].SourceExchange");
				bindingVO.Argument = _ctx.StringValue("ListQueueUpStreamBindings.Data.Bindings["+ i +"].Argument");
				bindingVO.BindingKey = _ctx.StringValue("ListQueueUpStreamBindings.Data.Bindings["+ i +"].BindingKey");
				bindingVO.BindingType = _ctx.StringValue("ListQueueUpStreamBindings.Data.Bindings["+ i +"].BindingType");
				bindingVO.DestinationName = _ctx.StringValue("ListQueueUpStreamBindings.Data.Bindings["+ i +"].DestinationName");

				data_bindings.Add(bindingVO);
			}
			data.Bindings = data_bindings;
			listQueueUpStreamBindingsResponse.Data = data;
        
			return listQueueUpStreamBindingsResponse;
        }
    }
}
