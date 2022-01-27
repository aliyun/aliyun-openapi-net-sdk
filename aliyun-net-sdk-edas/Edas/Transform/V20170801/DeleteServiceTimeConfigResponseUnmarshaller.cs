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
    public class DeleteServiceTimeConfigResponseUnmarshaller
    {
        public static DeleteServiceTimeConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteServiceTimeConfigResponse deleteServiceTimeConfigResponse = new DeleteServiceTimeConfigResponse();

			deleteServiceTimeConfigResponse.HttpResponse = _ctx.HttpResponse;
			deleteServiceTimeConfigResponse.Code = _ctx.IntegerValue("DeleteServiceTimeConfig.Code");
			deleteServiceTimeConfigResponse.Message = _ctx.StringValue("DeleteServiceTimeConfig.Message");
			deleteServiceTimeConfigResponse.Success = _ctx.BooleanValue("DeleteServiceTimeConfig.Success");

			DeleteServiceTimeConfigResponse.DeleteServiceTimeConfig_Data data = new DeleteServiceTimeConfigResponse.DeleteServiceTimeConfig_Data();
			data.Timeout = _ctx.StringValue("DeleteServiceTimeConfig.Data.Timeout");
			data.ConsumerAppName = _ctx.StringValue("DeleteServiceTimeConfig.Data.ConsumerAppName");
			data.ConsumerAppId = _ctx.StringValue("DeleteServiceTimeConfig.Data.ConsumerAppId");
			data.Path = _ctx.StringValue("DeleteServiceTimeConfig.Data.Path");
			data.Id = _ctx.LongValue("DeleteServiceTimeConfig.Data.Id");
			deleteServiceTimeConfigResponse.Data = data;
        
			return deleteServiceTimeConfigResponse;
        }
    }
}
