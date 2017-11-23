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
	public class GetPhotoStoreResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private string action;

		private GetPhotoStore_PhotoStore photoStore;

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

		public GetPhotoStore_PhotoStore PhotoStore
		{
			get
			{
				return photoStore;
			}
			set	
			{
				photoStore = value;
			}
		}

		public class GetPhotoStore_PhotoStore
		{

			private long? id;

			private string name;

			private string remark;

			private bool? autoCleanEnabled;

			private int? autoCleanDays;

			private long? defaultQuota;

			private long? ctime;

			private long? mtime;

			private List<GetPhotoStore_Bucket> buckets;

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
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

			public long? DefaultQuota
			{
				get
				{
					return defaultQuota;
				}
				set	
				{
					defaultQuota = value;
				}
			}

			public long? Ctime
			{
				get
				{
					return ctime;
				}
				set	
				{
					ctime = value;
				}
			}

			public long? Mtime
			{
				get
				{
					return mtime;
				}
				set	
				{
					mtime = value;
				}
			}

			public List<GetPhotoStore_Bucket> Buckets
			{
				get
				{
					return buckets;
				}
				set	
				{
					buckets = value;
				}
			}

			public class GetPhotoStore_Bucket
			{

				private string name;

				private string region;

				private string state;

				private string acl;

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

				public string Region
				{
					get
					{
						return region;
					}
					set	
					{
						region = value;
					}
				}

				public string State
				{
					get
					{
						return state;
					}
					set	
					{
						state = value;
					}
				}

				public string Acl
				{
					get
					{
						return acl;
					}
					set	
					{
						acl = value;
					}
				}
			}
		}
	}
}