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
using Aliyun.Acs.lto;
using Aliyun.Acs.lto.Transform;
using Aliyun.Acs.lto.Transform.V20210707;

namespace Aliyun.Acs.lto.Model.V20210707
{
    public class UploadIoTDataToBlockchainRequest : RpcAcsRequest<UploadIoTDataToBlockchainResponse>
    {
        public UploadIoTDataToBlockchainRequest()
            : base("lto", "2021-07-07", "UploadIoTDataToBlockchain")
        {
			Method = MethodType.POST;
        }

		private string iotIdSource;

		private string iotDataToken;

		private string privacyData;

		private string iotId;

		private string iotDataDigest;

		private string iotDataDID;

		private string plainData;

		private string iotAuthType;

		private string iotIdServiceProvider;

		public string IotIdSource
		{
			get
			{
				return iotIdSource;
			}
			set	
			{
				iotIdSource = value;
				DictionaryUtil.Add(QueryParameters, "IotIdSource", value);
			}
		}

		public string IotDataToken
		{
			get
			{
				return iotDataToken;
			}
			set	
			{
				iotDataToken = value;
				DictionaryUtil.Add(QueryParameters, "IotDataToken", value);
			}
		}

		public string PrivacyData
		{
			get
			{
				return privacyData;
			}
			set	
			{
				privacyData = value;
				DictionaryUtil.Add(QueryParameters, "PrivacyData", value);
			}
		}

		public string IotId
		{
			get
			{
				return iotId;
			}
			set	
			{
				iotId = value;
				DictionaryUtil.Add(QueryParameters, "IotId", value);
			}
		}

		public string IotDataDigest
		{
			get
			{
				return iotDataDigest;
			}
			set	
			{
				iotDataDigest = value;
				DictionaryUtil.Add(QueryParameters, "IotDataDigest", value);
			}
		}

		public string IotDataDID
		{
			get
			{
				return iotDataDID;
			}
			set	
			{
				iotDataDID = value;
				DictionaryUtil.Add(QueryParameters, "IotDataDID", value);
			}
		}

		public string PlainData
		{
			get
			{
				return plainData;
			}
			set	
			{
				plainData = value;
				DictionaryUtil.Add(QueryParameters, "PlainData", value);
			}
		}

		public string IotAuthType
		{
			get
			{
				return iotAuthType;
			}
			set	
			{
				iotAuthType = value;
				DictionaryUtil.Add(QueryParameters, "IotAuthType", value);
			}
		}

		public string IotIdServiceProvider
		{
			get
			{
				return iotIdServiceProvider;
			}
			set	
			{
				iotIdServiceProvider = value;
				DictionaryUtil.Add(QueryParameters, "IotIdServiceProvider", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UploadIoTDataToBlockchainResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UploadIoTDataToBlockchainResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
