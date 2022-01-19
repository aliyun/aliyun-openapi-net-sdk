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

namespace Aliyun.Acs.cr.Model.V20160607
{
	public class GetRepoTagResponse : AcsResponse
	{

		private string requestId;

		private string status;

		private string tag;

		private string digest;

		private string imageId;

		private long? imageCreate;

		private long? imageUpdate;

		private long? imageSize;

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

		public string Tag
		{
			get
			{
				return tag;
			}
			set	
			{
				tag = value;
			}
		}

		public string Digest
		{
			get
			{
				return digest;
			}
			set	
			{
				digest = value;
			}
		}

		public string ImageId
		{
			get
			{
				return imageId;
			}
			set	
			{
				imageId = value;
			}
		}

		public long? ImageCreate
		{
			get
			{
				return imageCreate;
			}
			set	
			{
				imageCreate = value;
			}
		}

		public long? ImageUpdate
		{
			get
			{
				return imageUpdate;
			}
			set	
			{
				imageUpdate = value;
			}
		}

		public long? ImageSize
		{
			get
			{
				return imageSize;
			}
			set	
			{
				imageSize = value;
			}
		}
	}
}
