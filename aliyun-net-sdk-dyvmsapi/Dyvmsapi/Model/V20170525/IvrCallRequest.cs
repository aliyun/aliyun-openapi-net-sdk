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
    public class IvrCallRequest : RpcAcsRequest<IvrCallResponse>
    {
        public IvrCallRequest()
            : base("Dyvmsapi", "2017-05-25", "IvrCall", "dyvms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string byeCode;

		private long? resourceOwnerId;

		private string startTtsParams;

		private int? timeout;

		private string startCode;

		private string calledNumber;

		private string calledShowNumber;

		private List<MenuKeyMap> menuKeyMaps = new List<MenuKeyMap>(){ };

		private string resourceOwnerAccount;

		private long? playTimes;

		private long? ownerId;

		private string outId;

		private string byeTtsParams;

		public string ByeCode
		{
			get
			{
				return byeCode;
			}
			set	
			{
				byeCode = value;
				DictionaryUtil.Add(QueryParameters, "ByeCode", value);
			}
		}

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

		public string StartTtsParams
		{
			get
			{
				return startTtsParams;
			}
			set	
			{
				startTtsParams = value;
				DictionaryUtil.Add(QueryParameters, "StartTtsParams", value);
			}
		}

		public int? Timeout
		{
			get
			{
				return timeout;
			}
			set	
			{
				timeout = value;
				DictionaryUtil.Add(QueryParameters, "Timeout", value.ToString());
			}
		}

		public string StartCode
		{
			get
			{
				return startCode;
			}
			set	
			{
				startCode = value;
				DictionaryUtil.Add(QueryParameters, "StartCode", value);
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

		public List<MenuKeyMap> MenuKeyMaps
		{
			get
			{
				return menuKeyMaps;
			}

			set
			{
				menuKeyMaps = value;
				for (int i = 0; i < menuKeyMaps.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"MenuKeyMap." + (i + 1) + ".Code", menuKeyMaps[i].Code);
					DictionaryUtil.Add(QueryParameters,"MenuKeyMap." + (i + 1) + ".TtsParams", menuKeyMaps[i].TtsParams);
					DictionaryUtil.Add(QueryParameters,"MenuKeyMap." + (i + 1) + ".Key", menuKeyMaps[i].Key);
				}
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

		public long? PlayTimes
		{
			get
			{
				return playTimes;
			}
			set	
			{
				playTimes = value;
				DictionaryUtil.Add(QueryParameters, "PlayTimes", value.ToString());
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

		public string ByeTtsParams
		{
			get
			{
				return byeTtsParams;
			}
			set	
			{
				byeTtsParams = value;
				DictionaryUtil.Add(QueryParameters, "ByeTtsParams", value);
			}
		}

		public class MenuKeyMap
		{

			private string code;

			private string ttsParams;

			private string key;

			public string Code
			{
				get
				{
					return code;
				}
				set	
				{
					code = value;
				}
			}

			public string TtsParams
			{
				get
				{
					return ttsParams;
				}
				set	
				{
					ttsParams = value;
				}
			}

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}
		}

        public override IvrCallResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return IvrCallResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
