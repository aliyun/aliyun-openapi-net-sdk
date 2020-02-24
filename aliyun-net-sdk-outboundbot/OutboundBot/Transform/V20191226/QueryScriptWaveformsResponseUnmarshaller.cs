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
    public class QueryScriptWaveformsResponseUnmarshaller
    {
        public static QueryScriptWaveformsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryScriptWaveformsResponse queryScriptWaveformsResponse = new QueryScriptWaveformsResponse();

			queryScriptWaveformsResponse.HttpResponse = context.HttpResponse;
			queryScriptWaveformsResponse.RequestId = context.StringValue("QueryScriptWaveforms.RequestId");
			queryScriptWaveformsResponse.Success = context.BooleanValue("QueryScriptWaveforms.Success");
			queryScriptWaveformsResponse.Code = context.StringValue("QueryScriptWaveforms.Code");
			queryScriptWaveformsResponse.Message = context.StringValue("QueryScriptWaveforms.Message");
			queryScriptWaveformsResponse.HttpStatusCode = context.IntegerValue("QueryScriptWaveforms.HttpStatusCode");

			List<QueryScriptWaveformsResponse.QueryScriptWaveforms_ScriptWaveform> queryScriptWaveformsResponse_scriptWaveforms = new List<QueryScriptWaveformsResponse.QueryScriptWaveforms_ScriptWaveform>();
			for (int i = 0; i < context.Length("QueryScriptWaveforms.ScriptWaveforms.Length"); i++) {
				QueryScriptWaveformsResponse.QueryScriptWaveforms_ScriptWaveform scriptWaveform = new QueryScriptWaveformsResponse.QueryScriptWaveforms_ScriptWaveform();
				scriptWaveform.ScriptWaveformId = context.StringValue("QueryScriptWaveforms.ScriptWaveforms["+ i +"].ScriptWaveformId");
				scriptWaveform.ScriptId = context.StringValue("QueryScriptWaveforms.ScriptWaveforms["+ i +"].ScriptId");
				scriptWaveform.ScriptContent = context.StringValue("QueryScriptWaveforms.ScriptWaveforms["+ i +"].ScriptContent");
				scriptWaveform.FileId = context.StringValue("QueryScriptWaveforms.ScriptWaveforms["+ i +"].FileId");
				scriptWaveform.FileName = context.StringValue("QueryScriptWaveforms.ScriptWaveforms["+ i +"].FileName");

				queryScriptWaveformsResponse_scriptWaveforms.Add(scriptWaveform);
			}
			queryScriptWaveformsResponse.ScriptWaveforms = queryScriptWaveformsResponse_scriptWaveforms;
        
			return queryScriptWaveformsResponse;
        }
    }
}
