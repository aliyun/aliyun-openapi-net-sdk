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
    public class CreateGatewayFileShareRequest : RpcAcsRequest<CreateGatewayFileShareResponse>
    {
        public CreateGatewayFileShareRequest()
            : base("sgw", "2018-05-11", "CreateGatewayFileShare", "hcs_sgw", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.sgw.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.sgw.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? inPlace;

		private string ossEndpoint;

		private string readWriteClientList;

		private bool? bypassCacheRead;

		private int? backendLimit;

		private string squash;

		private string readOnlyClientList;

		private string securityToken;

		private long? kmsRotatePeriod;

		private bool? remoteSyncDownload;

		private string shareProtocol;

		private bool? nfsV4Optimization;

		private bool? accessBasedEnumeration;

		private string gatewayId;

		private bool? supportArchive;

		private string cacheMode;

		private string localFilePath;

		private string partialSyncPaths;

		private int? downloadLimit;

		private string readOnlyUserList;

		private bool? fastReclaim;

		private bool? windowsAcl;

		private string name;

		private string ossBucketName;

		private bool? transferAcceleration;

		private string clientSideCmk;

		private string pathPrefix;

		private bool? browsable;

		private string readWriteUserList;

		private int? pollingInterval;

		private string serverSideAlgorithm;

		private string serverSideCmk;

		private bool? serverSideEncryption;

		private bool? ignoreDelete;

		private long? lagPeriod;

		private bool? directIO;

		private bool? clientSideEncryption;

		private bool? ossBucketSsl;

		private bool? remoteSync;

		private int? frontendLimit;

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

		public string ShareProtocol
		{
			get
			{
				return shareProtocol;
			}
			set	
			{
				shareProtocol = value;
				DictionaryUtil.Add(QueryParameters, "ShareProtocol", value);
			}
		}

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

		public bool? SupportArchive
		{
			get
			{
				return supportArchive;
			}
			set	
			{
				supportArchive = value;
				DictionaryUtil.Add(QueryParameters, "SupportArchive", value.ToString());
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

		public string PartialSyncPaths
		{
			get
			{
				return partialSyncPaths;
			}
			set	
			{
				partialSyncPaths = value;
				DictionaryUtil.Add(QueryParameters, "PartialSyncPaths", value);
			}
		}

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

		public string PathPrefix
		{
			get
			{
				return pathPrefix;
			}
			set	
			{
				pathPrefix = value;
				DictionaryUtil.Add(QueryParameters, "PathPrefix", value);
			}
		}

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

		public string ServerSideAlgorithm
		{
			get
			{
				return serverSideAlgorithm;
			}
			set	
			{
				serverSideAlgorithm = value;
				DictionaryUtil.Add(QueryParameters, "ServerSideAlgorithm", value);
			}
		}

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

        public override CreateGatewayFileShareResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateGatewayFileShareResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
