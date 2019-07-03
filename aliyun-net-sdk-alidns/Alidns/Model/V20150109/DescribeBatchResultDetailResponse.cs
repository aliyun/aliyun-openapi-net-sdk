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

namespace Aliyun.Acs.Alidns.Model.V20150109
{
	public class DescribeBatchResultDetailResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private long? pageNumber;

		private long? pageSize;

		private List<DescribeBatchResultDetail_BatchResultDetail> batchResultDetails;

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

		public long? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public long? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<DescribeBatchResultDetail_BatchResultDetail> BatchResultDetails
		{
			get
			{
				return batchResultDetails;
			}
			set	
			{
				batchResultDetails = value;
			}
		}

		public class DescribeBatchResultDetail_BatchResultDetail
		{

			private string domain;

			private string type;

			private string rr;

			private string _value;

			private bool? status;

			private string reason;

			private string newRr;

			private string newValue;

			private string batchType;

			private string operateDateStr;

			private string line;

			private string priority;

			private string ttl;

			private string recordId;

			private string remark;

			private string rrStatus;

			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
				}
			}

			public string Type
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

			public string Rr
			{
				get
				{
					return rr;
				}
				set	
				{
					rr = value;
				}
			}

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

			public bool? Status
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

			public string Reason
			{
				get
				{
					return reason;
				}
				set	
				{
					reason = value;
				}
			}

			public string NewRr
			{
				get
				{
					return newRr;
				}
				set	
				{
					newRr = value;
				}
			}

			public string NewValue
			{
				get
				{
					return newValue;
				}
				set	
				{
					newValue = value;
				}
			}

			public string BatchType
			{
				get
				{
					return batchType;
				}
				set	
				{
					batchType = value;
				}
			}

			public string OperateDateStr
			{
				get
				{
					return operateDateStr;
				}
				set	
				{
					operateDateStr = value;
				}
			}

			public string Line
			{
				get
				{
					return line;
				}
				set	
				{
					line = value;
				}
			}

			public string Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
				}
			}

			public string Ttl
			{
				get
				{
					return ttl;
				}
				set	
				{
					ttl = value;
				}
			}

			public string RecordId
			{
				get
				{
					return recordId;
				}
				set	
				{
					recordId = value;
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

			public string RrStatus
			{
				get
				{
					return rrStatus;
				}
				set	
				{
					rrStatus = value;
				}
			}
		}
	}
}
