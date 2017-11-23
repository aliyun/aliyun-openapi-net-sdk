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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudPhoto.Model.V20170711
{
	public class GetLibraryResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private string action;

		private GetLibrary_Library library;

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

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
			}
		}

		public GetLibrary_Library Library
		{
			get
			{
				return library;
			}
			set	
			{
				library = value;
			}
		}

		public class GetLibrary_Library
		{

			private GetLibrary_Quota quota;

			private GetLibrary_AutoCleanConfig autoCleanConfig;

			public GetLibrary_Quota Quota
			{
				get
				{
					return quota;
				}
				set	
				{
					quota = value;
				}
			}

			public GetLibrary_AutoCleanConfig AutoCleanConfig
			{
				get
				{
					return autoCleanConfig;
				}
				set	
				{
					autoCleanConfig = value;
				}
			}

			public class GetLibrary_Quota
			{

				private long? totalQuota;

				private int? facesCount;

				private int? photosCount;

				private long? usedQuota;

				private int? videosCount;

				public long? TotalQuota
				{
					get
					{
						return totalQuota;
					}
					set	
					{
						totalQuota = value;
					}
				}

				public int? FacesCount
				{
					get
					{
						return facesCount;
					}
					set	
					{
						facesCount = value;
					}
				}

				public int? PhotosCount
				{
					get
					{
						return photosCount;
					}
					set	
					{
						photosCount = value;
					}
				}

				public long? UsedQuota
				{
					get
					{
						return usedQuota;
					}
					set	
					{
						usedQuota = value;
					}
				}

				public int? VideosCount
				{
					get
					{
						return videosCount;
					}
					set	
					{
						videosCount = value;
					}
				}
			}

			public class GetLibrary_AutoCleanConfig
			{

				private bool? autoCleanEnabled;

				private int? autoCleanDays;

				public bool? AutoCleanEnabled
				{
					get
					{
						return autoCleanEnabled;
					}
					set	
					{
						autoCleanEnabled = value;
					}
				}

				public int? AutoCleanDays
				{
					get
					{
						return autoCleanDays;
					}
					set	
					{
						autoCleanDays = value;
					}
				}
			}
		}
	}
}