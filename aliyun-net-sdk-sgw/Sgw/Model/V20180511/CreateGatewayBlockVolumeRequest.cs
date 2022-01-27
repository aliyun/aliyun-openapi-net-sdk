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
using Aliyun.Acs.sgw.Transform;
using Aliyun.Acs.sgw.Transform.V20180511;

namespace Aliyun.Acs.sgw.Model.V20180511
{
    public class CreateGatewayBlockVolumeRequest : RpcAcsRequest<CreateGatewayBlockVolumeResponse>
    {
        public CreateGatewayBlockVolumeRequest()
            : base("sgw", "2018-05-11", "CreateGatewayBlockVolume", "hcs_sgw", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.sgw.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.sgw.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string ossEndpoint;

		private bool? recovery;

		private string securityToken;

		private int? chunkSize;

		private string gatewayId;

		private string volumeProtocol;

		private bool? chapEnabled;

		private string cacheMode;

		private string localFilePath;

		private bool? ossBucketSsl;

		private long? size;

		private string chapInUser;

		private string name;

		private string ossBucketName;

		private string chapInPassword;

		public string OssEndpoint
		{
			get
			{
				return ossEndpoint;
			}
			set	
			{
				ossEndpoint = value;
				DictionaryUtil.Add(QueryParameters, "OssEndpoint", value);
			}
		}

		public bool? Recovery
		{
			get
			{
				return recovery;
			}
			set	
			{
				recovery = value;
				DictionaryUtil.Add(QueryParameters, "Recovery", value.ToString());
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public int? ChunkSize
		{
			get
			{
				return chunkSize;
			}
			set	
			{
				chunkSize = value;
				DictionaryUtil.Add(QueryParameters, "ChunkSize", value.ToString());
			}
		}

		public string GatewayId
		{
			get
			{
				return gatewayId;
			}
			set	
			{
				gatewayId = value;
				DictionaryUtil.Add(QueryParameters, "GatewayId", value);
			}
		}

		public string VolumeProtocol
		{
			get
			{
				return volumeProtocol;
			}
			set	
			{
				volumeProtocol = value;
				DictionaryUtil.Add(QueryParameters, "VolumeProtocol", value);
			}
		}

		public bool? ChapEnabled
		{
			get
			{
				return chapEnabled;
			}
			set	
			{
				chapEnabled = value;
				DictionaryUtil.Add(QueryParameters, "ChapEnabled", value.ToString());
			}
		}

		public string CacheMode
		{
			get
			{
				return cacheMode;
			}
			set	
			{
				cacheMode = value;
				DictionaryUtil.Add(QueryParameters, "CacheMode", value);
			}
		}

		public string LocalFilePath
		{
			get
			{
				return localFilePath;
			}
			set	
			{
				localFilePath = value;
				DictionaryUtil.Add(QueryParameters, "LocalFilePath", value);
			}
		}

		public bool? OssBucketSsl
		{
			get
			{
				return ossBucketSsl;
			}
			set	
			{
				ossBucketSsl = value;
				DictionaryUtil.Add(QueryParameters, "OssBucketSsl", value.ToString());
			}
		}

		public long? Size
		{
			get
			{
				return size;
			}
			set	
			{
				size = value;
				DictionaryUtil.Add(QueryParameters, "Size", value.ToString());
			}
		}

		public string ChapInUser
		{
			get
			{
				return chapInUser;
			}
			set	
			{
				chapInUser = value;
				DictionaryUtil.Add(QueryParameters, "ChapInUser", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string OssBucketName
		{
			get
			{
				return ossBucketName;
			}
			set	
			{
				ossBucketName = value;
				DictionaryUtil.Add(QueryParameters, "OssBucketName", value);
			}
		}

		public string ChapInPassword
		{
			get
			{
				return chapInPassword;
			}
			set	
			{
				chapInPassword = value;
				DictionaryUtil.Add(QueryParameters, "ChapInPassword", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateGatewayBlockVolumeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateGatewayBlockVolumeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
