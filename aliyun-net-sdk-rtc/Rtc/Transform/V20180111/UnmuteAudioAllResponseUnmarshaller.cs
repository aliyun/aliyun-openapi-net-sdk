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
    public class UnmuteAudioAllResponseUnmarshaller
    {
        public static UnmuteAudioAllResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UnmuteAudioAllResponse unmuteAudioAllResponse = new UnmuteAudioAllResponse();

			unmuteAudioAllResponse.HttpResponse = _ctx.HttpResponse;
			unmuteAudioAllResponse.RequestId = _ctx.StringValue("UnmuteAudioAll.RequestId");
			unmuteAudioAllResponse.ConferenceId = _ctx.StringValue("UnmuteAudioAll.ConferenceId");

			List<UnmuteAudioAllResponse.UnmuteAudioAll_Participant> unmuteAudioAllResponse_participants = new List<UnmuteAudioAllResponse.UnmuteAudioAll_Participant>();
			for (int i = 0; i < _ctx.Length("UnmuteAudioAll.Participants.Length"); i++) {
				UnmuteAudioAllResponse.UnmuteAudioAll_Participant participant = new UnmuteAudioAllResponse.UnmuteAudioAll_Participant();
				participant.Id = _ctx.StringValue("UnmuteAudioAll.Participants["+ i +"].Id");
				participant.Code = _ctx.StringValue("UnmuteAudioAll.Participants["+ i +"].Code");
				participant.Message = _ctx.StringValue("UnmuteAudioAll.Participants["+ i +"].Message");

				unmuteAudioAllResponse_participants.Add(participant);
			}
			unmuteAudioAllResponse.Participants = unmuteAudioAllResponse_participants;
        
			return unmuteAudioAllResponse;
        }
    }
}
