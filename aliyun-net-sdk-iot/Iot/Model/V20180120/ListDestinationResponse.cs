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

namespace Aliyun.Acs.Iot.Model.V20180120
{
	public class ListDestinationResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private int? page;

		private int? pageSize;

		private int? total;

		private List<ListDestination_DestinationsItem> destinations;

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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public int? Page
		{
			get
			{
				return page;
			}
			set	
			{
				page = value;
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

		public List<ListDestination_DestinationsItem> Destinations
		{
			get
			{
				return destinations;
			}
			set	
			{
				destinations = value;
			}
		}

		public class ListDestination_DestinationsItem
		{

			private long? destinationId;

			private string name;

			private string type;

			private string configuration;

			private bool? isFailover;

			private string utcCreated;

			private string description;

			private string status;

			public long? DestinationId
			{
				get
				{
					return destinationId;
				}
				set	
				{
					destinationId = value;
				}
			}

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

			public string Configuration
			{
				get
				{
					return configuration;
				}
				set	
				{
					configuration = value;
				}
			}

			public bool? IsFailover
			{
				get
				{
					return isFailover;
				}
				set	
				{
					isFailover = value;
				}
			}

			public string UtcCreated
			{
				get
				{
					return utcCreated;
				}
				set	
				{
					utcCreated = value;
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
		}
	}
}
