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
        public static QueryScriptWaveformsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryScriptWaveformsResponse queryScriptWaveformsResponse = new QueryScriptWaveformsResponse();

			queryScriptWaveformsResponse.HttpResponse = _ctx.HttpResponse;
			queryScriptWaveformsResponse.Code = _ctx.StringValue("QueryScriptWaveforms.Code");
			queryScriptWaveformsResponse.HttpStatusCode = _ctx.IntegerValue("QueryScriptWaveforms.HttpStatusCode");
			queryScriptWaveformsResponse.Message = _ctx.StringValue("QueryScriptWaveforms.Message");
			queryScriptWaveformsResponse.RequestId = _ctx.StringValue("QueryScriptWaveforms.RequestId");
			queryScriptWaveformsResponse.Success = _ctx.BooleanValue("QueryScriptWaveforms.Success");

			List<QueryScriptWaveformsResponse.QueryScriptWaveforms_ScriptWaveform> queryScriptWaveformsResponse_scriptWaveforms = new List<QueryScriptWaveformsResponse.QueryScriptWaveforms_ScriptWaveform>();
			for (int i = 0; i < _ctx.Length("QueryScriptWaveforms.ScriptWaveforms.Length"); i++) {
				QueryScriptWaveformsResponse.QueryScriptWaveforms_ScriptWaveform scriptWaveform = new QueryScriptWaveformsResponse.QueryScriptWaveforms_ScriptWaveform();
				scriptWaveform.FileId = _ctx.StringValue("QueryScriptWaveforms.ScriptWaveforms["+ i +"].FileId");
				scriptWaveform.FileName = _ctx.StringValue("QueryScriptWaveforms.ScriptWaveforms["+ i +"].FileName");
				scriptWaveform.ScriptContent = _ctx.StringValue("QueryScriptWaveforms.ScriptWaveforms["+ i +"].ScriptContent");
				scriptWaveform.ScriptId = _ctx.StringValue("QueryScriptWaveforms.ScriptWaveforms["+ i +"].ScriptId");
				scriptWaveform.ScriptWaveformId = _ctx.StringValue("QueryScriptWaveforms.ScriptWaveforms["+ i +"].ScriptWaveformId");

				queryScriptWaveformsResponse_scriptWaveforms.Add(scriptWaveform);
			}
			queryScriptWaveformsResponse.ScriptWaveforms = queryScriptWaveformsResponse_scriptWaveforms;
        
			return queryScriptWaveformsResponse;
        }
    }
}
