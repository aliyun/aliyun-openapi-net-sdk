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

namespace Aliyun.Acs.vs.Model.V20181212
{
	public class CreateStreamSnapshotResponse : AcsResponse
	{

		private string requestId;

		private string id;

		private string url;

		private string ossBucket;

		private string ossObject;

		private string ossEndpoint;

		private long? height;

		private long? width;

		private string format;

		private long? timestamp;

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

		public string Id
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

		public string OssBucket
		{
			get
			{
				return ossBucket;
			}
			set	
			{
				ossBucket = value;
			}
		}

		public string OssObject
		{
			get
			{
				return ossObject;
			}
			set	
			{
				ossObject = value;
			}
		}

		public string OssEndpoint
		{
			get
			{
				return ossEndpoint;
			}
			set	
			{
				ossEndpoint = value;
			}
		}

		public long? Height
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

		public long? Width
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

		public long? Timestamp
		{
			get
			{
				return timestamp;
			}
			set	
			{
				timestamp = value;
			}
		}
	}
}
