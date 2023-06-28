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

namespace Aliyun.Acs.ltl.Model.V20190510
{
	public class DescribeMPCoSPhaseInfoResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private bool? success;

		private DescribeMPCoSPhaseInfo_Data data;

		[JsonProperty(PropertyName = "Code")]
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

		[JsonProperty(PropertyName = "Message")]
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

		[JsonProperty(PropertyName = "Data")]
		public DescribeMPCoSPhaseInfo_Data Data
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

		public class DescribeMPCoSPhaseInfo_Data
		{

			private string previousHash;

			private string productKey;

			private string dataHash;

			private string dataValue;

			private long? timestamp;

			private string transactionHash;

			private string blockHash;

			private long? blockNumber;

			private string iotId;

			private List<DescribeMPCoSPhaseInfo_RelatedData> relatedDataList;

			[JsonProperty(PropertyName = "PreviousHash")]
			public string PreviousHash
			{
				get
				{
					return previousHash;
				}
				set	
				{
					previousHash = value;
				}
			}

			[JsonProperty(PropertyName = "ProductKey")]
			public string ProductKey
			{
				get
				{
					return productKey;
				}
				set	
				{
					productKey = value;
				}
			}

			[JsonProperty(PropertyName = "DataHash")]
			public string DataHash
			{
				get
				{
					return dataHash;
				}
				set	
				{
					dataHash = value;
				}
			}

			[JsonProperty(PropertyName = "DataValue")]
			public string DataValue
			{
				get
				{
					return dataValue;
				}
				set	
				{
					dataValue = value;
				}
			}

			[JsonProperty(PropertyName = "Timestamp")]
			public long? Timestamp
			{
				get
				{
					return timestamp;
				}
				set	
				{
					timestamp = value;
				}
			}

			[JsonProperty(PropertyName = "TransactionHash")]
			public string TransactionHash
			{
				get
				{
					return transactionHash;
				}
				set	
				{
					transactionHash = value;
				}
			}

			[JsonProperty(PropertyName = "BlockHash")]
			public string BlockHash
			{
				get
				{
					return blockHash;
				}
				set	
				{
					blockHash = value;
				}
			}

			[JsonProperty(PropertyName = "BlockNumber")]
			public long? BlockNumber
			{
				get
				{
					return blockNumber;
				}
				set	
				{
					blockNumber = value;
				}
			}

			[JsonProperty(PropertyName = "IotId")]
			public string IotId
			{
				get
				{
					return iotId;
				}
				set	
				{
					iotId = value;
				}
			}

			[JsonProperty(PropertyName = "RelatedDataList")]
			public List<DescribeMPCoSPhaseInfo_RelatedData> RelatedDataList
			{
				get
				{
					return relatedDataList;
				}
				set	
				{
					relatedDataList = value;
				}
			}

			public class DescribeMPCoSPhaseInfo_RelatedData
			{

				private string relatedDataKey;

				private string relatedPhaseDataHash;

				private string relatedDataSeq;

				private string relatedPhaseName;

				private string relatedPhaseId;

				[JsonProperty(PropertyName = "RelatedDataKey")]
				public string RelatedDataKey
				{
					get
					{
						return relatedDataKey;
					}
					set	
					{
						relatedDataKey = value;
					}
				}

				[JsonProperty(PropertyName = "RelatedPhaseDataHash")]
				public string RelatedPhaseDataHash
				{
					get
					{
						return relatedPhaseDataHash;
					}
					set	
					{
						relatedPhaseDataHash = value;
					}
				}

				[JsonProperty(PropertyName = "RelatedDataSeq")]
				public string RelatedDataSeq
				{
					get
					{
						return relatedDataSeq;
					}
					set	
					{
						relatedDataSeq = value;
					}
				}

				[JsonProperty(PropertyName = "RelatedPhaseName")]
				public string RelatedPhaseName
				{
					get
					{
						return relatedPhaseName;
					}
					set	
					{
						relatedPhaseName = value;
					}
				}

				[JsonProperty(PropertyName = "RelatedPhaseId")]
				public string RelatedPhaseId
				{
					get
					{
						return relatedPhaseId;
					}
					set	
					{
						relatedPhaseId = value;
					}
				}
			}
		}
	}
}
