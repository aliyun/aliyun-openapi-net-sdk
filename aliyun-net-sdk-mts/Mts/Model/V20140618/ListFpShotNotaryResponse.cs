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

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class ListFpShotNotaryResponse : AcsResponse
	{

		private string requestId;

		private string nextPageToken;

		private List<ListFpShotNotary_FpShotNotary> fpShotNotaryList;

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

		public string NextPageToken
		{
			get
			{
				return nextPageToken;
			}
			set	
			{
				nextPageToken = value;
			}
		}

		public List<ListFpShotNotary_FpShotNotary> FpShotNotaryList
		{
			get
			{
				return fpShotNotaryList;
			}
			set	
			{
				fpShotNotaryList = value;
			}
		}

		public class ListFpShotNotary_FpShotNotary
		{

			private string transactionId;

			private string txHash;

			private string fpDBId;

			private string jobId;

			private string detail;

			private string creationTime;

			private string finishTime;

			public string TransactionId
			{
				get
				{
					return transactionId;
				}
				set	
				{
					transactionId = value;
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

			public string FpDBId
			{
				get
				{
					return fpDBId;
				}
				set	
				{
					fpDBId = value;
				}
			}

			public string JobId
			{
				get
				{
					return jobId;
				}
				set	
				{
					jobId = value;
				}
			}

			public string Detail
			{
				get
				{
					return detail;
				}
				set	
				{
					detail = value;
				}
			}

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string FinishTime
			{
				get
				{
					return finishTime;
				}
				set	
				{
					finishTime = value;
				}
			}
		}
	}
}
