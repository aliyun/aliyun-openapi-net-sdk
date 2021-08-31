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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class GetServiceConsumersPageResponse : AcsResponse
	{

		private int? code;

		private string message;

		private bool? success;

		private GetServiceConsumersPage_Data data;

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

		public GetServiceConsumersPage_Data Data
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

		public class GetServiceConsumersPage_Data
		{

			private int? size;

			private int? totalElements;

			private int? totalPages;

			private List<GetServiceConsumersPage_Provider> content;

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

			public int? TotalElements
			{
				get
				{
					return totalElements;
				}
				set	
				{
					totalElements = value;
				}
			}

			public int? TotalPages
			{
				get
				{
					return totalPages;
				}
				set	
				{
					totalPages = value;
				}
			}

			public List<GetServiceConsumersPage_Provider> Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
				}
			}

			public class GetServiceConsumersPage_Provider
			{

				private string ip;

				private string edasAppName;

				private string edassAppId;

				public string Ip
				{
					get
					{
						return ip;
					}
					set	
					{
						ip = value;
					}
				}

				public string EdasAppName
				{
					get
					{
						return edasAppName;
					}
					set	
					{
						edasAppName = value;
					}
				}

				public string EdassAppId
				{
					get
					{
						return edassAppId;
					}
					set	
					{
						edassAppId = value;
					}
				}
			}
		}
	}
}
