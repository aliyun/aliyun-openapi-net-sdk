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
    public class DeleteScriptWaveformResponseUnmarshaller
    {
        public static DeleteScriptWaveformResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteScriptWaveformResponse deleteScriptWaveformResponse = new DeleteScriptWaveformResponse();

			deleteScriptWaveformResponse.HttpResponse = _ctx.HttpResponse;
			deleteScriptWaveformResponse.Code = _ctx.StringValue("DeleteScriptWaveform.Code");
			deleteScriptWaveformResponse.HttpStatusCode = _ctx.IntegerValue("DeleteScriptWaveform.HttpStatusCode");
			deleteScriptWaveformResponse.Message = _ctx.StringValue("DeleteScriptWaveform.Message");
			deleteScriptWaveformResponse.RequestId = _ctx.StringValue("DeleteScriptWaveform.RequestId");
			deleteScriptWaveformResponse.Success = _ctx.BooleanValue("DeleteScriptWaveform.Success");
        
			return deleteScriptWaveformResponse;
        }
    }
}
