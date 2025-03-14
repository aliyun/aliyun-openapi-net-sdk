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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class ModifyCopilotEmbedConfigResponseUnmarshaller
    {
        public static ModifyCopilotEmbedConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyCopilotEmbedConfigResponse modifyCopilotEmbedConfigResponse = new ModifyCopilotEmbedConfigResponse();

			modifyCopilotEmbedConfigResponse.HttpResponse = _ctx.HttpResponse;
			modifyCopilotEmbedConfigResponse.RequestId = _ctx.StringValue("ModifyCopilotEmbedConfig.RequestId");
			modifyCopilotEmbedConfigResponse.Success = _ctx.BooleanValue("ModifyCopilotEmbedConfig.Success");
			modifyCopilotEmbedConfigResponse.Result = _ctx.BooleanValue("ModifyCopilotEmbedConfig.Result");
        
			return modifyCopilotEmbedConfigResponse;
        }
    }
}
