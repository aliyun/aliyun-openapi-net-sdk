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

namespace Aliyun.Acs.gpdb.Model.V20160503
{
	public class DescribeRdsVSwitchsResponse : AcsResponse
	{

		private string requestId;

		private DescribeRdsVSwitchs_VSwitches vSwitches;

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

		public DescribeRdsVSwitchs_VSwitches VSwitches
		{
			get
			{
				return vSwitches;
			}
			set	
			{
				vSwitches = value;
			}
		}

		public class DescribeRdsVSwitchs_VSwitches
		{

			private List<DescribeRdsVSwitchs_VSwitchItem> vSwitch;

			public List<DescribeRdsVSwitchs_VSwitchItem> VSwitch
			{
				get
				{
					return vSwitch;
				}
				set	
				{
					vSwitch = value;
				}
			}

			public class DescribeRdsVSwitchs_VSwitchItem
			{

				private string vSwitchId;

				private string vSwitchName;

				private string izNo;

				private string bid;

				private string aliUid;

				private string regionNo;

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
			}
		}
	}
}
