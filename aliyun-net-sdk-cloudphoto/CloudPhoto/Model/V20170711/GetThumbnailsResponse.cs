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

namespace Aliyun.Acs.CloudPhoto.Model.V20170711
{
	public class GetThumbnailsResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private string action;

		private List<GetThumbnails_Result> results;

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

		public List<GetThumbnails_Result> Results
		{
			get
			{
				return results;
			}
			set	
			{
				results = value;
			}
		}

		public class GetThumbnails_Result
		{

			private string code;

			private string message;

			private long? photoId;

			private string photoIdStr;

			private string thumbnailUrl;

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

			public long? PhotoId
			{
				get
				{
					return photoId;
				}
				set	
				{
					photoId = value;
				}
			}

			public string PhotoIdStr
			{
				get
				{
					return photoIdStr;
				}
				set	
				{
					photoIdStr = value;
				}
			}

			public string ThumbnailUrl
			{
				get
				{
					return thumbnailUrl;
				}
				set	
				{
					thumbnailUrl = value;
				}
			}
		}
	}
}
