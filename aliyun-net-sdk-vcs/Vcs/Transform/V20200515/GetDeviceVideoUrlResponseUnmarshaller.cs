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
using Aliyun.Acs.Vcs.Model.V20200515;

namespace Aliyun.Acs.Vcs.Transform.V20200515
{
    public class GetDeviceVideoUrlResponseUnmarshaller
    {
        public static GetDeviceVideoUrlResponse Unmarshall(UnmarshallerContext context)
        {
			GetDeviceVideoUrlResponse getDeviceVideoUrlResponse = new GetDeviceVideoUrlResponse();

			getDeviceVideoUrlResponse.HttpResponse = context.HttpResponse;
			getDeviceVideoUrlResponse.Code = context.StringValue("GetDeviceVideoUrl.Code");
			getDeviceVideoUrlResponse.Message = context.StringValue("GetDeviceVideoUrl.Message");
			getDeviceVideoUrlResponse.RequestId = context.StringValue("GetDeviceVideoUrl.RequestId");
			getDeviceVideoUrlResponse.Url = context.StringValue("GetDeviceVideoUrl.Url");
			getDeviceVideoUrlResponse.OutProtocol = context.StringValue("GetDeviceVideoUrl.OutProtocol");
        
			return getDeviceVideoUrlResponse;
        }
    }
}
