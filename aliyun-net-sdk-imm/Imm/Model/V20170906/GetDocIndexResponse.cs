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

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class GetDocIndexResponse : AcsResponse
	{

		private string requestId;

		private string indexCreatedTime;

		private string indexModifiedTime;

		private string uniqueId;

		private string srcUri;

		private string name;

		private string contentType;

		private string lastModified;

		private long? size;

		private long? pageNum;

		private string customKey1;

		private string customKey2;

		private string customKey3;

		private string customKey4;

		private string customKey5;

		private string customKey6;

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

		public string IndexCreatedTime
		{
			get
			{
				return indexCreatedTime;
			}
			set	
			{
				indexCreatedTime = value;
			}
		}

		public string IndexModifiedTime
		{
			get
			{
				return indexModifiedTime;
			}
			set	
			{
				indexModifiedTime = value;
			}
		}

		public string UniqueId
		{
			get
			{
				return uniqueId;
			}
			set	
			{
				uniqueId = value;
			}
		}

		public string SrcUri
		{
			get
			{
				return srcUri;
			}
			set	
			{
				srcUri = value;
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

		public string ContentType
		{
			get
			{
				return contentType;
			}
			set	
			{
				contentType = value;
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

		public long? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
			}
		}

		public string CustomKey1
		{
			get
			{
				return customKey1;
			}
			set	
			{
				customKey1 = value;
			}
		}

		public string CustomKey2
		{
			get
			{
				return customKey2;
			}
			set	
			{
				customKey2 = value;
			}
		}

		public string CustomKey3
		{
			get
			{
				return customKey3;
			}
			set	
			{
				customKey3 = value;
			}
		}

		public string CustomKey4
		{
			get
			{
				return customKey4;
			}
			set	
			{
				customKey4 = value;
			}
		}

		public string CustomKey5
		{
			get
			{
				return customKey5;
			}
			set	
			{
				customKey5 = value;
			}
		}

		public string CustomKey6
		{
			get
			{
				return customKey6;
			}
			set	
			{
				customKey6 = value;
			}
		}
	}
}
