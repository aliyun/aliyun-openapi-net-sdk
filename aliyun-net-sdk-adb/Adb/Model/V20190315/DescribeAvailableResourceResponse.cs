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

namespace Aliyun.Acs.adb.Model.V20190315
{
	public class DescribeAvailableResourceResponse : AcsResponse
	{

		private string requestId;

		private string regionId;

		private List<DescribeAvailableResource_AvailableZone> availableZoneList;

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

		public List<DescribeAvailableResource_AvailableZone> AvailableZoneList
		{
			get
			{
				return availableZoneList;
			}
			set	
			{
				availableZoneList = value;
			}
		}

		public class DescribeAvailableResource_AvailableZone
		{

			private string zoneId;

			private List<DescribeAvailableResource_SupportedSerial> supportedSerialList;

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

			public List<DescribeAvailableResource_SupportedSerial> SupportedSerialList
			{
				get
				{
					return supportedSerialList;
				}
				set	
				{
					supportedSerialList = value;
				}
			}

			public class DescribeAvailableResource_SupportedSerial
			{

				private string serial;

				private List<DescribeAvailableResource_SupportedInstanceClass> supportedInstanceClassList;

				public string Serial
				{
					get
					{
						return serial;
					}
					set	
					{
						serial = value;
					}
				}

				public List<DescribeAvailableResource_SupportedInstanceClass> SupportedInstanceClassList
				{
					get
					{
						return supportedInstanceClassList;
					}
					set	
					{
						supportedInstanceClassList = value;
					}
				}

				public class DescribeAvailableResource_SupportedInstanceClass
				{

					private string instanceClass;

					private string tips;

					private List<DescribeAvailableResource_SupportedNodeCount> supportedNodeCountList;

					public string InstanceClass
					{
						get
						{
							return instanceClass;
						}
						set	
						{
							instanceClass = value;
						}
					}

					public string Tips
					{
						get
						{
							return tips;
						}
						set	
						{
							tips = value;
						}
					}

					public List<DescribeAvailableResource_SupportedNodeCount> SupportedNodeCountList
					{
						get
						{
							return supportedNodeCountList;
						}
						set	
						{
							supportedNodeCountList = value;
						}
					}

					public class DescribeAvailableResource_SupportedNodeCount
					{

						private string nodeCount;

						private List<string> storageSize;

						public string NodeCount
						{
							get
							{
								return nodeCount;
							}
							set	
							{
								nodeCount = value;
							}
						}

						public List<string> StorageSize
						{
							get
							{
								return storageSize;
							}
							set	
							{
								storageSize = value;
							}
						}
					}
				}
			}
		}
	}
}
