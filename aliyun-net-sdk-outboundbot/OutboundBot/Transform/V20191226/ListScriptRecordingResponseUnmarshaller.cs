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
    public class ListScriptRecordingResponseUnmarshaller
    {
        public static ListScriptRecordingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListScriptRecordingResponse listScriptRecordingResponse = new ListScriptRecordingResponse();

			listScriptRecordingResponse.HttpResponse = _ctx.HttpResponse;
			listScriptRecordingResponse.HttpStatusCode = _ctx.IntegerValue("ListScriptRecording.HttpStatusCode");
			listScriptRecordingResponse.RequestId = _ctx.StringValue("ListScriptRecording.RequestId");
			listScriptRecordingResponse.Success = _ctx.BooleanValue("ListScriptRecording.Success");
			listScriptRecordingResponse.Code = _ctx.StringValue("ListScriptRecording.Code");
			listScriptRecordingResponse.Message = _ctx.StringValue("ListScriptRecording.Message");
			listScriptRecordingResponse.PageSize = _ctx.IntegerValue("ListScriptRecording.PageSize");
			listScriptRecordingResponse.PageNumber = _ctx.IntegerValue("ListScriptRecording.PageNumber");
			listScriptRecordingResponse.TotalCount = _ctx.LongValue("ListScriptRecording.TotalCount");

			List<ListScriptRecordingResponse.ListScriptRecording_ScriptRecording> listScriptRecordingResponse_scriptRecordings = new List<ListScriptRecordingResponse.ListScriptRecording_ScriptRecording>();
			for (int i = 0; i < _ctx.Length("ListScriptRecording.ScriptRecordings.Length"); i++) {
				ListScriptRecordingResponse.ListScriptRecording_ScriptRecording scriptRecording = new ListScriptRecordingResponse.ListScriptRecording_ScriptRecording();
				scriptRecording.RecordingContent = _ctx.StringValue("ListScriptRecording.ScriptRecordings["+ i +"].RecordingContent");
				scriptRecording.State = _ctx.IntegerValue("ListScriptRecording.ScriptRecordings["+ i +"].State");
				scriptRecording.StorageUuid = _ctx.StringValue("ListScriptRecording.ScriptRecordings["+ i +"].StorageUuid");
				scriptRecording.StateExtend = _ctx.StringValue("ListScriptRecording.ScriptRecordings["+ i +"].StateExtend");
				scriptRecording.InstanceId = _ctx.StringValue("ListScriptRecording.ScriptRecordings["+ i +"].InstanceId");
				scriptRecording.GmtModified = _ctx.LongValue("ListScriptRecording.ScriptRecordings["+ i +"].GmtModified");
				scriptRecording.ScriptId = _ctx.StringValue("ListScriptRecording.ScriptRecordings["+ i +"].ScriptId");
				scriptRecording.Uuid = _ctx.StringValue("ListScriptRecording.ScriptRecordings["+ i +"].Uuid");
				scriptRecording.GmtUpload = _ctx.LongValue("ListScriptRecording.ScriptRecordings["+ i +"].GmtUpload");
				scriptRecording.RecordingDuration = _ctx.IntegerValue("ListScriptRecording.ScriptRecordings["+ i +"].RecordingDuration");
				scriptRecording.RecordingName = _ctx.StringValue("ListScriptRecording.ScriptRecordings["+ i +"].RecordingName");
				scriptRecording.GmtCreate = _ctx.LongValue("ListScriptRecording.ScriptRecordings["+ i +"].GmtCreate");
				scriptRecording.InnerId = _ctx.StringValue("ListScriptRecording.ScriptRecordings["+ i +"].InnerId");

				listScriptRecordingResponse_scriptRecordings.Add(scriptRecording);
			}
			listScriptRecordingResponse.ScriptRecordings = listScriptRecordingResponse_scriptRecordings;
        
			return listScriptRecordingResponse;
        }
    }
}
