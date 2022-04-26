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
    public class ListMultiChannelRecordingsResponseUnmarshaller
    {
        public static ListMultiChannelRecordingsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMultiChannelRecordingsResponse listMultiChannelRecordingsResponse = new ListMultiChannelRecordingsResponse();

			listMultiChannelRecordingsResponse.HttpResponse = _ctx.HttpResponse;
			listMultiChannelRecordingsResponse.Code = _ctx.StringValue("ListMultiChannelRecordings.Code");
			listMultiChannelRecordingsResponse.HttpStatusCode = _ctx.IntegerValue("ListMultiChannelRecordings.HttpStatusCode");
			listMultiChannelRecordingsResponse.Message = _ctx.StringValue("ListMultiChannelRecordings.Message");
			listMultiChannelRecordingsResponse.RequestId = _ctx.StringValue("ListMultiChannelRecordings.RequestId");

			List<ListMultiChannelRecordingsResponse.ListMultiChannelRecordings_RecordingDTO> listMultiChannelRecordingsResponse_data = new List<ListMultiChannelRecordingsResponse.ListMultiChannelRecordings_RecordingDTO>();
			for (int i = 0; i < _ctx.Length("ListMultiChannelRecordings.Data.Length"); i++) {
				ListMultiChannelRecordingsResponse.ListMultiChannelRecordings_RecordingDTO recordingDTO = new ListMultiChannelRecordingsResponse.ListMultiChannelRecordings_RecordingDTO();
				recordingDTO.FileName = _ctx.StringValue("ListMultiChannelRecordings.Data["+ i +"].FileName");
				recordingDTO.FileUrl = _ctx.StringValue("ListMultiChannelRecordings.Data["+ i +"].FileUrl");
				recordingDTO.AgentId = _ctx.StringValue("ListMultiChannelRecordings.Data["+ i +"].AgentId");
				recordingDTO.AgentName = _ctx.StringValue("ListMultiChannelRecordings.Data["+ i +"].AgentName");
				recordingDTO.StartTime = _ctx.LongValue("ListMultiChannelRecordings.Data["+ i +"].StartTime");
				recordingDTO.ContactId = _ctx.StringValue("ListMultiChannelRecordings.Data["+ i +"].ContactId");
				recordingDTO.Duration = _ctx.StringValue("ListMultiChannelRecordings.Data["+ i +"].Duration");
				recordingDTO.SkillGroupId = _ctx.StringValue("ListMultiChannelRecordings.Data["+ i +"].SkillGroupId");
				recordingDTO.RamId = _ctx.StringValue("ListMultiChannelRecordings.Data["+ i +"].RamId");
				recordingDTO.AgentChannelId = _ctx.StringValue("ListMultiChannelRecordings.Data["+ i +"].AgentChannelId");

				listMultiChannelRecordingsResponse_data.Add(recordingDTO);
			}
			listMultiChannelRecordingsResponse.Data = listMultiChannelRecordingsResponse_data;
        
			return listMultiChannelRecordingsResponse;
        }
    }
}
