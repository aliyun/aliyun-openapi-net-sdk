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
	public class DescribeGatewayBlockVolumesResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private List<DescribeGatewayBlockVolumes_BlockVolume> blockVolumes;

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

			private int? chunkSize;

			private string cacheMode;

			private string address;

			private string serialNumber;

			private string indexId;

			private string target;

			private int? port;

			private int? lunId;

			private bool? chapEnabled;

			private string chapInUser;

			private string chapOutUser;

			private int? status;

			private int? volumeState;

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
		}
	}
}
