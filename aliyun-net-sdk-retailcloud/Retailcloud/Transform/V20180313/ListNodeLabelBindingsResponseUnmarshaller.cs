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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class ListNodeLabelBindingsResponseUnmarshaller
    {
        public static ListNodeLabelBindingsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNodeLabelBindingsResponse listNodeLabelBindingsResponse = new ListNodeLabelBindingsResponse();

			listNodeLabelBindingsResponse.HttpResponse = _ctx.HttpResponse;
			listNodeLabelBindingsResponse.Code = _ctx.IntegerValue("ListNodeLabelBindings.Code");
			listNodeLabelBindingsResponse.ErrorMsg = _ctx.StringValue("ListNodeLabelBindings.ErrorMsg");
			listNodeLabelBindingsResponse.PageNumber = _ctx.IntegerValue("ListNodeLabelBindings.PageNumber");
			listNodeLabelBindingsResponse.PageSize = _ctx.IntegerValue("ListNodeLabelBindings.PageSize");
			listNodeLabelBindingsResponse.RequestId = _ctx.StringValue("ListNodeLabelBindings.RequestId");
			listNodeLabelBindingsResponse.TotalCount = _ctx.LongValue("ListNodeLabelBindings.TotalCount");

			List<ListNodeLabelBindingsResponse.ListNodeLabelBindings_ListNodeLabelBindingResponse> listNodeLabelBindingsResponse_data = new List<ListNodeLabelBindingsResponse.ListNodeLabelBindings_ListNodeLabelBindingResponse>();
			for (int i = 0; i < _ctx.Length("ListNodeLabelBindings.Data.Length"); i++) {
				ListNodeLabelBindingsResponse.ListNodeLabelBindings_ListNodeLabelBindingResponse listNodeLabelBindingResponse = new ListNodeLabelBindingsResponse.ListNodeLabelBindings_ListNodeLabelBindingResponse();
				listNodeLabelBindingResponse.Id = _ctx.LongValue("ListNodeLabelBindings.Data["+ i +"].Id");
				listNodeLabelBindingResponse.InstanceId = _ctx.StringValue("ListNodeLabelBindings.Data["+ i +"].InstanceId");
				listNodeLabelBindingResponse.InstanceType = _ctx.StringValue("ListNodeLabelBindings.Data["+ i +"].InstanceType");
				listNodeLabelBindingResponse.LabelKey = _ctx.StringValue("ListNodeLabelBindings.Data["+ i +"].LabelKey");
				listNodeLabelBindingResponse.LabelValue = _ctx.StringValue("ListNodeLabelBindings.Data["+ i +"].LabelValue");

				listNodeLabelBindingsResponse_data.Add(listNodeLabelBindingResponse);
			}
			listNodeLabelBindingsResponse.Data = listNodeLabelBindingsResponse_data;
        
			return listNodeLabelBindingsResponse;
        }
    }
}
