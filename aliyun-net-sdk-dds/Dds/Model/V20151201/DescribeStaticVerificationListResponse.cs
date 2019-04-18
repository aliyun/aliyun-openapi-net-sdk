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

namespace Aliyun.Acs.Dds.Model.V20151201
{
	public class DescribeStaticVerificationListResponse : AcsResponse
	{

		private string requestId;

		private string replicaId;

		private string sourceInstanceId;

		private int? sourceDBNumber;

		private int? sourceTableNumber;

		private int? sourceCountNumber;

		private int? sourceDBSize;

		private string destinationInstanceId;

		private int? destinationDBNumber;

		private int? destinationTableNumber;

		private int? destinationCountNumber;

		private int? destinationDBSize;

		private string consistencyPercent;

		private List<DescribeStaticVerificationList_ItemsItem> items;

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

		public string ReplicaId
		{
			get
			{
				return replicaId;
			}
			set	
			{
				replicaId = value;
			}
		}

		public string SourceInstanceId
		{
			get
			{
				return sourceInstanceId;
			}
			set	
			{
				sourceInstanceId = value;
			}
		}

		public int? SourceDBNumber
		{
			get
			{
				return sourceDBNumber;
			}
			set	
			{
				sourceDBNumber = value;
			}
		}

		public int? SourceTableNumber
		{
			get
			{
				return sourceTableNumber;
			}
			set	
			{
				sourceTableNumber = value;
			}
		}

		public int? SourceCountNumber
		{
			get
			{
				return sourceCountNumber;
			}
			set	
			{
				sourceCountNumber = value;
			}
		}

		public int? SourceDBSize
		{
			get
			{
				return sourceDBSize;
			}
			set	
			{
				sourceDBSize = value;
			}
		}

		public string DestinationInstanceId
		{
			get
			{
				return destinationInstanceId;
			}
			set	
			{
				destinationInstanceId = value;
			}
		}

		public int? DestinationDBNumber
		{
			get
			{
				return destinationDBNumber;
			}
			set	
			{
				destinationDBNumber = value;
			}
		}

		public int? DestinationTableNumber
		{
			get
			{
				return destinationTableNumber;
			}
			set	
			{
				destinationTableNumber = value;
			}
		}

		public int? DestinationCountNumber
		{
			get
			{
				return destinationCountNumber;
			}
			set	
			{
				destinationCountNumber = value;
			}
		}

		public int? DestinationDBSize
		{
			get
			{
				return destinationDBSize;
			}
			set	
			{
				destinationDBSize = value;
			}
		}

		public string ConsistencyPercent
		{
			get
			{
				return consistencyPercent;
			}
			set	
			{
				consistencyPercent = value;
			}
		}

		public List<DescribeStaticVerificationList_ItemsItem> Items
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

		public class DescribeStaticVerificationList_ItemsItem
		{

			private string abnormalType;

			private string sourceDetail;

			private string destinationDetail;

			public string AbnormalType
			{
				get
				{
					return abnormalType;
				}
				set	
				{
					abnormalType = value;
				}
			}

			public string SourceDetail
			{
				get
				{
					return sourceDetail;
				}
				set	
				{
					sourceDetail = value;
				}
			}

			public string DestinationDetail
			{
				get
				{
					return destinationDetail;
				}
				set	
				{
					destinationDetail = value;
				}
			}
		}
	}
}
