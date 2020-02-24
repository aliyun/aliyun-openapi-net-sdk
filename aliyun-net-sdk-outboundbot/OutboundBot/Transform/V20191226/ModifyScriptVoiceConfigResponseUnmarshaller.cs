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
        public static ModifyScriptVoiceConfigResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyScriptVoiceConfigResponse modifyScriptVoiceConfigResponse = new ModifyScriptVoiceConfigResponse();

			modifyScriptVoiceConfigResponse.HttpResponse = context.HttpResponse;
			modifyScriptVoiceConfigResponse.RequestId = context.StringValue("ModifyScriptVoiceConfig.RequestId");
			modifyScriptVoiceConfigResponse.Success = context.BooleanValue("ModifyScriptVoiceConfig.Success");
			modifyScriptVoiceConfigResponse.Code = context.StringValue("ModifyScriptVoiceConfig.Code");
			modifyScriptVoiceConfigResponse.Message = context.StringValue("ModifyScriptVoiceConfig.Message");
			modifyScriptVoiceConfigResponse.HttpStatusCode = context.IntegerValue("ModifyScriptVoiceConfig.HttpStatusCode");

			ModifyScriptVoiceConfigResponse.ModifyScriptVoiceConfig_ScriptVoiceConfig scriptVoiceConfig = new ModifyScriptVoiceConfigResponse.ModifyScriptVoiceConfig_ScriptVoiceConfig();
			scriptVoiceConfig.ScriptVoiceConfigId = context.StringValue("ModifyScriptVoiceConfig.ScriptVoiceConfig.ScriptVoiceConfigId");
			scriptVoiceConfig.InstanceId = context.StringValue("ModifyScriptVoiceConfig.ScriptVoiceConfig.InstanceId");
			scriptVoiceConfig.ScriptId = context.StringValue("ModifyScriptVoiceConfig.ScriptVoiceConfig.ScriptId");
			scriptVoiceConfig.ScriptContent = context.StringValue("ModifyScriptVoiceConfig.ScriptVoiceConfig.ScriptContent");
			scriptVoiceConfig.Source = context.StringValue("ModifyScriptVoiceConfig.ScriptVoiceConfig.Source");
			scriptVoiceConfig.Type = context.StringValue("ModifyScriptVoiceConfig.ScriptVoiceConfig.Type");
			scriptVoiceConfig.ScriptWaveformRelation = context.StringValue("ModifyScriptVoiceConfig.ScriptVoiceConfig.ScriptWaveformRelation");
			modifyScriptVoiceConfigResponse.ScriptVoiceConfig = scriptVoiceConfig;
        
			return modifyScriptVoiceConfigResponse;
        }
    }
}
