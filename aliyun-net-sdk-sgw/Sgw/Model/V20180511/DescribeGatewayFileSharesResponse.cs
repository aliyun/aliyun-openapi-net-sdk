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

		private string message;

		private string requestId;

		private string code;

		private bool? success;

		private List<DescribeGatewayFileShares_FileShare> fileShares;

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

			private string serialNumber;

			private string clientSideCmk;

			private string partialSyncPaths;

			private string pathPrefix;

			private bool? bucketsStub;

			private long? uploadQueue;

			private string diskId;

			private long? ossUsed;

			private long? downloadQueue;

			private long? activeMessages;

			private string indexId;

			private string mnsHealth;

			private bool? accessBasedEnumeration;

			private long? downloadRate;

			private int? feLimit;

			private bool? supportArchive;

			private string ossEndpoint;

			private string ossHealth;

			private long? outRate;

			private string serverSideCmk;

			private string rwClientList;

			private string state;

			private string protocol;

			private bool? ossBucketSsl;

			private int? downloadLimit;

			private bool? inPlace;

			private bool? remoteSync;

			private long? fileNumLimit;

			private string squash;

			private string nfsFullPath;

			private long? remainingMetaSpace;

			private bool? transferAcceleration;

			private long? size;

			private bool? serverSideEncryption;

			private bool? windowsAcl;

			private bool? remoteSyncDownload;

			private bool? clientSideEncryption;

			private string bucketInfos;

			private bool? nfsV4Optimization;

			private long? totalUpload;

			private string diskType;

			private long? used;

			private bool? ignoreDelete;

			private string roUserList;

			private long? fsSizeLimit;

			private long? totalDownload;

			private bool? enabled;

			private int? highWatermark;

			private string kmsRotatePeriod;

			private string address;

			private int? pollingInterval;

			private string name;

			private string ossBucketName;

			private string expressSyncId;

			private long? lagPeriod;

			private bool? directIO;

			private string cacheMode;

			private long? inRate;

			private int? lowWatermark;

			private int? syncProgress;

			private string serverSideAlgorithm;

			private string obsoleteBuckets;

			private int? beLimit;

			private string localPath;

			private string roClientList;

			private string rwUserList;

			private bool? fastReclaim;

			private bool? browsable;

			private bool? throttling;

			private bool? bypassCacheRead;

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

			public int? HighWatermark
			{
				get
				{
					return highWatermark;
				}
				set	
				{
					highWatermark = value;
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

			public int? LowWatermark
			{
				get
				{
					return lowWatermark;
				}
				set	
				{
					lowWatermark = value;
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

			public string ServerSideAlgorithm
			{
				get
				{
					return serverSideAlgorithm;
				}
				set	
				{
					serverSideAlgorithm = value;
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

			public bool? Throttling
			{
				get
				{
					return throttling;
				}
				set	
				{
					throttling = value;
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
				}
			}
		}
	}
}
