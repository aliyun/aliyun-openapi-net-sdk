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

namespace Aliyun.Acs.Sas_api.Model.V20170705
{
	public class GetApplicationAttackListResponse : AcsResponse
	{

		private string code;

		private string message;

		private bool? success;

		private GetApplicationAttackList_Data data;

		public string Code
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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public GetApplicationAttackList_Data Data
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

		public class GetApplicationAttackList_Data
		{

			private long? total;

			private List<GetApplicationAttackList_Item> items;

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

			public List<GetApplicationAttackList_Item> Items
			{
				get
				{
					return items;
				}
				set	
				{
					items = value;
				}
			}

			public class GetApplicationAttackList_Item
			{

				private long? id;

				private string level;

				private string uuid;

				private string product;

				private string vmIp;

				private string url;

				private string method;

				private string sourceIp;

				private string sourceUuid;

				private string sourceDomain;

				private int? sourcePort;

				private string sourceLocal;

				private string dstIp;

				private string dstUuid;

				private string dstDomain;

				private int? dstPort;

				private string dstLocal;

				private long? attackCount;

				private string threatRate;

				private long? attackStartTime;

				private long? attackEndTime;

				private int? attackCategory;

				private string attackCategoryName;

				private string attackType;

				private string attackTypeName;

				private int? attackStatus;

				private string attackSource;

				private List<GetApplicationAttackList_Detail> details;

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

				public string Level
				{
					get
					{
						return level;
					}
					set	
					{
						level = value;
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

				public string Product
				{
					get
					{
						return product;
					}
					set	
					{
						product = value;
					}
				}

				public string VmIp
				{
					get
					{
						return vmIp;
					}
					set	
					{
						vmIp = value;
					}
				}

				public string Url
				{
					get
					{
						return url;
					}
					set	
					{
						url = value;
					}
				}

				public string Method
				{
					get
					{
						return method;
					}
					set	
					{
						method = value;
					}
				}

				public string SourceIp
				{
					get
					{
						return sourceIp;
					}
					set	
					{
						sourceIp = value;
					}
				}

				public string SourceUuid
				{
					get
					{
						return sourceUuid;
					}
					set	
					{
						sourceUuid = value;
					}
				}

				public string SourceDomain
				{
					get
					{
						return sourceDomain;
					}
					set	
					{
						sourceDomain = value;
					}
				}

				public int? SourcePort
				{
					get
					{
						return sourcePort;
					}
					set	
					{
						sourcePort = value;
					}
				}

				public string SourceLocal
				{
					get
					{
						return sourceLocal;
					}
					set	
					{
						sourceLocal = value;
					}
				}

				public string DstIp
				{
					get
					{
						return dstIp;
					}
					set	
					{
						dstIp = value;
					}
				}

				public string DstUuid
				{
					get
					{
						return dstUuid;
					}
					set	
					{
						dstUuid = value;
					}
				}

				public string DstDomain
				{
					get
					{
						return dstDomain;
					}
					set	
					{
						dstDomain = value;
					}
				}

				public int? DstPort
				{
					get
					{
						return dstPort;
					}
					set	
					{
						dstPort = value;
					}
				}

				public string DstLocal
				{
					get
					{
						return dstLocal;
					}
					set	
					{
						dstLocal = value;
					}
				}

				public long? AttackCount
				{
					get
					{
						return attackCount;
					}
					set	
					{
						attackCount = value;
					}
				}

				public string ThreatRate
				{
					get
					{
						return threatRate;
					}
					set	
					{
						threatRate = value;
					}
				}

				public long? AttackStartTime
				{
					get
					{
						return attackStartTime;
					}
					set	
					{
						attackStartTime = value;
					}
				}

				public long? AttackEndTime
				{
					get
					{
						return attackEndTime;
					}
					set	
					{
						attackEndTime = value;
					}
				}

				public int? AttackCategory
				{
					get
					{
						return attackCategory;
					}
					set	
					{
						attackCategory = value;
					}
				}

				public string AttackCategoryName
				{
					get
					{
						return attackCategoryName;
					}
					set	
					{
						attackCategoryName = value;
					}
				}

				public string AttackType
				{
					get
					{
						return attackType;
					}
					set	
					{
						attackType = value;
					}
				}

				public string AttackTypeName
				{
					get
					{
						return attackTypeName;
					}
					set	
					{
						attackTypeName = value;
					}
				}

				public int? AttackStatus
				{
					get
					{
						return attackStatus;
					}
					set	
					{
						attackStatus = value;
					}
				}

				public string AttackSource
				{
					get
					{
						return attackSource;
					}
					set	
					{
						attackSource = value;
					}
				}

				public List<GetApplicationAttackList_Detail> Details
				{
					get
					{
						return details;
					}
					set	
					{
						details = value;
					}
				}

				public class GetApplicationAttackList_Detail
				{

					private string _value;

					private int? type;

					private string label;

					private string linkText;

					public string _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}

					public int? Type
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

					public string Label
					{
						get
						{
							return label;
						}
						set	
						{
							label = value;
						}
					}

					public string LinkText
					{
						get
						{
							return linkText;
						}
						set	
						{
							linkText = value;
						}
					}
				}
			}
		}
	}
}