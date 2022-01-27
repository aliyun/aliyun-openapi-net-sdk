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
    public class ListComponentsResponseUnmarshaller
    {
        public static ListComponentsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListComponentsResponse listComponentsResponse = new ListComponentsResponse();

			listComponentsResponse.HttpResponse = _ctx.HttpResponse;
			listComponentsResponse.Code = _ctx.IntegerValue("ListComponents.Code");
			listComponentsResponse.Message = _ctx.StringValue("ListComponents.Message");

			List<ListComponentsResponse.ListComponents_Component> listComponentsResponse_componentList = new List<ListComponentsResponse.ListComponents_Component>();
			for (int i = 0; i < _ctx.Length("ListComponents.ComponentList.Length"); i++) {
				ListComponentsResponse.ListComponents_Component component = new ListComponentsResponse.ListComponents_Component();
				component.ComponentId = _ctx.StringValue("ListComponents.ComponentList["+ i +"].ComponentId");
				component.Type = _ctx.StringValue("ListComponents.ComponentList["+ i +"].Type");
				component.Version = _ctx.StringValue("ListComponents.ComponentList["+ i +"].Version");
				component.Expired = _ctx.BooleanValue("ListComponents.ComponentList["+ i +"].Expired");
				component.ComponentKey = _ctx.StringValue("ListComponents.ComponentList["+ i +"].ComponentKey");
				component.Desc = _ctx.StringValue("ListComponents.ComponentList["+ i +"].Desc");

				listComponentsResponse_componentList.Add(component);
			}
			listComponentsResponse.ComponentList = listComponentsResponse_componentList;
        
			return listComponentsResponse;
        }
    }
}
