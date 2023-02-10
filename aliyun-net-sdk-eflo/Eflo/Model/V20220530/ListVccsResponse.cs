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
	public class ListVccsResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private ListVccs_Content content;

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

		public ListVccs_Content Content
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

		public class ListVccs_Content
		{

			private long? total;

			private List<ListVccs_DataItem> data;

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

			public List<ListVccs_DataItem> Data
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

			public class ListVccs_DataItem
			{

				private string tenantId;

				private string regionId;

				private string vccId;

				private string vpdId;

				private string vpcId;

				private string cenId;

				private string vccName;

				private string accessPointId;

				private string lineOperator;

				private string spec;

				private string portType;

				private string status;

				private string message;

				private string createTime;

				private string gmtModified;

				private double? rate;

				private string bandwidthStr;

				private string bgpCidr;

				private ListVccs_VpdBaseInfo vpdBaseInfo;

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

				public string VccId
				{
					get
					{
						return vccId;
					}
					set	
					{
						vccId = value;
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

				public string CenId
				{
					get
					{
						return cenId;
					}
					set	
					{
						cenId = value;
					}
				}

				public string VccName
				{
					get
					{
						return vccName;
					}
					set	
					{
						vccName = value;
					}
				}

				public string AccessPointId
				{
					get
					{
						return accessPointId;
					}
					set	
					{
						accessPointId = value;
					}
				}

				public string LineOperator
				{
					get
					{
						return lineOperator;
					}
					set	
					{
						lineOperator = value;
					}
				}

				public string Spec
				{
					get
					{
						return spec;
					}
					set	
					{
						spec = value;
					}
				}

				public string PortType
				{
					get
					{
						return portType;
					}
					set	
					{
						portType = value;
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

				public double? Rate
				{
					get
					{
						return rate;
					}
					set	
					{
						rate = value;
					}
				}

				public string BandwidthStr
				{
					get
					{
						return bandwidthStr;
					}
					set	
					{
						bandwidthStr = value;
					}
				}

				public string BgpCidr
				{
					get
					{
						return bgpCidr;
					}
					set	
					{
						bgpCidr = value;
					}
				}

				public ListVccs_VpdBaseInfo VpdBaseInfo
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

				public class ListVccs_VpdBaseInfo
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
