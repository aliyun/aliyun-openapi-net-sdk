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

namespace Aliyun.Acs.lto.Model.V20210707
{
	public class ListRouteRuleResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private bool? success;

		private ListRouteRule_Data data;

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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public ListRouteRule_Data Data
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

		public class ListRouteRule_Data
		{

			private int? num;

			private int? total;

			private int? size;

			private List<ListRouteRule_RouteRuleInfo> pageData;

			public int? Num
			{
				get
				{
					return num;
				}
				set	
				{
					num = value;
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

			public int? Size
			{
				get
				{
					return size;
				}
				set	
				{
					size = value;
				}
			}

			public List<ListRouteRule_RouteRuleInfo> PageData
			{
				get
				{
					return pageData;
				}
				set	
				{
					pageData = value;
				}
			}

			public class ListRouteRule_RouteRuleInfo
			{

				private string contractName;

				private string deviceGroupId;

				private string remark;

				private string deviceGroupName;

				private string privacyRuleId;

				private long? bizChainId;

				private string privacyRuleName;

				private string invokeType;

				private string routeRuleId;

				private string bizChainName;

				private string contractTemplateId;

				private string blockChainType;

				private string chainUpMode;

				public string ContractName
				{
					get
					{
						return contractName;
					}
					set	
					{
						contractName = value;
					}
				}

				public string DeviceGroupId
				{
					get
					{
						return deviceGroupId;
					}
					set	
					{
						deviceGroupId = value;
					}
				}

				public string Remark
				{
					get
					{
						return remark;
					}
					set	
					{
						remark = value;
					}
				}

				public string DeviceGroupName
				{
					get
					{
						return deviceGroupName;
					}
					set	
					{
						deviceGroupName = value;
					}
				}

				public string PrivacyRuleId
				{
					get
					{
						return privacyRuleId;
					}
					set	
					{
						privacyRuleId = value;
					}
				}

				public long? BizChainId
				{
					get
					{
						return bizChainId;
					}
					set	
					{
						bizChainId = value;
					}
				}

				public string PrivacyRuleName
				{
					get
					{
						return privacyRuleName;
					}
					set	
					{
						privacyRuleName = value;
					}
				}

				public string InvokeType
				{
					get
					{
						return invokeType;
					}
					set	
					{
						invokeType = value;
					}
				}

				public string RouteRuleId
				{
					get
					{
						return routeRuleId;
					}
					set	
					{
						routeRuleId = value;
					}
				}

				public string BizChainName
				{
					get
					{
						return bizChainName;
					}
					set	
					{
						bizChainName = value;
					}
				}

				public string ContractTemplateId
				{
					get
					{
						return contractTemplateId;
					}
					set	
					{
						contractTemplateId = value;
					}
				}

				public string BlockChainType
				{
					get
					{
						return blockChainType;
					}
					set	
					{
						blockChainType = value;
					}
				}

				public string ChainUpMode
				{
					get
					{
						return chainUpMode;
					}
					set	
					{
						chainUpMode = value;
					}
				}
			}
		}
	}
}
