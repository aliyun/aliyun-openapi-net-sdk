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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class GetCustomerListResponseUnmarshaller
    {
        public static GetCustomerListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetCustomerListResponse getCustomerListResponse = new GetCustomerListResponse();

			getCustomerListResponse.HttpResponse = _ctx.HttpResponse;
			getCustomerListResponse.RequestId = _ctx.StringValue("GetCustomerList.RequestId");
			getCustomerListResponse.Success = _ctx.BooleanValue("GetCustomerList.Success");
			getCustomerListResponse.Code = _ctx.StringValue("GetCustomerList.Code");
			getCustomerListResponse.Message = _ctx.StringValue("GetCustomerList.Message");

			GetCustomerListResponse.GetCustomerList_Data data = new GetCustomerListResponse.GetCustomerList_Data();

			List<string> data_uidList = new List<string>();
			for (int i = 0; i < _ctx.Length("GetCustomerList.Data.UidList.Length"); i++) {
				data_uidList.Add(_ctx.StringValue("GetCustomerList.Data.UidList["+ i +"]"));
			}
			data.UidList = data_uidList;
			getCustomerListResponse.Data = data;
        
			return getCustomerListResponse;
        }
    }
}
