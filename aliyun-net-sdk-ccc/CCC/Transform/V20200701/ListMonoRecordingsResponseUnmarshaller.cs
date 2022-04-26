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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class ListMonoRecordingsResponseUnmarshaller
    {
        public static ListMonoRecordingsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMonoRecordingsResponse listMonoRecordingsResponse = new ListMonoRecordingsResponse();

			listMonoRecordingsResponse.HttpResponse = _ctx.HttpResponse;
			listMonoRecordingsResponse.Code = _ctx.StringValue("ListMonoRecordings.Code");
			listMonoRecordingsResponse.HttpStatusCode = _ctx.IntegerValue("ListMonoRecordings.HttpStatusCode");
			listMonoRecordingsResponse.Message = _ctx.StringValue("ListMonoRecordings.Message");
			listMonoRecordingsResponse.RequestId = _ctx.StringValue("ListMonoRecordings.RequestId");

			List<ListMonoRecordingsResponse.ListMonoRecordings_RecordingDTO> listMonoRecordingsResponse_data = new List<ListMonoRecordingsResponse.ListMonoRecordings_RecordingDTO>();
			for (int i = 0; i < _ctx.Length("ListMonoRecordings.Data.Length"); i++) {
				ListMonoRecordingsResponse.ListMonoRecordings_RecordingDTO recordingDTO = new ListMonoRecordingsResponse.ListMonoRecordings_RecordingDTO();
				recordingDTO.FileName = _ctx.StringValue("ListMonoRecordings.Data["+ i +"].FileName");
				recordingDTO.FileUrl = _ctx.StringValue("ListMonoRecordings.Data["+ i +"].FileUrl");
				recordingDTO.AgentId = _ctx.StringValue("ListMonoRecordings.Data["+ i +"].AgentId");
				recordingDTO.AgentName = _ctx.StringValue("ListMonoRecordings.Data["+ i +"].AgentName");
				recordingDTO.StartTime = _ctx.StringValue("ListMonoRecordings.Data["+ i +"].StartTime");
				recordingDTO.ContactId = _ctx.StringValue("ListMonoRecordings.Data["+ i +"].ContactId");
				recordingDTO.Duration = _ctx.StringValue("ListMonoRecordings.Data["+ i +"].Duration");
				recordingDTO.SkillGroupId = _ctx.StringValue("ListMonoRecordings.Data["+ i +"].SkillGroupId");
				recordingDTO.RamId = _ctx.StringValue("ListMonoRecordings.Data["+ i +"].RamId");

				listMonoRecordingsResponse_data.Add(recordingDTO);
			}
			listMonoRecordingsResponse.Data = listMonoRecordingsResponse_data;
        
			return listMonoRecordingsResponse;
        }
    }
}
