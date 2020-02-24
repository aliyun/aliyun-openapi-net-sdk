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
        public static DescribeScriptVoiceConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScriptVoiceConfigResponse describeScriptVoiceConfigResponse = new DescribeScriptVoiceConfigResponse();

			describeScriptVoiceConfigResponse.HttpResponse = context.HttpResponse;
			describeScriptVoiceConfigResponse.RequestId = context.StringValue("DescribeScriptVoiceConfig.RequestId");
			describeScriptVoiceConfigResponse.Success = context.BooleanValue("DescribeScriptVoiceConfig.Success");
			describeScriptVoiceConfigResponse.Code = context.StringValue("DescribeScriptVoiceConfig.Code");
			describeScriptVoiceConfigResponse.Message = context.StringValue("DescribeScriptVoiceConfig.Message");
			describeScriptVoiceConfigResponse.HttpStatusCode = context.IntegerValue("DescribeScriptVoiceConfig.HttpStatusCode");

			DescribeScriptVoiceConfigResponse.DescribeScriptVoiceConfig_ScriptVoiceConfig scriptVoiceConfig = new DescribeScriptVoiceConfigResponse.DescribeScriptVoiceConfig_ScriptVoiceConfig();
			scriptVoiceConfig.ScriptVoiceConfigId = context.StringValue("DescribeScriptVoiceConfig.ScriptVoiceConfig.ScriptVoiceConfigId");
			scriptVoiceConfig.InstanceId = context.StringValue("DescribeScriptVoiceConfig.ScriptVoiceConfig.InstanceId");
			scriptVoiceConfig.ScriptId = context.StringValue("DescribeScriptVoiceConfig.ScriptVoiceConfig.ScriptId");
			scriptVoiceConfig.ScriptContent = context.StringValue("DescribeScriptVoiceConfig.ScriptVoiceConfig.ScriptContent");
			scriptVoiceConfig.Source = context.StringValue("DescribeScriptVoiceConfig.ScriptVoiceConfig.Source");
			scriptVoiceConfig.Type = context.StringValue("DescribeScriptVoiceConfig.ScriptVoiceConfig.Type");
			scriptVoiceConfig.ScriptWaveformRelation = context.StringValue("DescribeScriptVoiceConfig.ScriptVoiceConfig.ScriptWaveformRelation");
			describeScriptVoiceConfigResponse.ScriptVoiceConfig = scriptVoiceConfig;
        
			return describeScriptVoiceConfigResponse;
        }
    }
}
