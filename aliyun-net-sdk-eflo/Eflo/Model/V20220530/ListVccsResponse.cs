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

				private string zoneId;

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

				private string currentNode;

				private string message;

				private string createTime;

				private string gmtModified;

				private string taskId;

				private double? rate;

				private string bandwidthStr;

				private string commodityCode;

				private string bgpCidr;

				private string expirationDate;

				private string resourceGroupId;

				private string connectionType;

				private string cenOwnerId;

				private string bgpAsn;

				private List<ListVccs_ErInfo> erInfos;

				private List<ListVccs_Tag> tags;

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

				public string CurrentNode
				{
					get
					{
						return currentNode;
					}
					set	
					{
						currentNode = value;
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

				public string TaskId
				{
					get
					{
						return taskId;
					}
					set	
					{
						taskId = value;
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

				public string CommodityCode
				{
					get
					{
						return commodityCode;
					}
					set	
					{
						commodityCode = value;
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

				public string ExpirationDate
				{
					get
					{
						return expirationDate;
					}
					set	
					{
						expirationDate = value;
					}
				}

				public string ResourceGroupId
				{
					get
					{
						return resourceGroupId;
					}
					set	
					{
						resourceGroupId = value;
					}
				}

				public string ConnectionType
				{
					get
					{
						return connectionType;
					}
					set	
					{
						connectionType = value;
					}
				}

				public string CenOwnerId
				{
					get
					{
						return cenOwnerId;
					}
					set	
					{
						cenOwnerId = value;
					}
				}

				public string BgpAsn
				{
					get
					{
						return bgpAsn;
					}
					set	
					{
						bgpAsn = value;
					}
				}

				public List<ListVccs_ErInfo> ErInfos
				{
					get
					{
						return erInfos;
					}
					set	
					{
						erInfos = value;
					}
				}

				public List<ListVccs_Tag> Tags
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

				public class ListVccs_ErInfo
				{

					private string createTime;

					private string gmtModified;

					private string message;

					private string erId;

					private string regionId;

					private string tenantId;

					private string status;

					private string erName;

					private string masterZoneId;

					private string description;

					private long? connections;

					private long? routeMaps;

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

					public string ErId
					{
						get
						{
							return erId;
						}
						set	
						{
							erId = value;
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

					public string ErName
					{
						get
						{
							return erName;
						}
						set	
						{
							erName = value;
						}
					}

					public string MasterZoneId
					{
						get
						{
							return masterZoneId;
						}
						set	
						{
							masterZoneId = value;
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

					public long? Connections
					{
						get
						{
							return connections;
						}
						set	
						{
							connections = value;
						}
					}

					public long? RouteMaps
					{
						get
						{
							return routeMaps;
						}
						set	
						{
							routeMaps = value;
						}
					}
				}

				public class ListVccs_Tag
				{

					private string tagKey;

					private string tagValue;

					public string TagKey
					{
						get
						{
							return tagKey;
						}
						set	
						{
							tagKey = value;
						}
					}

					public string TagValue
					{
						get
						{
							return tagValue;
						}
						set	
						{
							tagValue = value;
						}
					}
				}

				public class ListVccs_VpdBaseInfo
				{

					private string vpdId;

					private string vpdName;

					private string cidr;

					private string createTime;

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

					public string VpdName
					{
						get
						{
							return vpdName;
						}
						set	
						{
							vpdName = value;
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
				}
			}
		}
	}
}
