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
    public class UpdateStoreConfigResponseUnmarshaller
    {
        public static UpdateStoreConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateStoreConfigResponse updateStoreConfigResponse = new UpdateStoreConfigResponse();

			updateStoreConfigResponse.HttpResponse = _ctx.HttpResponse;
			updateStoreConfigResponse.ErrorMessage = _ctx.StringValue("UpdateStoreConfig.ErrorMessage");
			updateStoreConfigResponse.ErrorCode = _ctx.StringValue("UpdateStoreConfig.ErrorCode");
			updateStoreConfigResponse.Message = _ctx.StringValue("UpdateStoreConfig.Message");
			updateStoreConfigResponse.DynamicCode = _ctx.StringValue("UpdateStoreConfig.DynamicCode");
			updateStoreConfigResponse.Code = _ctx.StringValue("UpdateStoreConfig.Code");
			updateStoreConfigResponse.DynamicMessage = _ctx.StringValue("UpdateStoreConfig.DynamicMessage");
			updateStoreConfigResponse.RequestId = _ctx.StringValue("UpdateStoreConfig.RequestId");
			updateStoreConfigResponse.Success = _ctx.BooleanValue("UpdateStoreConfig.Success");
        
			return updateStoreConfigResponse;
        }
    }
}
