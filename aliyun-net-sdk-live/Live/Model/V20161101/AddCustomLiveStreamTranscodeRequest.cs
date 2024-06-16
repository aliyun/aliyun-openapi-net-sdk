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
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class AddCustomLiveStreamTranscodeRequest : RpcAcsRequest<AddCustomLiveStreamTranscodeResponse>
    {
        public AddCustomLiveStreamTranscodeRequest()
            : base("live", "2016-11-01", "AddCustomLiveStreamTranscode", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string resWithSource;

		private string gop;

		private string audioCodec;

		private string kmsUID;

		private int? height;

		private string app;

		private int? profile;

		private long? ownerId;

		private string extWithSource;

		private string bitrateWithSource;

		private string domain;

		private string template;

		private string lazy;

		private string kmsKeyExpireInterval;

		private string templateType;

		private string audioProfile;

		private string encryptParameters;

		private int? audioChannelNum;

		private int? fPS;

		private int? audioRate;

		private string fpsWithSource;

		private int? audioBitrate;

		private int? width;

		private int? videoBitrate;

		private string kmsKeyID;

		public string ResWithSource
		{
			get
			{
				return resWithSource;
			}
			set	
			{
				resWithSource = value;
				DictionaryUtil.Add(QueryParameters, "ResWithSource", value);
			}
		}

		public string Gop
		{
			get
			{
				return gop;
			}
			set	
			{
				gop = value;
				DictionaryUtil.Add(QueryParameters, "Gop", value);
			}
		}

		public string AudioCodec
		{
			get
			{
				return audioCodec;
			}
			set	
			{
				audioCodec = value;
				DictionaryUtil.Add(QueryParameters, "AudioCodec", value);
			}
		}

		public string KmsUID
		{
			get
			{
				return kmsUID;
			}
			set	
			{
				kmsUID = value;
				DictionaryUtil.Add(QueryParameters, "KmsUID", value);
			}
		}

		public int? Height
		{
			get
			{
				return height;
			}
			set	
			{
				height = value;
				DictionaryUtil.Add(QueryParameters, "Height", value.ToString());
			}
		}

		public string App
		{
			get
			{
				return app;
			}
			set	
			{
				app = value;
				DictionaryUtil.Add(QueryParameters, "App", value);
			}
		}

		public int? Profile
		{
			get
			{
				return profile;
			}
			set	
			{
				profile = value;
				DictionaryUtil.Add(QueryParameters, "Profile", value.ToString());
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

		public string ExtWithSource
		{
			get
			{
				return extWithSource;
			}
			set	
			{
				extWithSource = value;
				DictionaryUtil.Add(QueryParameters, "ExtWithSource", value);
			}
		}

		public string BitrateWithSource
		{
			get
			{
				return bitrateWithSource;
			}
			set	
			{
				bitrateWithSource = value;
				DictionaryUtil.Add(QueryParameters, "BitrateWithSource", value);
			}
		}

		public string Domain
		{
			get
			{
				return domain;
			}
			set	
			{
				domain = value;
				DictionaryUtil.Add(QueryParameters, "Domain", value);
			}
		}

		public string Template
		{
			get
			{
				return template;
			}
			set	
			{
				template = value;
				DictionaryUtil.Add(QueryParameters, "Template", value);
			}
		}

		public string Lazy
		{
			get
			{
				return lazy;
			}
			set	
			{
				lazy = value;
				DictionaryUtil.Add(QueryParameters, "Lazy", value);
			}
		}

		public string KmsKeyExpireInterval
		{
			get
			{
				return kmsKeyExpireInterval;
			}
			set	
			{
				kmsKeyExpireInterval = value;
				DictionaryUtil.Add(QueryParameters, "KmsKeyExpireInterval", value);
			}
		}

		public string TemplateType
		{
			get
			{
				return templateType;
			}
			set	
			{
				templateType = value;
				DictionaryUtil.Add(QueryParameters, "TemplateType", value);
			}
		}

		public string AudioProfile
		{
			get
			{
				return audioProfile;
			}
			set	
			{
				audioProfile = value;
				DictionaryUtil.Add(QueryParameters, "AudioProfile", value);
			}
		}

		public string EncryptParameters
		{
			get
			{
				return encryptParameters;
			}
			set	
			{
				encryptParameters = value;
				DictionaryUtil.Add(QueryParameters, "EncryptParameters", value);
			}
		}

		public int? AudioChannelNum
		{
			get
			{
				return audioChannelNum;
			}
			set	
			{
				audioChannelNum = value;
				DictionaryUtil.Add(QueryParameters, "AudioChannelNum", value.ToString());
			}
		}

		public int? FPS
		{
			get
			{
				return fPS;
			}
			set	
			{
				fPS = value;
				DictionaryUtil.Add(QueryParameters, "FPS", value.ToString());
			}
		}

		public int? AudioRate
		{
			get
			{
				return audioRate;
			}
			set	
			{
				audioRate = value;
				DictionaryUtil.Add(QueryParameters, "AudioRate", value.ToString());
			}
		}

		public string FpsWithSource
		{
			get
			{
				return fpsWithSource;
			}
			set	
			{
				fpsWithSource = value;
				DictionaryUtil.Add(QueryParameters, "FpsWithSource", value);
			}
		}

		public int? AudioBitrate
		{
			get
			{
				return audioBitrate;
			}
			set	
			{
				audioBitrate = value;
				DictionaryUtil.Add(QueryParameters, "AudioBitrate", value.ToString());
			}
		}

		public int? Width
		{
			get
			{
				return width;
			}
			set	
			{
				width = value;
				DictionaryUtil.Add(QueryParameters, "Width", value.ToString());
			}
		}

		public int? VideoBitrate
		{
			get
			{
				return videoBitrate;
			}
			set	
			{
				videoBitrate = value;
				DictionaryUtil.Add(QueryParameters, "VideoBitrate", value.ToString());
			}
		}

		public string KmsKeyID
		{
			get
			{
				return kmsKeyID;
			}
			set	
			{
				kmsKeyID = value;
				DictionaryUtil.Add(QueryParameters, "KmsKeyID", value);
			}
		}

        public override AddCustomLiveStreamTranscodeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddCustomLiveStreamTranscodeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
