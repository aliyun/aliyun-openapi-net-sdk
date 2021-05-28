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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class CreateGatewayBlockVolumeResponseUnmarshaller
    {
        public static CreateGatewayBlockVolumeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateGatewayBlockVolumeResponse createGatewayBlockVolumeResponse = new CreateGatewayBlockVolumeResponse();

			createGatewayBlockVolumeResponse.HttpResponse = _ctx.HttpResponse;
			createGatewayBlockVolumeResponse.RequestId = _ctx.StringValue("CreateGatewayBlockVolume.RequestId");
			createGatewayBlockVolumeResponse.Success = _ctx.BooleanValue("CreateGatewayBlockVolume.Success");
			createGatewayBlockVolumeResponse.Code = _ctx.StringValue("CreateGatewayBlockVolume.Code");
			createGatewayBlockVolumeResponse.Message = _ctx.StringValue("CreateGatewayBlockVolume.Message");
			createGatewayBlockVolumeResponse.TaskId = _ctx.StringValue("CreateGatewayBlockVolume.TaskId");
        
			return createGatewayBlockVolumeResponse;
        }
    }
}
