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

namespace Aliyun.Acs.NAS.Model.V20170626
{
	public class DescribeFileSystemsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageSize;

		private int? pageNumber;

		private List<DescribeFileSystems_FileSystem> fileSystems;

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

		public List<DescribeFileSystems_FileSystem> FileSystems
		{
			get
			{
				return fileSystems;
			}
			set	
			{
				fileSystems = value;
			}
		}

		public class DescribeFileSystems_FileSystem
		{

			private string fileSystemId;

			private string description;

			private string createTime;

			private string expiredTime;

			private string regionId;

			private string zoneId;

			private string protocolType;

			private string storageType;

			private string fileSystemType;

			private int? encryptType;

			private long? meteredSize;

			private long? meteredIASize;

			private long? bandwidth;

			private long? capacity;

			private string autoSnapshotPolicyId;

			private string status;

			private string chargeType;

			private long? mountTargetCountLimit;

			private string nasNamespaceId;

			private string kMSKeyId;

			private string version;

			private List<DescribeFileSystems_MountTarget> mountTargets;

			private List<DescribeFileSystems_Package> packages;

			private List<DescribeFileSystems_Tag2> tags;

			private List<string> supportedFeatures;

			private DescribeFileSystems_Ldap ldap;

			public string FileSystemId
			{
				get
				{
					return fileSystemId;
				}
				set	
				{
					fileSystemId = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string ExpiredTime
			{
				get
				{
					return expiredTime;
				}
				set	
				{
					expiredTime = value;
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

			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			public string ProtocolType
			{
				get
				{
					return protocolType;
				}
				set	
				{
					protocolType = value;
				}
			}

			public string StorageType
			{
				get
				{
					return storageType;
				}
				set	
				{
					storageType = value;
				}
			}

			public string FileSystemType
			{
				get
				{
					return fileSystemType;
				}
				set	
				{
					fileSystemType = value;
				}
			}

			public int? EncryptType
			{
				get
				{
					return encryptType;
				}
				set	
				{
					encryptType = value;
				}
			}

			public long? MeteredSize
			{
				get
				{
					return meteredSize;
				}
				set	
				{
					meteredSize = value;
				}
			}

			public long? MeteredIASize
			{
				get
				{
					return meteredIASize;
				}
				set	
				{
					meteredIASize = value;
				}
			}

			public long? Bandwidth
			{
				get
				{
					return bandwidth;
				}
				set	
				{
					bandwidth = value;
				}
			}

			public long? Capacity
			{
				get
				{
					return capacity;
				}
				set	
				{
					capacity = value;
				}
			}

			public string AutoSnapshotPolicyId
			{
				get
				{
					return autoSnapshotPolicyId;
				}
				set	
				{
					autoSnapshotPolicyId = value;
				}
			}

			public string Status
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

			public string ChargeType
			{
				get
				{
					return chargeType;
				}
				set	
				{
					chargeType = value;
				}
			}

			public long? MountTargetCountLimit
			{
				get
				{
					return mountTargetCountLimit;
				}
				set	
				{
					mountTargetCountLimit = value;
				}
			}

			public string NasNamespaceId
			{
				get
				{
					return nasNamespaceId;
				}
				set	
				{
					nasNamespaceId = value;
				}
			}

			public string KMSKeyId
			{
				get
				{
					return kMSKeyId;
				}
				set	
				{
					kMSKeyId = value;
				}
			}

			public string Version
			{
				get
				{
					return version;
				}
				set	
				{
					version = value;
				}
			}

			public List<DescribeFileSystems_MountTarget> MountTargets
			{
				get
				{
					return mountTargets;
				}
				set	
				{
					mountTargets = value;
				}
			}

			public List<DescribeFileSystems_Package> Packages
			{
				get
				{
					return packages;
				}
				set	
				{
					packages = value;
				}
			}

			public List<DescribeFileSystems_Tag2> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public List<string> SupportedFeatures
			{
				get
				{
					return supportedFeatures;
				}
				set	
				{
					supportedFeatures = value;
				}
			}

			public DescribeFileSystems_Ldap Ldap
			{
				get
				{
					return ldap;
				}
				set	
				{
					ldap = value;
				}
			}

			public class DescribeFileSystems_MountTarget
			{

				private string mountTargetDomain;

				private string networkType;

				private string vpcId;

				private string vswId;

				private string accessGroupName;

				private string status;

				private string dualStackMountTargetDomain;

				private List<DescribeFileSystems_ClientMasterNode> clientMasterNodes;

				private List<DescribeFileSystems_Tag> tags1;

				public string MountTargetDomain
				{
					get
					{
						return mountTargetDomain;
					}
					set	
					{
						mountTargetDomain = value;
					}
				}

				public string NetworkType
				{
					get
					{
						return networkType;
					}
					set	
					{
						networkType = value;
					}
				}

				public string VpcId
				{
					get
					{
						return vpcId;
					}
					set	
					{
						vpcId = value;
					}
				}

				public string VswId
				{
					get
					{
						return vswId;
					}
					set	
					{
						vswId = value;
					}
				}

				public string AccessGroupName
				{
					get
					{
						return accessGroupName;
					}
					set	
					{
						accessGroupName = value;
					}
				}

				public string Status
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

				public string DualStackMountTargetDomain
				{
					get
					{
						return dualStackMountTargetDomain;
					}
					set	
					{
						dualStackMountTargetDomain = value;
					}
				}

				public List<DescribeFileSystems_ClientMasterNode> ClientMasterNodes
				{
					get
					{
						return clientMasterNodes;
					}
					set	
					{
						clientMasterNodes = value;
					}
				}

				public List<DescribeFileSystems_Tag> Tags1
				{
					get
					{
						return tags1;
					}
					set	
					{
						tags1 = value;
					}
				}

				public class DescribeFileSystems_ClientMasterNode
				{

					private string ecsId;

					private string ecsIp;

					private string defaultPasswd;

					public string EcsId
					{
						get
						{
							return ecsId;
						}
						set	
						{
							ecsId = value;
						}
					}

					public string EcsIp
					{
						get
						{
							return ecsIp;
						}
						set	
						{
							ecsIp = value;
						}
					}

					public string DefaultPasswd
					{
						get
						{
							return defaultPasswd;
						}
						set	
						{
							defaultPasswd = value;
						}
					}
				}

				public class DescribeFileSystems_Tag
				{

					private string key;

					private string _value;

					public string Key
					{
						get
						{
							return key;
						}
						set	
						{
							key = value;
						}
					}

					public string _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}
				}
			}

			public class DescribeFileSystems_Package
			{

				private string packageId;

				private string packageType;

				private long? size;

				private string startTime;

				private string expiredTime;

				public string PackageId
				{
					get
					{
						return packageId;
					}
					set	
					{
						packageId = value;
					}
				}

				public string PackageType
				{
					get
					{
						return packageType;
					}
					set	
					{
						packageType = value;
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

				public string StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
					}
				}

				public string ExpiredTime
				{
					get
					{
						return expiredTime;
					}
					set	
					{
						expiredTime = value;
					}
				}
			}

			public class DescribeFileSystems_Tag2
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}

			public class DescribeFileSystems_Ldap
			{

				private string bindDN;

				private string uRI;

				private string searchBase;

				public string BindDN
				{
					get
					{
						return bindDN;
					}
					set	
					{
						bindDN = value;
					}
				}

				public string URI
				{
					get
					{
						return uRI;
					}
					set	
					{
						uRI = value;
					}
				}

				public string SearchBase
				{
					get
					{
						return searchBase;
					}
					set	
					{
						searchBase = value;
					}
				}
			}
		}
	}
}
