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
    public class GetJavaStartUpConfigResponseUnmarshaller
    {
        public static GetJavaStartUpConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetJavaStartUpConfigResponse getJavaStartUpConfigResponse = new GetJavaStartUpConfigResponse();

			getJavaStartUpConfigResponse.HttpResponse = _ctx.HttpResponse;
			getJavaStartUpConfigResponse.Code = _ctx.IntegerValue("GetJavaStartUpConfig.Code");
			getJavaStartUpConfigResponse.Message = _ctx.StringValue("GetJavaStartUpConfig.Message");
			getJavaStartUpConfigResponse.RequestId = _ctx.StringValue("GetJavaStartUpConfig.RequestId");

			GetJavaStartUpConfigResponse.GetJavaStartUpConfig_JavaStartUpConfig javaStartUpConfig = new GetJavaStartUpConfigResponse.GetJavaStartUpConfig_JavaStartUpConfig();
			javaStartUpConfig.OriginalConfigs = _ctx.StringValue("GetJavaStartUpConfig.JavaStartUpConfig.OriginalConfigs");
			javaStartUpConfig.StartUpArgs = _ctx.StringValue("GetJavaStartUpConfig.JavaStartUpConfig.StartUpArgs");
			getJavaStartUpConfigResponse.JavaStartUpConfig = javaStartUpConfig;
        
			return getJavaStartUpConfigResponse;
        }
    }
}
