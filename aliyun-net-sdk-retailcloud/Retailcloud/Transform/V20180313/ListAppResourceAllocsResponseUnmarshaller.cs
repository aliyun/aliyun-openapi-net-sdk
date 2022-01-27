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
    public class ListAppResourceAllocsResponseUnmarshaller
    {
        public static ListAppResourceAllocsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAppResourceAllocsResponse listAppResourceAllocsResponse = new ListAppResourceAllocsResponse();

			listAppResourceAllocsResponse.HttpResponse = _ctx.HttpResponse;
			listAppResourceAllocsResponse.Code = _ctx.IntegerValue("ListAppResourceAllocs.Code");
			listAppResourceAllocsResponse.ErrorMsg = _ctx.StringValue("ListAppResourceAllocs.ErrorMsg");
			listAppResourceAllocsResponse.PageNumber = _ctx.IntegerValue("ListAppResourceAllocs.PageNumber");
			listAppResourceAllocsResponse.PageSize = _ctx.IntegerValue("ListAppResourceAllocs.PageSize");
			listAppResourceAllocsResponse.RequestId = _ctx.StringValue("ListAppResourceAllocs.RequestId");
			listAppResourceAllocsResponse.TotalCount = _ctx.LongValue("ListAppResourceAllocs.TotalCount");

			List<ListAppResourceAllocsResponse.ListAppResourceAllocs_ListAppResourceAllocResponse> listAppResourceAllocsResponse_data = new List<ListAppResourceAllocsResponse.ListAppResourceAllocs_ListAppResourceAllocResponse>();
			for (int i = 0; i < _ctx.Length("ListAppResourceAllocs.Data.Length"); i++) {
				ListAppResourceAllocsResponse.ListAppResourceAllocs_ListAppResourceAllocResponse listAppResourceAllocResponse = new ListAppResourceAllocsResponse.ListAppResourceAllocs_ListAppResourceAllocResponse();
				listAppResourceAllocResponse.AppEnvId = _ctx.LongValue("ListAppResourceAllocs.Data["+ i +"].AppEnvId");
				listAppResourceAllocResponse.AppId = _ctx.LongValue("ListAppResourceAllocs.Data["+ i +"].AppId");
				listAppResourceAllocResponse.ClusterId = _ctx.StringValue("ListAppResourceAllocs.Data["+ i +"].ClusterId");
				listAppResourceAllocResponse.Id = _ctx.LongValue("ListAppResourceAllocs.Data["+ i +"].Id");
				listAppResourceAllocResponse.ResourceDef = _ctx.StringValue("ListAppResourceAllocs.Data["+ i +"].ResourceDef");

				listAppResourceAllocsResponse_data.Add(listAppResourceAllocResponse);
			}
			listAppResourceAllocsResponse.Data = listAppResourceAllocsResponse_data;
        
			return listAppResourceAllocsResponse;
        }
    }
}
