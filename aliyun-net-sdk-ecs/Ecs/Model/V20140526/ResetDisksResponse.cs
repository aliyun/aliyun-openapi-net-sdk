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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class ResetDisksResponse : AcsResponse
	{

		private string requestId;

		private List<ResetDisks_OperationProgress> operationProgressSet;

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

		[JsonProperty(PropertyName = "OperationProgressSet")]
		public List<ResetDisks_OperationProgress> OperationProgressSet
		{
			get
			{
				return operationProgressSet;
			}
			set	
			{
				operationProgressSet = value;
			}
		}

		public class ResetDisks_OperationProgress
		{

			private string errorMsg;

			private string errorCode;

			private string operationStatus;

			private List<ResetDisks_RelatedItem> relatedItemSet;

			[JsonProperty(PropertyName = "ErrorMsg")]
			public string ErrorMsg
			{
				get
				{
					return errorMsg;
				}
				set	
				{
					errorMsg = value;
				}
			}

			[JsonProperty(PropertyName = "ErrorCode")]
			public string ErrorCode
			{
				get
				{
					return errorCode;
				}
				set	
				{
					errorCode = value;
				}
			}

			[JsonProperty(PropertyName = "OperationStatus")]
			public string OperationStatus
			{
				get
				{
					return operationStatus;
				}
				set	
				{
					operationStatus = value;
				}
			}

			[JsonProperty(PropertyName = "RelatedItemSet")]
			public List<ResetDisks_RelatedItem> RelatedItemSet
			{
				get
				{
					return relatedItemSet;
				}
				set	
				{
					relatedItemSet = value;
				}
			}

			public class ResetDisks_RelatedItem
			{

				private string name;

				private string _value;

				[JsonProperty(PropertyName = "Name")]
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

				[JsonProperty(PropertyName = "_Value")]
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
			}
		}
	}
}
