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
	public class DescribeEmrMainVersionResponse : AcsResponse
	{

		private string requestId;

		private DescribeEmrMainVersion_EmrMainVersion emrMainVersion;

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

		public DescribeEmrMainVersion_EmrMainVersion EmrMainVersion
		{
			get
			{
				return emrMainVersion;
			}
			set	
			{
				emrMainVersion = value;
			}
		}

		public class DescribeEmrMainVersion_EmrMainVersion
		{

			private string regionId;

			private string emrVersion;

			private bool? ecmVersion;

			private string imageId;

			private bool? display;

			private string stackName;

			private string stackVersion;

			private List<DescribeEmrMainVersion_ClusterTypeInfo> clusterTypeInfoList;

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

			public List<DescribeEmrMainVersion_ClusterTypeInfo> ClusterTypeInfoList
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

			public class DescribeEmrMainVersion_ClusterTypeInfo
			{

				private string clusterType;

				private List<DescribeEmrMainVersion_ServiceInfo> serviceInfoList;

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

				public List<DescribeEmrMainVersion_ServiceInfo> ServiceInfoList
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

				public class DescribeEmrMainVersion_ServiceInfo
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
		}
	}
}
