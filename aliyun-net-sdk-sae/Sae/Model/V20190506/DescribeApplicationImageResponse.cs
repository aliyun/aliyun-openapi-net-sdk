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

namespace Aliyun.Acs.sae.Model.V20190506
{
	public class DescribeApplicationImageResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private bool? success;

		private string errorCode;

		private string traceId;

		private DescribeApplicationImage_Data data;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string TraceId
		{
			get
			{
				return traceId;
			}
			set	
			{
				traceId = value;
			}
		}

		public DescribeApplicationImage_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DescribeApplicationImage_Data
		{

			private string crUrl;

			private string logo;

			private string regionId;

			private int? repoId;

			private string repoName;

			private string repoNamespace;

			private string repoOriginType;

			private string repoType;

			private string repoTag;

			public string CrUrl
			{
				get
				{
					return crUrl;
				}
				set	
				{
					crUrl = value;
				}
			}

			public string Logo
			{
				get
				{
					return logo;
				}
				set	
				{
					logo = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public int? RepoId
			{
				get
				{
					return repoId;
				}
				set	
				{
					repoId = value;
				}
			}

			public string RepoName
			{
				get
				{
					return repoName;
				}
				set	
				{
					repoName = value;
				}
			}

			public string RepoNamespace
			{
				get
				{
					return repoNamespace;
				}
				set	
				{
					repoNamespace = value;
				}
			}

			public string RepoOriginType
			{
				get
				{
					return repoOriginType;
				}
				set	
				{
					repoOriginType = value;
				}
			}

			public string RepoType
			{
				get
				{
					return repoType;
				}
				set	
				{
					repoType = value;
				}
			}

			public string RepoTag
			{
				get
				{
					return repoTag;
				}
				set	
				{
					repoTag = value;
				}
			}
		}
	}
}
