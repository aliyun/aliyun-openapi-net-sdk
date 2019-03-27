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

namespace Aliyun.Acs.CSB.Model.V20171118
{
	public class GetOrderResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private GetOrder_Data data;

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

		public GetOrder_Data Data
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

		public class GetOrder_Data
		{

			private GetOrder_Order order;

			public GetOrder_Order Order
			{
				get
				{
					return order;
				}
				set	
				{
					order = value;
				}
			}

			public class GetOrder_Order
			{

				private string alias;

				private long? credentialGroupId;

				private long? csbId;

				private string dauthGroupName;

				private long? gmtCreate;

				private long? gmtModified;

				private string groupName;

				private long? id;

				private string projectName;

				private long? serviceId;

				private string serviceName;

				private int? serviceStatus;

				private string serviceVersion;

				private string statisticName;

				private int? status;

				private string strictWhiteListJson;

				private string userId;

				private List<GetOrder_ErrorTypeCatagory> errorTypeCatagoryList;

				private List<string> strictWhiteList;

				private GetOrder_Service service;

				private GetOrder_SlaInfo slaInfo;

				private GetOrder_Total total;

				public string Alias
				{
					get
					{
						return alias;
					}
					set	
					{
						alias = value;
					}
				}

				public long? CredentialGroupId
				{
					get
					{
						return credentialGroupId;
					}
					set	
					{
						credentialGroupId = value;
					}
				}

				public long? CsbId
				{
					get
					{
						return csbId;
					}
					set	
					{
						csbId = value;
					}
				}

				public string DauthGroupName
				{
					get
					{
						return dauthGroupName;
					}
					set	
					{
						dauthGroupName = value;
					}
				}

				public long? GmtCreate
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

				public long? GmtModified
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

				public string GroupName
				{
					get
					{
						return groupName;
					}
					set	
					{
						groupName = value;
					}
				}

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

				public string ProjectName
				{
					get
					{
						return projectName;
					}
					set	
					{
						projectName = value;
					}
				}

				public long? ServiceId
				{
					get
					{
						return serviceId;
					}
					set	
					{
						serviceId = value;
					}
				}

				public string ServiceName
				{
					get
					{
						return serviceName;
					}
					set	
					{
						serviceName = value;
					}
				}

				public int? ServiceStatus
				{
					get
					{
						return serviceStatus;
					}
					set	
					{
						serviceStatus = value;
					}
				}

				public string ServiceVersion
				{
					get
					{
						return serviceVersion;
					}
					set	
					{
						serviceVersion = value;
					}
				}

				public string StatisticName
				{
					get
					{
						return statisticName;
					}
					set	
					{
						statisticName = value;
					}
				}

				public int? Status
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

				public string StrictWhiteListJson
				{
					get
					{
						return strictWhiteListJson;
					}
					set	
					{
						strictWhiteListJson = value;
					}
				}

				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}

				public List<GetOrder_ErrorTypeCatagory> ErrorTypeCatagoryList
				{
					get
					{
						return errorTypeCatagoryList;
					}
					set	
					{
						errorTypeCatagoryList = value;
					}
				}

				public List<string> StrictWhiteList
				{
					get
					{
						return strictWhiteList;
					}
					set	
					{
						strictWhiteList = value;
					}
				}

				public GetOrder_Service Service
				{
					get
					{
						return service;
					}
					set	
					{
						service = value;
					}
				}

				public GetOrder_SlaInfo SlaInfo
				{
					get
					{
						return slaInfo;
					}
					set	
					{
						slaInfo = value;
					}
				}

				public GetOrder_Total Total
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

				public class GetOrder_ErrorTypeCatagory
				{

					private int? total;

					private int? errorNum;

					private string name;

					public int? Total
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

					public int? ErrorNum
					{
						get
						{
							return errorNum;
						}
						set	
						{
							errorNum = value;
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
				}

				public class GetOrder_Service
				{

					private string accessParamsJSON;

					private bool? active;

					private string alias;

					private bool? allVisiable;

					private string consumeTypesJSON;

					private long? createTime;

					private long? csbId;

					private string errDefJSON;

					private long? id;

					private string interfaceName;

					private string oldVersion;

					private bool? ottFlag;

					private string ownerId;

					private string principalName;

					private string projectId;

					private string projectName;

					private string provideType;

					private bool? sSL;

					private string scope;

					private string serviceName;

					private string serviceProviderType;

					private string serviceVersion;

					private bool? skipAuth;

					private string statisticName;

					private int? status;

					private long? userId;

					private bool? validConsumeTypes;

					private bool? validProvideType;

					public string AccessParamsJSON
					{
						get
						{
							return accessParamsJSON;
						}
						set	
						{
							accessParamsJSON = value;
						}
					}

					public bool? Active
					{
						get
						{
							return active;
						}
						set	
						{
							active = value;
						}
					}

					public string Alias
					{
						get
						{
							return alias;
						}
						set	
						{
							alias = value;
						}
					}

					public bool? AllVisiable
					{
						get
						{
							return allVisiable;
						}
						set	
						{
							allVisiable = value;
						}
					}

					public string ConsumeTypesJSON
					{
						get
						{
							return consumeTypesJSON;
						}
						set	
						{
							consumeTypesJSON = value;
						}
					}

					public long? CreateTime
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

					public long? CsbId
					{
						get
						{
							return csbId;
						}
						set	
						{
							csbId = value;
						}
					}

					public string ErrDefJSON
					{
						get
						{
							return errDefJSON;
						}
						set	
						{
							errDefJSON = value;
						}
					}

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

					public string InterfaceName
					{
						get
						{
							return interfaceName;
						}
						set	
						{
							interfaceName = value;
						}
					}

					public string OldVersion
					{
						get
						{
							return oldVersion;
						}
						set	
						{
							oldVersion = value;
						}
					}

					public bool? OttFlag
					{
						get
						{
							return ottFlag;
						}
						set	
						{
							ottFlag = value;
						}
					}

					public string OwnerId
					{
						get
						{
							return ownerId;
						}
						set	
						{
							ownerId = value;
						}
					}

					public string PrincipalName
					{
						get
						{
							return principalName;
						}
						set	
						{
							principalName = value;
						}
					}

					public string ProjectId
					{
						get
						{
							return projectId;
						}
						set	
						{
							projectId = value;
						}
					}

					public string ProjectName
					{
						get
						{
							return projectName;
						}
						set	
						{
							projectName = value;
						}
					}

					public string ProvideType
					{
						get
						{
							return provideType;
						}
						set	
						{
							provideType = value;
						}
					}

					public bool? SSL
					{
						get
						{
							return sSL;
						}
						set	
						{
							sSL = value;
						}
					}

					public string Scope
					{
						get
						{
							return scope;
						}
						set	
						{
							scope = value;
						}
					}

					public string ServiceName
					{
						get
						{
							return serviceName;
						}
						set	
						{
							serviceName = value;
						}
					}

					public string ServiceProviderType
					{
						get
						{
							return serviceProviderType;
						}
						set	
						{
							serviceProviderType = value;
						}
					}

					public string ServiceVersion
					{
						get
						{
							return serviceVersion;
						}
						set	
						{
							serviceVersion = value;
						}
					}

					public bool? SkipAuth
					{
						get
						{
							return skipAuth;
						}
						set	
						{
							skipAuth = value;
						}
					}

					public string StatisticName
					{
						get
						{
							return statisticName;
						}
						set	
						{
							statisticName = value;
						}
					}

					public int? Status
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

					public long? UserId
					{
						get
						{
							return userId;
						}
						set	
						{
							userId = value;
						}
					}

					public bool? ValidConsumeTypes
					{
						get
						{
							return validConsumeTypes;
						}
						set	
						{
							validConsumeTypes = value;
						}
					}

					public bool? ValidProvideType
					{
						get
						{
							return validProvideType;
						}
						set	
						{
							validProvideType = value;
						}
					}
				}

				public class GetOrder_SlaInfo
				{

					private string qph;

					private string qps;

					public string Qph
					{
						get
						{
							return qph;
						}
						set	
						{
							qph = value;
						}
					}

					public string Qps
					{
						get
						{
							return qps;
						}
						set	
						{
							qps = value;
						}
					}
				}

				public class GetOrder_Total
				{

					private int? errorNum;

					private int? total;

					public int? ErrorNum
					{
						get
						{
							return errorNum;
						}
						set	
						{
							errorNum = value;
						}
					}

					public int? Total
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
				}
			}
		}
	}
}
