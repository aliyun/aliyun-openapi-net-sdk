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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.rtc.Transform;
using Aliyun.Acs.rtc.Transform.V20180111;

namespace Aliyun.Acs.rtc.Model.V20180111
{
    public class MuteAudioRequest : RpcAcsRequest<MuteAudioResponse>
    {
        public MuteAudioRequest()
            : base("rtc", "2018-01-11", "MuteAudio", "rtc", "openAPI")
        {
        }

		private List<string> participantIdss;

		private long? ownerId;

		private string conferenceId;

		private string appId;

		private string action;

		public List<string> ParticipantIdss
		{
			get
			{
				return participantIdss;
			}

			set
			{
				participantIdss = value;
				for (int i = 0; i < participantIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ParticipantIds." + (i + 1) , participantIdss[i]);
				}
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ConferenceId
		{
			get
			{
				return conferenceId;
			}
			set	
			{
				conferenceId = value;
				DictionaryUtil.Add(QueryParameters, "ConferenceId", value);
			}
		}

		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

        public override MuteAudioResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return MuteAudioResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
