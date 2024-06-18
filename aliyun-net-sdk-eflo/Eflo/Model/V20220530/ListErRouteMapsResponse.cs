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
	public class ListErRouteMapsResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private ListErRouteMaps_Content content;

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

		public ListErRouteMaps_Content Content
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

		public class ListErRouteMaps_Content
		{

			private long? total;

			private List<ListErRouteMaps_DataItem> data;

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

			public List<ListErRouteMaps_DataItem> Data
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

			public class ListErRouteMaps_DataItem
			{

				private string regionId;

				private string tenantId;

				private string createTime;

				private string gmtModified;

				private string message;

				private string status;

				private string erRouteMapId;

				private string erId;

				private int? routeMapNum;

				private string description;

				private string destinationCidrBlock;

				private string transmissionInstanceName;

				private string transmissionInstanceId;

				private string transmissionInstanceType;

				private string receptionInstanceName;

				private string receptionInstanceId;

				private string receptionInstanceType;

				private string action;

				private string transmissionInstanceOwner;

				private string receptionInstanceOwner;

				private string resourceGroupId;

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

				public string ErRouteMapId
				{
					get
					{
						return erRouteMapId;
					}
					set	
					{
						erRouteMapId = value;
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

				public int? RouteMapNum
				{
					get
					{
						return routeMapNum;
					}
					set	
					{
						routeMapNum = value;
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

				public string DestinationCidrBlock
				{
					get
					{
						return destinationCidrBlock;
					}
					set	
					{
						destinationCidrBlock = value;
					}
				}

				public string TransmissionInstanceName
				{
					get
					{
						return transmissionInstanceName;
					}
					set	
					{
						transmissionInstanceName = value;
					}
				}

				public string TransmissionInstanceId
				{
					get
					{
						return transmissionInstanceId;
					}
					set	
					{
						transmissionInstanceId = value;
					}
				}

				public string TransmissionInstanceType
				{
					get
					{
						return transmissionInstanceType;
					}
					set	
					{
						transmissionInstanceType = value;
					}
				}

				public string ReceptionInstanceName
				{
					get
					{
						return receptionInstanceName;
					}
					set	
					{
						receptionInstanceName = value;
					}
				}

				public string ReceptionInstanceId
				{
					get
					{
						return receptionInstanceId;
					}
					set	
					{
						receptionInstanceId = value;
					}
				}

				public string ReceptionInstanceType
				{
					get
					{
						return receptionInstanceType;
					}
					set	
					{
						receptionInstanceType = value;
					}
				}

				public string Action
				{
					get
					{
						return action;
					}
					set	
					{
						action = value;
					}
				}

				public string TransmissionInstanceOwner
				{
					get
					{
						return transmissionInstanceOwner;
					}
					set	
					{
						transmissionInstanceOwner = value;
					}
				}

				public string ReceptionInstanceOwner
				{
					get
					{
						return receptionInstanceOwner;
					}
					set	
					{
						receptionInstanceOwner = value;
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
			}
		}
	}
}
