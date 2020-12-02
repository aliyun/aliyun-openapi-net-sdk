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
    public class ListScriptVoiceConfigsResponseUnmarshaller
    {
        public static ListScriptVoiceConfigsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListScriptVoiceConfigsResponse listScriptVoiceConfigsResponse = new ListScriptVoiceConfigsResponse();

			listScriptVoiceConfigsResponse.HttpResponse = _ctx.HttpResponse;
			listScriptVoiceConfigsResponse.Code = _ctx.StringValue("ListScriptVoiceConfigs.Code");
			listScriptVoiceConfigsResponse.HttpStatusCode = _ctx.IntegerValue("ListScriptVoiceConfigs.HttpStatusCode");
			listScriptVoiceConfigsResponse.Message = _ctx.StringValue("ListScriptVoiceConfigs.Message");
			listScriptVoiceConfigsResponse.RequestId = _ctx.StringValue("ListScriptVoiceConfigs.RequestId");
			listScriptVoiceConfigsResponse.Success = _ctx.BooleanValue("ListScriptVoiceConfigs.Success");

			ListScriptVoiceConfigsResponse.ListScriptVoiceConfigs_ScriptVoiceConfigs scriptVoiceConfigs = new ListScriptVoiceConfigsResponse.ListScriptVoiceConfigs_ScriptVoiceConfigs();
			scriptVoiceConfigs.PageNumber = _ctx.IntegerValue("ListScriptVoiceConfigs.ScriptVoiceConfigs.PageNumber");
			scriptVoiceConfigs.PageSize = _ctx.IntegerValue("ListScriptVoiceConfigs.ScriptVoiceConfigs.PageSize");
			scriptVoiceConfigs.TotalCount = _ctx.IntegerValue("ListScriptVoiceConfigs.ScriptVoiceConfigs.TotalCount");

			List<ListScriptVoiceConfigsResponse.ListScriptVoiceConfigs_ScriptVoiceConfigs.ListScriptVoiceConfigs_ScriptVoiceConfig> scriptVoiceConfigs_list = new List<ListScriptVoiceConfigsResponse.ListScriptVoiceConfigs_ScriptVoiceConfigs.ListScriptVoiceConfigs_ScriptVoiceConfig>();
			for (int i = 0; i < _ctx.Length("ListScriptVoiceConfigs.ScriptVoiceConfigs.List.Length"); i++) {
				ListScriptVoiceConfigsResponse.ListScriptVoiceConfigs_ScriptVoiceConfigs.ListScriptVoiceConfigs_ScriptVoiceConfig scriptVoiceConfig = new ListScriptVoiceConfigsResponse.ListScriptVoiceConfigs_ScriptVoiceConfigs.ListScriptVoiceConfigs_ScriptVoiceConfig();
				scriptVoiceConfig.InstanceId = _ctx.StringValue("ListScriptVoiceConfigs.ScriptVoiceConfigs.List["+ i +"].InstanceId");
				scriptVoiceConfig.ScriptContent = _ctx.StringValue("ListScriptVoiceConfigs.ScriptVoiceConfigs.List["+ i +"].ScriptContent");
				scriptVoiceConfig.ScriptId = _ctx.StringValue("ListScriptVoiceConfigs.ScriptVoiceConfigs.List["+ i +"].ScriptId");
				scriptVoiceConfig.ScriptVoiceConfigId = _ctx.StringValue("ListScriptVoiceConfigs.ScriptVoiceConfigs.List["+ i +"].ScriptVoiceConfigId");
				scriptVoiceConfig.ScriptWaveformRelation = _ctx.StringValue("ListScriptVoiceConfigs.ScriptVoiceConfigs.List["+ i +"].ScriptWaveformRelation");
				scriptVoiceConfig.Source = _ctx.StringValue("ListScriptVoiceConfigs.ScriptVoiceConfigs.List["+ i +"].Source");
				scriptVoiceConfig.Type = _ctx.StringValue("ListScriptVoiceConfigs.ScriptVoiceConfigs.List["+ i +"].Type");

				scriptVoiceConfigs_list.Add(scriptVoiceConfig);
			}
			scriptVoiceConfigs.List = scriptVoiceConfigs_list;
			listScriptVoiceConfigsResponse.ScriptVoiceConfigs = scriptVoiceConfigs;
        
			return listScriptVoiceConfigsResponse;
        }
    }
}
