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
    public class ListAppGroupMappingResponseUnmarshaller
    {
        public static ListAppGroupMappingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAppGroupMappingResponse listAppGroupMappingResponse = new ListAppGroupMappingResponse();

			listAppGroupMappingResponse.HttpResponse = _ctx.HttpResponse;
			listAppGroupMappingResponse.Code = _ctx.IntegerValue("ListAppGroupMapping.Code");
			listAppGroupMappingResponse.PageNumber = _ctx.IntegerValue("ListAppGroupMapping.PageNumber");
			listAppGroupMappingResponse.RequestId = _ctx.StringValue("ListAppGroupMapping.RequestId");
			listAppGroupMappingResponse.PageSize = _ctx.IntegerValue("ListAppGroupMapping.PageSize");
			listAppGroupMappingResponse.TotalCount = _ctx.LongValue("ListAppGroupMapping.TotalCount");
			listAppGroupMappingResponse.ErrorMsg = _ctx.StringValue("ListAppGroupMapping.ErrorMsg");

			List<ListAppGroupMappingResponse.ListAppGroupMapping_AppGroupMappingDetail> listAppGroupMappingResponse_data = new List<ListAppGroupMappingResponse.ListAppGroupMapping_AppGroupMappingDetail>();
			for (int i = 0; i < _ctx.Length("ListAppGroupMapping.Data.Length"); i++) {
				ListAppGroupMappingResponse.ListAppGroupMapping_AppGroupMappingDetail appGroupMappingDetail = new ListAppGroupMappingResponse.ListAppGroupMapping_AppGroupMappingDetail();
				appGroupMappingDetail.Id = _ctx.LongValue("ListAppGroupMapping.Data["+ i +"].Id");
				appGroupMappingDetail.Name = _ctx.StringValue("ListAppGroupMapping.Data["+ i +"].Name");
				appGroupMappingDetail.GroupId = _ctx.LongValue("ListAppGroupMapping.Data["+ i +"].GroupId");
				appGroupMappingDetail.AppId = _ctx.LongValue("ListAppGroupMapping.Data["+ i +"].AppId");

				listAppGroupMappingResponse_data.Add(appGroupMappingDetail);
			}
			listAppGroupMappingResponse.Data = listAppGroupMappingResponse_data;
        
			return listAppGroupMappingResponse;
        }
    }
}
