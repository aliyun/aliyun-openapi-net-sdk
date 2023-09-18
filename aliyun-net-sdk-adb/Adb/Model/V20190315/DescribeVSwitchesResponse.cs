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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.adb.Model.V20190315
{
	public class DescribeVSwitchesResponse : AcsResponse
	{

		private string requestId;

		private DescribeVSwitches_VSwitches vSwitches;

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

		public DescribeVSwitches_VSwitches VSwitches
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

		public class DescribeVSwitches_VSwitches
		{

			private List<DescribeVSwitches_VSwitchItem> vSwitch;

			public List<DescribeVSwitches_VSwitchItem> VSwitch
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

			public class DescribeVSwitches_VSwitchItem
			{

				private string status;

				private bool? isDefault;

				private string vSwitchId;

				private string cidrBlock;

				private string regionNo;

				private string gmtCreate;

				private string aliUid;

				private string gmtModified;

				private string bid;

				private string izNo;

				private string vSwitchName;

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
			}
		}
	}
}
