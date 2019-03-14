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

namespace Aliyun.Acs.MoPen.Model.V20180211
{
	public class MoPenQueryCanvasResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private bool? success;

		private string description;

		private MoPenQueryCanvas_Data data;

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

		public MoPenQueryCanvas_Data Data
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

		public class MoPenQueryCanvas_Data
		{

			private List<MoPenQueryCanvas_Canvas> canvasList;

			public List<MoPenQueryCanvas_Canvas> CanvasList
			{
				get
				{
					return canvasList;
				}
				set	
				{
					canvasList = value;
				}
			}

			public class MoPenQueryCanvas_Canvas
			{

				private long? id;

				private string deviceName;

				private string url;

				private int? pageId;

				private string sessionId;

				private string createTime;

				private string lastModified;

				private int? status;

				private string attribute;

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

				public string DeviceName
				{
					get
					{
						return deviceName;
					}
					set	
					{
						deviceName = value;
					}
				}

				public string Url
				{
					get
					{
						return url;
					}
					set	
					{
						url = value;
					}
				}

				public int? PageId
				{
					get
					{
						return pageId;
					}
					set	
					{
						pageId = value;
					}
				}

				public string SessionId
				{
					get
					{
						return sessionId;
					}
					set	
					{
						sessionId = value;
					}
				}

				public string CreateTime
				{
					get
					{
						return createTime;
					}
					set	
					{
						createTime = value;
					}
				}

				public string LastModified
				{
					get
					{
						return lastModified;
					}
					set	
					{
						lastModified = value;
					}
				}

				public int? Status
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

				public string Attribute
				{
					get
					{
						return attribute;
					}
					set	
					{
						attribute = value;
					}
				}
			}
		}
	}
}
