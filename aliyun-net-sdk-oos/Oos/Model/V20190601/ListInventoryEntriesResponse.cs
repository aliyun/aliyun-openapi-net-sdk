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
	public class ListInventoryEntriesResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private string schemaVersion;

		private int? maxResults;

		private string captureTime;

		private string typeName;

		private string instanceId;

		private List<Dictionary<string, string>> entries;

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

		[JsonProperty(PropertyName = "SchemaVersion")]
		public string SchemaVersion
		{
			get
			{
				return schemaVersion;
			}
			set	
			{
				schemaVersion = value;
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

		[JsonProperty(PropertyName = "CaptureTime")]
		public string CaptureTime
		{
			get
			{
				return captureTime;
			}
			set	
			{
				captureTime = value;
			}
		}

		[JsonProperty(PropertyName = "TypeName")]
		public string TypeName
		{
			get
			{
				return typeName;
			}
			set	
			{
				typeName = value;
			}
		}

		[JsonProperty(PropertyName = "InstanceId")]
		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
			}
		}

		[JsonProperty(PropertyName = "Entries")]
		public List<Dictionary<string, string>> Entries
		{
			get
			{
				return entries;
			}
			set	
			{
				entries = value;
			}
		}
	}
}
