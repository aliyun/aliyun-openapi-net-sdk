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
    public class ModifyScriptVoiceConfigResponseUnmarshaller
    {
        public static ModifyScriptVoiceConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyScriptVoiceConfigResponse modifyScriptVoiceConfigResponse = new ModifyScriptVoiceConfigResponse();

			modifyScriptVoiceConfigResponse.HttpResponse = _ctx.HttpResponse;
			modifyScriptVoiceConfigResponse.Code = _ctx.StringValue("ModifyScriptVoiceConfig.Code");
			modifyScriptVoiceConfigResponse.HttpStatusCode = _ctx.IntegerValue("ModifyScriptVoiceConfig.HttpStatusCode");
			modifyScriptVoiceConfigResponse.Message = _ctx.StringValue("ModifyScriptVoiceConfig.Message");
			modifyScriptVoiceConfigResponse.RequestId = _ctx.StringValue("ModifyScriptVoiceConfig.RequestId");
			modifyScriptVoiceConfigResponse.Success = _ctx.BooleanValue("ModifyScriptVoiceConfig.Success");

			ModifyScriptVoiceConfigResponse.ModifyScriptVoiceConfig_ScriptVoiceConfig scriptVoiceConfig = new ModifyScriptVoiceConfigResponse.ModifyScriptVoiceConfig_ScriptVoiceConfig();
			scriptVoiceConfig.InstanceId = _ctx.StringValue("ModifyScriptVoiceConfig.ScriptVoiceConfig.InstanceId");
			scriptVoiceConfig.ScriptContent = _ctx.StringValue("ModifyScriptVoiceConfig.ScriptVoiceConfig.ScriptContent");
			scriptVoiceConfig.ScriptId = _ctx.StringValue("ModifyScriptVoiceConfig.ScriptVoiceConfig.ScriptId");
			scriptVoiceConfig.ScriptVoiceConfigId = _ctx.StringValue("ModifyScriptVoiceConfig.ScriptVoiceConfig.ScriptVoiceConfigId");
			scriptVoiceConfig.ScriptWaveformRelation = _ctx.StringValue("ModifyScriptVoiceConfig.ScriptVoiceConfig.ScriptWaveformRelation");
			scriptVoiceConfig.Source = _ctx.StringValue("ModifyScriptVoiceConfig.ScriptVoiceConfig.Source");
			scriptVoiceConfig.Type = _ctx.StringValue("ModifyScriptVoiceConfig.ScriptVoiceConfig.Type");
			modifyScriptVoiceConfigResponse.ScriptVoiceConfig = scriptVoiceConfig;
        
			return modifyScriptVoiceConfigResponse;
        }
    }
}
