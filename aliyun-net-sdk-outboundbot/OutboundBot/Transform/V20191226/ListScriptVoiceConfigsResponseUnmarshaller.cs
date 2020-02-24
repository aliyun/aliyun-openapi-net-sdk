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
        public static ListScriptVoiceConfigsResponse Unmarshall(UnmarshallerContext context)
        {
			ListScriptVoiceConfigsResponse listScriptVoiceConfigsResponse = new ListScriptVoiceConfigsResponse();

			listScriptVoiceConfigsResponse.HttpResponse = context.HttpResponse;
			listScriptVoiceConfigsResponse.RequestId = context.StringValue("ListScriptVoiceConfigs.RequestId");
			listScriptVoiceConfigsResponse.Success = context.BooleanValue("ListScriptVoiceConfigs.Success");
			listScriptVoiceConfigsResponse.Code = context.StringValue("ListScriptVoiceConfigs.Code");
			listScriptVoiceConfigsResponse.Message = context.StringValue("ListScriptVoiceConfigs.Message");
			listScriptVoiceConfigsResponse.HttpStatusCode = context.IntegerValue("ListScriptVoiceConfigs.HttpStatusCode");

			ListScriptVoiceConfigsResponse.ListScriptVoiceConfigs_ScriptVoiceConfigs scriptVoiceConfigs = new ListScriptVoiceConfigsResponse.ListScriptVoiceConfigs_ScriptVoiceConfigs();
			scriptVoiceConfigs.TotalCount = context.IntegerValue("ListScriptVoiceConfigs.ScriptVoiceConfigs.TotalCount");
			scriptVoiceConfigs.PageNumber = context.IntegerValue("ListScriptVoiceConfigs.ScriptVoiceConfigs.PageNumber");
			scriptVoiceConfigs.PageSize = context.IntegerValue("ListScriptVoiceConfigs.ScriptVoiceConfigs.PageSize");

			List<ListScriptVoiceConfigsResponse.ListScriptVoiceConfigs_ScriptVoiceConfigs.ListScriptVoiceConfigs_ScriptVoiceConfig> scriptVoiceConfigs_list = new List<ListScriptVoiceConfigsResponse.ListScriptVoiceConfigs_ScriptVoiceConfigs.ListScriptVoiceConfigs_ScriptVoiceConfig>();
			for (int i = 0; i < context.Length("ListScriptVoiceConfigs.ScriptVoiceConfigs.List.Length"); i++) {
				ListScriptVoiceConfigsResponse.ListScriptVoiceConfigs_ScriptVoiceConfigs.ListScriptVoiceConfigs_ScriptVoiceConfig scriptVoiceConfig = new ListScriptVoiceConfigsResponse.ListScriptVoiceConfigs_ScriptVoiceConfigs.ListScriptVoiceConfigs_ScriptVoiceConfig();
				scriptVoiceConfig.ScriptVoiceConfigId = context.StringValue("ListScriptVoiceConfigs.ScriptVoiceConfigs.List["+ i +"].ScriptVoiceConfigId");
				scriptVoiceConfig.InstanceId = context.StringValue("ListScriptVoiceConfigs.ScriptVoiceConfigs.List["+ i +"].InstanceId");
				scriptVoiceConfig.ScriptId = context.StringValue("ListScriptVoiceConfigs.ScriptVoiceConfigs.List["+ i +"].ScriptId");
				scriptVoiceConfig.ScriptContent = context.StringValue("ListScriptVoiceConfigs.ScriptVoiceConfigs.List["+ i +"].ScriptContent");
				scriptVoiceConfig.Source = context.StringValue("ListScriptVoiceConfigs.ScriptVoiceConfigs.List["+ i +"].Source");
				scriptVoiceConfig.Type = context.StringValue("ListScriptVoiceConfigs.ScriptVoiceConfigs.List["+ i +"].Type");
				scriptVoiceConfig.ScriptWaveformRelation = context.StringValue("ListScriptVoiceConfigs.ScriptVoiceConfigs.List["+ i +"].ScriptWaveformRelation");

				scriptVoiceConfigs_list.Add(scriptVoiceConfig);
			}
			scriptVoiceConfigs.List = scriptVoiceConfigs_list;
			listScriptVoiceConfigsResponse.ScriptVoiceConfigs = scriptVoiceConfigs;
        
			return listScriptVoiceConfigsResponse;
        }
    }
}
