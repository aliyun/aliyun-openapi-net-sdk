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
using Aliyun.Acs.Qualitycheck.Model.V20190115;

namespace Aliyun.Acs.Qualitycheck.Transform.V20190115
{
    public class SubmitCustomizationConfigResponseUnmarshaller
    {
        public static SubmitCustomizationConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SubmitCustomizationConfigResponse submitCustomizationConfigResponse = new SubmitCustomizationConfigResponse();

			submitCustomizationConfigResponse.HttpResponse = _ctx.HttpResponse;
			submitCustomizationConfigResponse.Code = _ctx.StringValue("SubmitCustomizationConfig.Code");
			submitCustomizationConfigResponse.Message = _ctx.StringValue("SubmitCustomizationConfig.Message");
			submitCustomizationConfigResponse.RequestId = _ctx.StringValue("SubmitCustomizationConfig.RequestId");
			submitCustomizationConfigResponse.Success = _ctx.BooleanValue("SubmitCustomizationConfig.Success");

			SubmitCustomizationConfigResponse.SubmitCustomizationConfig_Data data = new SubmitCustomizationConfigResponse.SubmitCustomizationConfig_Data();
			data.ModelStatus = _ctx.IntegerValue("SubmitCustomizationConfig.Data.ModelStatus");
			data.ModelName = _ctx.StringValue("SubmitCustomizationConfig.Data.ModelName");
			data.ModelId = _ctx.LongValue("SubmitCustomizationConfig.Data.ModelId");
			data.ModeCustomizationId = _ctx.StringValue("SubmitCustomizationConfig.Data.ModeCustomizationId");
			submitCustomizationConfigResponse.Data = data;
        
			return submitCustomizationConfigResponse;
        }
    }
}
