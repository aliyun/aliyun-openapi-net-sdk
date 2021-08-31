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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class AddServiceTimeConfigResponseUnmarshaller
    {
        public static AddServiceTimeConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddServiceTimeConfigResponse addServiceTimeConfigResponse = new AddServiceTimeConfigResponse();

			addServiceTimeConfigResponse.HttpResponse = _ctx.HttpResponse;
			addServiceTimeConfigResponse.Code = _ctx.IntegerValue("AddServiceTimeConfig.Code");
			addServiceTimeConfigResponse.Message = _ctx.StringValue("AddServiceTimeConfig.Message");
			addServiceTimeConfigResponse.Success = _ctx.BooleanValue("AddServiceTimeConfig.Success");
			addServiceTimeConfigResponse.RequestId = _ctx.StringValue("AddServiceTimeConfig.RequestId");

			AddServiceTimeConfigResponse.AddServiceTimeConfig_Data data = new AddServiceTimeConfigResponse.AddServiceTimeConfig_Data();
			data.Timeout = _ctx.StringValue("AddServiceTimeConfig.Data.Timeout");
			data.ConsumerAppName = _ctx.StringValue("AddServiceTimeConfig.Data.ConsumerAppName");
			data.ConsumerAppId = _ctx.StringValue("AddServiceTimeConfig.Data.ConsumerAppId");
			data.Path = _ctx.StringValue("AddServiceTimeConfig.Data.Path");
			data.Id = _ctx.LongValue("AddServiceTimeConfig.Data.Id");
			addServiceTimeConfigResponse.Data = data;
        
			return addServiceTimeConfigResponse;
        }
    }
}
