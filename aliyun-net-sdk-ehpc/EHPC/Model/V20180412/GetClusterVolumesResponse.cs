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
	public class GetClusterVolumesResponse : AcsResponse
	{

		private string requestId;

		private string regionId;

		private List<GetClusterVolumes_VolumeInfo> volumes;

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

		public List<GetClusterVolumes_VolumeInfo> Volumes
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

		public class GetClusterVolumes_VolumeInfo
		{

			private string volumeId;

			private string volumeType;

			private string volumeProtocol;

			private string volumeMountpoint;

			private string remoteDirectory;

			private string localDirectory;

			private string location;

			private string jobQueue;

			private bool? mustKeep;

			private List<GetClusterVolumes_RoleInfo> roles;

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

			public bool? MustKeep
			{
				get
				{
					return mustKeep;
				}
				set	
				{
					mustKeep = value;
				}
			}

			public List<GetClusterVolumes_RoleInfo> Roles
			{
				get
				{
					return roles;
				}
				set	
				{
					roles = value;
				}
			}

			public class GetClusterVolumes_RoleInfo
			{

				private string name;

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
			}
		}
	}
}
