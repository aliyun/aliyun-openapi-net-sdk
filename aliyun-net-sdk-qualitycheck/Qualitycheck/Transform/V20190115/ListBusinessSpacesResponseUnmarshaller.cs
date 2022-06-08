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
using Aliyun.Acs.Qualitycheck.Model.V20190115;

namespace Aliyun.Acs.Qualitycheck.Transform.V20190115
{
    public class ListBusinessSpacesResponseUnmarshaller
    {
        public static ListBusinessSpacesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListBusinessSpacesResponse listBusinessSpacesResponse = new ListBusinessSpacesResponse();

			listBusinessSpacesResponse.HttpResponse = _ctx.HttpResponse;
			listBusinessSpacesResponse.CurrentPage = _ctx.IntegerValue("ListBusinessSpaces.CurrentPage");
			listBusinessSpacesResponse.PageSize = _ctx.IntegerValue("ListBusinessSpaces.PageSize");
			listBusinessSpacesResponse.PageNumber = _ctx.IntegerValue("ListBusinessSpaces.PageNumber");
			listBusinessSpacesResponse.RequestId = _ctx.StringValue("ListBusinessSpaces.RequestId");
			listBusinessSpacesResponse.Success = _ctx.BooleanValue("ListBusinessSpaces.Success");
			listBusinessSpacesResponse.Code = _ctx.StringValue("ListBusinessSpaces.Code");
			listBusinessSpacesResponse.Message = _ctx.StringValue("ListBusinessSpaces.Message");

			List<ListBusinessSpacesResponse.ListBusinessSpaces_DataItem> listBusinessSpacesResponse_data = new List<ListBusinessSpacesResponse.ListBusinessSpaces_DataItem>();
			for (int i = 0; i < _ctx.Length("ListBusinessSpaces.Data.Length"); i++) {
				ListBusinessSpacesResponse.ListBusinessSpaces_DataItem dataItem = new ListBusinessSpacesResponse.ListBusinessSpaces_DataItem();
				dataItem.Id = _ctx.LongValue("ListBusinessSpaces.Data["+ i +"].Id");
				dataItem.AliUid = _ctx.LongValue("ListBusinessSpaces.Data["+ i +"].AliUid");
				dataItem.SubAliUid = _ctx.LongValue("ListBusinessSpaces.Data["+ i +"].SubAliUid");
				dataItem.RoleName = _ctx.StringValue("ListBusinessSpaces.Data["+ i +"].RoleName");
				dataItem.LoginUserType = _ctx.IntegerValue("ListBusinessSpaces.Data["+ i +"].LoginUserType");
				dataItem.BusinessSpaceCode = _ctx.StringValue("ListBusinessSpaces.Data["+ i +"].BusinessSpaceCode");
				dataItem.BusinessSpaceName = _ctx.StringValue("ListBusinessSpaces.Data["+ i +"].BusinessSpaceName");
				dataItem.OrderInstanceId = _ctx.StringValue("ListBusinessSpaces.Data["+ i +"].OrderInstanceId");
				dataItem.XspaceProductCode = _ctx.StringValue("ListBusinessSpaces.Data["+ i +"].XspaceProductCode");
				dataItem.XspaceCommodityCode = _ctx.StringValue("ListBusinessSpaces.Data["+ i +"].XspaceCommodityCode");
				dataItem.ProductType = _ctx.StringValue("ListBusinessSpaces.Data["+ i +"].ProductType");
				dataItem.Language = _ctx.StringValue("ListBusinessSpaces.Data["+ i +"].Language");
				dataItem.StartTime = _ctx.StringValue("ListBusinessSpaces.Data["+ i +"].StartTime");
				dataItem.EndTime = _ctx.StringValue("ListBusinessSpaces.Data["+ i +"].EndTime");
				dataItem.CurrentStatus = _ctx.IntegerValue("ListBusinessSpaces.Data["+ i +"].CurrentStatus");

				listBusinessSpacesResponse_data.Add(dataItem);
			}
			listBusinessSpacesResponse.Data = listBusinessSpacesResponse_data;
        
			return listBusinessSpacesResponse;
        }
    }
}
