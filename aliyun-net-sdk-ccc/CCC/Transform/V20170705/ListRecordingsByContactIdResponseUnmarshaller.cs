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
    public class ListRecordingsByContactIdResponseUnmarshaller
    {
        public static ListRecordingsByContactIdResponse Unmarshall(UnmarshallerContext context)
        {
			ListRecordingsByContactIdResponse listRecordingsByContactIdResponse = new ListRecordingsByContactIdResponse();

			listRecordingsByContactIdResponse.HttpResponse = context.HttpResponse;
			listRecordingsByContactIdResponse.RequestId = context.StringValue("ListRecordingsByContactId.RequestId");
			listRecordingsByContactIdResponse.Success = context.BooleanValue("ListRecordingsByContactId.Success");
			listRecordingsByContactIdResponse.Code = context.StringValue("ListRecordingsByContactId.Code");
			listRecordingsByContactIdResponse.Message = context.StringValue("ListRecordingsByContactId.Message");
			listRecordingsByContactIdResponse.HttpStatusCode = context.IntegerValue("ListRecordingsByContactId.HttpStatusCode");

			List<ListRecordingsByContactIdResponse.ListRecordingsByContactId_Recording> listRecordingsByContactIdResponse_recordings = new List<ListRecordingsByContactIdResponse.ListRecordingsByContactId_Recording>();
			for (int i = 0; i < context.Length("ListRecordingsByContactId.Recordings.Length"); i++) {
				ListRecordingsByContactIdResponse.ListRecordingsByContactId_Recording recording = new ListRecordingsByContactIdResponse.ListRecordingsByContactId_Recording();
				recording.ContactId = context.StringValue("ListRecordingsByContactId.Recordings["+ i +"].ContactId");
				recording.ContactType = context.StringValue("ListRecordingsByContactId.Recordings["+ i +"].ContactType");
				recording.AgentId = context.StringValue("ListRecordingsByContactId.Recordings["+ i +"].AgentId");
				recording.AgentName = context.StringValue("ListRecordingsByContactId.Recordings["+ i +"].AgentName");
				recording.CallingNumber = context.StringValue("ListRecordingsByContactId.Recordings["+ i +"].CallingNumber");
				recording.CalledNumber = context.StringValue("ListRecordingsByContactId.Recordings["+ i +"].CalledNumber");
				recording.StartTime = context.LongValue("ListRecordingsByContactId.Recordings["+ i +"].StartTime");
				recording.Duration = context.IntegerValue("ListRecordingsByContactId.Recordings["+ i +"].Duration");
				recording.FileName = context.StringValue("ListRecordingsByContactId.Recordings["+ i +"].FileName");
				recording.FilePath = context.StringValue("ListRecordingsByContactId.Recordings["+ i +"].FilePath");
				recording.FileDescription = context.StringValue("ListRecordingsByContactId.Recordings["+ i +"].FileDescription");
				recording.Channel = context.StringValue("ListRecordingsByContactId.Recordings["+ i +"].Channel");
				recording.InstanceId = context.StringValue("ListRecordingsByContactId.Recordings["+ i +"].InstanceId");
				recording.QualityCheckTid = context.StringValue("ListRecordingsByContactId.Recordings["+ i +"].QualityCheckTid");
				recording.QualityCheckTaskId = context.StringValue("ListRecordingsByContactId.Recordings["+ i +"].QualityCheckTaskId");

				listRecordingsByContactIdResponse_recordings.Add(recording);
			}
			listRecordingsByContactIdResponse.Recordings = listRecordingsByContactIdResponse_recordings;
        
			return listRecordingsByContactIdResponse;
        }
    }
}
