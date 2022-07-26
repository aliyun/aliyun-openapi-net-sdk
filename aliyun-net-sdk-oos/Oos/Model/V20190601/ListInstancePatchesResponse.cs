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

namespace Aliyun.Acs.oos.Model.V20190601
{
	public class ListInstancePatchesResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private int? maxResults;

		private List<ListInstancePatches_Patch> patches;

		[JsonProperty(PropertyName = "NextToken")]
		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

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

		[JsonProperty(PropertyName = "MaxResults")]
		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		[JsonProperty(PropertyName = "Patches")]
		public List<ListInstancePatches_Patch> Patches
		{
			get
			{
				return patches;
			}
			set	
			{
				patches = value;
			}
		}

		public class ListInstancePatches_Patch
		{

			private string severity;

			private string status;

			private string installedTime;

			private string kBId;

			private string title;

			private string classification;

			[JsonProperty(PropertyName = "Severity")]
			public string Severity
			{
				get
				{
					return severity;
				}
				set	
				{
					severity = value;
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

			[JsonProperty(PropertyName = "InstalledTime")]
			public string InstalledTime
			{
				get
				{
					return installedTime;
				}
				set	
				{
					installedTime = value;
				}
			}

			[JsonProperty(PropertyName = "KBId")]
			public string KBId
			{
				get
				{
					return kBId;
				}
				set	
				{
					kBId = value;
				}
			}

			[JsonProperty(PropertyName = "Title")]
			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}

			[JsonProperty(PropertyName = "Classification")]
			public string Classification
			{
				get
				{
					return classification;
				}
				set	
				{
					classification = value;
				}
			}
		}
	}
}
