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
	public class DescribeGatewayBlockVolumesResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private string code;

		private bool? success;

		private List<DescribeGatewayBlockVolumes_BlockVolume> blockVolumes;

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

		[JsonProperty(PropertyName = "BlockVolumes")]
		public List<DescribeGatewayBlockVolumes_BlockVolume> BlockVolumes
		{
			get
			{
				return blockVolumes;
			}
			set	
			{
				blockVolumes = value;
			}
		}

		public class DescribeGatewayBlockVolumes_BlockVolume
		{

			private int? status;

			private string serialNumber;

			private int? chunkSize;

			private long? totalUpload;

			private string diskType;

			private string diskId;

			private int? port;

			private string indexId;

			private string chapOutUser;

			private long? totalDownload;

			private bool? chapEnabled;

			private bool? enabled;

			private string address;

			private string name;

			private string target;

			private string ossEndpoint;

			private string ossBucketName;

			private string cacheMode;

			private string state;

			private string protocol;

			private int? lunId;

			private bool? ossBucketSsl;

			private int? volumeState;

			private string localPath;

			private string chapInUser;

			private long? size;

			[JsonProperty(PropertyName = "Status")]
			public int? Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

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

			[JsonProperty(PropertyName = "ChunkSize")]
			public int? ChunkSize
			{
				get
				{
					return chunkSize;
				}
				set	
				{
					chunkSize = value;
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

			[JsonProperty(PropertyName = "Port")]
			public int? Port
			{
				get
				{
					return port;
				}
				set	
				{
					port = value;
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

			[JsonProperty(PropertyName = "ChapOutUser")]
			public string ChapOutUser
			{
				get
				{
					return chapOutUser;
				}
				set	
				{
					chapOutUser = value;
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

			[JsonProperty(PropertyName = "ChapEnabled")]
			public bool? ChapEnabled
			{
				get
				{
					return chapEnabled;
				}
				set	
				{
					chapEnabled = value;
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

			[JsonProperty(PropertyName = "Target")]
			public string Target
			{
				get
				{
					return target;
				}
				set	
				{
					target = value;
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

			[JsonProperty(PropertyName = "LunId")]
			public int? LunId
			{
				get
				{
					return lunId;
				}
				set	
				{
					lunId = value;
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

			[JsonProperty(PropertyName = "VolumeState")]
			public int? VolumeState
			{
				get
				{
					return volumeState;
				}
				set	
				{
					volumeState = value;
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

			[JsonProperty(PropertyName = "ChapInUser")]
			public string ChapInUser
			{
				get
				{
					return chapInUser;
				}
				set	
				{
					chapInUser = value;
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
		}
	}
}
