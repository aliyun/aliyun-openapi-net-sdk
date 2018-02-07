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

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeVulDetailsResponse : AcsResponse
	{

		private string requestId;

		private string name;

		private string aliasName;

		private string level;

		private long? vulPublishTs;

		private string type;

		private string product;

		private bool? hasPatch;

		private long? patchPublishTs;

		private string patchSource;

		private string cvss;

		private string cveIds;

		private string advice;

		private string description;

		private int? pendingCount;

		private int? handledCount;

		private List<string> cveLists;

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

		public string AliasName
		{
			get
			{
				return aliasName;
			}
			set	
			{
				aliasName = value;
			}
		}

		public string Level
		{
			get
			{
				return level;
			}
			set	
			{
				level = value;
			}
		}

		public long? VulPublishTs
		{
			get
			{
				return vulPublishTs;
			}
			set	
			{
				vulPublishTs = value;
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
			}
		}

		public string Product
		{
			get
			{
				return product;
			}
			set	
			{
				product = value;
			}
		}

		public bool? HasPatch
		{
			get
			{
				return hasPatch;
			}
			set	
			{
				hasPatch = value;
			}
		}

		public long? PatchPublishTs
		{
			get
			{
				return patchPublishTs;
			}
			set	
			{
				patchPublishTs = value;
			}
		}

		public string PatchSource
		{
			get
			{
				return patchSource;
			}
			set	
			{
				patchSource = value;
			}
		}

		public string Cvss
		{
			get
			{
				return cvss;
			}
			set	
			{
				cvss = value;
			}
		}

		public string CveIds
		{
			get
			{
				return cveIds;
			}
			set	
			{
				cveIds = value;
			}
		}

		public string Advice
		{
			get
			{
				return advice;
			}
			set	
			{
				advice = value;
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

		public int? PendingCount
		{
			get
			{
				return pendingCount;
			}
			set	
			{
				pendingCount = value;
			}
		}

		public int? HandledCount
		{
			get
			{
				return handledCount;
			}
			set	
			{
				handledCount = value;
			}
		}

		public List<string> CveLists
		{
			get
			{
				return cveLists;
			}
			set	
			{
				cveLists = value;
			}
		}
	}
}