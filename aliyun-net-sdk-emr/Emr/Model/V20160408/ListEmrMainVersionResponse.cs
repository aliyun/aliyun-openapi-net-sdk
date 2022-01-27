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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class ListEmrMainVersionResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<ListEmrMainVersion_EmrMainVersion> emrMainVersionList;

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

		public List<ListEmrMainVersion_EmrMainVersion> EmrMainVersionList
		{
			get
			{
				return emrMainVersionList;
			}
			set	
			{
				emrMainVersionList = value;
			}
		}

		public class ListEmrMainVersion_EmrMainVersion
		{

			private string regionId;

			private string emrVersion;

			private bool? ecmVersion;

			private string imageId;

			private bool? display;

			private string stackName;

			private string stackVersion;

			private string publishType;

			private List<ListEmrMainVersion_ClusterTypeInfo> clusterTypeInfoList;

			private List<ListEmrMainVersion_ClusterTypeWhiteUser> clusterTypeWhiteUserList;

			private List<string> whiteUserList;

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

			public string EmrVersion
			{
				get
				{
					return emrVersion;
				}
				set	
				{
					emrVersion = value;
				}
			}

			public bool? EcmVersion
			{
				get
				{
					return ecmVersion;
				}
				set	
				{
					ecmVersion = value;
				}
			}

			public string ImageId
			{
				get
				{
					return imageId;
				}
				set	
				{
					imageId = value;
				}
			}

			public bool? Display
			{
				get
				{
					return display;
				}
				set	
				{
					display = value;
				}
			}

			public string StackName
			{
				get
				{
					return stackName;
				}
				set	
				{
					stackName = value;
				}
			}

			public string StackVersion
			{
				get
				{
					return stackVersion;
				}
				set	
				{
					stackVersion = value;
				}
			}

			public string PublishType
			{
				get
				{
					return publishType;
				}
				set	
				{
					publishType = value;
				}
			}

			public List<ListEmrMainVersion_ClusterTypeInfo> ClusterTypeInfoList
			{
				get
				{
					return clusterTypeInfoList;
				}
				set	
				{
					clusterTypeInfoList = value;
				}
			}

			public List<ListEmrMainVersion_ClusterTypeWhiteUser> ClusterTypeWhiteUserList
			{
				get
				{
					return clusterTypeWhiteUserList;
				}
				set	
				{
					clusterTypeWhiteUserList = value;
				}
			}

			public List<string> WhiteUserList
			{
				get
				{
					return whiteUserList;
				}
				set	
				{
					whiteUserList = value;
				}
			}

			public class ListEmrMainVersion_ClusterTypeInfo
			{

				private string clusterType;

				private List<ListEmrMainVersion_ServiceInfo> serviceInfoList;

				public string ClusterType
				{
					get
					{
						return clusterType;
					}
					set	
					{
						clusterType = value;
					}
				}

				public List<ListEmrMainVersion_ServiceInfo> ServiceInfoList
				{
					get
					{
						return serviceInfoList;
					}
					set	
					{
						serviceInfoList = value;
					}
				}

				public class ListEmrMainVersion_ServiceInfo
				{

					private string serviceName;

					private string serviceDisplayName;

					private string serviceVersion;

					private string serviceDisplayVersion;

					private bool? mandatory;

					private bool? display;

					public string ServiceName
					{
						get
						{
							return serviceName;
						}
						set	
						{
							serviceName = value;
						}
					}

					public string ServiceDisplayName
					{
						get
						{
							return serviceDisplayName;
						}
						set	
						{
							serviceDisplayName = value;
						}
					}

					public string ServiceVersion
					{
						get
						{
							return serviceVersion;
						}
						set	
						{
							serviceVersion = value;
						}
					}

					public string ServiceDisplayVersion
					{
						get
						{
							return serviceDisplayVersion;
						}
						set	
						{
							serviceDisplayVersion = value;
						}
					}

					public bool? Mandatory
					{
						get
						{
							return mandatory;
						}
						set	
						{
							mandatory = value;
						}
					}

					public bool? Display
					{
						get
						{
							return display;
						}
						set	
						{
							display = value;
						}
					}
				}
			}

			public class ListEmrMainVersion_ClusterTypeWhiteUser
			{

				private string clusterType;

				private string userId;

				public string ClusterType
				{
					get
					{
						return clusterType;
					}
					set	
					{
						clusterType = value;
					}
				}

				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}
			}
		}
	}
}
