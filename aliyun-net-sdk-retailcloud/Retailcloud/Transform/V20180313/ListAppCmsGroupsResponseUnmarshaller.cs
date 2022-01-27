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
    public class ListAppCmsGroupsResponseUnmarshaller
    {
        public static ListAppCmsGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAppCmsGroupsResponse listAppCmsGroupsResponse = new ListAppCmsGroupsResponse();

			listAppCmsGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listAppCmsGroupsResponse.Code = _ctx.IntegerValue("ListAppCmsGroups.Code");
			listAppCmsGroupsResponse.ErrorMsg = _ctx.StringValue("ListAppCmsGroups.ErrorMsg");
			listAppCmsGroupsResponse.PageNumber = _ctx.IntegerValue("ListAppCmsGroups.PageNumber");
			listAppCmsGroupsResponse.PageSize = _ctx.IntegerValue("ListAppCmsGroups.PageSize");
			listAppCmsGroupsResponse.RequestId = _ctx.StringValue("ListAppCmsGroups.RequestId");
			listAppCmsGroupsResponse.TotalCount = _ctx.LongValue("ListAppCmsGroups.TotalCount");

			List<string> listAppCmsGroupsResponse_data = new List<string>();
			for (int i = 0; i < _ctx.Length("ListAppCmsGroups.Data.Length"); i++) {
				listAppCmsGroupsResponse_data.Add(_ctx.StringValue("ListAppCmsGroups.Data["+ i +"]"));
			}
			listAppCmsGroupsResponse.Data = listAppCmsGroupsResponse_data;
        
			return listAppCmsGroupsResponse;
        }
    }
}
