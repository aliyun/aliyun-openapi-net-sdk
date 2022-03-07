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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class DescribeTenantBindNumberResponseUnmarshaller
    {
        public static DescribeTenantBindNumberResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTenantBindNumberResponse describeTenantBindNumberResponse = new DescribeTenantBindNumberResponse();

			describeTenantBindNumberResponse.HttpResponse = _ctx.HttpResponse;
			describeTenantBindNumberResponse.Success = _ctx.BooleanValue("DescribeTenantBindNumber.Success");
			describeTenantBindNumberResponse.Code = _ctx.StringValue("DescribeTenantBindNumber.Code");
			describeTenantBindNumberResponse.Message = _ctx.StringValue("DescribeTenantBindNumber.Message");
			describeTenantBindNumberResponse.HttpStatusCode = _ctx.IntegerValue("DescribeTenantBindNumber.HttpStatusCode");
			describeTenantBindNumberResponse.RequestId = _ctx.StringValue("DescribeTenantBindNumber.RequestId");

			DescribeTenantBindNumberResponse.DescribeTenantBindNumber_Data data = new DescribeTenantBindNumberResponse.DescribeTenantBindNumber_Data();

			List<DescribeTenantBindNumberResponse.DescribeTenantBindNumber_Data.DescribeTenantBindNumber_ListItem> data_list = new List<DescribeTenantBindNumberResponse.DescribeTenantBindNumber_Data.DescribeTenantBindNumber_ListItem>();
			for (int i = 0; i < _ctx.Length("DescribeTenantBindNumber.Data.List.Length"); i++) {
				DescribeTenantBindNumberResponse.DescribeTenantBindNumber_Data.DescribeTenantBindNumber_ListItem listItem = new DescribeTenantBindNumberResponse.DescribeTenantBindNumber_Data.DescribeTenantBindNumber_ListItem();
				listItem.InstanceId = _ctx.StringValue("DescribeTenantBindNumber.Data.List["+ i +"].InstanceId");
				listItem.InstanceName = _ctx.StringValue("DescribeTenantBindNumber.Data.List["+ i +"].InstanceName");
				listItem.IsBinding = _ctx.BooleanValue("DescribeTenantBindNumber.Data.List["+ i +"].IsBinding");

				data_list.Add(listItem);
			}
			data.List = data_list;
			describeTenantBindNumberResponse.Data = data;
        
			return describeTenantBindNumberResponse;
        }
    }
}
