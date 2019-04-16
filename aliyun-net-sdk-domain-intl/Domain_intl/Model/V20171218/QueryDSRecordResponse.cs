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

namespace Aliyun.Acs.Domain_intl.Model.V20171218
{
	public class QueryDSRecordResponse : AcsResponse
	{

		private string requestId;

		private List<QueryDSRecord_DSRecord> dSRecordList;

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

		public List<QueryDSRecord_DSRecord> DSRecordList
		{
			get
			{
				return dSRecordList;
			}
			set	
			{
				dSRecordList = value;
			}
		}

		public class QueryDSRecord_DSRecord
		{

			private int? keyTag;

			private int? algorithm;

			private int? digestType;

			private string digest;

			public int? KeyTag
			{
				get
				{
					return keyTag;
				}
				set	
				{
					keyTag = value;
				}
			}

			public int? Algorithm
			{
				get
				{
					return algorithm;
				}
				set	
				{
					algorithm = value;
				}
			}

			public int? DigestType
			{
				get
				{
					return digestType;
				}
				set	
				{
					digestType = value;
				}
			}

			public string Digest
			{
				get
				{
					return digest;
				}
				set	
				{
					digest = value;
				}
			}
		}
	}
}
