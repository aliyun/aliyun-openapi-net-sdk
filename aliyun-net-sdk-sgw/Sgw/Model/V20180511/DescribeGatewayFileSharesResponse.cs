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

namespace Aliyun.Acs.sgw.Model.V20180511
{
	public class DescribeGatewayFileSharesResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private string code;

		private bool? success;

		private List<DescribeGatewayFileShares_FileShare> fileShares;

		[JsonProperty(PropertyName = "Message")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Code")]
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

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "FileShares")]
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

			[JsonProperty(PropertyName = "SerialNumber")]
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
				}
			}

			[JsonProperty(PropertyName = "PartialSyncPaths")]
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

			[JsonProperty(PropertyName = "PathPrefix")]
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

			[JsonProperty(PropertyName = "BucketsStub")]
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

			[JsonProperty(PropertyName = "UploadQueue")]
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

			[JsonProperty(PropertyName = "DiskId")]
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

			[JsonProperty(PropertyName = "OssUsed")]
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

			[JsonProperty(PropertyName = "DownloadQueue")]
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

			[JsonProperty(PropertyName = "ActiveMessages")]
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
				}
			}

			[JsonProperty(PropertyName = "MnsHealth")]
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
				}
			}

			[JsonProperty(PropertyName = "DownloadRate")]
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

			[JsonProperty(PropertyName = "FeLimit")]
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

			[JsonProperty(PropertyName = "SupportArchive")]
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

			[JsonProperty(PropertyName = "OssEndpoint")]
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

			[JsonProperty(PropertyName = "OssHealth")]
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

			[JsonProperty(PropertyName = "OutRate")]
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
				}
			}

			[JsonProperty(PropertyName = "RwClientList")]
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

			[JsonProperty(PropertyName = "State")]
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

			[JsonProperty(PropertyName = "Protocol")]
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

			[JsonProperty(PropertyName = "OssBucketSsl")]
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
				}
			}

			[JsonProperty(PropertyName = "FileNumLimit")]
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
				}
			}

			[JsonProperty(PropertyName = "NfsFullPath")]
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

			[JsonProperty(PropertyName = "RemainingMetaSpace")]
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
				}
			}

			[JsonProperty(PropertyName = "Size")]
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
				}
			}

			[JsonProperty(PropertyName = "BucketInfos")]
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
				}
			}

			[JsonProperty(PropertyName = "TotalUpload")]
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

			[JsonProperty(PropertyName = "DiskType")]
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

			[JsonProperty(PropertyName = "Used")]
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
				}
			}

			[JsonProperty(PropertyName = "RoUserList")]
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

			[JsonProperty(PropertyName = "FsSizeLimit")]
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

			[JsonProperty(PropertyName = "TotalDownload")]
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

			[JsonProperty(PropertyName = "Enabled")]
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

			[JsonProperty(PropertyName = "HighWatermark")]
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

			[JsonProperty(PropertyName = "KmsRotatePeriod")]
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

			[JsonProperty(PropertyName = "Address")]
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
				}
			}

			[JsonProperty(PropertyName = "OssBucketName")]
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

			[JsonProperty(PropertyName = "ExpressSyncId")]
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
				}
			}

			[JsonProperty(PropertyName = "InRate")]
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

			[JsonProperty(PropertyName = "LowWatermark")]
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

			[JsonProperty(PropertyName = "SyncProgress")]
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

			[JsonProperty(PropertyName = "ServerSideAlgorithm")]
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

			[JsonProperty(PropertyName = "ObsoleteBuckets")]
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

			[JsonProperty(PropertyName = "BeLimit")]
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

			[JsonProperty(PropertyName = "LocalPath")]
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

			[JsonProperty(PropertyName = "RoClientList")]
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

			[JsonProperty(PropertyName = "RwUserList")]
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
				}
			}

			[JsonProperty(PropertyName = "Throttling")]
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
				}
			}
		}
	}
}
