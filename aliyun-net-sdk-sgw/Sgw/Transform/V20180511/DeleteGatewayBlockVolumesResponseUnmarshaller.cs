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
    public class DeleteGatewayBlockVolumesResponseUnmarshaller
    {
        public static DeleteGatewayBlockVolumesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteGatewayBlockVolumesResponse deleteGatewayBlockVolumesResponse = new DeleteGatewayBlockVolumesResponse();

			deleteGatewayBlockVolumesResponse.HttpResponse = _ctx.HttpResponse;
			deleteGatewayBlockVolumesResponse.TaskId = _ctx.StringValue("DeleteGatewayBlockVolumes.TaskId");
			deleteGatewayBlockVolumesResponse.Message = _ctx.StringValue("DeleteGatewayBlockVolumes.Message");
			deleteGatewayBlockVolumesResponse.RequestId = _ctx.StringValue("DeleteGatewayBlockVolumes.RequestId");
			deleteGatewayBlockVolumesResponse.Code = _ctx.StringValue("DeleteGatewayBlockVolumes.Code");
			deleteGatewayBlockVolumesResponse.Success = _ctx.BooleanValue("DeleteGatewayBlockVolumes.Success");
        
			return deleteGatewayBlockVolumesResponse;
        }
    }
}
