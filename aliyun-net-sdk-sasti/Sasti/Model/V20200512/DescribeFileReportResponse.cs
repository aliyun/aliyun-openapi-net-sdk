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

namespace Aliyun.Acs.Sasti.Model.V20200512
{
	public class DescribeFileReportResponse : AcsResponse
	{

		private string intelligences;

		private string requestId;

		private string fileHash;

		private string threatTypes;

		private string basic;

		private string threatLevel;

		private string sandbox;

		public string Intelligences
		{
			get
			{
				return intelligences;
			}
			set	
			{
				intelligences = value;
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

		public string FileHash
		{
			get
			{
				return fileHash;
			}
			set	
			{
				fileHash = value;
			}
		}

		public string ThreatTypes
		{
			get
			{
				return threatTypes;
			}
			set	
			{
				threatTypes = value;
			}
		}

		public string Basic
		{
			get
			{
				return basic;
			}
			set	
			{
				basic = value;
			}
		}

		public string ThreatLevel
		{
			get
			{
				return threatLevel;
			}
			set	
			{
				threatLevel = value;
			}
		}

		public string Sandbox
		{
			get
			{
				return sandbox;
			}
			set	
			{
				sandbox = value;
			}
		}
	}
}
