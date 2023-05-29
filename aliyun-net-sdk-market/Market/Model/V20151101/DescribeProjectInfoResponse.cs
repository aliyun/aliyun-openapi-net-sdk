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

namespace Aliyun.Acs.Market.Model.V20151101
{
	public class DescribeProjectInfoResponse : AcsResponse
	{

		private bool? success;

		private string requestId;

		private DescribeProjectInfo_Result result;

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Result")]
		public DescribeProjectInfo_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribeProjectInfo_Result
		{

			private string productName;

			private string projectStatus;

			private long? customerAliUid;

			private string templateType;

			private string instanceId;

			private string productSkuName;

			private int? finalStepNo;

			private int? currentStepNo;

			private long? gmtExpired;

			private long? gmtFinished;

			private string productSkuCode;

			private long? gmtCreate;

			private long? supplierAliUid;

			private string finishType;

			private long? templateId;

			private long? orderId;

			private string productCode;

			[JsonProperty(PropertyName = "ProductName")]
			public string ProductName
			{
				get
				{
					return productName;
				}
				set	
				{
					productName = value;
				}
			}

			[JsonProperty(PropertyName = "ProjectStatus")]
			public string ProjectStatus
			{
				get
				{
					return projectStatus;
				}
				set	
				{
					projectStatus = value;
				}
			}

			[JsonProperty(PropertyName = "CustomerAliUid")]
			public long? CustomerAliUid
			{
				get
				{
					return customerAliUid;
				}
				set	
				{
					customerAliUid = value;
				}
			}

			[JsonProperty(PropertyName = "TemplateType")]
			public string TemplateType
			{
				get
				{
					return templateType;
				}
				set	
				{
					templateType = value;
				}
			}

			[JsonProperty(PropertyName = "InstanceId")]
			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			[JsonProperty(PropertyName = "ProductSkuName")]
			public string ProductSkuName
			{
				get
				{
					return productSkuName;
				}
				set	
				{
					productSkuName = value;
				}
			}

			[JsonProperty(PropertyName = "FinalStepNo")]
			public int? FinalStepNo
			{
				get
				{
					return finalStepNo;
				}
				set	
				{
					finalStepNo = value;
				}
			}

			[JsonProperty(PropertyName = "CurrentStepNo")]
			public int? CurrentStepNo
			{
				get
				{
					return currentStepNo;
				}
				set	
				{
					currentStepNo = value;
				}
			}

			[JsonProperty(PropertyName = "GmtExpired")]
			public long? GmtExpired
			{
				get
				{
					return gmtExpired;
				}
				set	
				{
					gmtExpired = value;
				}
			}

			[JsonProperty(PropertyName = "GmtFinished")]
			public long? GmtFinished
			{
				get
				{
					return gmtFinished;
				}
				set	
				{
					gmtFinished = value;
				}
			}

			[JsonProperty(PropertyName = "ProductSkuCode")]
			public string ProductSkuCode
			{
				get
				{
					return productSkuCode;
				}
				set	
				{
					productSkuCode = value;
				}
			}

			[JsonProperty(PropertyName = "GmtCreate")]
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

			[JsonProperty(PropertyName = "SupplierAliUid")]
			public long? SupplierAliUid
			{
				get
				{
					return supplierAliUid;
				}
				set	
				{
					supplierAliUid = value;
				}
			}

			[JsonProperty(PropertyName = "FinishType")]
			public string FinishType
			{
				get
				{
					return finishType;
				}
				set	
				{
					finishType = value;
				}
			}

			[JsonProperty(PropertyName = "TemplateId")]
			public long? TemplateId
			{
				get
				{
					return templateId;
				}
				set	
				{
					templateId = value;
				}
			}

			[JsonProperty(PropertyName = "OrderId")]
			public long? OrderId
			{
				get
				{
					return orderId;
				}
				set	
				{
					orderId = value;
				}
			}

			[JsonProperty(PropertyName = "ProductCode")]
			public string ProductCode
			{
				get
				{
					return productCode;
				}
				set	
				{
					productCode = value;
				}
			}
		}
	}
}
