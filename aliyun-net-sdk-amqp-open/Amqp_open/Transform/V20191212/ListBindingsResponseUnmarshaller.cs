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
    public class ListBindingsResponseUnmarshaller
    {
        public static ListBindingsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListBindingsResponse listBindingsResponse = new ListBindingsResponse();

			listBindingsResponse.HttpResponse = _ctx.HttpResponse;
			listBindingsResponse.RequestId = _ctx.StringValue("ListBindings.RequestId");

			ListBindingsResponse.ListBindings_Data data = new ListBindingsResponse.ListBindings_Data();
			data.MaxResults = _ctx.IntegerValue("ListBindings.Data.MaxResults");
			data.NextToken = _ctx.StringValue("ListBindings.Data.NextToken");

			List<ListBindingsResponse.ListBindings_Data.ListBindings_BindingDO> data_bindings = new List<ListBindingsResponse.ListBindings_Data.ListBindings_BindingDO>();
			for (int i = 0; i < _ctx.Length("ListBindings.Data.Bindings.Length"); i++) {
				ListBindingsResponse.ListBindings_Data.ListBindings_BindingDO bindingDO = new ListBindingsResponse.ListBindings_Data.ListBindings_BindingDO();
				bindingDO.SourceExchange = _ctx.StringValue("ListBindings.Data.Bindings["+ i +"].SourceExchange");
				bindingDO.Argument = _ctx.StringValue("ListBindings.Data.Bindings["+ i +"].Argument");
				bindingDO.BindingKey = _ctx.StringValue("ListBindings.Data.Bindings["+ i +"].BindingKey");
				bindingDO.BindingType = _ctx.StringValue("ListBindings.Data.Bindings["+ i +"].BindingType");
				bindingDO.DestinationName = _ctx.StringValue("ListBindings.Data.Bindings["+ i +"].DestinationName");

				data_bindings.Add(bindingDO);
			}
			data.Bindings = data_bindings;
			listBindingsResponse.Data = data;
        
			return listBindingsResponse;
        }
    }
}
