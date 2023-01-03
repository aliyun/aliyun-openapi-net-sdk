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

namespace Aliyun.Acs.eflo.Model.V20220530
{
	public class ListSubnetsResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private ListSubnets_Content content;

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

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

		public ListSubnets_Content Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
			}
		}

		public class ListSubnets_Content
		{

			private long? total;

			private List<ListSubnets_DataItem> data;

			public long? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public List<ListSubnets_DataItem> Data
			{
				get
				{
					return data;
				}
				set	
				{
					data = value;
				}
			}

			public class ListSubnets_DataItem
			{

				private long? id;

				private string gmtCreate;

				private string gmtModified;

				private string tenantId;

				private string regionId;

				private string zoneId;

				private string type;

				private string subnetId;

				private string name;

				private string cidr;

				private string vpdId;

				private string status;

				private string message;

				private long? ncCount;

				private ListSubnets_VpdBaseInfo vpdBaseInfo;

				public long? Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
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

				public string TenantId
				{
					get
					{
						return tenantId;
					}
					set	
					{
						tenantId = value;
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

				public string SubnetId
				{
					get
					{
						return subnetId;
					}
					set	
					{
						subnetId = value;
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

				public string Cidr
				{
					get
					{
						return cidr;
					}
					set	
					{
						cidr = value;
					}
				}

				public string VpdId
				{
					get
					{
						return vpdId;
					}
					set	
					{
						vpdId = value;
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

				public string Message
				{
					get
					{
						return message;
					}
					set	
					{
						message = value;
					}
				}

				public long? NcCount
				{
					get
					{
						return ncCount;
					}
					set	
					{
						ncCount = value;
					}
				}

				public ListSubnets_VpdBaseInfo VpdBaseInfo
				{
					get
					{
						return vpdBaseInfo;
					}
					set	
					{
						vpdBaseInfo = value;
					}
				}

				public class ListSubnets_VpdBaseInfo
				{

					private string vpdId;

					private string name;

					private string cidr;

					private string gmtCreate;

					public string VpdId
					{
						get
						{
							return vpdId;
						}
						set	
						{
							vpdId = value;
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

					public string Cidr
					{
						get
						{
							return cidr;
						}
						set	
						{
							cidr = value;
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
				}
			}
		}
	}
}
