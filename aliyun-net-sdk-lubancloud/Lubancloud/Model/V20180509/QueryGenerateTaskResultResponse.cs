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

namespace Aliyun.Acs.lubancloud.Model.V20180509
{
	public class QueryGenerateTaskResultResponse : AcsResponse
	{

		private string requestId;

		private int? totalSize;

		private int? waitSize;

		private int? successSize;

		private int? failSize;

		private int? status;

		private List<QueryGenerateTaskResult_Picture> pictures;

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

		public int? TotalSize
		{
			get
			{
				return totalSize;
			}
			set	
			{
				totalSize = value;
			}
		}

		public int? WaitSize
		{
			get
			{
				return waitSize;
			}
			set	
			{
				waitSize = value;
			}
		}

		public int? SuccessSize
		{
			get
			{
				return successSize;
			}
			set	
			{
				successSize = value;
			}
		}

		public int? FailSize
		{
			get
			{
				return failSize;
			}
			set	
			{
				failSize = value;
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

		public List<QueryGenerateTaskResult_Picture> Pictures
		{
			get
			{
				return pictures;
			}
			set	
			{
				pictures = value;
			}
		}

		public class QueryGenerateTaskResult_Picture
		{

			private long? id;

			private string name;

			private string previewUrl;

			private int? width;

			private int? height;

			private int? status;

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

			public string PreviewUrl
			{
				get
				{
					return previewUrl;
				}
				set	
				{
					previewUrl = value;
				}
			}

			public int? Width
			{
				get
				{
					return width;
				}
				set	
				{
					width = value;
				}
			}

			public int? Height
			{
				get
				{
					return height;
				}
				set	
				{
					height = value;
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
		}
	}
}