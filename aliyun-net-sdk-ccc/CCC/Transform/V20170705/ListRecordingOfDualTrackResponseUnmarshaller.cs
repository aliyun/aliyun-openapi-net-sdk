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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class ListRecordingOfDualTrackResponseUnmarshaller
    {
        public static ListRecordingOfDualTrackResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRecordingOfDualTrackResponse listRecordingOfDualTrackResponse = new ListRecordingOfDualTrackResponse();

			listRecordingOfDualTrackResponse.HttpResponse = _ctx.HttpResponse;
			listRecordingOfDualTrackResponse.RequestId = _ctx.StringValue("ListRecordingOfDualTrack.RequestId");
			listRecordingOfDualTrackResponse.Success = _ctx.BooleanValue("ListRecordingOfDualTrack.Success");
			listRecordingOfDualTrackResponse.Code = _ctx.StringValue("ListRecordingOfDualTrack.Code");
			listRecordingOfDualTrackResponse.Message = _ctx.StringValue("ListRecordingOfDualTrack.Message");
			listRecordingOfDualTrackResponse.HttpStatusCode = _ctx.IntegerValue("ListRecordingOfDualTrack.HttpStatusCode");

			ListRecordingOfDualTrackResponse.ListRecordingOfDualTrack_Recordings recordings = new ListRecordingOfDualTrackResponse.ListRecordingOfDualTrack_Recordings();
			recordings.TotalCount = _ctx.IntegerValue("ListRecordingOfDualTrack.Recordings.TotalCount");
			recordings.PageNumber = _ctx.IntegerValue("ListRecordingOfDualTrack.Recordings.PageNumber");
			recordings.PageSize = _ctx.IntegerValue("ListRecordingOfDualTrack.Recordings.PageSize");

			List<ListRecordingOfDualTrackResponse.ListRecordingOfDualTrack_Recordings.ListRecordingOfDualTrack_Recording> recordings_list = new List<ListRecordingOfDualTrackResponse.ListRecordingOfDualTrack_Recordings.ListRecordingOfDualTrack_Recording>();
			for (int i = 0; i < _ctx.Length("ListRecordingOfDualTrack.Recordings.List.Length"); i++) {
				ListRecordingOfDualTrackResponse.ListRecordingOfDualTrack_Recordings.ListRecordingOfDualTrack_Recording recording = new ListRecordingOfDualTrackResponse.ListRecordingOfDualTrack_Recordings.ListRecordingOfDualTrack_Recording();
				recording.ContactId = _ctx.StringValue("ListRecordingOfDualTrack.Recordings.List["+ i +"].ContactId");
				recording.ContactType = _ctx.StringValue("ListRecordingOfDualTrack.Recordings.List["+ i +"].ContactType");
				recording.AgentId = _ctx.StringValue("ListRecordingOfDualTrack.Recordings.List["+ i +"].AgentId");
				recording.AgentName = _ctx.StringValue("ListRecordingOfDualTrack.Recordings.List["+ i +"].AgentName");
				recording.CallingNumber = _ctx.StringValue("ListRecordingOfDualTrack.Recordings.List["+ i +"].CallingNumber");
				recording.CalledNumber = _ctx.StringValue("ListRecordingOfDualTrack.Recordings.List["+ i +"].CalledNumber");
				recording.StartTime = _ctx.LongValue("ListRecordingOfDualTrack.Recordings.List["+ i +"].StartTime");
				recording.Duration = _ctx.IntegerValue("ListRecordingOfDualTrack.Recordings.List["+ i +"].Duration");
				recording.FileName = _ctx.StringValue("ListRecordingOfDualTrack.Recordings.List["+ i +"].FileName");
				recording.FilePath = _ctx.StringValue("ListRecordingOfDualTrack.Recordings.List["+ i +"].FilePath");
				recording.FileDescription = _ctx.StringValue("ListRecordingOfDualTrack.Recordings.List["+ i +"].FileDescription");
				recording.Channel = _ctx.StringValue("ListRecordingOfDualTrack.Recordings.List["+ i +"].Channel");
				recording.InstanceId = _ctx.StringValue("ListRecordingOfDualTrack.Recordings.List["+ i +"].InstanceId");

				recordings_list.Add(recording);
			}
			recordings.List = recordings_list;
			listRecordingOfDualTrackResponse.Recordings = recordings;
        
			return listRecordingOfDualTrackResponse;
        }
    }
}
