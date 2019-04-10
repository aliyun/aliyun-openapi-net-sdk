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

namespace Aliyun.Acs.EHPC.Model.V20180412
{
	public class ListVolumesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<ListVolumes_VolumeInfo> volumes;

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

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<ListVolumes_VolumeInfo> Volumes
		{
			get
			{
				return volumes;
			}
			set	
			{
				volumes = value;
			}
		}

		public class ListVolumes_VolumeInfo
		{

			private string regionId;

			private string clusterId;

			private string clusterName;

			private string volumeId;

			private string volumeType;

			private string volumeProtocol;

			private string volumeMountpoint;

			private string remoteDirectory;

			private List<ListVolumes_VolumeInfo1> additionalVolumes;

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string ClusterId
			{
				get
				{
					return clusterId;
				}
				set	
				{
					clusterId = value;
				}
			}

			public string ClusterName
			{
				get
				{
					return clusterName;
				}
				set	
				{
					clusterName = value;
				}
			}

			public string VolumeId
			{
				get
				{
					return volumeId;
				}
				set	
				{
					volumeId = value;
				}
			}

			public string VolumeType
			{
				get
				{
					return volumeType;
				}
				set	
				{
					volumeType = value;
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
				}
			}

			public string VolumeMountpoint
			{
				get
				{
					return volumeMountpoint;
				}
				set	
				{
					volumeMountpoint = value;
				}
			}

			public string RemoteDirectory
			{
				get
				{
					return remoteDirectory;
				}
				set	
				{
					remoteDirectory = value;
				}
			}

			public List<ListVolumes_VolumeInfo1> AdditionalVolumes
			{
				get
				{
					return additionalVolumes;
				}
				set	
				{
					additionalVolumes = value;
				}
			}

			public class ListVolumes_VolumeInfo1
			{

				private string volumeType;

				private string volumeId;

				private string volumeProtocol;

				private string volumeMountpoint;

				private string remoteDirectory;

				private string localDirectory;

				private string role;

				private string location;

				private string jobQueue;

				public string VolumeType
				{
					get
					{
						return volumeType;
					}
					set	
					{
						volumeType = value;
					}
				}

				public string VolumeId
				{
					get
					{
						return volumeId;
					}
					set	
					{
						volumeId = value;
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
					}
				}

				public string VolumeMountpoint
				{
					get
					{
						return volumeMountpoint;
					}
					set	
					{
						volumeMountpoint = value;
					}
				}

				public string RemoteDirectory
				{
					get
					{
						return remoteDirectory;
					}
					set	
					{
						remoteDirectory = value;
					}
				}

				public string LocalDirectory
				{
					get
					{
						return localDirectory;
					}
					set	
					{
						localDirectory = value;
					}
				}

				public string Role
				{
					get
					{
						return role;
					}
					set	
					{
						role = value;
					}
				}

				public string Location
				{
					get
					{
						return location;
					}
					set	
					{
						location = value;
					}
				}

				public string JobQueue
				{
					get
					{
						return jobQueue;
					}
					set	
					{
						jobQueue = value;
					}
				}
			}
		}
	}
}
