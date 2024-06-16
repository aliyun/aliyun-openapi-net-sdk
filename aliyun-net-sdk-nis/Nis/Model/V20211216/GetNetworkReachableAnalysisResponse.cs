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

namespace Aliyun.Acs.nis.Model.V20211216
{
	public class GetNetworkReachableAnalysisResponse : AcsResponse
	{

		private string networkPathId;

		private string networkReachableAnalysisId;

		private string networkReachableAnalysisStatus;

		private string networkReachableAnalysisResult;

		private bool? reachable;

		private string createTime;

		private long? aliUid;

		private string requestId;

		private string networkPathParameter;

		[JsonProperty(PropertyName = "NetworkPathId")]
		public string NetworkPathId
		{
			get
			{
				return networkPathId;
			}
			set	
			{
				networkPathId = value;
			}
		}

		[JsonProperty(PropertyName = "NetworkReachableAnalysisId")]
		public string NetworkReachableAnalysisId
		{
			get
			{
				return networkReachableAnalysisId;
			}
			set	
			{
				networkReachableAnalysisId = value;
			}
		}

		[JsonProperty(PropertyName = "NetworkReachableAnalysisStatus")]
		public string NetworkReachableAnalysisStatus
		{
			get
			{
				return networkReachableAnalysisStatus;
			}
			set	
			{
				networkReachableAnalysisStatus = value;
			}
		}

		[JsonProperty(PropertyName = "NetworkReachableAnalysisResult")]
		public string NetworkReachableAnalysisResult
		{
			get
			{
				return networkReachableAnalysisResult;
			}
			set	
			{
				networkReachableAnalysisResult = value;
			}
		}

		[JsonProperty(PropertyName = "Reachable")]
		public bool? Reachable
		{
			get
			{
				return reachable;
			}
			set	
			{
				reachable = value;
			}
		}

		[JsonProperty(PropertyName = "CreateTime")]
		public string CreateTime
		{
			get
			{
				return createTime;
			}
			set	
			{
				createTime = value;
			}
		}

		[JsonProperty(PropertyName = "AliUid")]
		public long? AliUid
		{
			get
			{
				return aliUid;
			}
			set	
			{
				aliUid = value;
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

		[JsonProperty(PropertyName = "NetworkPathParameter")]
		public string NetworkPathParameter
		{
			get
			{
				return networkPathParameter;
			}
			set	
			{
				networkPathParameter = value;
			}
		}
	}
}
