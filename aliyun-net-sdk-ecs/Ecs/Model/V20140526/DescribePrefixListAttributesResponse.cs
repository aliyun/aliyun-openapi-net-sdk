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
	public class DescribePrefixListAttributesResponse : AcsResponse
	{

		private string creationTime;

		private int? maxEntries;

		private string requestId;

		private string description;

		private string addressFamily;

		private string prefixListName;

		private string prefixListId;

		private List<DescribePrefixListAttributes_Entry> entries;

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

		public int? MaxEntries
		{
			get
			{
				return maxEntries;
			}
			set	
			{
				maxEntries = value;
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

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
			}
		}

		public string AddressFamily
		{
			get
			{
				return addressFamily;
			}
			set	
			{
				addressFamily = value;
			}
		}

		public string PrefixListName
		{
			get
			{
				return prefixListName;
			}
			set	
			{
				prefixListName = value;
			}
		}

		public string PrefixListId
		{
			get
			{
				return prefixListId;
			}
			set	
			{
				prefixListId = value;
			}
		}

		public List<DescribePrefixListAttributes_Entry> Entries
		{
			get
			{
				return entries;
			}
			set	
			{
				entries = value;
			}
		}

		public class DescribePrefixListAttributes_Entry
		{

			private string description;

			private string cidr;

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string Cidr
			{
				get
				{
					return cidr;
				}
				set	
				{
					cidr = value;
				}
			}
		}
	}
}
