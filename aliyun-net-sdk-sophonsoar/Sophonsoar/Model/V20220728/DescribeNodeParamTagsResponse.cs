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

namespace Aliyun.Acs.sophonsoar.Model.V20220728
{
	public class DescribeNodeParamTagsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeNodeParamTags_Data> paramReferredPaths;

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

		public List<DescribeNodeParamTags_Data> ParamReferredPaths
		{
			get
			{
				return paramReferredPaths;
			}
			set	
			{
				paramReferredPaths = value;
			}
		}

		public class DescribeNodeParamTags_Data
		{

			private string paramName;

			private List<string> referredPath;

			public string ParamName
			{
				get
				{
					return paramName;
				}
				set	
				{
					paramName = value;
				}
			}

			public List<string> ReferredPath
			{
				get
				{
					return referredPath;
				}
				set	
				{
					referredPath = value;
				}
			}
		}
	}
}
