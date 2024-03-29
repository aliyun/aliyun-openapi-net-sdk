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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.sgw.Transform;
using Aliyun.Acs.sgw.Transform.V20180511;

namespace Aliyun.Acs.sgw.Model.V20180511
{
    public class UpdateGatewayFileShareRequest : RpcAcsRequest<UpdateGatewayFileShareResponse>
    {
        public UpdateGatewayFileShareRequest()
            : base("sgw", "2018-05-11", "UpdateGatewayFileShare", "hcs_sgw", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.sgw.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.sgw.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clientSideCmk;

		private bool? inPlace;

		private bool? browsable;

		private string readWriteUserList;

		private int? pollingInterval;

		private string readWriteClientList;

		private bool? bypassCacheRead;

		private int? backendLimit;

		private string squash;

		private string readOnlyClientList;

		private string serverSideCmk;

		private string securityToken;

		private long? kmsRotatePeriod;

		private bool? remoteSyncDownload;

		private bool? serverSideEncryption;

		private bool? nfsV4Optimization;

		private bool? accessBasedEnumeration;

		private string gatewayId;

		private bool? ignoreDelete;

		private long? lagPeriod;

		private bool? directIO;

		private bool? clientSideEncryption;

		private string cacheMode;

		private int? downloadLimit;

		private string readOnlyUserList;

		private bool? fastReclaim;

		private bool? windowsAcl;

		private string name;

		private string indexId;

		private bool? transferAcceleration;

		private bool? remoteSync;

		private int? frontendLimit;

		[JsonProperty(PropertyName = "ClientSideCmk")]
		public string ClientSideCmk
		{
			get
			{
				return clientSideCmk;
			}
			set	
			{
				clientSideCmk = value;
				DictionaryUtil.Add(QueryParameters, "ClientSideCmk", value);
			}
		}

		[JsonProperty(PropertyName = "InPlace")]
		public bool? InPlace
		{
			get
			{
				return inPlace;
			}
			set	
			{
				inPlace = value;
				DictionaryUtil.Add(QueryParameters, "InPlace", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Browsable")]
		public bool? Browsable
		{
			get
			{
				return browsable;
			}
			set	
			{
				browsable = value;
				DictionaryUtil.Add(QueryParameters, "Browsable", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ReadWriteUserList")]
		public string ReadWriteUserList
		{
			get
			{
				return readWriteUserList;
			}
			set	
			{
				readWriteUserList = value;
				DictionaryUtil.Add(QueryParameters, "ReadWriteUserList", value);
			}
		}

		[JsonProperty(PropertyName = "PollingInterval")]
		public int? PollingInterval
		{
			get
			{
				return pollingInterval;
			}
			set	
			{
				pollingInterval = value;
				DictionaryUtil.Add(QueryParameters, "PollingInterval", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ReadWriteClientList")]
		public string ReadWriteClientList
		{
			get
			{
				return readWriteClientList;
			}
			set	
			{
				readWriteClientList = value;
				DictionaryUtil.Add(QueryParameters, "ReadWriteClientList", value);
			}
		}

		[JsonProperty(PropertyName = "BypassCacheRead")]
		public bool? BypassCacheRead
		{
			get
			{
				return bypassCacheRead;
			}
			set	
			{
				bypassCacheRead = value;
				DictionaryUtil.Add(QueryParameters, "BypassCacheRead", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "BackendLimit")]
		public int? BackendLimit
		{
			get
			{
				return backendLimit;
			}
			set	
			{
				backendLimit = value;
				DictionaryUtil.Add(QueryParameters, "BackendLimit", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Squash")]
		public string Squash
		{
			get
			{
				return squash;
			}
			set	
			{
				squash = value;
				DictionaryUtil.Add(QueryParameters, "Squash", value);
			}
		}

		[JsonProperty(PropertyName = "ReadOnlyClientList")]
		public string ReadOnlyClientList
		{
			get
			{
				return readOnlyClientList;
			}
			set	
			{
				readOnlyClientList = value;
				DictionaryUtil.Add(QueryParameters, "ReadOnlyClientList", value);
			}
		}

		[JsonProperty(PropertyName = "ServerSideCmk")]
		public string ServerSideCmk
		{
			get
			{
				return serverSideCmk;
			}
			set	
			{
				serverSideCmk = value;
				DictionaryUtil.Add(QueryParameters, "ServerSideCmk", value);
			}
		}

		[JsonProperty(PropertyName = "SecurityToken")]
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

		[JsonProperty(PropertyName = "KmsRotatePeriod")]
		public long? KmsRotatePeriod
		{
			get
			{
				return kmsRotatePeriod;
			}
			set	
			{
				kmsRotatePeriod = value;
				DictionaryUtil.Add(QueryParameters, "KmsRotatePeriod", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "RemoteSyncDownload")]
		public bool? RemoteSyncDownload
		{
			get
			{
				return remoteSyncDownload;
			}
			set	
			{
				remoteSyncDownload = value;
				DictionaryUtil.Add(QueryParameters, "RemoteSyncDownload", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ServerSideEncryption")]
		public bool? ServerSideEncryption
		{
			get
			{
				return serverSideEncryption;
			}
			set	
			{
				serverSideEncryption = value;
				DictionaryUtil.Add(QueryParameters, "ServerSideEncryption", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "NfsV4Optimization")]
		public bool? NfsV4Optimization
		{
			get
			{
				return nfsV4Optimization;
			}
			set	
			{
				nfsV4Optimization = value;
				DictionaryUtil.Add(QueryParameters, "NfsV4Optimization", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "AccessBasedEnumeration")]
		public bool? AccessBasedEnumeration
		{
			get
			{
				return accessBasedEnumeration;
			}
			set	
			{
				accessBasedEnumeration = value;
				DictionaryUtil.Add(QueryParameters, "AccessBasedEnumeration", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "GatewayId")]
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

		[JsonProperty(PropertyName = "IgnoreDelete")]
		public bool? IgnoreDelete
		{
			get
			{
				return ignoreDelete;
			}
			set	
			{
				ignoreDelete = value;
				DictionaryUtil.Add(QueryParameters, "IgnoreDelete", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "LagPeriod")]
		public long? LagPeriod
		{
			get
			{
				return lagPeriod;
			}
			set	
			{
				lagPeriod = value;
				DictionaryUtil.Add(QueryParameters, "LagPeriod", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "DirectIO")]
		public bool? DirectIO
		{
			get
			{
				return directIO;
			}
			set	
			{
				directIO = value;
				DictionaryUtil.Add(QueryParameters, "DirectIO", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ClientSideEncryption")]
		public bool? ClientSideEncryption
		{
			get
			{
				return clientSideEncryption;
			}
			set	
			{
				clientSideEncryption = value;
				DictionaryUtil.Add(QueryParameters, "ClientSideEncryption", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "CacheMode")]
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

		[JsonProperty(PropertyName = "DownloadLimit")]
		public int? DownloadLimit
		{
			get
			{
				return downloadLimit;
			}
			set	
			{
				downloadLimit = value;
				DictionaryUtil.Add(QueryParameters, "DownloadLimit", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ReadOnlyUserList")]
		public string ReadOnlyUserList
		{
			get
			{
				return readOnlyUserList;
			}
			set	
			{
				readOnlyUserList = value;
				DictionaryUtil.Add(QueryParameters, "ReadOnlyUserList", value);
			}
		}

		[JsonProperty(PropertyName = "FastReclaim")]
		public bool? FastReclaim
		{
			get
			{
				return fastReclaim;
			}
			set	
			{
				fastReclaim = value;
				DictionaryUtil.Add(QueryParameters, "FastReclaim", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "WindowsAcl")]
		public bool? WindowsAcl
		{
			get
			{
				return windowsAcl;
			}
			set	
			{
				windowsAcl = value;
				DictionaryUtil.Add(QueryParameters, "WindowsAcl", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Name")]
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

		[JsonProperty(PropertyName = "IndexId")]
		public string IndexId
		{
			get
			{
				return indexId;
			}
			set	
			{
				indexId = value;
				DictionaryUtil.Add(QueryParameters, "IndexId", value);
			}
		}

		[JsonProperty(PropertyName = "TransferAcceleration")]
		public bool? TransferAcceleration
		{
			get
			{
				return transferAcceleration;
			}
			set	
			{
				transferAcceleration = value;
				DictionaryUtil.Add(QueryParameters, "TransferAcceleration", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "RemoteSync")]
		public bool? RemoteSync
		{
			get
			{
				return remoteSync;
			}
			set	
			{
				remoteSync = value;
				DictionaryUtil.Add(QueryParameters, "RemoteSync", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "FrontendLimit")]
		public int? FrontendLimit
		{
			get
			{
				return frontendLimit;
			}
			set	
			{
				frontendLimit = value;
				DictionaryUtil.Add(QueryParameters, "FrontendLimit", value.ToString());
			}
		}

        public override UpdateGatewayFileShareResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateGatewayFileShareResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
