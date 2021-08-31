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
    public class GetWebContainerConfigResponseUnmarshaller
    {
        public static GetWebContainerConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetWebContainerConfigResponse getWebContainerConfigResponse = new GetWebContainerConfigResponse();

			getWebContainerConfigResponse.HttpResponse = _ctx.HttpResponse;
			getWebContainerConfigResponse.RequestId = _ctx.StringValue("GetWebContainerConfig.RequestId");
			getWebContainerConfigResponse.Message = _ctx.StringValue("GetWebContainerConfig.Message");
			getWebContainerConfigResponse.Code = _ctx.IntegerValue("GetWebContainerConfig.Code");

			GetWebContainerConfigResponse.GetWebContainerConfig_WebContainerConfig webContainerConfig = new GetWebContainerConfigResponse.GetWebContainerConfig_WebContainerConfig();
			webContainerConfig.ContextInputType = _ctx.StringValue("GetWebContainerConfig.WebContainerConfig.ContextInputType");
			webContainerConfig.ContextPath = _ctx.StringValue("GetWebContainerConfig.WebContainerConfig.ContextPath");
			webContainerConfig.HttpPort = _ctx.IntegerValue("GetWebContainerConfig.WebContainerConfig.HttpPort");
			webContainerConfig.MaxThreads = _ctx.IntegerValue("GetWebContainerConfig.WebContainerConfig.MaxThreads");
			webContainerConfig.ServerXml = _ctx.StringValue("GetWebContainerConfig.WebContainerConfig.ServerXml");
			webContainerConfig.UriEncoding = _ctx.StringValue("GetWebContainerConfig.WebContainerConfig.UriEncoding");
			webContainerConfig.UseAdvancedServerXml = _ctx.BooleanValue("GetWebContainerConfig.WebContainerConfig.UseAdvancedServerXml");
			webContainerConfig.UseBodyEncoding = _ctx.BooleanValue("GetWebContainerConfig.WebContainerConfig.UseBodyEncoding");
			webContainerConfig.UseDefaultConfig = _ctx.BooleanValue("GetWebContainerConfig.WebContainerConfig.UseDefaultConfig");
			getWebContainerConfigResponse.WebContainerConfig = webContainerConfig;
        
			return getWebContainerConfigResponse;
        }
    }
}
