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
    public class ListAppGroupResponseUnmarshaller
    {
        public static ListAppGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAppGroupResponse listAppGroupResponse = new ListAppGroupResponse();

			listAppGroupResponse.HttpResponse = _ctx.HttpResponse;
			listAppGroupResponse.Code = _ctx.IntegerValue("ListAppGroup.Code");
			listAppGroupResponse.PageNumber = _ctx.IntegerValue("ListAppGroup.PageNumber");
			listAppGroupResponse.RequestId = _ctx.StringValue("ListAppGroup.RequestId");
			listAppGroupResponse.PageSize = _ctx.IntegerValue("ListAppGroup.PageSize");
			listAppGroupResponse.TotalCount = _ctx.LongValue("ListAppGroup.TotalCount");
			listAppGroupResponse.ErrorMsg = _ctx.StringValue("ListAppGroup.ErrorMsg");

			List<ListAppGroupResponse.ListAppGroup_AppGroupDetail> listAppGroupResponse_data = new List<ListAppGroupResponse.ListAppGroup_AppGroupDetail>();
			for (int i = 0; i < _ctx.Length("ListAppGroup.Data.Length"); i++) {
				ListAppGroupResponse.ListAppGroup_AppGroupDetail appGroupDetail = new ListAppGroupResponse.ListAppGroup_AppGroupDetail();
				appGroupDetail.BizName = _ctx.StringValue("ListAppGroup.Data["+ i +"].BizName");
				appGroupDetail.Name = _ctx.StringValue("ListAppGroup.Data["+ i +"].Name");
				appGroupDetail.Id = _ctx.LongValue("ListAppGroup.Data["+ i +"].Id");

				listAppGroupResponse_data.Add(appGroupDetail);
			}
			listAppGroupResponse.Data = listAppGroupResponse_data;
        
			return listAppGroupResponse;
        }
    }
}
