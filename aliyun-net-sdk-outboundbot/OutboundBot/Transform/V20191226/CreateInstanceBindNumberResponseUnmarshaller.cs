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
    public class CreateInstanceBindNumberResponseUnmarshaller
    {
        public static CreateInstanceBindNumberResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateInstanceBindNumberResponse createInstanceBindNumberResponse = new CreateInstanceBindNumberResponse();

			createInstanceBindNumberResponse.HttpResponse = _ctx.HttpResponse;
			createInstanceBindNumberResponse.Success = _ctx.BooleanValue("CreateInstanceBindNumber.Success");
			createInstanceBindNumberResponse.Code = _ctx.StringValue("CreateInstanceBindNumber.Code");
			createInstanceBindNumberResponse.Message = _ctx.StringValue("CreateInstanceBindNumber.Message");
			createInstanceBindNumberResponse.HttpStatusCode = _ctx.IntegerValue("CreateInstanceBindNumber.HttpStatusCode");
			createInstanceBindNumberResponse.RequestId = _ctx.StringValue("CreateInstanceBindNumber.RequestId");

			CreateInstanceBindNumberResponse.CreateInstanceBindNumber_Data data = new CreateInstanceBindNumberResponse.CreateInstanceBindNumber_Data();

			List<CreateInstanceBindNumberResponse.CreateInstanceBindNumber_Data.CreateInstanceBindNumber_ListItem> data_list = new List<CreateInstanceBindNumberResponse.CreateInstanceBindNumber_Data.CreateInstanceBindNumber_ListItem>();
			for (int i = 0; i < _ctx.Length("CreateInstanceBindNumber.Data.List.Length"); i++) {
				CreateInstanceBindNumberResponse.CreateInstanceBindNumber_Data.CreateInstanceBindNumber_ListItem listItem = new CreateInstanceBindNumberResponse.CreateInstanceBindNumber_Data.CreateInstanceBindNumber_ListItem();
				listItem.InstanceId = _ctx.StringValue("CreateInstanceBindNumber.Data.List["+ i +"].InstanceId");
				listItem.Success = _ctx.BooleanValue("CreateInstanceBindNumber.Data.List["+ i +"].Success");

				data_list.Add(listItem);
			}
			data.List = data_list;
			createInstanceBindNumberResponse.Data = data;
        
			return createInstanceBindNumberResponse;
        }
    }
}
