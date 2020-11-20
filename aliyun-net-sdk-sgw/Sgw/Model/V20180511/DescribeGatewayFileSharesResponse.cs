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

namespace Aliyun.Acs.sgw.Model.V20180511
{
	public class DescribeGatewayFileSharesResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private List<DescribeGatewayFileShares_FileShare> fileShares;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public List<DescribeGatewayFileShares_FileShare> FileShares
		{
			get
			{
				return fileShares;
			}
			set	
			{
				fileShares = value;
			}
		}

		public class DescribeGatewayFileShares_FileShare
		{

			private string name;

			private string diskId;

			private string diskType;

			private string protocol;

			private long? size;

			private bool? enabled;

			private string state;

			private long? totalUpload;

			private long? totalDownload;

			private string ossBucketName;

			private string ossEndpoint;

			private bool? ossBucketSsl;

			private string localPath;

			private string cacheMode;

			private string address;

			private string serialNumber;

			private string indexId;

			private bool? remoteSync;

			private int? pollingInterval;

			private bool? ignoreDelete;

			private int? feLimit;

			private int? beLimit;

			private bool? inPlace;

			private bool? browsable;

			private string squash;

			private string rwUserList;

			private string roUserList;

			private string rwClientList;

			private string roClientList;

			private long? ossUsed;

			private long? used;

			private long? inRate;

			private long? outRate;

			private long? lagPeriod;

			private bool? directIO;

			private string nfsFullPath;

			private long? fileNumLimit;

			private long? fsSizeLimit;

			private bool? serverSideEncryption;

			private string serverSideCmk;

			private bool? clientSideEncryption;

			private string clientSideCmk;

			private string kmsRotatePeriod;

			private string ossHealth;

			private string pathPrefix;

			private bool? fastReclaim;

			private bool? supportArchive;

			private long? remainingMetaSpace;

			private string mnsHealth;

			private string expressSyncId;

			private bool? windowsAcl;

			private bool? accessBasedEnumeration;

			private bool? nfsV4Optimization;

			private bool? bucketsStub;

			private string bucketInfos;

			private string obsoleteBuckets;

			private bool? transferAcceleration;

			private int? downloadLimit;

			private bool? remoteSyncDownload;

			private string partialSyncPaths;

			private int? syncProgress;

			private long? uploadQueue;

			private long? downloadQueue;

			private long? downloadRate;

			private long? activeMessages;

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string DiskId
			{
				get
				{
					return diskId;
				}
				set	
				{
					diskId = value;
				}
			}

			public string DiskType
			{
				get
				{
					return diskType;
				}
				set	
				{
					diskType = value;
				}
			}

			public string Protocol
			{
				get
				{
					return protocol;
				}
				set	
				{
					protocol = value;
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
				}
			}

			public bool? Enabled
			{
				get
				{
					return enabled;
				}
				set	
				{
					enabled = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public long? TotalUpload
			{
				get
				{
					return totalUpload;
				}
				set	
				{
					totalUpload = value;
				}
			}

			public long? TotalDownload
			{
				get
				{
					return totalDownload;
				}
				set	
				{
					totalDownload = value;
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
				}
			}

			public string LocalPath
			{
				get
				{
					return localPath;
				}
				set	
				{
					localPath = value;
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
				}
			}

			public string Address
			{
				get
				{
					return address;
				}
				set	
				{
					address = value;
				}
			}

			public string SerialNumber
			{
				get
				{
					return serialNumber;
				}
				set	
				{
					serialNumber = value;
				}
			}

			public string IndexId
			{
				get
				{
					return indexId;
				}
				set	
				{
					indexId = value;
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
				}
			}

			public int? FeLimit
			{
				get
				{
					return feLimit;
				}
				set	
				{
					feLimit = value;
				}
			}

			public int? BeLimit
			{
				get
				{
					return beLimit;
				}
				set	
				{
					beLimit = value;
				}
			}

			public bool? InPlace
			{
				get
				{
					return inPlace;
				}
				set	
				{
					inPlace = value;
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
				}
			}

			public string RwUserList
			{
				get
				{
					return rwUserList;
				}
				set	
				{
					rwUserList = value;
				}
			}

			public string RoUserList
			{
				get
				{
					return roUserList;
				}
				set	
				{
					roUserList = value;
				}
			}

			public string RwClientList
			{
				get
				{
					return rwClientList;
				}
				set	
				{
					rwClientList = value;
				}
			}

			public string RoClientList
			{
				get
				{
					return roClientList;
				}
				set	
				{
					roClientList = value;
				}
			}

			public long? OssUsed
			{
				get
				{
					return ossUsed;
				}
				set	
				{
					ossUsed = value;
				}
			}

			public long? Used
			{
				get
				{
					return used;
				}
				set	
				{
					used = value;
				}
			}

			public long? InRate
			{
				get
				{
					return inRate;
				}
				set	
				{
					inRate = value;
				}
			}

			public long? OutRate
			{
				get
				{
					return outRate;
				}
				set	
				{
					outRate = value;
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
				}
			}

			public string NfsFullPath
			{
				get
				{
					return nfsFullPath;
				}
				set	
				{
					nfsFullPath = value;
				}
			}

			public long? FileNumLimit
			{
				get
				{
					return fileNumLimit;
				}
				set	
				{
					fileNumLimit = value;
				}
			}

			public long? FsSizeLimit
			{
				get
				{
					return fsSizeLimit;
				}
				set	
				{
					fsSizeLimit = value;
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
				}
			}

			public string KmsRotatePeriod
			{
				get
				{
					return kmsRotatePeriod;
				}
				set	
				{
					kmsRotatePeriod = value;
				}
			}

			public string OssHealth
			{
				get
				{
					return ossHealth;
				}
				set	
				{
					ossHealth = value;
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
				}
			}

			public long? RemainingMetaSpace
			{
				get
				{
					return remainingMetaSpace;
				}
				set	
				{
					remainingMetaSpace = value;
				}
			}

			public string MnsHealth
			{
				get
				{
					return mnsHealth;
				}
				set	
				{
					mnsHealth = value;
				}
			}

			public string ExpressSyncId
			{
				get
				{
					return expressSyncId;
				}
				set	
				{
					expressSyncId = value;
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
				}
			}

			public bool? BucketsStub
			{
				get
				{
					return bucketsStub;
				}
				set	
				{
					bucketsStub = value;
				}
			}

			public string BucketInfos
			{
				get
				{
					return bucketInfos;
				}
				set	
				{
					bucketInfos = value;
				}
			}

			public string ObsoleteBuckets
			{
				get
				{
					return obsoleteBuckets;
				}
				set	
				{
					obsoleteBuckets = value;
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
				}
			}

			public int? SyncProgress
			{
				get
				{
					return syncProgress;
				}
				set	
				{
					syncProgress = value;
				}
			}

			public long? UploadQueue
			{
				get
				{
					return uploadQueue;
				}
				set	
				{
					uploadQueue = value;
				}
			}

			public long? DownloadQueue
			{
				get
				{
					return downloadQueue;
				}
				set	
				{
					downloadQueue = value;
				}
			}

			public long? DownloadRate
			{
				get
				{
					return downloadRate;
				}
				set	
				{
					downloadRate = value;
				}
			}

			public long? ActiveMessages
			{
				get
				{
					return activeMessages;
				}
				set	
				{
					activeMessages = value;
				}
			}
		}
	}
}
