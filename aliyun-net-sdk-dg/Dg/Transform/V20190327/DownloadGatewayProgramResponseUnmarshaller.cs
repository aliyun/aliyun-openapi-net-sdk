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
using Aliyun.Acs.dg.Model.V20190327;

namespace Aliyun.Acs.dg.Transform.V20190327
{
    public class DownloadGatewayProgramResponseUnmarshaller
    {
        public static DownloadGatewayProgramResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DownloadGatewayProgramResponse downloadGatewayProgramResponse = new DownloadGatewayProgramResponse();

			downloadGatewayProgramResponse.HttpResponse = _ctx.HttpResponse;
			downloadGatewayProgramResponse.RequestId = _ctx.StringValue("DownloadGatewayProgram.RequestId");
			downloadGatewayProgramResponse.Success = _ctx.BooleanValue("DownloadGatewayProgram.Success");
			downloadGatewayProgramResponse.Code = _ctx.StringValue("DownloadGatewayProgram.Code");
			downloadGatewayProgramResponse.ErrorMsg = _ctx.StringValue("DownloadGatewayProgram.ErrorMsg");
			downloadGatewayProgramResponse.Data = _ctx.StringValue("DownloadGatewayProgram.Data");
        
			return downloadGatewayProgramResponse;
        }
    }
}
