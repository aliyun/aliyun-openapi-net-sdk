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

namespace Aliyun.Acs.NAS.Model.V20170626
{
	public class GetRecycleBinAttributeResponse : AcsResponse
	{

		private string requestId;

		private GetRecycleBinAttribute_RecycleBinAttribute recycleBinAttribute;

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

		public GetRecycleBinAttribute_RecycleBinAttribute RecycleBinAttribute
		{
			get
			{
				return recycleBinAttribute;
			}
			set	
			{
				recycleBinAttribute = value;
			}
		}

		public class GetRecycleBinAttribute_RecycleBinAttribute
		{

			private long? size;

			private long? secondarySize;

			private string status;

			private long? reservedDays;

			private string enableTime;

			private long? archiveSize;

			public long? Size
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

			public long? SecondarySize
			{
				get
				{
					return secondarySize;
				}
				set	
				{
					secondarySize = value;
				}
			}

			public string Status
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

			public long? ReservedDays
			{
				get
				{
					return reservedDays;
				}
				set	
				{
					reservedDays = value;
				}
			}

			public string EnableTime
			{
				get
				{
					return enableTime;
				}
				set	
				{
					enableTime = value;
				}
			}

			public long? ArchiveSize
			{
				get
				{
					return archiveSize;
				}
				set	
				{
					archiveSize = value;
				}
			}
		}
	}
}
