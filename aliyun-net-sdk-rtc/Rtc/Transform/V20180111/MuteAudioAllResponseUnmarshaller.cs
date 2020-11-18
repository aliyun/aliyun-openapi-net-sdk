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
    public class MuteAudioAllResponseUnmarshaller
    {
        public static MuteAudioAllResponse Unmarshall(UnmarshallerContext _ctx)
        {
			MuteAudioAllResponse muteAudioAllResponse = new MuteAudioAllResponse();

			muteAudioAllResponse.HttpResponse = _ctx.HttpResponse;
			muteAudioAllResponse.RequestId = _ctx.StringValue("MuteAudioAll.RequestId");
			muteAudioAllResponse.ConferenceId = _ctx.StringValue("MuteAudioAll.ConferenceId");

			List<MuteAudioAllResponse.MuteAudioAll_Participant> muteAudioAllResponse_participants = new List<MuteAudioAllResponse.MuteAudioAll_Participant>();
			for (int i = 0; i < _ctx.Length("MuteAudioAll.Participants.Length"); i++) {
				MuteAudioAllResponse.MuteAudioAll_Participant participant = new MuteAudioAllResponse.MuteAudioAll_Participant();
				participant.Id = _ctx.StringValue("MuteAudioAll.Participants["+ i +"].Id");
				participant.Code = _ctx.StringValue("MuteAudioAll.Participants["+ i +"].Code");
				participant.Message = _ctx.StringValue("MuteAudioAll.Participants["+ i +"].Message");

				muteAudioAllResponse_participants.Add(participant);
			}
			muteAudioAllResponse.Participants = muteAudioAllResponse_participants;
        
			return muteAudioAllResponse;
        }
    }
}
