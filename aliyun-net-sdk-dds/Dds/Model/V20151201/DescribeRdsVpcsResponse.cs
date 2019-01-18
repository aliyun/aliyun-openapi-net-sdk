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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Dds.Model.V20151201
{
	public class DescribeRdsVpcsResponse : AcsResponse
	{

		private string requestId;

		private DescribeRdsVpcs_Vpcs vpcs;

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

		public DescribeRdsVpcs_Vpcs Vpcs
		{
			get
			{
				return vpcs;
			}
			set	
			{
				vpcs = value;
			}
		}

		public class DescribeRdsVpcs_Vpcs
		{

			private List<DescribeRdsVpcs_VpcItem> vpc;

			public List<DescribeRdsVpcs_VpcItem> Vpc
			{
				get
				{
					return vpc;
				}
				set	
				{
					vpc = value;
				}
			}

			public class DescribeRdsVpcs_VpcItem
			{

				private string vpcId;

				private string vpcName;

				private string bid;

				private string aliUid;

				private string regionNo;

				private string cidrBlock;

				private bool? isDefault;

				private string status;

				private string gmtCreate;

				private string gmtModified;

				private List<DescribeRdsVpcs_VSwitch> vSwitchs;

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

				public string VpcName
				{
					get
					{
						return vpcName;
					}
					set	
					{
						vpcName = value;
					}
				}

				public string Bid
				{
					get
					{
						return bid;
					}
					set	
					{
						bid = value;
					}
				}

				public string AliUid
				{
					get
					{
						return aliUid;
					}
					set	
					{
						aliUid = value;
					}
				}

				public string RegionNo
				{
					get
					{
						return regionNo;
					}
					set	
					{
						regionNo = value;
					}
				}

				public string CidrBlock
				{
					get
					{
						return cidrBlock;
					}
					set	
					{
						cidrBlock = value;
					}
				}

				public bool? IsDefault
				{
					get
					{
						return isDefault;
					}
					set	
					{
						isDefault = value;
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

				public string GmtCreate
				{
					get
					{
						return gmtCreate;
					}
					set	
					{
						gmtCreate = value;
					}
				}

				public string GmtModified
				{
					get
					{
						return gmtModified;
					}
					set	
					{
						gmtModified = value;
					}
				}

				public List<DescribeRdsVpcs_VSwitch> VSwitchs
				{
					get
					{
						return vSwitchs;
					}
					set	
					{
						vSwitchs = value;
					}
				}

				public class DescribeRdsVpcs_VSwitch
				{

					private string vSwitchId;

					private string vSwitchName;

					private string izNo;

					private string cidrBlock;

					private bool? isDefault;

					private string status;

					private string gmtCreate;

					private string gmtModified;

					public string VSwitchId
					{
						get
						{
							return vSwitchId;
						}
						set	
						{
							vSwitchId = value;
						}
					}

					public string VSwitchName
					{
						get
						{
							return vSwitchName;
						}
						set	
						{
							vSwitchName = value;
						}
					}

					public string IzNo
					{
						get
						{
							return izNo;
						}
						set	
						{
							izNo = value;
						}
					}

					public string CidrBlock
					{
						get
						{
							return cidrBlock;
						}
						set	
						{
							cidrBlock = value;
						}
					}

					public bool? IsDefault
					{
						get
						{
							return isDefault;
						}
						set	
						{
							isDefault = value;
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

					public string GmtCreate
					{
						get
						{
							return gmtCreate;
						}
						set	
						{
							gmtCreate = value;
						}
					}

					public string GmtModified
					{
						get
						{
							return gmtModified;
						}
						set	
						{
							gmtModified = value;
						}
					}
				}
			}
		}
	}
}