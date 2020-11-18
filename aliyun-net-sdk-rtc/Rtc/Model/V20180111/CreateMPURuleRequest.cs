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
    public class CreateMPURuleRequest : RpcAcsRequest<CreateMPURuleResponse>
    {
        public CreateMPURuleRequest()
            : base("rtc", "2018-01-11", "CreateMPURule", "rtc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.rtc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.rtc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? backgroundColor;

		private int? cropMode;

		private string channelPrefix;

		private string taskProfile;

		private List<long?> layoutIdss = new List<long?>(){ };

		private string playDomain;

		private long? ownerId;

		private string appId;

		private int? mediaEncode;

		private string callBack;

		public int? BackgroundColor
		{
			get
			{
				return backgroundColor;
			}
			set	
			{
				backgroundColor = value;
				DictionaryUtil.Add(QueryParameters, "BackgroundColor", value.ToString());
			}
		}

		public int? CropMode
		{
			get
			{
				return cropMode;
			}
			set	
			{
				cropMode = value;
				DictionaryUtil.Add(QueryParameters, "CropMode", value.ToString());
			}
		}

		public string ChannelPrefix
		{
			get
			{
				return channelPrefix;
			}
			set	
			{
				channelPrefix = value;
				DictionaryUtil.Add(QueryParameters, "ChannelPrefix", value);
			}
		}

		public string TaskProfile
		{
			get
			{
				return taskProfile;
			}
			set	
			{
				taskProfile = value;
				DictionaryUtil.Add(QueryParameters, "TaskProfile", value);
			}
		}

		public List<long?> LayoutIdss
		{
			get
			{
				return layoutIdss;
			}

			set
			{
				layoutIdss = value;
				for (int i = 0; i < layoutIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"LayoutIds." + (i + 1) , layoutIdss[i]);
				}
			}
		}

		public string PlayDomain
		{
			get
			{
				return playDomain;
			}
			set	
			{
				playDomain = value;
				DictionaryUtil.Add(QueryParameters, "PlayDomain", value);
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

		public int? MediaEncode
		{
			get
			{
				return mediaEncode;
			}
			set	
			{
				mediaEncode = value;
				DictionaryUtil.Add(QueryParameters, "MediaEncode", value.ToString());
			}
		}

		public string CallBack
		{
			get
			{
				return callBack;
			}
			set	
			{
				callBack = value;
				DictionaryUtil.Add(QueryParameters, "CallBack", value);
			}
		}

        public override CreateMPURuleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateMPURuleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
