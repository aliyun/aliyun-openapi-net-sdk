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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class DescribeScriptVoiceConfigResponseUnmarshaller
    {
        public static DescribeScriptVoiceConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScriptVoiceConfigResponse describeScriptVoiceConfigResponse = new DescribeScriptVoiceConfigResponse();

			describeScriptVoiceConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeScriptVoiceConfigResponse.Code = _ctx.StringValue("DescribeScriptVoiceConfig.Code");
			describeScriptVoiceConfigResponse.HttpStatusCode = _ctx.IntegerValue("DescribeScriptVoiceConfig.HttpStatusCode");
			describeScriptVoiceConfigResponse.Message = _ctx.StringValue("DescribeScriptVoiceConfig.Message");
			describeScriptVoiceConfigResponse.RequestId = _ctx.StringValue("DescribeScriptVoiceConfig.RequestId");
			describeScriptVoiceConfigResponse.Success = _ctx.BooleanValue("DescribeScriptVoiceConfig.Success");

			DescribeScriptVoiceConfigResponse.DescribeScriptVoiceConfig_ScriptVoiceConfig scriptVoiceConfig = new DescribeScriptVoiceConfigResponse.DescribeScriptVoiceConfig_ScriptVoiceConfig();
			scriptVoiceConfig.InstanceId = _ctx.StringValue("DescribeScriptVoiceConfig.ScriptVoiceConfig.InstanceId");
			scriptVoiceConfig.ScriptContent = _ctx.StringValue("DescribeScriptVoiceConfig.ScriptVoiceConfig.ScriptContent");
			scriptVoiceConfig.ScriptId = _ctx.StringValue("DescribeScriptVoiceConfig.ScriptVoiceConfig.ScriptId");
			scriptVoiceConfig.ScriptVoiceConfigId = _ctx.StringValue("DescribeScriptVoiceConfig.ScriptVoiceConfig.ScriptVoiceConfigId");
			scriptVoiceConfig.ScriptWaveformRelation = _ctx.StringValue("DescribeScriptVoiceConfig.ScriptVoiceConfig.ScriptWaveformRelation");
			scriptVoiceConfig.Source = _ctx.StringValue("DescribeScriptVoiceConfig.ScriptVoiceConfig.Source");
			scriptVoiceConfig.Type = _ctx.StringValue("DescribeScriptVoiceConfig.ScriptVoiceConfig.Type");
			describeScriptVoiceConfigResponse.ScriptVoiceConfig = scriptVoiceConfig;
        
			return describeScriptVoiceConfigResponse;
        }
    }
}
