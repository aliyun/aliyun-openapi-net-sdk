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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class QueryLayoutByDeviceResponseUnmarshaller
    {
        public static QueryLayoutByDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryLayoutByDeviceResponse queryLayoutByDeviceResponse = new QueryLayoutByDeviceResponse();

			queryLayoutByDeviceResponse.HttpResponse = _ctx.HttpResponse;
			queryLayoutByDeviceResponse.RequestId = _ctx.StringValue("QueryLayoutByDevice.RequestId");
			queryLayoutByDeviceResponse.Success = _ctx.BooleanValue("QueryLayoutByDevice.Success");
			queryLayoutByDeviceResponse.Message = _ctx.StringValue("QueryLayoutByDevice.Message");
			queryLayoutByDeviceResponse.ErrorCode = _ctx.StringValue("QueryLayoutByDevice.ErrorCode");
			queryLayoutByDeviceResponse.ErrorMessage = _ctx.StringValue("QueryLayoutByDevice.ErrorMessage");
			queryLayoutByDeviceResponse.Code = _ctx.StringValue("QueryLayoutByDevice.Code");
			queryLayoutByDeviceResponse.DynamicCode = _ctx.StringValue("QueryLayoutByDevice.DynamicCode");
			queryLayoutByDeviceResponse.DynamicMessage = _ctx.StringValue("QueryLayoutByDevice.DynamicMessage");
			queryLayoutByDeviceResponse.PageNumber = _ctx.IntegerValue("QueryLayoutByDevice.PageNumber");
			queryLayoutByDeviceResponse.PageSize = _ctx.IntegerValue("QueryLayoutByDevice.PageSize");
			queryLayoutByDeviceResponse.TotalCount = _ctx.IntegerValue("QueryLayoutByDevice.TotalCount");

			List<QueryLayoutByDeviceResponse.QueryLayoutByDevice_Layout> queryLayoutByDeviceResponse_layoutList = new List<QueryLayoutByDeviceResponse.QueryLayoutByDevice_Layout>();
			for (int i = 0; i < _ctx.Length("QueryLayoutByDevice.LayoutList.Length"); i++) {
				QueryLayoutByDeviceResponse.QueryLayoutByDevice_Layout layout = new QueryLayoutByDeviceResponse.QueryLayoutByDevice_Layout();
				layout.LayoutId = _ctx.StringValue("QueryLayoutByDevice.LayoutList["+ i +"].LayoutId");
				layout.LayoutName = _ctx.StringValue("QueryLayoutByDevice.LayoutList["+ i +"].LayoutName");
				layout.Description = _ctx.StringValue("QueryLayoutByDevice.LayoutList["+ i +"].Description");
				layout.LayoutTemplateId = _ctx.StringValue("QueryLayoutByDevice.LayoutList["+ i +"].LayoutTemplateId");
				layout.IsBind = _ctx.BooleanValue("QueryLayoutByDevice.LayoutList["+ i +"].IsBind");
				layout.Brand = _ctx.StringValue("QueryLayoutByDevice.LayoutList["+ i +"].Brand");
				layout.BasePic = _ctx.StringValue("QueryLayoutByDevice.LayoutList["+ i +"].BasePic");

				queryLayoutByDeviceResponse_layoutList.Add(layout);
			}
			queryLayoutByDeviceResponse.LayoutList = queryLayoutByDeviceResponse_layoutList;
        
			return queryLayoutByDeviceResponse;
        }
    }
}
