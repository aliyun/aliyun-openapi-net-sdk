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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class UpdateMediaStorageClassResponse : AcsResponse
	{

		private string requestId;

		private string status;

		private List<UpdateMediaStorageClass_MediaForbiddenReasonDTO> forbiddenList;

		private List<string> ignoredList;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Status")]
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

		[JsonProperty(PropertyName = "ForbiddenList")]
		public List<UpdateMediaStorageClass_MediaForbiddenReasonDTO> ForbiddenList
		{
			get
			{
				return forbiddenList;
			}
			set	
			{
				forbiddenList = value;
			}
		}

		[JsonProperty(PropertyName = "IgnoredList")]
		public List<string> IgnoredList
		{
			get
			{
				return ignoredList;
			}
			set	
			{
				ignoredList = value;
			}
		}

		public class UpdateMediaStorageClass_MediaForbiddenReasonDTO
		{

			private string mediaId;

			private string reason;

			[JsonProperty(PropertyName = "MediaId")]
			public string MediaId
			{
				get
				{
					return mediaId;
				}
				set	
				{
					mediaId = value;
				}
			}

			[JsonProperty(PropertyName = "Reason")]
			public string Reason
			{
				get
				{
					return reason;
				}
				set	
				{
					reason = value;
				}
			}
		}
	}
}
