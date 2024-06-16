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
    public class ListExchangeUpStreamBindingsResponseUnmarshaller
    {
        public static ListExchangeUpStreamBindingsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListExchangeUpStreamBindingsResponse listExchangeUpStreamBindingsResponse = new ListExchangeUpStreamBindingsResponse();

			listExchangeUpStreamBindingsResponse.HttpResponse = _ctx.HttpResponse;
			listExchangeUpStreamBindingsResponse.Code = _ctx.IntegerValue("ListExchangeUpStreamBindings.Code");
			listExchangeUpStreamBindingsResponse.Message = _ctx.StringValue("ListExchangeUpStreamBindings.Message");
			listExchangeUpStreamBindingsResponse.RequestId = _ctx.StringValue("ListExchangeUpStreamBindings.RequestId");
			listExchangeUpStreamBindingsResponse.Success = _ctx.BooleanValue("ListExchangeUpStreamBindings.Success");

			ListExchangeUpStreamBindingsResponse.ListExchangeUpStreamBindings_Data data = new ListExchangeUpStreamBindingsResponse.ListExchangeUpStreamBindings_Data();
			data.MaxResults = _ctx.IntegerValue("ListExchangeUpStreamBindings.Data.MaxResults");
			data.NextToken = _ctx.StringValue("ListExchangeUpStreamBindings.Data.NextToken");

			List<ListExchangeUpStreamBindingsResponse.ListExchangeUpStreamBindings_Data.ListExchangeUpStreamBindings_BindingVO> data_bindings = new List<ListExchangeUpStreamBindingsResponse.ListExchangeUpStreamBindings_Data.ListExchangeUpStreamBindings_BindingVO>();
			for (int i = 0; i < _ctx.Length("ListExchangeUpStreamBindings.Data.Bindings.Length"); i++) {
				ListExchangeUpStreamBindingsResponse.ListExchangeUpStreamBindings_Data.ListExchangeUpStreamBindings_BindingVO bindingVO = new ListExchangeUpStreamBindingsResponse.ListExchangeUpStreamBindings_Data.ListExchangeUpStreamBindings_BindingVO();
				bindingVO.SourceExchange = _ctx.StringValue("ListExchangeUpStreamBindings.Data.Bindings["+ i +"].SourceExchange");
				bindingVO.Argument = _ctx.StringValue("ListExchangeUpStreamBindings.Data.Bindings["+ i +"].Argument");
				bindingVO.BindingKey = _ctx.StringValue("ListExchangeUpStreamBindings.Data.Bindings["+ i +"].BindingKey");
				bindingVO.BindingType = _ctx.StringValue("ListExchangeUpStreamBindings.Data.Bindings["+ i +"].BindingType");
				bindingVO.DestinationName = _ctx.StringValue("ListExchangeUpStreamBindings.Data.Bindings["+ i +"].DestinationName");

				data_bindings.Add(bindingVO);
			}
			data.Bindings = data_bindings;
			listExchangeUpStreamBindingsResponse.Data = data;
        
			return listExchangeUpStreamBindingsResponse;
        }
    }
}
