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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeExposedInstanceDetailResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeExposedInstanceDetail_ExposedChain> exposedChains;

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

		public List<DescribeExposedInstanceDetail_ExposedChain> ExposedChains
		{
			get
			{
				return exposedChains;
			}
			set	
			{
				exposedChains = value;
			}
		}

		public class DescribeExposedInstanceDetail_ExposedChain
		{

			private string uuid;

			private string intranetIp;

			private string internetIp;

			private string exposureComponent;

			private string exposureType;

			private string exposurePort;

			private string exposureIp;

			private string exposureTypeId;

			private string instanceId;

			private string instanceName;

			private string regionId;

			private string groupNo;

			private List<DescribeExposedInstanceDetail_ScaVulRecord> realVulList;

			private List<DescribeExposedInstanceDetail_ScaVulRecord> allVulList;

			public string Uuid
			{
				get
				{
					return uuid;
				}
				set	
				{
					uuid = value;
				}
			}

			public string IntranetIp
			{
				get
				{
					return intranetIp;
				}
				set	
				{
					intranetIp = value;
				}
			}

			public string InternetIp
			{
				get
				{
					return internetIp;
				}
				set	
				{
					internetIp = value;
				}
			}

			public string ExposureComponent
			{
				get
				{
					return exposureComponent;
				}
				set	
				{
					exposureComponent = value;
				}
			}

			public string ExposureType
			{
				get
				{
					return exposureType;
				}
				set	
				{
					exposureType = value;
				}
			}

			public string ExposurePort
			{
				get
				{
					return exposurePort;
				}
				set	
				{
					exposurePort = value;
				}
			}

			public string ExposureIp
			{
				get
				{
					return exposureIp;
				}
				set	
				{
					exposureIp = value;
				}
			}

			public string ExposureTypeId
			{
				get
				{
					return exposureTypeId;
				}
				set	
				{
					exposureTypeId = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
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

			public string GroupNo
			{
				get
				{
					return groupNo;
				}
				set	
				{
					groupNo = value;
				}
			}

			public List<DescribeExposedInstanceDetail_ScaVulRecord> RealVulList
			{
				get
				{
					return realVulList;
				}
				set	
				{
					realVulList = value;
				}
			}

			public List<DescribeExposedInstanceDetail_ScaVulRecord> AllVulList
			{
				get
				{
					return allVulList;
				}
				set	
				{
					allVulList = value;
				}
			}

			public class DescribeExposedInstanceDetail_ScaVulRecord
			{

				private string aliasName;

				private string necessity;

				private string name;

				private string type;

				private string uuid;

				public string AliasName
				{
					get
					{
						return aliasName;
					}
					set	
					{
						aliasName = value;
					}
				}

				public string Necessity
				{
					get
					{
						return necessity;
					}
					set	
					{
						necessity = value;
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

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public string Uuid
				{
					get
					{
						return uuid;
					}
					set	
					{
						uuid = value;
					}
				}
			}
		}
	}
}
