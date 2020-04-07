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

namespace Aliyun.Acs.companyreg.Model.V20190508
{
	public class ListBookkeepingSubjectBalancesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageSize;

		private int? pageNumber;

		private bool? success;

		private string errorMsg;

		private List<ListBookkeepingSubjectBalances_BookkeepingSubjectBalancesItem> bookkeepingSubjectBalances;

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

		public int? TotalCount
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

		public int? PageSize
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

		public int? PageNumber
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

		public List<ListBookkeepingSubjectBalances_BookkeepingSubjectBalancesItem> BookkeepingSubjectBalances
		{
			get
			{
				return bookkeepingSubjectBalances;
			}
			set	
			{
				bookkeepingSubjectBalances = value;
			}
		}

		public class ListBookkeepingSubjectBalances_BookkeepingSubjectBalancesItem
		{

			private string bizId;

			private string parentBizId;

			private string parentSubjectCode;

			private string subjectCode;

			private string subjectName;

			private float? startDebitValue;

			private float? startCreditValue;

			private float? currentDebitValue;

			private float? currentCreditValue;

			private float? endDebitValue;

			private float? endCreditValue;

			private float? yearDebitValue;

			private float? yearCreditValue;

			private string subjectLevel;

			public string BizId
			{
				get
				{
					return bizId;
				}
				set	
				{
					bizId = value;
				}
			}

			public string ParentBizId
			{
				get
				{
					return parentBizId;
				}
				set	
				{
					parentBizId = value;
				}
			}

			public string ParentSubjectCode
			{
				get
				{
					return parentSubjectCode;
				}
				set	
				{
					parentSubjectCode = value;
				}
			}

			public string SubjectCode
			{
				get
				{
					return subjectCode;
				}
				set	
				{
					subjectCode = value;
				}
			}

			public string SubjectName
			{
				get
				{
					return subjectName;
				}
				set	
				{
					subjectName = value;
				}
			}

			public float? StartDebitValue
			{
				get
				{
					return startDebitValue;
				}
				set	
				{
					startDebitValue = value;
				}
			}

			public float? StartCreditValue
			{
				get
				{
					return startCreditValue;
				}
				set	
				{
					startCreditValue = value;
				}
			}

			public float? CurrentDebitValue
			{
				get
				{
					return currentDebitValue;
				}
				set	
				{
					currentDebitValue = value;
				}
			}

			public float? CurrentCreditValue
			{
				get
				{
					return currentCreditValue;
				}
				set	
				{
					currentCreditValue = value;
				}
			}

			public float? EndDebitValue
			{
				get
				{
					return endDebitValue;
				}
				set	
				{
					endDebitValue = value;
				}
			}

			public float? EndCreditValue
			{
				get
				{
					return endCreditValue;
				}
				set	
				{
					endCreditValue = value;
				}
			}

			public float? YearDebitValue
			{
				get
				{
					return yearDebitValue;
				}
				set	
				{
					yearDebitValue = value;
				}
			}

			public float? YearCreditValue
			{
				get
				{
					return yearCreditValue;
				}
				set	
				{
					yearCreditValue = value;
				}
			}

			public string SubjectLevel
			{
				get
				{
					return subjectLevel;
				}
				set	
				{
					subjectLevel = value;
				}
			}
		}
	}
}
