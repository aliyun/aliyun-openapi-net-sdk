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
    public class ListRecordingsResponseUnmarshaller
    {
        public static ListRecordingsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRecordingsResponse listRecordingsResponse = new ListRecordingsResponse();

			listRecordingsResponse.HttpResponse = _ctx.HttpResponse;
			listRecordingsResponse.RequestId = _ctx.StringValue("ListRecordings.RequestId");
			listRecordingsResponse.Success = _ctx.BooleanValue("ListRecordings.Success");
			listRecordingsResponse.Code = _ctx.StringValue("ListRecordings.Code");
			listRecordingsResponse.Message = _ctx.StringValue("ListRecordings.Message");
			listRecordingsResponse.HttpStatusCode = _ctx.IntegerValue("ListRecordings.HttpStatusCode");

			ListRecordingsResponse.ListRecordings_Recordings recordings = new ListRecordingsResponse.ListRecordings_Recordings();
			recordings.TotalCount = _ctx.IntegerValue("ListRecordings.Recordings.TotalCount");
			recordings.PageNumber = _ctx.IntegerValue("ListRecordings.Recordings.PageNumber");
			recordings.PageSize = _ctx.IntegerValue("ListRecordings.Recordings.PageSize");

			List<ListRecordingsResponse.ListRecordings_Recordings.ListRecordings_Recording> recordings_list = new List<ListRecordingsResponse.ListRecordings_Recordings.ListRecordings_Recording>();
			for (int i = 0; i < _ctx.Length("ListRecordings.Recordings.List.Length"); i++) {
				ListRecordingsResponse.ListRecordings_Recordings.ListRecordings_Recording recording = new ListRecordingsResponse.ListRecordings_Recordings.ListRecordings_Recording();
				recording.ContactId = _ctx.StringValue("ListRecordings.Recordings.List["+ i +"].ContactId");
				recording.ContactType = _ctx.StringValue("ListRecordings.Recordings.List["+ i +"].ContactType");
				recording.AgentId = _ctx.StringValue("ListRecordings.Recordings.List["+ i +"].AgentId");
				recording.AgentName = _ctx.StringValue("ListRecordings.Recordings.List["+ i +"].AgentName");
				recording.CallingNumber = _ctx.StringValue("ListRecordings.Recordings.List["+ i +"].CallingNumber");
				recording.CalledNumber = _ctx.StringValue("ListRecordings.Recordings.List["+ i +"].CalledNumber");
				recording.StartTime = _ctx.LongValue("ListRecordings.Recordings.List["+ i +"].StartTime");
				recording.Duration = _ctx.IntegerValue("ListRecordings.Recordings.List["+ i +"].Duration");
				recording.FileName = _ctx.StringValue("ListRecordings.Recordings.List["+ i +"].FileName");
				recording.FilePath = _ctx.StringValue("ListRecordings.Recordings.List["+ i +"].FilePath");
				recording.FileDescription = _ctx.StringValue("ListRecordings.Recordings.List["+ i +"].FileDescription");
				recording.Channel = _ctx.StringValue("ListRecordings.Recordings.List["+ i +"].Channel");
				recording.InstanceId = _ctx.StringValue("ListRecordings.Recordings.List["+ i +"].InstanceId");

				recordings_list.Add(recording);
			}
			recordings.List = recordings_list;
			listRecordingsResponse.Recordings = recordings;
        
			return listRecordingsResponse;
        }
    }
}
