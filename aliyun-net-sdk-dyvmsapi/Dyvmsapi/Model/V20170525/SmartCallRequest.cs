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
using Aliyun.Acs.Dyvmsapi.Transform;
using Aliyun.Acs.Dyvmsapi.Transform.V20170525;

namespace Aliyun.Acs.Dyvmsapi.Model.V20170525
{
    public class SmartCallRequest : RpcAcsRequest<SmartCallResponse>
    {
        public SmartCallRequest()
            : base("Dyvmsapi", "2017-05-25", "SmartCall", "dyvms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string voiceCodeParam;

		private bool? earlyMediaAsr;

		private int? speed;

		private string asrBaseId;

		private int? sessionTimeout;

		private string dynamicId;

		private string calledNumber;

		private int? ttsSpeed;

		private string voiceCode;

		private string calledShowNumber;

		private int? actionCodeTimeBreak;

		private bool? ttsConf;

		private bool? actionCodeBreak;

		private string resourceOwnerAccount;

		private bool? recordFlag;

		private long? ownerId;

		private int? ttsVolume;

		private int? volume;

		private int? muteTime;

		private string outId;

		private string asrModelId;

		private int? pauseTime;

		private string ttsStyle;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string VoiceCodeParam
		{
			get
			{
				return voiceCodeParam;
			}
			set	
			{
				voiceCodeParam = value;
				DictionaryUtil.Add(QueryParameters, "VoiceCodeParam", value);
			}
		}

		public bool? EarlyMediaAsr
		{
			get
			{
				return earlyMediaAsr;
			}
			set	
			{
				earlyMediaAsr = value;
				DictionaryUtil.Add(QueryParameters, "EarlyMediaAsr", value.ToString());
			}
		}

		public int? Speed
		{
			get
			{
				return speed;
			}
			set	
			{
				speed = value;
				DictionaryUtil.Add(QueryParameters, "Speed", value.ToString());
			}
		}

		public string AsrBaseId
		{
			get
			{
				return asrBaseId;
			}
			set	
			{
				asrBaseId = value;
				DictionaryUtil.Add(QueryParameters, "AsrBaseId", value);
			}
		}

		public int? SessionTimeout
		{
			get
			{
				return sessionTimeout;
			}
			set	
			{
				sessionTimeout = value;
				DictionaryUtil.Add(QueryParameters, "SessionTimeout", value.ToString());
			}
		}

		public string DynamicId
		{
			get
			{
				return dynamicId;
			}
			set	
			{
				dynamicId = value;
				DictionaryUtil.Add(QueryParameters, "DynamicId", value);
			}
		}

		public string CalledNumber
		{
			get
			{
				return calledNumber;
			}
			set	
			{
				calledNumber = value;
				DictionaryUtil.Add(QueryParameters, "CalledNumber", value);
			}
		}

		public int? TtsSpeed
		{
			get
			{
				return ttsSpeed;
			}
			set	
			{
				ttsSpeed = value;
				DictionaryUtil.Add(QueryParameters, "TtsSpeed", value.ToString());
			}
		}

		public string VoiceCode
		{
			get
			{
				return voiceCode;
			}
			set	
			{
				voiceCode = value;
				DictionaryUtil.Add(QueryParameters, "VoiceCode", value);
			}
		}

		public string CalledShowNumber
		{
			get
			{
				return calledShowNumber;
			}
			set	
			{
				calledShowNumber = value;
				DictionaryUtil.Add(QueryParameters, "CalledShowNumber", value);
			}
		}

		public int? ActionCodeTimeBreak
		{
			get
			{
				return actionCodeTimeBreak;
			}
			set	
			{
				actionCodeTimeBreak = value;
				DictionaryUtil.Add(QueryParameters, "ActionCodeTimeBreak", value.ToString());
			}
		}

		public bool? TtsConf
		{
			get
			{
				return ttsConf;
			}
			set	
			{
				ttsConf = value;
				DictionaryUtil.Add(QueryParameters, "TtsConf", value.ToString());
			}
		}

		public bool? ActionCodeBreak
		{
			get
			{
				return actionCodeBreak;
			}
			set	
			{
				actionCodeBreak = value;
				DictionaryUtil.Add(QueryParameters, "ActionCodeBreak", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public bool? RecordFlag
		{
			get
			{
				return recordFlag;
			}
			set	
			{
				recordFlag = value;
				DictionaryUtil.Add(QueryParameters, "RecordFlag", value.ToString());
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

		public int? TtsVolume
		{
			get
			{
				return ttsVolume;
			}
			set	
			{
				ttsVolume = value;
				DictionaryUtil.Add(QueryParameters, "TtsVolume", value.ToString());
			}
		}

		public int? Volume
		{
			get
			{
				return volume;
			}
			set	
			{
				volume = value;
				DictionaryUtil.Add(QueryParameters, "Volume", value.ToString());
			}
		}

		public int? MuteTime
		{
			get
			{
				return muteTime;
			}
			set	
			{
				muteTime = value;
				DictionaryUtil.Add(QueryParameters, "MuteTime", value.ToString());
			}
		}

		public string OutId
		{
			get
			{
				return outId;
			}
			set	
			{
				outId = value;
				DictionaryUtil.Add(QueryParameters, "OutId", value);
			}
		}

		public string AsrModelId
		{
			get
			{
				return asrModelId;
			}
			set	
			{
				asrModelId = value;
				DictionaryUtil.Add(QueryParameters, "AsrModelId", value);
			}
		}

		public int? PauseTime
		{
			get
			{
				return pauseTime;
			}
			set	
			{
				pauseTime = value;
				DictionaryUtil.Add(QueryParameters, "PauseTime", value.ToString());
			}
		}

		public string TtsStyle
		{
			get
			{
				return ttsStyle;
			}
			set	
			{
				ttsStyle = value;
				DictionaryUtil.Add(QueryParameters, "TtsStyle", value);
			}
		}

        public override SmartCallResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SmartCallResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
