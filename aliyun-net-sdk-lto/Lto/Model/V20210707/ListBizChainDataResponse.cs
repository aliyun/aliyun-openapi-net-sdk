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
	public class ListBizChainDataResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private bool? success;

		private ListBizChainData_Data data;

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

		public ListBizChainData_Data Data
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

		public class ListBizChainData_Data
		{

			private int? num;

			private int? total;

			private int? size;

			private List<ListBizChainData_BizChainDataInfo> pageData;

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

			public List<ListBizChainData_BizChainDataInfo> PageData
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

			public class ListBizChainData_BizChainDataInfo
			{

				private string blockNum;

				private string productKey;

				private string memberName;

				private string deviceName;

				private string blockHash;

				private string txHash;

				private long? timestamp;

				private string iotDataDID;

				public string BlockNum
				{
					get
					{
						return blockNum;
					}
					set	
					{
						blockNum = value;
					}
				}

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

				public string MemberName
				{
					get
					{
						return memberName;
					}
					set	
					{
						memberName = value;
					}
				}

				public string DeviceName
				{
					get
					{
						return deviceName;
					}
					set	
					{
						deviceName = value;
					}
				}

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

				public string TxHash
				{
					get
					{
						return txHash;
					}
					set	
					{
						txHash = value;
					}
				}

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

				public string IotDataDID
				{
					get
					{
						return iotDataDID;
					}
					set	
					{
						iotDataDID = value;
					}
				}
			}
		}
	}
}
