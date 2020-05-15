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
	public class QueryEdgeInstanceChannelResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private QueryEdgeInstanceChannel_Data data;

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

		public QueryEdgeInstanceChannel_Data Data
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

		public class QueryEdgeInstanceChannel_Data
		{

			private int? total;

			private int? pageSize;

			private int? currentPage;

			private List<QueryEdgeInstanceChannel_Channel> channelList;

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

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
				}
			}

			public List<QueryEdgeInstanceChannel_Channel> ChannelList
			{
				get
				{
					return channelList;
				}
				set	
				{
					channelList = value;
				}
			}

			public class QueryEdgeInstanceChannel_Channel
			{

				private string channelId;

				private string channelName;

				private string gmtCreate;

				private string gmtModified;

				private long? gmtCreateTimestamp;

				private long? gmtModifiedTimestamp;

				private List<QueryEdgeInstanceChannel_Config> configList;

				public string ChannelId
				{
					get
					{
						return channelId;
					}
					set	
					{
						channelId = value;
					}
				}

				public string ChannelName
				{
					get
					{
						return channelName;
					}
					set	
					{
						channelName = value;
					}
				}

				public string GmtCreate
				{
					get
					{
						return gmtCreate;
					}
					set	
					{
						gmtCreate = value;
					}
				}

				public string GmtModified
				{
					get
					{
						return gmtModified;
					}
					set	
					{
						gmtModified = value;
					}
				}

				public long? GmtCreateTimestamp
				{
					get
					{
						return gmtCreateTimestamp;
					}
					set	
					{
						gmtCreateTimestamp = value;
					}
				}

				public long? GmtModifiedTimestamp
				{
					get
					{
						return gmtModifiedTimestamp;
					}
					set	
					{
						gmtModifiedTimestamp = value;
					}
				}

				public List<QueryEdgeInstanceChannel_Config> ConfigList
				{
					get
					{
						return configList;
					}
					set	
					{
						configList = value;
					}
				}

				public class QueryEdgeInstanceChannel_Config
				{

					private string configId;

					private string format;

					private string content;

					private string key;

					public string ConfigId
					{
						get
						{
							return configId;
						}
						set	
						{
							configId = value;
						}
					}

					public string Format
					{
						get
						{
							return format;
						}
						set	
						{
							format = value;
						}
					}

					public string Content
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

					public string Key
					{
						get
						{
							return key;
						}
						set	
						{
							key = value;
						}
					}
				}
			}
		}
	}
}
