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
    public class ModifyTTSConfigResponseUnmarshaller
    {
        public static ModifyTTSConfigResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyTTSConfigResponse modifyTTSConfigResponse = new ModifyTTSConfigResponse();

			modifyTTSConfigResponse.HttpResponse = context.HttpResponse;
			modifyTTSConfigResponse.RequestId = context.StringValue("ModifyTTSConfig.RequestId");
			modifyTTSConfigResponse.Success = context.BooleanValue("ModifyTTSConfig.Success");
			modifyTTSConfigResponse.Code = context.StringValue("ModifyTTSConfig.Code");
			modifyTTSConfigResponse.Message = context.StringValue("ModifyTTSConfig.Message");
			modifyTTSConfigResponse.HttpStatusCode = context.IntegerValue("ModifyTTSConfig.HttpStatusCode");

			ModifyTTSConfigResponse.ModifyTTSConfig_TTSConfig tTSConfig = new ModifyTTSConfigResponse.ModifyTTSConfig_TTSConfig();
			tTSConfig.TTSConfigId = context.StringValue("ModifyTTSConfig.TTSConfig.TTSConfigId");
			tTSConfig.ScriptId = context.StringValue("ModifyTTSConfig.TTSConfig.ScriptId");
			tTSConfig.InstanceId = context.StringValue("ModifyTTSConfig.TTSConfig.InstanceId");
			tTSConfig.Voice = context.StringValue("ModifyTTSConfig.TTSConfig.Voice");
			tTSConfig.SpeechRate = context.StringValue("ModifyTTSConfig.TTSConfig.SpeechRate");
			tTSConfig.Volume = context.StringValue("ModifyTTSConfig.TTSConfig.Volume");
			modifyTTSConfigResponse.TTSConfig = tTSConfig;
        
			return modifyTTSConfigResponse;
        }
    }
}
