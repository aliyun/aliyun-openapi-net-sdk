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
using Aliyun.Acs.rtc.Model.V20180111;

namespace Aliyun.Acs.rtc.Transform.V20180111
{
    public class RemoveParticipantsResponseUnmarshaller
    {
        public static RemoveParticipantsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RemoveParticipantsResponse removeParticipantsResponse = new RemoveParticipantsResponse();

			removeParticipantsResponse.HttpResponse = _ctx.HttpResponse;
			removeParticipantsResponse.RequestId = _ctx.StringValue("RemoveParticipants.RequestId");
			removeParticipantsResponse.ConferenceId = _ctx.StringValue("RemoveParticipants.ConferenceId");

			List<RemoveParticipantsResponse.RemoveParticipants_Participant> removeParticipantsResponse_participants = new List<RemoveParticipantsResponse.RemoveParticipants_Participant>();
			for (int i = 0; i < _ctx.Length("RemoveParticipants.Participants.Length"); i++) {
				RemoveParticipantsResponse.RemoveParticipants_Participant participant = new RemoveParticipantsResponse.RemoveParticipants_Participant();
				participant.Id = _ctx.StringValue("RemoveParticipants.Participants["+ i +"].Id");
				participant.Code = _ctx.StringValue("RemoveParticipants.Participants["+ i +"].Code");
				participant.Message = _ctx.StringValue("RemoveParticipants.Participants["+ i +"].Message");

				removeParticipantsResponse_participants.Add(participant);
			}
			removeParticipantsResponse.Participants = removeParticipantsResponse_participants;
        
			return removeParticipantsResponse;
        }
    }
}
