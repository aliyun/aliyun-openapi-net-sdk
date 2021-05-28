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
    public class UploadGatewayLogResponseUnmarshaller
    {
        public static UploadGatewayLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UploadGatewayLogResponse uploadGatewayLogResponse = new UploadGatewayLogResponse();

			uploadGatewayLogResponse.HttpResponse = _ctx.HttpResponse;
			uploadGatewayLogResponse.RequestId = _ctx.StringValue("UploadGatewayLog.RequestId");
			uploadGatewayLogResponse.Success = _ctx.BooleanValue("UploadGatewayLog.Success");
			uploadGatewayLogResponse.Code = _ctx.StringValue("UploadGatewayLog.Code");
			uploadGatewayLogResponse.Message = _ctx.StringValue("UploadGatewayLog.Message");
			uploadGatewayLogResponse.TaskId = _ctx.StringValue("UploadGatewayLog.TaskId");
        
			return uploadGatewayLogResponse;
        }
    }
}
